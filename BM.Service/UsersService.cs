using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BM.Core.Repository;
using BM.Core.Service;
using BM.Domain.Entities;
using BM.Domain.Models;

namespace BM.Service
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository repository;

        public UsersService(IUsersRepository loginRepository)
        {
            this.repository = loginRepository;
        }

        public async Task<IList<User>> GetAllAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<LoginResultModel> AuthenticateAsync(LoginModel loginModel)
        {
            return new LoginResultModel();
        }
    }
}
