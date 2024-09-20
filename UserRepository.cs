using DAL.EntityFramework;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly FileManagementContext FileManagementContext;

        public UserRepository(FileManagementContext fileManagementContext)
        {
            FileManagementContext = fileManagementContext;
        }

        public void DeleteUser(int id)
        {
            User? user = FileManagementContext.Users.Find(id);
            if (user == null)
            {
                throw new KeyNotFoundException($"User with ID {id} not found.");
            }
            FileManagementContext.Users.Remove(user);
            FileManagementContext.SaveChanges();
        }

        public User GetUser(int id)
        {
            User? user = FileManagementContext.Users.Find(id);
            if (user == null)
            {
                throw new KeyNotFoundException($"User with ID {id} not found.");
            }
            return user;
        }

        public List<User> GetUsers()
        {
            List<User> users = FileManagementContext.Users.ToList();
            return users;
        }

        public void InsertUser(User user)
        {
            FileManagementContext.Users.Add(user);
            FileManagementContext.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            FileManagementContext.Users.Update(user);
            FileManagementContext.SaveChanges();
        }
    }
}
