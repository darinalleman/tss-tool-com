using System.Collections.Generic;
using System;

namespace Models
{
    public class HeartRateLogger
    {
        public IList<int> HeartRates {get;}

        static volatile HeartRateLogger instance;

        public static HeartRateLogger Instance
        {
            get 
            {
                object syncRoot = new Object();
                if (instance == null) 
                {
                    lock (syncRoot) 
                    {
                    if (instance == null) 
                        instance = new HeartRateLogger();
                    }
                }

                return instance;
            }
        }

        HeartRateLogger()
        {
            HeartRates = new List<int>();
        }

        public void Log(int HeartRate)
        {
            HeartRates.Add(HeartRate);
        }

        public void Reset()
        {
            instance = new HeartRateLogger();
        }
    }
}
