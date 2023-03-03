using System;
namespace TaskManagement.Models
{
    public class UserLite : BaseEntity
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }
}
