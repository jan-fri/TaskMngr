using TaskMngrApp.Repositories;

namespace TaskMngrApp.Services
{
    public class TaskService : ITaskService
    {
        private ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public Models.Task AddTask(string newTaskDescription)
        {
            var allTasks = _taskRepository.GetAllTasks();
            var lastTaskId = allTasks.LastOrDefault()?.Id ?? 0;
            var newTask = new Models.Task { Id = lastTaskId + 1, Description = newTaskDescription, IsCompleted = false };
            return _taskRepository.AddTask(newTask);
        }
    }
}
