using FoodTrucks.DAL;
using FoodTrucks.Provider;
using FoodTrucks.Provider.Interface;
using FoodTrucks.Provider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FoodTrucks.API.Controllers
{
    public class ReviewController : ApiController
    {
        private readonly IReview _ReviewProvider = new ReviewProvider();

        public ReviewController()
        {

        }

        public IHttpActionResult GetByTruckID(int truckId)
        {
            ReviewDetailModel reviewDetail = _ReviewProvider.GetByTruckId(truckId);

            if (reviewDetail == null)
                return NotFound();
            else
                return Ok(reviewDetail);
        }
    }
}
