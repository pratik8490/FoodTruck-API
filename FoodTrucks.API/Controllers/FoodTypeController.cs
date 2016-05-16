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
    public class FoodTypeController : ApiController
    {
        private readonly IFoodType _FoodTypeProvider = new FoodTypeProvider();

        public FoodTypeController()
        {

        }
        public IHttpActionResult GetAll()
        {
            List<FoodType> foodTypeList = _FoodTypeProvider.GetAll().ToList();

            if (foodTypeList != null && foodTypeList.Count > 0)
                return Ok(foodTypeList);
            else
                return NotFound();
        }
        public IHttpActionResult GetById(int id)
        {
            FoodType foodType = _FoodTypeProvider.GetById(id);

            if (foodType == null)
                return NotFound();
            else
                return Ok(foodType);
        }
    }
}
