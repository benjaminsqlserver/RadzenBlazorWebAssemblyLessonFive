#pragma checksum "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\Unauthorized.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b87362dc382f4771faf5f979f2bcd13b15903ee"
// <auto-generated/>
#pragma warning disable 1591
namespace CaApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\_Imports.razor"
using CaApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\_Imports.razor"
using CaApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\Unauthorized.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\Unauthorized.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\Unauthorized.razor"
using CaApp.Models.ConData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\Unauthorized.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\Unauthorized.razor"
using CaApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\Unauthorized.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/unauthorized")]
    public partial class Unauthorized : CaApp.Pages.UnauthorizedComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(3);
                __builder2.AddAttribute(4, "Size", "H1");
                __builder2.AddAttribute(5, "Text", "Unauthorized");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtml>(11);
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(13, "\n          The current user is not authorized to see this page.\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
