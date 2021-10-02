using System;
using System.Collections.ObjectModel;

namespace TimeZoneList
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadOnlyCollection<TimeZoneInfo> tzCollection;
            tzCollection = TimeZoneInfo.GetSystemTimeZones();

            foreach (TimeZoneInfo timeZone in tzCollection)
            {
                if (timeZone.DisplayName.Contains("-03"))
                    Console.WriteLine("   {0}: {1}", timeZone.Id, timeZone.DisplayName);
            }
                
        }
    }
}
