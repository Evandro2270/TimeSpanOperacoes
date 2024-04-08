﻿using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;


                TimeSpan t1 = TimeSpan.MaxValue;
                TimeSpan t2 = TimeSpan.MinValue;
                TimeSpan t3 = TimeSpan.Zero;

                TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

                Console.WriteLine(t1);
                Console.WriteLine(t2);
                Console.WriteLine(t3);
                Console.WriteLine(t);
                Console.WriteLine("Days: " + t.Days);
                Console.WriteLine("Hours: " + t.Hours);
                Console.WriteLine("Minutes: " + t.Minutes);
                Console.WriteLine("Milliseconds: " + t.Milliseconds);
                Console.WriteLine("Seconds: " + t.Seconds);
                Console.WriteLine("Ticks: " + t.Ticks);
                Console.WriteLine("TotalDays: " + t.TotalDays);
                Console.WriteLine("TotalHours: " + t.TotalHours);
                Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
                Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
                Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);

            }
        }
    }
}