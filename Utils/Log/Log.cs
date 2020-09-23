using System.Collections;

namespace CLEditor.Utils
{
    public class Log
    {
        /// <summary>
        /// 记录所有日志
        /// </summary>
        public static readonly Queue LogDataList = new Queue();

        /// <summary>
        /// 输出信息
        /// </summary>
        /// <param name="text"></param>
        public static void Info(string text)
        {
            var data = new LogData {Type = LogType.Info, Message = text};
            LogDataList.Enqueue(data);
        }

        /// <summary>
        /// 输出错误信息
        /// </summary>
        /// <param name="text"></param>
        public static void Error(string text)
        {
            var data = new LogData {Type = LogType.Error, Message = text};
            LogDataList.Enqueue(data);
        }
    }

    public class LogData
    {
        public LogType Type;
        public string Message;
    }

    public enum LogType
    {
        /// <summary>
        /// 记录
        /// </summary>
        Info,
        /// <summary>
        /// 错误
        /// </summary>
        Error,
    }
}