using FoodTrucks.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTrucks.Provider.Interface
{
    public interface IBar
    {
        IEnumerable<Bar> GetAll();
        Bar GetById(int id);
    }
}
