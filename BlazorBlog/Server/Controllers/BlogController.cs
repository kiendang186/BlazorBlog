﻿using BlazorBlog.Server.Data;
using BlazorBlog.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBlog.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly DataContext _context;

        public BlogController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<BlogPost>> GetPostsList()
        {
            return Ok(_context.BlogPosts);
        }

        [HttpGet("{url}")]
        public ActionResult<BlogPost> GetSinglePost(string url)
        {
            var post = _context.BlogPosts.FirstOrDefault(p => p.Url.ToLower().Equals(url));
            if(post == null)
            {
                return NotFound("This post does not exist");
            }           
            return Ok(post);          
        }

        [HttpPost]
        public async Task<ActionResult<BlogPost>> CreateNewBlogPost(BlogPost request)
        {
            _context.BlogPosts.Add(request);
            await _context.SaveChangesAsync();
            return request;
        }
    }
}
