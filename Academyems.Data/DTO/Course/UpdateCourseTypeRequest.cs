namespace Academyems.Data.DTO
{
    public class UpdateCourseTypeRequest : BaseRequest
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }
}
