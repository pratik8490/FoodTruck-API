using FoodTrucks.DAL;
using FoodTrucks.Provider;
using FoodTrucks.Provider.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using User = FoodTrucks.DAL.User;

namespace FoodTrucks.API.Controllers
{
    public class UserController : ApiController
    {
        private readonly IUser _userProvider = new UserProvider();

        public IHttpActionResult GetAll()
        {
            return Ok(_userProvider.GetAll());
        }
        public IHttpActionResult GetByDeviceID(string deviceID)
        {
            User user = _userProvider.GetAll().Where(x => x.DeviceID == deviceID).FirstOrDefault();

            if (user != null)
            {
                return Ok(user);
            }
            else
            {
                return NotFound();
            }
        }
        public IHttpActionResult Post(User objUser)
        {
            int id = 0;
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                id = _userProvider.Add(objUser);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Ok(id);
        }

        public IHttpActionResult GetById(int id)
        {
            User user = _userProvider.GetById(id);

            if (user == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(user);
            }
        }
        public IHttpActionResult Login(string email, int pin)
        {
            User user = _userProvider.GetAll().Where(x => x.Email == email && x.Pin == pin).FirstOrDefault();

            if (user != null)
                return Ok(true);
            else
                return Ok(false);
        }
        public IHttpActionResult LogOff(string deviceID)
        {
            try
            {
                _userProvider.LogOff(deviceID);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
