#pragma checksum "C:\inetpub\wwwroot\dcboe\dcboe\Components\FormBuilder\FormComponents\ColorFormComponent\_ColorFormComponent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68aa644111d169ee3878c6b87ee436ed840d9b55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Components_FormBuilder_FormComponents_ColorFormComponent__ColorFormComponent), @"mvc.1.0.view", @"/Components/FormBuilder/FormComponents/ColorFormComponent/_ColorFormComponent.cshtml")]
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
#line 1 "C:\inetpub\wwwroot\dcboe\dcboe\Components\FormBuilder\FormComponents\ColorFormComponent\_ColorFormComponent.cshtml"
using Kentico.Forms.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\inetpub\wwwroot\dcboe\dcboe\Components\FormBuilder\FormComponents\ColorFormComponent\_ColorFormComponent.cshtml"
using Kentico.Web.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68aa644111d169ee3878c6b87ee436ed840d9b55", @"/Components/FormBuilder/FormComponents/ColorFormComponent/_ColorFormComponent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52497c0ca1c24ed45b2843b03dca00a1ff33ca16", @"/Components/_ViewImports.cshtml")]
    public class Components_FormBuilder_FormComponents_ColorFormComponent__ColorFormComponent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dcboe.Components.FormBuilder.FormComponents.ColorFormComponent.ColorFormComponent>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\inetpub\wwwroot\dcboe\dcboe\Components\FormBuilder\FormComponents\ColorFormComponent\_ColorFormComponent.cshtml"
  
    // Gets a collection of system HTML attributes necessary for the functionality of form component inputs
    IDictionary<string, object> htmlAttributes = ViewData.Kentico().GetEditorHtmlAttributes();

    // Prepares data that will be passed to the function that opens the modal dialog
    string dialogData = Newtonsoft.Json.JsonConvert.SerializeObject(new
    {
        modalDialogUrl = Url.Action("Index", "ColorModalDialog"),
        colorInputId = Html.IdFor(m => m.Value)
    });

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\inetpub\wwwroot\dcboe\dcboe\Components\FormBuilder\FormComponents\ColorFormComponent\_ColorFormComponent.cshtml"
Write(Html.TextBoxFor(m => m.Value, htmlAttributes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("<button type=\"button\" class=\"ktc-btn ktc-btn-default\"");
            BeginWriteAttribute("onclick", " onclick=\"", 895, "\"", 938, 3);
            WriteAttributeValue("", 905, "openColorModalDialog(", 905, 21, true);
#nullable restore
#line 22 "C:\inetpub\wwwroot\dcboe\dcboe\Components\FormBuilder\FormComponents\ColorFormComponent\_ColorFormComponent.cshtml"
WriteAttributeValue("", 926, dialogData, 926, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 937, ")", 937, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Open dialog</button>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dcboe.Components.FormBuilder.FormComponents.ColorFormComponent.ColorFormComponent> Html { get; private set; }
    }
}
#pragma warning restore 1591
