using Microservice.UserApi.DbContexts.Enities;
using Microservice.UserApi.Responsitories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microservice.UserApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserResponsitory _userResponsitory;

        public UsersController(IUserResponsitory userResponsitory)
        {
            _userResponsitory = userResponsitory;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var users = _userResponsitory.Get();
            return Ok(users);
        }
    }
}
