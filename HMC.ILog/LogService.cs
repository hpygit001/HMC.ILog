using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMC.ILog
{
    /// <summary>
    /// 日志服务，用来返回ILogCreateFactory 
    /// 默认添加，以文件实现的日志（FileLogCreateFactory）;日志路径管理由LogPathHelper负责，默认放在Debug/Log下
    /// </summary>
    public class LogService
    {
        static LogService()
        {
            Default.SetILogCreateFactory(FileImplement.FileLogCreateFactory.Default);
        }
        /// <summary>
        /// 默认的日志服务对象
        /// </summary>
        public static readonly LogService Default = new LogService();

        ILogCreateFactory CreateFactory;

        /// <summary>
        /// 设置日志创建
        /// </summary>
        /// <param name="factory"></param>
        public void SetILogCreateFactory(ILogCreateFactory factory)
        {
            CreateFactory = factory;
        }

        /// <summary>
        /// 获取创建的日志工厂
        /// </summary>
        /// <returns></returns>
        public ILogCreateFactory GetLogCreateFactory()
        {
            return CreateFactory;
        }

    }
}
