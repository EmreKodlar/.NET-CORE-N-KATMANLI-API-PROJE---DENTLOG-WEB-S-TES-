#pragma checksum "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Write\WriterUpdate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55522aa0343eb5af595d4267936afe470b32bef4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Write_WriterUpdate), @"mvc.1.0.view", @"/Views/Write/WriterUpdate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55522aa0343eb5af595d4267936afe470b32bef4", @"/Views/Write/WriterUpdate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb7badf436513dd8c97ff44224df8e763842534d", @"/Views/_ViewImports.cshtml")]
    public class Views_Write_WriterUpdate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NetCore_PROJE.Controllers.ClassWrite>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "True", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "False", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Write/WriterUpdate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("Api_ile_Guncelleme"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Write\WriterUpdate.cshtml"
  
    ViewData["Title"] = "Yazar Güncelleme Sayfası";
    Layout = "~/Views/Shared/Writer_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>");
#nullable restore
#line 6 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Write\WriterUpdate.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55522aa0343eb5af595d4267936afe470b32bef46230", async() => {
                WriteLiteral("\r\n    <input name=\"WriterID\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 334, "\"", 357, 1);
#nullable restore
#line 8 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Write\WriterUpdate.cshtml"
WriteAttributeValue("", 342, Model.WriterID, 342, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n    <label>Yazar Adı:</label><br />\r\n    <input");
                BeginWriteAttribute("value", " value=\"", 416, "\"", 441, 1);
#nullable restore
#line 10 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Write\WriterUpdate.cshtml"
WriteAttributeValue("", 424, Model.WriterName, 424, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"WriterName\" type=\"text\" class=\"form-control\" style=\" min-width:100%\" required />\r\n    <br />\r\n    <label>Yazar Durumu:</label><br />\r\n    <select name=\"WriterStatus\" class=\"form-control\" style=\"min-width:100%\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55522aa0343eb5af595d4267936afe470b32bef47604", async() => {
                    WriteLiteral("Aktif");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55522aa0343eb5af595d4267936afe470b32bef48834", async() => {
                    WriteLiteral("Pasif");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Write\WriterUpdate.cshtml"
         if (Model.WriterStatus == true)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55522aa0343eb5af595d4267936afe470b32bef410311", async() => {
                    WriteLiteral("Aktif");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("  ");
#nullable restore
#line 17 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Write\WriterUpdate.cshtml"
                                                                    }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55522aa0343eb5af595d4267936afe470b32bef411916", async() => {
                    WriteLiteral("Pasif");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" ");
#nullable restore
#line 19 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Write\WriterUpdate.cshtml"
                                                                   } 

#line default
#line hidden
#nullable disable
                WriteLiteral("    </select> \r\n    <br />\r\n    <label>Yazar Şifresi:</label><br />\r\n    <input name=\"WriterPassword\"");
                BeginWriteAttribute("value", " value=\"", 1051, "\"", 1080, 1);
#nullable restore
#line 23 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Write\WriterUpdate.cshtml"
WriteAttributeValue("", 1059, Model.WriterPassword, 1059, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"password\" class=\"form-control\" style=\"  min-width:100%\" required readonly/><br />\r\n    <label>Yazar Maili:</label><br />\r\n    <input name=\"WriterMail\" type=\"email\" class=\"form-control\" style=\"min-width:100%\"");
                BeginWriteAttribute("value", " value=\"", 1295, "\"", 1320, 1);
#nullable restore
#line 25 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Write\WriterUpdate.cshtml"
WriteAttributeValue("", 1303, Model.WriterMail, 1303, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required /><br />\r\n    <label>Yazar Hakkında:</label><br />\r\n    <textarea name=\"WriterAbout\" minlength=\"20\" class=\"form-control\" style=\"  min-width:100%\" required>");
#nullable restore
#line 27 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Write\WriterUpdate.cshtml"
                                                                                                  Write(Model.WriterAbout);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</textarea><br />
    <label>Yazar Fotoğrafı:</label><br />
    <input name=""WriterImage"" id=""WriterImage"" type=""file"" class=""form-control"" style=""  min-width:100%"" /><br />
    *Fotoğrafı Güncellemeyecekseniz, bu kısmı boş geçebilirsiniz...<br /><br />
    <label><b>Mevcut Fotoğraf:</b></label><br />
    <img");
                BeginWriteAttribute("src", " src=\"", 1820, "\"", 1856, 2);
                WriteAttributeValue("", 1826, "/images/", 1826, 8, true);
#nullable restore
#line 32 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Write\WriterUpdate.cshtml"
WriteAttributeValue("", 1834, Model.WriterImageName, 1834, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br /><br />\r\n    <input name=\"WriterImageName\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1921, "\"", 1951, 1);
#nullable restore
#line 33 "C:\PROJELER\asp.netCore\NetCore_PROJE\NetCore_PROJE\Views\Write\WriterUpdate.cshtml"
WriteAttributeValue("", 1929, Model.WriterImageName, 1929, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <button class=\"btn btn-success\" style=\"margin-right:10px\">GÜNCELLE</button>\r\n    <button class=\"btn btn-danger\" data-dismiss=\"modal\" action=\"/Write/IndexWrite\">VAZGEÇ</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NetCore_PROJE.Controllers.ClassWrite> Html { get; private set; }
    }
}
#pragma warning restore 1591