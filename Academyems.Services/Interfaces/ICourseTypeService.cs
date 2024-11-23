using Academyems.CoreDbContext.Entities;
using Academyems.Data.DTO;

namespace Academyems.Services
{
    public interface ICourseTypeService
    {
        List<CourseTypeDTO> GetAll();
        CourseTypeDTO GetByID(int id);
        List<CourseTypeDTO> GetByCourseId(int courseId);
        List<CourseTypeDTO> GetByCourseTypeID(int id);
        int CreateCourseType(CourseType request);
    }
}
