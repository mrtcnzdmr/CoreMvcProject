#pragma checksum "C:\Users\dooms\OneDrive\Masaüstü\Murat Yücedağ-Asp.Net Core Mvc\CoreMvcProject\CoreMvcProject\Views\MyPersonal\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf274de14e70c64b5d11cb0ff7c5bebe743ec6e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyPersonal_Index), @"mvc.1.0.view", @"/Views/MyPersonal/Index.cshtml")]
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
#line 1 "C:\Users\dooms\OneDrive\Masaüstü\Murat Yücedağ-Asp.Net Core Mvc\CoreMvcProject\CoreMvcProject\Views\_ViewImports.cshtml"
using CoreMvcProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\dooms\OneDrive\Masaüstü\Murat Yücedağ-Asp.Net Core Mvc\CoreMvcProject\CoreMvcProject\Views\MyPersonal\Index.cshtml"
using CoreMvcProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf274de14e70c64b5d11cb0ff7c5bebe743ec6e5", @"/Views/MyPersonal/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18129d99b0726d8f9473a818c711dcc5ef26be2c", @"/Views/_ViewImports.cshtml")]
    public class Views_MyPersonal_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Personal>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\dooms\OneDrive\Masaüstü\Murat Yücedağ-Asp.Net Core Mvc\CoreMvcProject\CoreMvcProject\Views\MyPersonal\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-bordered"">
    <tr>
        <th>Personel Id</th>
        <th>Personel Ad</th>
        <th>Personel Soyad</th>
        <th>Personel Şehir</th>
        <th>Personel Birim</th>
        <th>Sil</th>
        <th>Güncelle</th>
    </tr>
");
#nullable restore
#line 18 "C:\Users\dooms\OneDrive\Masaüstü\Murat Yücedağ-Asp.Net Core Mvc\CoreMvcProject\CoreMvcProject\Views\MyPersonal\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\dooms\OneDrive\Masaüstü\Murat Yücedağ-Asp.Net Core Mvc\CoreMvcProject\CoreMvcProject\Views\MyPersonal\Index.cshtml"
           Write(item.PersonalId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\dooms\OneDrive\Masaüstü\Murat Yücedağ-Asp.Net Core Mvc\CoreMvcProject\CoreMvcProject\Views\MyPersonal\Index.cshtml"
           Write(item.PersonalFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\dooms\OneDrive\Masaüstü\Murat Yücedağ-Asp.Net Core Mvc\CoreMvcProject\CoreMvcProject\Views\MyPersonal\Index.cshtml"
           Write(item.PersonalLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\dooms\OneDrive\Masaüstü\Murat Yücedağ-Asp.Net Core Mvc\CoreMvcProject\CoreMvcProject\Views\MyPersonal\Index.cshtml"
           Write(item.PersonalCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\dooms\OneDrive\Masaüstü\Murat Yücedağ-Asp.Net Core Mvc\CoreMvcProject\CoreMvcProject\Views\MyPersonal\Index.cshtml"
           Write(item.Unit.UnitName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 700, "\"", 750, 2);
            WriteAttributeValue("", 707, "/MyPersonal/RemovePersonal/", 707, 27, true);
#nullable restore
#line 26 "C:\Users\dooms\OneDrive\Masaüstü\Murat Yücedağ-Asp.Net Core Mvc\CoreMvcProject\CoreMvcProject\Views\MyPersonal\Index.cshtml"
WriteAttributeValue("", 734, item.PersonalId, 734, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 807, "\"", 856, 2);
            WriteAttributeValue("", 814, "/MyPersonal/PersonalGetir/", 814, 26, true);
#nullable restore
#line 27 "C:\Users\dooms\OneDrive\Masaüstü\Murat Yücedağ-Asp.Net Core Mvc\CoreMvcProject\CoreMvcProject\Views\MyPersonal\Index.cshtml"
WriteAttributeValue("", 840, item.PersonalId, 840, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\dooms\OneDrive\Masaüstü\Murat Yücedağ-Asp.Net Core Mvc\CoreMvcProject\CoreMvcProject\Views\MyPersonal\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/MyPersonal/NewPersonal/\" class=\"btn btn-primary\">Yeni Personel Ekle</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Personal>> Html { get; private set; }
    }
}
#pragma warning restore 1591
