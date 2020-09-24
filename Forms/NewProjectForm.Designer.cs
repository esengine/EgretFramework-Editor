using System.ComponentModel;

namespace CLEditor
{
    partial class NewProjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.darkSectionPanel1 = new DarkUI.Controls.DarkSectionPanel();
			this.projectName = new DarkUI.Controls.DarkTextBox();
			this.darkLabel2 = new DarkUI.Controls.DarkLabel();
			this.createBtn = new DarkUI.Controls.DarkButton();
			this.projectBrowser = new DarkUI.Controls.DarkButton();
			this.projectPosition = new DarkUI.Controls.DarkTextBox();
			this.darkLabel1 = new DarkUI.Controls.DarkLabel();
			this.darkSectionPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// darkSectionPanel1
			// 
			this.darkSectionPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.darkSectionPanel1.Controls.Add(this.projectName);
			this.darkSectionPanel1.Controls.Add(this.darkLabel2);
			this.darkSectionPanel1.Controls.Add(this.createBtn);
			this.darkSectionPanel1.Controls.Add(this.projectBrowser);
			this.darkSectionPanel1.Controls.Add(this.projectPosition);
			this.darkSectionPanel1.Controls.Add(this.darkLabel1);
			this.darkSectionPanel1.Location = new System.Drawing.Point(12, 12);
			this.darkSectionPanel1.Name = "darkSectionPanel1";
			this.darkSectionPanel1.SectionHeader = "工程属性";
			this.darkSectionPanel1.Size = new System.Drawing.Size(446, 179);
			this.darkSectionPanel1.TabIndex = 0;
			// 
			// projectName
			// 
			this.projectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.projectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.projectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.projectName.Location = new System.Drawing.Point(74, 44);
			this.projectName.Name = "projectName";
			this.projectName.Size = new System.Drawing.Size(362, 21);
			this.projectName.TabIndex = 5;
			// 
			// darkLabel2
			// 
			this.darkLabel2.AutoSize = true;
			this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.darkLabel2.Location = new System.Drawing.Point(16, 48);
			this.darkLabel2.Name = "darkLabel2";
			this.darkLabel2.Size = new System.Drawing.Size(41, 12);
			this.darkLabel2.TabIndex = 4;
			this.darkLabel2.Text = "工程名";
			// 
			// createBtn
			// 
			this.createBtn.Location = new System.Drawing.Point(17, 129);
			this.createBtn.Name = "createBtn";
			this.createBtn.Padding = new System.Windows.Forms.Padding(5);
			this.createBtn.Size = new System.Drawing.Size(419, 23);
			this.createBtn.TabIndex = 3;
			this.createBtn.Text = "创建";
			// 
			// projectBrowser
			// 
			this.projectBrowser.Location = new System.Drawing.Point(362, 82);
			this.projectBrowser.Name = "projectBrowser";
			this.projectBrowser.Padding = new System.Windows.Forms.Padding(5);
			this.projectBrowser.Size = new System.Drawing.Size(75, 23);
			this.projectBrowser.TabIndex = 2;
			this.projectBrowser.Text = "浏览...";
			// 
			// projectPosition
			// 
			this.projectPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.projectPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.projectPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.projectPosition.Location = new System.Drawing.Point(74, 83);
			this.projectPosition.Name = "projectPosition";
			this.projectPosition.Size = new System.Drawing.Size(282, 21);
			this.projectPosition.TabIndex = 1;
			// 
			// darkLabel1
			// 
			this.darkLabel1.AutoSize = true;
			this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.darkLabel1.Location = new System.Drawing.Point(16, 87);
			this.darkLabel1.Name = "darkLabel1";
			this.darkLabel1.Size = new System.Drawing.Size(53, 12);
			this.darkLabel1.TabIndex = 0;
			this.darkLabel1.Text = "工程路径";
			// 
			// NewProjectForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(470, 203);
			this.Controls.Add(this.darkSectionPanel1);
			this.Name = "NewProjectForm";
			this.ShowIcon = false;
			this.Text = "NewProjectForm";
			this.darkSectionPanel1.ResumeLayout(false);
			this.darkSectionPanel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private DarkUI.Controls.DarkSectionPanel darkSectionPanel1;
        private DarkUI.Controls.DarkButton projectBrowser;
        private DarkUI.Controls.DarkTextBox projectPosition;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkButton createBtn;
		private DarkUI.Controls.DarkTextBox projectName;
		private DarkUI.Controls.DarkLabel darkLabel2;
	}
}