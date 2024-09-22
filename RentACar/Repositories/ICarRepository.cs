using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Repositories
{
    internal class ICarRepository
    {
        public List<Category> GetAll()
        {
            return categories;
        }

        public Category? GetById(int id)
        {
            // L1 
            Category? category = categories.SingleOrDefault(x => x.Id == id);
            return category;
        }

        public Category Add(Category category)
        {
            categories.Add(category);
            return category;
        }

        public Product Delete(int id)
        {
            Product? product = GetById(id);

            if (product is not null)
            {
                products.Remove(product);
            }
            else
            {
                return null;
            }

            return product;
        }



    }
}
