using System;
using System.Collections.Generic;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using MyWebRecruit.Domain.Services;
using MyWebRecruit.Data.MyWebRecruit.Data.Entities;

namespace MyWebRecruit.Services
{
    class UserService : BaseService, IUserService
    {
        public UserService(MyWebRecruitDataBaseContext dataBaseContext) : base(dataBaseContext)
        {

        }

        public void GetUserList()
        {
            using (var context = new MyWebRecruitDataBaseContext())
            {
                IQueryable<User> users = context.User
                    .Where(x => x.IsDeleted == false)
                    .OrderBy(x => x.UserName);
            }
        }

        public void CreateUser()
        {
            string userNameDummy = string.Empty, userEmailDummy = string.Empty, userPaswordDummy = string.Empty;
            byte isAdminDummy = 0;
            string exceptionMessage = null;
            bool isEmailValid = false;
            using (var context = new MyWebRecruitDataBaseContext())
            {
                exceptionMessage = Logic.NullOrEmptyField(userNameDummy, userEmailDummy, userPaswordDummy);
                isEmailValid = Logic.EmailValidation(userEmailDummy);
                if (exceptionMessage == null && isEmailValid)
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
        }        

        public void UpdateUser(Domain.Entities.User user)
        {
            string userNameDummy = string.Empty, userEmailDummy = string.Empty, userPasswordDummy = string.Empty;
            byte isAdminDummy = 0;
            string exceptionMessage = null;
            using (var context = new MyWebRecruitDataBaseContext())
            {
                // Get entity by id
                var userToUpdate = context.User.FirstOrDefault(u => u.Id == user.Id);

                if (userToUpdate != null)
                {
                    exceptionMessage = Logic.NullOrEmptyField(userNameDummy, userEmailDummy, userPasswordDummy);
                    if (exceptionMessage == null)
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
        }

        public void DeleteUser(Domain.Entities.User user)
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
