#pragma checksum "C:\Users\recep\Downloads\MVCProjeKampı\MVCProjeKampıUI\Views\Message\SendBox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd927221e2e5821a43f5f157851fea901fe0440a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_SendBox), @"mvc.1.0.view", @"/Views/Message/SendBox.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd927221e2e5821a43f5f157851fea901fe0440a", @"/Views/Message/SendBox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a0d1b94e20a9ded07d9a96433c0bac8a23fb7d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_SendBox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_MessageListMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition sidebar-mini"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\recep\Downloads\MVCProjeKampı\MVCProjeKampıUI\Views\Message\SendBox.cshtml"
  
    ViewData["Title"] = "AddCategory";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd927221e2e5821a43f5f157851fea901fe0440a4394", async() => {
                WriteLiteral(@"

    <!-- Content Wrapper. Contains page content -->
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1>Mesaj Sayfası</h1>
                </div>

            </div>
        </div><!-- /.container-fluid -->
    </section>
    <!-- Main content -->
    <section class=""content"">
        <div class=""row"">
            <!-- /.col*******************************************partial -->
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dd927221e2e5821a43f5f157851fea901fe0440a5237", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            <div class=""col-md-9"">
                <div class=""card card-primary card-outline"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">Gönderilen Mesajlar</h3>
                        <div class=""card-tools"">
                            <div class=""input-group input-group-sm"">
                                <input type=""text"" class=""form-control"" placeholder=""Mail Kutusunda Ara"">
                                <div class=""input-group-append"">
                                    <div class=""btn btn-primary"">
                                        <i class=""fas fa-search""></i>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- /.card-tools -->
                    </div>
                    <!-- /.card-header -->
                    <div class=""card-body p-0"">
                        <div class=""mailbox-controls""");
                WriteLiteral(@">
                            <!-- Check all button -->
                            <button type=""button"" class=""btn btn-default btn-sm checkbox-toggle"">
                                <i class=""far fa-square""></i>
                            </button>
                            <div class=""btn-group"">
                                <button type=""button"" class=""btn btn-default btn-sm""><i class=""far fa-trash-alt""></i></button>
                                <button type=""button"" class=""btn btn-default btn-sm""><i class=""fas fa-reply""></i></button>
                                <button type=""button"" class=""btn btn-default btn-sm""><i class=""fas fa-share""></i></button>
                            </div>
                            <!-- /.btn-group -->
                            <button type=""button"" class=""btn btn-default btn-sm""><i class=""fas fa-sync-alt""></i></button>
                            <div class=""float-right"">
                                1-50/200
                              ");
                WriteLiteral(@"  <div class=""btn-group"">
                                    <button type=""button"" class=""btn btn-default btn-sm""><i class=""fas fa-chevron-left""></i></button>
                                    <button type=""button"" class=""btn btn-default btn-sm""><i class=""fas fa-chevron-right""></i></button>
                                </div>
                                <!-- /.btn-group -->
                            </div>
                            <!-- /.float-right -->
                        </div>
                        <div class=""table-responsive mailbox-messages"">
                            <table class=""table table-hover table-striped"">
                                <tbody>
");
#nullable restore
#line 73 "C:\Users\recep\Downloads\MVCProjeKampı\MVCProjeKampıUI\Views\Message\SendBox.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <tr>\r\n                                            <td>\r\n                                                <div class=\"icheck-primary\">\r\n                                                    <input type=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 4021, "\"", 4029, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""check1"">
                                                    <label for=""check1""></label>
                                                </div>
                                            </td>
                                            <td class=""mailbox-star""><a href=""#""><i class=""fas fa-star text-warning""></i></a></td>
                                            <td class=""mailbox-name""><a");
                BeginWriteAttribute("href", " href=\"", 4437, "\"", 4493, 2);
                WriteAttributeValue("", 4444, "/Message/GetSendboxMessageDetails/", 4444, 34, true);
#nullable restore
#line 83 "C:\Users\recep\Downloads\MVCProjeKampı\MVCProjeKampıUI\Views\Message\SendBox.cshtml"
WriteAttributeValue("", 4478, item.MessageId, 4478, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 83 "C:\Users\recep\Downloads\MVCProjeKampı\MVCProjeKampıUI\Views\Message\SendBox.cshtml"
                                                                                                                            Write(item.RecieverMail);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n                                            <td class=\"mailbox-subject\">\r\n                                                <b>");
#nullable restore
#line 85 "C:\Users\recep\Downloads\MVCProjeKampı\MVCProjeKampıUI\Views\Message\SendBox.cshtml"
                                              Write(item.Subject);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b>- ");
#nullable restore
#line 85 "C:\Users\recep\Downloads\MVCProjeKampı\MVCProjeKampıUI\Views\Message\SendBox.cshtml"
                                                                 Write(item.MessageContent.Substring(0, 2));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ...\r\n                                            </td>\r\n                                            <td class=\"mailbox-attachment\"></td>\r\n                                            <td class=\"mailbox-date\">");
#nullable restore
#line 88 "C:\Users\recep\Downloads\MVCProjeKampı\MVCProjeKampıUI\Views\Message\SendBox.cshtml"
                                                                 Write(((DateTime)item.MessageDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 90 "C:\Users\recep\Downloads\MVCProjeKampı\MVCProjeKampıUI\Views\Message\SendBox.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </tbody>
                            </table>
                            <!-- /.table -->
                        </div>
                        <!-- /.mail-box-messages -->
                    </div>
                    <!-- /.card-body -->
                    <div class=""card-footer p-0"">
                        <div class=""mailbox-controls"">
                            <!-- Check all button -->
                            <button type=""button"" class=""btn btn-default btn-sm checkbox-toggle"">
                                <i class=""far fa-square""></i>
                            </button>
                            <div class=""btn-group"">
                                <button type=""button"" class=""btn btn-default btn-sm""><i class=""far fa-trash-alt""></i></button>
                                <button type=""button"" class=""btn btn-default btn-sm""><i class=""fas fa-reply""></i></button>
                                <button type=""button"" class=""btn btn-defau");
                WriteLiteral(@"lt btn-sm""><i class=""fas fa-share""></i></button>
                            </div>
                            <!-- /.btn-group -->
                            <button type=""button"" class=""btn btn-default btn-sm""><i class=""fas fa-sync-alt""></i></button>
                            <div class=""float-right"">
                                1-50/200
                                <div class=""btn-group"">
                                    <button type=""button"" class=""btn btn-default btn-sm""><i class=""fas fa-chevron-left""></i></button>
                                    <button type=""button"" class=""btn btn-default btn-sm""><i class=""fas fa-chevron-right""></i></button>
                                </div>
                                <!-- /.btn-group -->
                            </div>
                            <!-- /.float-right -->
                        </div>
                    </div>
                </div>
                <!-- /.card -->
            </div>
            <!-- /.co");
                WriteLiteral("l -->\r\n        </div>\r\n        <!-- /.row -->\r\n    </section>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message>> Html { get; private set; }
    }
}
#pragma warning restore 1591
