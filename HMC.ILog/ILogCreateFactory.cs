using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMC.ILog
{
    /// <summary>
    /// 日志创建接口
    /// </summary>
    public interface ILogCreateFactory
    {
        /// <summary>
        /// 创建流程日志
        /// </summary>
        /// <param name="logName">日志名字，无需后缀</param>
        /// <returns></returns>
        ILogProcess CreateLogProcess(string logName);

        /// <summary>
        ///  创建错误日志
        /// </summary>
        /// <param name="logName">日志名字，无需后缀</param>
        /// <returns></returns>
        ILogError CreateLogError(string logName);

        /// <summary>
        /// 创建UI操作日志
        /// </summary>
        /// <param name="logName">日志名字，无需后缀</param>
        /// <returns></returns>
        ILogUIOperation CreateLogUIOperation(string logName);
    }
}
