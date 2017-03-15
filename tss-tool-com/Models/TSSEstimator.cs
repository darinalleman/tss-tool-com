using System.Collections.Generic;
public static class TSSEstimator
{
    private static List<HeartRateZone> HeartRateZones;
    private static IList<int> TimeInZones {get;set;}
    public static double FromHeartRate(IList<int> Zones, IList<int> HeartRates)
    {
        BuildZones(Zones);
        foreach(int HeartRate in HeartRates)
        {
            AssignZone(HeartRate);
        }
		double TSS = 0;
		TSS += TimeInZones[0] * (20.0 / 3600);
		TSS += TimeInZones[1] * (30.0 / 3600);
		TSS += TimeInZones[2] * (40.0 / 3600);
		TSS += TimeInZones[3] * (50.0 / 3600);
		TSS += TimeInZones[4] * (60.0 / 3600);
		TSS += TimeInZones[5] * (70.0 / 3600);
		TSS += TimeInZones[6] * (80.0 / 3600);
		TSS += TimeInZones[7] * (100.0 / 3600);
		TSS += TimeInZones[8] * (120.0 / 3600);
		TSS += TimeInZones[9] * (140.0 / 3600);
		return TSS;
    }
    /**
    http://home.trainingpeaks.com/blog/article/estimating-training-stress-score-tss
     */
    private static void BuildZones(IList<int> Zones)
    {
        HeartRateZones = new List<HeartRateZone>();
        HeartRateZone Zone1 = new HeartRateZone(0, Zones[0] - 40);
        HeartRateZones.Add(Zone1);
        HeartRateZone Zone2 = new HeartRateZone(Zone1.End+1, Zones[0] - 10);
        HeartRateZones.Add(Zone2);
        HeartRateZone Zone3 = new HeartRateZone(Zone2.End+1, Zones[0]);
        HeartRateZones.Add(Zone3);
        HeartRateZone Zone4 = new HeartRateZone(Zone3.End+1, Zones[1] - ((Zones[1] - Zones[0]) / 2));
        HeartRateZones.Add(Zone4);
        HeartRateZone Zone5 = new HeartRateZone(Zone4.End+1, Zones[1]);
        HeartRateZones.Add(Zone5);
        HeartRateZone Zone6 = new HeartRateZone(Zone5.End+1, Zones[2]);
        HeartRateZones.Add(Zone6);
        HeartRateZone Zone7 = new HeartRateZone(Zone6.End+1, Zones[3]);
        HeartRateZones.Add(Zone7);
        HeartRateZone Zone8 = new HeartRateZone(Zone7.End+1, Zones[3] + (Zones[4] - Zones[3]) / 3);
        HeartRateZones.Add(Zone8);
        HeartRateZone Zone9 = new HeartRateZone(Zone8.End+1,  Zones[3] + 2 * (Zones[4] - Zones[3]) / 3);
        HeartRateZones.Add(Zone9);
        HeartRateZone Zone10 = new HeartRateZone(Zone9.End+1,  Zones[4]);
        HeartRateZones.Add(Zone10);
    }

    private static void AssignZone(int HeartRate)
    {
        for (int i = 0; i < HeartRateZones.Count; i++)
        {
            if (HeartRateZones[i].Contains(HeartRate))
            {
                TimeInZones[i]++;
            }
        }
    }

}