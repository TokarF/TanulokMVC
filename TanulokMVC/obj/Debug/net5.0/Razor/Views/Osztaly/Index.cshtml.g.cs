#pragma checksum "C:\Users\user\source\repos\TanulokMVC\TanulokMVC\Views\Osztaly\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7839b31d9814819875cf626f0eb446f1cf11ef8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Osztaly_Index), @"mvc.1.0.view", @"/Views/Osztaly/Index.cshtml")]
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
#line 1 "C:\Users\user\source\repos\TanulokMVC\TanulokMVC\Views\_ViewImports.cshtml"
using TanulokMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\TanulokMVC\TanulokMVC\Views\_ViewImports.cshtml"
using TanulokMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7839b31d9814819875cf626f0eb446f1cf11ef8", @"/Views/Osztaly/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0acd6e47386be9a0581846c4cebf61b7dd1a57f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Osztaly_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TanulokMVC.Models.OsztalyModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w3-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Osztaly", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tanulo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TanuloAdatok", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w3-button w3-white w3-text-blue w3-border w3-border-blue w3-hover-blue w3-round"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TanuloModositasForm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w3-button w3-white w3-text-orange w3-border w3-border-orange w3-hover-orange w3-round"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btn-torles"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TanuloTorles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w3-button w3-white w3-text-red w3-border w3-border-red w3-hover-red w3-round"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\source\repos\TanulokMVC\TanulokMVC\Views\Osztaly\Index.cshtml"
  
    ViewData["Title"] = "Főoldal";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""w3-container"" style=""margin-top:50px; margin-bottom:50px;"">
    <h1 class=""w3-xxxlarge w3-text-green w3-center w3-border-bottom w3-padding w3-wide""><b>Osztályok</b></h1>
</div>

<div class=""w3-container w3-center"" style=""margin-top:50px; margin-bottom:50px;"" id=""showcase"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7839b31d9814819875cf626f0eb446f1cf11ef87715", async() => {
                WriteLiteral(@"
        <input type=""text"" name=""kereses"" placeholder=""Keresés név alapján"" class=""w3-input w3-col l8 w3-margin-right"" />
        <button type=""submit"" class=""w3-button w3-white w3-text-blue w3-border w3-border-blue w3-hover-blue w3-round w3-col l3""><i class=""fas fa-search w3-margin-right""></i>Keresés</button>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 17 "C:\Users\user\source\repos\TanulokMVC\TanulokMVC\Views\Osztaly\Index.cshtml"
 foreach (OsztalyModel osztaly in Model)
{
    if (osztaly.diakok.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"w3-card-4 w3-margin-right w3-margin-left w3-round\"");
            BeginWriteAttribute("id", " id=\"", 961, "\"", 992, 2);
            WriteAttributeValue("", 966, "osztaly-", 966, 8, true);
#nullable restore
#line 21 "C:\Users\user\source\repos\TanulokMVC\TanulokMVC\Views\Osztaly\Index.cshtml"
WriteAttributeValue("", 974, osztaly.OsztalyId, 974, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-bottom: 50px\">\r\n            <table class=\"w3-table w3-bordered w3-striped w3-centered\">\r\n                <thead>\r\n                    <tr class=\"w3-green w3-border-0\">\r\n                        <th style=\"width: 20%;\"><h5>");
#nullable restore
#line 25 "C:\Users\user\source\repos\TanulokMVC\TanulokMVC\Views\Osztaly\Index.cshtml"
                                               Write(Html.DisplayNameFor(model => model.OsztalyNev));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 25 "C:\Users\user\source\repos\TanulokMVC\TanulokMVC\Views\Osztaly\Index.cshtml"
                                                                                                Write(osztaly.OsztalyNev);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></th>\r\n                        <th");
            BeginWriteAttribute("class", " class=\"", 1336, "\"", 1344, 0);
            EndWriteAttribute();
            WriteLiteral("><h5>");
#nullable restore
#line 26 "C:\Users\user\source\repos\TanulokMVC\TanulokMVC\Views\Osztaly\Index.cshtml"
                                    Write(Html.DisplayNameFor(model => model.OsztalyFonok));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 26 "C:\Users\user\source\repos\TanulokMVC\TanulokMVC\Views\Osztaly\Index.cshtml"
                                                                                       Write(osztaly.OsztalyFonok);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></th>\r\n                        <th style=\"width: 20%;\"><h5>");
#nullable restore
#line 27 "C:\Users\user\source\repos\TanulokMVC\TanulokMVC\Views\Osztaly\Index.cshtml"
                                               Write(Html.DisplayNameFor(model => model.Tanterem));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 27 "C:\Users\user\source\repos\TanulokMVC\TanulokMVC\Views\Osztaly\Index.cshtml"
                                                                                              Write(osztaly.Tanterem);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5></th>
                    </tr>
                    <tr class=""w3-green"">
                        <th>Tanuló ID</th>
                        <th>Név</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 37 "C:\Users\user\source\repos\TanulokMVC\TanulokMVC\Views\Osztaly\Index.cshtml"
                     foreach (TanuloModel diak in osztaly.diakok)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 40 "C:\Users\user\source\repos\TanulokMVC\TanulokMVC\Views\Osztaly\Index.cshtml"
                           Write(diak.TanuloId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 41 "C:\Users\user\source\repos\TanulokMVC\TanulokMVC\Views\Osztaly\Index.cshtml"
                           Write(diak.VezetekNev);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 41 "C:\Users\user\source\repos\TanulokMVC\TanulokMVC\Views\Osztaly\Index.cshtml"
                                            Write(diak.KeresztNev);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7839b31d9814819875cf626f0eb446f1cf11ef814326", async() => {
                WriteLiteral("<i class=\"fas fa-user\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-tanuloId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "C:\Users\user\source\repos\TanulokMVC\TanulokMVC\Views\Osztaly\Index.cshtml"
                                                                                             WriteLiteral(diak.TanuloId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tanuloId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-tanuloId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tanuloId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7839b31d9814819875cf626f0eb446f1cf11ef816900", async() => {
                WriteLiteral("<i class=\"fas fa-user-edit\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-tanuloId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\user\source\repos\TanulokMVC\TanulokMVC\Views\Osztaly\Index.cshtml"
                                                                                                    WriteLiteral(diak.TanuloId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tanuloId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-tanuloId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tanuloId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <a id=\"btn-tanulo-torles\" data-value-tanuloId=\"");
#nullable restore
#line 45 "C:\Users\user\source\repos\TanulokMVC\TanulokMVC\Views\Osztaly\Index.cshtml"
                                                                          Write(diak.TanuloId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-value-osztalyId=\"");
#nullable restore
#line 45 "C:\Users\user\source\repos\TanulokMVC\TanulokMVC\Views\Osztaly\Index.cshtml"
                                                                                                                Write(osztaly.OsztalyId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" onclick=""document.getElementById('tanulo-torles-modal').style.display='block'"" class=""w3-button w3-white w3-text-red w3-border w3-border-red w3-hover-red w3-round""><i class=""fas fa-user-times""></i></a>
                            </td>
                        </tr>
");
#nullable restore
#line 48 "C:\Users\user\source\repos\TanulokMVC\TanulokMVC\Views\Osztaly\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n");
#nullable restore
#line 52 "C:\Users\user\source\repos\TanulokMVC\TanulokMVC\Views\Osztaly\Index.cshtml"

    }

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<div id=""tanulo-torles-modal"" class=""w3-modal"">
    <div class=""w3-modal-content w3-animate-zoom w3-card-4"">
        <header class=""w3-container w3-red w3-center"">
            <h2>Tanuló Törlés</h2>
        </header>
        <div class=""w3-container w3-center"">
            <p>Valóban törölni szeretné a tanulót és vele minden osztályzatát?</p>
        </div>
        <footer class=""w3-container w3-padding w3-center"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7839b31d9814819875cf626f0eb446f1cf11ef821424", async() => {
                WriteLiteral("<i class=\"fas fa-check w3-margin-right\"></i>Törlés");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <a id=""btn-megsem"" onclick=""document.getElementById('tanulo-torles-modal').style.display='none'"" class=""w3-button w3-white w3-text-dark-gray w3-border w3-border-dark-gray w3-hover-dark-gray w3-round""><i class=""fas fa-times w3-margin-right""></i>Mégsem</a>
        </footer>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TanulokMVC.Models.OsztalyModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
