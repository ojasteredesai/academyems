namespace AcademyEMS.Data.DTO
{
    public class CreateCourseTypeRequest : BaseRequest
    {
        public string Type { get; set; }
        public string Description { get; set; }
    }
}
