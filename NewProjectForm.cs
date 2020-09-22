using System;
using System.Drawing;
using System.Windows.Forms;
using CLEditor.Properties;
using DarkUI.Controls;
using DarkUI.Docking;
using DarkUI.Forms;

namespace CLEditor
{
    public partial class NewProjectForm : DarkForm
    {
        public NewProjectForm()
        {
            InitializeComponent();

            Text = Resources.NewProjectForm_NewProject;
            StartPosition = FormStartPosition.CenterScreen;

            projectBrowser.Click += ProjectBrowserOnClick;
            createBtn.Click += CreateBtnOnClick;
        }

        private void CreateBtnOnClick(object sender, EventArgs e)
        {
            
        }

        private void ProjectBrowserOnClick(object sender, EventArgs e)
        {
            var projectDialog = new FolderBrowserDialog();
            if (projectDialog.ShowDialog() == DialogResult.Yes)
            {
                projectPosition.Text = projectDialog.SelectedPath;
            }
        }

        public sealed override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }
    }
}