#pragma checksum "D:\01.Projects\28. OrvizarWeb\orvizarwebPage\Pages\TkinterPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d564e8e280f8967ca3e0f120be9b7b57b9a2ac9"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Tkinter")]
    public partial class TkinterPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.AddMarkupContent(3, "<div class=\"row\">\r\n            <img src=\"/images/Logo.png\" asp-append-version=\"true\" width=\"150\">\r\n            <h1 class=\"center-button py-3\">  Curso de  Tkinter </h1>\r\n        </div>\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n\r\n\r\n    ");
            __builder.AddMarkupContent(5, "<div class=\"content mt-2\">\r\n        <p>\r\n            <h2>\r\n                Aprende Tkiniter (UI Para python)\r\n            </h2>\r\n        </p>\r\n        <p>\r\n            Aprende a crear Interfaces de usuario usando uno de las librerías mas utilizadas en python Tkinter. Esta librería permite crear Interfaces gráficas de manera bastante simple en python  pero con una muy limitad riqueza en sus herramientas. A pesar de no ser la mejor para crear una aplicación a gran escala es muy útil para poder realizar pequeños proyectos, testear tu código , presentar un pequeña interfaz para aplicaciones básicas cuando necesitas salir de ese aprieto de inmediato.\r\n        </p>\r\n\r\n        <div class=\"center-button\">\r\n            <iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/iuhvOU9PefU\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n        </div>\r\n\r\n        <p>\r\n            <h2>\r\n                Revisemos una Aplicacion de Tkinter\r\n            </h2>\r\n        </p>\r\n        <p>\r\n            Realizamos una interfaces gráficas en Python. Utilizando Tkinter.  Para este caso vamos a realizar una aplicación que nos permita mejorar nuestra productividad . Vamos a ver conceptos que ya habias repaso en el video anterior\r\n        </p>\r\n        <div class=\"center-button\">\r\n            <iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/ACT9uDY2oY0\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n        </div>\r\n        <p>\r\n            Revisemos el Thread dentro de nuestra aplicación para tener el tiempo que necesitamos.\r\n        </p>\r\n        <div class=\"center-button\">\r\n            <iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/05vIaRuujuk\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n        </div>\r\n        <p>\r\n            Seguimos con el curso de Tkinter para poder crear una aplicacion que la podemos utilizar en nuestro escritorio.\r\n        </p>\r\n        <div class=\"center-button\">\r\n\r\n            <iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/8sE3H3ccgwo\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n        </div>\r\n        <p>\r\n            En este video veremos como  crear un ejecutable desde python como convertir nuestra aplicacion en un .exe para que lo podamos compartir con los demas.\r\n        </p>\r\n        <div class=\"center-button\">\r\n\r\n            <iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/80dbOfNgrrY\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n        </div>\r\n    </div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
