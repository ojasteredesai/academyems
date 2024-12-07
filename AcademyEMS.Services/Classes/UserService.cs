using AcademyEMS.CoreDbContext.Entities;
using AcademyEMS.Data.DTO;
using AcademyEMS.Repositories;
using AcademyEMS.Repositories.Classes;

namespace AcademyEMS.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userTypeRepository)
        {
            _userRepository = userTypeRepository;
        }

        public UserResponse CreateUser(CreateUserRequest request)
        {
            UserDetail inputUser = new()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                DateOfBirth = request.DateOfBirth,
                EMail = request.UserEmail,
                MobileNo = request.MobileNo,
                HashedPassword = "To do passowrd",
                Gender = request.Gender,
                IdentityId = request.IdentityId,
                IdentityType = request.IdentityType,
                UserTypeId = request.UserTypeId,
                UserCode = "UC001",
                Address = new Address
                {
                    AddressLine1 = request.Address1,
                    AddressLine2 = request.Address2,
                    PinCode = request.PinCode,
                    City = request.City,
                    CreatedBy = 1,
                    UpdatedBy = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow
                },
                CreatedBy = 1,
                UpdatedBy = 1,
                CreatedOn = DateTime.UtcNow,
                UpdatedOn = DateTime.UtcNow
            };



            return new UserResponse
            {
                Success = _userRepository.CreateUser(inputUser) > 0
            };
        }

        public UserResponse GetAll()
        {
            return new UserResponse
            {
                Users = _userRepository.GetAll(),
                Success = true
            };
        }
    }
}
