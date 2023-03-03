namespace TaskManagement.Repository
{
    using System;
    using System.Collections.Generic;
    using TaskManagement.Models;
    public class TaskRepository : ITaskRepository
    {
        private static List<Task> taskList = new List<Task>();

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
                    CreateDate = new DateTime(2023, 02, 03),
                    CreatedBy = Guid.Parse("01fb71e6-4e28-46b8-b926-022a60fc4794"),
                },
                CreateDate = new DateTime(2023, 02, 03),
                CreatedBy = Guid.Parse("01fb71e6-4e28-46b8-b926-022a60fc4794")
            };

            Task task2 = new Task
            {
                TaskId = Guid.NewGuid(),
                TaskName = "Task 2",
                Category = new TaskCategory
                {
                    TaskCategoryId = Guid.NewGuid(),
                    CategoryName = "Development",
                    CreateDate = new DateTime(2023, 02, 03),
                    CreatedBy = Guid.Parse("01fb71e6-4e28-46b8-b926-022a60fc4794"),
                },
                CreateDate = new DateTime(2023, 02, 03),
                CreatedBy = Guid.Parse("01fb71e6-4e28-46b8-b926-022a60fc4794")
            };


            taskList.Add(task1);
            taskList.Add(task2);
        }

        public Task AddNewTask(Task task)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTask(Guid taskId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Task> GetAllTask()
        {
            return taskList;
        }

        public Task GetTaskById(Guid taskId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTask(Task task)
        {
            throw new NotImplementedException();
        }
    }
}