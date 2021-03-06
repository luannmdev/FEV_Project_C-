#pragma checksum "D:\Study-code\FEVProject\project code\FEVProject\FEVProject\Views\Dashboard\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c966f794a54e59e402fc1565d03df2dae91a8baf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Profile), @"mvc.1.0.view", @"/Views/Dashboard/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/Profile.cshtml", typeof(AspNetCore.Views_Dashboard_Profile))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c966f794a54e59e402fc1565d03df2dae91a8baf", @"/Views/Dashboard/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1eef9ec9b93ff74979ddbffdefa6873cb64b5963", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Study-code\FEVProject\project code\FEVProject\FEVProject\Views\Dashboard\Profile.cshtml"
   
    Layout = "_Layout";
    ViewData["Title"] = "Profile";

#line default
#line hidden
            BeginContext(82, 541, true);
            WriteLiteral(@"<div class=""main main-raised"">
    <div class=""profile-content"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-6 ml-auto mr-auto"">
                    <div class=""profile"">
                        <div class=""avatar"">
                            <img src=""/assets/img/fev_dev_avt/BEN00150-2.jpg"" alt=""Circle Image"" class=""img-raised rounded-circle img-fluid"">
                        </div>
                        <div class=""name"">
                            <h3 class=""title"">");
            EndContext();
            BeginContext(624, 14, false);
#line 16 "D:\Study-code\FEVProject\project code\FEVProject\FEVProject\Views\Dashboard\Profile.cshtml"
                                         Write(Model.username);

#line default
#line hidden
            EndContext();
            BeginContext(638, 3050, true);
            WriteLiteral(@"</h3>
                            <h6>Designer</h6>
                            <a href=""https://www.youtube.com/channel/UCWWG2OMjLZAFbgkDs8XRjNw?view_as=subscriber"" class=""btn btn-link btn-just-icon""><i class=""fa fa-youtube-play""></i></a>
                            <a href=""https://www.instagram.com/vnproben/"" class=""btn btn-link btn-just-icon""><i class=""fa fa-instagram""></i></a>
                            <a href=""https://www.facebook.com/vnproben"" class=""btn btn-link btn-just-icon""><i class=""fa fa-facebook-square""></i></a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""description text-center"">
                <p>Im a senior in FPT University in HCM city. My major is Software Engineering. In part-time, Im a photographer. </p>
            </div>
            <div class=""row"">
                <div class=""col-md-6 ml-auto mr-auto"">
                    <div class=""profile-tabs"">
                        <ul class=""nav n");
            WriteLiteral(@"av-pills nav-pills-icons justify-content-center"" role=""tablist"">
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#studio"" role=""tab"" data-toggle=""tab"">
                                    <i class=""material-icons"">camera</i> Studio
                                </a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link active"" href=""#profile"" role=""tab"" data-toggle=""tab"">
                                    <i class=""material-icons"">palette</i> Work
                                </a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#favorite"" role=""tab"" data-toggle=""tab"">
                                    <i class=""material-icons"">favorite</i> Favorite
                                </a>
                            </li>
                        </ul>
     ");
            WriteLiteral(@"               </div>
                </div>
            </div>
            <div class=""tab-content tab-space"">
                <div class=""tab-pane text-center gallery"" id=""studio"">
                    <div class=""row"">
                        <div class=""col-md-3 ml-auto"">
                            <img src=""/assets/img/examples/studio-1.jpg"" class=""rounded"">
                            <img src=""/assets/img/examples/studio-2.jpg"" class=""rounded"">
                        </div>
                        <div class=""col-md-3 mr-auto"">
                            <img src=""/assets/img/examples/studio-5.jpg"" class=""rounded"">
                            <img src=""/assets/img/examples/studio-4.jpg"" class=""rounded"">
                        </div>
                    </div>
                </div>
                <div class=""tab-pane active text-center gallery"" id=""profile"">
                    <div class=""row"">
                        <div class=""col-md-5 ml-auto mr-auto"">
");
            EndContext();
#line 67 "D:\Study-code\FEVProject\project code\FEVProject\FEVProject\Views\Dashboard\Profile.cshtml"
                             if (ViewBag.Action == "Edit")
                            {
                                

#line default
#line hidden
            BeginContext(3812, 39, false);
#line 69 "D:\Study-code\FEVProject\project code\FEVProject\FEVProject\Views\Dashboard\Profile.cshtml"
                           Write(Html.Partial("_ProfileEditForm", Model));

#line default
#line hidden
            EndContext();
#line 69 "D:\Study-code\FEVProject\project code\FEVProject\FEVProject\Views\Dashboard\Profile.cshtml"
                                                                        
                            }
                            else if (ViewBag.Action == "ChangePass")
                            {
                                

#line default
#line hidden
            BeginContext(4018, 35, false);
#line 73 "D:\Study-code\FEVProject\project code\FEVProject\FEVProject\Views\Dashboard\Profile.cshtml"
                           Write(Html.Partial("_PasswordChangeForm"));

#line default
#line hidden
            EndContext();
#line 73 "D:\Study-code\FEVProject\project code\FEVProject\FEVProject\Views\Dashboard\Profile.cshtml"
                                                                    
                            }
                            else
                            {
                                

#line default
#line hidden
            BeginContext(4184, 39, false);
#line 77 "D:\Study-code\FEVProject\project code\FEVProject\FEVProject\Views\Dashboard\Profile.cshtml"
                           Write(Html.Partial("_ProfileViewForm", Model));

#line default
#line hidden
            EndContext();
#line 77 "D:\Study-code\FEVProject\project code\FEVProject\FEVProject\Views\Dashboard\Profile.cshtml"
                                                                        
                            }

#line default
#line hidden
            BeginContext(4256, 951, true);
            WriteLiteral(@"                        </div>
                    </div>
                </div>
                <div class=""tab-pane text-center gallery"" id=""favorite"">
                    <div class=""row"">
                        <div class=""col-md-3 ml-auto"">
                            <img src=""/assets/img/examples/mariya-georgieva.jpg"" class=""rounded"">
                            <img src=""/assets/img/examples/studio-3.jpg"" class=""rounded"">
                        </div>
                        <div class=""col-md-3 mr-auto"">
                            <img src=""/assets/img/examples/clem-onojeghuo.jpg"" class=""rounded"">
                            <img src=""/assets/img/examples/olu-eletu.jpg"" class=""rounded"">
                            <img src=""/assets/img/examples/studio-1.jpg"" class=""rounded"">
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
