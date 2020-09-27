using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CLEditor.Editor;
using CLEditor.Forms;
using CLEditor.Properties;
using CLEditor.Utils;
using CLEditor.Views;
using DarkUI.Docking;
using DarkUI.Forms;
using DarkUI.Win32;
using DynamicData;
using DynamicData.Kernel;

#pragma warning disable 8618

namespace CLEditor
{
	public partial class MainForm : DarkForm
    {
        private SourceList<DarkDockContent> _toolWindows = new SourceList<DarkDockContent>();
        internal LoggerView _loggerView;
        internal ProjectView _projectView;
        // internal NodeView _nodeView;
        internal SceneView _sceneView;

        public static MainForm Instance;

        public MainForm()
        {
	        Instance = this;
			InitializeComponent();
            // 添加控件滚动消息过滤器，以将所有鼠标滚轮事件重新路由到用户当前鼠标悬停在其上的控件
            Application.AddMessageFilter(new ControlScrollFilter());
            // 添加dock内容拖拽消息过滤器来处理移动dock内容。
            Application.AddMessageFilter(mainDockPanel.DockContentDragFilter);
            // 添加停靠面板消息过滤器，以便在让事件传递到应用程序的其余部分之前对停靠面板拆分器输入进行筛选。
            Application.AddMessageFilter(mainDockPanel.DockResizeFilter);

            HookEvents();

            // 构建工具窗口并将其添加到dock面板中
            _loggerView = new LoggerView();
			_projectView = new ProjectView();
			// _nodeView = new NodeView();
			_sceneView = new SceneView();

			// 将工具窗口添加到列表中
			_toolWindows.Add(_loggerView);
			_toolWindows.Add(_projectView);
			// _toolWindows.Add(_nodeView);
			_toolWindows.Add(_sceneView);

            // 如果存储了以前的状态，则反序列化
            if (File.Exists(Settings.Default.DOCKPANELCONFIG))
            {
                DeserializeDockPanel(Settings.Default.DOCKPANELCONFIG);
            }
            else
            {
                // 使用并行化将工具窗口列表内容添加到停靠面板
                _toolWindows.Items.AsList().ForEach(toolWindow =>
                {
                    mainDockPanel.AddContent(toolWindow);
                });
            }

            // 检查停靠面板中包含的窗口菜单项
            BuildWindowMenu();

            Text = Resources.MainForm_Title + string.Format(Resources.MainForm_Version, Application.ProductVersion);
			WindowState = FormWindowState.Maximized;
        }

        private void HookEvents()
        {
            FormClosing += OnFormClosing;

            mainDockPanel.ContentAdded += MainDockPanelOnContentAdded;
            mainDockPanel.ContentRemoved += MainDockPanelOnContentRemoved;

            loadProjectStrip.Click += LoadProjectStripOnClick;
			createProjectStrip.Click += NewProjectOnClick;
            menuLogger.Click += MenuLoggerOnClick;
			menuProject.Click += MenuProjectOnClick;
			// menuNode.Click += MenuNodeOnClick;
			menuScene.Click += MenuSceneOnClick;
			settingStrip.Click += SettingStripOnClick;
        }

        private void MenuSceneOnClick(object sender, EventArgs e)
        {
	        ToggleToolWindow(_sceneView);
        }

        private void SettingStripOnClick(object sender, EventArgs e)
        {
	        new SettingForm().ShowDialog();
        }

        // private void MenuNodeOnClick(object sender, EventArgs e)
        // {
	       //  ToggleToolWindow(_nodeView);
        // }

        private void MenuProjectOnClick(object sender, EventArgs e)
        {
	        ToggleToolWindow(_projectView);
        }

        private void MenuLoggerOnClick(object sender, EventArgs e)
        {
            ToggleToolWindow(_loggerView);
        }

        private void MainDockPanelOnContentRemoved(object sender, DockContentEventArgs e)
        {
            if (_toolWindows.Items.Contains(e.Content))
                BuildWindowMenu();
        }

        private void MainDockPanelOnContentAdded(object sender, DockContentEventArgs e)
        {
            if (_toolWindows.Items.Contains(e.Content))
                BuildWindowMenu();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeDockPanel(Settings.Default.DOCKPANELCONFIG);
        }

        private void NewProjectOnClick(object sender, EventArgs e)
        {
            var newProjectForm = new NewProjectForm();
			if (newProjectForm.ShowDialog() == DialogResult.Yes)
			{
				// 创建完成
				CoreEditor.LoadProject(newProjectForm.Info);
			}
		}

        private void LoadProjectStripOnClick(object sender, EventArgs e)
        {
	        var folderBrowser = new FolderBrowserDialog();
	        if (folderBrowser.ShowDialog() == DialogResult.OK)
	        {
		        if (!Directory.Exists(folderBrowser.SelectedPath)) return;
		        if (!File.Exists(Path.Combine(folderBrowser.SelectedPath, Settings.Default.PROJECTCONFIG)))
		        {
					Log.Error("项目不存在，请重新创建");
			        return;
		        }

		        try
		        {
			        var info = SerializerHelper.Deserialize<ProjectInfo>(Path.Combine(folderBrowser.SelectedPath,
				        Settings.Default.PROJECTCONFIG));
			        CoreEditor.LoadProject(info);
					Log.Info("加载项目成功");
				}
		        catch (Exception exception)
		        {
			        Log.Error("加载项目失败:" + exception.Message);
		        }
	        }
        }

		private void BuildWindowMenu()
        {
            menuLogger.Checked = mainDockPanel.ContainsContent(_loggerView);
            menuProject.Checked = mainDockPanel.ContainsContent(_projectView);
			// menuNode.Checked = mainDockPanel.ContainsContent(_nodeView);
			menuScene.Checked = mainDockPanel.ContainsContent(_sceneView);
        }

        private void ToggleToolWindow(DarkDockContent toolWindow)
        {
            if (toolWindow.DockPanel == null) 
                mainDockPanel.AddContent(toolWindow);
            else
                mainDockPanel.RemoveContent(toolWindow);
        }

        private void SerializeDockPanel(string path)
        {
            var state = mainDockPanel.GetDockPanelState();
            SerializerHelper.Serialize(state, path);
        }

        private void DeserializeDockPanel(string path)
        {
	        try
	        {
		        var state = SerializerHelper.Deserialize<DockPanelState>(path);
		        mainDockPanel.RestoreDockPanelState(state, GetContentBySerializationKey);
	        }
	        catch (Exception e)
	        {
		        _toolWindows.Items.AsList().ForEach(toolWindow =>
		        {
			        mainDockPanel.AddContent(toolWindow);
		        });
		        Log.Error("序列化dockPanel失败:" + e.Message);
	        }
            
        }

        private DarkDockContent GetContentBySerializationKey(string key)
        {
            return _toolWindows.Items.First(item => item.SerializationKey == key);
        }


        public sealed override string Text
		{
			get => base.Text;
			set => base.Text = value;
		}
	}
}
