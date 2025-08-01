

using LU1Theme2;
using System.Diagnostics.CodeAnalysis;

//indexer exmaple
///new IndexerLog();
///
//Basic overloading
/*
var basic = new BasicOverloading();
basic.Add(100, 10); //method overloading
basic.Add(100, 10, 20); //method overloading
basic.Add(100, "Joe"); //method overloading
*/

//Without opertor overloading
/*
var object1 = new BasicClass();
var object2 = new BasicClass();
object1.X = 10;
object2.X = 20;
object1.Y = 30;
object2.Y = 30;

//X= 30
//Y =60
//var result= object1 + object2; //not allowed withoput operator overload
var result = new BasicClass();
result.X = object1.X + object2.X;
result.Y = object1.Y + object2.Y;

Console.WriteLine("No overloading");
Console.WriteLine($"The new point is {result.X},{result.Y}");

*/
/*
//Operar over loading
var object3 = new OverloadBasicClass(10, 30);
var object4 = new OverloadBasicClass(20, 30);
var result2 = object3 + object4; ///invoking operator overloading
Console.WriteLine("With operator overloading");
Console.WriteLine($"The new point is {result2.X},{result2.Y}");

//Money Example

Money t1 = new Money(500, 136);
Money t2 = new Money(200, 75);
//Rands - 702.11
var result3 = t1 + t2;//invoking operator overloading
Console.WriteLine($"The total for 2 tills is R{result3.Rands},{result3.Cents}");

*/

//Conversion using Convert Class
/*
ConversionClass  conversionClass= new ConversionClass();
Console.WriteLine("Please a year");
var year = Console.ReadLine();
conversionClass.ConvertMethod(year);

//conversionClass.TryParseMethod(year);
*/

//Extensions
/*
Console.WriteLine("Please enter a sentence");
var sentence = Console.ReadLine();
Console.WriteLine($"The length of '{sentence} is {sentence.GetLength()}");

Console.WriteLine("Please enter a name");
var firstName = Console.ReadLine();
Console.WriteLine($"The cleaned value  '{firstName} is {firstName.ReplaceSpecialCharacters()}");

Console.WriteLine("Please enter a last name");
var lastName = Console.ReadLine();
Console.WriteLine($"The cleaned value  '{lastName} is {lastName.ReplaceSpecialCharacters()}");


Console.WriteLine("Please enter a mark");
var mark = Console.ReadLine();
if (mark.IsNumeric())
    Console.WriteLine($"The mark  '{mark} is valid");
else
{
    Console.WriteLine($"The mark  '{mark} is not a vlaid number");
}

Console.WriteLine("Please enter a price");
var price = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"The price in US currency  {price.ToCurrency("en-US")}");
Console.WriteLine($"The price in ZA currency  {price.ToCurrency("en-ZA")}");
Console.WriteLine($"The price in ZM currency  {price.ToCurrency("en-ZM")}");
*/

//Anonymous example

new AnonymousType();
Console.ReadKey();

