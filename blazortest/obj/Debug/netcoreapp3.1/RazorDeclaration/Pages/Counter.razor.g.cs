#pragma checksum "/home/louwster3000/RiderProjects/blazortest/blazortest/Pages/Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d573bab9eca1ee14d83789e6008f94a2ffd5c4c4"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "/home/louwster3000/RiderProjects/blazortest/blazortest/Pages/Counter.razor"
       
    private int currentCount = 0;
    [Parameter]
    public int IncrementAmount { get; set; } = 1;

    private void IncrementCount()
    {
        currentCount += IncrementAmount;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
