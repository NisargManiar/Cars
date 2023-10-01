using Car.Models;
using Car.Repository.Interface;

namespace Car.Repository
{
    public class UsersRepository : IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public UsersRepository(ApplicationDbContext dbContext) {

            _dbContext = dbContext;
        }
        public  async Task<User> Login(string username, string Password)
        {
            throw new NotImplementedException();
        }

        public async Task<User> Regitestion(User user)
        {
            throw new NotImplementedException();
        }
    }
}
