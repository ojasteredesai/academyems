using Academyems.CoreDbContext.Entities;
using Academyems.Data.DTO;

namespace Academyems.Repositories
{
    public interface ICourseTypeRepository
    {
        List<CourseTypeDTO> GetAll();
        CourseTypeDTO GetByID(int id);
        List<CourseTypeDTO> GetByCourseId(int courseId);
        List<CourseTypeDTO> GetByCourseTypeID(int id);
        int CreateCourseType(CourseType request);
        int UpdateCourseType(CourseType request);
        int DeleteCourseType(int id);
    }
}
