using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodTrucks.DAL;
using FoodTrucks.Provider.Interface;

namespace FoodTrucks.Provider
{
    public class TruckDetailProvider : ITruckDetail
    {
        public IEnumerable<TruckDetail> GetAll()
        {
            using (FoodTrucksDbEntities context = new FoodTrucksDbEntities())
            {
                var result = (from c in context.TruckDetails
                              select c).ToList();

                return result;
            }
        }

        public TruckDetail GetById(int id)
        {
            using (FoodTrucksDbEntities context = new FoodTrucksDbEntities())
            {
                var result = (from c in context.TruckDetails
                              where c.Id == id
                              select c).FirstOrDefault();

                return result;
            }
        }

        public int Add(TruckDetail truckDetail)
        {
            using (FoodTrucksDbEntities context = new FoodTrucksDbEntities())
            {
                context.TruckDetails.Add(truckDetail);
                context.SaveChanges();

                return truckDetail.Id;
            }
        }

        public void Update(TruckDetail truckDetail)
        {
            using (FoodTrucksDbEntities context = new FoodTrucksDbEntities())
            {
                TruckDetail objTruckDetail = context.TruckDetails.Where(x => x.Id == truckDetail.Id).FirstOrDefault();

                objTruckDetail.TruckName = truckDetail.TruckName != null ? truckDetail.TruckName : objTruckDetail.TruckName;
                objTruckDetail.TruckDetail1 = truckDetail.TruckDetail1 != null ? truckDetail.TruckDetail1 : objTruckDetail.TruckDetail1;
                objTruckDetail.TruckDetail2 = truckDetail.TruckDetail2 != null ? truckDetail.TruckDetail2 : objTruckDetail.TruckDetail2;
                objTruckDetail.Reviews = truckDetail.Reviews != null ? truckDetail.Reviews : objTruckDetail.Reviews;
                objTruckDetail.Menu = truckDetail.Menu != null ? truckDetail.Menu : objTruckDetail.Menu;
                objTruckDetail.Longitude = truckDetail.Longitude != null ? truckDetail.Longitude : objTruckDetail.Longitude;
                objTruckDetail.Lattitude = truckDetail.Lattitude != null ? truckDetail.Lattitude : objTruckDetail.Lattitude;
                objTruckDetail.Link = truckDetail.Link != null ? truckDetail.Link : objTruckDetail.Link;
                objTruckDetail.IsActive = truckDetail.IsActive != null ? truckDetail.IsActive : objTruckDetail.IsActive;

                context.SaveChanges();
            }
        }
    }
}
