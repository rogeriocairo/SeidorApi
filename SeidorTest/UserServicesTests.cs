using Moq;
using SeidorApi.Core.Entities;
using SeidorApi.Core.Interfaces;
using SeidorApi.Core.Services;

namespace SeidorTest;

public class UserServicesTests
{
    private readonly Mock<IUserRepository> _mockUserRepository = new Mock<IUserRepository>();

    [Fact]
    public async void ObterUsuario_ShouldThrowArgumentNullException_WhenEmailIsNull()
    {
        // Arrange
        var userService = new UserServices(_mockUserRepository.Object);

        // Act & Assert
        Assert.ThrowsAsync<ArgumentNullException>(async () => await userService.ObterUsuarioAsync(null, "senha"));
    }

    [Fact]
    public async void ObterUsuario_ShouldThrowArgumentNullException_WhenSenhaIsNull()
    {
        // Arrange
        var userService = new UserServices(_mockUserRepository.Object);

        // Act & Assert
        Assert.ThrowsAsync<ArgumentNullException>(async () => await userService.ObterUsuarioAsync("email", null));
    }

    [Fact]
    public async void ObterUsuario_ShouldThrowException_WhenUserNotFound()
    {
        // Arrange
        var userService = new UserServices(_mockUserRepository.Object);
        _mockUserRepository.Setup(x => x.ObterUsuarioAsync("email", "senha")).ReturnsAsync((UserEntity?)null);

        // Act & Assert
        Assert.ThrowsAsync<Exception>(async () => await userService.ObterUsuarioAsync("email", "senha"));
    }

    [Fact]
    public async void ObterUsuario_ShouldReturnUser_WhenUserFound()
    {
        // Arrange
        var userService = new UserServices(_mockUserRepository.Object);
        var expectedUser = new UserEntity { Id = 1, Email = "email", Senha = "senha" };

        _mockUserRepository
            .Setup(x => x.ObterUsuarioAsync("email", "senha"))
            .ReturnsAsync(expectedUser);

        // Act
        var user = await userService.ObterUsuarioAsync("email", "senha");

        // Assert
        Assert.True(user.Email == "email");
    }
}
