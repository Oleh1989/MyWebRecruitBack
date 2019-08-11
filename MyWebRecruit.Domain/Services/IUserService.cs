using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWebRecruit.Domain.Entities;

namespace MyWebRecruit.Domain.Services
{
    public interface IUserService
    {
        void GetUserList();
        void CreateUser();
        void UpdateUser(User user);
        void DeleteUser(User user);
    }
}
