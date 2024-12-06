using Academyems.CoreDbContext.Entities;
using Academyems.Data.DTO;

namespace Academyems.Repositories
{
    public interface IUserTypeRepository
    {
        List<UserTypeDTO> GetAll();
        UserTypeDTO GetByID(int id);
        List<UserTypeDTO> GetByUserId(int courseId);
        List<UserTypeDTO> GetByUserTypeID(int id);
        int CreateUserType(UserType userType);
        int UpdateUserType(UserType userType);
        int DeleteUserType(int id);
    }
}
