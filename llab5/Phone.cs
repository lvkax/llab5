using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace llab5
{
    public interface Phone
    {
        string Name { get; set; }
        string Model { get; set; }
        string Cost { get; set; }
        string ReleaseYear { get; set; } 
        string YearOfPurchase { get; set; }

        string GetPhoneInfo();
    }
}
