#pragma checksum "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Shared\BlogSirala.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ff18dd96d27eea39f82b3ee582f787813d11d59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_BlogSirala), @"mvc.1.0.view", @"/Views/Shared/BlogSirala.cshtml")]
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
#line 1 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\_ViewImports.cshtml"
using NetCore_PROJE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\_ViewImports.cshtml"
using NetCore_PROJE.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Shared\BlogSirala.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ff18dd96d27eea39f82b3ee582f787813d11d59", @"/Views/Shared/BlogSirala.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb7badf436513dd8c97ff44224df8e763842534d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_BlogSirala : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"tech-btm\">\r\n    <h4>Son Bloglar</h4>\r\n\r\n");
#nullable restore
#line 7 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Shared\BlogSirala.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"blog-grids row mb-3\">\r\n            <div class=\"col-md-5 blog-grid-left\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 257, "\"", 293, 2);
            WriteAttributeValue("", 264, "Blog/BlogDetails/", 264, 17, true);
#nullable restore
#line 12 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Shared\BlogSirala.cshtml"
WriteAttributeValue("", 281, item.BlogID, 281, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img src=\"images/1.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 358, "\"", 364, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n            </div>\r\n            <div class=\"col-md-7 blog-grid-right\">\r\n\r\n                <h5>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 508, "\"", 544, 2);
            WriteAttributeValue("", 515, "Blog/BlogDetails/", 515, 17, true);
#nullable restore
#line 19 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Shared\BlogSirala.cshtml"
WriteAttributeValue("", 532, item.BlogID, 532, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Shared\BlogSirala.cshtml"
                                                       Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                </h5>\r\n                <div class=\"sub-meta\">\r\n                    <span>\r\n                        <i class=\"far fa-clock\"></i>");
#nullable restore
#line 23 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Shared\BlogSirala.cshtml"
                                               Write(item.BlogCreateContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n            </div>\r\n           \r\n        </div>\r\n");
#nullable restore
#line 29 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Shared\BlogSirala.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
