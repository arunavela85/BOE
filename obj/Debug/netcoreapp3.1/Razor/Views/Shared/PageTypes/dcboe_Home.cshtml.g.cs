#pragma checksum "C:\inetpub\wwwroot\dcboe\dcboe\Views\Shared\PageTypes\dcboe_Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "978a85599fa383800232ad8319bf3f6e253ad6b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_PageTypes_dcboe_Home), @"mvc.1.0.view", @"/Views/Shared/PageTypes/dcboe_Home.cshtml")]
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
#line 1 "C:\inetpub\wwwroot\dcboe\dcboe\Views\_ViewImports.cshtml"
using Kentico.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\inetpub\wwwroot\dcboe\dcboe\Views\_ViewImports.cshtml"
using Kentico.PageBuilder.Web.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"978a85599fa383800232ad8319bf3f6e253ad6b4", @"/Views/Shared/PageTypes/dcboe_Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78979bc92fdb481272598c22d79cadd8b7ad709f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PageTypes_dcboe_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"intro\" title=\"Intro\" role=\"region\">\r\n    <div class=\"intro__container\">\r\n        ");
#nullable restore
#line 3 "C:\inetpub\wwwroot\dcboe\dcboe\Views\Shared\PageTypes\dcboe_Home.cshtml"
   Write(await Html.Kentico().EditableAreaAsync("area1"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<script>\r\n            $(document).ready(function () {\r\n                $(\'.carousel\').carousel({\r\n                    interval: 2000\r\n                });\r\n            });\r\n</script>\r\n");
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
