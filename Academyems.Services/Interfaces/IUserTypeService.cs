using AcademyEMS.Data.DTO;
using AcademyEMS.Data.DTO.User;

namespace AcademyEMS.Services
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
