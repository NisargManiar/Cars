using Car.Models;
using Car.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Car.Repository
{
    public class UsersRepository : IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ILogger<IUserRepository> _logger;
        public UsersRepository(ApplicationDbContext dbContext ,ILogger<IUserRepository> logger) {

            _dbContext = dbContext;
            _logger = logger;
        }
        public  async Task<Users> Login(string username, string Password)
        {
            _logger.LogInformation("Get User Loging Method Called");
            //var user = await (from x in _dbContext.Users where x.Email == username && x.Password == Password).ToListAsync();


            _dbContext.SaveChanges();   

            throw new NotImplementedException();
        }

        public async Task<Users> Regitestion(Users user)
        {
            _logger.LogInformation("Get User Regitestion Method Called");
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
            return user;
        }
    }
}
