#pragma checksum "D:\source\repos\OrvizarWebPageServer\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d201a66d2e8c27b01ade6aa52d83f64a042f550"
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-3 navbar navbar-dark");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href><img src=\" /images/Logo.png\" asp-append-version=\"true\" width=\"100\"><strong>Orvizar</strong></a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "D:\source\repos\OrvizarWebPageServer\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\"> </span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n\r\n\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", 
#nullable restore
#line 12 "D:\source\repos\OrvizarWebPageServer\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "D:\source\repos\OrvizarWebPageServer\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "ul");
            __builder.AddAttribute(16, "class", "nav flex-column");
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "li");
            __builder.AddAttribute(19, "class", "nav-item px-3");
            __builder.AddMarkupContent(20, "\r\n\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(21);
            __builder.AddAttribute(22, "class", "nav-link");
            __builder.AddAttribute(23, "href", "");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "D:\source\repos\OrvizarWebPageServer\Shared\NavMenu.razor"
                                                        ExpandSubMenuA

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(26, "\r\n                ");
                __builder2.AddMarkupContent(27, "<span><img src=\" /images/pythonc.png\" asp-append-version=\"true\" width=\"30\"></span> ");
                __builder2.AddMarkupContent(28, "<span class=\"px-3\"> Python</span>\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 19 "D:\source\repos\OrvizarWebPageServer\Shared\NavMenu.razor"
             if (expandSubMenuA)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "                ");
            __builder.OpenElement(31, "ul");
            __builder.AddAttribute(32, "class", "nav flex-column");
            __builder.AddMarkupContent(33, "\r\n\r\n                    ");
            __builder.OpenElement(34, "li");
            __builder.AddAttribute(35, "class", "nav-item px-2");
            __builder.AddMarkupContent(36, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(37);
            __builder.AddAttribute(38, "class", "nav-link");
            __builder.AddAttribute(39, "href", "Anaconda");
            __builder.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(41, "\r\n                            ");
                __builder2.AddMarkupContent(42, "<span aria-hidden=\"true\"><img src=\" /images/anacondatrasn.png\" asp-append-version=\"true\" width=\"30\"></span>\r\n                            ");
                __builder2.AddMarkupContent(43, "<span class=\"px-3\"> Anaconda</span>\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.OpenElement(46, "li");
            __builder.AddAttribute(47, "class", "nav-item px-2");
            __builder.AddMarkupContent(48, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(49);
            __builder.AddAttribute(50, "class", "nav-link");
            __builder.AddAttribute(51, "href", "Python");
            __builder.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(53, "\r\n                            ");
                __builder2.AddMarkupContent(54, "<span aria-hidden=\"true\"><img src=\" /images/pythonins.png\" asp-append-version=\"true\" width=\"30\"></span>\r\n                            ");
                __builder2.AddMarkupContent(55, "<span class=\"px-3\"> Curso Gratis</span>\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                    ");
            __builder.OpenElement(58, "li");
            __builder.AddAttribute(59, "class", "nav-item px-2");
            __builder.AddMarkupContent(60, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(61);
            __builder.AddAttribute(62, "class", "nav-link");
            __builder.AddAttribute(63, "href", "Matplotlib");
            __builder.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(65, "\r\n                            ");
                __builder2.AddMarkupContent(66, "<span aria-hidden=\"true\"><img src=\" /images/matplotlib2.png\" asp-append-version=\"true\" width=\"30\"></span>\r\n                            ");
                __builder2.AddMarkupContent(67, "<span class=\"px-3\"> Matplotlibs</span>\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(68, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                    ");
            __builder.OpenElement(70, "li");
            __builder.AddAttribute(71, "class", "nav-item px-2");
            __builder.AddMarkupContent(72, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(73);
            __builder.AddAttribute(74, "class", "nav-link");
            __builder.AddAttribute(75, "href", "Pandas");
            __builder.AddAttribute(76, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(77, "\r\n                            ");
                __builder2.AddMarkupContent(78, "<span aria-hidden=\"true\"><img src=\" /images/pandas1.png\" asp-append-version=\"true\" width=\"40\"></span>\r\n                            ");
                __builder2.AddMarkupContent(79, "<span class=\"px-3\"> Pandas</span>\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(80, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                    ");
            __builder.OpenElement(82, "li");
            __builder.AddAttribute(83, "class", "nav-item px-2");
            __builder.AddMarkupContent(84, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(85);
            __builder.AddAttribute(86, "class", "nav-link");
            __builder.AddAttribute(87, "href", "Tkinter");
            __builder.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(89, "\r\n                            ");
                __builder2.AddMarkupContent(90, "<span aria-hidden=\"true\"><img src=\" /images/tkinter.png\" asp-append-version=\"true\" width=\"30\"></span>\r\n                            ");
                __builder2.AddMarkupContent(91, "<span class=\"px-3\"> Tkinter</span>\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(92, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n");
#nullable restore
#line 54 "D:\source\repos\OrvizarWebPageServer\Shared\NavMenu.razor"

            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(95, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n        ");
            __builder.OpenElement(97, "li");
            __builder.AddAttribute(98, "class", "nav-item px-3");
            __builder.AddMarkupContent(99, "\r\n\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(100);
            __builder.AddAttribute(101, "class", "nav-link");
            __builder.AddAttribute(102, "href", "");
            __builder.AddAttribute(103, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "D:\source\repos\OrvizarWebPageServer\Shared\NavMenu.razor"
                                                        ExpandSubMenuB

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(104, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(105, "\r\n                ");
                __builder2.AddMarkupContent(106, "<span><img src=\" /images/visualStudio.png\" asp-append-version=\"true\" width=\"40\"></span> ");
                __builder2.AddMarkupContent(107, "<span class=\"px-3\"> C#</span>\r\n\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(108, "\r\n");
#nullable restore
#line 63 "D:\source\repos\OrvizarWebPageServer\Shared\NavMenu.razor"
             if (expandSubMenuB)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(109, "                ");
            __builder.OpenElement(110, "ul");
            __builder.AddAttribute(111, "class", "nav flex-column");
            __builder.AddMarkupContent(112, "\r\n\r\n                    ");
            __builder.OpenElement(113, "li");
            __builder.AddAttribute(114, "class", "nav-item px-2");
            __builder.AddMarkupContent(115, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(116);
            __builder.AddAttribute(117, "class", "nav-link");
            __builder.AddAttribute(118, "href", "Csharpbasico");
            __builder.AddAttribute(119, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(120, "\r\n                            ");
                __builder2.AddMarkupContent(121, "<span aria-hidden=\"true\"><img src=\" /images/csharp3.png\" asp-append-version=\"true\" width=\"30\"></span>\r\n                            ");
                __builder2.AddMarkupContent(122, "<span class=\"px-3\"> Curso Basico</span>\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(123, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n                    ");
            __builder.OpenElement(125, "li");
            __builder.AddAttribute(126, "class", "nav-item px-2");
            __builder.AddMarkupContent(127, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(128);
            __builder.AddAttribute(129, "class", "nav-link");
            __builder.AddAttribute(130, "href", "Unity");
            __builder.AddAttribute(131, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(132, "\r\n                            ");
                __builder2.AddMarkupContent(133, "<span aria-hidden=\"true\"><img src=\" /images/unity2.png\" asp-append-version=\"true\" width=\"30\"></span>\r\n                            ");
                __builder2.AddMarkupContent(134, "<span class=\"px-3\"> Curso Unity</span>\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(135, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n");
#nullable restore
#line 81 "D:\source\repos\OrvizarWebPageServer\Shared\NavMenu.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(138, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n        ");
            __builder.OpenElement(140, "li");
            __builder.AddAttribute(141, "class", "nav-item px-3");
            __builder.AddMarkupContent(142, "\r\n\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(143);
            __builder.AddAttribute(144, "class", "nav-link");
            __builder.AddAttribute(145, "href", "");
            __builder.AddAttribute(146, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 85 "D:\source\repos\OrvizarWebPageServer\Shared\NavMenu.razor"
                                                         ExpandSubMenuC

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(147, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(148, "\r\n                <span class=\"oi oi-script\" aria-hidden=\"true\"></span> ");
                __builder2.AddMarkupContent(149, "<span class=\"px-3\"> Avanzado</span>\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(150, "\r\n");
#nullable restore
#line 88 "D:\source\repos\OrvizarWebPageServer\Shared\NavMenu.razor"
             if (expandSubMenuC)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(151, "                ");
            __builder.OpenElement(152, "ul");
            __builder.AddAttribute(153, "class", "nav flex-column");
            __builder.AddMarkupContent(154, "\r\n\r\n                    ");
            __builder.OpenElement(155, "li");
            __builder.AddAttribute(156, "class", "nav-item px-2");
            __builder.AddMarkupContent(157, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(158);
            __builder.AddAttribute(159, "class", "nav-link");
            __builder.AddAttribute(160, "href", "Optimizacion");
            __builder.AddAttribute(161, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(162, "\r\n                            ");
                __builder2.AddMarkupContent(163, "<span aria-hidden=\"true\"><img src=\" /images/algo1.png\" asp-append-version=\"true\" width=\"30\"></span>\r\n                            ");
                __builder2.AddMarkupContent(164, "<span class=\"px-2\"> Optimizacion</span>\r\n\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(165, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n                    ");
            __builder.OpenElement(167, "li");
            __builder.AddAttribute(168, "class", "nav-item px-2");
            __builder.AddMarkupContent(169, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(170);
            __builder.AddAttribute(171, "class", "nav-link");
            __builder.AddAttribute(172, "href", "Opencv");
            __builder.AddAttribute(173, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(174, "\r\n                            ");
                __builder2.AddMarkupContent(175, "<span aria-hidden=\"true\"><img src=\" /images/opencvtrasn.png\" asp-append-version=\"true\" width=\"30\"></span>\r\n                            ");
                __builder2.AddMarkupContent(176, "<span class=\"px-3\"> Open CV</span>\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(177, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(178, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(179, "\r\n");
#nullable restore
#line 107 "D:\source\repos\OrvizarWebPageServer\Shared\NavMenu.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(180, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(181, "\r\n        ");
            __builder.OpenElement(182, "li");
            __builder.AddAttribute(183, "class", "nav-item px-3");
            __builder.AddMarkupContent(184, "\r\n\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(185);
            __builder.AddAttribute(186, "class", "nav-link");
            __builder.AddAttribute(187, "href", "");
            __builder.AddAttribute(188, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 111 "D:\source\repos\OrvizarWebPageServer\Shared\NavMenu.razor"
                                                         NavigateToNewTab

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(189, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(190, "\r\n                <span class=\"oi oi-comment-square\" aria-hidden=\"true\"></span> ");
                __builder2.AddMarkupContent(191, "<span class=\"px-3\"> Blog </span>\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(192, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(193, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(194, "\r\n");
            __builder.CloseElement();
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
