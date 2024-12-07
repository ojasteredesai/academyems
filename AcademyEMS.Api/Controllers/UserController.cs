using AcademyEMS.Data.DTO;
using AcademyEMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace AcademyEMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetAllUsers")]
        public IActionResult Get()
        {
            UserResponse response;
            try
            {
                response = _userService.GetAll();
            }
            catch (Exception ex)
            {
                response = new UserResponse
                {
                    Error = ex.Message,
                    Success = false
                };
            }
            finally
            {

            }
            return Ok(response);
        }


        [HttpPost("CreateUser")]
        public IActionResult CreateUser(CreateUserRequest user)
        {
            UserResponse response;
            try
            {
                response = _userService.CreateUser(user);
            }
            catch (Exception ex)
            {
                response = new UserResponse
                {
                    Error = ex.Message,
                    Success = false
                };
            }
            finally
            {

            }
            return Ok(response);
        }
    }
}
