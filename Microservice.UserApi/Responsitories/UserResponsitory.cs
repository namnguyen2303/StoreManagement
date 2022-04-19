using Microservice.UserApi.DbContexts;
using Microservice.UserApi.DbContexts.Enities;
using Microservice.UserApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.UserApi.Responsitories
{
    public class UserResponsitory : IUserResponsitory
    {
        private readonly UserDbContext _dbContext;

        public UserResponsitory(UserDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<User>> Get()
        {
            var users = await _dbContext.Users.ToListAsync();
            return users;
        }
        public async Task<User> GetById(string Id)
        {
            var user = await _dbContext.Users.Where(u => u.Id.ToString() == Id).FirstOrDefaultAsync();
            return user;
        }
        public User Add(UserDto u)
        {
            User user = new User()
            {
                Id = Guid.NewGuid(),
                Username = u.Username,
                LastName = u.LastName,
                FirstName = u.FirstName,
                RoleId = u.RoleId,
            };
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return user;
        }
        public async Task Update(UserDto u)
        {
            var user = await _dbContext.Users.Where(u => u.Id == u.Id).FirstOrDefaultAsync();
            if (user != null)
            {
                user.Username = u.Username;
                user.LastName = u.LastName;
                user.FirstName = u.FirstName;
                user.RoleId = u.RoleId;
            }
            _dbContext.SaveChanges();
        }
        public async Task Delete(Guid Id)
        {
            var user = await _dbContext.Users.Where(u => u.Id == u.Id).FirstOrDefaultAsync();
            if(user != null) _dbContext.Users.Remove(user);
        }
    }
}
