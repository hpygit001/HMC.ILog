using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMC.ILog.FileImplement
{
    /// <summary>
    /// 流程类 Log记录
    /// 记录的路径默认为：当前运行程序\\Log\\ProcessLog\\...
    /// </summary>
    class LogProcessHelper : LogFileBase,ILogProcess
    {


        /// <summary>
        /// 文件的名字,无需后缀
        /// </summary>
        /// <param name="fileName"></param>
        public LogProcessHelper(string fileName) : this(fileName, LogPathHelper.Default)
        {


        }

        public LogProcessHelper(string fileName, LogPathHelper logPath) : base(logPath)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                //生成默认
                fileName = $"ProcessDefault.txt";
            }

            if (string.IsNullOrEmpty(System.IO.Path.GetExtension(fileName)))
            {
                fileName += ".txt";
            }

            _FileName = fileName;

            if (!System.IO.Directory.Exists(LogPath.GetProcessRootFullPath()))
            {
                System.IO.Directory.CreateDirectory(LogPath.GetProcessRootFullPath());
            }

        }

        string _FileName = "";


        public string FullPath => LogPath.GetProcessFileFullPath(_FileName);




       
      

        public void Write(LogProcessArgs args)
        {
            if (args == null) return;
            if (string.IsNullOrEmpty(args.Info)) return;
            Write(FullPath, args.ToString());
        }
    }
}
