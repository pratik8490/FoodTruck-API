using FoodTrucks.DAL;
using FoodTrucks.Provider.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTrucks.Provider
{
    public class FoodTypeProvider : IFoodType
    {
        public IEnumerable<FoodType> GetAll()
        {
            using (FoodTrucksDbEntities context = new FoodTrucksDbEntities())
            {
                var result = (from c in context.FoodTypes
                              select c).ToList();

                return result;
            }
        }

        public FoodType GetById(int id)
        {
            using (FoodTrucksDbEntities context = new FoodTrucksDbEntities())
            {
                context.Configuration.ProxyCreationEnabled = false;

                var result = (from c in context.FoodTypes
                              where c.Id == id
                              select c).FirstOrDefault();

                return result;
            }
        }
    }
}
