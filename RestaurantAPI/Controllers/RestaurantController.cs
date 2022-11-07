using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestaurantAPI.Entities;

namespace RestaurantAPI.Controllers
{
    [Route("api/restaurant")]
    public class RestaurantController : ControllerBase
    {
        private readonly RestaurantDbContext _dbContext;

        public RestaurantController(RestaurantDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public ActionResult<IEnumerable<Restaurant>> GetAll()
        {
            var restaurants = _dbContext
                .Restaurants
                .ToList();

            return Ok(restaurants);
        }
    }
}