using AcademyEMS.Data.DTO;

namespace AcademyEMS.Services
{
    public interface IBatchService
    {
        BatchResponse CreateBatch(CreateBatchRequest user);
        BatchResponse GetAll();
    }
}
