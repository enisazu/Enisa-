#pragma checksum "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shared\Components\MainContentArea\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e7c413ad0fd914bd99b62b2eee5208d2bfa3a75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MainContentArea_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MainContentArea/Default.cshtml")]
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
#line 1 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\_ViewImports.cshtml"
using Eticaret.Presentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\_ViewImports.cshtml"
using Eticaret.Presentation.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shared\Components\MainContentArea\Default.cshtml"
using Eticaret.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e7c413ad0fd914bd99b62b2eee5208d2bfa3a75", @"/Views/Shared/Components/MainContentArea/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b11e296975fd3811b136a67feaa7e5a9cfb980bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MainContentArea_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductImagesCustomModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""maincontent-area"">
    <div class=""zigzag-bottom""></div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""latest-product"">
                    <h2 class=""section-title"">Latest Products</h2>
                    <div class=""product-carousel"">

");
#nullable restore
#line 12 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shared\Components\MainContentArea\Default.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"single-product\">\r\n                                <div class=\"product-f-image\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 639, "\"", 665, 2);
            WriteAttributeValue("", 645, "/product/", 645, 9, true);
#nullable restore
#line 16 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shared\Components\MainContentArea\Default.cshtml"
WriteAttributeValue("", 654, item.Image, 654, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 666, "\"", 672, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div class=\"product-hover\">\r\n                                        <a class=\"add-to-cart-link\"");
            BeginWriteAttribute("onclick", " onclick=\"", 808, "\"", 839, 3);
            WriteAttributeValue("", 818, "AddBasket(1,", 818, 12, true);
#nullable restore
#line 18 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shared\Components\MainContentArea\Default.cshtml"
WriteAttributeValue("", 830, item.Id, 830, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 838, ")", 838, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-shopping-cart\"></i> Add to cart</a>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 936, "\"", 962, 2);
            WriteAttributeValue("", 943, "/urun/", 943, 6, true);
#nullable restore
#line 19 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shared\Components\MainContentArea\Default.cshtml"
WriteAttributeValue("", 949, item.SeoName, 949, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"view-details-link\"><i class=\"fa fa-link\"></i> See details</a>\r\n                                    </div>\r\n                                </div>\r\n\r\n                                <h2><a");
            BeginWriteAttribute("href", " href=\"", 1158, "\"", 1184, 2);
            WriteAttributeValue("", 1165, "/urun/", 1165, 6, true);
#nullable restore
#line 23 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shared\Components\MainContentArea\Default.cshtml"
WriteAttributeValue("", 1171, item.SeoName, 1171, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 23 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shared\Components\MainContentArea\Default.cshtml"
                                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n\r\n                                <div class=\"product-carousel-price\">\r\n                                    <ins>");
#nullable restore
#line 26 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shared\Components\MainContentArea\Default.cshtml"
                                    Write(item.Price.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</ins> <del>$1.0</del>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 29 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shared\Components\MainContentArea\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div> <!-- End main content area -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductImagesCustomModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
