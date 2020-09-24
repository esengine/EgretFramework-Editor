using System;
using System.Collections.Generic;
using System.IO;
using CLEditor.Editor;
using CLEditor.Properties;
using CLEditor.Utils;
using DarkUI.Controls;
using DarkUI.Docking;

namespace CLEditor.Views
{
	internal delegate void UpdateNodeDelegate(DarkTreeNode node);
	internal delegate void ClearNodeDelgate();

	public partial class ProjectView : DarkToolWindow
	{
		private FileSystemWatcher _fileSystemWatcher;
		private readonly List<FileInfo> fileList = new List<FileInfo>();

		public ProjectView()
		{
			InitializeComponent();
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

			UpdateDirectory();
		}

		private void FileSystemWatcherOnError(object sender, ErrorEventArgs e)
		{
			Log.Error("文件系统发生错误:" + e.GetException().Message);
		}

		private void FileSystemWatcherOnChanged(object sender, FileSystemEventArgs e)
		{
			UpdateDirectory();
		}

		private void UpdateDirectory()
		{
			fileList.Clear();
			projectList.BeginInvoke(new ClearNodeDelgate(ClearNode));

			var files = Directory.GetFileSystemEntries(CoreEditor.Info.Path);
			foreach (var file in files)
			{
				fileList.Add(new FileInfo(file));
			}
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
				}
				else
				{
					node.Icon = Icons.file;
				}

				projectList.BeginInvoke(new UpdateNodeDelegate(UpdateNode), node);
			}
		}

		private void ClearNode()
		{
			projectList.Nodes.Clear();
		}

		private void UpdateNode(DarkTreeNode node)
		{
			projectList.Nodes.Add(node);
		}
	}
}
