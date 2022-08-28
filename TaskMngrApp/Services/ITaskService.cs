namespace TaskMngrApp.Services
{
    public interface ITaskService
    {
        Models.Task AddTask(string newTaskDescription);
    }
}
