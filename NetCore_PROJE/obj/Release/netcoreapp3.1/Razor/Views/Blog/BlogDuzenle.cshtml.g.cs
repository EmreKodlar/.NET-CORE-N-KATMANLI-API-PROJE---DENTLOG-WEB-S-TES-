#pragma checksum "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDuzenle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c4fc9eeae27fce7b57c0e82917fe75bb3646972"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogDuzenle), @"mvc.1.0.view", @"/Views/Blog/BlogDuzenle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c4fc9eeae27fce7b57c0e82917fe75bb3646972", @"/Views/Blog/BlogDuzenle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb7badf436513dd8c97ff44224df8e763842534d", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogDuzenle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/ckeditor/jquery/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/ckeditor/ckeditor.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/ckeditor/ckeditorJS.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Blog/BlogDuzenle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Blog/BlogDuzenleFoto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDuzenle.cshtml"
  
    ViewData["Title"] = "Blog Düzenleme Paneli";
    Layout = "~/Views/Shared/Writer_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c4fc9eeae27fce7b57c0e82917fe75bb36469726468", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c4fc9eeae27fce7b57c0e82917fe75bb36469727507", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c4fc9eeae27fce7b57c0e82917fe75bb36469728629", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<h3>Blog Düzenleme Paneli</h3>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c4fc9eeae27fce7b57c0e82917fe75bb36469729706", async() => {
                WriteLiteral("\r\n    <br />");
                WriteLiteral("    <input class=\"form-control\" type=\"text\" name=\"BlogTitle\" required");
                BeginWriteAttribute("value", " value=\"", 520, "\"", 544, 1);
#nullable restore
#line 13 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDuzenle.cshtml"
WriteAttributeValue("", 528, Model.BlogTitle, 528, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n    ");
#nullable restore
#line 14 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDuzenle.cshtml"
Write(Html.DropDownListFor(m => m.CategoryID, ViewBag.kategoriler as SelectList, new { @class = "form-control", required = "required" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    <textarea id=\"editor1\" class=\"form-control\" minlength=\"130\" rows=\"10\" name=\"BlogContent\" required>");
#nullable restore
#line 16 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDuzenle.cshtml"
                                                                                                 Write(Model.BlogContent);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n    <input class=\"form-control\" type=\"hidden\" name=\"BlogThumbnailImageName\"");
                BeginWriteAttribute("value", " value=\"", 913, "\"", 942, 1);
#nullable restore
#line 17 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDuzenle.cshtml"
WriteAttributeValue("", 921, Model.BloglImageName, 921, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input class=\"form-control\" type=\"hidden\" name=\"BloglImageName\"");
                BeginWriteAttribute("value", " value=\"", 1015, "\"", 1044, 1);
#nullable restore
#line 18 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDuzenle.cshtml"
WriteAttributeValue("", 1023, Model.BloglImageName, 1023, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input class=\"form-control\" type=\"hidden\" name=\"BlogStatus\" value=\"True\" />\r\n    <input class=\"form-control\" type=\"hidden\" name=\"BlogCreateContent\"");
                BeginWriteAttribute("value", " value=\"", 1201, "\"", 1233, 1);
#nullable restore
#line 20 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDuzenle.cshtml"
WriteAttributeValue("", 1209, Model.BlogCreateContent, 1209, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input class=\"form-control\" type=\"hidden\" name=\"WriterID\"");
                BeginWriteAttribute("value", " value=\"", 1300, "\"", 1326, 1);
#nullable restore
#line 21 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDuzenle.cshtml"
WriteAttributeValue("", 1308, ViewBag.Writer_ID, 1308, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input class=\"form-control\" type=\"hidden\" name=\"BlogID\"");
                BeginWriteAttribute("value", " value=\"", 1391, "\"", 1412, 1);
#nullable restore
#line 22 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDuzenle.cshtml"
WriteAttributeValue("", 1399, Model.BlogID, 1399, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n    <button class=\"btn btn-primary\">GÜNCELLE</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br />\r\nBloğun Şu anki Resmi:\r\n<br />\r\n<img");
            BeginWriteAttribute("src", " src=\"", 1537, "\"", 1572, 2);
            WriteAttributeValue("", 1543, "/images/", 1543, 8, true);
#nullable restore
#line 29 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDuzenle.cshtml"
WriteAttributeValue("", 1551, Model.BloglImageName, 1551, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"200\" style=\"align-self:start\" />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c4fc9eeae27fce7b57c0e82917fe75bb364697215571", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("    <br />\r\n    <input class=\"form-control\" type=\"file\" name=\"BloglImage\" required />\r\n");
                WriteLiteral("    <input class=\"form-control\" type=\"hidden\" name=\"CategoryID\"");
                BeginWriteAttribute("value", " value=\"", 1989, "\"", 2014, 1);
#nullable restore
#line 35 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDuzenle.cshtml"
WriteAttributeValue("", 1997, Model.CategoryID, 1997, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input class=\"form-control\" type=\"hidden\" name=\"WriterID\"");
                BeginWriteAttribute("value", " value=\"", 2081, "\"", 2107, 1);
#nullable restore
#line 36 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDuzenle.cshtml"
WriteAttributeValue("", 2089, ViewBag.Writer_ID, 2089, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input class=\"form-control\" type=\"hidden\" name=\"BlogID\"");
                BeginWriteAttribute("value", " value=\"", 2172, "\"", 2193, 1);
#nullable restore
#line 37 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDuzenle.cshtml"
WriteAttributeValue("", 2180, Model.BlogID, 2180, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input class=\"form-control\" type=\"hidden\" name=\"BlogCreateContent\"");
                BeginWriteAttribute("value", " value=\"", 2269, "\"", 2301, 1);
#nullable restore
#line 38 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDuzenle.cshtml"
WriteAttributeValue("", 2277, Model.BlogCreateContent, 2277, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input class=\"form-control\" type=\"hidden\" name=\"BlogContent\"");
                BeginWriteAttribute("value", " value=\"", 2371, "\"", 2397, 1);
#nullable restore
#line 39 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDuzenle.cshtml"
WriteAttributeValue("", 2379, Model.BlogContent, 2379, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input class=\"form-control\" type=\"hidden\" name=\"BlogTitle\"");
                BeginWriteAttribute("value", " value=\"", 2465, "\"", 2489, 1);
#nullable restore
#line 40 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Blog\BlogDuzenle.cshtml"
WriteAttributeValue("", 2473, Model.BlogTitle, 2473, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input class=\"form-control\" type=\"hidden\" name=\"BlogStatus\" value=\"True\" />\r\n");
                WriteLiteral("    <br />\r\n    <button class=\"btn btn-danger\">RESMİ GÜNCELLE</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<script>\r\n    $(document).ready(function () {\r\n        CKEDITOR.replace(\'editor1\', {\r\n            customConfig: \'/ckeditor/Config.js\'\r\n        });\r\n    });\r\n</script>\r\n");
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