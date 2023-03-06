﻿using log4net;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Logging.Log4Net.Layout.Loggers
{
    public class FileLogger:LoggerService
    {
        public FileLogger():base(LogManager.GetLogger("JsonFileLogger"))
        {

        }
    }
}
