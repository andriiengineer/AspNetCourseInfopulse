using HW1.Models;

using Microsoft.AspNetCore.Mvc;

namespace HW1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : Controller
    {
        private static List<Car> cars = new List<Car>()
        {
            new Car(),
            new Car { Id =  1, Make = "BMW", Model = "325d", Price = 88000, FuelType = FuelType.Diesel },
            new Car { Id = 2, Make = "Mazda" , Model = "3", Price = 20000, FuelType = FuelType.Petrol },
            new Car { Id = 3, Make = "Tesla", Model = "Model X", Price = 58000, FuelType = FuelType.Electric},
        };

        [HttpGet]
        public ActionResult<List<Car>> Get()
        {
            return Ok(cars);
        }
    }
}
