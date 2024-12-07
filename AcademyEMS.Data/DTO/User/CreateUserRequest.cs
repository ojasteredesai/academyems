namespace AcademyEMS.Data.DTO
{
    public class CreateUserRequest : BaseRequest
    {
        public int Id { get; set; }
        public int UserTypeId { get; set; }
        public string UserTypeName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string UserEmail { get; set; }

        public long MobileNo { get; set; }
        public string IdentityType { get; set; }
        public string IdentityId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int PinCode { get; set; }
    }
}
