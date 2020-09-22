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
            this.darkListView1 = new DarkUI.Controls.DarkListView();
            this.SuspendLayout();
            // 
            // darkListView1
            // 
            this.darkListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.darkListView1.Location = new System.Drawing.Point(0, 25);
            this.darkListView1.Name = "darkListView1";
            this.darkListView1.Size = new System.Drawing.Size(389, 239);
            this.darkListView1.TabIndex = 1;
            this.darkListView1.Text = "darkListView1";
            // 
            // LoggerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.darkListView1);
            this.DefaultDockArea = DarkUI.Docking.DarkDockArea.Bottom;
            this.DockText = "日志";
            this.Name = "LoggerView";
            this.SerializationKey = "LoggerView";
            this.Size = new System.Drawing.Size(389, 264);
            this.ResumeLayout(false);
        }

        #endregion

        private DarkUI.Controls.DarkListView darkListView1;
    }
}
