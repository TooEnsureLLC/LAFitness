using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TooEnsure.Lib.Backend;
using TooEnsure.Lib.Client.Models;
using TooEnsure.Lib.Client.Models.Pages;

namespace LAFitnessWeb.Server.Data
{
    public class PageRepository : IPageRepository
    {
        private readonly DataContext _context;

        public PageRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<int>> CreateArticle(Page article)
        {
            await _context.Pages.AddAsync(article);
            await _context.SaveChangesAsync();

            return new ServiceResponse<int>
            {
                Data = article.Id,
                Message = "Article Page Created"
            };
        }
    }
}
