#pragma checksum "D:\source\repos\OrvizarWebPageServer\Pages\PythonCourse.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cc7a0093ca1c0e31f0c937161c45f88fc41a3da"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace OrvizarWebPageServer.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Python")]
    public partial class PythonCourse : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "D:\source\repos\OrvizarWebPageServer\Pages\PythonCourse.razor"
       
    public List<string> ListVideos { get; set; } = new List<string>
{
      "https://www.youtube.com/embed/_ihdkS8jBvA",


    };

    public OrvizarWebPageServer.Data.PlayList PlayListType { get; set; } = Data.PlayList.Anaconda;
    public int Id { get; set; } = 0;
    public int ConvertFromPlayListToInt(OrvizarWebPageServer.Data.PlayList playList)
    {
        return (int)playList;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
