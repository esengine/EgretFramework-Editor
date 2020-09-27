using System.Windows.Forms;
using CLEditor.Properties;
using DarkUI.Forms;

namespace CLEditor.Forms
{
    public partial class NewDirectoryForm : DarkDialog
    {
        public NewDirectoryForm()
        {
            InitializeComponent();

            ShowIcon = false;
            Text = Resources.NewDirectoryForm_NewDirectory;
            StartPosition = FormStartPosition.CenterScreen;
        }

        public sealed override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }
    }
}