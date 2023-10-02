using Car.Models;

namespace Car.Repository.Interface
{
    public interface IUserRepository
    {
        Task<Users> Regitestion(Users users);
        Task<Users> Login(string username ,string Password);
    }
}
