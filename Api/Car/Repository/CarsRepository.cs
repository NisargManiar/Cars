using Car.Models;
using Car.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Car.Repository
{
    public class CarsRepository : ICarsRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ILogger<CarsRepository> _logger;
        public CarsRepository(ApplicationDbContext dbContext, ILogger<CarsRepository> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public async Task<IEnumerable<Cars>> GetCars()
        {
            _logger.LogInformation("Get Car List Loging Method Called");
            return await _dbContext.Cars.ToListAsync();
        }

        public async Task<Cars> GetCarsById(int carId)
        {
            _logger.LogInformation("Get Single Car get Loging Method Called");
            return await _dbContext.Cars.FindAsync(carId);
        }
        public async Task<Cars> InsertCars(Cars cars)
        {
            _logger.LogInformation("Create Car Loging Method Called");
            await _dbContext.Cars.AddAsync(cars);
            await _dbContext.SaveChangesAsync();
            return cars;
        }

        public bool DeleteCars(int carId)
        {
            _logger.LogInformation("Delete Car Loging Method Called");
            bool result = false;
            var Cars = _dbContext.Cars.Find(carId);
            if (Cars != null)
            {
                _dbContext.Entry(Cars).State = EntityState.Deleted;
                _dbContext.SaveChanges();
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        public async Task<Cars> UpdateCars(Cars cars)
        {
            _logger.LogInformation("Update Car Loging Method Called");
            _dbContext.Entry(cars).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return cars;
        }
    }
}
