using AcademyEMS.CoreDbContext.Entities;
using AcademyEMS.Data.DTO;
using AcademyEMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace AcademyEMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseTypeController : ControllerBase
    {
        private readonly ICourseTypeService _courseTypeService;

        public CourseTypeController(ICourseTypeService courseTypeService)
        {
            _courseTypeService = courseTypeService;
        }

        [HttpGet("GetAllCourseTypes")]
        public IActionResult Get()
        {
            CourseTypeResponse response;
            try
            {
                response = _courseTypeService.GetAll();
            }
            catch (Exception ex)
            {
                response = new CourseTypeResponse
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

        [HttpPost("CreateCourseType")]
        public IActionResult CreateCourseType(CreateCourseTypeRequest courseType)
        {
            CourseTypeResponse response;
            try
            {
                response = _courseTypeService.CreateCourseType(courseType);
            }
            catch (Exception ex)
            {
                response = new CourseTypeResponse
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

        [HttpPost("UpdateCourseType")]
        public IActionResult UpdateCourseType(UpdateCourseTypeRequest courseType)
        {
            CourseTypeResponse response;
            try
            {
                response = _courseTypeService.UpdateCourseType(courseType);
            }
            catch (Exception ex)
            {
                response = new CourseTypeResponse
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

        [HttpPost("DeleteCourseType")]
        public IActionResult DeleteCourseType(int id)
        {
            CourseTypeResponse response;
            try
            {
                response = _courseTypeService.DeleteCourseType(id);
            }
            catch (Exception ex)
            {
                response = new CourseTypeResponse
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
