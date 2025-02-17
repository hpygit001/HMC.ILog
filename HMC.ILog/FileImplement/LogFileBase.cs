using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMC.ILog.FileImplement
{
    /// <summary>
    /// 
    /// 日志文件基类
    /// </summary>
    public abstract class LogFileBase
    {
        public LogFileBase(LogPathHelper logPath)
        {


            LogPath = logPath;
            if (!System.IO.Directory.Exists(LogPath.GetRootFullPath()))
            {
                System.IO.Directory.CreateDirectory(LogPath.GetRootFullPath());
            }
            IsWriteLog = true;
        }
        protected LogPathHelper LogPath;
        readonly object ob_lock = new object();
        static readonly object ob_Lock_dic = new object();
        /// <summary>
        /// 是否禁止所有写入Log的操作，默认为False,即允许写入
        /// 
        /// </summary>
        public static bool IsLimitAllWriteLog { get; set; }
        /// <summary>
        /// 是否写入Log,默认为True,即写入
        /// </summary>
        public bool IsWriteLog { get; set; }


        /// <summary>
        /// Log 根目录
        /// </summary>
        public string LogRoot => LogPath.GetRootFullPath();

       
      

        bool CheckFileExist(string filePath)
        {
            try
            {

                if (!System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(filePath)))
                {
                    lock (ob_Lock_dic)
                    {
                        if (!System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(filePath)))
                        {
                            System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(filePath));
                        }

                    }

                }
                if (!System.IO.File.Exists(filePath))
                {
                    lock (ob_lock)
                    {
                        if (!System.IO.File.Exists(filePath))
                        {
                            using (System.IO.File.Create(filePath)) { }
                        }
                    }
                }



                return true;
            }
            catch (Exception ex)
            {
                return false;

            }

        }
        protected void Write(string filePath, string msg)
        {



            if (IsLimitAllWriteLog) return;
            if (IsWriteLog == false) return;
            if (!CheckFileExist(filePath)) return;
            lock (ob_lock)
            {
                try
                {

                    System.IO.File.AppendAllText(filePath, msg + "\r\n");
                }
                catch (Exception ex)
                {


                }


            }
        }


        public static string GetCurrentTime()
        {

            return DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff");
        }

    }
}
