using BlazorBlog.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBlog.Client.Services
{
    interface IBlogPostService
    {
        List<BlogPost> GetPosts();
        BlogPost GetPostByUrl(string url);
    }
}
