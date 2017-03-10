using System;
using System.Collections.Generic;
using Dynastream.Fit;

namespace Models
{
    public class HeartRateMesgListener : IMesgBroadcastPlugin
    {
        private HeartRateLogger logger {get;set;}

        public HeartRateMesgListener(HeartRateLogger logger) 
        {
            this.logger = logger;
        }

        void IMesgBroadcastPlugin.OnBroadcast(object sender, MesgBroadcastEventArgs e)
        {
            throw new NotImplementedException();
        }

        void IMesgBroadcastPlugin.OnIncomingMesg(object sender, IncomingMesgEventArgs ev)
        {
            Mesg mesg = ev.mesg;
            if (mesg.Num.Equals(MesgNum.Record))
            {
                Field HeartRateField = mesg.GetField(RecordMesg.FieldDefNum.HeartRate);
                
                if (HeartRateField != null)
                {
                    int HeartRate = (int) HeartRateField.GetValue();
                    logger.Log(HeartRate);
                }
            }
        }
    }
}
