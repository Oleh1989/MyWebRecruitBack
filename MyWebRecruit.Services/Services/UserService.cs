using System;
using System.Collections.Generic;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using MyWebRecruit.Data.Entities;
using MyWebRecruit.Services.Services;
using MyWebRecruit.Services.Entities;
using MyWebRecruit.Services.Interfaces;
using MyWebRecruit.Services.Extensions;
using MyWebRecruit.Data.UnitOfWorks;

namespace MyWebRecruit.Services
{
    public class UserService : BaseService, IUserService
    {
        public UserService(IUnitOfWork uow) : base(uow)
        {

        }

        public List<UserDto> GetUserList()
        {
            return _uow.UserRepository.GetAll().Select(x => x.ToDto()).ToList();
        }

        public UserDto GetUser(int id)
        {
            return _uow.UserRepository.GetById(id).ToDto();
        }

        public void CreateUser(UserDto userDto)
        {
            _uow.UserRepository.Add(userDto.ToData());
            _uow.Save();
        }

        public void UpdateUser(UserDto userDto)
        {
            _uow.UserRepository.Update(userDto.ToData());
            _uow.Save();
        }

        public void DeleteUser(int id)
        {
            _uow.UserRepository.Delete(id);
            _uow.Save();
        }
    }
}
