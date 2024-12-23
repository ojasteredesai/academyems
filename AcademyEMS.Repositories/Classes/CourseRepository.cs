using AcademyEMS.CoreDbContext;
using AcademyEMS.CoreDbContext.Entities;
using AcademyEMS.Data.DTO;
using AcademyEMS.Data.Enums;

namespace AcademyEMS.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly AppDbContext _dbContext;
        public CourseRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int CreateUser(Course course)
        {

            _dbContext.Course.Add(course);
            _dbContext.SaveChanges();
            return course.Id;
        }

        public List<CourseDTO> GetAll()
        {
            var courses = from course in _dbContext.Course
                        select new CourseDTO
                        {
                            Id = course.Id,
                            CourseDescription = course.CourseDescription,
                            CourseName = course.CourseName,
                            CourseTypeId = course.CourseTypeId
                        };
            return courses.ToList();
        }

        public CourseDTO GetByCourseId(int id)
        {
            var courseById = (from course in _dbContext.Course
                             where course.Id == id
                          select new CourseDTO
                          {
                              Id = course.Id,
                              CourseDescription = course.CourseDescription,
                              CourseName = course.CourseName,
                              CourseTypeId = course.CourseTypeId
                          }).FirstOrDefault();
            return courseById;
        }

        public List<CourseDTO> GetByCourseType(int id)
        {
            var courses = from course in _dbContext.Course
                          where course.CourseTypeId == id
                          select new CourseDTO
                          {
                              Id = course.Id,
                              CourseDescription = course.CourseDescription,
                              CourseName = course.CourseName,
                              CourseTypeId = course.CourseTypeId
                          };
            return courses.ToList();
        }
    }
}
