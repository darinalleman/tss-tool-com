using System;
using System.Collections.Generic;
using Dynastream.Fit;

namespace Models
{
    public class HeartRateMesgListener
    {
        public static void MesgEvent(object sender, MesgEventArgs e)
        {
            if (e.mesg.GetField(RecordMesg.FieldDefNum.HeartRate) != null)
            {
                HeartRateLogger logger = HeartRateLogger.GetInstance();
                Field HeartRateField = e.mesg.GetField(RecordMesg.FieldDefNum.HeartRate);
                int HeartRate = Convert.ToInt32(HeartRateField.GetValue());
                logger.Log(HeartRate);
            }   
        }
    }
}
