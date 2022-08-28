namespace TaskMngrApp.Repositories
{
    public interface ITaskRepository
    {
        IEnumerable<Models.Task> GetAllTasks();
        Models.Task AddTask(Models.Task task);
    }
}
