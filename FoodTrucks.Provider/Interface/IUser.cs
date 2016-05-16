using FoodTrucks.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTrucks.Provider.Interface
{
    public interface IUser
    {
        List<User> GetAll();
        int Add(User User);
        User GetById(int Id);
        void LogOff(string DeviceID);
    }
}
