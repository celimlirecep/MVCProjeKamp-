#pragma checksum "C:\Users\recep\Downloads\MVCProjeKampı\MVCProjeKampıUI\Views\Heading\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9548acbd5318f1d5d4c4e2d14a6af7c91e882908"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Heading_Index), @"mvc.1.0.view", @"/Views/Heading/Index.cshtml")]
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
#line 1 "C:\Users\recep\Downloads\MVCProjeKampı\MVCProjeKampıUI\Views\_ViewImports.cshtml"
using MVCProjeKampıUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\recep\Downloads\MVCProjeKampı\MVCProjeKampıUI\Views\_ViewImports.cshtml"
using MVCProjeKampıUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\recep\Downloads\MVCProjeKampı\MVCProjeKampıUI\Views\_ViewImports.cshtml"
using EntityLayer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9548acbd5318f1d5d4c4e2d14a6af7c91e882908", @"/Views/Heading/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a0d1b94e20a9ded07d9a96433c0bac8a23fb7d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Heading_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Heading>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Heading", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ContentByHeading", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition sidebar-mini"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\recep\Downloads\MVCProjeKampı\MVCProjeKampıUI\Views\Heading\Index.cshtml"
  
    ViewData["Title"] = "AddCategory";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9548acbd5318f1d5d4c4e2d14a6af7c91e8829085124", async() => {
                WriteLiteral(@"
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1>Projects</h1>
                </div>
            </div>
        </div><!-- /.container-fluid -->
    </section>
    <!-- Main content -->
    <section class=""content"">
        <!-- Default box -->
        <div class=""card"">
            <div class=""card-header"">
                <h3 class=""card-title"">Başlık İşlemleri</h3>
                <div class=""card-tools"">
                    <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"" data-toggle=""tooltip"" title=""Collapse"">
                        <i class=""fas fa-minus""></i>
                    </button>
                    <button type=""button"" class=""btn btn-tool"" data-card-widget=""remove"" data-toggle=""tooltip"" title=""Remove"">
                        <i class=""fas fa-times""></i>
                    </butto");
                WriteLiteral(@"n>
                </div>
            </div>
            <div class=""card-body p-0"">
                <table class=""table table-striped projects"">
                    <thead>
                        <tr>
                            <th style=""width: 1%"">
                                #
                            </th>
                            <th style=""width: 20%"">
                                Başlık Adı
                            </th>
                            <th style=""width: 30%"">
                                Oluşturan Yazar
                            </th>
                            <th style=""width: 8%"" class=""text-center"">
                                Kategori
                            </th>
                            <th style=""width: 20%"">
                            </th>
                        </tr>
                    </thead>
");
#nullable restore
#line 58 "C:\Users\recep\Downloads\MVCProjeKampı\MVCProjeKampıUI\Views\Heading\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tbody>\r\n                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 63 "C:\Users\recep\Downloads\MVCProjeKampı\MVCProjeKampıUI\Views\Heading\Index.cshtml"
                               Write(item.HeadingId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    <a>\r\n                                        ");
#nullable restore
#line 67 "C:\Users\recep\Downloads\MVCProjeKampı\MVCProjeKampıUI\Views\Heading\Index.cshtml"
                                   Write(item.HeadingName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </a>\r\n                                    <br />\r\n                                    <small>\r\n                                        ");
#nullable restore
#line 71 "C:\Users\recep\Downloads\MVCProjeKampı\MVCProjeKampıUI\Views\Heading\Index.cshtml"
                                    Write(((DateTime)item.HeadingDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </small>
                                </td>
                                <td>
                                    <ul class=""list-inline"">
                                        <li class=""list-inline-item"">
                                            ");
#nullable restore
#line 77 "C:\Users\recep\Downloads\MVCProjeKampı\MVCProjeKampıUI\Views\Heading\Index.cshtml"
                                       Write(item.Writer.WriterFullName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                        </li>
                                    </ul>
                                </td>
                                <td class=""project-state"">
                                    <span class=""badge badge-success"">");
#nullable restore
#line 82 "C:\Users\recep\Downloads\MVCProjeKampı\MVCProjeKampıUI\Views\Heading\Index.cshtml"
                                                                 Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                </td>\r\n                                <td class=\"project-actions text-right\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9548acbd5318f1d5d4c4e2d14a6af7c91e88290810281", async() => {
                    WriteLiteral("\r\n                                        <i class=\"fas fa-folder\">\r\n                                        </i>\r\n                                       İçerikler\r\n                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    <a class=""btn btn-info btn-sm"" href=""#"">
                                        <i class=""fas fa-pencil-alt"">
                                        </i>
                                     Düzenle
                                    </a>
                                    <a class=""btn btn-danger btn-sm"" href=""#"">
                                        <i class=""fas fa-trash"">
                                        </i>
                                       Sil
                                    </a>
                                </td>
                            </tr>

                        </tbody>
");
#nullable restore
#line 108 "C:\Users\recep\Downloads\MVCProjeKampı\MVCProjeKampıUI\Views\Heading\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </table>\r\n            </div>\r\n            <!-- /.card-body -->\r\n        </div>\r\n        <!-- /.card -->\r\n    </section>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Heading>> Html { get; private set; }
    }
}
#pragma warning restore 1591
