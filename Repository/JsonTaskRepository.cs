namespace TaskManagement.Repository
{
    using Microsoft.AspNetCore.Hosting;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using TaskManagement.Models;
    using TaskManagement.Services;

    public class JsonTaskRepository : ITaskRepository
    {
        private readonly string fileRootPath = string.Empty;
        private readonly IJsonFileService fileService;
        public JsonTaskRepository(IWebHostEnvironment hostingEnvironment, IJsonFileService fileService)
        {
            this.fileRootPath = hostingEnvironment.ContentRootPath;
            this.fileService = fileService;
            
        }

        public Task AddNewTask(Task task)
        {
            var filePath = Path.Combine(fileRootPath, "Data\\data.json");
            var data = fileService.ReadFromJsonFile<List<Task>>(filePath);
            data.Add(task);
            this.fileService.WriteToJsonFile(filePath, data);
            return task;
        }


        public Task DeleteTask(Guid taskId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Task> GetAllTask()
        {
            var filePath = Path.Combine(fileRootPath, "Data\\data.json");
            var data = fileService.ReadFromJsonFile<List<Task>>(filePath);
            return data;
        }

        public Task GetTaskById(Guid taskId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTask(Task task, Guid taskId)
        {
            throw new NotImplementedException();
        }
    }
}