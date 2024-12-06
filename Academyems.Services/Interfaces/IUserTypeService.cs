using Academyems.Data.DTO;
using Academyems.Data.DTO.User;

namespace Academyems.Services
{
    public interface IUserTypeService
    {
        UserTypeResponse GetAll();
        UserTypeDTO GetByID(int id);
        List<UserTypeDTO> GetByUserId(int courseId);
        List<UserTypeDTO> GetByUserTypeID(int id);
        UserTypeResponse CreateUserType(CreateUserTypeRequest request);
        UserTypeResponse UpdateUserType(UpdateUserTypeRequest request);
        UserTypeResponse DeleteUserType(int id);
    }
}
