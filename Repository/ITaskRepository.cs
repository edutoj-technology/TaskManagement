namespace TaskManagement.Repository
{
    using System;
    using System.Collections.Generic;
    using TaskManagement.Models;
    public interface ITaskRepository
    {
        public IEnumerable<Task> GetAllTask();
        public Task GetTaskById(Guid taskId);
        public Task AddNewTask(Task task);
        public Task UpdateTask(Task task);
        public Task DeleteTask(Guid taskId);
    }
}