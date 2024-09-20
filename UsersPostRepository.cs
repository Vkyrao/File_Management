using DAL.EntityFramework;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class UsersPostRepository : IUsersPostRepository
    {
        private readonly FileManagementContext _context;

        public UsersPostRepository(FileManagementContext context)
        {
            _context = context;
        }

        public void DeleteUsersPost(int id)
        {
            UsersPost usersPost = GetUsersPost(id);
            if (usersPost != null)
            {
                _context.UsersPost.Remove(usersPost);
                _context.SaveChanges();
            }
        }

        public UsersPost GetUsersPost(int id)
        {
            return _context.UsersPost.Find(id) ?? throw new InvalidOperationException($"UsersPost with id {id} not found.");
        }

        public List<UsersPost> GetUsersPosts()
        {
            List<UsersPost> usersPosts = new List<UsersPost>();
            usersPosts = _context.UsersPost.ToList();
            return usersPosts;
        }

        public void InsertUsersPost(UsersPost usersPost)
        {
            _context.UsersPost.Add(usersPost);
            _context.SaveChanges();
        }

        public void UpdateUsersPost(UsersPost usersPost)
        {
            _context.UsersPost.Update(usersPost);
            _context.SaveChanges();
        }
    }
}
