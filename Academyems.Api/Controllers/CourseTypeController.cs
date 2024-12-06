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
            return (result != null) ? Ok(result) : NotFound();
        }

        [HttpPost("CreateCourseType")]
        public IActionResult CreateCourseType(CreateCourseTypeRequest courseType)
        {
            return Ok(_courseTypeService.CreateCourseType(courseType));
        }
    }
}
