using Car.Models;
using Car.Repository.Interface;

namespace Car.Repository
{
    public class CarsRepository : ICarsRepository
    {
        public async Task<Cars> CreateCars(Cars cars)
        {
            throw new NotImplementedException();
        }

        public async Task<Cars> DeleteCars(int carId)
        {
            throw new NotImplementedException();
        }

        public async Task<Cars> GetCars()
        {
            throw new NotImplementedException();
        }

        public async Task<Cars> GetCarsSingle(int carId)
        {
            throw new NotImplementedException();
        }

        public async Task<Cars> UpdateCars(Cars cars)
        {
            throw new NotImplementedException();
        }
    }
}
