using System;
using System.ComponentModel;
using System.Text;
using CLEditor.Utils;
using DarkUI.Docking;

namespace CLEditor
{
    public partial class LoggerView : DarkToolWindow
    {
        private BackgroundWorker loggerBackworker;
        
        public LoggerView()
        {
            InitializeComponent();
            RunLogger();
        }

        public void RunLogger()
        {
            loggerBackworker = new BackgroundWorker {WorkerReportsProgress = true};
            loggerBackworker.DoWork += BackgroundWorkerOnDoWork;
            loggerBackworker.ProgressChanged += LoggerBackworkerOnProgressChanged;
            loggerBackworker.RunWorkerAsync();
        }

        private void LoggerBackworkerOnProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            logBox.AppendText(e.UserState.ToString());
        }

        private void BackgroundWorkerOnDoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (Log.LogDataList.Count > 0)
                {
                    var data = (LogData)Log.LogDataList.Dequeue();
                    loggerBackworker.ReportProgress(0, $"[{data.Type}]: {data.Message}" + Environment.NewLine);
                }
            }
        }
    }
}
