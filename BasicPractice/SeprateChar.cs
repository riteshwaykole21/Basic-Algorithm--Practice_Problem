using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    public class SeprateChar
    {
        public void Input()
        {
            Console.WriteLine("Enter A string");
            string Name = Console.ReadLine();
            int i = 0;
            while (i <= Name.Length - 1)
            {
                Console.Write("{0} ", Name[i]);
                i++;
            }
        }
    }
}
