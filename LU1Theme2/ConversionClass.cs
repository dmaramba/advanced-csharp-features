using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LU1Theme2
{
    internal class ConversionClass
    {

        public void Simple()
        {
            //implicit  conversion

            int num1 = 123;
            long num2 = num1;
            float num3 = num1;
            Console.WriteLine($"Value for num1 ={num1}");
            Console.WriteLine($"Value for num2 ={num2}");
            Console.WriteLine($"Value for num3 ={num3}");


            //Explicit conversion//
            //casting
            // targetType num5=(targetType)num4
            double num4 = 100.45;
            int num5 = (int)num4;
            Console.WriteLine($"Value for num4 ={num4}");
            Console.WriteLine($"Value for num5 ={num5}");


            //Object convert a number/strinh

            Object a = 10;
            object b = 20;
            object c = "John";
            object d = "Doe";

            var objectResult = (int)a + (int)b;
            Console.WriteLine($"Value for object summation ={objectResult}");

            var objectResult2 = (string)c + (string)d;
            Console.WriteLine($"Value for object string ={objectResult2}");

            //casting using as
            var objectResult3 = (c as string) + (d as string);
            Console.WriteLine($"Value for object using as keyword ={objectResult3}");
        }


        public void ConvertMethod(string year )
        {
            try
            {
               // string year = "2004";
                int yearValue = Convert.ToInt32(year);// will throw an exception if year is not a numeric value
                int age = DateTime.Now.Year - yearValue;
                Console.WriteLine($"Age is {age}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid number");
            }
        }

        public void TryParseMethod(string year)
        {
            if (Int32.TryParse(year, out int yearValue))
            {
                int age = DateTime.Now.Year - yearValue;
                Console.WriteLine($"Age is {age}");
            }
            else
            {
                Console.WriteLine($"The value entered '{year}' is not a valid number");
            }
        }
    }
}
