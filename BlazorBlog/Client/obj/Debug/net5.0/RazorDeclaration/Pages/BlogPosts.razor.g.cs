// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorBlog.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Kien Dang\source\repos\BlazorBlog\BlazorBlog\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kien Dang\source\repos\BlazorBlog\BlazorBlog\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kien Dang\source\repos\BlazorBlog\BlazorBlog\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kien Dang\source\repos\BlazorBlog\BlazorBlog\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kien Dang\source\repos\BlazorBlog\BlazorBlog\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kien Dang\source\repos\BlazorBlog\BlazorBlog\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kien Dang\source\repos\BlazorBlog\BlazorBlog\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kien Dang\source\repos\BlazorBlog\BlazorBlog\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kien Dang\source\repos\BlazorBlog\BlazorBlog\Client\_Imports.razor"
using BlazorBlog.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Kien Dang\source\repos\BlazorBlog\BlazorBlog\Client\_Imports.razor"
using BlazorBlog.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Kien Dang\source\repos\BlazorBlog\BlazorBlog\Client\Pages\BlogPosts.razor"
using BlazorBlog.Shared;

#line default
#line hidden
#nullable disable
    public partial class BlogPosts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\Kien Dang\source\repos\BlazorBlog\BlazorBlog\Client\Pages\BlogPosts.razor"
       
    public List<BlogPost> Posts { get; set; } = new List<BlogPost>()
    {
        new BlogPost(){ Title = "A New Tutorial about Blazor", Description = "This is a new tutorial, showing you how to buid a blog with Blazor"},
        new BlogPost(){ Title = "My First Blog Post", Description="Hi!This is my new shiny blog. Enjoy!"}
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
