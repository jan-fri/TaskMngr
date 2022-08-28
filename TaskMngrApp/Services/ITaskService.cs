namespace TaskMngrApp.Services
{
    public interface ITaskService
    {
        void AddTask(string newTaskDescription);
        List<Task> GetAllTasks();
    }
}
