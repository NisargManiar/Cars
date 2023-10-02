using Car.Models;

namespace Car.Repository.Interface
{
    public interface ICarsRepository
    {
        Task<IEnumerable<Cars>> GetCars();
        Task<Cars> GetCarsById(int carId);
        Task<Cars> InsertCars(Cars cars);
        Task<Cars> UpdateCars(Cars cars);
        bool DeleteCars(int carId);
    }
}
