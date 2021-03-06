#pragma checksum "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\Pages\FlightFields.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d0f0dc9b1a9c116ffa22841e70dada5a5c46013"
// <auto-generated/>
#pragma warning disable 1591
namespace FlightManagementBlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\_Imports.razor"
using FlightManagementBlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\_Imports.razor"
using FlightManagementBlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\_Imports.razor"
using DomainModel.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\_Imports.razor"
using Services;

#line default
#line hidden
#nullable disable
    public partial class FlightFields : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\Pages\FlightFields.razor"
 if(Carriers == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p>Loading...</p>");
#nullable restore
#line 6 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\Pages\FlightFields.razor"

}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "flightFields");
            __builder.AddMarkupContent(3, "<label for=\"flightNumber\">Flight Number</label>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(4);
            __builder.AddAttribute(5, "id", "flightNumber");
            __builder.AddAttribute(6, "class", "form-control");
            __builder.AddAttribute(7, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\Pages\FlightFields.razor"
                                                   Flight.Number

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Flight.Number = __value, Flight.Number))));
            __builder.AddAttribute(9, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Flight.Number));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n        \r\n        ");
            __builder.AddMarkupContent(11, "<label for=\"Carriers\">Carrier</label>\r\n        ");
            __Blazor.FlightManagementBlazorServer.Pages.FlightFields.TypeInference.CreateInputSelect_0(__builder, 12, 13, "Carriers", 14, "form-control", 15, 
#nullable restore
#line 15 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\Pages\FlightFields.razor"
                                                Flight.CarrierId

#line default
#line hidden
#nullable disable
            , 16, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Flight.CarrierId = __value, Flight.CarrierId)), 17, () => Flight.CarrierId, 18, (__builder2) => {
                __builder2.AddMarkupContent(19, "<option value>Select...</option>");
#nullable restore
#line 17 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\Pages\FlightFields.razor"
             foreach(var carrier in Carriers)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(20, "option");
                __builder2.AddAttribute(21, "value", 
#nullable restore
#line 19 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\Pages\FlightFields.razor"
                                carrier.Id

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 19 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\Pages\FlightFields.razor"
__builder2.AddContent(22, carrier.Name);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 20 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\Pages\FlightFields.razor"
            }

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(23, "\r\n\r\n        ");
            __builder.AddMarkupContent(24, "<label for=\"flightDate\">Flight Date</label>\r\n        ");
            __Blazor.FlightManagementBlazorServer.Pages.FlightFields.TypeInference.CreateInputDate_1(__builder, 25, 26, "flightDate", 27, "form-control", 28, 
#nullable restore
#line 24 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\Pages\FlightFields.razor"
                                                 Flight.FlightDate

#line default
#line hidden
#nullable disable
            , 29, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Flight.FlightDate = __value, Flight.FlightDate)), 30, () => Flight.FlightDate);
            __builder.AddMarkupContent(31, "\r\n\r\n        ");
            __builder.AddMarkupContent(32, "<label for=\"flightTime\">Flight Time</label>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(33);
            __builder.AddAttribute(34, "id", "flightTime");
            __builder.AddAttribute(35, "class", "form-control");
            __builder.AddAttribute(36, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\Pages\FlightFields.razor"
                                                 Flight.FlightTime

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Flight.FlightTime = __value, Flight.FlightTime))));
            __builder.AddAttribute(38, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Flight.FlightTime));
            __builder.CloseComponent();
            __builder.AddMarkupContent(39, "\r\n\r\n        ");
            __builder.AddMarkupContent(40, "<label for=\"airportTo\">Airport To</label>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(41);
            __builder.AddAttribute(42, "id", "airportTo");
            __builder.AddAttribute(43, "class", "form-control");
            __builder.AddAttribute(44, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\Pages\FlightFields.razor"
                                                Flight.AirportTo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Flight.AirportTo = __value, Flight.AirportTo))));
            __builder.AddAttribute(46, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Flight.AirportTo));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\Pages\FlightFields.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\Pages\FlightFields.razor"
       
    [Parameter]
    public Flight Flight { get; set; }

    public List<Carrier> Carriers{ get; set; }

    protected override async Task OnInitializedAsync()
    {
        Carriers = await _carrierService.GetCarriersAsync();
    }

    protected void OnCarrierChange(int value)
    {
        Flight.CarrierId = value;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CarrierService _carrierService { get; set; }
    }
}
namespace __Blazor.FlightManagementBlazorServer.Pages.FlightFields
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
