#pragma checksum "D:\source\repos\OrvizarWebPageServer\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "027b3ef8e9ba1c22f9b505eab7b5c66fb5ed75ac"
// <auto-generated/>
#pragma warning disable 1591
namespace OrvizarWebPageServer.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\source\repos\OrvizarWebPageServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\source\repos\OrvizarWebPageServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\source\repos\OrvizarWebPageServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\source\repos\OrvizarWebPageServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\source\repos\OrvizarWebPageServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\source\repos\OrvizarWebPageServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\source\repos\OrvizarWebPageServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\source\repos\OrvizarWebPageServer\_Imports.razor"
using OrvizarWebPageServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\source\repos\OrvizarWebPageServer\_Imports.razor"
using OrvizarWebPageServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\source\repos\OrvizarWebPageServer\_Imports.razor"
using SharedFolder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\source\repos\OrvizarWebPageServer\_Imports.razor"
using OrvizarWebPageServer.SharedFolder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\source\repos\OrvizarWebPageServer\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\source\repos\OrvizarWebPageServer\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\source\repos\OrvizarWebPageServer\_Imports.razor"
using OrvizarWebPageServer.Data;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<OrvizarWebPageServer.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "container-fluid bg-orvizar");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.AddMarkupContent(9, @"<div class=""row top-bar"">
        <h1 class=""center-button ml-5""> Orvizar tu sitio para aprender </h1>
        <div class=""user-info"">
            <a href=""https://www.youtube.com/channel/UCpO7BGqaPLRlMoffNxTxw2A/featured"" target=""_blank""> <strong>Nuestros Videos </strong>  </a>
            <span style=""vertical-align:middle;margin:0px 10px""> </span>
            <a href=""https://www.youtube.com/channel/UCpO7BGqaPLRlMoffNxTxw2A/featured"" target=""_blank"">
                <img src="" /images/youtube.png"" asp-append-version=""true"" width=""40"" style=""vertical-align:middle;margin:0px 10px"">
            </a>
            <a href=""https://www.instagram.com/orvizar/"" target=""_blank"">
                <img src="" /images/instagram.png"" asp-append-version=""true"" width=""40"" style=""vertical-align:middle;margin:0px 10px"">
            </a>

            <a href=""https://www.facebook.com/orvizar/"" target=""_blank"">
                <img src="" /images/facebook.png"" asp-append-version=""true"" width=""40"" style=""vertical-align:middle;margin:0px 10px"">
            </a>
        </div>
    </div>

    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "content px-3");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.AddContent(13, 
#nullable restore
#line 28 "D:\source\repos\OrvizarWebPageServer\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n   \r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
