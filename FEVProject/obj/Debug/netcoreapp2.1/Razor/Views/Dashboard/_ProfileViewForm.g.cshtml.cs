#pragma checksum "D:\Study-code\FEVProject\project code\FEVProject\FEVProject\Views\Dashboard\_ProfileViewForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f4aec82753483cd3e877d02539a8fbe8ba2a2ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard__ProfileViewForm), @"mvc.1.0.view", @"/Views/Dashboard/_ProfileViewForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/_ProfileViewForm.cshtml", typeof(AspNetCore.Views_Dashboard__ProfileViewForm))]
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
#line 1 "D:\Study-code\FEVProject\project code\FEVProject\FEVProject\Views\_ViewImports.cshtml"
using FEVProject;

#line default
#line hidden
#line 2 "D:\Study-code\FEVProject\project code\FEVProject\FEVProject\Views\_ViewImports.cshtml"
using FEVProject.Models;

#line default
#line hidden
#line 3 "D:\Study-code\FEVProject\project code\FEVProject\FEVProject\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f4aec82753483cd3e877d02539a8fbe8ba2a2ec", @"/Views/Dashboard/_ProfileViewForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1eef9ec9b93ff74979ddbffdefa6873cb64b5963", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard__ProfileViewForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-link btn-wd btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangePass", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(13, 2513, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bec262840dcc441ea228deea27f4e1e2", async() => {
                BeginContext(52, 443, true);
                WriteLiteral(@"
    <p class=""description text-center"">There are your profile</p>
    <div class=""card-body"">
        <div class=""input-group"">
            <div class=""input-group-prepend"">
                <span class=""input-group-text"">
                    <i class=""material-icons"">face</i>
                </span>
            </div>
            <input style=""background-color: transparent;"" type=""text"" class=""form-control"" placeholder=""Username""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 495, "\"", 518, 1);
#line 11 "D:\Study-code\FEVProject\project code\FEVProject\FEVProject\Views\Dashboard\_ProfileViewForm.cshtml"
WriteAttributeValue("", 503, Model.username, 503, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(519, 373, true);
                WriteLiteral(@" readonly>
        </div>
        <div class=""input-group"">
            <div class=""input-group-prepend"">
                <span class=""input-group-text"">
                    <i class=""material-icons"">contacts</i>
                </span>
            </div>
            <input style=""background-color: transparent;"" type=""text"" class=""form-control"" placeholder=""Name""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 892, "\"", 915, 1);
#line 19 "D:\Study-code\FEVProject\project code\FEVProject\FEVProject\Views\Dashboard\_ProfileViewForm.cshtml"
WriteAttributeValue("", 900, Model.fullName, 900, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(916, 378, true);
                WriteLiteral(@" readonly>
        </div>
        <div class=""input-group"">
            <div class=""input-group-prepend"">
                <span class=""input-group-text"">
                    <i class=""material-icons"">mail_outline</i>
                </span>
            </div>
            <input style=""background-color: transparent;"" type=""text"" class=""form-control"" placeholder=""Email""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1294, "\"", 1314, 1);
#line 27 "D:\Study-code\FEVProject\project code\FEVProject\FEVProject\Views\Dashboard\_ProfileViewForm.cshtml"
WriteAttributeValue("", 1302, Model.email, 1302, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1315, 380, true);
                WriteLiteral(@" readonly>
        </div>
        <div class=""input-group"">
            <div class=""input-group-prepend"">
                <span class=""input-group-text"">
                    <i class=""material-icons"">phonelink_ring</i>
                </span>
            </div>
            <input style=""background-color: transparent;"" type=""text"" class=""form-control"" placeholder=""Phone""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1695, "\"", 1715, 1);
#line 35 "D:\Study-code\FEVProject\project code\FEVProject\FEVProject\Views\Dashboard\_ProfileViewForm.cshtml"
WriteAttributeValue("", 1703, Model.phone, 1703, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1716, 360, true);
                WriteLiteral(@" readonly>
        </div>
        <div class=""input-group"">
            <div class=""input-group-prepend"">
                <span class=""input-group-text"">
                    <i class=""material-icons"">calendar_today</i>
                </span>
            </div>
            <input style=""background-color: transparent;"" type=""date"" class=""form-control""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2076, "\"", 2100, 1);
#line 43 "D:\Study-code\FEVProject\project code\FEVProject\FEVProject\Views\Dashboard\_ProfileViewForm.cshtml"
WriteAttributeValue("", 2084, Model.birthdate, 2084, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2101, 40, true);
                WriteLiteral(" disabled>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
#line 46 "D:\Study-code\FEVProject\project code\FEVProject\FEVProject\Views\Dashboard\_ProfileViewForm.cshtml"
     if (ViewBag.OtherInf == null)
    {

#line default
#line hidden
                BeginContext(2184, 54, true);
                WriteLiteral("        <div class=\"footer text-center\">\r\n            ");
                EndContext();
                BeginContext(2238, 91, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "376e026dfe4b48a4a9aa4117274579ba", async() => {
                    BeginContext(2313, 12, true);
                    WriteLiteral("Edit Profile");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2329, 72, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"footer text-center\">\r\n            ");
                EndContext();
                BeginContext(2401, 93, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "862704498f0144e5ba83bc4e4949fa3f", async() => {
                    BeginContext(2475, 15, true);
                    WriteLiteral("Change Password");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2494, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
#line 54 "D:\Study-code\FEVProject\project code\FEVProject\FEVProject\Views\Dashboard\_ProfileViewForm.cshtml"
    }

#line default
#line hidden
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
