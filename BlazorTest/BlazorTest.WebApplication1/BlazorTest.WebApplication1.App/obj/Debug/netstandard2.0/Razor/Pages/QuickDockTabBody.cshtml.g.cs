#pragma checksum "C:\Users\TomCC\source\repos\BlazorTest\BlazorTest.WebApplication1\BlazorTest.WebApplication1.App\Pages\QuickDockTabBody.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cee3a9bb4db37330b7edb08cefe3ae55de3a6ddf"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTest.WebApplication1.App.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using BlazorTest.WebApplication1.App;
    using BlazorTest.WebApplication1.App.Shared;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]

    public class QuickDockTabBody : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "qd_item" + " " + (Content.Active?"qd_active":"qd_inactive"));
            builder.AddAttribute(2, "data-qd-column", "1");
            builder.AddContent(3, "\r\n    ");
            builder.OpenComponent<BlazorTest.WebApplication1.App.Pages.QuickDockContainer>(4);
            builder.AddAttribute(5, "Content", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<BlazorTest.WebApplication1.App.QuickDockContent>(Content));
            builder.CloseComponent();
            builder.AddContent(6, "\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 5 "C:\Users\TomCC\source\repos\BlazorTest\BlazorTest.WebApplication1\BlazorTest.WebApplication1.App\Pages\QuickDockTabBody.cshtml"
            
    [CascadingParameter] protected QuickDockConfig Config { get; set; }
    [Parameter] protected QuickDockContent Content { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
