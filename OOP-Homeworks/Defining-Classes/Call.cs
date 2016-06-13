using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes
{
    public class Call
    {
        private DateTime dateTime;
        private string dialedPhone;
        private double callDuration;

        public Call(string dialedPhone, double callDuration)
        {
            this.DateTime = DateTime.Now;
            this.DialedPhone = dialedPhone;
            this.CallDuration = callDuration;
        }

        public DateTime DateTime
        {
            get { return this.dateTime; }
            private set { this.dateTime = DateTime.Now; }
        }

        public string DialedPhone
        {
            get { return this.dialedPhone; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ApplicationException("Phonenumber can not be null or empty!");
                }
                if ((value.Length != 10 && value.Length != 13) || (value[0] != '0' && value[0] != '+'))
                {
                    throw new ApplicationException("Phonenumber must be in format +359xxxxxxxxx OR 0xxxxxxxxx !");
                }

                this.dialedPhone = value;
            }
        }

        public double CallDuration
        {
            get { return this.callDuration; }
            set { this.callDuration = value; }
        }
    }
}
