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
        public CourseTypeResponse CreateCourseType(CreateCourseTypeRequest request)
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

            return new CourseTypeResponse
            {
                Success = _courseTypeRepository.CreateCourseType(inputCourseType) > 0
            }; 
        }

        public CourseTypeResponse DeleteCourseType(int id)
        {
            return new CourseTypeResponse
            {
                Success = _courseTypeRepository.DeleteCourseType(id) > 0
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

        public CourseTypeResponse UpdateCourseType(UpdateCourseTypeRequest request)
        {
            CourseType inputCourseType = new()
            {
                Id = request.Id,
                Type = request.Type,
                Description = request.Description,
                UpdatedBy = 1,
                UpdatedOn = DateTime.UtcNow
            };

            return new CourseTypeResponse
            {
                Success = _courseTypeRepository.UpdateCourseType(inputCourseType) > 0
            };
        }
    }
}
