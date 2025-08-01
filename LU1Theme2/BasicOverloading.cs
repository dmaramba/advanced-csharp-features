using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LU1Theme2
{
    internal class BasicOverloading
    {
        public BasicOverloading()
        {
            //calculation
            int x = 10, y = 20;
            var sum = x + y; //+ to perfom arithmetic calculation
            Console.WriteLine($"The value of {x}+{y} = {sum}");

            string name = "John";
            var result = name + x;//+ to perfom concatination - join

            var result2 = String.Concat(name, x);
            Console.WriteLine($"The value of {name}+{x} = {result}");
            Console.WriteLine($"The value of Concat for {name} and {x} = {result2}");

        }

        public void Add(int x,int y)
        {
            Console.WriteLine("Addition numbers only");
            var sum = x + y;
            Console.WriteLine($" value of {x}+{y} = {sum}");
        }

        public void Add(int x, int y, int z)
        {
            Console.WriteLine("Addition numbers only");
            var sum = x + y + z;
            Console.WriteLine($" value of {x}+{y}+{z} = {sum}");
        }

        public void Add(int x, string name)
        {
            Console.WriteLine("Addition number and text");
            var result = name + x;
            Console.WriteLine($"Addition method number/text of {name}+{x} = {result}");
        }

    }
}
