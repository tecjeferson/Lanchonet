#pragma checksum "C:\Users\jefbg\source\repos\Lanchonete\Lanchonete\Views\Shared\_LanchesResumo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8b3a48f01b4a8baf003b1fbc7282707c5117114"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LanchesResumo), @"mvc.1.0.view", @"/Views/Shared/_LanchesResumo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_LanchesResumo.cshtml", typeof(AspNetCore.Views_Shared__LanchesResumo))]
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
#line 1 "C:\Users\jefbg\source\repos\Lanchonete\Lanchonete\Views\_ViewImports.cshtml"
using Lanchonete.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\jefbg\source\repos\Lanchonete\Lanchonete\Views\_ViewImports.cshtml"
using Lanchonete;

#line default
#line hidden
#line 3 "C:\Users\jefbg\source\repos\Lanchonete\Lanchonete\Views\_ViewImports.cshtml"
using Lanchonete.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8b3a48f01b4a8baf003b1fbc7282707c5117114", @"/Views/Shared/_LanchesResumo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fffddd9efc2a444e93fd83229a8f50d6ac73c60d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LanchesResumo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lanche>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 53, true);
            WriteLiteral("\r\n<div class=\"col-sm-12 col-md-4 col-lg-3\">\r\n    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 68, "\"", 90, 1);
#line 4 "C:\Users\jefbg\source\repos\Lanchonete\Lanchonete\Views\Shared\_LanchesResumo.cshtml"
WriteAttributeValue("", 74, Model.ImagemUrl, 74, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(91, 76, true);
            WriteLiteral(" class=\"img-fluid  h-50\" alt=\"Foto do lanche\" />\r\n    <h3 class=\"pull-righ\">");
            EndContext();
            BeginContext(168, 25, false);
#line 5 "C:\Users\jefbg\source\repos\Lanchonete\Lanchonete\Views\Shared\_LanchesResumo.cshtml"
                     Write(Model.Preco.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(193, 15, true);
            WriteLiteral("</h3>\r\n    <h3>");
            EndContext();
            BeginContext(209, 10, false);
#line 6 "C:\Users\jefbg\source\repos\Lanchonete\Lanchonete\Views\Shared\_LanchesResumo.cshtml"
   Write(Model.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(219, 14, true);
            WriteLiteral("</h3>\r\n    <p>");
            EndContext();
            BeginContext(234, 20, false);
#line 7 "C:\Users\jefbg\source\repos\Lanchonete\Lanchonete\Views\Shared\_LanchesResumo.cshtml"
  Write(Model.DescricaoCurta);

#line default
#line hidden
            EndContext();
            BeginContext(254, 12, true);
            WriteLiteral("</p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lanche> Html { get; private set; }
    }
}
#pragma warning restore 1591
