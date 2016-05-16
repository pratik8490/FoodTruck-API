using FoodTrucks.DAL;
using FoodTrucks.Provider;
using FoodTrucks.Provider.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FoodTrucks.API.Controllers
{
    public class TruckInfoController : ApiController
    {
        private readonly ITruckDetail _truckProvider = new TruckDetailProvider();

        public TruckInfoController()
        {

        }
        public IHttpActionResult Add(TruckDetail truckDetail)
        {
            try
            {
                int newId = _truckProvider.Add(truckDetail);
                return Ok(newId);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        public IHttpActionResult GetAll()
        {
            try
            {

                List<TruckDetail> lstTruck = _truckProvider.GetAll().ToList();

                if (lstTruck.Count > 0)
                    return Ok(lstTruck);
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
