namespace TaskManagement.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System.Collections.Generic;
    using TaskManagement.Models;
    using TaskManagement.Repository;

    [ApiController]
    [Route("[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly ILogger<TasksController> _logger;
        private readonly ITaskRepository _taskRepository;

        public TasksController(ILogger<TasksController> logger, ITaskRepository taskRepository)
        {
            _logger = logger;
            _taskRepository = taskRepository;
        }

        [HttpGet(Name = "GetTasks")]
        public IEnumerable<Task> Get()
        {
            return this._taskRepository.GetAllTask();
        }
    }
}
