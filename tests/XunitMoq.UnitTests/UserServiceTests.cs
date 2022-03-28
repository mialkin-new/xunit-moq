using System;
using FluentAssertions;
using Moq;
using Xunit;
using XunitMoq.Web.Models;
using XunitMoq.Web.Repositories;
using XunitMoq.Web.Services;

namespace XunitMoq.UnitTests;

public class UserServiceTests
{
    [Fact]
    public void Get_WhenUserExists_ReturnsUser()
    {
        // Arrange.
        var userId = 20;
        var userRepository = new Mock<IUserRepository>();
        userRepository
            .Setup(x => x.Get(It.IsAny<int>()))
            .Returns(new User(userId, It.IsAny<string>(), It.IsAny<DateTime>()));

        var sut = new UserService(userRepository.Object);

        // Act.
        var user = sut.Get(userId);

        // Assert.
        user!.Id.Should().Be(userId);
    }
}