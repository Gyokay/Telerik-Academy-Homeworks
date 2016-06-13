using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes
{
    public class GSM
    {
        private static GSM iPhone = new GSM("iPhone", "Apple", new Display(), new Battery());

        private Battery battery;
        private Display display;

        private List<Call> callHistory;

        private string model;
        private string manufacturer;
        private double price;
        private string owner;

        public GSM(string model, string manufacturer, double price, string owner) : this(model, manufacturer, price, owner, new Display(), new Battery())
        {
        }

        public GSM(string model, string manufacturer) : this(model, manufacturer, 0.01D, "Unknown Owner", new Display(), new Battery())
        {

        }

        public GSM(string model, string manufacturer, Display display, Battery battery)
            : this(model, manufacturer, 0.01D, "Unknown Owner", display, battery)
        {

        }

        public GSM(string model, string manufacturer, double price, string owner, Display display, Battery battery)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Display = display;
            this.Battery = battery;

            this.CallHistory = new List<Call>();
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (value == null)
                {
                    throw new ApplicationException("Model must be specified");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value == null)
                {
                    throw new ApplicationException("Manufacturer must be specified");
                }

                this.manufacturer = value;
            }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                {
                    throw new ApplicationException("Price must have a positive value");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (value == null)
                {
                    throw new ApplicationException("Owner must be specified");
                }

                this.owner = value;
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }

        public static GSM IPhone
        {
            get { return iPhone; }
        }

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
            set
            {
                this.callHistory = value;
            }
        }

        public override string ToString()
        {
            string fullInformation = $" MODEL: {this.model} \n MANUFACTURER: { this.manufacturer} \n PRICE: {this.price} \n OWNER: {this.owner} \n BATTERY INFO \n BATTERY MODEL: {this.battery.Model} \n BATTERY TYPE: {this.Battery.BatteryType} \n BATTERY Hours Idle: {this.battery.HoursIdle} \n BATTERY Hours Talk: {this.battery.HoursTalk} \n DISPLAY INFO \n Display Size: {this.display.Size} \n Display Colors: {this.display.NumberOfColors} \n ";
            Console.WriteLine(fullInformation);

            return fullInformation;
        }

        public void AddCall(string dialerPhone, double callDuration)
        {
            this.CallHistory.Add(new Call(dialerPhone, callDuration));
        }

        public void DeleteCall(int index)
        {
            if (callHistory.Count < 1)
            {
                throw new ApplicationException("Call history is empty");
            }

            if ((this.CallHistory.Count <= index - 1) || (index - 1 < 0))
            {
                throw new ApplicationException("Such call history log does not exist!");
            }

            this.callHistory.RemoveAt(index);
        }


        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        public double CallculateTotalPrice(double price)
        {
            double totalPrice = 0.00D;

            foreach (var call in this.CallHistory)
            {
                totalPrice += call.CallDuration;
            }

            return totalPrice * price;
        }
    }
}
