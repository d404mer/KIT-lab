using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BooksThingExams;
using Moq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateBook_ShouldAddBook()
        {
            // Arrange
            var mockRepo = new Mock<IEBooksRepository>();
            mockRepo.Setup(repo => repo.AddObject(It.IsAny<string>(), It.IsAny<string>()));

            var repository = mockRepo.Object;

            // Act
            repository.AddObject("John Doe", "test");

            // Assert
            mockRepo.Verify(repo => repo.AddObject("John Doe", "test"), Times.Once);
        }

    }
}


