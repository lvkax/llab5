using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace llab5
{
    public class SmartPhone : Phone
    {
        public string Name { get; set; }

        public string Model { get; set; }

        public string Cost { get; set; }

        public string ReleaseYear { get; set; }

        public string YearOfPurchase { get; set; }

        public string BatteryCapacity { get; set; }

        public bool Has3Cameras { get; set; }

        public bool HasWirelessCharging { get; set; }

        public SmartPhone()
        { }


        public string GetPhoneInfo()
        {
            return $"{Name} {Model} - Released: {ReleaseYear}, " +
                $"Purchased: {YearOfPurchase} , Price: {Cost}," +
                $" Battery: {BatteryCapacity}mAh, Three Cameras: " +
                $"{Has3Cameras}, Wireless Charging: {HasWirelessCharging}";
        }
    }
}
