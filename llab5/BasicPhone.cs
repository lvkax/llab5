using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace llab5
{
    public class BasicPhone : Phone
    {
        public string Name { get; set; }

        public string Model { get; set; }

        public string Cost { get; set; }

        public string ReleaseYear { get; set; }

        public string YearOfPurchase { get; set; }

        public string GetPhoneInfo()
        {
            return $"{Name} {Model} - Released: {ReleaseYear},Purchased: {YearOfPurchase}, Price: {Cost},";
        }
    }
}
