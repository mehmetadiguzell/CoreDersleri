#pragma checksum "C:\Users\MA\source\repos\CoreDersleri\CoreDepartman\Views\Departman\YeniDepartman.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04cf9a5064d23023a459b494187151fc7560f5ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Departman_YeniDepartman), @"mvc.1.0.view", @"/Views/Departman/YeniDepartman.cshtml")]
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
#line 1 "C:\Users\MA\source\repos\CoreDersleri\CoreDepartman\Views\_ViewImports.cshtml"
using CoreDepartman;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MA\source\repos\CoreDersleri\CoreDepartman\Views\_ViewImports.cshtml"
using CoreDepartman.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04cf9a5064d23023a459b494187151fc7560f5ff", @"/Views/Departman/YeniDepartman.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"244fa5d166229326930cbe183019d72d2c0ef836", @"/Views/_ViewImports.cshtml")]
    public class Views_Departman_YeniDepartman : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreDepartman.Models.Departman>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\MA\source\repos\CoreDersleri\CoreDepartman\Views\Departman\YeniDepartman.cshtml"
  
    ViewData["Title"] = "YeniDepartman";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\MA\source\repos\CoreDersleri\CoreDepartman\Views\Departman\YeniDepartman.cshtml"
 using(Html.BeginForm("YeniDepartman", "Departman", FormMethod.Post)) { 


#line default
#line hidden
#nullable disable
            WriteLiteral("    <label class=\"bg-info\">Departman Ad??</label>\r\n");
#nullable restore
#line 9 "C:\Users\MA\source\repos\CoreDersleri\CoreDepartman\Views\Departman\YeniDepartman.cshtml"
Write(Html.TextBoxFor(m=>m.DepartmanAd,new { @class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-success\">Kaydet</button>\r\n");
#nullable restore
#line 12 "C:\Users\MA\source\repos\CoreDersleri\CoreDepartman\Views\Departman\YeniDepartman.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreDepartman.Models.Departman> Html { get; private set; }
    }
}
#pragma warning restore 1591
