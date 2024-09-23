using RentACar.Data;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Service
{
    internal class FuelService
    {
        private FuelData fuelData = new FuelData();
        public void Add(Fuel fuel)
        {
           fuelData.Add(fuel);
        }
        public void GetById(int id)
        {
            Fuel? fuel = fuelData.GetById(id);
            if (fuel is null)
            {
                Console.WriteLine($"Aradığınız Id ye göre Fuel bulunamadı :{id}");
                return;
            }
            Console.WriteLine($"Seçilen id: {id}");
            Console.WriteLine(car);
        }
        public void Delete(int id)
        {
            Fuel? fuel = fuelData.Delete(id);
            if (fuel is null)
            {
                Console.WriteLine($"Bulunamadı : Id= {id}");
                return;
            }
            Console.WriteLine("Silindi.");
            Console.WriteLine(fuel);
        }
        public void GetAll()
        {
            List<Fuel> fuels = fuelData.GetAll();
            fuels.ForEach(x => Console.WriteLine(x));
        }

        public void Update(int id, Car uFuel)
        {
            Fuel? fuel = fuelData.Update(id, updatedCar);
            if (fuel is null)
            {
                Console.WriteLine($"Güncellemek istediğiniz bilgi bulunamadı: Id= {id}");
                return;
            }
            Console.WriteLine("Güncellendi.");
            Console.WriteLine(fuel);
        }
    }
}
