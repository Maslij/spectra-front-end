#pragma checksum "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ccae227a35c676c60940776e5b616b9c70e27a7"
// <auto-generated/>
#pragma warning disable 1591
namespace Spectra.Model.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\_Imports.razor"
using Spectra.Model.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\_Imports.razor"
using Spectra.Model.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenTooltip>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "page");
            __builder.AddAttribute(4, "b-5siuq89tld");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "main");
            __builder.AddAttribute(7, "b-5siuq89tld");
            __builder.OpenComponent<Spectra.Model.Client.Shared.NavBar>(8);
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "content px-4");
            __builder.AddAttribute(12, "b-5siuq89tld");
            __builder.AddContent(13, 
#nullable restore
#line 7 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenComponent<Spectra.Model.Client.Shared.Footer>(15);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
