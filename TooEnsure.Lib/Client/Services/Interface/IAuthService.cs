using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TooEnsure.Lib.Client.Models;
using TooEnsure.Lib.Client.Models.Authentication;

namespace TooEnsure.Lib.Client.Services.Interface
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> Register(UserRegister requst);
    }
}
