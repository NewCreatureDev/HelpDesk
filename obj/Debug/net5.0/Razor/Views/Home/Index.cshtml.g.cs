#pragma checksum "C:\Users\gabri\OneDrive\Área de Trabalho\HelpDesk\HelpDesk\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "013f32b5b4418569013230eb702ab4a1dc21113d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\gabri\OneDrive\Área de Trabalho\HelpDesk\HelpDesk\Views\_ViewImports.cshtml"
using HelpDesk;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gabri\OneDrive\Área de Trabalho\HelpDesk\HelpDesk\Views\_ViewImports.cshtml"
using HelpDesk.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"013f32b5b4418569013230eb702ab4a1dc21113d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52c247f7295ac14acf1ea99fed5a7a4fde8a5af2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "25", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "50", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "100", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\gabri\OneDrive\Área de Trabalho\HelpDesk\HelpDesk\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid"">
    <h3 class=""text-dark mb-4"">Lista de Tickets</h3>
    <div class=""card shadow"">
        <div class=""card-header py-3"">
            <p class=""text-primary m-0 fw-bold""></p>
        </div>
        <div class=""card-body"">
            <div class=""row"">
                <div class=""col-md-6 text-nowrap"">
                    <div id=""dataTable_length"" class=""dataTables_length"" aria-controls=""dataTable"">
                        <label class=""form-label"">
                            Show&nbsp;<select class=""d-inline-block form-select form-select-sm"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "013f32b5b4418569013230eb702ab4a1dc21113d5437", async() => {
                WriteLiteral("10");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "013f32b5b4418569013230eb702ab4a1dc21113d6707", async() => {
                WriteLiteral("25");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "013f32b5b4418569013230eb702ab4a1dc21113d7894", async() => {
                WriteLiteral("50");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "013f32b5b4418569013230eb702ab4a1dc21113d9081", async() => {
                WriteLiteral("100");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </select>&nbsp;
                        </label>
                    </div>
                </div>
                <div class=""col-md-6"">
                    <div class=""text-md-end dataTables_filter"" id=""dataTable_filter""><label class=""form-label""><input type=""search"" class=""form-control form-control-sm"" aria-controls=""dataTable"" placeholder=""Search""></label></div>
                </div>
            </div>
            <div class=""table-responsive table mt-2"" id=""dataTable"" role=""grid"" aria-describedby=""dataTable_info"">
                <table class=""table my-0"" id=""dataTable"">
                    <thead>
                        <tr>
                            <th>Ticket</th>
                            <th>Assunto</th>
                            <th>Responsável</th>
                            <th>Data de Abertura</th>
                            <th>Status</th>
                        </tr>
                    </thead>
                    <tbody>
          ");
            WriteLiteral(@"              <tr>
                            <td>#08781</td>
                            <td>Accountant</td>
                            <td><img class=""rounded-circle me-2"" width=""30"" height=""30"" src=""assets/img/avatars/avatar1.jpeg"">Marcos Vianey</td>
                            <td>2008/11/28</td>
                            <td>Aberto</td>
                        </tr>
                        <tr>
                            <td>#08782<br></td>
                            <td>Chief Executive Officer(CEO)</td>
                            <td><img class=""rounded-circle me-2"" width=""30"" height=""30"" src=""assets/img/avatars/avatar2.jpeg"">Bibinha Marcos</td>
                            <td>2009/10/09<br></td>
                            <td>Aberto</td>
                        </tr>
                        <tr>
                            <td>#08783<br></td>
                            <td>Junior Technical Author</td>
                            <td><img class=""rounded-circle me-2"" width=""30"" ");
            WriteLiteral(@"height=""30"" src=""assets/img/avatars/avatar3.jpeg"">50 Cent</td>
                            <td>2009/01/12<br></td>
                            <td>Aberto</td>
                        </tr>
                        <tr>
                            <td>#08784</td>
                            <td>Software Engineer</td>
                            <td><img class=""rounded-circle me-2"" width=""30"" height=""30"" src=""assets/img/avatars/avatar4.jpeg"">Ateuzinho</td>
                            <td>2012/10/13<br></td>
                            <td>Aberto</td>
                        </tr>
                        <tr>
                            <td>#08785</td>
                            <td>Software Engineer</td>
                            <td><img class=""rounded-circle me-2"" width=""30"" height=""30"" src=""assets/img/avatars/avatar5.jpeg"">Crente Penteca</td>
                            <td>2011/06/07<br></td>
                            <td>Aberto</td>
                        </tr>
                      ");
            WriteLiteral(@"  <tr>
                            <td>#08786</td>
                            <td>Integration Specialist</td>
                            <td><img class=""rounded-circle me-2"" width=""30"" height=""30"" src=""assets/img/avatars/avatar1.jpeg"">Phablo Lindo</td>
                            <td>2012/12/02<br></td>
                            <td>Aberto</td>
                        </tr>
                        <tr>
                            <td>#08787</td>
                            <td>Software Engineer</td>
                            <td><img class=""rounded-circle me-2"" width=""30"" height=""30"" src=""assets/img/avatars/avatar2.jpeg"">Michael Quadrado<br></td>
                            <td>2011/05/03<br></td>
                            <td>Aberto</td>
                        </tr>
                        <tr>
                            <td>#08788</td>
                            <td>Pre-Sales Support</td>
                            <td><img class=""rounded-circle me-2"" width=""30"" height=""30"" src=");
            WriteLiteral(@"""assets/img/avatars/avatar3.jpeg"">Angola Boy</td>
                            <td>2011/12/12<br></td>
                            <td>Aberto</td>
                        </tr>
                        <tr>
                            <td>#08789</td>
                            <td>Sales Assistant</td>
                            <td><img class=""rounded-circle me-2"" width=""30"" height=""30"" src=""assets/img/avatars/avatar4.jpeg"">Thiguinha lindo</td>
                            <td>2011/12/06<br></td>
                            <td>Aberto</td>
                        </tr>
                        <tr>
                            <td>#08790</td>
                            <td>Senior JavaScript Developer</td>
                            <td><img class=""rounded-circle me-2"" width=""30"" height=""30"" src=""assets/img/avatars/avatar5.jpeg"">Tchola</td>
                            <td>2012/03/29<br></td>
                            <td>Aberto</td>
                        </tr>
                    </tbody>");
            WriteLiteral(@"
                    <tfoot>
                        <tr></tr>
                    </tfoot>
                </table>
            </div>
            <div class=""row"">
                <div class=""col"">
                    <nav class=""text-center d-lg-flex justify-content-lg-end dataTables_paginate paging_simple_numbers"">
                        <ul class=""pagination"">
                            <li class=""page-item disabled""><a class=""page-link"" href=""#"" aria-label=""Previous""><span aria-hidden=""true"">«</span></a></li>
                            <li class=""page-item active""><a class=""page-link"" href=""#"">1</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"" aria-label=""Next""><span aria-hidden=""true"">»</span></a></li>
                        </ul>
                    </nav>
       ");
            WriteLiteral("         </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
