using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorTest.WebApplication1.App
{
    public class Rect
    {
        public int x { get; set; }
        public int y { get; set; }
    }
    public static class ElementRefExtensions
    {
        public static Task<Rect> GetPos(this ElementRef elementRef)
        {
            // Implemented in JsInterop.js stored in index.html
            return JSRuntime.Current.InvokeAsync<Rect>("Js.GetPos", elementRef);
        }
    }
}
