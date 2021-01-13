using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using TooEnsure.Lib.Client.Models;
using TooEnsure.Lib.Client.Models.Authentication;
using TooEnsure.Lib.Client.Services.Interface;

namespace TooEnsure.Lib.Client.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;

        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ServiceResponse<int>> Register(UserRegister requst)
        {
            var result = await _httpClient.PostAsJsonAsync("api/Auth/register", requst);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
        }
    }
}
