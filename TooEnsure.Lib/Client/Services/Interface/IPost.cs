using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TooEnsure.Lib.Client.Models.Article;

namespace TooEnsure.Lib.Client.Services.Interface
{
    public interface IPost
    {
        // Members
        event Action OnChange;
        IList<TextedPost> Articles { get; set; }
        void AddPost(int id, string title, string content);
        void RemovePost(int id);
        void EditPost(int id);
        Task LoadArticlesAsync();

    }
}
