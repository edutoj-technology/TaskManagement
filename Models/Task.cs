namespace TaskManagement.Models
{
    public class Task
    {
        public Guid TaskId { get; set; }

        public string TaskName { get; set; }
        public TaskCategory Category { get; set; }
    }
}