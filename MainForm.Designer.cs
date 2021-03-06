﻿namespace CLEditor
{
	partial class MainForm
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.darkMenuStrip1 = new DarkUI.Controls.DarkMenuStrip();
			this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.createProjectStrip = new System.Windows.Forms.ToolStripMenuItem();
			this.loadProjectStrip = new System.Windows.Forms.ToolStripMenuItem();
			this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingStrip = new System.Windows.Forms.ToolStripMenuItem();
			this.窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuLogger = new System.Windows.Forms.ToolStripMenuItem();
			this.menuProject = new System.Windows.Forms.ToolStripMenuItem();
			this.darkStatusStrip1 = new DarkUI.Controls.DarkStatusStrip();
			this.mainDockPanel = new DarkUI.Docking.DarkDockPanel();
			this.menuScene = new System.Windows.Forms.ToolStripMenuItem();
			this.darkMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// darkMenuStrip1
			// 
			this.darkMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (60)))), ((int) (((byte) (63)))), ((int) (((byte) (65)))));
			this.darkMenuStrip1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (220)))), ((int) (((byte) (220)))));
			this.darkMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.文件ToolStripMenuItem, this.工具ToolStripMenuItem, this.窗口ToolStripMenuItem});
			this.darkMenuStrip1.Location = new System.Drawing.Point(0, 0);
			this.darkMenuStrip1.Name = "darkMenuStrip1";
			this.darkMenuStrip1.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
			this.darkMenuStrip1.Size = new System.Drawing.Size(800, 25);
			this.darkMenuStrip1.TabIndex = 0;
			this.darkMenuStrip1.Text = "darkMenuStrip1";
			// 
			// 文件ToolStripMenuItem
			// 
			this.文件ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (60)))), ((int) (((byte) (63)))), ((int) (((byte) (65)))));
			this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.createProjectStrip, this.loadProjectStrip});
			this.文件ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (220)))), ((int) (((byte) (220)))));
			this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
			this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.文件ToolStripMenuItem.Text = "文件";
			// 
			// createProjectStrip
			// 
			this.createProjectStrip.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (60)))), ((int) (((byte) (63)))), ((int) (((byte) (65)))));
			this.createProjectStrip.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (220)))), ((int) (((byte) (220)))));
			this.createProjectStrip.Image = global::CLEditor.Properties.Resources.NewFile_6276;
			this.createProjectStrip.Name = "createProjectStrip";
			this.createProjectStrip.Size = new System.Drawing.Size(124, 22);
			this.createProjectStrip.Text = "创建工程";
			// 
			// loadProjectStrip
			// 
			this.loadProjectStrip.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (60)))), ((int) (((byte) (63)))), ((int) (((byte) (65)))));
			this.loadProjectStrip.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (220)))), ((int) (((byte) (220)))));
			this.loadProjectStrip.Name = "loadProjectStrip";
			this.loadProjectStrip.Size = new System.Drawing.Size(124, 22);
			this.loadProjectStrip.Text = "加载工程";
			// 
			// 工具ToolStripMenuItem
			// 
			this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.settingStrip});
			this.工具ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (220)))), ((int) (((byte) (220)))));
			this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
			this.工具ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.工具ToolStripMenuItem.Text = "工具";
			// 
			// settingStrip
			// 
			this.settingStrip.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (220)))), ((int) (((byte) (220)))));
			this.settingStrip.Name = "settingStrip";
			this.settingStrip.Size = new System.Drawing.Size(100, 22);
			this.settingStrip.Text = "选项";
			// 
			// 窗口ToolStripMenuItem
			// 
			this.窗口ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (60)))), ((int) (((byte) (63)))), ((int) (((byte) (65)))));
			this.窗口ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.menuLogger, this.menuProject, this.menuScene});
			this.窗口ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (220)))), ((int) (((byte) (220)))));
			this.窗口ToolStripMenuItem.Name = "窗口ToolStripMenuItem";
			this.窗口ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.窗口ToolStripMenuItem.Text = "窗口";
			// 
			// menuLogger
			// 
			this.menuLogger.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (60)))), ((int) (((byte) (63)))), ((int) (((byte) (65)))));
			this.menuLogger.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (220)))), ((int) (((byte) (220)))));
			this.menuLogger.Image = global::CLEditor.Properties.Resources.application_16x;
			this.menuLogger.Name = "menuLogger";
			this.menuLogger.Size = new System.Drawing.Size(152, 22);
			this.menuLogger.Text = "日志";
			// 
			// menuProject
			// 
			this.menuProject.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (60)))), ((int) (((byte) (63)))), ((int) (((byte) (65)))));
			this.menuProject.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (220)))), ((int) (((byte) (220)))));
			this.menuProject.Image = global::CLEditor.Properties.Resources.application_16x;
			this.menuProject.Name = "menuProject";
			this.menuProject.Size = new System.Drawing.Size(152, 22);
			this.menuProject.Text = "工程";
			// 
			// darkStatusStrip1
			// 
			this.darkStatusStrip1.AutoSize = false;
			this.darkStatusStrip1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (60)))), ((int) (((byte) (63)))), ((int) (((byte) (65)))));
			this.darkStatusStrip1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (220)))), ((int) (((byte) (220)))));
			this.darkStatusStrip1.Location = new System.Drawing.Point(0, 426);
			this.darkStatusStrip1.Name = "darkStatusStrip1";
			this.darkStatusStrip1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
			this.darkStatusStrip1.Size = new System.Drawing.Size(800, 24);
			this.darkStatusStrip1.SizingGrip = false;
			this.darkStatusStrip1.TabIndex = 1;
			this.darkStatusStrip1.Text = "darkStatusStrip1";
			// 
			// mainDockPanel
			// 
			this.mainDockPanel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (60)))), ((int) (((byte) (63)))), ((int) (((byte) (65)))));
			this.mainDockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainDockPanel.Location = new System.Drawing.Point(0, 25);
			this.mainDockPanel.Name = "mainDockPanel";
			this.mainDockPanel.Size = new System.Drawing.Size(800, 401);
			this.mainDockPanel.TabIndex = 2;
			// 
			// menuScene
			// 
			this.menuScene.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (220)))), ((int) (((byte) (220)))));
			this.menuScene.Image = global::CLEditor.Properties.Resources.application_16x;
			this.menuScene.Name = "menuScene";
			this.menuScene.Size = new System.Drawing.Size(152, 22);
			this.menuScene.Text = "场景";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.mainDockPanel);
			this.Controls.Add(this.darkStatusStrip1);
			this.Controls.Add(this.darkMenuStrip1);
			this.MainMenuStrip = this.darkMenuStrip1;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "Form1";
			this.darkMenuStrip1.ResumeLayout(false);
			this.darkMenuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.ToolStripMenuItem menuScene;

		#endregion

        private DarkUI.Controls.DarkMenuStrip darkMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createProjectStrip;
        private DarkUI.Controls.DarkStatusStrip darkStatusStrip1;
        private DarkUI.Docking.DarkDockPanel mainDockPanel;
        private System.Windows.Forms.ToolStripMenuItem 窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuLogger;
		private System.Windows.Forms.ToolStripMenuItem menuProject;
		private System.Windows.Forms.ToolStripMenuItem loadProjectStrip;
		private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingStrip;
	}
}

