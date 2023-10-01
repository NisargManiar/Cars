using Car.Models;

namespace Car.Repository.Interface
{
    public interface IUserRepository
    {
        Task<User> Regitestion(User user);
        Task<User> Login(string username ,string Password);
    }
}
