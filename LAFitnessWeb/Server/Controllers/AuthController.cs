using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LAFitnessWeb.Server.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TooEnsure.Lib;
using TooEnsure.Lib.Client.Models.Authentication;

namespace LAFitnessWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepository;

        public AuthController(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegister requst)
        {
            var reponse = await _authRepository.Register(
                new User
                {
                    Username = requst.Username,
                    Email = requst.Email,
                    DateOfBirth = requst.DataOfBirth,
                    IsConfirmed = requst.IsConfirmed
                }, requst.Password);


            if (!reponse.Success)
            {
                BadRequest(reponse);
            }

            return Ok(reponse);
        }
    }
}
