using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Data
{
    internal class ColorData
    {
        private List<Color> colors = new List<Color>()
{
        new Color(),
};

        public Color Add(Color color)
        {
            colors.Add(color);
            return color;
        }

        public List<Color> GetAllCars() {
            return color; }

        public Color GetById(int id)
        {
            Color? color = colors.SingleOrDefault(x => x.Id == id);
            return color;
        }

        public Color Delete(int id)
        {
            Color? color = GetById(id);

            if (car is not null)
            {
                colors.Remove(color);
            }
            else
            {
                return null;
            }

            return color;

        }

        public Color Update(int id)
        {
            Color? color = GetById(id);

            if (color is not null)
            {
                color = new Color(
    id: updatedCar.Id,
    colorName: updateColorName.ColorId,
    );
            }

            return color;

        }       
    }
}
