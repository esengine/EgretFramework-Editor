using System;
using System.Drawing;
using System.Windows.Forms;
using CLEditor.Editor;
using CLEditor.Properties;

namespace CLEditor.Views
{
	public sealed partial class SceneView : DarkUI.Docking.DarkDocument
	{
		public SceneView()
		{
			InitializeComponent();

			DoubleBuffered = true;
			Resize += OnResize;
		}

		private void OnResize(object sender, EventArgs e)
		{
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			var graphics = e.Graphics;
			graphics.Clear(Color.Transparent);
			if (!CoreEditor.IsLoad) return;

			graphics.DrawRectangle(Pens.Red, 0, 0, CoreEditor.Info.SceneWidth, CoreEditor.Info.SceneHeight);
		}
	}
}
