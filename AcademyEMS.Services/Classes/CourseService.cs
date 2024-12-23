using AcademyEMS.CoreDbContext.Entities;
using AcademyEMS.Data.DTO;
using AcademyEMS.Repositories;

namespace AcademyEMS.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public CourseResponse CreateUser(CreateCourseRequest request)
        {
            Course inputCourse = new()
            {
                CourseTypeId = request.CourseTypeId,
                CourseDescription = request.CourseDescription,
                CourseName = request.CourseName,
                CreatedBy = 1,
                UpdatedBy = 1,
                CreatedOn = DateTime.UtcNow,
                UpdatedOn = DateTime.UtcNow
            };
            return new CourseResponse
            {
                Success = _courseRepository.CreateUser(inputCourse) > 0
            };
        }

        public CourseResponse GetAll()
        {
            return new CourseResponse
            {
                Courses = _courseRepository.GetAll(),
                Success = true
            };
        }

        public CourseResponse GetCourseByType(int id)
        {
            return new CourseResponse
            {
                Courses = _courseRepository.GetByCourseType(id),
                Success = true
            };
        }
    }
}
