namespace AcademyEMS.Data.DTO
{
    public class CreateUserTypeRequest : BaseRequest
    {
        public string Type { get; set; }
        public string Description { get; set; }
    }
}
