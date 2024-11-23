using Academyems.CoreDbContext.Entities;
using Academyems.Data.DTO;
using Academyems.Services;
using Microsoft.AspNetCore.Mvc;

namespace Academyems.Api.Controllers
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
            var result = _courseTypeService.GetAll();
            if (result != null)
            {
                return Ok(new CourseTypeResponse
                {
                    CourseTypes = result,
                    Success = true
                });
            }

            return NotFound();
        }

        [HttpPost("CreateCourseType")]
        public IActionResult CreateCourseType(CreateCourseTypeRequest courseType)
        {
            CourseType inputCourseType = new CourseType
            {
            };

            int createdId = _courseTypeService.CreateCourseType(inputCourseType);
            if (createdId > 0)
            {
                CreateCourseTypeResponse response = new CreateCourseTypeResponse
                {
                    Success = true
                };

                return Ok(response);
            }

            return Ok(new CreateCourseTypeResponse
            {
                Success = false,
                Error = "Error while creating profile!"
            });
        }
    }
}
