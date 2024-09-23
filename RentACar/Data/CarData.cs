using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using RentACar.Models;
using RentACar.Models.Dtos;

namespace RentACar.Data
{
    public class CarData
    {
        private List<Car> cars = new List<Car>()
{
        new Car(),
};

        public Car Add(Car car)
        {
            cars.Add(car);
            return car;
        }

        public List<Car> GetAllCars() {
            return cars; }

        public Car GetById(int id)
        {
            Car? car = cars.SingleOrDefault(x => x.Id == id);
            return car;
        }

        public Car Delete(int id)
        {
            Car? car = GetById(id);

            if (car is not null)
            {
                cars.Remove(car);
            }
            else
            {
                return null;
            }

            return car;

        }

        public Car Update(int id, Car car)
        {
            Car? car = GetById(id);

            if (car is not null)
            {
                car = new Car(
    id: updatedCar.Id,
    colorId: updatedCar.ColorId,
    fuelId: updatedCar.FuelId,
    transmissionId: updatedCar.TransmissionId,
    carState: updatedCar.CarState,
    kiloMeter: updatedCar.KiloMeter,
    modelYear: updatedCar.ModelYear,
    plate: updatedCar.Plate,
    brandName: updatedCar.BrandName,
    modelName: updatedCar.ModelName,
    modelName: updatedCar.ModelName,
    dailyPrice: updatedCar.DailyPrice
    );
            }

            return car;

        }
        public List<CarDetailDto> GetDetails(List<Color> colors, List<Fuel> fuels, List<Transmission> transmissions)
        {
            var result = from car in cars
                         join co in colors on car.ColorId equals co.Id
                         join fu in fuels on car.FuelId equals fu.Id
                         join trm in transmissions on car.TransmissionId equals trm.Id


                         select new CarDetailDto(
                    Id: car.Id,
                    ColorName: co.ColorName,
                    FuelName: fu.Name,
                    TransmissionName: trm.Name,
                    CarState: car.CarState,
                    KiloMeter: car.KiloMeter,
                    ModelYear: car.ModelYear,
                    Plate: car.Plate,
                    BrandName: car.BrandName,
                    ModelName: car.ModelName,
                    DailyPrice: car.DailyPrice
                             );

            return result.ToList();
        }

    }
}
