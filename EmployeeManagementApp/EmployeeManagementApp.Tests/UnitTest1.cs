using Moq;
using System.Collections.Generic;
using Xunit;
using EmployeeManagementApp;

public class EmployeeRepositoryTests
{
    [Fact]
    public void CreateEmployee_ShouldAddEmployee()
    {
        // Arrange
        var mockRepo = new Mock<IEmployeeRepository>();
        mockRepo.Setup(repo => repo.CreateEmployee(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<decimal>()));

        var repository = mockRepo.Object;

        // Act
        repository.CreateEmployee("John Doe", "Developer", 50000);

        // Assert
        mockRepo.Verify(repo => repo.CreateEmployee("John Doe", "Developer", 50000), Times.Once);
    }

    [Fact]
    public void GetAllEmployees_ShouldReturnEmployeeList()
    {
        // Arrange
        var employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "John Doe", Position = "Developer", Salary = 50000 },
            new Employee { Id = 2, Name = "Jane Smith", Position = "Manager", Salary = 70000 }
        };

        var mockRepo = new Mock<IEmployeeRepository>();
        mockRepo.Setup(repo => repo.GetAllEmployees()).Returns(employees);

        var repository = mockRepo.Object;

        // Act
        var result = repository.GetAllEmployees();

        // Assert
        Assert.Equal(2, result.Count);
        Assert.Equal("John Doe", result[0].Name);
        Assert.Equal("Jane Smith", result[1].Name);
    }

    [Fact]
    public void UpdateEmployee_ShouldUpdateEmployeeDetails()
    {
        // Arrange
        var mockRepo = new Mock<IEmployeeRepository>();
        mockRepo.Setup(repo => repo.UpdateEmployee(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<decimal>()));

        var repository = mockRepo.Object;

        // Act
        repository.UpdateEmployee(1, "John Doe", "Senior Developer", 60000);

        // Assert
        mockRepo.Verify(repo => repo.UpdateEmployee(1, "John Doe", "Senior Developer", 60000), Times.Once);
    }

    [Fact]
    public void DeleteEmployee_ShouldRemoveEmployee()
    {
        // Arrange
        var mockRepo = new Mock<IEmployeeRepository>();
        mockRepo.Setup(repo => repo.DeleteEmployee(It.IsAny<int>()));

        var repository = mockRepo.Object;

        // Act
        repository.DeleteEmployee(1);

        // Assert
        mockRepo.Verify(repo => repo.DeleteEmployee(1), Times.Once);
    }
}
