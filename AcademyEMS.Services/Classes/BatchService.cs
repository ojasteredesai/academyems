using AcademyEMS.CoreDbContext.Entities;
using AcademyEMS.Data.DTO;
using AcademyEMS.Repositories;

namespace AcademyEMS.Services
{
    public class BatchService : IBatchService
    {
        private readonly IBatchRepository _batchRepository;
        public BatchService(IBatchRepository batchRepository)
        {
            _batchRepository = batchRepository;
        }

        public BatchResponse CreateBatch(CreateBatchRequest batch)
        {
            Batch inputBatch = new()
            {
                CourseId = batch.CourseId,
                BatchStatusId = batch.BatchStatusId,
                InstructorId = batch.InstructorId,
                Capacity = batch.Capacity,
                Description = batch.Description,
                StartDate= batch.StartDate,
                EndDate= batch.EndDate,
                Fees=batch.Fees,
                Duration=batch.Duration,    
                Type=batch.Type,    
                Time=batch.Time,
                CreatedBy = 1,
                UpdatedBy = 1,
                CreatedOn = DateTime.UtcNow,
                UpdatedOn = DateTime.UtcNow
            };
            return new BatchResponse
            {
                Success = _batchRepository.CreateBatch(inputBatch) > 0
            };
        }

        public BatchResponse GetAll()
        {
            return new BatchResponse
            {
                Batches = _batchRepository.GetAll(),
                Success = true
            };
        }
    }
}
