using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMC.ILog
{
    public class LogProcessArgs:LogArgs
    {
        public static readonly string MessageType_Step = "Step";

        public static readonly string MessageType_Info = "Info";

        public static readonly string MessageType_Err = "Err";
        public LogProcessArgs()
        {

        }
        

        
        /// <summary>
        /// 消息类型
        /// </summary>
        public string MessageType { get; set; }

        /// <summary>
        /// 当前流程的名字
        /// </summary>

        public string ProcessName { get; set; }


        public override string ToString()
        {
            if(MessageType!=null&&ProcessName!=null)
            {
                return $"[{Time},{MessagLevel}][{ProcessName}][{MessageType}]{Info}";

            }
            if(ProcessName!=null)
            {
                return $"[{Time},{MessagLevel}][{ProcessName}]{Info}";

            }
            else
            {
                return $"[{Time},{MessagLevel}][{MessageType}]{Info}";

            }
        }

    }
}
