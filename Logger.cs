using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace Sandbox.Logging
{
    public static class Logger
    {
        //private static readonly ILog _log = LogManager.GetLogger(typeof(Logger));
        private static readonly ILog _log = LogManager.GetLogger("Demo Logger");
        public static void Log(string message)
        {
            var repos = LogManager.GetAllRepositories();
            var loggers = LogManager.GetCurrentLoggers();
            

            _log.Logger.Repository.Properties["MessageId"] = "123987";
            _log.Debug(message);

            
        }
    }
}
