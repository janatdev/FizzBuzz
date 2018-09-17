using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************FizzBuzz Application****************");
            Console.WriteLine(@"****************Prints the numbers from 1 to 100, inclusive\n ");
            Console.WriteLine(@"****************For Multiple of Three, Fizz will display.\n ");
            Console.WriteLine(@"****************For Multiple of Five, Buzz will display.\n ");
            Console.WriteLine(@"****************For Multiple of both Three and Five, FizzBuzz will display.\n ");
            FizzBuzzBusinessLogic.FizzBuzz(1,100);
            Console.ReadLine();
        }        
    }
}