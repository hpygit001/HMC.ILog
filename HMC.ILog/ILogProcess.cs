using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMC.ILog
{
    /// <summary>
    /// 流程日志
    /// </summary>
    public interface ILogProcess
    {
        /// <summary>
        /// 记录流程日志
        /// </summary>
        /// <param name="args"></param>
        void Write(LogProcessArgs args);
    }
}
