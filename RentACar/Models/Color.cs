using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Models
{
    public record Color
    (
        int Id,
        string ColorName,
        string FuelName,
        string TransmissionName
    );
}
