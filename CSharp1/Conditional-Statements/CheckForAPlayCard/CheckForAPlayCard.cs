using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckForAPlayCard
{
    class CheckForAPlayCard
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type some character");
            string a = Console.ReadLine();

            switch (a)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "A":
                case "Q":
                case "J":
                case "K": Console.WriteLine("Yes!"); break;

                default: Console.WriteLine("No!");
                    break;
            }
                  
        }
    }
}
