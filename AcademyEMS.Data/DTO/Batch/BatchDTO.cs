namespace AcademyEMS.Data.DTO
{
    public class BatchDTO
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int BatchStatusId { get; set; }
        public string BatchStatus { get; set; }
        public string Status { get; set; }
        public int InstructorId { get; set; }
        public string InstructorName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int PinCode { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime Time { get; set; }
        public int Capacity { get; set; }
        public int Duration { get; set; }
        public double Fees { get; set; }
    }
}
