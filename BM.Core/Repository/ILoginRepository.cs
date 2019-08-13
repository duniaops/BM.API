using System.Linq;
using BM.Domain.Entities;

namespace BM.Core.Repository
{
    public interface ILoginRepository
    {
        IQueryable<User> GetAll();
    }
}
