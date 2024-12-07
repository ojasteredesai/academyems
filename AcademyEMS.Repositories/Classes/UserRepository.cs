using AcademyEMS.CoreDbContext;
using AcademyEMS.CoreDbContext.Entities;
using AcademyEMS.Data.DTO;

namespace AcademyEMS.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;
        public UserRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int CreateUser(UserDetail user)
        {
            _dbContext.UserDetail.Add(user);
            _dbContext.SaveChanges();
            return user.Id;
        }

        public List<UserDTO> GetAll()
        {
            var users = from user in _dbContext.UserDetail
                        select new UserDTO
                        {
                            Id = user.Id,
                            IdentityId = user.IdentityId,
                            UserName = user.FirstName + " " + user.LastName,
                            DateOfBirth = user.DateOfBirth,
                            AddressId = user.Address.Id,
                            Address1 = user.Address.AddressLine1,
                            Address2 = user.Address.AddressLine2,
                            City= user.Address.City,
                            IdentityType = user.IdentityType,
                            MobileNo = user.MobileNo,
                            PinCode = user.Address.PinCode,
                            UserEmail = user.EMail,
                            UserTypeId = user.UserTypeId
                        };
            return users.ToList();
        }
    }
}
