using elosztott_gyak.Model;
using elosztott_gyak.Persistance;
using Microsoft.AspNetCore.Mvc;

namespace elosztott_gyak.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CarController : Controller
    {
        [HttpGet(Name = nameof(GetCar))]
        public Car GetCar([FromHeader] string licensePlate)
        {
            return CarDb.GetInstance().GetCar(licensePlate);
        }

        [HttpPost(Name = nameof(AddCar))]
        public void AddCar([FromBody] Car car)
        {
            CarDb.GetInstance().AddCar(car);
        }


    }
}
