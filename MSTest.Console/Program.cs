using MSTest.Library.Services;
using System;

namespace MSTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here are your 8 random characters:");
            Console.WriteLine(ValueService.GetRandomString());
            Console.WriteLine("Now go away, shoo!");

            Console.ReadKey();
        }
    }
}
