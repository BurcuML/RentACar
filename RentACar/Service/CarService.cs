using RentACar.Data;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Service
{
    public class CarService
    {
        private CarData carData = new CarData();
        public void Add(Car car)
        {
            carData.Add(car);
        }
        public void GetById(int id)
        {
            Car? car = carData.GetById(id);
            if (car is null)
            {
                Console.WriteLine($"Aradığınız Id ye göre araba bulunamadı :{id}");
                return;
            }
            Console.WriteLine($"Seçilen araba id si: {id}");
            Console.WriteLine(car);
        }
        public void Delete(int id)
        {
            Car? car = carData.Delete(id);
            if (car is null)
            {
                Console.WriteLine($"Araba Bulunamadı : Id= {id}");
                return;
            }
            Console.WriteLine("Araba  Silindi.");
            Console.WriteLine(car);
        }
        public void GetAll()
        {
            List<Car> cars = carData.GetAllCars();
            cars.ForEach(x => Console.WriteLine(x));
        }

        public void Update(int id, Car updatedCar)
        {
            Car? car = carData.Update(id, updatedCar);
            if (car is null)
            {
                Console.WriteLine($"Güncellemek istediğiniz Araba bulunamadı: Id= {id}");
                return;
            }
            Console.WriteLine("Araba güncellendi.");
            Console.WriteLine(car);
        }

    }
}
