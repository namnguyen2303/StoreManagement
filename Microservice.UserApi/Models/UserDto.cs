using System;

namespace Microservice.UserApi.Models
{
    public class UserDto
    {
        public Guid Id { get; set; } 
        public string Username { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RoleId { get; set; }
        //public DateTime CreatedDate { get; set; } = DateTime.Now;
        //public DateTime ModifyDate { get; set; };
    }
}
