using System;
using System.Threading.Tasks;
using BM.Domain.Entities;
using BM.EF;
using BM.Repository;
using Moq;
using Xunit;

namespace BM.Test.Repositories
{
    public class UsersRepositoryTest
    {
        public UsersRepositoryTest()
        {

        }

        [Theory]
        [InlineData("ibrahim", "uylas")]
        public async Task UserNotExists(string username, string password)
        {
            var contextMock = new Mock<BMContext>();
            contextMock.Setup(_ => _.User.Add(new User { Username = "Nick", Pwd="357" }));

            var repository = new UsersRepository(contextMock.Object);
            var result = await repository.GetUserByUsernameAsync(username, password);

            Assert.Null(result);
        }

        [Theory]
        [InlineData("Ibrahim", "123")]
        public async Task UserExists(string username, string password)
        {
            var contextMock = new Mock<BMContext>();
            contextMock.Setup(_ => _.User.Add(new User { Username = "Ibrahim", Pwd = "123" }));

            var repository = new UsersRepository(contextMock.Object);
            var result = await repository.GetUserByUsernameAsync(username, password);

            Assert.NotNull(result);
        }
    }
}
