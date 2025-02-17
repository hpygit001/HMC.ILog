using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMC.ILog
{
    /// <summary>
    /// UI 操作日志
    /// </summary>
    public class LogUIOperationArgs
    {
        /// <summary>
        /// 时间
        /// </summary>
        public string Time { get; set; }

        /// <summary>
        /// 用户
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }


        public override string ToString()
        {
            return $"[{Time},{UserName}]{Content}";
        }
    }
}
