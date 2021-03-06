#pragma checksum "D:\01.Projects\28. OrvizarWeb\orvizarwebPage\Pages\MatplotlibPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b08e3410151a61608f3037679b4d4cdd565c7a4b"
// <auto-generated/>
#pragma warning disable 1591
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
#line 10 "D:\01.Projects\28. OrvizarWeb\orvizarwebPage\_Imports.razor"
using SharedFolder;

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Matplotlib")]
    public partial class MatplotlibPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.AddMarkupContent(3, "<div class=\"row\">\r\n            <img src=\"/images/Logo.png\" asp-append-version=\"true\" width=\"150\">\r\n            <h1 class=\"center-button py-3\">   Qué es Matplotlib ?</h1>\r\n        </div>\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n\r\n\r\n    ");
            __builder.AddMarkupContent(5, "<div class=\"content mt-2\">\r\n        <p>\r\n            <h2>\r\n                Tutorial Básico de matplotlib\r\n            </h2>\r\n        </p>\r\n        <p>\r\n            Este es el tutorial introductorio a la libreria matplotlib de python, la misma que te permitirá elaborar gráficos para poder mostrar la información de una manera más clara y concisa. El tutorial no solamente abarca como graficar en el ambiente de programación de python, sino que también ilustra con ejemplos los tipos de gráficas que se pueden dibujar.\r\n        </p>\r\n\r\n        <div class=\"center-button\">\r\n            <iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/4t3ZqgcAbAg?start=4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n        </div>\r\n        <p>\r\n            En este video aprenderemos como usar matplotlib para gráficas de estadística y como optimizar de mejor manera el código para poder graficarlas.\r\n\r\n        </p>\r\n        <div class=\"center-button\">\r\n            <iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/FB2QYlZYbLQ?start=4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n        </div>\r\n        <p>\r\n            En este video continuaremos aprendiendo como usar matplotlib para gráficas de estadística y como optimizar de mejor manera el código para poder graficarlas.\r\n\r\n        </p>\r\n        <div class=\"center-button\">\r\n            <iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/onXXD4n19fw?start=4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n        </div>\r\n        <p>\r\n            <h2>\r\n                Tutorial Avanzado de matplotlib\r\n            </h2>\r\n        </p>\r\n        <p>\r\n            En este video continuaremos con el tutorial para graficar en matplotlib, ahora mejoraremos las graficas con una personalizacion en los colores, de manera que puedan ser modificados de manera fácil y rápida.\r\n\r\n        </p>\r\n        <div class=\"center-button\">\r\n\r\n            <iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/VMReboADqU4?start=2\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n        </div>\r\n\r\n        <p>\r\n            El curso Completo de matplotlib avanzado aca :\r\n\r\n        </p>\r\n        <div class=\"center-button\">\r\n\r\n            <iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/videoseries?start=2&amp;list=PL6GZzVvsfrGFEXFyrG0qi0UJdy9gzwy9w\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n        </div>\r\n\r\n    </div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
