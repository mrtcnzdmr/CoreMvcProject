#pragma checksum "C:\Users\dooms\OneDrive\Masaüstü\Murat Yücedağ-Asp.Net Core Mvc\CoreKitaplik\CoreKitaplik\Views\Shared\Components\YeniKitaplar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bc9d308b08ace9bc3842098ae0b4b8f48e63ac2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_YeniKitaplar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/YeniKitaplar/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bc9d308b08ace9bc3842098ae0b4b8f48e63ac2", @"/Views/Shared/Components/YeniKitaplar/Default.cshtml")]
    public class Views_Shared_Components_YeniKitaplar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreKitaplik.Models.Kitaplar>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>AD</th>\r\n        <th>YAZAR</th>\r\n    </tr>\r\n");
#nullable restore
#line 9 "C:\Users\dooms\OneDrive\Masaüstü\Murat Yücedağ-Asp.Net Core Mvc\CoreKitaplik\CoreKitaplik\Views\Shared\Components\YeniKitaplar\Default.cshtml"
     foreach (var k in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 12 "C:\Users\dooms\OneDrive\Masaüstü\Murat Yücedağ-Asp.Net Core Mvc\CoreKitaplik\CoreKitaplik\Views\Shared\Components\YeniKitaplar\Default.cshtml"
           Write(k.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 13 "C:\Users\dooms\OneDrive\Masaüstü\Murat Yücedağ-Asp.Net Core Mvc\CoreKitaplik\CoreKitaplik\Views\Shared\Components\YeniKitaplar\Default.cshtml"
           Write(k.KitapAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 14 "C:\Users\dooms\OneDrive\Masaüstü\Murat Yücedağ-Asp.Net Core Mvc\CoreKitaplik\CoreKitaplik\Views\Shared\Components\YeniKitaplar\Default.cshtml"
           Write(k.Yazar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 16 "C:\Users\dooms\OneDrive\Masaüstü\Murat Yücedağ-Asp.Net Core Mvc\CoreKitaplik\CoreKitaplik\Views\Shared\Components\YeniKitaplar\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreKitaplik.Models.Kitaplar>> Html { get; private set; }
    }
}
#pragma warning restore 1591
