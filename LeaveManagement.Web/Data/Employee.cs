using Microsoft.AspNetCore.Identity;

namespace LeaveManagement.Web.Data
{
    public class Employee : IdentityUser
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? TaxID { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }
    }
}
