using Car.Models;
using Car.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Car.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarsRepository _carsRepository;

        public CarsController(ICarsRepository carsRepository) {

            _carsRepository = carsRepository;
        }

        [HttpPost]
        [Route("CreateCar")]
        public async Task<IActionResult> CreateCar(Cars cars)
        {
            return Ok(await _carsRepository.InsertCars(cars));
        }
        [HttpGet]
        [Route("GetCarList")]
        public async Task<IActionResult> GetCar()
        {
            return Ok(await _carsRepository.GetCars());
        }
        [HttpGet]
        [Route("GetCarsByID/{Id}")]
        public async Task<IActionResult> GetDeptById(int Id)
        {
            return Ok(await _carsRepository.GetCarsById(Id));
        }
        [HttpPut]
        [Route("UpdateCar")]
        public async Task<IActionResult> Put(Cars cars)
        {
            await _carsRepository.UpdateCars(cars);
            return Ok("Updated Successfully");
        }
        [HttpDelete]
        //[HttpDelete("{id}")]
        [Route("DeleteCar")]
        public JsonResult Delete(int id)
        {
            _carsRepository.DeleteCars(id);
            return new JsonResult("Deleted Successfully");
        }

    }
}
