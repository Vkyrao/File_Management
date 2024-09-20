using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public interface IUsersLikeRepository
    {
        UsersLike GetUsersLike(int id);

        List<UsersLike> GetUsersLikes();

        void InsertUsersLike(UsersLike usersLike);

        void UpdateUsersLike(UsersLike usersLike);

        void DeleteUsersLike(int id);
    }
}
