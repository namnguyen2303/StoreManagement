using Microservice.UserApi.DbContexts;
using Microservice.UserApi.DbContexts.Enities;
using Microservice.UserApi.Models;
using Microservice.UserApi.Responsitories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
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
        public async Task<IActionResult> Get()
        {
            try
            {
                var users = await _userResponsitory.Get();
                return Ok(users);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            try {
                var user = await _userResponsitory.GetById(id);
                if (user != null) return Ok(user);
                else
                {
                    return NotFound();
                }
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


        [HttpPost]
        public IActionResult Add(UserDto u)
        {
            var user = _userResponsitory.Add(u);
            return Ok(new
            {
                Success = true,
                Data = user
            });
        }
        [HttpPut]
        public async Task<IActionResult> Update(UserDto u)
        {
            try
            {
                await _userResponsitory.Update(u);
                return NoContent();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await _userResponsitory.Delete(id);
                return Ok();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
