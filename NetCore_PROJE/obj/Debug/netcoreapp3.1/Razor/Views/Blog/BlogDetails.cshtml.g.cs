#pragma checksum "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8a5126da53fb6f01cd7492c95627eb400f77816"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogDetails), @"mvc.1.0.view", @"/Views/Blog/BlogDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8a5126da53fb6f01cd7492c95627eb400f77816", @"/Views/Blog/BlogDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb7badf436513dd8c97ff44224df8e763842534d", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Comment/CommentAddBlog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDetails.cshtml"
  
    ViewData["Title"] = Model.BlogTitle;
    Layout = "~/Views/Shared/UI_Layout.cshtml";

    Random rnd = new Random();


    int s1 = rnd.Next(1, 50);
    int s2 = rnd.Next(1, 50);
    int sonuc = s1 + s2;


    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!--//banner-->
<section class=""banner-bottom"" style=""background-color:lightgrey"">
    <!--/blog-->
    <div class=""container"">
        <div class=""row"">
            <!--left-->
          
            <div class=""col-lg-8 left-blog-info-w3layouts-agileits text-justify"" style=""background-color: white; border-radius: 10px;"">
                <div class=""blog-grid-top"" style=""padding-left: 20px; padding-right: 20px; padding-top: 10px; "">
                    <div class=""b-grid-top"">
                        <h3 style=""margin-bottom: 15px; margin-top: 15px; padding:15px; background-color:crimson; color:aliceblue; border-radius:5px"">
                            <i class=""fas fa-angle-double-right""></i> ");
#nullable restore
#line 29 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDetails.cshtml"
                                                                 Write(Model.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h3>\r\n                        <div class=\"blog_info_left_grid\">\r\n\r\n     <img");
            BeginWriteAttribute("src", " src=\"", 1106, "\"", 1141, 2);
            WriteAttributeValue("", 1112, "/images/", 1112, 8, true);
#nullable restore
#line 33 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDetails.cshtml"
WriteAttributeValue("", 1120, Model.BloglImageName, 1120, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 1160, "\"", 1182, 1);
#nullable restore
#line 33 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDetails.cshtml"
WriteAttributeValue("", 1166, Model.BlogTitle, 1166, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" width=""730"" style=""border-radius: 10px;"">

                        </div>
                        <div class=""blog-info-middle"">
                            <ul>
                                <li>
                                    <a href=""#"" style=""margin-right:20px"">
                                        <i class=""far fa-calendar-alt""> </i>");
#nullable restore
#line 40 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDetails.cshtml"
                                                                       Write(Model.BlogCreateContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </li>\r\n\r\n                                <li>\r\n                                    <a href=\"#\">\r\n                                        <i class=\"far fa-comment\"> </i> ");
#nullable restore
#line 46 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDetails.cshtml"
                                                                   Write(Model.CommentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </li>\r\n\r\n                            </ul>\r\n                        </div>\r\n                    </div>\r\n\r\n                    <p style=\"color:black;  \">\r\n                        ");
#nullable restore
#line 55 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDetails.cshtml"
                   Write(Html.Raw(Model.BlogContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n\r\n                </div>\r\n\r\n");
            WriteLiteral("                <div class=\"comment-top\" style=\"padding:20px;\">\r\n                    <h3>YORUMLAR</h3>\r\n                    <hr />\r\n\r\n");
#nullable restore
#line 65 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDetails.cshtml"
                     foreach (var yorum in ViewBag.yorumSirala)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"media\">\r\n\r\n                            <div class=\"media-body\">\r\n                                <b style=\"color:brown\">");
#nullable restore
#line 70 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDetails.cshtml"
                                                  Write(yorum.CommentTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b><br />\r\n\r\n\r\n                                ");
#nullable restore
#line 73 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDetails.cshtml"
                           Write(yorum.CommentContent);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n\r\n                                <i style=\"color:dimgrey; font-size:smaller\"><b>");
#nullable restore
#line 75 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDetails.cshtml"
                                                                          Write(yorum.CommentUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>   ");
#nullable restore
#line 75 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDetails.cshtml"
                                                                                                        Write(((DateTime)yorum.CommentDate).ToString("dd-MM-yyyy HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n\r\n                                <hr />\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 80 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDetails.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <!--//yorum sat??r?? bitti-->


                <div class=""comment-top"" style=""padding:20px; "">
                    <h4>Bir Yorum Yap??n</h4>
                    <div class=""comment-bottom"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8a5126da53fb6f01cd7492c95627eb400f7781610705", async() => {
                WriteLiteral("\r\n                            <input class=\"form-control\" type=\"text\" name=\"CommentUserName\" pattern=\"[A-Za-z\\s]+\" title=\"Sadece Harf Kullan??n??z...\" placeholder=\"Ad??n??z Soyad??n??z\"");
                BeginWriteAttribute("required", " required=\"", 3483, "\"", 3494, 0);
                EndWriteAttribute();
                WriteLiteral(" style=\"color: dimgrey\">\r\n\r\n\r\n                            <input class=\"form-control\" type=\"text\" name=\"CommentTitle\" pattern=\"[A-Za-z0-9\\s]+\" title=\"Sadece Harf ve Rakam Kullan??n??z...\" placeholder=\"Ba??l??k\"");
                BeginWriteAttribute("required", " required=\"", 3701, "\"", 3712, 0);
                EndWriteAttribute();
                WriteLiteral(" style=\"color: dimgrey;\">\r\n\r\n                            <input class=\"form-control\" type=\"hidden\" name=\"BLogID\"");
                BeginWriteAttribute("value", "   value=\"", 3825, "\"", 3848, 1);
#nullable restore
#line 94 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDetails.cshtml"
WriteAttributeValue("", 3835, Model.BlogID, 3835, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n                            <textarea class=\"form-control\" name=\"CommentContent\"  placeholder=\"Mesaj...\"");
                BeginWriteAttribute("required", " required=\"", 3958, "\"", 3969, 0);
                EndWriteAttribute();
                WriteLiteral(" style=\"color: dimgrey;\"></textarea>\r\n\r\n                            <label>Toplama ????lemini Yap??n??z: ");
#nullable restore
#line 98 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDetails.cshtml"
                                                        Write(s1);

#line default
#line hidden
#nullable disable
                WriteLiteral(" + ");
#nullable restore
#line 98 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDetails.cshtml"
                                                              Write(s2);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" =?</label>

                            <input class=""form-control"" type=""text"" id=""kullanici_sonuc"" name=""kullanici_sonuc"" pattern=""[0-9]*"" title=""Sadece Rakam Kullan??n??z..."" style=""color: dimgrey;"" />
                            <input class=""form-control"" type=""hidden"" id=""gercekSonuc""");
                BeginWriteAttribute("value", " value=\"", 4373, "\"", 4387, 1);
#nullable restore
#line 101 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDetails.cshtml"
WriteAttributeValue("", 4381, sonuc, 4381, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />

                            <i style=""color: dimgrey;font-size:smaller"">
                                *Yorumunuz yap??ld??????nda IP adresiniz sistemimize kaydedilir.
                                L??tfen hakaret, k??f??r ve rencide edici s??zlerden ka????n??n??z.
                            </i> <br />
                            <button type=""submit"" id=""yorumEkle"" name=""yorumEkle"" class=""btn btn-primary submit"">G??NDER</button>

                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                        <br />
                    </div>
                </div>

            </div>

            <!--//left-->
            <!--right- kategori sirala-->
            <aside class=""col-lg-4 agileits-w3ls-right-blog-con text-right"">
                <div class=""right-blog-info text-left"">

                    ");
#nullable restore
#line 122 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDetails.cshtml"
               Write(await Component.InvokeAsync("CategoryList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    ");
#nullable restore
#line 124 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDetails.cshtml"
               Write(await Component.InvokeAsync("BlogListFromWriter", Model.BlogID));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                </div>




            </aside>
            <!--//right-->
        </div>
    </div>
</section>
<!--//main-->

<script type=""text/javascript"">
 
    function sayiDogrula(e) {

        const sonucAl = document.getElementById(""kullanici_sonuc"").value;

        var gercekSonucAl = document.getElementById(""gercekSonuc"").value;

        if (sonucAl != gercekSonucAl) {

            alert(""Toplamay?? Yanl???? Yapt??n??z! Yorum Eklenemedi..."");
            e.preventDefault();
            e.stopPropagation();
        } else {
           /* alert(""Yorumunuz Ba??ar??l?? Bir ??ekilde Kay??t Edildi. Kontrol Edildikten Sonra Yay??nlanacakt??r!"")*/
        }
    }

    document.getElementById(""yorumEkle"").addEventListener(""click"", sayiDogrula)
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
