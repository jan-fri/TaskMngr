namespace TaskMngrApp.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public bool IsCompleted { get; set; }
    }
}
