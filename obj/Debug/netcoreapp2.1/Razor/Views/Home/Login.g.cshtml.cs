#pragma checksum "C:\Users\Administrator-PC\source\repos\AIMS-Portal\AIMS-Portal\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a80ae2e264b04ae7daf2b643539ac3f808897e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Login.cshtml", typeof(AspNetCore.Views_Home_Login))]
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
#line 1 "C:\Users\Administrator-PC\source\repos\AIMS-Portal\AIMS-Portal\Views\_ViewImports.cshtml"
using AIMS_Portal;

#line default
#line hidden
#line 2 "C:\Users\Administrator-PC\source\repos\AIMS-Portal\AIMS-Portal\Views\_ViewImports.cshtml"
using AIMS_Portal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a80ae2e264b04ae7daf2b643539ac3f808897e3", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6a65730eb6f86e969b1258116b48df5ca33c90", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Administrator-PC\source\repos\AIMS-Portal\AIMS-Portal\Views\Home\Login.cshtml"
   
    ViewData["Title"] = "Login";

#line default
#line hidden
            BeginContext(42, 1655, true);
            WriteLiteral(@"
<div class=""modal fade"" id=""modalLoginForm"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header text-center"">
                <h4 class=""modal-title w-100 font-weight-bold"">Sign in</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body mx-3"">
                <div class=""md-form mb-5"">
                    <i class=""fa fa-envelope prefix grey-text""></i>
                    <input type=""email"" id=""defaultForm-email"" class=""form-control validate"">
                    <label data-error=""wrong"" data-success=""right"" for=""defaultForm-email"">Your email</label>
                </div>

                <div class=""md-form mb-4"">
                    <i class=""fa fa-lock prefix gr");
            WriteLiteral(@"ey-text""></i>
                    <input type=""password"" id=""defaultForm-pass"" class=""form-control validate"">
                    <label data-error=""wrong"" data-success=""right"" for=""defaultForm-pass"">Your password</label>
                </div>

            </div>
            <div class=""modal-footer d-flex justify-content-center"">
                <button class=""btn btn-default"">Login</button>
            </div>
        </div>
    </div>
</div>

<div class=""text-center"">
    <a href="""" class=""btn btn-default btn-rounded mb-4"" data-toggle=""modal"" data-target=""#modalLoginForm"">Launch Modal Login Form</a>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
