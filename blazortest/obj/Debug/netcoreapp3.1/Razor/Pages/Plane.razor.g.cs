#pragma checksum "/home/louwster3000/RiderProjects/blazortest/blazortest/Pages/Plane.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eeb70d63eed6e0c1016ddfb92a0b2a53c3bd42b8"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 4 "/home/louwster3000/RiderProjects/blazortest/blazortest/Pages/Plane.razor"
                 plane

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "form-group");
                __builder2.AddMarkupContent(6, "\n        ");
                __builder2.AddMarkupContent(7, "<label>Registration</label>\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(8);
                __builder2.AddAttribute(9, "id", "Registration");
                __builder2.AddAttribute(10, "class", "form-control");
                __builder2.AddAttribute(11, "name", "Registration");
                __builder2.AddAttribute(12, "value", 
#nullable restore
#line 7 "/home/louwster3000/RiderProjects/blazortest/blazortest/Pages/Plane.razor"
                                                                                            plane.Registration

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(13, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plane.Registration = __value, plane.Registration));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\n    ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-group");
                __builder2.AddMarkupContent(18, "\n        ");
                __builder2.AddMarkupContent(19, "<label>Manufacturer</label>\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(20);
                __builder2.AddAttribute(21, "id", "Manufacturer");
                __builder2.AddAttribute(22, "class", "form-control");
                __builder2.AddAttribute(23, "name", "Manufacturer");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "/home/louwster3000/RiderProjects/blazortest/blazortest/Pages/Plane.razor"
                                                                                            plane.Manufacturer

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plane.Manufacturer = __value, plane.Manufacturer))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => plane.Manufacturer));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\n    ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group");
                __builder2.AddMarkupContent(31, "\n        ");
                __builder2.AddMarkupContent(32, "<label>Passenger</label>\n        ");
                __Blazor.blazortest.Pages.Plane.TypeInference.CreateInputNumber_0(__builder2, 33, 34, "Passenger", 35, "form-control", 36, "Passenger", 37, 
#nullable restore
#line 15 "/home/louwster3000/RiderProjects/blazortest/blazortest/Pages/Plane.razor"
                                                                                        plane.Passenger

#line default
#line hidden
#nullable disable
                , 38, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plane.Passenger = __value, plane.Passenger)), 39, () => plane.Passenger);
                __builder2.AddMarkupContent(40, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\n    ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-group");
                __builder2.AddMarkupContent(44, "\n        ");
                __builder2.AddMarkupContent(45, "<label>Aircrafttype</label>\n        ");
                __builder2.OpenElement(46, "CustomSelect");
                __builder2.AddAttribute(47, "id", "AircraftType");
                __builder2.AddAttribute(48, "class", "form-control");
                __builder2.AddAttribute(49, "name", "Aircraft Type");
                __builder2.AddAttribute(50, "@bind", 
#nullable restore
#line 19 "/home/louwster3000/RiderProjects/blazortest/blazortest/Pages/Plane.razor"
                                                                                          plane.AircraftType

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(53, "\n\n");
            __builder.AddMarkupContent(54, "<h3>Edit Plane</h3>\n");
            __builder.OpenElement(55, "h4");
            __builder.AddContent(56, 
#nullable restore
#line 24 "/home/louwster3000/RiderProjects/blazortest/blazortest/Pages/Plane.razor"
     Registration

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
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
namespace __Blazor.blazortest.Pages.Plane
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "name", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591