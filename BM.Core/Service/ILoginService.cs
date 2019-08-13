using System;
using System.Linq;
using BM.Domain.Entities;

namespace BM.Core.Service
{
    public interface ILoginService
    {
        IQueryable<User> GetAll();
    }
}
