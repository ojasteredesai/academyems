using AcademyEMS.CoreDbContext.Entities;
using AcademyEMS.Data.DTO;

namespace AcademyEMS.Repositories
{
    public interface IBatchRepository
    {
        List<BatchDTO> GetAll();
        BatchDTO GetByID(int id);
        List<BatchDTO> GetByBatchId(int courseId);
        List<BatchDTO> GetByBatchStatusID(int id);
        int CreateBatch(Batch request);
        int UpdateBatch(Batch request);
        int DeleteBatch(int id);
    }
}
