#pragma checksum "C:\Users\mqhelemguni\source\repos\MyFirstBlazorApp\MyFirstBlazorApp\Pages\DynamicComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b9229ab62d6c52e987458c22d6db82b1a2c2495"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MyFirstBlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mqhelemguni\source\repos\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mqhelemguni\source\repos\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mqhelemguni\source\repos\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mqhelemguni\source\repos\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mqhelemguni\source\repos\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mqhelemguni\source\repos\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mqhelemguni\source\repos\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mqhelemguni\source\repos\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using MyFirstBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mqhelemguni\source\repos\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using MyFirstBlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/dynamic")]
    public partial class DynamicComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\mqhelemguni\source\repos\MyFirstBlazorApp\MyFirstBlazorApp\Pages\DynamicComponent.razor"
       

    private string title;
    private string content;

    
    private void HandleBlazorServerClick() {
        title = "Blazor Server";
        content = "Blazor is cool it generates great dynamic content and sends the content to the browser";
    }

    private void HandleBlazoWebAssemblyClick()
    {
        title = "Blazor WebAssembly";
        content = "Blazor WebAssemly runs completely within the browser and genearates dynamic content";

    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
