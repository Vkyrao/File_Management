using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public interface IUsersPostRepository
    {
        UsersPost GetUsersPost(int id);

        List<UsersPost> GetUsersPosts();

        void InsertUsersPost(UsersPost usersPost);

        void UpdateUsersPost(UsersPost usersPost);

        void DeleteUsersPost(int id);
    }
}
