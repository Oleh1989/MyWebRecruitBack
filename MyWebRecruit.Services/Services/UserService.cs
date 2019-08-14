﻿using System;
using System.Collections.Generic;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using MyWebRecruit.Data.Entities;
using MyWebRecruit.Services.Services;
using MyWebRecruit.Services.Entities;
using MyWebRecruit.Services.Interfaces;

namespace MyWebRecruit.Services
{
    class UserService : BaseService, IUserService
    {
        public UserService(MyWebRecruitDataBaseContext dataBaseContext) : base(dataBaseContext)
        {

        }

        public IQueryable<UserDto> GetUserList()
        {
            IQueryable<UserDto> users;
            using (var context = new MyWebRecruitDataBaseContext())
            {
                users = context.User
                    .Cast<UserDto>()
                    .Where(x => x.IsDeleted == false)
                    .OrderBy(x => x.UserName);
            }
            return users;
        }

        public void CreateUser()
        {
            string userNameDummy = string.Empty, userEmailDummy = string.Empty, userPaswordDummy = string.Empty;
            byte isAdminDummy = 0;
            using (var context = new MyWebRecruitDataBaseContext())
            {
                var newUser = new User
                {
                    UserName = userNameDummy,
                    UserEmail = userEmailDummy,
                    Password = userPaswordDummy,
                    AdminYn = isAdminDummy,
                    IsDeleted = false,
                    CreateTime = DateTime.Now
                };

                context.User.Add(newUser);
                context.SaveChanges();

            }
        }

        public void UpdateUser(UserDto user)
        {
            string userNameDummy = string.Empty, userEmailDummy = string.Empty, userPasswordDummy = string.Empty;
            byte isAdminDummy = 0;
            using (var context = new MyWebRecruitDataBaseContext())
            {
                // Get entity by id
                var userToUpdate = context.User.FirstOrDefault(u => u.Id == user.Id);

                if (userToUpdate != null)
                {
                    userToUpdate.UserName = userNameDummy;
                    userToUpdate.UserEmail = userEmailDummy;
                    userToUpdate.Password = userPasswordDummy;
                    userToUpdate.CreateTime = DateTime.Now;
                    userToUpdate.AdminYn = isAdminDummy;

                    // Update entity in DbSet
                    context.User.Update(userToUpdate);

                    // Save changes in DbSet;
                    context.SaveChanges();

                }
            }
        }

        public void DeleteUser(UserDto user)
        {
            using (var context = new MyWebRecruitDataBaseContext())
            {
                // Get entity by id
                var userToDelete = context.User.FirstOrDefault(u => u.Id == user.Id);
                if (userToDelete != null)
                {
                    userToDelete.IsDeleted = true;

                    // Update entity in DbSet
                    context.User.Update(userToDelete);

                    // Save changes in DbSet;
                    context.SaveChanges();
                }
            }
        }
    }
}