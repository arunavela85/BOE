#pragma checksum "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Sections\_DefaultSection.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21a424e556110ad2e6e92bc2f8480990a212d9c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Components_PageBuilder_Sections__DefaultSection), @"mvc.1.0.view", @"/Components/PageBuilder/Sections/_DefaultSection.cshtml")]
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
#line 4 "C:\inetpub\wwwroot\dcboe\dcboe\Components\_ViewImports.cshtml"
using Kentico.Components.Web.Mvc.Dialogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Sections\_DefaultSection.cshtml"
using Kentico.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Sections\_DefaultSection.cshtml"
using Kentico.PageBuilder.Web.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21a424e556110ad2e6e92bc2f8480990a212d9c8", @"/Components/PageBuilder/Sections/_DefaultSection.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52497c0ca1c24ed45b2843b03dca00a1ff33ca16", @"/Components/_ViewImports.cshtml")]
    public class Components_PageBuilder_Sections__DefaultSection : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n<div>\r\n    ");
#nullable restore
#line 5 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Sections\_DefaultSection.cshtml"
Write(await Html.Kentico().WidgetZoneAsync());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
