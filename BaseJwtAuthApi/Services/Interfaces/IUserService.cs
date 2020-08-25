using EtainTechnicalTest.Data.Model;

namespace EtainTechnicalTest.Services
{
    public interface IUserService
    {
        UserModel Authenticate(string username, string password);
    }
}
