using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LAFitnessWeb.Server.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TooEnsure.Lib.Backend;
using TooEnsure.Lib.Client.Models.Pages;

namespace LAFitnessWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PageController : ControllerBase
    {
        private readonly IPageRepository _pageRepository;

        public PageController(IPageRepository pageRepository)
        {
            _pageRepository = pageRepository;
        }

        [HttpPost("page")]
        public async Task<IActionResult> CreatePage(ArticlePage request)
        {
            var response = await _pageRepository.CreateArticle(
                new Page
                {
                    ImageUri = request.ImageUri,
                    Title = request.Title,
                    Content = request.Content
                }
            );

            return Ok(response);
        }
    }
}
