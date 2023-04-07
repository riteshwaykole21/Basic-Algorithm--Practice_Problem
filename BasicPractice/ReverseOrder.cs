using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    public class ReverseOrder
    {
        public void Order()
        {
            Console.WriteLine(" Enter a String ");
            string Name = Console.ReadLine();
            char [] Chars = Name.ToCharArray(); 
            Array.Reverse(Chars);
            string reversed = new string(Chars);
            Console.WriteLine("Reversed String : " + reversed);
        }
    }
}
