using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Logging
{
    public class LogParameter
    {
        // Loglanacak olan Metot'un ismi,tipi,değeri 
        public string Name { get; set; }
        public string Type { get; set; }
        public object Value { get; set; }


    }
}
