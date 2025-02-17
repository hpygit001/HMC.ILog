using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMC.ILog
{
    /// <summary>
    /// 日志参数表示类
    /// </summary>
    public class LogArgs
    {
        public static readonly string LevelNormal = "Normal";
        public static readonly string LevelWarning = "Warning";
        public static readonly string LevelError = "Error";

        public static readonly string LevelException = "Exception";
        public LogArgs()
        {
          
        }

        /// <summary>
        /// 时间
        /// </summary>
       public string Time { get; set; }

        /// <summary>
        /// 消息的级别
        /// </summary>
        public string MessagLevel { get; set; }



        /// <summary>
        /// 消息
        /// </summary>
        public string Info { get; set; }

        public override string ToString()
        {
            return $"[{Time},{MessagLevel}] {Info}";
        }
    }
}
