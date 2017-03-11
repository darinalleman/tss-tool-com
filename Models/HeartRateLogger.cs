using System.Collections.Generic;
using System;

namespace Models
{
    public class HeartRateLogger
    {
        public IList<int> HeartRates {get;}

        private volatile static HeartRateLogger Instance;

        public static HeartRateLogger GetInstance()
        {
            object lockingObject = new object();
            if (Instance == null)
            {
                lock (lockingObject)
                {
                    if (Instance == null)
                    {
                        Instance = new HeartRateLogger();
                    }
                }
            }
            return Instance;
        }
        private HeartRateLogger() 
        {
            HeartRates = new List<int>();
        }

        public void Log(int HeartRate)
        {
            HeartRates.Add(HeartRate);
        }
    }
}
