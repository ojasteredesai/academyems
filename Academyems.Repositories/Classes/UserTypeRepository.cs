using Academyems.CoreDbContext;
using Academyems.CoreDbContext.Entities;
using Academyems.Data.DTO;

namespace Academyems.Repositories.Classes
{
    public class UserTypeRepository : IUserTypeRepository
    {
        private readonly AppDbContext _dbContext;
        public UserTypeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int CreateUserType(UserType userType)
        {

            _dbContext.UserType.Add(userType);
            _dbContext.SaveChanges();
            return userType.Id;
        }

        public int DeleteUserType(int id)
        {
            var userType = _dbContext.UserType
                        .Where(uType => uType.Id == id)
                        .FirstOrDefault();
            if (userType != null)
            {
                _dbContext.UserType.Remove(userType);
                return _dbContext.SaveChanges();
            }

            return 0;
        }

        public List<UserTypeDTO> GetAll()
        {
            var userTypes = from userType in _dbContext.UserType
                              select new UserTypeDTO
                              {
                                  Id = userType.Id,
                                  Type = userType.Type,
                                  Description = userType.Description
                              };
            return userTypes.ToList();
        }

        public UserTypeDTO GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserTypeDTO> GetByUserId(int courseId)
        {
            throw new NotImplementedException();
        }

        public List<UserTypeDTO> GetByUserTypeID(int id)
        {
            throw new NotImplementedException();
        }

        public int UpdateUserType(UserType userType)
        {
            var userTypeToUpdate = _dbContext.UserType
                                                 .Where(cType => cType.Id == userType.Id).FirstOrDefault();
            if (userTypeToUpdate != null)
            {
                userTypeToUpdate.Type = userType.Type;
                userTypeToUpdate.Description = userType.Description;
                userTypeToUpdate.UpdatedBy = userType.UpdatedBy;
                userTypeToUpdate.UpdatedOn = userType.UpdatedOn;
                return _dbContext.SaveChanges();
            }

            return 0;
        }
    }
}
