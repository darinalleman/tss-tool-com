using System;
using System.Collections.Generic;
using Dynastream.Fit;

namespace Models
{
    public class PowerEncoderListener
    {
        public static void MesgEvent(object sender, MesgEventArgs e)
        {
            if (e.mesg.Name.Equals("Record"))
            {
                Field PowerField = e.mesg.GetField(RecordMesg.FieldDefNum.Power);
                if (PowerField != null)
                {
                    PowerField.SetValue(300);
                }
                else{
                    e.mesg.SetFieldValue(7, 300);
                }   
            }
            MesgLogger.Instance.Log(e.mesg);
        }

        public static void MesgDefinitionEvent(object sender, MesgDefinitionEventArgs e)
        {
            MesgDefLogger.Instance.Log(e.mesgDef);
        }
    }
}
