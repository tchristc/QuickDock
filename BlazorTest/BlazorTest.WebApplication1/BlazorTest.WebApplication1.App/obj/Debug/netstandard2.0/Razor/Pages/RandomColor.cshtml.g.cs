#pragma checksum "C:\Users\TomCC\source\repos\BlazorTest\BlazorTest.WebApplication1\BlazorTest.WebApplication1.App\Pages\RandomColor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3eb1520d02a1b9687624dcfb70bcd8d717071ec"
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

    [Microsoft.AspNetCore.Components.RouteAttribute("/randomcolor")]
    public class RandomColor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<style>\r\n    .input_canvas {\r\n        position: absolute;\r\n        top: 0;\r\n        left: 0;\r\n        height: 100%;\r\n        width: 100%\r\n    }\r\n\r\n    .cb{\r\n        height: 50px;\r\n        width: 50px;\r\n    }\r\n</style>\r\n");
            builder.OpenElement(1, "div");
            builder.AddAttribute(2, "class", "input_canvas");
            builder.AddAttribute(3, "onmousemove", Microsoft.AspNetCore.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Components.UIMouseEventArgs>(e=> MouseMove(e)));
            builder.CloseElement();
            builder.AddContent(4, "\r\n");
            builder.AddMarkupContent(5, "<h1>Quick Dock</h1>\r\n\r\n");
#line 19 "C:\Users\TomCC\source\repos\BlazorTest\BlazorTest.WebApplication1\BlazorTest.WebApplication1.App\Pages\RandomColor.cshtml"
 for(int i=0; i<5; i++)
{

#line default
#line hidden
            builder.AddContent(6, "    ");
            builder.OpenElement(7, "div");
            builder.AddAttribute(8, "class", "cb");
            builder.AddAttribute(9, "style", "background-color:" + (GetRandomColor()));
            builder.CloseElement();
            builder.AddContent(10, "\r\n");
#line 22 "C:\Users\TomCC\source\repos\BlazorTest\BlazorTest.WebApplication1\BlazorTest.WebApplication1.App\Pages\RandomColor.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 24 "C:\Users\TomCC\source\repos\BlazorTest\BlazorTest.WebApplication1\BlazorTest.WebApplication1.App\Pages\RandomColor.cshtml"
            
    static Random Rand = new Random();

    long x = 0;
    long y = 0;

    void MouseMove(UIMouseEventArgs e)
    {
        x = e.ClientX;
        y = e.ClientY;
    }


    string GetRandomColor()
    {
        var randomColor = $"#{Rand.Next(256):X}{Rand.Next(256):X}{Rand.Next(256):X}";
        return randomColor;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
