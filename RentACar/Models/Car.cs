using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Models
{
    public record Car
    (
        int Id,
        int ColorId,
        int FuelId,
        int TransmissionId,
        string CarState,
        int? KiloMeter,
        short? ModelYear,
        string? Plate,
        string? BrandName,
        string? ModelName,
        double? DailyPrice
    );
}
