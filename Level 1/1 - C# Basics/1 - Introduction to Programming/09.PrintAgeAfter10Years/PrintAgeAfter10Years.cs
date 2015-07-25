using System;
using System.Collections.Generic;

class PrintAgeAfter10Years
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write your birthday date in dd/mm/yy format");
        DateTime Birthday = new DateTime();
        Birthday = DateTime.Parse(Console.ReadLine());
        int AgeNow = DateTime.Now.Year - Birthday.Year;
        if (Birthday.Month >= DateTime.Now.Month && Birthday.Day > DateTime.Now.Day)
        {
            AgeNow--;
        }
        int AgeAfter10Years = AgeNow + 10;
        Console.WriteLine("Your age now: {0}",AgeNow);
        Console.WriteLine("Your age after 10 years: {0}", AgeAfter10Years);
    }
}