#pragma checksum "C:\Users\prdora\source\repos\Clean-Architecture\StudenManagementDemo\Src\Presentation\SexyUI\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9be9ff55b19bcb6f3f9ae02419b4ddaed6e476df"
// <auto-generated/>
#pragma warning disable 1591
namespace SexyUI.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\prdora\source\repos\Clean-Architecture\StudenManagementDemo\Src\Presentation\SexyUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\prdora\source\repos\Clean-Architecture\StudenManagementDemo\Src\Presentation\SexyUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\prdora\source\repos\Clean-Architecture\StudenManagementDemo\Src\Presentation\SexyUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\prdora\source\repos\Clean-Architecture\StudenManagementDemo\Src\Presentation\SexyUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\prdora\source\repos\Clean-Architecture\StudenManagementDemo\Src\Presentation\SexyUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\prdora\source\repos\Clean-Architecture\StudenManagementDemo\Src\Presentation\SexyUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\prdora\source\repos\Clean-Architecture\StudenManagementDemo\Src\Presentation\SexyUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\prdora\source\repos\Clean-Architecture\StudenManagementDemo\Src\Presentation\SexyUI\_Imports.razor"
using SexyUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\prdora\source\repos\Clean-Architecture\StudenManagementDemo\Src\Presentation\SexyUI\_Imports.razor"
using SexyUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\prdora\source\repos\Clean-Architecture\StudenManagementDemo\Src\Presentation\SexyUI\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\prdora\source\repos\Clean-Architecture\StudenManagementDemo\Src\Presentation\SexyUI\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 1 "C:\Users\prdora\source\repos\Clean-Architecture\StudenManagementDemo\Src\Presentation\SexyUI\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
