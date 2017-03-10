using System;
using System.Collections.Generic;
using Dynastream.Fit;

namespace Models
{
    public class HeartRateMesgListener
    {
        public static void HrMesgEvent(object sender, MesgEventArgs e)
        {
            Console.WriteLine("got an HR mesg");
            HeartRateLogger logger = HeartRateLogger.GetInstance();
            Mesg mesg = e.mesg;
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
