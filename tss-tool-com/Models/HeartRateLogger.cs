using System.Collections.Generic;
using System;

namespace Models
{
    public class HeartRateLogger
    {
        public IList<int> HeartRates {get;}

        static readonly HeartRateLogger instance = new HeartRateLogger();

        public static HeartRateLogger Instance {get;set;}

        static HeartRateLogger() 
        {     
        }

        public HeartRateLogger()
        {
            HeartRates = new List<int>();
        }

        public void Log(int HeartRate)
        {
            HeartRates.Add(HeartRate);
        }
    }
}
