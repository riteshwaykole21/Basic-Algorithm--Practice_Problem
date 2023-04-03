using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 : Sum Of Two Given Integer Value");
            Console.WriteLine("2 : Enter The Values");
            Console.WriteLine("Enter The Option");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch(Option)
            {
                case 1:
                    TripleSum triple = new TripleSum();
                    triple.Values();
                    break;
                case 2:
                    Absolute absolute = new Absolute();
                    absolute.Diffences();
                    break;
            }
            Console.ReadLine();
        }
    }
}
