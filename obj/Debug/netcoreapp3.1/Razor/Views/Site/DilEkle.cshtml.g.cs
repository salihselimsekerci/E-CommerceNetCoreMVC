#pragma checksum "C:\Users\Salih Selim Sekerci\source\repos\NetCore\NetCore\Views\Site\DilEkle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b608acd7800656fcfe0d934a3203ba4f0cb597f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Site_DilEkle), @"mvc.1.0.view", @"/Views/Site/DilEkle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b608acd7800656fcfe0d934a3203ba4f0cb597f6", @"/Views/Site/DilEkle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68c593e2973db2472dd8ea7ea162ebc292929aa7", @"/Views/_ViewImports.cshtml")]
    public class Views_Site_DilEkle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Site", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DilEkle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b608acd7800656fcfe0d934a3203ba4f0cb597f65573", async() => {
                WriteLiteral("\r\n    <title>Dil Ekle</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b608acd7800656fcfe0d934a3203ba4f0cb597f66570", async() => {
                WriteLiteral(@"
    <div id=""layoutAuthentication"">
        <div id=""layoutAuthentication_content"">
            <main>
                <div class=""container"">
                    <div class=""row justify-content-center"">
                        <div class=""col-lg-5"">
                            <div class=""card shadow-lg border-0 rounded-lg mt-5"">
                                <div class=""card-header""><h3 class=""text-center font-weight-light my-4"">Dil Ekle:</h3></div>
                                <div class=""card-body"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b608acd7800656fcfe0d934a3203ba4f0cb597f67404", async() => {
                    WriteLiteral(@"
                                        <div class=""form-group"">

                                            <label class=""small mb-1"">Dil Adi:</label>
                                            <input class=""form-control py-4"" name=""Adi"" id=""Adi"" type=""text"" placeholder=""Türkçe"" />

                                            <label class=""small mb-1"">Hesap:</label>
                                            <input class=""form-control py-4"" name=""Hesap"" id=""Hesap"" type=""text"" placeholder=""Hesap"" />

                                            <label class=""small mb-1"">Ürün Listesi:</label>
                                            <input class=""form-control py-4"" name=""UrunListesi"" id=""UrunListesi"" type=""text"" placeholder=""Ürün Listesi"" />

                                            <label class=""small mb-1"">Sepetim:</label>
                                            <input class=""form-control py-4"" name=""Sepetim"" id=""Sepetim"" type=""text"" placeholder=""Sepetim"" />

                     ");
                    WriteLiteral(@"                       <label class=""small mb-1"">İletisim:</label>
                                            <input class=""form-control py-4"" name=""Iletisim"" id=""Iletisim"" type=""text"" placeholder=""İletisim"" />

                                            <label class=""small mb-1"">Kategoriler:</label>
                                            <input class=""form-control py-4"" name=""Kategoriler"" id=""Kategoriler"" type=""text"" placeholder=""Kategoriler"" />

                                            <label class=""small mb-1"">Giriş Yap:</label>
                                            <input class=""form-control py-4"" name=""GirisYap"" id=""GirisYap"" type=""text"" placeholder=""Giriş Yap"" />

                                            <label class=""small mb-1"">Çıkış Yap:</label>
                                            <input class=""form-control py-4"" name=""CikisYap"" id=""CikisYap"" type=""text"" placeholder=""Çıkış Yap"" />

                                            <label class=""small mb-1"">30 Gün için");
                    WriteLiteral(@"de İade:</label>
                                            <input class=""form-control py-4"" name=""Iade"" id=""Iade"" type=""text"" placeholder=""30 Gün içinde İade"" />

                                            <label class=""small mb-1"">Ücretsiz Kargo:</label>
                                            <input class=""form-control py-4"" name=""UcretsizKargo"" id=""UcretsizKargo"" type=""text"" placeholder=""Ücretsiz Kargo"" />

                                            <label class=""small mb-1"">Güvenli Alışveriş:</label>
                                            <input class=""form-control py-4"" name=""GuvenliAlisveris"" id=""GuvenliAlisveris"" type=""text"" placeholder=""Güvenli Alışveriş"" />

                                            <label class=""small mb-1"">Yeni Ürünler:</label>
                                            <input class=""form-control py-4"" name=""YeniUrunler"" id=""YeniUrunler"" type=""text"" placeholder=""Yeni Ürünler"" />

                                            <label class=""small mb-1"">En Ço");
                    WriteLiteral(@"k Satan:</label>
                                            <input class=""form-control py-4"" name=""EnCokSatan"" id=""EnCokSatan"" type=""text"" placeholder=""En Çok Satan"" />
                                            <label class=""small mb-1"">En Çok Görüntülenen:</label>
                                            <input class=""form-control py-4"" name=""EnCokGoruntulenen"" id=""EnCokGoruntulenen"" type=""text"" placeholder=""En Çok Görüntülenen"" />
                                            <label class=""small mb-1"">En Yeni:</label>
                                            <input class=""form-control py-4"" name=""EnYeni"" id=""EnYeni"" type=""text"" placeholder=""En Yeni"" />


                                        </div>

                                        <div class=""form-group d-flex align-items-center justify-content-between mt-4 mb-0"">
                                            <input class=""btn btn-primary"" type=""submit"" value=""Ekle"" />
                                        </div>
              ");
                    WriteLiteral("                      ");
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
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"card-footer text-center\">\r\n\r\n                                    <div class=\"small\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b608acd7800656fcfe0d934a3203ba4f0cb597f614056", async() => {
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