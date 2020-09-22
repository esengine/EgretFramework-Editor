using System.Diagnostics;

namespace CLEditor.Utils
{
    public class ProcessUtils
    {
        public static void Run(string cmd)
        {
            var p = new Process
            {
                StartInfo =
                {
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            p.Start();

            p.StandardInput.WriteLine(cmd + "&exit");
            p.StandardInput.AutoFlush = true;

            var output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            p.Close();
        }
    }
}