using ATaskApi.Controllers;
using ATaskApi.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace UnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void GetAllTasks_ReturnsListOfTasks()
        {
            // Arrange
            var controller = new MyTaskController();

            // Act
            var result = controller.GetAllTasks();

            // Assert
            var okResult = Assert.IsType<ActionResult<IEnumerable<MyTaskDTO>>>(result);
            var tasks = Assert.IsType<OkObjectResult>(okResult.Result).Value as IEnumerable<MyTaskDTO>;

            // Ensure there are some tasks returned
            Assert.NotNull(tasks);
            Assert.True(tasks.Any());
        }

        [Fact]
        public void DeleteTask_WithValidId_RemovesTask()
        {
            // Arrange
            int taskId = 1;
            var controller = new MyTaskController();

            // Act
            var result = controller.DeleteTask(taskId);

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void UpdateTask_WithValidId_UpdatesTask()
        {
            // Arrange
            int taskId = 1;
            var updatedTask = new MyTaskDTO { Id = taskId, TaskName = "Updated Task", TaskDescription = "Description of updated task" };
            var controller = new MyTaskController();

            // Act
            var result = controller.Updatetasks(taskId, updatedTask);

            // Assert
            Assert.NotNull(result); // Ensure the result is not null

            // Check if the result is an OkObjectResult or inherits from it
            if (result is OkObjectResult okResult)
            {
                // Extract the value from the result
                var updatedTaskResult = Assert.IsType<MyTaskDTO>(okResult.Value);

                // Ensure the returned task has the correct properties
                Assert.Equal(taskId, updatedTaskResult.Id);
                Assert.Equal(updatedTask.TaskName, updatedTaskResult.TaskName);
                Assert.Equal(updatedTask.TaskDescription, updatedTaskResult.TaskDescription);
            }
        }

    }
}