using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CLEditor.Properties;
using CLEditor.Utils;
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
        private LoggerView _loggerView;

        public MainForm()
		{
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

            // 将工具窗口添加到列表中
            _toolWindows.Add(_loggerView);

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

            createProjectStrip.Click += NewProjectOnClick;
            menuLogger.Click += MenuLoggerOnClick;
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
				
			}
		}

        private void BuildWindowMenu()
        {
            menuLogger.Checked = mainDockPanel.ContainsContent(_loggerView);
        }

        private void ToggleToolWindow(DarkToolWindow toolWindow)
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
            var state = SerializerHelper.Deserialize<DockPanelState>(path);
            mainDockPanel.RestoreDockPanelState(state, GetContentBySerializationKey);
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
