using System;

namespace mira_nb
{
    public class Time
    {
        double hour;
        double minute;
        double second;
        public void getTime(double hour, double minute, double second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
        public void showTime()
        {
            Console.WriteLine("Time : " + hour + ":" + minute + ":" + second);
        }
    }

    internal class ClassDemo1
    {
        public static void Main(string[] args)
        {
            Time t1 = new Time();
            t1.getTime(11, 28, 35);
            t1.showTime();
        }
    }
}