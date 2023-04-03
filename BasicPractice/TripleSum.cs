using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    public class TripleSum
    {
        public void Values()
        {
            Console.WriteLine("Enter First Number");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int Y = Convert.ToInt32(Console.ReadLine());
            if (X == Y)
            {
                Console.WriteLine((X + Y)*3);
            }
            else if (X != Y)
            {
                Console.WriteLine(X + Y);
            }
        }
    }
}
