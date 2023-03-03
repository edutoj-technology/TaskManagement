using System;

namespace TaskManagement.Models
{
    public class BaseEntity
    {
        public Guid CreatedBy { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
