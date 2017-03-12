using System.Collections.Generic;
using System;

namespace Models
{
    public class HeartRateLogger
    {
        public IList<int> HeartRates {get;}

        static readonly HeartRateLogger instance = new HeartRateLogger();

        public static HeartRateLogger Instance
        {
            get
            {
                return instance;
            }
        }

        static HeartRateLogger() 
        {     
        }

        HeartRateLogger()
        {
            HeartRates = new List<int>();
        }

        public void Log(int HeartRate)
        {
            HeartRates.Add(HeartRate);
        }
    }
}
