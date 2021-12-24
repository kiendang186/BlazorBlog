using BlazorBlog.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBlog.Client.Services
{
    interface IBlogPostService
    {
        Task<List<BlogPost>> GetPosts();
        Task<BlogPost> GetPostByUrl(string url);

        Task<BlogPost> CreateBlogPost(BlogPost request);
    }
}
