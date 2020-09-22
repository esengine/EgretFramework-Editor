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
        public DarkSectionPanel MainSectionPanel;
        
        public NewProjectForm()
        {
            InitializeComponent();

            Text = Resources.NewProjectForm_NewProject;

            MainSectionPanel = new DarkSectionPanel {SectionHeader = "工程属性", Dock = DockStyle.Fill};
            Controls.Add(MainSectionPanel);

            var panel = new FlowLayoutPanel {Top = 50};
            MainSectionPanel.Controls.Add(panel);
            
            var projectName = new DarkLabel {Text = Resources.NewProjectForm_ProjectName, TextAlign = ContentAlignment.MiddleCenter ,AutoSize = true};
            panel.Controls.Add(projectName);
            
            var projectPosition = new DarkTextBox {Left = projectName.Width + 5, TextAlign = HorizontalAlignment.Center};
            panel.Controls.Add(projectPosition);
            
            var projectBrowser = new DarkButton {Text = "浏览...", AutoSize = true, Left = projectPosition.Width + 5};
            projectBrowser.Click += ProjectBrowserOnClick;
            panel.Controls.Add(projectBrowser);
        }

        private void ProjectBrowserOnClick(object sender, EventArgs e)
        {
            var projectDialog = new FolderBrowserDialog();
            if (projectDialog.ShowDialog() == DialogResult.Yes)
            {
                
            }
        }

        public sealed override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }
    }
}