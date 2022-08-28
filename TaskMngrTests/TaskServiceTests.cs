using Moq;
using TaskMngrApp.Repositories;
using TaskMngrApp.Services;

namespace TaskMngrTests
{
    public class TaskServiceTests
    {
        [Test]
        public void AddTask_CallsTaskRepositoryToAddTask_VerifyWithGetAllTasks()
        {
            //Arrange
            var taskRepoMock = new Mock<ITaskRepository>();
            var taskService = new TaskService(taskRepoMock.Object);

            //Act
            taskService.AddTask("new task");

            //Assert
            taskRepoMock.Verify(x => x.GetAllTasks());
            taskRepoMock.Verify(x => x.AddTask(It.IsAny<TaskMngrApp.Models.Task>()));
        }
    }
}
