using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CLEditor.Editor;
using CLEditor.Forms;
using CLEditor.Properties;
using CLEditor.Utils;
using DarkUI.Controls;
using DarkUI.Docking;

namespace CLEditor.Views
{
	internal delegate void UpdateNodeDelegate(DarkTreeNode node, DarkTreeNode rootNode = null);
	internal delegate void ClearNodeDelgate();

	public partial class ProjectView : DarkToolWindow
	{
		private DarkContextMenu _contextMenu;
		private FileSystemWatcher _fileSystemWatcher;
		private bool _toggle = false;

		public ProjectView()
		{
			InitializeComponent();

			_contextMenu = new DarkContextMenu();
			projectList.ContextMenuStrip = _contextMenu;
			projectList.AllowMoveNodes = false;
			projectList.MultiSelect = false;
			InitContextMenu();
			
			_contextMenu.Opening += ContextMenuOnOpening;
			projectList.DoubleClick += ProjectListOnDoubleClick;
			projectList.SelectedNodesChanged += ProjectListOnSelectedNodesChanged;
			Resize += OnResize;
			TogglePreview(false);
		}

		private void InitContextMenu()
		{
			var createDirMenu = new ToolStripMenuItem("创建文件夹");
			createDirMenu.Click += CreateDirMenuOnClick;
			_contextMenu.Items.Add(createDirMenu);
		}
		
		private void ContextMenuOnOpening(object sender, CancelEventArgs e)
		{
			var nodes = projectList.SelectedNodes;
			if (nodes.Count <= 0)
			{
				e.Cancel = true;
				return;
			}

			var firstNode = nodes.First();
			if (firstNode == null)
				e.Cancel = true;
		}
		
		private void CreateDirMenuOnClick(object sender, EventArgs e)
		{
			new NewDirectoryForm().ShowDialog();
		}

		private void OnResize(object sender, EventArgs e)
		{
			TogglePreview(this._toggle);
		}

		private void ProjectListOnSelectedNodesChanged(object sender, EventArgs e)
		{
			var nodes = projectList.SelectedNodes;
			if (nodes.Count <= 0) 
				return;
			
			var firstNode = nodes.First();
			if (firstNode == null) 
				return;

			if (!(firstNode.Tag is FileInfo fileInfo) || fileInfo.Attributes == FileAttributes.Directory) 
				return;
			
			var extension = fileInfo.Extension.ToLower();
			if (extension == ".png" || extension == ".jpg")
			{
				previewBox.Image = Image.FromFile(fileInfo.FullName);
				TogglePreview(true);
			}
			else
			{
				TogglePreview(false);
			}
		}

		private void TogglePreview(bool visible)
		{
			_toggle = visible;
			if (visible)
			{
				previewPanel.Size = new Size(previewPanel.Size.Width, 216);
				projectList.Size = new Size(projectList.Size.Width, Height - 32 - previewPanel.Height);
				previewPanel.Location = new Point(previewPanel.Location.X, Height - 216);
			}
			else
			{
				previewPanel.Size = new Size(previewPanel.Size.Width, 30);
				projectList.Size = new Size(projectList.Size.Width, Height - 32 - previewPanel.Height);
				previewPanel.Location = new Point(previewPanel.Location.X, Height - 32);
			}
		}

		private void ProjectListOnDoubleClick(object sender, EventArgs e)
		{
			var nodes = projectList.SelectedNodes;
			if (nodes.Count <= 0) 
				return;
			var firstNode = nodes.First();

			if (firstNode != null)
			{
			}
		}

		public void LoadProject(ProjectInfo info)
		{
			if (!Directory.Exists(info.Path)) return;

			_fileSystemWatcher = new FileSystemWatcher(info.Path);
			_fileSystemWatcher.Created += FileSystemWatcherOnChanged;
			_fileSystemWatcher.Deleted += FileSystemWatcherOnChanged;
			_fileSystemWatcher.Renamed += FileSystemWatcherOnChanged;
			_fileSystemWatcher.Error += FileSystemWatcherOnError;
			_fileSystemWatcher.EnableRaisingEvents = true;

			UpdateDirectory(info.Path);
		}

		private void FileSystemWatcherOnError(object sender, ErrorEventArgs e)
		{
			Log.Error("文件系统发生错误:" + e.GetException().Message);
		}

		private void FileSystemWatcherOnChanged(object sender, FileSystemEventArgs e)
		{
			projectList.BeginInvoke(new ClearNodeDelgate(ClearNode));

			UpdateDirectory(_fileSystemWatcher.Path);
		}

		private void UpdateDirectory(string directory, DarkTreeNode rootNode = null)
		{
			var files = Directory.GetFileSystemEntries(directory);
			var fileList = files.Select(file => new FileInfo(file)).ToList();
			fileList.Sort((a, b) =>
			{
				if (a.Attributes == b.Attributes) return 0;
				if (a.Attributes == FileAttributes.Directory) return -1;
				if (b.Attributes == FileAttributes.Directory) return 1;

				return 0;
			});

			foreach (var file in fileList)
			{
				var node = new DarkTreeNode(file.Name) { Tag = file };
				if (file.Attributes == FileAttributes.Directory)
				{
					node.Icon = Icons.folder_close;
					node.ExpandedIcon = Icons.folder_open;
					UpdateDirectory(file.FullName, node);
				}
				else
				{
					node.Icon = Icons.file;
				}

				projectList.BeginInvoke(new UpdateNodeDelegate(UpdateNode), node, rootNode);
			}
		}

		private void ClearNode()
		{
			projectList.Nodes.Clear();
		}

		private void UpdateNode(DarkTreeNode node, DarkTreeNode rootNode = null)
		{
			if (rootNode == null )
				projectList.Nodes.Add(node);
			else
				rootNode.Nodes.Add(node);
		}
	}
}
