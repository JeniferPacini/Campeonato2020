using Microsoft.AspNetCore.Mvc;
using Domain.Players;
using Microsoft.Extensions.Primitives;
using System;
using Domain.Users;

namespace WebAPI.Controllers.Players
{
    [ApiController]
    [Route("[controller]")]
    public class PlayersController : ControllerBase
    {
        private readonly PlayersService _playersService;
        private readonly UsersService _usersService;

        public PlayersController()
        {
            _playersService = new PlayersService();
            _usersService = new UsersService();
        }
        
        [HttpPost]
        public IActionResult Create(CreatePlayerRequest request)
        {
            StringValues userId;
            if(!Request.Headers.TryGetValue("UserId", out userId))
            {
                return Unauthorized();
            }

            var user = _usersService.GetById(Guid.Parse(userId));
            
            if(user == null)
            {
                return Unauthorized();
            }
            
            if(!user.CBF)
            {
                return Unauthorized();
                //return Forbid("Test");
            }
            var response = _playersService.Create(request.Name);

            if(!response.IsValid)
            {
                return BadRequest(response.Errors);
            }
            return Ok(response.Id);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, CreatePlayerRequest request)
        {
            StringValues userId;
            if(!Request.Headers.TryGetValue("UserId", out userId))
            {
                return Unauthorized();
            }

            var user = _usersService.GetById(Guid.Parse(userId));
            
            if(user == null)
            {
                return Unauthorized();
            }
            
            if(!user.CBF)
            {
                return Unauthorized();
            }
            var response = _playersService.Update(id, request.Name);

            if(!response.IsValid)
            {
                return BadRequest(response.Errors);
            }
            return Ok(response.Id);
        }
    }
}
