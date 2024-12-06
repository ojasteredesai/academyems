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
        public List<CourseTypeDTO> GetAll()
        {

            var courseTypes = from courseType in _dbContext.CourseType
                              select new CourseTypeDTO
                              {
                                  Id = courseType.Id,
                                  Type = courseType.Type,
                                  Description = courseType.Description
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

        public int CreateCourseType(CourseType courseType)
        {
            _dbContext.CourseType.Add(courseType);
            _dbContext.SaveChanges();
            return courseType.Id;
        }

        public int UpdateCourseType(CourseType courseType)
        {
            var courseTypeToUpdate = _dbContext.CourseType
                                                 .Where(cType => cType.Id == courseType.Id).FirstOrDefault();
            if (courseTypeToUpdate != null)
            {
                courseTypeToUpdate.Type = courseType.Type;
                courseTypeToUpdate.Description = courseType.Description;
                courseTypeToUpdate.UpdatedBy = courseType.UpdatedBy;
                courseTypeToUpdate.UpdatedOn = courseType.UpdatedOn;
                return _dbContext.SaveChanges();
            }

            return 0;
        }

        public int DeleteCourseType(int id)
        {
            var courseType = _dbContext.CourseType
                        .Where(cType => cType.Id == id)
                        .FirstOrDefault();
            if (courseType != null)
            {
                _dbContext.CourseType.Remove(courseType);
                return _dbContext.SaveChanges();
            }

            return 0;
        }
    }
}
