using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Models;

namespace Services.Repository
{
    public interface IUserFileRepository
    {
        UserFile GetUserFile(int id);

        List<UserFile> GetUserFiles();

        void InsertUserFile(UserFile userFile);

        void UpdateUserFile(UserFile userFile);

        void DeleteUserFile(int id);
    }
}

