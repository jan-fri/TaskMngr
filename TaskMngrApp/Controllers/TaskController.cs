using Microsoft.AspNetCore.Mvc;
using TaskMngrApp.Repositories;
using TaskMngrApp.Services;

namespace TaskMngrApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        [HttpPost]
        [Route("AddTask")]
        public IActionResult AddTask(string taskDescription)
        {
            var taskRepository = new TaskRepository();
            var taskService = new TaskService(taskRepository);
            var newTask = taskService.AddTask(taskDescription);

            return Ok(newTask);
        }
    }
}
