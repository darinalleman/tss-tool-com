using System.Collections.Generic;
using System;
using Dynastream.Fit;

namespace Models
{
    public class MesgLogger
    {
        public IList<Mesg> Mesgs {get;}

        static volatile MesgLogger instance;

        public static MesgLogger Instance
        {
            get 
            {
                object syncRoot = new Object();
                if (instance == null) 
                {
                    lock (syncRoot) 
                    {
                    if (instance == null) 
                        instance = new MesgLogger();
                    }
                }

                return instance;
            }
        }

        MesgLogger()
        {
            Mesgs = new List<Mesg>();
        }

        public void Log(Mesg mesg)
        {
            Mesgs.Add(mesg);
        }

        public void Reset()
        {
            instance = new MesgLogger();
        }
    }
}
