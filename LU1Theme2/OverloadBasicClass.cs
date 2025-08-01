using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LU1Theme2
{
    internal class OverloadBasicClass
    {

        public int X { get; set; }
        public int Y { get; set; }

        public OverloadBasicClass(int x, int y)
        {
            X = x; 
            Y = y;
        }

        //Overload with +
        public static OverloadBasicClass operator +(OverloadBasicClass a, OverloadBasicClass b)
        {
            return new OverloadBasicClass(a.X + b.X, a.Y + b.Y);
        }

    }
}
