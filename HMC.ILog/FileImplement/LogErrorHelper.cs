using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMC.ILog.FileImplement
{
    /// <summary>
    /// 错误收集型日志：专门用来收集错误信息
    /// 日志保存在：Log\\Log_Err\\...
    /// </summary>
    class LogErrorHelper:LogFileBase,ILogError
    {
        /// <summary>
        /// 文件的名字
        /// </summary>
        /// <param name="fileName"></param>
        public LogErrorHelper(string fileName) : this(fileName, LogPathHelper.Default)
        {



        }

        public LogErrorHelper(string fileName, LogPathHelper logPath) : base(logPath)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                //生成默认
                fileName = "ErrorDefault.txt";
            }

            if (string.IsNullOrEmpty(System.IO.Path.GetExtension(fileName)))
            {
                fileName += ".txt";
            }

            _FileName = fileName;

            if (!System.IO.Directory.Exists(LogPath.GetErrornRootFullPath()))
            {
                System.IO.Directory.CreateDirectory(LogPath.GetErrornRootFullPath());
            }
        }

        string _FileName = "";


        public string FullPath => LogPath.GetErrorFileFullPath(_FileName);


       
        public void Write(LogErrorArgs args)
        {
            if (args == null) return;
            if (string.IsNullOrEmpty(args.Info)) return;

            Write(FullPath, args.ToString());
        }
    }
}
