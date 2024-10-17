using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace llab5
{
    public class Phone
    {
        public string Name { get; set; }

        public string Model { get; set; }

        public string Cost { get; set; }

        public string ReleaseYear { get; set; }

        public string YearOfPurchase { get; set; }

        public string BatteryCapacity { get; set; }

        public bool Has3Cameras { get; set; }

        public bool HasWirelessCharging { get; set; }

        public Phone()
        { }


        public Phone(string name, string model, string cost, string releaseyear, string yearofpurchase,
            string batterycapacity, bool has3cameras, bool haswirelesscharging)
        {
            Name = name; Model = model; Cost = cost; ReleaseYear = releaseyear;
            YearOfPurchase = yearofpurchase; BatteryCapacity = batterycapacity;
            Has3Cameras = has3cameras; HasWirelessCharging = haswirelesscharging;
        }
    }
}
