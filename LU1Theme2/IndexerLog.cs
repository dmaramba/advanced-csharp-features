using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LU1Theme2
{
    internal class IndexerLog
    {
        public IndexerLog()
        {
            WeekDays weekDays = new WeekDays();

            weekDays[0] = "Sunday";
            weekDays[1] = "Monday";
            weekDays[2] = "Tuesday";
            weekDays[3] = "Wednesday";
            weekDays[6] = "Friday";

            //read from indexer class
            //print only 1 item
            Console.WriteLine(weekDays[0]);

            //print all the items
            for (int i = 0; i < 7; i++)
            {
                if (!string.IsNullOrEmpty(weekDays[i]))
                    Console.WriteLine(weekDays[i]);
            }
            Console.WriteLine("Done");

            //read from invalid index
            //print only 1 item
            try
            {
                Console.WriteLine(weekDays[10]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }
}
