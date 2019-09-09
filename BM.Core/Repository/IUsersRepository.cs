using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BM.Domain.Entities;

namespace BM.Core.Repository
{
    public interface IUsersRepository
    {
        Task<IList<User>> GetAllAsync();

        Task<User> GetUserByUsernameAsync(string username, string password);
    }
}
