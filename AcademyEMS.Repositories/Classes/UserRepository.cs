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
            throw new NotImplementedException();
        }
    }
}
