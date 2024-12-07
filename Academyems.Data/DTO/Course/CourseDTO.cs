namespace AcademyEMS.Data.DTO
{
    public class CourseDTO
    {
        public int Id { get; set; }
        public int CourseTypeId { get; set; }
        public string CourseTypeName { get; set; }
        public string CourseName { get; set; }
        public string? CourseDescription { get; set; }
    }
}
