using System;
namespace TaskManagement.Models
{
    public class TaskCategory : BaseEntity
    {
        public Guid TaskCategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
    }
}