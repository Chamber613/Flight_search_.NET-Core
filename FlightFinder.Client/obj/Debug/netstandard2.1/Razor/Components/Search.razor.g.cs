#pragma checksum "E:\Sample Projects\ASP.NET project\aspnet samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\Search.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7733d5d0678b4a046f4e10ccc76fdfa5cc916f5b9e325896297739e6a7c8dead"
// <auto-generated/>
#pragma warning disable 1591
namespace FlightFinder.Client.Components
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Sample Projects\ASP.NET project\aspnet samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "E:\Sample Projects\ASP.NET project\aspnet samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 3 "E:\Sample Projects\ASP.NET project\aspnet samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 4 "E:\Sample Projects\ASP.NET project\aspnet samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 5 "E:\Sample Projects\ASP.NET project\aspnet samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\_Imports.razor"
using FlightFinder.Client.Services

#nullable disable
    ;
#nullable restore
#line 6 "E:\Sample Projects\ASP.NET project\aspnet samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\_Imports.razor"
using FlightFinder.Client.Components

#nullable disable
    ;
#nullable restore
#line 7 "E:\Sample Projects\ASP.NET project\aspnet samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\_Imports.razor"
using FlightFinder.Shared

#line default
#line hidden
#nullable disable
    ;
    #nullable restore
    public partial class Search : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col");
            __builder.AddMarkupContent(2, "\r\n    \r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row py-1");
            __builder.AddMarkupContent(5, "\r\n        \r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col pr-0");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-control d-flex");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, "<div><i>✈</i>&nbsp;&nbsp;From:</div>\r\n                ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "list", "airports");
            __builder.AddAttribute(15, "placeholder", "...");
            __builder.AddAttribute(16, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "E:\Sample Projects\ASP.NET project\aspnet samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\Search.razor"
                                                                criteria.FromAirport

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => criteria.FromAirport = __value, criteria.FromAirport));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.AddMarkupContent(21, "<div class=\"col px-2 py-1 align-self-end arrow\">➝</div>\r\n\r\n        \r\n        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "col pl-0");
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "form-control d-flex");
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.AddMarkupContent(28, "<div><i>✈</i>&nbsp;&nbsp;To:</div>\r\n                ");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "list", "airports");
            __builder.AddAttribute(31, "placeholder", "...");
            __builder.AddAttribute(32, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "E:\Sample Projects\ASP.NET project\aspnet samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\Search.razor"
                                                                criteria.ToAirport

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => criteria.ToAirport = __value, criteria.ToAirport));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n    \r\n    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "row py-1");
            __builder.AddMarkupContent(40, "\r\n        \r\n        ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "col pr-0");
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "form-control d-flex");
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.AddMarkupContent(47, "<div><i>🗓</i>&nbsp;&nbsp;Depart:</div>\r\n                ");
            __builder.OpenElement(48, "input");
            __builder.AddAttribute(49, "type", "date");
            __builder.AddAttribute(50, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "E:\Sample Projects\ASP.NET project\aspnet samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\Search.razor"
                                          criteria.OutboundDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(51, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => criteria.OutboundDate = __value, criteria.OutboundDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.AddMarkupContent(55, "<div class=\"col px-2 py-1 align-self-end arrow\">➝</div>\r\n\r\n        \r\n        ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "col pl-0");
            __builder.AddMarkupContent(58, "\r\n            ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "form-control d-flex");
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.AddMarkupContent(62, "<div><i>🗓</i>&nbsp;&nbsp;Return:</div>\r\n                ");
            __builder.OpenElement(63, "input");
            __builder.AddAttribute(64, "type", "date");
            __builder.AddAttribute(65, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "E:\Sample Projects\ASP.NET project\aspnet samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\Search.razor"
                                          criteria.ReturnDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(66, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => criteria.ReturnDate = __value, criteria.ReturnDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n\r\n    \r\n    ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "row py-1 d-flex px-3");
            __builder.AddMarkupContent(73, "\r\n        ");
            __builder.OpenElement(74, "div");
            __builder.AddMarkupContent(75, "\r\n            ");
            __builder.OpenElement(76, "select");
            __builder.AddAttribute(77, "class", "custom-select");
            __builder.AddAttribute(78, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "E:\Sample Projects\ASP.NET project\aspnet samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\Search.razor"
                                                 criteria.TicketClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(79, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => criteria.TicketClass = __value, criteria.TicketClass));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(80, "\r\n                ");
            __builder.OpenElement(81, "option");
            __builder.AddAttribute(82, "value", 
#nullable restore
#line 46 "E:\Sample Projects\ASP.NET project\aspnet samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\Search.razor"
                               TicketClass.Economy

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(83, "Economy");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                ");
            __builder.OpenElement(85, "option");
            __builder.AddAttribute(86, "value", 
#nullable restore
#line 47 "E:\Sample Projects\ASP.NET project\aspnet samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\Search.razor"
                               TicketClass.PremiumEconomy

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(87, "Premium Economy");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                ");
            __builder.OpenElement(89, "option");
            __builder.AddAttribute(90, "value", 
#nullable restore
#line 48 "E:\Sample Projects\ASP.NET project\aspnet samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\Search.razor"
                               TicketClass.Business

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(91, "Business");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                ");
            __builder.OpenElement(93, "option");
            __builder.AddAttribute(94, "value", 
#nullable restore
#line 49 "E:\Sample Projects\ASP.NET project\aspnet samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\Search.razor"
                               TicketClass.First

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(95, "First");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n        ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "ml-auto");
            __builder.AddMarkupContent(101, "\r\n            ");
            __builder.OpenElement(102, "button");
            __builder.AddAttribute(103, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "E:\Sample Projects\ASP.NET project\aspnet samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\Search.razor"
                              () => OnSearch.InvokeAsync(criteria)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(104, "type", "button");
            __builder.AddAttribute(105, "class", "btn btn-danger px-5");
            __builder.AddMarkupContent(106, "\r\n                Search ➝\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n");
            __builder.OpenComponent<global::FlightFinder.Client.Components.AirportsList>(111);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "E:\Sample Projects\ASP.NET project\aspnet samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\Search.razor"
 
    [Parameter]
    public EventCallback<SearchCriteria> OnSearch { get; set; }

    private SearchCriteria criteria = new SearchCriteria("LHR", "SEA");

#line default
#line hidden
#nullable disable

    }
}
#pragma warning restore 1591
