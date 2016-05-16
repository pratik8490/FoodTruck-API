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
    public class BarController : ApiController
    {
        private readonly IBar _BarProvider = new BarProvider();

        public BarController()
        {

        }
        public IHttpActionResult GetAll()
        {
            List<Bar> barList = _BarProvider.GetAll().ToList();

            if (barList != null && barList.Count > 0)
                return Ok(barList);
            else
                return NotFound();
        }
    }
}
