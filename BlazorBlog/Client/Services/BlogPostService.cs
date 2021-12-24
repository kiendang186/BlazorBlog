using BlazorBlog.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorBlog.Client.Services
{
    public class BlogPostService : IBlogPostService
    {
        private readonly HttpClient _http;

        public BlogPostService(HttpClient http)
        {
            _http = http;
        }

        public async Task<BlogPost> GetPostByUrl(string url)
        {
            var post = await _http.GetAsync($"api/Blog/{url}");
            if(post.StatusCode != System.Net.HttpStatusCode.OK)
            {
                var message = await post.Content.ReadAsStringAsync();
                return new BlogPost() { Title = message.ToString() };
            }
            else
            {
                return await post.Content.ReadFromJsonAsync<BlogPost>();
            }           
        }

        public async Task<List<BlogPost>> GetPosts()
        {
            return await _http.GetFromJsonAsync<List<BlogPost>>("api/Blog");
        }

        public async Task<BlogPost> CreateBlogPost(BlogPost request)
        {
            var result = await _http.PostAsJsonAsync<BlogPost>($"api/Blog", request);
            return await result.Content.ReadFromJsonAsync<BlogPost>();
        }
    }
}
