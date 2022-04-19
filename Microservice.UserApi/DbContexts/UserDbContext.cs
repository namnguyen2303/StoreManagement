using Microservice.UserApi.DbContexts.Enities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Microservice.UserApi.DbContexts
{
    public class UserDbContext: DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = Guid.NewGuid(),
                Username = "namnv",
                FirstName = "Nam",
                LastName = "Nguyen",
                RoleId = 1,
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = Guid.NewGuid(),
                Username = "phunh",
                FirstName = "Phu",
                LastName = "Nguyen",
                RoleId = 1,
            });

        }
    }
}
