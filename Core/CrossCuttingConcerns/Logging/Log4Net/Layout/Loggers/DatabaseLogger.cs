using log4net;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Logging.Log4Net.Layout.Loggers
{
    public class DatabaseLogger:LoggerService
    {
        public DatabaseLogger():base(LogManager.GetLogger("DatabaseLogger"))
        {

        }
    }
}
