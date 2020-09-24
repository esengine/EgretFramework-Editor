namespace CLEditor.Editor
{
	public static class CoreEditor
	{
		internal static ProjectInfo Info;

		internal static void LoadProject(ProjectInfo info)
		{
			Info = info;
			MainForm.Instance._projectView.LoadProject(info);
		}
	}
}