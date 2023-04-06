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
            Console.WriteLine("3 : Enter The Number");
            Console.WriteLine("4 : Enter The values");
            Console.WriteLine("5 : Crete New String");
            Console.WriteLine("6 : Remove The Character ");
            Console.WriteLine("7  : Enter a String");
            Console.WriteLine("8 : Find The Length Of String");
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
                case 3:
                    Integer integer = new Integer();
                    integer.Test();
                    break;
                case 4:
                    TrueValue trueValue = new TrueValue(30,15);
                    trueValue.Live();
                    break;
                case 5:
                    Create create = new Create(" if Ritesh");
                    break;
                case 6:
                    Character character = new Character();
                    character.Given();
                    break;
                case 7:
                    Exchange exchange = new Exchange();
                    exchange.Print();
                    break;
                case 8:
                    FindfLength obj = new FindfLength();
                    obj.Triple();
                    break;
            }
            Console.ReadLine();
        }
    }
}
