namespace TaskMngrApp.Repositories
{
    public interface ITaskRepository
    {
        IEnumerable<Models.Task> GetAllTasks();
        void AddTask(Models.Task task);
    }
}
