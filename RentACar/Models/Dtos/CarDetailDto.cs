using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Models.Dtos
{
    internal class CarDetailDto
    (
        int Id,
        string ColorName,
        int FuelName,
        int TransmissionName,
        string CarState,
        int? KiloMeter,
        short? ModelYear,
        string? Plate,
        string? BrandName,
        string? ModelName,
        double? DailyPrice
    );
}
