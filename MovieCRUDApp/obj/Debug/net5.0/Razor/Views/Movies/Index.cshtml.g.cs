#pragma checksum "E:\code\Visual Studio Projects\. NET\MovieCRUDApp\MovieCRUDApp\Views\Movies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "355caf713df0a60b8b5c2c5a1044096ba853cf36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"355caf713df0a60b8b5c2c5a1044096ba853cf36", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6283a3b29756ba029ff93f4bab0ceb9e4ac00a12", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Movie>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\code\Visual Studio Projects\. NET\MovieCRUDApp\MovieCRUDApp\Views\Movies\Index.cshtml"
  
    ViewData["Title"] = "Movies";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2> <i class=\"bi bi-film\"></i> Movies</h2>\r\n\r\n<hr />\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "355caf713df0a60b8b5c2c5a1044096ba853cf365655", async() => {
                WriteLiteral("\r\n    <i class=\"bi bi-file-plus\"></i>\r\n    Add Movies\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"m-4\">\r\n\r\n");
#nullable restore
#line 18 "E:\code\Visual Studio Projects\. NET\MovieCRUDApp\MovieCRUDApp\Views\Movies\Index.cshtml"
     if (!Model.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-warning\" role=\"alert\">\r\n            <i class=\"bi bi-exclamation-circle-fill\"></i>  No Movies Found!\r\n        </div>\r\n");
#nullable restore
#line 23 "E:\code\Visual Studio Projects\. NET\MovieCRUDApp\MovieCRUDApp\Views\Movies\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n");
#nullable restore
#line 27 "E:\code\Visual Studio Projects\. NET\MovieCRUDApp\MovieCRUDApp\Views\Movies\Index.cshtml"
             foreach (var m in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    <div class=\"card mb-3\">\r\n                        <div class=\"row no-gutters\">\r\n                            <div class=\"col-md-2 poster\"");
            BeginWriteAttribute("style", " style=\"", 724, "\"", 811, 4);
            WriteAttributeValue("", 732, "background-image:", 732, 17, true);
            WriteAttributeValue(" ", 749, "url(data:image\\/*;base64,", 750, 26, true);
#nullable restore
#line 32 "E:\code\Visual Studio Projects\. NET\MovieCRUDApp\MovieCRUDApp\Views\Movies\Index.cshtml"
WriteAttributeValue("", 775, Convert.ToBase64String(m.Poster), 775, 35, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 810, ")", 810, 1, true);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                            <div class=""col-md-10"">
                                <div class=""card-body d-flex flex-column justify-content-between h-100"">
                                    <div>
                                        <h5 class=""card-title"">");
#nullable restore
#line 36 "E:\code\Visual Studio Projects\. NET\MovieCRUDApp\MovieCRUDApp\Views\Movies\Index.cshtml"
                                                           Write(m.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 36 "E:\code\Visual Studio Projects\. NET\MovieCRUDApp\MovieCRUDApp\Views\Movies\Index.cshtml"
                                                                       Write(m.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h5>\r\n                                        <p class=\"card-text text-justify\">");
#nullable restore
#line 37 "E:\code\Visual Studio Projects\. NET\MovieCRUDApp\MovieCRUDApp\Views\Movies\Index.cshtml"
                                                                      Write( m.Storyline.Length > 500 ? $"{m.Storyline.Substring(0,500)}...........": m.Storyline);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                    <div class=""d-flex justify-content-between"">
                                        <p class=""card-text mb-0 mt-2"">
                                            <i class=""bi bi-star-fill text-warning""></i>
                                            <small class=""text-muted"">");
#nullable restore
#line 42 "E:\code\Visual Studio Projects\. NET\MovieCRUDApp\MovieCRUDApp\Views\Movies\Index.cshtml"
                                                                  Write(m.Rate.ToString("0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                        </p>\r\n                                        <div>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "355caf713df0a60b8b5c2c5a1044096ba853cf3610822", async() => {
                WriteLiteral("\r\n                                                <i class=\"bi bi-camera-reels\"></i>\r\n                                                Details\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "E:\code\Visual Studio Projects\. NET\MovieCRUDApp\MovieCRUDApp\Views\Movies\Index.cshtml"
                                                                       WriteLiteral(m.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "355caf713df0a60b8b5c2c5a1044096ba853cf3613330", async() => {
                WriteLiteral("\r\n                                                <i class=\"bi bi-pencil\"></i>\r\n                                                Edit\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "E:\code\Visual Studio Projects\. NET\MovieCRUDApp\MovieCRUDApp\Views\Movies\Index.cshtml"
                                                                    WriteLiteral(m.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                            <a href=\"javascript:;\" class=\"btn btn-danger js-delete\" data-id=\"");
#nullable restore
#line 55 "E:\code\Visual Studio Projects\. NET\MovieCRUDApp\MovieCRUDApp\Views\Movies\Index.cshtml"
                                                                                                        Write(m.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                                <i class=""bi bi-trash""></i>
                                                Delete
                                            </a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 66 "E:\code\Visual Studio Projects\. NET\MovieCRUDApp\MovieCRUDApp\Views\Movies\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 68 "E:\code\Visual Studio Projects\. NET\MovieCRUDApp\MovieCRUDApp\Views\Movies\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('.js-delete').on('click', function () {
                var btn = $(this);

                bootbox.confirm({
                    message: ""Are you sure that you need to delete this movie?"",
                    buttons: {
                        confirm: {
                            label: 'Yes',
                            className: 'btn-danger'
                        },
                        cancel: {
                            label: 'No',
                            className: 'btn-outline-secondary'
                        }
                    },
                    callback: function (result) {
                        if (result) {
                            $.ajax({
                                url: '/movies/delete/' + btn.data('id'),
                                success: function () {
                                    var movieContainer = btn.parents('.col-md-10');
                              ");
                WriteLiteral(@"      movieContainer.addClass('animate__animated animate__zoomOut');

                                    setTimeout(function () {
                                        movieContainer.remove();
                                    }, 1000);

                                    toastr.success('Movies deleted');
                                },
                                error: function () {
                                    toastr.error('Something went wrong!');
                                }
                            });
                        }
                    }
                });

            });
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Movie>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591