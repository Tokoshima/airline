#pragma checksum "/home/louwster3000/RiderProjects/blazortest/blazortest/Pages/Plane.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eeb70d63eed6e0c1016ddfb92a0b2a53c3bd42b8"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace blazortest.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/louwster3000/RiderProjects/blazortest/blazortest/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/louwster3000/RiderProjects/blazortest/blazortest/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/louwster3000/RiderProjects/blazortest/blazortest/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/louwster3000/RiderProjects/blazortest/blazortest/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/louwster3000/RiderProjects/blazortest/blazortest/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/louwster3000/RiderProjects/blazortest/blazortest/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/louwster3000/RiderProjects/blazortest/blazortest/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/louwster3000/RiderProjects/blazortest/blazortest/_Imports.razor"
using blazortest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/louwster3000/RiderProjects/blazortest/blazortest/_Imports.razor"
using blazortest.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/louwster3000/RiderProjects/blazortest/blazortest/_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/louwster3000/RiderProjects/blazortest/blazortest/_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/plane/{Registration}")]
    public partial class Plane : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "/home/louwster3000/RiderProjects/blazortest/blazortest/Pages/Plane.razor"
       

    [Parameter]
    public string Registration { get; set; }

    private Data.Aircraft plane { get; set; }

    protected override void OnInitialized()
    {
        plane = AircraftService.GetPlane(Registration);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private blazortest.Data.AircraftIE AircraftService { get; set; }
    }
}
#pragma warning restore 1591
