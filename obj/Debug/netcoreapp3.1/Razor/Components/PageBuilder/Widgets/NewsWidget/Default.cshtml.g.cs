#pragma checksum "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\NewsWidget\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b73a5082c09a027a1d1b5f6bb182b4a1dddb05b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Components_PageBuilder_Widgets_NewsWidget_Default), @"mvc.1.0.view", @"/Components/PageBuilder/Widgets/NewsWidget/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\inetpub\wwwroot\dcboe\dcboe\Components\_ViewImports.cshtml"
using Kentico.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\inetpub\wwwroot\dcboe\dcboe\Components\_ViewImports.cshtml"
using Kentico.PageBuilder.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\inetpub\wwwroot\dcboe\dcboe\Components\_ViewImports.cshtml"
using Kentico.Components.Web.Mvc.Dialogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\NewsWidget\Default.cshtml"
using dcboe.Components.Widgets.NewsWidget;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b73a5082c09a027a1d1b5f6bb182b4a1dddb05b0", @"/Components/PageBuilder/Widgets/NewsWidget/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52497c0ca1c24ed45b2843b03dca00a1ff33ca16", @"/Components/_ViewImports.cshtml")]
    public class Components_PageBuilder_Widgets_NewsWidget_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NewsWidgetViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <div class=\"article\">\r\n");
#nullable restore
#line 11 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\NewsWidget\Default.cshtml"
                   int i = 0; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\NewsWidget\Default.cshtml"
                 foreach (NewsWidgetViewModel item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"newsItem\" id=\"readspeaker-content\">\r\n                        <span class=\"ISI_MESSAGE\"></span>\r\n                        <h6>");
#nullable restore
#line 17 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\NewsWidget\Default.cshtml"
                       Write(item.NewsReleaseDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <a role=\"link\"");
            BeginWriteAttribute("href", " href=", 588, "", 610, 1);
#nullable restore
#line 18 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\NewsWidget\Default.cshtml"
WriteAttributeValue("", 594, item.NewsTeaser, 594, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">");
#nullable restore
#line 18 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\NewsWidget\Default.cshtml"
                                                                        Write(item.NewsTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n\r\n                        <hr>\r\n                    </div>\r\n");
#nullable restore
#line 22 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\NewsWidget\Default.cshtml"

                    i++;

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"pagination\">\r\n");
#nullable restore
#line 27 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\NewsWidget\Default.cshtml"
                 foreach (NewsWidgetViewModel item in Model)
                {
                   

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\NewsWidget\Default.cshtml"
                    foreach (int pageNumber in item.pagination)
                   { 
                   if (pageNumber == item.currentPage)
                   {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"page-numbers current\"");
            BeginWriteAttribute("href", "  href=\"", 1102, "\"", 1127, 2);
            WriteAttributeValue("", 1110, "?page=", 1110, 6, true);
#nullable restore
#line 33 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\NewsWidget\Default.cshtml"
WriteAttributeValue("", 1116, pageNumber, 1116, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 33 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\NewsWidget\Default.cshtml"
                                                                                 Write(pageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 34 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\NewsWidget\Default.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"page-numbers\"");
            BeginWriteAttribute("href", "  href=\"", 1281, "\"", 1306, 2);
            WriteAttributeValue("", 1289, "?page=", 1289, 6, true);
#nullable restore
#line 37 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\NewsWidget\Default.cshtml"
WriteAttributeValue("", 1295, pageNumber, 1295, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 37 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\NewsWidget\Default.cshtml"
                                                                         Write(pageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 38 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\NewsWidget\Default.cshtml"

                        }

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\NewsWidget\Default.cshtml"
                     
                    break;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("             \r\n            </div>\r\n            </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NewsWidgetViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591