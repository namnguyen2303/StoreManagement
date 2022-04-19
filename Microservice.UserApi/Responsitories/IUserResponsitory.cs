using Microservice.UserApi.DbContexts.Enities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microservice.UserApi.Responsitories
{
    public interface IUserResponsitory
    {
        List<User> Get();
    }
}
