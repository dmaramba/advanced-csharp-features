using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LU1Theme2
{
    public class WeekDays
    {

        //private storage/ internal storage
        private string[] days = new string[7];

        //indexer
        
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= days.Length)
                    throw new ArgumentOutOfRangeException("Invalid index");
                return days[index];
            }
            set
            {
                if (index < 0 || index >= days.Length)
                    throw new ArgumentOutOfRangeException("Invalid index");
                days[index] = value;
            }
        }
        

    }
}
