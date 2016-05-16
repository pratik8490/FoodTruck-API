using FoodTrucks.DAL;
using FoodTrucks.Provider.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTrucks.Provider
{
    public class UserProvider : IUser
    {
        public List<User> GetAll()
        {
            using (FoodTrucksDbEntities context = new FoodTrucksDbEntities())
            {
                var result = context.Users;

                return result.ToList();
            }
        }
        public int Add(User user)
        {
            using (FoodTrucksDbEntities context = new FoodTrucksDbEntities())
            {
                user.CreatedAt = DateTime.Now;
                user.ModifiedAt = DateTime.Now;

                context.Users.Add(user);
                context.SaveChanges();

                return user.Id;
            }
        }

        public User GetById(int id)
        {
            using (FoodTrucksDbEntities context = new FoodTrucksDbEntities())
            {
                var result = (from c in context.Users
                              where c.Id == id
                              select c).FirstOrDefault();

                return result;
            }
        }

        public void LogOff(string deviceID)
        {
            using (FoodTrucksDbEntities context = new FoodTrucksDbEntities())
            {
                User user = context.Users.Where(x => x.DeviceID == deviceID).FirstOrDefault();
                context.Users.Remove(user);
                context.SaveChanges();
            }
        }
    }
}
