#pragma checksum "C:\Users\Musa\Desktop\Ne_Yapalim_develop\Ne_Yapalim\Views\Event\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd9dcebbdc1b9a51e0e97c26fe97acd756e351fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_Delete), @"mvc.1.0.view", @"/Views/Event/Delete.cshtml")]
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
#line 1 "C:\Users\Musa\Desktop\Ne_Yapalim_develop\Ne_Yapalim\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Musa\Desktop\Ne_Yapalim_develop\Ne_Yapalim\Views\_ViewImports.cshtml"
using Ne_Yapalim;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Musa\Desktop\Ne_Yapalim_develop\Ne_Yapalim\Views\_ViewImports.cshtml"
using Ne_Yapalim.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Musa\Desktop\Ne_Yapalim_develop\Ne_Yapalim\Views\_ViewImports.cshtml"
using Ne_Yapalim.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd9dcebbdc1b9a51e0e97c26fe97acd756e351fe", @"/Views/Event/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8362dce5b165b993107f6a901009a216efd138b0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Event_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ne_Yapalim.Models.Events>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("mdo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("32"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("32"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Musa\Desktop\Ne_Yapalim_develop\Ne_Yapalim\Views\Event\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Musa\Desktop\Ne_Yapalim_develop\Ne_Yapalim\Views\Event\Delete.cshtml"
  var Users = await UserManager.GetUserAsync(User); 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container px-4 py-5 event-detail\" id=\"custom-cards\">\r\n    <div class=\"row align-items-stretch g-4 py-5 eventList1\">\r\n        <div class=\"col-12 col-lg-6 align-items-center justify-content-center\">\r\n            <h2 class=\"pb-2\">");
#nullable restore
#line 13 "C:\Users\Musa\Desktop\Ne_Yapalim_develop\Ne_Yapalim\Views\Event\Delete.cshtml"
                        Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 14 "C:\Users\Musa\Desktop\Ne_Yapalim_develop\Ne_Yapalim\Views\Event\Delete.cshtml"
             foreach (var images in Model.EventImage)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"img\">\r\n                    <img id=\"img-details\"");
            BeginWriteAttribute("src", " src=\"", 611, "\"", 642, 2);
            WriteAttributeValue("", 617, "/EventImage/", 617, 12, true);
#nullable restore
#line 17 "C:\Users\Musa\Desktop\Ne_Yapalim_develop\Ne_Yapalim\Views\Event\Delete.cshtml"
WriteAttributeValue("", 629, images.Image, 629, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 643, "\"", 649, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n");
#nullable restore
#line 19 "C:\Users\Musa\Desktop\Ne_Yapalim_develop\Ne_Yapalim\Views\Event\Delete.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"content\">\r\n                <p>\r\n                    ");
#nullable restore
#line 23 "C:\Users\Musa\Desktop\Ne_Yapalim_develop\Ne_Yapalim\Views\Event\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </p>
            </div>
        </div>

        <div class=""col-12 col-lg-6 order-md-last"">
            <ul class=""list-group mb-3"">
                <li class=""list-group-item d-flex justify-content-between lh-sm"">
                    <div class=""pb-3 mb-0 small lh-sm border-bottom float-end"">
                        <div class=""dropdown text-end"" style=""margin-right: 20px;"">
                            <a href=""#"" class=""d-block link-dark text-decoration-none dropdown-toggle"" id=""dropdownUser1"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                <h6>Kat??l??mc??lar</h6>
                            </a>
                            <ul class=""dropdown-menu text-small"" aria-labelledby=""dropdownUser1""");
            BeginWriteAttribute("style", " style=\"", 1579, "\"", 1587, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <li>\r\n                                    <a class=\"dropdown-item\">\r\n                                        <div>\r\n\r\n                                            <ul>\r\n");
#nullable restore
#line 42 "C:\Users\Musa\Desktop\Ne_Yapalim_develop\Ne_Yapalim\Views\Event\Delete.cshtml"
                                                 foreach (var attendee in Model.Attendees)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <li> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dd9dcebbdc1b9a51e0e97c26fe97acd756e351fe9889", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2001, "~/images/", 2001, 9, true);
#nullable restore
#line 44 "C:\Users\Musa\Desktop\Ne_Yapalim_develop\Ne_Yapalim\Views\Event\Delete.cshtml"
AddHtmlAttributeValue("", 2010, attendee.CustomUsers.ProfilPhoto, 2010, 33, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" ");
#nullable restore
#line 44 "C:\Users\Musa\Desktop\Ne_Yapalim_develop\Ne_Yapalim\Views\Event\Delete.cshtml"
                                                                                                                                                                     Write(attendee.CustomUsers.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 44 "C:\Users\Musa\Desktop\Ne_Yapalim_develop\Ne_Yapalim\Views\Event\Delete.cshtml"
                                                                                                                                                                                                Write(attendee.CustomUsers.SurName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <small>(");
#nullable restore
#line 44 "C:\Users\Musa\Desktop\Ne_Yapalim_develop\Ne_Yapalim\Views\Event\Delete.cshtml"
                                                                                                                                                                                                                                      Write(attendee.CustomUsers.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</small></li>\r\n");
#nullable restore
#line 45 "C:\Users\Musa\Desktop\Ne_Yapalim_develop\Ne_Yapalim\Views\Event\Delete.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </ul>


                                        </div>
                                    </a>
                                </li>

                            </ul>
                        </div>
                    </div>
                    <span class=""text-muted"">");
#nullable restore
#line 56 "C:\Users\Musa\Desktop\Ne_Yapalim_develop\Ne_Yapalim\Views\Event\Delete.cshtml"
                                        Write(Html.DisplayFor(model => model.Attendees.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                </li>

                <li class=""list-group-item d-flex justify-content-between lh-sm"">
                    <div>
                        <h6 class=""my-0"">Konum</h6>
                    </div>
                    <span class=""text-muted"">");
#nullable restore
#line 63 "C:\Users\Musa\Desktop\Ne_Yapalim_develop\Ne_Yapalim\Views\Event\Delete.cshtml"
                                        Write(Html.DisplayFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                </li>
                <li class=""list-group-item d-flex justify-content-between lh-sm"">
                    <div>
                        <h6 class=""my-0"">Tarih</h6>
                    </div>
                    <span class=""text-muted""> ");
#nullable restore
#line 69 "C:\Users\Musa\Desktop\Ne_Yapalim_develop\Ne_Yapalim\Views\Event\Delete.cshtml"
                                         Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </li>\r\n            </ul>\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd9dcebbdc1b9a51e0e97c26fe97acd756e351fe15054", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dd9dcebbdc1b9a51e0e97c26fe97acd756e351fe15329", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 74 "C:\Users\Musa\Desktop\Ne_Yapalim_develop\Ne_Yapalim\Views\Event\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <input type=\"submit\" value=\"Etkinli??i sil\"  class=\"btn btn-primary my-2 btnStyle1 float-end\"/>\r\n\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<CustomUser> UserManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<CustomUser> SignInManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ne_Yapalim.Models.Events> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
