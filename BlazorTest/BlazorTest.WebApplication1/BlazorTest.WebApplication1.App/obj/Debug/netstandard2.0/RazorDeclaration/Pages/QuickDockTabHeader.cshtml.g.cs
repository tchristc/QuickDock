#pragma checksum "C:\Users\TomCC\source\repos\BlazorTest\BlazorTest.WebApplication1\BlazorTest.WebApplication1.App\Pages\QuickDockTabHeader.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a428e459f1cc654efb626b7aa7222c4de43ccd52"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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

    public class QuickDockTabHeader : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 5 "C:\Users\TomCC\source\repos\BlazorTest\BlazorTest.WebApplication1\BlazorTest.WebApplication1.App\Pages\QuickDockTabHeader.cshtml"
            
    [CascadingParameter] protected QuickDockConfig Config { get; set; }
    [Parameter] protected QuickDockContent Content { get; set; }
    [Parameter] protected Action<QuickDockContent> OnTabClick { get; set; }

    public void OnClick(UIMouseEventArgs e)
    {
        OnTabClick(Content);
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
