using FoodTrucks.DAL;
using FoodTrucks.Provider.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTrucks.Provider
{
    public class BarProvider : IBar
    {
        public BarProvider()
        {

        }

        public IEnumerable<Bar> GetAll()
        {
            using (FoodTrucksDbEntities context = new FoodTrucksDbEntities())
            {
                var result = (from c in context.Bars
                              select c).ToList();

                return result;
            }
        }

        public Bar GetById(int id)
        {
            using (FoodTrucksDbEntities context = new FoodTrucksDbEntities())
            {
                context.Configuration.ProxyCreationEnabled = false;

                var result = (from c in context.Bars
                              where c.Id == id
                              select c).FirstOrDefault();

                return result;
            }
        }


    }
}
