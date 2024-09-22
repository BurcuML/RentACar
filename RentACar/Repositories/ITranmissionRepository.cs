using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Repositories
{
    internal class ITranmissionRepository
    {
        CategoryData categoryData = new CategoryData();

        public void GetAll()
        {
            List<Category> categories = categoryData.GetAll();

            foreach (Category category in categories)
            {
                Console.WriteLine(category);
            }
        }
    }
}
