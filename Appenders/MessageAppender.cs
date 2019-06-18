using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Appender;
using log4net.Core;

namespace Sandbox.Logging.Appenders
{
    class MessageAppender : FileAppender
    {
        protected override void OpenFile(string fileName, bool append)
        {
            base.OpenFile(fileName, append);
        }

        protected override void Append(LoggingEvent loggingEvent)
        {
            var x = loggingEvent.Repository.Properties.Count;

            if (loggingEvent.Repository.Properties.Contains("MessageId"))
            {
                var file = base.File.Replace("{MessageId}", loggingEvent.Repository.Properties["MessageId"].ToString());
                base.OpenFile(file, base.AppendToFile);
                base.Append(loggingEvent);
                base.CloseFile();
                return;
            }
            
            base.Append(loggingEvent);
        }
    }
}
