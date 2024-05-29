using MyWebRecruit.Data.Entities;
using MyWebRecruit.Services.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebRecruit.Services.Extensions
{
    public static class UserExtension
    {
        public static UserDto ToDto(this User user)
        {
            if (user == null)
                return null;

            var userDto = new UserDto
            {
                AdminYn = user.AdminYn,
                CreateTime = user.CreateTime,
                Id = user.Id,
                Password = user.Password,
                UserEmail = user.UserEmail,
                UserName = user.UserName
            };

            return userDto;
        }

        public static User ToData(this UserDto userDto)
        {
            if (userDto == null)
                return null;

            var user = new User
            {
                AdminYn = userDto.AdminYn,
                CreateTime = userDto.CreateTime,
                Id = userDto.Id.Value,
                Password = userDto.Password,
                UserEmail = userDto.UserEmail,
                UserName = userDto.UserName                
            };

            return user;
        }
    }
}
