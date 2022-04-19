using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Microservice.UserApi.DbContexts.Enities
{
    [Table("user")]
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RoleId { get; set; }
    }
}
