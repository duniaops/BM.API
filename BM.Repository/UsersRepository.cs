using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BM.Core.Repository;
using BM.Domain.Entities;
using BM.EF;
using Microsoft.EntityFrameworkCore;

namespace BM.Repository
{
    public class UsersRepository : IUsersRepository
    {
        private BMContext context;
        public UsersRepository(BMContext context)
        {
            this.context = context;
        }

        public async Task<IList<User>> GetAllAsync()
        {
            IQueryable<User> query = context.Set<User>();
            return await query.ToListAsync();
        }

        public async Task<User> GetUserByUsernameAsync(string username, string password)
        {
            IQueryable<User> query = context.Set<User>();
            return await query.Where(_=> _.Username == username && _.Pwd == password).FirstOrDefaultAsync();
        }
    }
}
