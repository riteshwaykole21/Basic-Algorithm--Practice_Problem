using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    public class Character
    {
        public void Given()
        {
            Console.WriteLine(test("Python",1));
            Console.WriteLine(test("Python", 0));
            Console.WriteLine(test("Python", 4));
        }
        public static string test(string str, int n)
        {
            return str.Remove(n, 1);
        }
    }
}
