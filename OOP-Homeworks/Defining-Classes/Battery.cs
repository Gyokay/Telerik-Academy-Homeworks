using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes
{
    public class Battery
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;

        private BatteryType batteryType;

        public Battery() : this("Unkonown Model", 50, 5, BatteryType.LiIon)
        {

        }

        public Battery(string model) : this(model, 50, 5, BatteryType.LiIon)
        {
 
        }

        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType batteryType)
        {
            this.BatteryType = batteryType;
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ApplicationException("Model must be different then \"null\" or \"empty\"");
                }

                model = value;
            }
        }

        public BatteryType BatteryType
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }

        public int HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value <= 0)
                {
                    throw new ApplicationException("Hours idle must be greater then 0");
                }

                this.hoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value <= 0)
                {
                    throw new ApplicationException("Hours talk must be greater then 0");
                }

                this.hoursTalk = value;
            }
        }
    }
}
