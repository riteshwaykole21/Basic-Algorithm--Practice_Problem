using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    public class TrueValue
    {
        public void Live()
        {
            Console.WriteLine("Enter First Values");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Values");
            int Y = Convert.ToInt32(Console.ReadLine());
        }
        public TrueValue(int X, int Y)
        {
            Console.WriteLine(X == 30 || Y == 30 || (X + Y == 30));
        }
    }
}
