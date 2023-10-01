using Car.Models;

namespace Car.Repository.Interface
{
    public interface ICarsRepository
    {
        Task<Cars> GetCars();
        Task<Cars> GetCarsSingle(int carId);
        Task<Cars> CreateCars(Cars cars);
        Task<Cars> UpdateCars(Cars cars);
        Task<Cars> DeleteCars(int carId);
    }
}
