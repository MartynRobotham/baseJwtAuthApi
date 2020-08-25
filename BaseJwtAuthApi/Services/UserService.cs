using EtainTechnicalTest.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtainTechnicalTest.Services
{
    public class UserService : IUserService
    {
        public UserModel Authenticate(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) return null;
            // Would usually point to a database, but going to check hard coded creds here instead
            if (username.ToLower().Equals("martyn") && password.Equals("password"))
            {
                // If connected to DB, would use hash & salt or associated authentication mechanism
                return new UserModel
                {
                    Id = 1,
                    Username = "Martyn",
                    Password = "password"
                };
            }
            else return null;

        }
    }
}
