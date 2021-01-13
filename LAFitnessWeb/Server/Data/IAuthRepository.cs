using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TooEnsure.Lib;
using TooEnsure.Lib.Client.Models;

namespace LAFitnessWeb.Server.Data
{
    public interface IAuthRepository
    {
        Task<ServiceResponse<int>> Register(User user, string password);
        Task<ServiceResponse<string>> Login(string email, string password);
        Task<bool> UserExist(string email);
    }
}
