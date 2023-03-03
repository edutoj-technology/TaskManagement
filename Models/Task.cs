using System;

namespace TaskManagement.Models
{
    public class Task : BaseEntity
    {
        public Guid TaskId { get; set; }
        public string TaskName { get; set; } = string.Empty;
        public TaskCategory Category { get; set; } = new TaskCategory();
    }
}