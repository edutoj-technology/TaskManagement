namespace TaskManagement.Repository
{
    using TaskManagement.Models;
    public class TaskRepository
    {
        private static List<Task> taskList;

        public TaskRepository()
        {
            Task task1 = new Task
            {
                TaskId = Guid.NewGuid(),
                TaskName = "Task1",
                Category = new TaskCategory
                {
                    TaskCategoryId = Guid.NewGuid(),
                    CategoryName = "Development",
                }
            };


            taskList = new List<Task> { task1 };
        }


    }

}