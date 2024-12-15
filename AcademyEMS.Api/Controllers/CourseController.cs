using AcademyEMS.Data.DTO;
using AcademyEMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace AcademyEMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet("GetAllCourses")]
        public IActionResult Get()
        {
            CourseResponse response;
            try
            {
                response = _courseService.GetAll();
            }
            catch (Exception ex)
            {
                response = new CourseResponse
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


        [HttpPost("CreateCourse")]
        public IActionResult CreateCourse(CreateCourseRequest course)
        {
            CourseResponse response;
            try
            {
                response = _courseService.CreateUser(course);
            }
            catch (Exception ex)
            {
                response = new CourseResponse
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
