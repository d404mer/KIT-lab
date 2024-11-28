using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using Template;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateStudent_ShouldAddStudent()
        {
            // Arrange
            var mockRepo = new Mock<IEmployeeRepository>();
            mockRepo.Setup(repo => repo.CreateStudent(It.IsAny<string>(), It.IsAny<int>()));

            var repository = mockRepo.Object;

            // Act
            repository.CreateStudent("John Doe", 20);

            // Assert
            mockRepo.Verify(repo => repo.CreateStudent("John Doe", 20), Times.Once);
        }

    }
}
