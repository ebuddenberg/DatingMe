using System.Threading.Tasks;

namespace DatingApp.API.BusinessClasses.Interfaces
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);
         Task<User> Login(string username,string password);
         Task<bool> UserExists(string username);
    }
}