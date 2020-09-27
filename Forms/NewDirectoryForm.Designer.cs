using System.ComponentModel;

namespace CLEditor.Forms
{
    partial class NewDirectoryForm
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
			this.darkLabel1 = new DarkUI.Controls.DarkLabel();
			this.directoryName = new DarkUI.Controls.DarkTextBox();
			this.SuspendLayout();
			// 
			// darkLabel1
			// 
			this.darkLabel1.AutoSize = true;
			this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.darkLabel1.Location = new System.Drawing.Point(12, 24);
			this.darkLabel1.Name = "darkLabel1";
			this.darkLabel1.Size = new System.Drawing.Size(53, 12);
			this.darkLabel1.TabIndex = 2;
			this.darkLabel1.Text = "文件夹名";
			// 
			// directoryName
			// 
			this.directoryName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.directoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.directoryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.directoryName.Location = new System.Drawing.Point(71, 19);
			this.directoryName.Name = "directoryName";
			this.directoryName.Size = new System.Drawing.Size(288, 21);
			this.directoryName.TabIndex = 3;
			// 
			// NewDirectoryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(371, 101);
			this.Controls.Add(this.directoryName);
			this.Controls.Add(this.darkLabel1);
			this.Name = "NewDirectoryForm";
			this.Text = "NewDirectoryForm";
			this.Controls.SetChildIndex(this.darkLabel1, 0);
			this.Controls.SetChildIndex(this.directoryName, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private DarkUI.Controls.DarkLabel darkLabel1;
		private DarkUI.Controls.DarkTextBox directoryName;
	}
}