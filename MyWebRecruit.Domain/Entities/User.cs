using System;

namespace MyWebRecruit.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreateTime { get; set; }
        public byte AdminYn { get; set; }
    }
}
