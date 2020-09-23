namespace CLEditor
{
    partial class LoggerView
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.logBox = new DarkUI.Controls.DarkTextBox();
			this.SuspendLayout();
			// 
			// logBox
			// 
			this.logBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.logBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.logBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.logBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.logBox.Location = new System.Drawing.Point(0, 25);
			this.logBox.Multiline = true;
			this.logBox.Name = "logBox";
			this.logBox.ReadOnly = true;
			this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.logBox.Size = new System.Drawing.Size(389, 239);
			this.logBox.TabIndex = 0;
			// 
			// LoggerView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.logBox);
			this.DefaultDockArea = DarkUI.Docking.DarkDockArea.Bottom;
			this.DockText = "日志";
			this.Name = "LoggerView";
			this.SerializationKey = "LoggerView";
			this.Size = new System.Drawing.Size(389, 264);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private DarkUI.Controls.DarkTextBox logBox;
	}
}
