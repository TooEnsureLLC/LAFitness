using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;

namespace LAFitnessWeb.Client
{
    public class CustomAuthStateProvider : AuthenticationStateProvider 
    {
        private readonly ILocalStorageService _localStorageService;

        public CustomAuthStateProvider(ILocalStorageService localStorageService)
        {
            _localStorageService = localStorageService;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var state = new AuthenticationState(new ClaimsPrincipal());
            if (await _localStorageService.GetItemAsync<bool>("isAuthenticated"))
            {
                // 1. Create an identity
                var identity = new ClaimsIdentity(
                    new[]
                    {
                    new Claim(ClaimTypes.Name, "LA-Fitness, Admin")
                    }, "test autentication type");

                // 2. pass identity into a user
                var user = new ClaimsPrincipal(identity);

                state = new AuthenticationState(user);

                
            }
            NotifyAuthenticationStateChanged(Task.FromResult(state));
            return state;

        }
    }
}
