using AcademyEMS.Data.DTO;
using AcademyEMS.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AcademyEMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BatchController : ControllerBase
    {
        private readonly IBatchService _batchService;

        public BatchController(IBatchService batchService)
        {
            _batchService = batchService;
        }

        [HttpGet("GetAllBatches")]
        public IActionResult Get()
        {
            BatchResponse response;
            try
            {
                response = _batchService.GetAll();
            }
            catch (Exception ex)
            {
                response = new BatchResponse
                {
                    Error = ex.Message,
                    Success = false
                };
            }
            finally
            {

            }
            return Ok(response);
        }


        [HttpPost("CreateUser")]
        public IActionResult CreateUser(CreateBatchRequest batch)
        {
            BatchResponse response;
            try
            {
                response = _batchService.CreateBatch(batch);
            }
            catch (Exception ex)
            {
                response = new BatchResponse
                {
                    Error = ex.Message,
                    Success = false
                };
            }
            finally
            {

            }
            return Ok(response);
        }
    }
}
