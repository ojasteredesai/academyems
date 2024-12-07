using AcademyEMS.Data.DTO;

namespace AcademyEMS.Services
{
    public interface IUserService
    {
        UserResponse CreateUser(CreateUserRequest user);
        UserResponse GetAll();
    }
}
