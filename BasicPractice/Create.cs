using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    public class Create
    {
        public Create(string S)
        {
            if(S.Length > 2 && S.Substring(0 ,2).Equals("if"))
            {
                Console.WriteLine( S );
            }
            Console.WriteLine("if " + S );
        }
    }
}
