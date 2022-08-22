using System;
using System.Globalization;
 
class Program
{
    static void Main(string[] args)
    {
        uint day = uint.Parse(Console.ReadLine());
        string[] days = CultureInfo.CurrentCulture.DateTimeFormat.DayNames;
        Console.WriteLine(day == 7 ? days[0] : day <= 6 && day >= 1 ? days[day] : "ERROR");
        Console.ReadKey(true);
    }
}