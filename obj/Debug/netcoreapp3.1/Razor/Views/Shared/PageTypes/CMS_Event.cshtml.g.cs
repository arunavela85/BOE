#pragma checksum "C:\inetpub\wwwroot\dcboe\dcboe\Views\Shared\PageTypes\CMS_Event.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbcbcdc3c7009834a333d5190f39f6d652e7c1fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_PageTypes_CMS_Event), @"mvc.1.0.view", @"/Views/Shared/PageTypes/CMS_Event.cshtml")]
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
#line 1 "C:\inetpub\wwwroot\dcboe\dcboe\Views\Shared\PageTypes\CMS_Event.cshtml"
using dcboe.Models.PageBuilder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\inetpub\wwwroot\dcboe\dcboe\Views\Shared\PageTypes\CMS_Event.cshtml"
using Kentico.PageBuilder.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\inetpub\wwwroot\dcboe\dcboe\Views\Shared\PageTypes\CMS_Event.cshtml"
using Kentico.Web.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbcbcdc3c7009834a333d5190f39f6d652e7c1fc", @"/Views/Shared/PageTypes/CMS_Event.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78979bc92fdb481272598c22d79cadd8b7ad709f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PageTypes_CMS_Event : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\inetpub\wwwroot\dcboe\dcboe\Views\Shared\PageTypes\CMS_Event.cshtml"
Write(Html.Kentico().PageBuilderStyles());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div>\r\n    ");
#nullable restore
#line 9 "C:\inetpub\wwwroot\dcboe\dcboe\Views\Shared\PageTypes\CMS_Event.cshtml"
Write(await Html.Kentico().EditableAreaAsync("area1"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 11 "C:\inetpub\wwwroot\dcboe\dcboe\Views\Shared\PageTypes\CMS_Event.cshtml"
Write(Html.Kentico().PageBuilderScripts());

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
