using TaskMngrApp.Repositories;

namespace TaskMngrTests
{
    public class TaskRepositoryTests
    {
        [Test]
        public void GetAllTasks_ShouldReturnAllTasks()
        {
            //Arrange
            var taskRepo = new TaskRepository();
            var task1 = new TaskMngrApp.Models.Task { Id = 1, Description = "task 1", IsCompleted = false };
            var task2 = new TaskMngrApp.Models.Task { Id = 2, Description = "task 2", IsCompleted = true };
            taskRepo.AddTask(task1);
            taskRepo.AddTask(task2);

            //Act
            var results = taskRepo.GetAllTasks();

            //Assert
            Assert.True(results.Count() > 0);
        }

        [Test]
        public void AddTask_AddsNewTaskToRepository()
        {
            //Arrange
            var taskRepo = new TaskRepository();
            var task = new TaskMngrApp.Models.Task { Id = 1, Description = "task 1", IsCompleted = false };

            //Act
            taskRepo.AddTask(task);

            //Assert
            Assert.AreEqual(1, taskRepo.GetAllTasks().Count());
        }
    }
}