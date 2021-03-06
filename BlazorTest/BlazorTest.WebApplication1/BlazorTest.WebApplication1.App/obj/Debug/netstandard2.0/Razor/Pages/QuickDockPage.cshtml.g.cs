#pragma checksum "C:\Users\TomCC\source\repos\BlazorTest\BlazorTest.WebApplication1\BlazorTest.WebApplication1.App\Pages\QuickDockPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5f19f62a82ada626d633a76f7eb33d8dd33ed94"
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

    [Microsoft.AspNetCore.Components.RouteAttribute("/quickdock")]
    public class QuickDockPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<style>\r\n        .qd_header {\r\n            overflow: visible;\r\n            position: relative;\r\n            z-index: 1;\r\n            height: 20px;\r\n        }\r\n\r\n        .qd_header ul {\r\n            margin: 0;\r\n            padding: 0;\r\n            list-style-type: none;\r\n        }\r\n\r\n        .qd_header .qd_tabs {\r\n            position: absolute;\r\n        }\r\n\r\n        .qd_header .qd_tab {\r\n            position: absolute;\r\n        }\r\n\r\n        .qd_header [class^=qd_] {\r\n            box-sizing: content-box !important;\r\n        }\r\n\r\n        .qd_header .qd_tab {\r\n            font-family: Arial,sans-serif;\r\n            font-size: 12px;\r\n            color: #888888;\r\n            background: #fafafa;\r\n            margin-right: 2px;\r\n            padding-bottom: 0px;\r\n            padding-top: 2px;\r\n            border: 1px solid #cccccc;\r\n            border-bottom: none;\r\n        }\r\n\r\n        .qd_header .qd_tabs .qd_tab {\r\n            cursor: pointer;\r\n            float: left;\r\n            height: 12px;\r\n            margin-top: 1px;\r\n            padding: 2px 10px 4px;\r\n            padding-right: 25px;\r\n            position: relative;\r\n        }\r\n\r\n    .qd_drag_container .qd_tab_container .qd_header .qd_tabs .qd_tab {\r\n        cursor: move;\r\n    }\r\n\r\n    .qd_header .qd_tab .qd_title {\r\n        display: inline-block;\r\n        overflow: hidden;\r\n        text-overflow: ellipsis;\r\n    }\r\n\r\n    .qd_header .qd_tab .qd_close_tab {\r\n        width: 11px;\r\n        height: 11px;\r\n        background-image: url(data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAcAAAAHCAYAAADEUlfTAAAAIklEQVR4nGNgYGD4z4Ad/Mdg4ODDBXCZRFgCp5EEHQMXBwAQAgz0SVCcggAAAABJRU5ErkJggg==);\r\n        background-position: center center;\r\n        background-repeat: no-repeat;\r\n        right: 6px;\r\n        top: 4px;\r\n        opacity: 1;\r\n        position: absolute;\r\n        text-align: center;\r\n    }\r\n\r\n    .qd_header .qd_tab i.qd_left {\r\n        top: 0;\r\n        left: -2px;\r\n    }\r\n\r\n    .qd_header .qd_tab i.qd_right {\r\n        top: 0;\r\n        right: -2px;\r\n    }\r\n\r\n    .qd_tab.qd_active {\r\n        background: #e1e1e1;\r\n        color: #777777;\r\n    }\r\n\r\n    .qd_header .qd_tab.qd_active {\r\n        border-bottom: none;\r\n        box-shadow: 2px -2px 2px -2px rgba(0,0,0,0.2);\r\n        padding-bottom: 5px;\r\n    }\r\n\r\n    .qd_header .qd_controls {\r\n        position: absolute;\r\n        right: 3px;\r\n    }\r\n\r\n    .qd_header .qd_controls > li {\r\n        cursor: pointer;\r\n        float: left;\r\n        width: 18px;\r\n        height: 18px;\r\n        text-align: center;\r\n    }\r\n\r\n    .qd_controls > li {\r\n        position: relative;\r\n        background-position: center center;\r\n        background-repeat: no-repeat;\r\n        opacity: .4;\r\n        transition: opacity 300ms ease;\r\n    }\r\n\r\n    .qd_header .qd_controls {\r\n        position: absolute;\r\n        right: 3px;\r\n    }\r\n\r\n    .qd_controls .qd_popout {\r\n        background-image: url(data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAkAAAAJCAYAAADgkQYQAAAANUlEQVR4nI2QMQoAMAwCz5L/f9mOzZIaN0E9UDyZhaaQz6atgBHgambEJ5wBKoS0WaIvfT+6K2MIECN19MAAAAAASUVORK5CYII=);\r\n    }\r\n\r\n    .qd_controls .qd_maximise {\r\n        background-image: url(data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAkAAAAJCAYAAADgkQYQAAAAIklEQVR4nGNkYGD4z0AAMBFSAAOETPpPlEmDUREjAxHhBABPvAQLFv3qngAAAABJRU5ErkJggg==);\r\n    }\r\n\r\n    .qd_controls .qd_close {\r\n        background-image: url(data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAkAAAAJCAYAAADgkQYQAAAAKUlEQVR4nGNgYGD4z4Af/Mdg4FKASwCnDf8JKSBoAtEmEXQTQd8RDCcA6+4Q8OvIgasAAAAASUVORK5CYII=);\r\n    }\r\n\r\n   .qd_content_container {\r\n        display: flex;\r\n        padding:3px;\r\n        width: 100%;\r\n    }\r\n\r\n    .qd_content {\r\n        background: #fafafa;\r\n        border: 1px solid #cccccc;\r\n        width: 100%;\r\n    }\r\n\r\n    .qd_item.qd_active {\r\n        display: flex;\r\n        width: 100%;\r\n    }\r\n\r\n    .qd_item.qd_inactive {\r\n        display: none;\r\n    }\r\n\r\n    .qd_proxy_dock {\r\n        display: grid;\r\n        grid-template-rows: auto auto auto auto;\r\n        grid-template-columns: auto auto auto auto;\r\n        grid-gap: 0;\r\n    }\r\n\r\n    .qd_proxy.qd_top {\r\n        grid-row: 1 / 2;\r\n        grid-column: 1 / 5;\r\n    }\r\n\r\n    .qd_proxy.qd_bottom {\r\n        grid-row: 4 / 5;\r\n        grid-column: 1 / 5;\r\n    }\r\n\r\n    .qd_proxy.qd_left {\r\n        grid-row: 1 / 5;\r\n        grid-column: 1 / 2;\r\n    }\r\n\r\n    .qd_proxy.qd_right {\r\n        grid-row: 1 / 5;\r\n        grid-column: 4 / 5;\r\n    }\r\n\r\n    .qd_proxy.qd_center {\r\n        grid-row: 2 / 4;\r\n        grid-column: 2 / 4;\r\n    }\r\n\r\n    .debug_border {\r\n        border: dashed black 1px;\r\n        background: transparent;\r\n    }\r\n\r\n    .qd_body {\r\n        display: flex;\r\n        /*width: 100%;*/\r\n        height: 500px;\r\n        /*position: relative;*/\r\n        background: #e1e1e1;\r\n        color: #777777;\r\n        border: 1px solid #cccccc;\r\n    }\r\n\r\n    .qd_item,\r\n    .qd_proxy_dock {\r\n        width: 100%;\r\n\r\n    }\r\n\r\n    .qd_proxy_dock {\r\n        z-index: 10;\r\n    }\r\n\r\n    .qd_proxy {\r\n        border: transparent;\r\n    }\r\n\r\n    .qd_proxy:hover {\r\n        border: dashed black 1px;\r\n    }\r\n\r\n    .qd_drag_container {\r\n        position: absolute;\r\n        z-index: 9;\r\n    }\r\n\r\n    .qd_main_container.qd_dragging {\r\n        cursor: move;\r\n    }\r\n\r\n    .qd_vertical_splitter {\r\n        margin-top: 4px;\r\n        margin-bottom: 4px;\r\n        cursor: ew-resize;\r\n        background: repeating-linear-gradient(0deg, #cccccc, #cccccc 2px, #e1e1e1 2px, #e1e1e1 4px);\r\n    }\r\n    \r\n    .qd_vertical_splitter:hover {\r\n        /*background:#e1e1e1;*/\r\n        background: #d1d1d1;\r\n    }\r\n\r\n    .qd_horizontal_splitter {\r\n        padding-top: 2px;\r\n        margin-left: 4px;\r\n        margin-right: 4px;\r\n        background: repeating-linear-gradient(45deg, #cccccc, #cccccc 2px, #e1e1e1 2px, #e1e1e1 4px);\r\n        cursor: ns-resize;\r\n    }\r\n\r\n    .qd_horizontal_splitter:hover{\r\n        /*background:#e1e1e1;*/\r\n        background: #d1d1d1\r\n    }\r\n\r\n    .qd_controls .qd_popout {\r\n        background-image: url(data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAkAAAAJCAYAAADgkQYQAAAANUlEQVR4nI2QMQoAMAwCz5L/f9mOzZIaN0E9UDyZhaaQz6atgBHgambEJ5wBKoS0WaIvfT+6K2MIECN19MAAAAAASUVORK5CYII=);\r\n    }\r\n            \r\n    .qd_controls .qd_maximise {\r\n        background-image: url(data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAkAAAAJCAYAAADgkQYQAAAAIklEQVR4nGNkYGD4z0AAMBFSAAOETPpPlEmDUREjAxHhBABPvAQLFv3qngAAAABJRU5ErkJggg==);\r\n    }\r\n\r\n    .qd_controls .qd_close {\r\n        background-image: url(data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAkAAAAJCAYAAADgkQYQAAAAKUlEQVR4nGNgYGD4z4Af/Mdg4FKASwCnDf8JKSBoAtEmEXQTQd8RDCcA6+4Q8OvIgasAAAAASUVORK5CYII=);\r\n    }\r\n\r\n    .qd_column_container{\r\n        width: 100%;\r\n    }\r\n\r\n    .qd_row_container{\r\n        width: 100%;\r\n    }\r\n</style>\r\n");
            builder.AddMarkupContent(1, "<h1>Quick Dock</h1>\r\n");
            builder.OpenComponent<BlazorTest.WebApplication1.App.Pages.QuickDock>(2);
            builder.AddAttribute(3, "Config", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<BlazorTest.WebApplication1.App.QuickDockConfig>(Config));
            builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 274 "C:\Users\TomCC\source\repos\BlazorTest\BlazorTest.WebApplication1\BlazorTest.WebApplication1.App\Pages\QuickDockPage.cshtml"
           
    protected override void OnInit()
    {
        Config = new QuickDockConfig
        {
            Contents = new List<QuickDockContent>
            {
                new QuickDockContent
                {
                    Type = ContentType.Stack,
                    Children = new List<QuickDockContent>
                    {
                        new QuickDockContent
                        {
                            Type = ContentType.Component,
                            Title = "Hello",
                            HtmlBody = "<h1>world</h1>",
                            Active = true
                        },
                        new QuickDockContent
                        {
                            Type = ContentType.Component,
                            Title = "Content",
                            HtmlBody = "",
                            Active = false
                        },
                        new QuickDockContent
                        {
                            Type = ContentType.Row,
                            Title = "Rows",
                            Children = new List<QuickDockContent>
                            {
                                new QuickDockContent
                                {
                                    Type = ContentType.Component,
                                    Title = "",
                                    HtmlBody = "stuff",
                                    Active = true
                                },
                                new QuickDockContent
                                {
                                    Type = ContentType.Component,
                                    Title = "",
                                    HtmlBody = "stuff2",
                                    Active = false
                                }
                            }
                        },
                        new QuickDockContent
                        {
                            Type = ContentType.Column,
                            Title = "Column",
                            Children = new List<QuickDockContent>
                            {
                                new QuickDockContent
                                {
                                    Type = ContentType.Component,
                                    Title = "",
                                    HtmlBody = "stuff",
                                    Active = true
                                },
                                new QuickDockContent
                                {
                                    Type = ContentType.Component,
                                    Title = "",
                                    HtmlBody = "stuff2",
                                    Active = false
                                }
                            }
                        }
                    }
                }
            }
        };
    }

    QuickDockConfig Config { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
