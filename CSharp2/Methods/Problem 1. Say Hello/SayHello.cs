using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Say_Hello
{
    class SayHello
    {
        static void Main(string[] args)
        {
            AskAndPrintName();
        }
        static void AskAndPrintName()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!",name);
        }
    }
}
