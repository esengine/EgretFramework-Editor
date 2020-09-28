using System.IO;
using CLEditor.Properties;
using CLEditor.Utils;

namespace CLEditor.Editor
{
	public static class CoreEditor
	{
		internal static ProjectInfo Info;
		internal static bool IsLoad;

		internal static void LoadProject(ProjectInfo info)
		{
			Info = info;
			InvalideData();

			MainForm.Instance._projectView.LoadProject(info);
			IsLoad = true;
		}

		internal static void SaveProject(string path = null)
		{
			SerializerHelper.Serialize(Info, path ?? Path.Combine(Info.Path, Settings.Default.PROJECTCONFIG));
			Log.Info("保存工程成功");
		}

		private static void InvalideData()
		{
			if (Info.SceneWidth == 0) Info.SceneWidth = 640;
			if (Info.SceneHeight == 0) Info.SceneHeight = 1136;

			SaveProject();
		}
	}
}