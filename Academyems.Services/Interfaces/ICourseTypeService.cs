using AcademyEMS.Data.DTO;

namespace AcademyEMS.Services
{
    public interface ICourseTypeService
    {
        CourseTypeResponse GetAll();
        CourseTypeDTO GetByID(int id);
        List<CourseTypeDTO> GetByCourseId(int courseId);
        List<CourseTypeDTO> GetByCourseTypeID(int id);
        CourseTypeResponse CreateCourseType(CreateCourseTypeRequest request);
        CourseTypeResponse UpdateCourseType(UpdateCourseTypeRequest request);
        CourseTypeResponse DeleteCourseType(int id);
    }
}
