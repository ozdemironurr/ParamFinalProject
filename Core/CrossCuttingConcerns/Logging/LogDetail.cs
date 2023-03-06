using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Logging
{
    public class LogDetail
    {
        //log  detayı
        public string FullName { get; set; }
        public string MethodName { get; set; }
        public List<LogParameter> LogParameters { get; set; }
    }
}
