using System;
using System.Windows.Forms;
using CLEditor.Properties;
using DarkUI.Controls;
using DarkUI.Docking;
using DarkUI.Forms;
#pragma warning disable 8618

namespace CLEditor
{
	public partial class MainForm : DarkForm
	{
		public static MainForm Instance;
		public DarkDockPanel MainContainer;
		public DarkMenuStrip MainMenuStrip;

		public MainForm()
		{
			Instance = this;
			InitializeComponent();

			Text = Resources.MainForm_Title + string.Format(Resources.MainForm_Version, Application.ProductVersion);
			MainContainer = new DarkDockPanel {Dock = DockStyle.Fill};
			Controls.Add(MainContainer);

			MainMenuStrip = new DarkMenuStrip {Dock = DockStyle.Top};
			MainContainer.Controls.Add(MainMenuStrip);
			InitMenuStripData();
		}

		/// <summary>
		/// 初始化MenuStrip数据
		/// </summary>
		private void InitMenuStripData()
		{
			var fileMenuStrip = new ToolStripMenuItem(Resources.MenuStrip_File);
			MainMenuStrip.Items.Add(fileMenuStrip);
			
			var createProjectStrip = new ToolStripMenuItem("创建工程");
			createProjectStrip.Click += NewProjectOnClick;
			fileMenuStrip.DropDownItems.Add(createProjectStrip);
		}

		private void NewProjectOnClick(object sender, EventArgs e)
		{
			var newProjectForm = new NewProjectForm();
			if (newProjectForm.ShowDialog() == DialogResult.Yes)
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
