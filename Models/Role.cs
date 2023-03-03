using System;

namespace TaskManagement.Models
{
    public class Role : BaseEntity
    {
        public Guid RoleId { get; set; }
        public string RoleName { get; set; } = string.Empty;
    }
}
