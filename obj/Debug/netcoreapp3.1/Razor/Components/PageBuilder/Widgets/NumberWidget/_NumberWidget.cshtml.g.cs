#pragma checksum "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\NumberWidget\_NumberWidget.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a51fd41681e86d1218fda4c84e46916c0f04b62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Components_PageBuilder_Widgets_NumberWidget__NumberWidget), @"mvc.1.0.view", @"/Components/PageBuilder/Widgets/NumberWidget/_NumberWidget.cshtml")]
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
#line 3 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\NumberWidget\_NumberWidget.cshtml"
using Kentico.PageBuilder.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\NumberWidget\_NumberWidget.cshtml"
using dcboe.Components.PageBuilder.InlineEditors.NumberEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\NumberWidget\_NumberWidget.cshtml"
using dcboe.Components.PageBuilder.Widgets.NumberWidget;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a51fd41681e86d1218fda4c84e46916c0f04b62", @"/Components/PageBuilder/Widgets/NumberWidget/_NumberWidget.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52497c0ca1c24ed45b2843b03dca00a1ff33ca16", @"/Components/_ViewImports.cshtml")]
    public class Components_PageBuilder_Widgets_NumberWidget__NumberWidget : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ComponentViewModel<NumberWidgetProperties>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Components/PageBuilder/InlineEditors/NumberEditor/_NumberEditor.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h3 style=\"background-color: #dddddd;\">The number you chose for today is: ");
#nullable restore
#line 12 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\NumberWidget\_NumberWidget.cshtml"
                                                                     Write(Model.Properties.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n");
#nullable restore
#line 15 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\NumberWidget\_NumberWidget.cshtml"
 if (pageBuilderContext.Retrieve().EditMode)
{
    var inlineEditorModel = new HeadingEditorModel
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\NumberWidget\_NumberWidget.cshtml"
                                                                                                             
        PropertyName = nameof(NumberWidgetProperties.Number),
        Number = @Model.Properties.Number
    };


#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5a51fd41681e86d1218fda4c84e46916c0f04b625591", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 24 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\NumberWidget\_NumberWidget.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = inlineEditorModel;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 25 "C:\inetpub\wwwroot\dcboe\dcboe\Components\PageBuilder\Widgets\NumberWidget\_NumberWidget.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IPageBuilderDataContextRetriever pageBuilderContext { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ComponentViewModel<NumberWidgetProperties>> Html { get; private set; }
    }
}
#pragma warning restore 1591
