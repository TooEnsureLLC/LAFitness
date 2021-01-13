using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TooEnsure.Lib.Client.Models;
using TooEnsure.Lib.Client.Models.Pages;

namespace TooEnsure.Lib.Client.Services.Interface
{
    public interface IPageService
    {
        Task<ServiceResponse<int>> CreatePage(ArticlePage requst);
    }
}
