#pragma checksum "C:\Users\Salih Selim Sekerci\source\repos\NetCore\NetCore\Views\Site\DilDuzenle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fafa27a4a0c2579d8b0f7571d4833230854f1a13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Site_DilDuzenle), @"mvc.1.0.view", @"/Views/Site/DilDuzenle.cshtml")]
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
#line 1 "C:\Users\Salih Selim Sekerci\source\repos\NetCore\NetCore\Views\_ViewImports.cshtml"
using NetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Salih Selim Sekerci\source\repos\NetCore\NetCore\Views\_ViewImports.cshtml"
using NetCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fafa27a4a0c2579d8b0f7571d4833230854f1a13", @"/Views/Site/DilDuzenle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68c593e2973db2472dd8ea7ea162ebc292929aa7", @"/Views/_ViewImports.cshtml")]
    public class Views_Site_DilDuzenle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Site", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DilDuzenle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Panel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fafa27a4a0c2579d8b0f7571d4833230854f1a135591", async() => {
                WriteLiteral("\r\n    <title>Dil Düzenle</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fafa27a4a0c2579d8b0f7571d4833230854f1a136591", async() => {
                WriteLiteral(@"
    <div id=""layoutAuthentication"">
        <div id=""layoutAuthentication_content"">
            <main>
                <div class=""container"">
                    <div class=""row justify-content-center"">
                        <div class=""col-lg-5"">
                            <div class=""card shadow-lg border-0 rounded-lg mt-5"">
                                <div class=""card-header""><h3 class=""text-center font-weight-light my-4"">Dil Duzenle:</h3></div>
                                <div class=""card-body"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fafa27a4a0c2579d8b0f7571d4833230854f1a137428", async() => {
                    WriteLiteral(@"
                                        <div class=""form-group"">


                                            <label class=""small mb-1"">Dil Adi:</label>
                                            <input class=""form-control py-4"" name=""Adi"" id=""Adi"" type=""text"" placeholder=""Türkçe""");
                    BeginWriteAttribute("value", " value=\"", 1084, "\"", 1110, 1);
#nullable restore
#line 25 "C:\Users\Salih Selim Sekerci\source\repos\NetCore\NetCore\Views\Site\DilDuzenle.cshtml"
WriteAttributeValue("", 1092, ViewBag.Gelen.Adi, 1092, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n\r\n                                            <label class=\"small mb-1\">Hesap:</label>\r\n                                            <input class=\"form-control py-4\" name=\"Hesap\" id=\"Hesap\" type=\"text\" placeholder=\"Hesap\"");
                    BeginWriteAttribute("value", " value=\"", 1336, "\"", 1364, 1);
#nullable restore
#line 28 "C:\Users\Salih Selim Sekerci\source\repos\NetCore\NetCore\Views\Site\DilDuzenle.cshtml"
WriteAttributeValue("", 1344, ViewBag.Gelen.Hesap, 1344, 20, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n\r\n                                            <label class=\"small mb-1\">Ürün Listesi:</label>\r\n                                            <input class=\"form-control py-4\" name=\"UrunListesi\" id=\"UrunListesi\" type=\"text\" placeholder=\"Ürün Listesi\"");
                    BeginWriteAttribute("value", " value=\"", 1616, "\"", 1650, 1);
#nullable restore
#line 31 "C:\Users\Salih Selim Sekerci\source\repos\NetCore\NetCore\Views\Site\DilDuzenle.cshtml"
WriteAttributeValue("", 1624, ViewBag.Gelen.UrunListesi, 1624, 26, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n\r\n                                            <label class=\"small mb-1\">Sepetim:</label>\r\n                                            <input class=\"form-control py-4\" name=\"Sepetim\" id=\"Sepetim\" type=\"text\" placeholder=\"Sepetim\"");
                    BeginWriteAttribute("value", "  value=\"", 1884, "\"", 1915, 1);
#nullable restore
#line 34 "C:\Users\Salih Selim Sekerci\source\repos\NetCore\NetCore\Views\Site\DilDuzenle.cshtml"
WriteAttributeValue("", 1893, ViewBag.Gelen.Sepetim, 1893, 22, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n\r\n                                            <label class=\"small mb-1\">İletisim:</label>\r\n                                            <input class=\"form-control py-4\" name=\"Iletisim\" id=\"Iletisim\" type=\"text\" placeholder=\"İletisim\"");
                    BeginWriteAttribute("value", "  value=\"", 2153, "\"", 2185, 1);
#nullable restore
#line 37 "C:\Users\Salih Selim Sekerci\source\repos\NetCore\NetCore\Views\Site\DilDuzenle.cshtml"
WriteAttributeValue("", 2162, ViewBag.Gelen.Iletisim, 2162, 23, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n\r\n                                            <label class=\"small mb-1\">Kategoriler:</label>\r\n                                            <input class=\"form-control py-4\" name=\"Kategoriler\" id=\"Kategoriler\" type=\"text\" placeholder=\"Kategoriler\"");
                    BeginWriteAttribute("value", " value=\"", 2435, "\"", 2469, 1);
#nullable restore
#line 40 "C:\Users\Salih Selim Sekerci\source\repos\NetCore\NetCore\Views\Site\DilDuzenle.cshtml"
WriteAttributeValue("", 2443, ViewBag.Gelen.Kategoriler, 2443, 26, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n\r\n                                            <label class=\"small mb-1\">Giriş Yap:</label>\r\n                                            <input class=\"form-control py-4\" name=\"GirisYap\" id=\"GirisYap\" type=\"text\" placeholder=\"Giriş Yap\"");
                    BeginWriteAttribute("value", " value=\"", 2709, "\"", 2740, 1);
#nullable restore
#line 43 "C:\Users\Salih Selim Sekerci\source\repos\NetCore\NetCore\Views\Site\DilDuzenle.cshtml"
WriteAttributeValue("", 2717, ViewBag.Gelen.GirisYap, 2717, 23, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n\r\n                                            <label class=\"small mb-1\">Çıkış Yap:</label>\r\n                                            <input class=\"form-control py-4\" name=\"CikisYap\" id=\"CikisYap\" type=\"text\" placeholder=\"Çıkış Yap\"");
                    BeginWriteAttribute("value", " value=\"", 2980, "\"", 3011, 1);
#nullable restore
#line 46 "C:\Users\Salih Selim Sekerci\source\repos\NetCore\NetCore\Views\Site\DilDuzenle.cshtml"
WriteAttributeValue("", 2988, ViewBag.Gelen.CikisYap, 2988, 23, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n\r\n                                            <label class=\"small mb-1\">İade:</label>\r\n                                            <input class=\"form-control py-4\" name=\"Iade\" id=\"Iade\" type=\"text\" placeholder=\"İade\"");
                    BeginWriteAttribute("value", "  value=\"", 3233, "\"", 3261, 1);
#nullable restore
#line 49 "C:\Users\Salih Selim Sekerci\source\repos\NetCore\NetCore\Views\Site\DilDuzenle.cshtml"
WriteAttributeValue("", 3242, ViewBag.Gelen.Iade, 3242, 19, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" />

                                            <label class=""small mb-1"">Ücretsiz Kargo:</label>
                                            <input class=""form-control py-4"" name=""UcretsizKargo"" id=""UcretsizKargo"" type=""text"" placeholder=""Ücretsiz Kargo""");
                    BeginWriteAttribute("value", "  value=\"", 3521, "\"", 3558, 1);
#nullable restore
#line 52 "C:\Users\Salih Selim Sekerci\source\repos\NetCore\NetCore\Views\Site\DilDuzenle.cshtml"
WriteAttributeValue("", 3530, ViewBag.Gelen.UcretsizKargo, 3530, 28, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" />

                                            <label class=""small mb-1"">Güvenli Alışveriş:</label>
                                            <input class=""form-control py-4"" name=""GuvenliAlisveris"" id=""GuvenliAlisveris"" type=""text"" placeholder=""Güvenli Alışveriş""");
                    BeginWriteAttribute("value", " value=\"", 3830, "\"", 3869, 1);
#nullable restore
#line 55 "C:\Users\Salih Selim Sekerci\source\repos\NetCore\NetCore\Views\Site\DilDuzenle.cshtml"
WriteAttributeValue("", 3838, ViewBag.Gelen.GuvenliAlisveris, 3838, 31, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n\r\n                                            <label class=\"small mb-1\">Yeni Ürünler:</label>\r\n                                            <input class=\"form-control py-4\" name=\"YeniUrunler\" id=\"YeniUrunler\" type=\"text\" placeholder=\"Yeni Ürünler\"");
                    BeginWriteAttribute("value", "  value=\"", 4121, "\"", 4156, 1);
#nullable restore
#line 58 "C:\Users\Salih Selim Sekerci\source\repos\NetCore\NetCore\Views\Site\DilDuzenle.cshtml"
WriteAttributeValue("", 4130, ViewBag.Gelen.YeniUrunler, 4130, 26, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n\r\n                                            <label class=\"small mb-1\">En Çok Satan:</label>\r\n                                            <input class=\"form-control py-4\" name=\"EnCokSatan\" id=\"EnCokSatan\" type=\"text\" placeholder=\"En Çok Satan\"");
                    BeginWriteAttribute("value", " value=\"", 4406, "\"", 4439, 1);
#nullable restore
#line 61 "C:\Users\Salih Selim Sekerci\source\repos\NetCore\NetCore\Views\Site\DilDuzenle.cshtml"
WriteAttributeValue("", 4414, ViewBag.Gelen.EnCokSatan, 4414, 25, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" />
                                            <label class=""small mb-1"">En Çok Görüntülenen:</label>
                                            <input class=""form-control py-4"" name=""EnCokGoruntulenen"" id=""EnCokGoruntulenen"" type=""text"" placeholder=""En Çok Görüntülenen""");
                    BeginWriteAttribute("value", " value=\"", 4715, "\"", 4755, 1);
#nullable restore
#line 63 "C:\Users\Salih Selim Sekerci\source\repos\NetCore\NetCore\Views\Site\DilDuzenle.cshtml"
WriteAttributeValue("", 4723, ViewBag.Gelen.EnCokGoruntulenen, 4723, 32, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                                            <label class=\"small mb-1\">En Yeni:</label>\r\n                                            <input class=\"form-control py-4\" name=\"EnYeni\" id=\"EnYeni\" type=\"text\" placeholder=\"En Yeni\"");
                    BeginWriteAttribute("value", " value=\"", 4985, "\"", 5014, 1);
#nullable restore
#line 65 "C:\Users\Salih Selim Sekerci\source\repos\NetCore\NetCore\Views\Site\DilDuzenle.cshtml"
WriteAttributeValue("", 4993, ViewBag.Gelen.EnYeni, 4993, 21, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" />


                                        </div>

                                        <div class=""form-group d-flex align-items-center justify-content-between mt-4 mb-0"">
                                            <input class=""btn btn-primary"" type=""submit"" value=""Ekle"" />
                                        </div>
                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "C:\Users\Salih Selim Sekerci\source\repos\NetCore\NetCore\Views\Site\DilDuzenle.cshtml"
                                                                                                        WriteLiteral(ViewBag.Gelen.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"card-footer text-center\">\r\n\r\n                                    <div class=\"small\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fafa27a4a0c2579d8b0f7571d4833230854f1a1321190", async() => {
                    WriteLiteral("Geri");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </main>
        </div>

    </div>
    <script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.bundle.min.js"" crossorigin=""anonymous""></script>
    <script src=""js/scripts.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n\r\n");
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
