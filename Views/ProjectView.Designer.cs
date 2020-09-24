namespace CLEditor.Views
{
	partial class ProjectView
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

		#region 组件设计器生成的代码

		/// <summary> 
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.projectList = new DarkUI.Controls.DarkTreeView();
			this.SuspendLayout();
			// 
			// projectList
			// 
			this.projectList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.projectList.Location = new System.Drawing.Point(0, 31);
			this.projectList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.projectList.MaxDragChange = 20;
			this.projectList.Name = "projectList";
			this.projectList.ShowIcons = true;
			this.projectList.Size = new System.Drawing.Size(282, 347);
			this.projectList.TabIndex = 0;
			this.projectList.Text = "darkTreeView1";
			// 
			// ProjectView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.projectList);
			this.DefaultDockArea = DarkUI.Docking.DarkDockArea.Left;
			this.DockText = "工程浏览";
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.Icon = global::CLEditor.Properties.Resources.application_16x;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "ProjectView";
			this.SerializationKey = "ProjectView";
			this.Size = new System.Drawing.Size(282, 378);
			this.ResumeLayout(false);

		}

		#endregion

		private DarkUI.Controls.DarkTreeView projectList;
	}
}
