using System.Collections.Generic;
using LB3_PITPM;
using Xunit;

namespace UserAuthApp.Tests
{
    public class AuthServiceTests
    {
        private readonly AuthService _authService;

        public AuthServiceTests()
        {
            _authService = new AuthService();
        }

        [Fact]
        public void Register_ValidUsernameAndPassword_ReturnsSuccessMessage()
        {
            // Arrange
            string username = "testUser";
            string password = "testPassword";

            // Act
            string result = _authService.Register(username, password);

            // Assert
            Assert.Equal("Registration successful!", result);
        }

        [Fact]
        public void Register_UsernameAlreadyExists_ReturnsErrorMessage()
        {
            // Arrange
            string username = "testUser";
            string password = "testPassword";
            _authService.Register(username, password); // First registration

            // Act
            string result = _authService.Register(username, password); // Try to register again

            // Assert
            Assert.Equal("Error: Username already exists.", result);
        }

        [Fact]
        public void Login_ValidCredentials_ReturnsSuccessMessage()
        {
            // Arrange
            string username = "testUser";
            string password = "testPassword";
            _authService.Register(username, password); // Ensure user is registered

            // Act
            string result = _authService.Login(username, password);

            // Assert
            Assert.Equal("Login successful!", result);
        }

        [Fact]
        public void Login_InvalidCredentials_ReturnsErrorMessage()
        {
            // Arrange
            string username = "testUser";
            string password = "testPassword";
            _authService.Register(username, password); // Ensure user is registered

            // Act
            string result = _authService.Login(username, "wrongPassword"); // Wrong password

            // Assert
            Assert.Equal("Error: Incorrect username or password.", result);
        }

        [Fact]
        public void GetAllUsernames_NoUsers_ReturnsEmptyList()
        {
            // Act
            var result = _authService.GetAllUsernames();

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void GetAllUsernames_AfterRegistration_ReturnsUsernames()
        {
            // Arrange
            string username1 = "testUser1";
            string username2 = "testUser2";
            _authService.Register(username1, "password1");
            _authService.Register(username2, "password2");

            // Act
            var result = _authService.GetAllUsernames();

            // Assert
            Assert.Equal(new List<string> { username1, username2 }, result);
        }
    }
}
