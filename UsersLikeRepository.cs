using DAL.EntityFramework;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class UsersLikeRepository : IUsersLikeRepository
    {
        private readonly FileManagementContext _context;

        public UsersLikeRepository(FileManagementContext context)
        {
            _context = context;
        }

        public void DeleteUsersLike(int id)
        {
            UsersLike usersLike = GetUsersLike(id);
            if (usersLike != null)
            {
                _context.UsersLike.Remove(usersLike);
                _context.SaveChanges();
            }
        }

        public UsersLike GetUsersLike(int id)
        {
            return _context.UsersLike.Find(id) ?? throw new InvalidOperationException($"UsersLike with id {id} not found.");
        }

        public List<UsersLike> GetUsersLikes()
        {
            List<UsersLike> usersLikes = new List<UsersLike>();
            usersLikes = _context.UsersLike.ToList();
            return usersLikes;
        }

        public void InsertUsersLike(UsersLike usersLike)
        {
            _context.UsersLike.Add(usersLike);
            _context.SaveChanges();
        }

        public void UpdateUsersLike(UsersLike usersLike)
        {
            _context.UsersLike.Update(usersLike);
            _context.SaveChanges();
        }
    }
}
