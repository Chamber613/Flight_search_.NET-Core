// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
