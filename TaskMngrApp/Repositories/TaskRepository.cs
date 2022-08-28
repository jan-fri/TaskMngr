namespace TaskMngrApp.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private static List<Models.Task> _tasks = new List<Models.Task>();

        public Models.Task AddTask(Models.Task newTask)
        {
            _tasks.Add(newTask);
            return newTask;
        }

        public IEnumerable<Models.Task> GetAllTasks()
        {
            return _tasks;
        }
    }
}
