using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Company_Information
{
    class PrintCompanyInformation
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Company name:" );
            string cN = Console.ReadLine();

            Console.WriteLine("Company adres:");
            string cA = Console.ReadLine();

            Console.WriteLine("Phone nuber:");
            string pN = Console.ReadLine();

            Console.WriteLine("Web Site:");
            string wS = Console.ReadLine();

            Console.WriteLine("Manager first name:");
            string mFN = Console.ReadLine();

            Console.WriteLine("Manager last name:");
            string mLN = Console.ReadLine();

            Console.WriteLine("Manager age:");
            string mA = Console.ReadLine();

            Console.WriteLine("Manager phone:");
            string mP = Console.ReadLine();

            Console.WriteLine("{0}\n Address: {1}\n Tel. {2}\n Web Site:{3}\n Manager: {4} {5} ( age: {6}, tel. {7} )", cN, cA, pN, wS, mFN, mLN, mA, mP );
        }
    }
}
