using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    public class Integer
    {
        public void Test()
        {
            Console.WriteLine("Enter a First Number");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Second Number");
            int Y = Convert.ToInt32(Console.ReadLine());
            int Z = 30;
            if (X == Z)
            {
                Console.WriteLine("True");
            }
            else if (Y == Z)
            {
                Console.WriteLine("True");
            }
            else if (X + Y == Z)
            {
                Console.WriteLine("True");
            }
        }
    }
}
