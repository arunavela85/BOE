#pragma checksum "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\SelectorsWidget\_SelectorsWidget.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d82ed07059c716e917ec8389593acc4f2a93bce8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Components_PageBuilder_Widgets_SelectorsWidget__SelectorsWidget), @"mvc.1.0.view", @"/Components/PageBuilder/Widgets/SelectorsWidget/_SelectorsWidget.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d82ed07059c716e917ec8389593acc4f2a93bce8", @"/Components/PageBuilder/Widgets/SelectorsWidget/_SelectorsWidget.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52497c0ca1c24ed45b2843b03dca00a1ff33ca16", @"/Components/_ViewImports.cshtml")]
    public class Components_PageBuilder_Widgets_SelectorsWidget__SelectorsWidget : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dcboe.Components.PageBuilder.Widgets.SelectorsWidget.HeadingWidgetViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3>This is a dummy widget demonstrating the functionality of selector form components</h3>\r\n<p>Use the widget properties dialog to select media files or pages from the connected Xperience database.</p>\r\n\r\nSelected image:\r\n\r\n<br />\r\n\r\n");
#nullable restore
#line 11 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\SelectorsWidget\_SelectorsWidget.cshtml"
 if (Model.MediaFileUrl == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span style=\"border: 1px solid\"><em>image placeholder</em></span>\r\n");
#nullable restore
#line 14 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\SelectorsWidget\_SelectorsWidget.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <img");
            BeginWriteAttribute("src", " src=\"", 483, "\"", 508, 1);
#nullable restore
#line 17 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\SelectorsWidget\_SelectorsWidget.cshtml"
WriteAttributeValue("", 489, Model.MediaFileUrl, 489, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 18 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\SelectorsWidget\_SelectorsWidget.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>\r\n    Pages:\r\n    <ul>\r\n        <li>Selected document: ");
#nullable restore
#line 23 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\SelectorsWidget\_SelectorsWidget.cshtml"
                          Write(Model.DocumentGuid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Selected path: ");
#nullable restore
#line 24 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\SelectorsWidget\_SelectorsWidget.cshtml"
                      Write(Model.DocumentPath);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    </ul>\r\n</p>\r\n\r\nSelected attachment:\r\n");
#nullable restore
#line 30 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\SelectorsWidget\_SelectorsWidget.cshtml"
 if (Model.AttachmentUrl == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span style=\"border: 1px solid\"><em>placeholder</em></span>\r\n");
#nullable restore
#line 33 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\SelectorsWidget\_SelectorsWidget.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a");
            BeginWriteAttribute("href", " href=\"", 875, "\"", 903, 2);
#nullable restore
#line 36 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\SelectorsWidget\_SelectorsWidget.cshtml"
WriteAttributeValue("", 882, Model.AttachmentUrl, 882, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 902, ")", 902, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Click to download attachment</a>\r\n");
#nullable restore
#line 37 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\SelectorsWidget\_SelectorsWidget.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dcboe.Components.PageBuilder.Widgets.SelectorsWidget.HeadingWidgetViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591