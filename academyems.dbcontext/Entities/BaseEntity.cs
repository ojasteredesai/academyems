namespace academyems.dbcontext
{
    public class BaseEntity
    {
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set;}
        public DateTime CreatedOn { get; set; }
        public int UpdatedOn { get; set;}
    }
}
