using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMC.ILog.FileImplement
{
    /// <summary>
    /// 文件实现日志创建工厂
    /// </summary>
    public class FileLogCreateFactory : ILogCreateFactory
    {
        public static readonly FileLogCreateFactory Default = new FileLogCreateFactory(LogPathHelper.Default);
        public FileLogCreateFactory(LogPathHelper logPath)
        {
            LogPath = logPath;
        }
        /// <summary>
        /// 日志路径
        /// </summary>
        public LogPathHelper LogPath { get; private set; }

        /// <summary>
        /// 重新设置日志路径
        /// 路径修改后，不影响之前已经创建的日志；仅仅影响修改路径后，后续创建的日志对象
        /// </summary>
        /// <param name="logPath"></param>
        public void ResetLogPath(LogPathHelper logPath)
        {
            this.LogPath = logPath;
        }
        public ILogError CreateLogError(string logName)
        {
            return new LogErrorHelper(logName, LogPath);
        }

        public ILogProcess CreateLogProcess(string logName)
        {
            return new LogProcessHelper(logName, LogPath);
        }

        public ILogUIOperation CreateLogUIOperation(string logName)
        {
            return new LogUIOperationHelper(logName, LogPath);
        }
    }
}
