using AcademyEMS.Data.DTO;
using AcademyEMS.Data.DTO.User;
using AcademyEMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace AcademyEMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTypeController : ControllerBase
    {
        private readonly IUserTypeService _userTypeService;

        public UserTypeController(IUserTypeService userTypeService)
        {
            _userTypeService = userTypeService;
        }

        [HttpGet("GetAllUserTypes")]
        public IActionResult Get()
        {
            UserTypeResponse response;
            try
            {
                response = _userTypeService.GetAll();
            }
            catch (Exception ex)
            {
                response = new UserTypeResponse
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

        [HttpPost("CreateUserType")]
        public IActionResult CreateUserType(CreateUserTypeRequest userType)
        {
            UserTypeResponse response;
            try
            {
                response = _userTypeService.CreateUserType(userType);
            }
            catch (Exception ex)
            {
                response = new UserTypeResponse
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

        [HttpPost("UpdateUserType")]
        public IActionResult UpdateUserType(UpdateUserTypeRequest userType)
        {
            UserTypeResponse response;
            try
            {
                response = _userTypeService.UpdateUserType(userType);
            }
            catch (Exception ex)
            {
                response = new UserTypeResponse
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

        [HttpPost("DeleteUserType")]
        public IActionResult DeleteCourseType(int id)
        {
            UserTypeResponse response;
            try
            {
                response = _userTypeService.DeleteUserType(id);
            }
            catch (Exception ex)
            {
                response = new UserTypeResponse
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

