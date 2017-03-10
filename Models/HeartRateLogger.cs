using System.Collections.Generic;
using System;

namespace Models
{
    public class HeartRateLogger
    {
        public IList<int> HeartRates {get;}

        private static HeartRateLogger Instance = null;

        public  static HeartRateLogger GetInstance()
        {
            if (Instance == null)
            {
                return new HeartRateLogger();
            }
            else {
                return Instance;
            }
        }
        private HeartRateLogger() 
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
