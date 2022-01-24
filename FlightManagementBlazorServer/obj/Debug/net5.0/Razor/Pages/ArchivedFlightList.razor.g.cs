#pragma checksum "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\Pages\ArchivedFlightList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e7a3c5939f239d9decbe31154e7802f6eb369d9"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/archivedFlightList")]
    public partial class ArchivedFlightList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Archived Flights</h3>");
#nullable restore
#line 6 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\Pages\ArchivedFlightList.razor"
 if(Flights == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p>Loading...</p>");
#nullable restore
#line 9 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\Pages\ArchivedFlightList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddMarkupContent(3, "<thead><tr><th>Number</th>\r\n                <th>Date</th>\r\n                <th>Time</th>\r\n                <th>Carrier</th>\r\n                <th>Airport to</th></tr></thead>\r\n        ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 23 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\Pages\ArchivedFlightList.razor"
             foreach(var flight in Flights)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
#nullable restore
#line 26 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\Pages\ArchivedFlightList.razor"
__builder.AddContent(7, flight.Number);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n                    ");
            __builder.OpenElement(9, "td");
#nullable restore
#line 27 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\Pages\ArchivedFlightList.razor"
__builder.AddContent(10, flight.FlightDate.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "td");
#nullable restore
#line 28 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\Pages\ArchivedFlightList.razor"
__builder.AddContent(13, flight.FlightTime);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "td");
#nullable restore
#line 29 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\Pages\ArchivedFlightList.razor"
__builder.AddContent(16, flight.AirportTo);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\Pages\ArchivedFlightList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\Pages\ArchivedFlightList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\Bojan\Desktop\AirportSystem_Lecture8_Start\FlightManagementBlazorServer\Pages\ArchivedFlightList.razor"
       
    public List<Flight> Flights { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Flights = await _flightService.GetArchivedFlights();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FlightService _flightService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591
