namespace CLEditor.Views
{
	partial class NodeView
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
			this.nodesControl1 = new NodeEditor.NodesControl();
			this.SuspendLayout();
			// 
			// nodesControl1
			// 
			this.nodesControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.nodesControl1.Context = null;
			this.nodesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nodesControl1.Location = new System.Drawing.Point(0, 0);
			this.nodesControl1.Name = "nodesControl1";
			this.nodesControl1.Size = new System.Drawing.Size(381, 285);
			this.nodesControl1.TabIndex = 0;
			// 
			// NodeView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.Controls.Add(this.nodesControl1);
			this.DockText = "节点视图";
			this.DoubleBuffered = true;
			this.Icon = global::CLEditor.Properties.Resources.application_16x;
			this.Name = "NodeView";
			this.SerializationKey = "NodeView";
			this.Size = new System.Drawing.Size(381, 285);
			this.ResumeLayout(false);

		}

		#endregion

		private NodeEditor.NodesControl nodesControl1;
	}
}
