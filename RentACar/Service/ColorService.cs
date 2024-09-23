using RentACar.Data;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Service
{
    public class ColorService
    {
        private ColorData colorData = new ColorData();
        public void Add(Color color)
        {
            colorData.Add(color);
        }
        public void GetById(int id)
        {
            Color? color = colorData.GetById(id);
            if (color is null)
            {
                Console.WriteLine($"Aradığınız Id ye göre araba bulunamadı :{id}");
                return;
            }
            Console.WriteLine($"Seçilen araba id si: {id}");
            Console.WriteLine(color);
        }
        public void Delete(int id)
        {
            Color? color = colorData.Delete(id);
            if (color is null)
            {
                Console.WriteLine($"Araba Bulunamadı : Id= {id}");
                return;
            }
            Console.WriteLine("Araba  Silindi.");
            Console.WriteLine(color);
        }
        public void GetAll()
        {
            List<Color> colors = colorData.GetAllColors();
            colors.ForEach(x => Console.WriteLine(x));
        }

        public void Update(int id, Car uColor)
        {
            Color? color = colorData.Update(id, uColor);
            if (color is null)
            {
                Console.WriteLine($"Güncellemek istediğiniz araba bulunamadı: Id= {id}");
                return;
            }
            Console.WriteLine("Araba güncellendi.");
            Console.WriteLine(color);
        }
    }
}
