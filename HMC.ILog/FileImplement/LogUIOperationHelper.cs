using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMC.ILog.FileImplement
{

    /// <summary>
    /// 用户操作型日志
    /// 日志保存在：Log\\UserOperation\\...
    /// </summary>
    class LogUIOperationHelper:LogFileBase,ILogUIOperation
    {
        /// <summary>
        /// 文件的名字
        /// </summary>
        /// <param name="fileName"></param>
        public LogUIOperationHelper(string fileName) : this(fileName, LogPathHelper.Default)
        {




        }

        public LogUIOperationHelper(string fileName, LogPathHelper logPath) : base(logPath)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                //生成默认
                fileName = "OperationDefault.txt";
            }

            if (string.IsNullOrEmpty(System.IO.Path.GetExtension(fileName)))
            {
                fileName += ".txt";
            }

            _FileName = fileName;

            if (!System.IO.Directory.Exists(LogPath.GetOperationRootFullPath()))
            {
                System.IO.Directory.CreateDirectory(LogPath.GetOperationRootFullPath());
            }
        }

        string _FileName = "";


        public string FullPath => LogPath.GetOperationFileFullPath(_FileName);

        public void Write(LogUIOperationArgs args)
        {
            if (args == null) return;
            if (string.IsNullOrEmpty(args.Content)) return;
            Write(FullPath, args.ToString());
        }
    }
}
