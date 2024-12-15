using AcademyEMS.Data.DTO;

namespace AcademyEMS.Services
{
    public interface ICourseService
    {
        CourseResponse CreateUser(CreateCourseRequest user);
        CourseResponse GetAll();
    }
}
