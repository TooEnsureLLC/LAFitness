using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using TooEnsure.Lib.Client.Models;
using TooEnsure.Lib.Client.Models.Pages;
using TooEnsure.Lib.Client.Services.Interface;

namespace TooEnsure.Lib.Client.Services
{
    public class PageService : IPageService
    {
        private readonly HttpClient _httpClient;

        public PageService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ServiceResponse<int>> CreatePage(ArticlePage requst)
        {
            var result = await _httpClient.PostAsJsonAsync("api/Page/page", requst);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
        }
    }
}
