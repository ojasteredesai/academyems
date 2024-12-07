namespace AcademyEMS.Data.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public int UserTypeId { get; set; }
        public string UserTypeName { get; set; }
        public string UserName { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string UserEmail { get; set; }

        public long MobileNo { get; set; }
        public string IdentityType { get; set; }
        public string IdentityId { get; set; }
        public int AddressId { get; set; }
        public string Address1 { get; set; }
        public string? Address2 { get; set; }
        public string City { get; set; }
        public int PinCode { get; set; }
    }
}
