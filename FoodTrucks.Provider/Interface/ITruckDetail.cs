using FoodTrucks.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTrucks.Provider.Interface
{
    public interface ITruckDetail
    {
        IEnumerable<TruckDetail> GetAll();
        TruckDetail GetById(int id);
        int Add(TruckDetail truckDetail);
        void Update(TruckDetail truckDetail);
    }
}
