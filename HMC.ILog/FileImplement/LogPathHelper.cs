using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMC.ILog.FileImplement
{
    /// <summary>
    /// 日志路径管理，默认的根目录为Debug/
    /// </summary>
    public class LogPathHelper
    {
        public static LogPathHelper Default = new LogPathHelper("Log");

        /// <summary>
        /// 根路径的文件的名字
        /// </summary>
        /// <param name="rootName"></param>
        public LogPathHelper(string rootName)
        {
            this.RootName = rootName;
        }

        /// <summary>
        /// 根路径名字
        /// </summary>
        string RootName;
        /// <summary>
        /// 返回日志的根路径的完整路径
        /// </summary>
        /// <returns></returns>
        public virtual string GetRootFullPath()
        {

            return System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log");
        }

        /// <summary>
        /// 获取操作日志的根目录
        /// </summary>
        /// <returns></returns>
        public virtual string GetOperationRootFullPath()
        {
            return System.IO.Path.Combine(GetRootFullPath(), "Log_UserOperation", DateTime.Now.ToString("yyyy"), DateTime.Now.ToString("yyyy_MM"));
        }

        /// <summary>
        /// 获取操作日志的完整路径
        /// </summary>
        /// <returns></returns>
        public virtual string GetOperationFileFullPath(string fileName)
        {
            return System.IO.Path.Combine(GetOperationRootFullPath(), $"{DateTime.Now.ToString("yyyy_MM_dd")}_" + "UserOperation_" + fileName);
        }

        /// <summary>
        /// 获取错误日志的根目录
        /// </summary>
        /// <returns></returns>
        public virtual string GetErrornRootFullPath()
        {
            return System.IO.Path.Combine(GetRootFullPath(), "Log_Err", DateTime.Now.ToString("yyyy"), DateTime.Now.ToString("yyyy_MM"));
        }

        /// <summary>
        /// 获取错误日志文件的完整路径
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public virtual string GetErrorFileFullPath(string fileName)
        {
            return System.IO.Path.Combine(GetErrornRootFullPath(), $"{DateTime.Now.ToString("yyyy_MM_dd")}_" + "Err_" + fileName);
        }

        /// <summary>
        /// 获取流程日志的完整根目录
        /// </summary>
        /// <returns></returns>
        public virtual string GetProcessRootFullPath()
        {
            return System.IO.Path.Combine(GetRootFullPath(), "Log_Process", DateTime.Now.ToString("yyyy"), DateTime.Now.ToString("yyyy_MM"));
        }

        /// <summary>
        /// 获取流程日志文件的完整路径
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public virtual string GetProcessFileFullPath(string fileName)
        {
            return System.IO.Path.Combine(GetProcessRootFullPath(), $"{DateTime.Now.ToString("yyyy_MM_dd")}_" + "Process_" + fileName);
        }
    }
}
