#pragma checksum "D:\source\repos\OrvizarWebPageServer\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d201a66d2e8c27b01ade6aa52d83f64a042f550"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 119 "D:\source\repos\OrvizarWebPageServer\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;
    private bool expandSubMenuA = false;
    private bool expandSubMenuB = false;
    private bool expandSubMenuC = false;
    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;
    public async Task NavigateToNewTab()
    {
        string url = "https://orvizarblog.blogspot.com/";
     
        await jsRuntime.InvokeAsync<object>("open", url, "_blank");
    }
    private void ExpandSubMenuA()
    {
        expandSubMenuA = !expandSubMenuA;
        expandSubMenuB = false;
        expandSubMenuC = false;
    }
    private void ExpandSubMenuB()
    {
        expandSubMenuB = !expandSubMenuB;
        expandSubMenuA = false;
        expandSubMenuC = false;
    }
    private void ExpandSubMenuC()
    {
        expandSubMenuC = !expandSubMenuC;
        expandSubMenuB = false;
        expandSubMenuA = false;
    }

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591