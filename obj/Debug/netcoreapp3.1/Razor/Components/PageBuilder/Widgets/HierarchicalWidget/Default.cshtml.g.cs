#pragma checksum "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\HierarchicalWidget\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16ce5ac35968bb5d15cde1188c9484590e0b244c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Components_PageBuilder_Widgets_HierarchicalWidget_Default), @"mvc.1.0.view", @"/Components/PageBuilder/Widgets/HierarchicalWidget/Default.cshtml")]
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
#line 2 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\HierarchicalWidget\Default.cshtml"
using dcboe.Components.Widgets.HierarchicalWidget;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\HierarchicalWidget\Default.cshtml"
using Microsoft.AspNetCore.Http.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16ce5ac35968bb5d15cde1188c9484590e0b244c", @"/Components/PageBuilder/Widgets/HierarchicalWidget/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52497c0ca1c24ed45b2843b03dca00a1ff33ca16", @"/Components/_ViewImports.cshtml")]
    public class Components_PageBuilder_Widgets_HierarchicalWidget_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HierarchicalWidgetViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("                                <div class=\"container py-3\">\r\n                                    <div class=\"row\">\r\n                                        <div class=\"col-lg-12\">\r\n                                            <div");
            BeginWriteAttribute("class", " class=\"", 423, "\"", 431, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n");
#nullable restore
#line 12 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\HierarchicalWidget\Default.cshtml"
                                                   int i = 0; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <div class=""sidebar hidden-xs"">
                                                    <nav class=""nav-secondary"" role=""navigation"">
                                                        <ul role=""menubar"" aria-hidden=""false"">
");
#nullable restore
#line 16 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\HierarchicalWidget\Default.cshtml"
                                                             foreach (HierarchicalWidgetViewModel item in Model)
                                                            {
                                                                var className = "";

                                                                if (item.MenuItemRelativeUrl ==Context.Request.GetEncodedUrl())
                                                                {
                                                                    className = "current";
                                                                }


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <li role=\"menuitem\"");
            BeginWriteAttribute("class", " class=", 1475, "", 1492, 1);
#nullable restore
#line 25 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\HierarchicalWidget\Default.cshtml"
WriteAttributeValue("", 1482, className, 1482, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                            <a role=\"link\"");
            BeginWriteAttribute("href", " href=", 1569, "", 1575, 0);
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 26 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\HierarchicalWidget\Default.cshtml"
                                                                            Write(item.MenuItemRelativeUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral(" >");
#nullable restore
#line 26 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\HierarchicalWidget\Default.cshtml"
                                                                                                       Write(item.MenuName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                        </li>\r\n");
#nullable restore
#line 28 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\HierarchicalWidget\Default.cshtml"
                                                        i++;

                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                        </ul>
                                                    </nav>
                                                </div>

                                            </div>
                                        </div>
                                    </div>
                                </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HierarchicalWidgetViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
