#pragma checksum "E:\code\Visual Studio Projects\. NET\MovieCRUDApp\MovieCRUDApp\Views\Movies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d055487fafc8ffeff6818ec82ba3f3453a54e2d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Details), @"mvc.1.0.view", @"/Views/Movies/Details.cshtml")]
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
#line 1 "E:\code\Visual Studio Projects\. NET\MovieCRUDApp\MovieCRUDApp\Views\_ViewImports.cshtml"
using MovieCRUDApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\code\Visual Studio Projects\. NET\MovieCRUDApp\MovieCRUDApp\Views\_ViewImports.cshtml"
using MovieCRUDApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\code\Visual Studio Projects\. NET\MovieCRUDApp\MovieCRUDApp\Views\_ViewImports.cshtml"
using MovieCRUDApp.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d055487fafc8ffeff6818ec82ba3f3453a54e2d8", @"/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6283a3b29756ba029ff93f4bab0ceb9e4ac00a12", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\code\Visual Studio Projects\. NET\MovieCRUDApp\MovieCRUDApp\Views\Movies\Details.cshtml"
   
    ViewData["Title"] = Model.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row mt-60-px justify-content-between\">\r\n    <div class=\"col-md-3\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 156, "\"", 221, 2);
            WriteAttributeValue("", 162, "data:image/*;base64,", 162, 20, true);
#nullable restore
#line 9 "E:\code\Visual Studio Projects\. NET\MovieCRUDApp\MovieCRUDApp\Views\Movies\Details.cshtml"
WriteAttributeValue("", 182, Convert.ToBase64String(Model.Poster), 182, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail\"");
            BeginWriteAttribute("alt", " alt=\"", 244, "\"", 264, 1);
#nullable restore
#line 9 "E:\code\Visual Studio Projects\. NET\MovieCRUDApp\MovieCRUDApp\Views\Movies\Details.cshtml"
WriteAttributeValue("", 250, Model.Title, 250, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n    </div>\r\n    <div class=\"col-md-7\">\r\n        <div class=\"d-flex justify-content-between mb-4\">\r\n            <h3>");
#nullable restore
#line 13 "E:\code\Visual Studio Projects\. NET\MovieCRUDApp\MovieCRUDApp\Views\Movies\Details.cshtml"
            Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <span class=\"mt-2\">\r\n                <i class=\"bi bi-star-fill text-warning\"></i>\r\n                <span class=\"text-muted\">");
#nullable restore
#line 16 "E:\code\Visual Studio Projects\. NET\MovieCRUDApp\MovieCRUDApp\Views\Movies\Details.cshtml"
                                     Write(Model.Rate.ToString("0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </span>\r\n        </div>\r\n        <span class=\"text-muted mr-3\">\r\n            <i class=\"bi bi-calendar-week\"></i>\r\n            ");
#nullable restore
#line 21 "E:\code\Visual Studio Projects\. NET\MovieCRUDApp\MovieCRUDApp\Views\Movies\Details.cshtml"
        Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </span>\r\n        <span class=\"text-muted\">\r\n            <i class=\"bi bi-film\"></i>\r\n            ");
#nullable restore
#line 25 "E:\code\Visual Studio Projects\. NET\MovieCRUDApp\MovieCRUDApp\Views\Movies\Details.cshtml"
        Write(Model.Genre.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </span>\r\n        <p class=\"text-justify mt-3\" >");
#nullable restore
#line 27 "E:\code\Visual Studio Projects\. NET\MovieCRUDApp\MovieCRUDApp\Views\Movies\Details.cshtml"
                                  Write(Model.Storyline);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591