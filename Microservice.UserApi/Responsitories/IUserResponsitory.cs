using Microservice.UserApi.DbContexts.Enities;
using Microservice.UserApi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microservice.UserApi.Responsitories
{
    public interface IUserResponsitory
    {
       Task<List<User>> Get();
       Task<User> GetById(string Id);
       User Add(UserDto u);
       Task Update(UserDto u);
       Task Delete(Guid Id);
    }
}
