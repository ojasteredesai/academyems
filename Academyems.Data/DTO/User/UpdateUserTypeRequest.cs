namespace AcademyEMS.Data.DTO.User
{
    public class UpdateUserTypeRequest : BaseRequest
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }
}
