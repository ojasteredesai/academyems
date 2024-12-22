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
                              StartDate = batch.StartDate,
                              EndDate = batch.EndDate,  
                              Fees = batch.Fees,
                              BatchStatusId = batch.BatchStatusId,
                              PinCode = batch.Address.PinCode                              
                          };
            return batches.ToList();
        }

        public List<BatchDTO> GetByBatchId(int courseId)
        {
            throw new NotImplementedException();
        }

        public List<BatchDTO> GetByBatchStatusID(int id)
        {
            throw new NotImplementedException();
        }

        public BatchDTO GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public int UpdateBatch(Batch request)
        {
            throw new NotImplementedException();
        }
    }
}
