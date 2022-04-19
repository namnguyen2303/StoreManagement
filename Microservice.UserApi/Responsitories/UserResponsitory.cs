using Microservice.UserApi.DbContexts.Enities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microservice.UserApi.Responsitories
{
    public class UserResponsitory : IUserResponsitory
    {
        private List<User> _listUser = new List<User>();
        public List<User> Get()
        {
            _listUser.Add(new User()
            {
                Id = new Guid(),
                Username = "namnv",
                FirstName = "Nam",
                LastName = "Nguyen",
                RoleId = 1
            });

            return _listUser;
        }
    }
}
