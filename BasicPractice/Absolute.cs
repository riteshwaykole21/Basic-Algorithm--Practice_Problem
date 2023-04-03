using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    public class Absolute
    {
        public void Diffences()
        {
            Console.WriteLine("Enter The Values");
            int N = Convert.ToInt32(Console.ReadLine());
            int Y = 0;
            int X = 51;
            if(N > X)
            {
                Console.WriteLine((N - X)*3);
            }
            else
                Console.WriteLine(X-N);
        }
    }
}
