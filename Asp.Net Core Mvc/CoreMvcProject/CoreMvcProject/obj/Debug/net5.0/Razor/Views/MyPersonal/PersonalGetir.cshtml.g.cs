#pragma checksum "C:\Users\dooms\OneDrive\Masaüstü\Murat Yücedağ-Asp.Net Core Mvc\CoreMvcProject\CoreMvcProject\Views\MyPersonal\PersonalGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b3524ac3826efaca17e02fac385dcba1dfc8d1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyPersonal_PersonalGetir), @"mvc.1.0.view", @"/Views/MyPersonal/PersonalGetir.cshtml")]
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
#line 2 "C:\Users\dooms\OneDrive\Masaüstü\Murat Yücedağ-Asp.Net Core Mvc\CoreMvcProject\CoreMvcProject\Views\_ViewImports.cshtml"
using CoreMvcProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b3524ac3826efaca17e02fac385dcba1dfc8d1c", @"/Views/MyPersonal/PersonalGetir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18129d99b0726d8f9473a818c711dcc5ef26be2c", @"/Views/_ViewImports.cshtml")]
    public class Views_MyPersonal_PersonalGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreMvcProject.Models.Personal>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\dooms\OneDrive\Masaüstü\Murat Yücedağ-Asp.Net Core Mvc\CoreMvcProject\CoreMvcProject\Views\MyPersonal\PersonalGetir.cshtml"
  
    ViewData["Title"] = "PersonalGetir";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 8 "C:\Users\dooms\OneDrive\Masaüstü\Murat Yücedağ-Asp.Net Core Mvc\CoreMvcProject\CoreMvcProject\Views\MyPersonal\PersonalGetir.cshtml"
 using (Html.BeginForm("UpdatePersonal", "MyPersonal", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <b>Personel Adı</b>\r\n");
#nullable restore
#line 11 "C:\Users\dooms\OneDrive\Masaüstü\Murat Yücedağ-Asp.Net Core Mvc\CoreMvcProject\CoreMvcProject\Views\MyPersonal\PersonalGetir.cshtml"
Write(Html.TextBoxFor(x => x.PersonalFirstName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <b>Personel Soyad</b>\r\n");
#nullable restore
#line 14 "C:\Users\dooms\OneDrive\Masaüstü\Murat Yücedağ-Asp.Net Core Mvc\CoreMvcProject\CoreMvcProject\Views\MyPersonal\PersonalGetir.cshtml"
Write(Html.TextBoxFor(x => x.PersonalLastName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <b>Personel Şehir</b>\r\n");
#nullable restore
#line 17 "C:\Users\dooms\OneDrive\Masaüstü\Murat Yücedağ-Asp.Net Core Mvc\CoreMvcProject\CoreMvcProject\Views\MyPersonal\PersonalGetir.cshtml"
Write(Html.TextBoxFor(x => x.PersonalCity, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <b>Birim</b>\r\n");
#nullable restore
#line 20 "C:\Users\dooms\OneDrive\Masaüstü\Murat Yücedağ-Asp.Net Core Mvc\CoreMvcProject\CoreMvcProject\Views\MyPersonal\PersonalGetir.cshtml"
Write(Html.DropDownListFor(x => x.Unit.UnitId, (List<SelectListItem>)ViewBag.val, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-info\">Personel Güncelle</button>\r\n");
#nullable restore
#line 23 "C:\Users\dooms\OneDrive\Masaüstü\Murat Yücedağ-Asp.Net Core Mvc\CoreMvcProject\CoreMvcProject\Views\MyPersonal\PersonalGetir.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreMvcProject.Models.Personal> Html { get; private set; }
    }
}
#pragma warning restore 1591
