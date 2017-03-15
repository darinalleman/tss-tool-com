using System.Collections.Generic;
public class HeartRateZone
{
    public int Start {get;set;}
    public int End {get;set;}
    public HeartRateZone(int Start, int End)
    {
        this.Start = Start;
        this.End = End;
    }

    public bool Contains(int Number)
    {
        if (Number >= this.Start && Number <= this.End)
        {
            return true;
        }
        return false;
    }
    

}