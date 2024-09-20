using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public interface IUserRepository
    {
        User GetUser(int id);

        List<User> GetUsers();

        void InsertUser(User user);

        void UpdateUser(User user);

        void DeleteUser(int id);
    }
}

