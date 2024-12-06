using Academyems.CoreDbContext.Entities;
using Academyems.Data.DTO;
using Academyems.Data.DTO.User;
using Academyems.Repositories;

namespace Academyems.Services
{
    public class UserTypeService : IUserTypeService
    {
        private readonly IUserTypeRepository _userTypeRepository;
        public UserTypeService(IUserTypeRepository userTypeRepository)
        {
            _userTypeRepository = userTypeRepository;
        }

        public UserTypeResponse CreateUserType(CreateUserTypeRequest request)
        {
            UserType inputUserType = new()
            {
                Type = request.Type,
                Description = request.Description,
                CreatedBy = 1,
                UpdatedBy = 1,
                CreatedOn = DateTime.UtcNow,
                UpdatedOn = DateTime.UtcNow
            };

            return new UserTypeResponse
            {
                Success = _userTypeRepository.CreateUserType(inputUserType) > 0
            };
        }

        public UserTypeResponse DeleteUserType(int id)
        {
            return new UserTypeResponse
            {
                Success = _userTypeRepository.DeleteUserType(id) > 0
            };
        }

        public UserTypeResponse GetAll()
        {
            return new UserTypeResponse
            {
                UserTypes = _userTypeRepository.GetAll(),
                Success = true
            };
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

        public UserTypeResponse UpdateUserType(UpdateUserTypeRequest request)
        {
            UserType inputUserType = new()
            {
                Id = request.Id,
                Type = request.Type,
                Description = request.Description,
                UpdatedBy = 1,
                UpdatedOn = DateTime.UtcNow
            };

            return new UserTypeResponse
            {
                Success = _userTypeRepository.UpdateUserType(inputUserType) > 0
            };
        }
    }
}
