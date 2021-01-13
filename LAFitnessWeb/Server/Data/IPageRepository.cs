using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TooEnsure.Lib.Backend;
using TooEnsure.Lib.Client.Models;
using TooEnsure.Lib.Client.Models.Pages;

namespace LAFitnessWeb.Server.Data
{
    public interface IPageRepository
    {
        Task<ServiceResponse<int>> CreateArticle(Page article);
    }
}
