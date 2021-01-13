using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LAFitnessWeb.Server.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TooEnsure.Lib.Client.Models.Article;

namespace LAFitnessWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public ArticleController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetPosts()
        {
            var articles = await _dataContext.Articles.ToListAsync();
            return Ok(articles);
        }

        [HttpPost]
        public async Task<IActionResult> AddPost(TextedPost post)
        {
            await _dataContext.Articles.AddAsync(post);
            await _dataContext.SaveChangesAsync();
            return Ok(await _dataContext.Articles.ToListAsync());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePost(int id, TextedPost post)
        {
            TextedPost dbPost = await _dataContext.Articles.FirstOrDefaultAsync(u => u.ID == id);

            if (dbPost == null)
            {
                return NotFound("Post with given id dosent exist");
            }

            dbPost.Title = post.Title;
            dbPost.Content = post.Content;

            await _dataContext.SaveChangesAsync();
            return Ok(dbPost);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePost(int id)
        {
            TextedPost dbPost = await _dataContext.Articles.FirstOrDefaultAsync(u => u.ID == id);

            if (dbPost == null)
            {
                return NotFound("Post with given id dosent exist");
            }

            _dataContext.Articles.Remove(dbPost);
            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.Articles.ToListAsync());
        }
    }
}
