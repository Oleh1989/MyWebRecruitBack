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
        List<UserDto> GetUserList();
        UserDto GetUser(int id);
        void CreateUser(UserDto userDto);
        void UpdateUser(UserDto userDto);
        void DeleteUser(int id);
    }
}
