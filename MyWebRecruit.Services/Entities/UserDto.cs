using System;

namespace MyWebRecruit.Services.Entities
{
    public class UserDto
    {
        public int? Id { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }
        public DateTime CreateTime { get; set; }
        public byte AdminYn { get; set; }
    }
}
