using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMC.ILog
{
    /// <summary>
    /// 操作日志
    /// </summary>
    public interface ILogUIOperation
    {

        /// <summary>
        /// 记录UI操作
        /// </summary>
        /// <param name="args"></param>
        void Write(LogUIOperationArgs args);

        

    }
}
