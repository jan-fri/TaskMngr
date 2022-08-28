using Moq;
using TaskMngrApp.Repositories;
using TaskMngrApp.Services;

namespace TaskMngrTests
{
    public class TaskServiceTests
    {
        [Test]
        public void GetAllTasks_CallsTaskRepository_ToGetAllTasks()
        {
            //Arrange
            var taskRepoMock = new Mock<ITaskRepository>();
            var taskService = new TaskService();
            var task1 = new TaskMngrApp.Models.Task { Id = 1, Description = "task 1", IsCompleted = false };
            var task2 = new TaskMngrApp.Models.Task { Id = 2, Description = "task 2", IsCompleted = true };
            List<TaskMngrApp.Models.Task> tasks = new List<TaskMngrApp.Models.Task>();
            tasks.Add(task1);
            tasks.Add(task2);

            taskRepoMock.Setup(x => x.GetAllTasks()).Returns(tasks);

            //Act
            var result = taskService.GetAllTasks();

            //Assert
            Assert.Equals(2, result.Count());
        }

        [Test]
        public void AddTask_CallsTaskRepositoryToAddTask_VerifyWithGetAllTasks()
        {
            //Arrange
            var taskRepoMock = new Mock<ITaskRepository>();
            var taskService = new TaskService();

            //Act
            taskService.AddTask("new task");

            //Assert
            taskRepoMock.Verify(x => x.GetAllTasks());
            taskRepoMock.Verify(x => x.AddTask(It.IsAny<TaskMngrApp.Models.Task>()));
        }
    }
}
