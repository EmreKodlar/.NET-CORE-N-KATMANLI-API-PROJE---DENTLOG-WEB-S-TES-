#pragma checksum "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Category\KategoriGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccd3e5cf82598f5300d44e8bb2b0be7ec87d6a6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_KategoriGetir), @"mvc.1.0.view", @"/Views/Category/KategoriGetir.cshtml")]
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
#line 1 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Category\KategoriGetir.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Category\KategoriGetir.cshtml"
using NetCore_PROJE.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccd3e5cf82598f5300d44e8bb2b0be7ec87d6a6c", @"/Views/Category/KategoriGetir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb7badf436513dd8c97ff44224df8e763842534d", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_KategoriGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Category\KategoriGetir.cshtml"
  
    ViewData["Title"] = "Kategori: " + ViewBag.KategoriAd;
    Layout = "~/Views/Shared/UI_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"banner-inner\">\r\n</div>\r\n<ol class=\"breadcrumb\">\r\n    <li class=\"breadcrumb-item\">\r\n        <a href=\"/Category/CategoryShow\">Kategoriler</a>\r\n    </li>\r\n    <li class=\"breadcrumb-item active\">");
#nullable restore
#line 15 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Category\KategoriGetir.cshtml"
                                  Write(ViewBag.KategoriAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ol>\r\n<section class=\"main-content-w3layouts-agileits\">\r\n    <div class=\"container\">\r\n\r\n\r\n        <div class=\"left-blog-info-w3layouts-agileits text-left\">\r\n\r\n            <div class=\"row\">\r\n\r\n");
#nullable restore
#line 25 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Category\KategoriGetir.cshtml"
                 foreach (var itemBlog in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 card\" style=\"margin-bottom:50px; margin-top:2px\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 809, "\"", 889, 4);
            WriteAttributeValue("", 816, "/Blog/BlogDetails/", 816, 18, true);
#nullable restore
#line 28 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Category\KategoriGetir.cshtml"
WriteAttributeValue("", 834, itemBlog.BlogID, 834, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 850, "/", 850, 1, true);
#nullable restore
#line 28 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Category\KategoriGetir.cshtml"
WriteAttributeValue("", 851, Seo.AdresDuzenle(@itemBlog.BlogTitle), 851, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 925, "\"", 963, 2);
            WriteAttributeValue("", 931, "/images/", 931, 8, true);
#nullable restore
#line 29 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Category\KategoriGetir.cshtml"
WriteAttributeValue("", 939, itemBlog.BloglImageName, 939, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 995, "\"", 1020, 1);
#nullable restore
#line 29 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Category\KategoriGetir.cshtml"
WriteAttributeValue("", 1001, itemBlog.BlogTitle, 1001, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""margin-bottom:5px; height:200px; margin-top:5px"">

                        </a>
                        <div class=""card-body"" style=""margin-bottom:2px; margin-top:2px"">
                            <ul class=""blog-icons my-4"" style=""margin-bottom:2px; margin-top:2px"">
                                <li style=""margin-bottom:2px; margin-top:2px"">
                                    <a href=""#"">
                                        <i class=""far fa-calendar-alt""></i>");
#nullable restore
#line 36 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Category\KategoriGetir.cshtml"
                                                                      Write(itemBlog.BlogCreateContent);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral(@"
                                    </a>
                                </li>
                                <li class=""mx-2"" style=""margin-bottom:2px; margin-top:2px"">
                                    <a href=""#"">
                                        <i class=""far fa-comment""></i> ");
#nullable restore
#line 41 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Category\KategoriGetir.cshtml"
                                                                  Write(itemBlog.CommentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </li>\r\n                                <li style=\"margin-bottom:2px; margin-top:2px\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2124, "\"", 2184, 2);
            WriteAttributeValue("", 2131, "/Category/KategoriGetir/", 2131, 24, true);
#nullable restore
#line 45 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Category\KategoriGetir.cshtml"
WriteAttributeValue("", 2155, itemBlog.Category.CategoryID, 2155, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <i class=\"fas fa-eye\"></i>  ");
#nullable restore
#line 46 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Category\KategoriGetir.cshtml"
                                                               Write(itemBlog.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </li>\r\n\r\n                            </ul>\r\n                            <h5 class=\"card-title\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2494, "\"", 2574, 4);
            WriteAttributeValue("", 2501, "/Blog/BlogDetails/", 2501, 18, true);
#nullable restore
#line 52 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Category\KategoriGetir.cshtml"
WriteAttributeValue("", 2519, itemBlog.BlogID, 2519, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2535, "/", 2535, 1, true);
#nullable restore
#line 52 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Category\KategoriGetir.cshtml"
WriteAttributeValue("", 2536, Seo.AdresDuzenle(@itemBlog.BlogTitle), 2536, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 52 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Category\KategoriGetir.cshtml"
                                                                                                               Write(itemBlog.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </h5>\r\n                            <p class=\"card-text mb-3\">\r\n");
#nullable restore
#line 55 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Category\KategoriGetir.cshtml"
                                  string metin = System.Text.RegularExpressions.Regex.Replace(itemBlog.BlogContent, @"<(.|\n)*?>", string.Empty); 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
#nullable restore
#line 56 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Category\KategoriGetir.cshtml"
                           Write(metin.Substring(0, itemBlog.BlogContent.Substring(0, 110).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("...\r\n                            </p>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 3018, "\"", 3098, 4);
            WriteAttributeValue("", 3025, "/Blog/BlogDetails/", 3025, 18, true);
#nullable restore
#line 58 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Category\KategoriGetir.cshtml"
WriteAttributeValue("", 3043, itemBlog.BlogID, 3043, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3059, "/", 3059, 1, true);
#nullable restore
#line 58 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Category\KategoriGetir.cshtml"
WriteAttributeValue("", 3060, Seo.AdresDuzenle(@itemBlog.BlogTitle), 3060, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">Devamı...</a>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 61 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Category\KategoriGetir.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <!--//left-->\r\n        </div>\r\n\r\n    </div>\r\n</section>\r\n\r\n<br />");
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
