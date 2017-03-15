using System.Collections.Generic;
using System;
using Dynastream.Fit;

namespace Models
{
    public class MesgDefLogger
    {
        public IList<MesgDefinition> Mesgs {get;}

        static volatile MesgDefLogger instance;

        public static MesgDefLogger Instance
        {
            get 
            {
                object syncRoot = new Object();
                if (instance == null) 
                {
                    lock (syncRoot) 
                    {
                    if (instance == null) 
                        instance = new MesgDefLogger();
                    }
                }

                return instance;
            }
        }

        MesgDefLogger()
        {
            Mesgs = new List<MesgDefinition>();
        }

        public void Log(MesgDefinition mesg)
        {
            Mesgs.Add(mesg);
        }

        public void Reset()
        {
            instance = new MesgDefLogger();
        }
    }
}
