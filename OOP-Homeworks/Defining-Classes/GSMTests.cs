using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes
{
    class GSMTests
    {
        static void Main()
        {
            GSMTest();
            GSMCallHistoryTest();
        }

        private static void GSMTest()
        {
            GSM[] gsms = new GSM[3];

            gsms[0] = new GSM("Galaxy S7", "Samsung", 2000, "Samsung");
            gsms[1] = new GSM("Nexus 20", "Google", 1000, "Google");
            gsms[2] = new GSM("G5", "LG", 1800, "LG");

            gsms[0].ToString();
            gsms[1].ToString();
            gsms[2].ToString();

            GSM.IPhone.ToString();

            GSM someGsm = new GSM("Galaxy S7", "Samsung", 3000, "Samsung", new Display(1080, 8000000), new Battery("Samsung", 78, 34, BatteryType.NiMH));

            someGsm.ToString();
            someGsm.Display.NumberOfColors.ToString();

            someGsm.CallHistory.Add(new Call("0887616795", 6));
            Console.WriteLine(someGsm.CallHistory[0].DialedPhone);
        }

        private static void GSMCallHistoryTest()
        {
            GSM gsm = new GSM("3310", "Nokia", new Display(5, 2), new Battery("Nokis", 300, 100, BatteryType.AlienTech));

            gsm.AddCall("0887634856", 5);
            gsm.AddCall("0887342758", 20);
            gsm.AddCall("0884859046", 56);

            double totalPrice = gsm.CallculateTotalPrice(0.35);
            Console.WriteLine("Total price calcualted");
            Console.WriteLine(totalPrice);

            gsm.DeleteCall(2);
            Console.WriteLine("Longest call removed");

            totalPrice = gsm.CallculateTotalPrice(0.35);
            Console.WriteLine("Total price recalculated");
            Console.WriteLine(totalPrice);

            gsm.ClearCallHistory();
            Console.WriteLine("Call history cleared");
        }
    }
}
