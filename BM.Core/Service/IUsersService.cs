using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BM.Domain.Entities;
using BM.Domain.Models;

namespace BM.Core.Service
{
    public interface IUsersService
    {
        Task<IList<User>> GetAllAsync();

        Task<LoginResultModel> AuthenticateAsync(LoginModel loginModel);
    }
}
