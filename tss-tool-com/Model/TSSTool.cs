using System;
using System.Collections.Generic;
using Dynastream.Fit;
using System.IO;

namespace Models
{
    public class TSSTool
    {
        private static TSSTool Instance = null;

        public static TSSTool GetInstance()
        {
            if (Instance == null)
            {
                return new TSSTool();
            }
            else {
                return Instance;
            }
        }

        public Boolean DecodeFile(FileStream fitSource)
        {
            Decode decoder = new Decode();
            MesgBroadcaster Broadcaster = new MesgBroadcaster();

            decoder.MesgEvent += Broadcaster.OnMesg;
            decoder.MesgDefinitionEvent += Broadcaster.OnMesgDefinition;

            //add HrMesg listener HeartRateMesgListener
            Broadcaster.RecordMesgEvent += HeartRateMesgListener.MesgEvent;
            Broadcaster.SessionMesgEvent += ElapsedTimeMesgListener.MesgEvent;
            Broadcaster.MesgEvent += PowerEncoderListener.MesgEvent;
            Broadcaster.MesgDefinitionEvent += PowerEncoderListener.MesgDefinitionEvent;

            Boolean status = decoder.IsFIT(fitSource);
            status &= decoder.CheckIntegrity(fitSource);

            Boolean DecodeResult;
            if (status)
            {
                HeartRateLogger.Instance.Reset();
                DecodeResult = decoder.Read(fitSource);
            }
            else{
                try
                    {
                        Console.WriteLine("Integrity Check Failed {0}", fitSource.Name);
                        if (decoder.InvalidDataSize)
                        {
                            Console.WriteLine("Invalid Size Detected, Attempting to decode...");
                            DecodeResult = decoder.Read(fitSource);
                        }
                        else
                        {
                            Console.WriteLine("Attempting to decode by skipping the header...");
                            DecodeResult = decoder.Read(fitSource, DecodeMode.InvalidHeader);
                        }
                    }
                    catch (FitException ex)
                    {
                        Console.WriteLine("DecodeDemo caught FitException: " + ex.Message);
                        DecodeResult = false;
                    }
            }
            fitSource.Dispose();
            return DecodeResult;
           
        }

        public Boolean EncodeFile(int TSS, int FTP)
        {
            FileStream fitOutput = new FileStream("wwwroot/files/modifiedFile.fit", FileMode.Create);
            var averagePower = (int) (Math.Sqrt(FTP*FTP*TSS*36/ElapsedTimeLogger.Instance.ElapsedTime));
            PowerEncoderListener.Instance.Reset(averagePower);



            Encode encode = new Encode(fitOutput,ProtocolVersion.V10);
                        
            Boolean EncodeResult = false;
            if (MesgLogger.Instance.Mesgs.Count > 0 )
            {
                try {
                    foreach (MesgDefinition mesgDef in MesgDefLogger.Instance.Mesgs)
                    {
                        encode.Write(mesgDef);
                    }
                    encode.Write(MesgLogger.Instance.Mesgs);
                    EncodeResult = true;
                } catch (FitException ex)
                {
                        Console.WriteLine("Encoder caught FitException: " + ex.Message);
                        EncodeResult = false;
                }
            }
            encode.Close();
            fitOutput.Dispose();
            Console.WriteLine("finishing up in the encode");
            return EncodeResult;
        }

    }
}
