using System;
public static class Tools
{
    static long startTime;

    public static void start()
    {
        startTime=GetTimeStampMsec();   
    }

    public static long end()
    {
        return GetTimeStampMsec()-startTime;
    }

    static long GetTimeStampMsec()
    {
        TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
        return Convert.ToInt64(ts.TotalMilliseconds);
    }
}