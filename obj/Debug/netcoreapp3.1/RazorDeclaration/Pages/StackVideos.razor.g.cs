#pragma checksum "D:\01.Projects\28. OrvizarWeb\orvizarwebPage\Pages\StackVideos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5013265a5dc913b464b5733cf2eaaddc1799c8f"
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
#line 1 "D:\01.Projects\28. OrvizarWeb\orvizarwebPage\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\01.Projects\28. OrvizarWeb\orvizarwebPage\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\01.Projects\28. OrvizarWeb\orvizarwebPage\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\01.Projects\28. OrvizarWeb\orvizarwebPage\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\01.Projects\28. OrvizarWeb\orvizarwebPage\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\01.Projects\28. OrvizarWeb\orvizarwebPage\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\01.Projects\28. OrvizarWeb\orvizarwebPage\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\01.Projects\28. OrvizarWeb\orvizarwebPage\_Imports.razor"
using OrvizarWebPageServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\01.Projects\28. OrvizarWeb\orvizarwebPage\_Imports.razor"
using OrvizarWebPageServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\01.Projects\28. OrvizarWeb\orvizarwebPage\_Imports.razor"
using OrvizarWebPageServer.SharedFolder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\01.Projects\28. OrvizarWeb\orvizarwebPage\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\01.Projects\28. OrvizarWeb\orvizarwebPage\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\01.Projects\28. OrvizarWeb\orvizarwebPage\_Imports.razor"
using OrvizarWebPageServer.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\01.Projects\28. OrvizarWeb\orvizarwebPage\Pages\StackVideos.razor"
using SharedFolder;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Stack/{Id:int}")]
    public partial class StackVideos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "D:\01.Projects\28. OrvizarWeb\orvizarwebPage\Pages\StackVideos.razor"
 
    [Parameter]
    public int Id { get; set; }
    public OrvizarWebPageServer.Data.PlayList types { get; set; }
    private SourceElements Elements;

    protected override async Task OnInitializedAsync()
    {
        types = (OrvizarWebPageServer.Data.PlayList)Id;

        Elements = await videosService.GetVideosAsync(types);

    }





#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OrvizarWebPageServer.Data.VideosDataService videosService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
