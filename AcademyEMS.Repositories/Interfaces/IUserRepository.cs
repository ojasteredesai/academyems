using AcademyEMS.CoreDbContext.Entities;
using AcademyEMS.Data.DTO;

namespace AcademyEMS.Repositories
{
    public interface IUserRepository
    {
        int CreateUser(UserDetail user);
        List<UserDTO> GetAll();
    }
}
