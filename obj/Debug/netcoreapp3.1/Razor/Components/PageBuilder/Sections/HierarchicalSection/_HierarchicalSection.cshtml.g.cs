#pragma checksum "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Sections\HierarchicalSection\_HierarchicalSection.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8effaf8a2fe46079c8dd2b179ed0f7cad8ac9647"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Components_PageBuilder_Sections_HierarchicalSection__HierarchicalSection), @"mvc.1.0.view", @"/Components/PageBuilder/Sections/HierarchicalSection/_HierarchicalSection.cshtml")]
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
#line 4 "C:\inetpub\wwwroot\dcboe\dcboe\Components\_ViewImports.cshtml"
using Kentico.Components.Web.Mvc.Dialogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Sections\HierarchicalSection\_HierarchicalSection.cshtml"
using Kentico.PageBuilder.Web.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8effaf8a2fe46079c8dd2b179ed0f7cad8ac9647", @"/Components/PageBuilder/Sections/HierarchicalSection/_HierarchicalSection.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52497c0ca1c24ed45b2843b03dca00a1ff33ca16", @"/Components/_ViewImports.cshtml")]
    public class Components_PageBuilder_Sections_HierarchicalSection__HierarchicalSection : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ComponentViewModel<HierarchicalSectionProperties>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Kentico.Content.Web.Mvc.WidgetZoneTagHelper __Kentico_Content_Web_Mvc_WidgetZoneTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"intro-small\" role=\"region\" style=\"background-image: url(../../images/BlueBG.png);\" title=\"Candidates\">\r\n    <div class=\"container\">\r\n        <div class=\"intro__innerBlue\">\r\n            <h1>");
#nullable restore
#line 10 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Sections\HierarchicalSection\_HierarchicalSection.cshtml"
           Write(Model.Properties.Heading);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        </div>\r\n    </div>\r\n</div>\r\n<p></p>\r\n<p></p>\r\n<section class=\"section\" role=\"region\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-3\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("widget-zone", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8effaf8a2fe46079c8dd2b179ed0f7cad8ac96474359", async() => {
            }
            );
            __Kentico_Content_Web_Mvc_WidgetZoneTagHelper = CreateTagHelper<global::Kentico.Content.Web.Mvc.WidgetZoneTagHelper>();
            __tagHelperExecutionContext.Add(__Kentico_Content_Web_Mvc_WidgetZoneTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-9\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("widget-zone", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8effaf8a2fe46079c8dd2b179ed0f7cad8ac96475329", async() => {
            }
            );
            __Kentico_Content_Web_Mvc_WidgetZoneTagHelper = CreateTagHelper<global::Kentico.Content.Web.Mvc.WidgetZoneTagHelper>();
            __tagHelperExecutionContext.Add(__Kentico_Content_Web_Mvc_WidgetZoneTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ComponentViewModel<HierarchicalSectionProperties>> Html { get; private set; }
    }
}
#pragma warning restore 1591
