using Academyems.CoreDbContext;
using Academyems.CoreDbContext.Entities;
using Academyems.Data.DTO;

namespace Academyems.Repositories
{
    public class CourseTypeRepository : ICourseTypeRepository
    {

        private readonly AppDbContext _dbContext;
        public CourseTypeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int CreateCourseType(CourseType request)
        {
            _dbContext.CourseType.Add(request);
            _dbContext.SaveChanges();
            return request.Id;
        }

        public List<CourseTypeDTO> GetAll()
        {

            var courseTypes = from courseType in _dbContext.CourseType
                               select new CourseTypeDTO
                               {
                                   Id = courseType.Id,
                                   Type = courseType.Type,
                                   Description=courseType.Description
                               };
            return courseTypes.ToList();
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
