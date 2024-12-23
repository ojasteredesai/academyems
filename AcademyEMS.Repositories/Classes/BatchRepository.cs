using AcademyEMS.CoreDbContext;
using AcademyEMS.CoreDbContext.Entities;
using AcademyEMS.Data.DTO;

namespace AcademyEMS.Repositories
{
    public class BatchRepository : IBatchRepository
    {
        private readonly AppDbContext _dbContext;
        public BatchRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int CreateBatch(Batch batch)
        {
            _dbContext.Batch.Add(batch);
            _dbContext.SaveChanges();
            return batch.Id;
        }

        public int DeleteBatch(int id)
        {
            throw new NotImplementedException();
        }

        public List<BatchDTO> GetAll()
        {
            var batches = from batch in _dbContext.Batch
                          select new BatchDTO
                          {
                              Id = batch.Id,
                              Description = batch.Description,
                              InstructorId = batch.InstructorId,
                              InstructorName = batch.UserDetail.FirstName + " " + batch.UserDetail.LastName,
                              Address1 = batch.Address.AddressLine1,
                              Address2 = batch.Address.AddressLine2,
                              City = batch.Address.City,
                              Capacity = batch.Capacity,
                              CourseId = batch.CourseId,
                              CourseName = batch.Course.CourseName,
                              StartDate = batch.StartDate,
                              EndDate = batch.EndDate,
                              Fees = batch.Fees,
                              BatchStatusId = batch.BatchStatusId,
                              BatchStatus = batch.BatchStatus.Status,
                              PinCode = batch.Address.PinCode,
                              Duration = batch.Duration
                          };
            return batches.ToList();
        }

        public List<BatchDTO> GetByBatchStatusID(int id)
        {
            var batches = from batch in _dbContext.Batch
                          where batch.BatchStatusId == id
                          select new BatchDTO
                          {
                              Id = batch.Id,
                              Description = batch.Description,
                              InstructorId = batch.InstructorId,
                              InstructorName = batch.UserDetail.FirstName + " " + batch.UserDetail.LastName,
                              Address1 = batch.Address.AddressLine1,
                              Address2 = batch.Address.AddressLine2,
                              City = batch.Address.City,
                              Capacity = batch.Capacity,
                              CourseId = batch.CourseId,
                              CourseName = batch.Course.CourseName,
                              StartDate = batch.StartDate,
                              EndDate = batch.EndDate,
                              Fees = batch.Fees,
                              BatchStatusId = batch.BatchStatusId,
                              BatchStatus = batch.BatchStatus.Status,
                              PinCode = batch.Address.PinCode,
                              Duration = batch.Duration
                          };
            return batches.ToList();
        }

        public BatchDTO GetByID(int id)
        {
            return (from batch in _dbContext.Batch
                    where batch.Id == id
                    select new BatchDTO
                    {
                        Id = batch.Id,
                        Description = batch.Description,
                        InstructorId = batch.InstructorId,
                        InstructorName = batch.UserDetail.FirstName + " " + batch.UserDetail.LastName,
                        Address1 = batch.Address.AddressLine1,
                        Address2 = batch.Address.AddressLine2,
                        City = batch.Address.City,
                        Capacity = batch.Capacity,
                        CourseId = batch.CourseId,
                        CourseName = batch.Course.CourseName,
                        StartDate = batch.StartDate,
                        EndDate = batch.EndDate,
                        Fees = batch.Fees,
                        BatchStatusId = batch.BatchStatusId,
                        BatchStatus = batch.BatchStatus.Status,
                        PinCode = batch.Address.PinCode,
                        Duration = batch.Duration
                    }).FirstOrDefault();
        }

        public int UpdateBatch(Batch request)
        {
            throw new NotImplementedException();
        }
    }
}
