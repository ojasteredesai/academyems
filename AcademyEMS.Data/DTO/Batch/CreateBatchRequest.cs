﻿namespace AcademyEMS.Data.DTO
{
    public class CreateBatchRequest : BaseRequest
    {
        public int CourseId { get; set; }
        public int BatchStatusId { get; set; }
        public int InstructorId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int PinCode { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime Time { get; set; }
        public  int Duration { get; set; }
        public int Capacity { get; set; }
        public double Fees { get; set; }
    }
}
