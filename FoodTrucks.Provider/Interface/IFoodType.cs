using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodTrucks.DAL;

namespace FoodTrucks.Provider.Interface
{
    public interface IFoodType
    {
        IEnumerable<FoodType> GetAll();
        FoodType GetById(int id);
    }
}
