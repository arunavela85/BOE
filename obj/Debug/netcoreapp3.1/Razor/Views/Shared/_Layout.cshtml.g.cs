#pragma checksum "C:\inetpub\wwwroot\dcboe\dcboe\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f69d9cbc73cdb3d798eaa93d8057868c78a02a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 2 "C:\inetpub\wwwroot\dcboe\dcboe\Views\Shared\_Layout.cshtml"
using Kentico.PageBuilder.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\inetpub\wwwroot\dcboe\dcboe\Views\Shared\_Layout.cshtml"
using Kentico.Web.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f69d9cbc73cdb3d798eaa93d8057868c78a02a2", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78979bc92fdb481272598c22d79cadd8b7ad709f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bundle1.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/custom.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bundle.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/custom.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/formHelper.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f69d9cbc73cdb3d798eaa93d8057868c78a02a26219", async() => {
                WriteLiteral("\r\n    <title>\r\n        District of Columbia Board of Elections - /\r\n    </title>\r\n    <meta http-equiv=\"pragma\" content=\"no-cache\" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7f69d9cbc73cdb3d798eaa93d8057868c78a02a26626", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7f69d9cbc73cdb3d798eaa93d8057868c78a02a27891", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <link href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"" rel=""stylesheet"" integrity=""sha384-wvfXpqpZZVQGK6TAh5PVlGOfQNHSoD2xbE+QkPxCAFlNEevoEH3Sl0sibVcOQVnN"" crossorigin=""anonymous"">
    <script src='https://www.google.com/recaptcha/api.js'></script>
    <script src=""http://f1-na.readspeaker.com/script/37/webReader/webReader.js?pids=wr"" type=""text/javascript""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f69d9cbc73cdb3d798eaa93d8057868c78a02a29578", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f69d9cbc73cdb3d798eaa93d8057868c78a02a210677", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f69d9cbc73cdb3d798eaa93d8057868c78a02a211777", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f69d9cbc73cdb3d798eaa93d8057868c78a02a212877", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
#nullable restore
#line 20 "C:\inetpub\wwwroot\dcboe\dcboe\Views\Shared\_Layout.cshtml"
Write(Html.Kentico().PageBuilderStyles());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f69d9cbc73cdb3d798eaa93d8057868c78a02a214908", async() => {
                WriteLiteral(@"
    <div class=""header"" role=""banner"">
        <div class=""header__bar"">
            <div class=""container"">
                <div class=""header__holder"">
                    <nav class=""nav-utilities"" role=""navigation"" aria-label=""Utilities menu"">
                        <ul role=""menubar"" aria-hidden=""false"">
                            ");
#nullable restore
#line 29 "C:\inetpub\wwwroot\dcboe\dcboe\Views\Shared\_Layout.cshtml"
                       Write(await Component.InvokeAsync("NavigationMenu", "top"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </ul>
                    </nav>
                    <div class=""socials"">
                        <ul>
                            <li>
                                <a href=""https://www.facebook.com/Vote4DC/"" target=""_blank"" Title=""Facebook"" aria-label=""Link to District of Columbia Board of Elections Facebook Page"">
                                    <i class=""ico-facebook"" aria-hidden=""true""></i>
                                </a>
                            </li>
                            <li>
                                <a href=""https://twitter.com/Vote4DC"" target=""_blank"" title=""Twitter"" aria-label=""Link to District of Columbia Board of Elections Twitter Page"">
                                    <i class=""ico-twitter"" aria-hidden=""true""></i>
                                </a>
                            </li>
                            <li>
                                <a href=""https://www.instagram.com/vote4dc/"" target=""_blank"" title=""Instagram");
                WriteLiteral(@""" aria-label=""Link to District of Columbia Board of Elections Instagram Page"">
                                    <i class=""ico-instagram"" aria-hidden=""true""></i>
                                </a>
                            </li>
                            <li>
                                <a href=""https://www.youtube.com/channel/UCXMvT2yptWuxdOIXUePqhxg"" target=""_blank"" title=""YouTube"" aria-label=""Link to District of Columbia Board of Elections YouTube Channel"">
                                    <i class=""ico-youtube"" aria-hidden=""true""></i>
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <div class=""header__content"">
            <div class=""container"">
                <a href=""/"" class=""logo"">District of Columbia</a>
                <a href=""#"" class=""nav-btn"" aria-label=""Toggle menu"">
                    <span></span>
                ");
                WriteLiteral("    <span></span>\r\n                    <span></span>\r\n                </a>\r\n                <nav class=\"nav\" role=\"navigation\" aria-label=\"Main menu\">\r\n                    <ul class=\"nav-menu\">\r\n                        ");
#nullable restore
#line 69 "C:\inetpub\wwwroot\dcboe\dcboe\Views\Shared\_Layout.cshtml"
                   Write(await Component.InvokeAsync("NavigationMenu", "main"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </ul>\r\n                </nav>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"wrapper\">\r\n        ");
#nullable restore
#line 76 "C:\inetpub\wwwroot\dcboe\dcboe\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    
    </div>
    <div class=""bar"">
        <div class=""container"">
            <div class=""row"">
                <div class=""column col-lg-6"">
                    <div class=""subscribe"" role=""form"" aria-label=""subscribe"">
                        <form action=""/Subscription"" method=""post"">
                            <div class=""subscribe__row"">
                                <label for=""mail"" class=""hidden"">Email</label>
                                <input type=""email"" id=""subEmail"" name=""subEmail""");
                BeginWriteAttribute("value", " value=\"", 4413, "\"", 4421, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Get Email Updates"" class=""subscribe__field"" aria-label=""Enter E-mail address to subsribe"">
                                <input role=""button"" title=""Subscribe Button"" id=""btnSubmit"" type=""button"" value=""Subscribe"" class=""subscribe__btn"" onclick=""javascript:submitEmail();"" tabindex=""0"">
                            </div>
                        </form>
                    </div>
                </div>
                <div class=""column col-lg-6 socials-align text-right"">
                    <div class=""socials socials--follow"">
                        <span>Follow Us</span>
                        <ul>
                            <li>
                                <a href=""https://www.facebook.com/Vote4DC/"" target=""_blank"" title=""Facebook"" aria-label=""Link to District of Columbia Board of Elections Facebook Page"">
                                    <i aria-hidden=""true"" class=""ico-facebook-large""></i>
                                </a>
                            </li>
     ");
                WriteLiteral(@"                       <li>
                                <a href=""https://twitter.com/Vote4DC"" target=""_blank"" title=""Twitter"" aria-label=""Link to District of Columbia Board of Elections Twitter Page"">
                                    <i aria-hidden=""true"" class=""ico-twitter-large""></i>
                                </a>
                            </li>
                            <li>
                                <a href=""https://www.instagram.com/vote4dc/"" target=""_blank"" title=""Instagram"" aria-label=""Link to District of Columbia Board of Elections Instagram Page"">
                                    <i aria-hidden=""true"" class=""ico-instagram-large""></i>
                                </a>
                            </li>
                            <li>
                                <a href=""https://www.youtube.com/channel/UCXMvT2yptWuxdOIXUePqhxg"" target=""_blank"" title=""YouTube"" aria-label=""Link to District of Columbia Board of Elections Youtube Channel"">
                      ");
                WriteLiteral(@"              <i aria-hidden=""true"" class=""ico-youtube-large""></i>
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>


        <footer aria-label=""Page End"" class=""footer"" role=""contentinfo"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""column col-lg-6"">
                        <div class=""footer__inner"">
                            <div class=""footer__logo""><a class=""footer-logo"" href=""/"">District of Columbia</a></div>

                            <div class=""footer__content"">
                                <h5>DC Board of Elections</h5>
                                <ul>
                                    <li>1015 Half Street, SE, Suite 750</li>
                                    <li>Washington, DC 20003</li>
                                    <li>Tel: (202) 727-2525</li>
                  ");
                WriteLiteral(@"                  <li>Tollfree: 1-866-DC-VOTES</li>
                                    <li>TTY: 711 (in DC)</li>
                                    <li>TTY (Text Telephone): 800-643-3768</li>
                                    <li>Spanish TTY: 800-546-7111</li>
                                </ul>
                            </div>
                        </div>
                    </div>

                    <div class=""column col-lg-6"">
                        <div class=""footer__container"">
                            <div class=""footer__nav"">
                                <ul class=""nav-menu"">
                                    ");
#nullable restore
#line 149 "C:\inetpub\wwwroot\dcboe\dcboe\Views\Shared\_Layout.cshtml"
                               Write(await Component.InvokeAsync("NavigationMenu", "footer"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </footer>
        <script>

            $('.carousel').carousel({
                interval: 2000
            })
        </script>
        ");
#nullable restore
#line 163 "C:\inetpub\wwwroot\dcboe\dcboe\Views\Shared\_Layout.cshtml"
   Write(Html.Kentico().PageBuilderScripts());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
