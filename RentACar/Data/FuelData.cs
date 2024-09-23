using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Data
{
    public class FuelData
    {
        private List<Fuel> fuels = new List<Fuel>()
{
        new Fuel(),
};

        public Fuel Add(Fuel car)
        {
            fuels.Add(fuel);
            return fuel;
        }

        public List<Fuel> GetAllCars() {
            return fuels; }

        public Fuel GetById(int id)
        {
            Fuel? fuel = fuels.SingleOrDefault(x => x.Id == id);
            return fuel;
        }

        public Fuel Delete(int id)
        {
            Fuel? fuel = GetById(id);

            if (fuel is not null)
            {
                fuels.Remove(fuel);
            }
            else
            {
                return null;
            }

            return fuel;

        }

        public Fuel Update(int id, Fuel uFuel)
        {
            Fuel? fuel = GetById(id);

            if (fuel is not null)
            {
                fuel = new Fuel(
    id: uFuel.Id,
    colorId: uFuel.ColorId,
    fuelId: uFuel.FuelId,
    transmissionId: uFuel.TransmissionId,
    carState: uFuel.CarState,
    kiloMeter: uFuel.KiloMeter,
    modelYear: uFuel.ModelYear,
    plate: uFuel.Plate,
    brandName: uFuel.BrandName,
    modelName: uFuel.ModelName,
    modelName: uFuel.ModelName,
    dailyPrice: uFuel.DailyPrice
    );
            }

            return fuel;

        }
    }
}
