using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMC.ILog
{

    /// <summary>
    /// 记录错误日志
    /// </summary>
    public interface ILogError
    {
        
        /// <summary>
        /// 记录错误消息
        /// </summary>
        /// <param name="args"></param>
        void Write(LogErrorArgs args);
        
    }
}
