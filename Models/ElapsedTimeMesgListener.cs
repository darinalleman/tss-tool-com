using System;
using System.Collections.Generic;
using Dynastream.Fit;

namespace Models
{
    public class ElapsedTimeMesgListener
    {
        public static void MesgEvent(object sender, MesgEventArgs e)
        {
            Field Field = e.mesg.GetField(SessionMesg.FieldDefNum.TotalElapsedTime);
            if (Field != null)
            {
                ElapsedTimeLogger.Instance.Log(Convert.ToInt32(Field.GetValue()));
            }
        }
    }
}
