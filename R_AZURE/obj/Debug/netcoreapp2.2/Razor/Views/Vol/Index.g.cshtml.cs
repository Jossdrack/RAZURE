#pragma checksum "/Users/Joss/Projects/R_AZURE/R_AZURE/Views/Vol/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "847d4748f54d76da2598beccaac14b30f1d4ddde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vol_Index), @"mvc.1.0.view", @"/Views/Vol/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vol/Index.cshtml", typeof(AspNetCore.Views_Vol_Index))]
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
#line 1 "/Users/Joss/Projects/R_AZURE/R_AZURE/Views/_ViewImports.cshtml"
using R_AZURE;

#line default
#line hidden
#line 2 "/Users/Joss/Projects/R_AZURE/R_AZURE/Views/_ViewImports.cshtml"
using R_AZURE.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"847d4748f54d76da2598beccaac14b30f1d4ddde", @"/Views/Vol/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c519e80b436fee10df5673323f5c2f5e9108f8a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Vol_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Joss/Projects/R_AZURE/R_AZURE/Views/Vol/Index.cshtml"
  
    ViewData["Title"] = "RESERVEZ VOTRE VOLS AU MEILLEURS PRIX";
    Layout = "~/Views/Shared/_LayoutVol.cshtml";

#line default
#line hidden
            BeginContext(123, 71, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1><span class=\"badge badge-primary\">");
            EndContext();
            BeginContext(195, 17, false);
#line 7 "/Users/Joss/Projects/R_AZURE/R_AZURE/Views/Vol/Index.cshtml"
                                     Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(212, 28, true);
            WriteLiteral("</span></h1>\r\n\r\n\r\n\r\n\r\n</div>");
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
