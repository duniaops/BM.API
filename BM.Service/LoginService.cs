using System;
using System.Linq;
using BM.Core.Repository;
using BM.Core.Service;
using BM.Domain.Entities;

namespace BM.Service
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository repository;

        public LoginService(ILoginRepository loginRepository)
        {
            this.repository = loginRepository;
        }

        public IQueryable<User> GetAll()
        {
            return repository.GetAll();
        }
    }
}
