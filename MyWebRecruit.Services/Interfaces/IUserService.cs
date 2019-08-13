using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWebRecruit.Services.Entities;

namespace MyWebRecruit.Services.Interfaces
{
    public interface IUserService
    {
        IQueryable<UserDto> GetUserList();
        void CreateUser();
        void UpdateUser(UserDto user);
        void DeleteUser(UserDto user);
    }
}
