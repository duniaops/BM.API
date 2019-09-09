using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BM.API.Controllers;
using BM.Core.Service;
using BM.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace BM.Test.APIs
{
    public class UsersControllerTest
    {

        [Theory]
        [InlineData("ibrahim", "")]
        [InlineData("", "")]
        [InlineData("", "uylas")]
        public async Task Post_Authenticate_InvalidUsernameOrPassword(string username, string password)
        {
            var userServiceMock = new Mock<IUsersService>();
            var controller = new UsersController(userServiceMock.Object);
            var result = await controller.Authenticate(new LoginModel { Username = username, Password = password });

            var message = Assert.IsType<BadRequestObjectResult>(result);

            Assert.Equal(Toolkit.Messages.UsersMessages.InvalidUsernameOrPassword, message.Value);
        }

    }
}
