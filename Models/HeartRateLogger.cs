using System.Collections.Generic;
using System;

namespace Models
{
    public class HeartRateLogger
    {
        protected IList<int> HeartRates {get;}

        public HeartRateLogger() 
        {
            HeartRates = new List<int>();
        }

        public void Log(int HeartRate)
        {
            HeartRates.Add(HeartRate);
            Console.WriteLine("Added HR: " + HeartRate);
        }
    }
}
