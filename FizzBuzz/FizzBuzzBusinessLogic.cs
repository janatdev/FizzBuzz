using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzBusinessLogic
    {       
        public static void FizzBuzz(int startNo, int endNo)
        {
            Enumerable.Range(startNo, endNo)
                .Select(n => (n, new[] { (3, "Fizz"), (5, "Buzz") }
                    .Where(t => n % t.Item1 == 0).Select(t => t.Item2))
                ).Select(t => t.Item2.Any() ? string.Join("", t.Item2) : t.Item1.ToString())
                .ToList().ForEach(Console.WriteLine);
        }
    }    
}
