using Academyems.CoreDbContext.Entities;
using Academyems.Data.DTO;
using Academyems.Repositories;

namespace Academyems.Services
{
    public class CourseTypeService : ICourseTypeService
    {
        private readonly ICourseTypeRepository _courseTypeRepository;
        public CourseTypeService(ICourseTypeRepository courseTypeRepository)
        {
            _courseTypeRepository = courseTypeRepository;
        }

        public int CreateCourseType(CourseType request)
        {
            return _courseTypeRepository.CreateCourseType(request);
        }

        public List<CourseType> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<CourseTypeDTO> GetByCourseId(int courseId)
        {
            throw new NotImplementedException();
        }

        public List<CourseTypeDTO> GetByCourseTypeID(int id)
        {
            throw new NotImplementedException();
        }

        public CourseTypeDTO GetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
