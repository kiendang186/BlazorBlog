#pragma checksum "C:\Users\Kien Dang\source\repos\BlazorBlog\BlazorBlog\Client\Pages\Posts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c90e84ed17c01c769b1e9b9dfb5adbdc4d6104a"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/posts/{url}")]
    public partial class Posts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, 
#nullable restore
#line 4 "C:\Users\Kien Dang\source\repos\BlazorBlog\BlazorBlog\Client\Pages\Posts.razor"
     Post.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddContent(4, 
#nullable restore
#line 5 "C:\Users\Kien Dang\source\repos\BlazorBlog\BlazorBlog\Client\Pages\Posts.razor"
      Post.Content

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\Kien Dang\source\repos\BlazorBlog\BlazorBlog\Client\Pages\Posts.razor"
       
    
    public BlazorBlog.Shared.BlogPost Post;

    [Parameter]
    public string Url { get; set; }

    protected override void OnInitialized()
    {
        Post = BlogService.GetPostByUrl(Url);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorBlog.Client.Services.IBlogPostService BlogService { get; set; }
    }
}
#pragma warning restore 1591
