using System;
using System.Collections.Generic;
using Dynastream.Fit;

namespace Models
{
    public class PowerEncoderListener
    {
        static volatile PowerEncoderListener instance;
        public static int Power {get;set;}
        public static PowerEncoderListener Instance
        {
            get 
            {
                object syncRoot = new Object();
                if (instance == null) 
                {
                    lock (syncRoot) 
                    {
                    if (instance == null) 
                        instance = new PowerEncoderListener();
                    }
                }

                return instance;
            }
        }
        public static void MesgEvent(object sender, MesgEventArgs e)
        {
            if (e.mesg.Name.Equals("Record"))
            {
                Field PowerField = e.mesg.GetField(RecordMesg.FieldDefNum.Power);
                if (PowerField != null)
                {
                    PowerField.SetValue(Power);
                }
                else{
                    e.mesg.SetFieldValue(7, Power);
                }   
            }
            MesgLogger.Instance.Log(e.mesg);
        }

        public static void MesgDefinitionEvent(object sender, MesgDefinitionEventArgs e)
        {
            MesgDefLogger.Instance.Log(e.mesgDef);
        }

        public void Reset(int NewPower)
        {
            Power = NewPower;
        }
    }
}
