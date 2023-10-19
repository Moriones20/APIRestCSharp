using Api.Data.Repositories;
using Api.Model;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class CarsController : Controller
    {
        private readonly CarRepository _carRepository;

        public CarsController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCars()
        {
            return Ok(await _carRepository.GetAllCars());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetCarDetails(int id)
        {
            return Ok(await _carRepository.GetDetails(id));
        }

        [HttpPost]
        public async Task<ActionResult> CreateCar([FromBody] Car car)
        {
            if (car == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var created = await _carRepository.InsertCar(car);

            return Created("created", created);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateCar([FromBody] Car car)
        {
            if (car == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _carRepository.UpdateCar(car);

            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteCar(int id)
        {
            await _carRepository.DeleteCar(new Car { Id = id });
            return NoContent();
        }

    }
}
