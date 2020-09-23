using System;
using System.IO;
using System.Windows.Forms;
using CLEditor.Properties;
using CLEditor.Utils;
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
            if (string.IsNullOrEmpty(projectName.Text))
            {
                MessageBox.Show(Resources.NewProjectForm_ProjectNameIsNotNull);
                return;
            }

            if (string.IsNullOrEmpty(projectPosition.Text))
            {
                MessageBox.Show(Resources.NewProjectForm_ProjectPathIsNotNull);
                return;
            }

            if (!Directory.Exists(projectPosition.Text))
            {
                Directory.CreateDirectory(projectBrowser.Text);
            }

            ProcessUtils.Run($"egret create {projectName.Text} --type core", projectPosition.Text);
            Log.Info("项目创建完毕");
            Close();
        }

        private void ProjectBrowserOnClick(object sender, EventArgs e)
        {
            var projectDialog = new FolderBrowserDialog();
            if (projectDialog.ShowDialog() == DialogResult.OK)
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