using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMC.ILog
{
    public  class LogErrorArgs:LogArgs
    {
        /// <summary>
        /// 当前流程的名字
        /// </summary>
        public string ProcessName { get; set; }


        public override string ToString()
        {
            
            if (ProcessName != null)
            {
                return $"[{Time},{MessagLevel}][{ProcessName}]{Info}";

            }
            else
            {
                return $"[{Time},{MessagLevel}]{Info}";

            }
        }
    }
}
