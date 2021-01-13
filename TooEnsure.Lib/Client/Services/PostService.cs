using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using TooEnsure.Lib.Client.Models.Article;
using TooEnsure.Lib.Client.Services.Interface;

namespace TooEnsure.Lib.Client.Services
{
    public class PostService : IPost
    {
        private readonly HttpClient _http;

        public PostService(HttpClient http)
        {
            _http = http;
        }

        public IList<TextedPost> Articles { get; set; } = new List<TextedPost>();

        public event Action OnChange;
       

        public void AddPost(int id, string title, string content)
        {
            Articles.Add(new TextedPost(id,title,content));
            HasChanged();
            Console.WriteLine("Added");
        }

        public void EditPost(int id)
        {
            throw new NotImplementedException();
        }

        public async Task LoadArticlesAsync()
        {
            if(Articles.Count == 0)
            {
                Articles = await _http.GetFromJsonAsync<IList<TextedPost>>("api/Article");
            }
        }

        public void RemovePost(int id)
        {
            throw new NotImplementedException();
        }
        void HasChanged() => OnChange.Invoke();

    }
}
