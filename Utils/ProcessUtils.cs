using System;
using System.ComponentModel;
using System.Diagnostics;

namespace CLEditor.Utils
{
    public class ProcessUtils
    {
        private static string CmdPath = @"C:\Windows\System32\cmd.exe";
        /// <summary>
        /// 执行一个cmd命令
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="workDirectory"></param>
        /// <param name="outputAction"></param>
        public static void Run(string cmd, string workDirectory = null, Action<object> outputAction = null)
        {
            var backgroundWorker = new BackgroundWorker {WorkerReportsProgress = true};
            backgroundWorker.ProgressChanged += (sender, args) =>
            {
                outputAction?.Invoke(args.UserState);
            };
            backgroundWorker.DoWork += (sender, args) =>
            {
                cmd = cmd.Trim().TrimEnd('&') + "&exit";
                using (var p = new Process())
                {
                    p.StartInfo.FileName = CmdPath;
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardInput = true;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.RedirectStandardError = true;
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.WorkingDirectory = workDirectory ?? Environment.CurrentDirectory;
                    p.Start();
            
                    p.StandardInput.WriteLine(cmd);
                    p.StandardInput.AutoFlush = true;
            
                    var output = p.StandardOutput.ReadToEnd();
                    p.WaitForExit();
                    p.Close();
                    
                    backgroundWorker.ReportProgress(0, output);
                }
            };
            backgroundWorker.RunWorkerAsync();
        }
    }
}