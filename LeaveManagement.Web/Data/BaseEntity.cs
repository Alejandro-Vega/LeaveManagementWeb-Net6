namespace LeaveManagement.Web.Data
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }
    }
}
