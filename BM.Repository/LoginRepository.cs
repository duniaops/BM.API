using System;
using System.Linq;
using BM.Core.Repository;
using BM.Domain.Entities;
using BM.EF;

namespace BM.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private BMContext context;
        public LoginRepository(BMContext context)
        {
            this.context = context;
        }

        public IQueryable<User> GetAll()
        {

            IQueryable<User> query = context.Set<User>();
            return query;
        }
    }
}
