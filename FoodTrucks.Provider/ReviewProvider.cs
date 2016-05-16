using FoodTrucks.DAL;
using FoodTrucks.Provider.Interface;
using FoodTrucks.Provider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTrucks.Provider
{
    public class ReviewProvider : IReview
    {
        public ReviewDetailModel GetByTruckId(int truckID)
        {
            using (FoodTrucksDbEntities context = new FoodTrucksDbEntities())
            {
                context.Configuration.ProxyCreationEnabled = false;

                var result = (from r in context.Reviews
                              join u in context.Users on r.UserId equals u.Id
                              where r.TruckId == truckID
                              select new ReviewDetailModel
                              {
                                  Description = r.Description,
                                  FirstName = u.FirstName,
                                  LastName = u.LastName
                              }).FirstOrDefault();

                return result;
            }
        }
    }
}
