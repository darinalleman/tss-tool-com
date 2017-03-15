using System.Collections.Generic;
using System;

namespace Models
{
    public class ElapsedTimeLogger
    {
        public int ElapsedTime { get; set; }

        static readonly ElapsedTimeLogger instance = new ElapsedTimeLogger();

        public static ElapsedTimeLogger Instance
        {
            get
            {
                return instance;
            }
        }

        static ElapsedTimeLogger()
        {
        }


        public void Log(int ElapsedTime)
        {
            this.ElapsedTime = ElapsedTime;
        }

    }
}
