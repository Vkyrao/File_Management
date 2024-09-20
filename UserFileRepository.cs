using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.EntityFramework;
using Domain.Models;

namespace Services.Repository
{
    public class UserFileRepository : IUserFileRepository
    {
        private FileManagementContext _context;

        public UserFileRepository(FileManagementContext context)
        {
            _context = context;
        }

        public void DeleteUserFile(int id)
        {
            UserFile userFile = GetUserFile(id);
            if (userFile != null)
            {
                _context.UserFiles.Remove(userFile);
                _context.SaveChanges();
            }
        }

        public UserFile GetUserFile(int id)
        {
            UserFile? userFile = _context.UserFiles.Find(id);
            return userFile ?? throw new InvalidOperationException($"UserFile with id {id} not found.");
        }

        public List<UserFile> GetUserFiles()
        {
            List<UserFile> userFiles = new List<UserFile>();
            userFiles = _context.UserFiles.ToList();
            return userFiles;
        }

        public void InsertUserFile(UserFile userFile)
        {
            _context.UserFiles.Add(userFile);
            _context.SaveChanges();
        }

        public void UpdateUserFile(UserFile userFile)
        {
            _context.UserFiles.Update(userFile);
            _context.SaveChanges();
        }
    }
}


