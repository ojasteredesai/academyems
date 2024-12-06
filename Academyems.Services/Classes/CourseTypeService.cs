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

        public CreateCourseTypeResponse CreateCourseType(CreateCourseTypeRequest request)
        {
            CourseType inputCourseType = new()
            {
                Type = request.Type,
                Description = request.Description,
                CreatedBy = 1,
                UpdatedBy = 1,
                CreatedOn = DateTime.UtcNow,
                UpdatedOn = DateTime.UtcNow
            };

            return new CreateCourseTypeResponse
            {
                Success = _courseTypeRepository.CreateCourseType(inputCourseType) > 0
            }; 
        }

        public CourseTypeResponse GetAll()
        {
            return new CourseTypeResponse
            {
                CourseTypes = _courseTypeRepository.GetAll(),
                Success = true
            };
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
