using System.Threading.Tasks;
using BM.Core.Repository;
using BM.Domain.Models;
using BM.Service;
using Moq;
using Xunit;

namespace BM.Test.Services
{
    public class UsersServiceTest
    {
        public UsersServiceTest()
        {
        }

        [Theory]
        [InlineData("ibrahim", "")]
        [InlineData("", "")]
        [InlineData("", "uylas")]
        public async Task Authenticate_InvalidUsernameOrPassword(string username, string password)
        {
            var userRepositoryMock = new Mock<IUsersRepository>();
            var service = new UsersService(userRepositoryMock.Object);
            var model = await service.AuthenticateAsync(new LoginModel { Username = username, Password = password });

            var result = Assert.IsType<LoginResultModel>(model);
            Assert.False(result.IsSucess);
        }
    }
}
