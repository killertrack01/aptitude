#pragma checksum "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\SelectGeneral.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c152001a11558b0a7ac7b77266b0807171079465"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exam_SelectGeneral), @"mvc.1.0.view", @"/Views/Exam/SelectGeneral.cshtml")]
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
#line 1 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\_ViewImports.cshtml"
using Aptitude;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\_ViewImports.cshtml"
using Aptitude.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c152001a11558b0a7ac7b77266b0807171079465", @"/Views/Exam/SelectGeneral.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3293b3d850df3ce24076145fdd62ef046ce5541", @"/Views/_ViewImports.cshtml")]
    public class Views_Exam_SelectGeneral : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Aptitude.Models.Question>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/thanhcss.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/toastr/toastr.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TableQuestion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/hung.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/toastr/toastr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\SelectGeneral.cshtml"
  
    ViewData["Title"] = "Select Question Math";
    Layout = "~/Views/Shared/AdminLTE/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("CSS", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c152001a11558b0a7ac7b77266b08071710794655785", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c152001a11558b0a7ac7b77266b08071710794656964", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""card"">
                <div class=""card-body"">
                    <!--Title-->
                    <div class=""row"">
                        <div class=""col-lg-12"">
                            <h1 class=""card-title"">List General Question of ");
#nullable restore
#line 18 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\SelectGeneral.cshtml"
                                                                       Write(ViewBag.nameDepart);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                        </div>
                    </div>
                    <!--Search using partial view name: _Search-->
                    <div class=""row"" id=""searchtable"">
                        <div class=""col-lg-8"" style=""text-align: left;"">
                            <span>Total:</span><span id=""total"">");
#nullable restore
#line 24 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\SelectGeneral.cshtml"
                                                           Write(ViewBag.points);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> pts <span>|| Question Quantity:</span><span id=\"quantity\">");
#nullable restore
#line 24 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\SelectGeneral.cshtml"
                                                                                                                                            Write(ViewBag.count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </div>

                    </div>
                    <!--Table using partial view name: _Table-->
                    <div class=""row"">
                        <div class=""col-lg-12"">
                            <table class=""table table-bordered table-hover "" id=""table1"">
                                <thead class=""thead-dark"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c152001a11558b0a7ac7b77266b080717107946510404", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </thead>\r\n                                <tbody>\r\n");
#nullable restore
#line 36 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\SelectGeneral.cshtml"
                                     foreach (var item in Model)
                                    {
                                        //Filter exam section by value (1:general knowlegde||2:Math||3:Computer Technology)
                                        if (item.Category == 1)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td id=\"question-type\">\r\n");
#nullable restore
#line 43 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\SelectGeneral.cshtml"
                                             foreach (var item1 in ViewBag.Depart)
                                                    {
                                                        if (item1.Id == item.DepartmentId)
                                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\SelectGeneral.cshtml"
                                       Write(item1.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\SelectGeneral.cshtml"
                                                       }
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n                                        <td id=\"question-name\">\r\n                                            <p>");
#nullable restore
#line 51 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\SelectGeneral.cshtml"
                                          Write(item.QuestionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </td>\r\n                                        <td id=\"question-answer\">\r\n                                            <p>");
#nullable restore
#line 54 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\SelectGeneral.cshtml"
                                          Write(item.Answer1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </td>\r\n                                        <td id=\"question-answer\">\r\n                                            <p>");
#nullable restore
#line 57 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\SelectGeneral.cshtml"
                                          Write(item.Answer2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </td>\r\n                                        <td id=\"question-answer\">\r\n                                            <p>");
#nullable restore
#line 60 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\SelectGeneral.cshtml"
                                          Write(item.Answer3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </td>\r\n                                        <td id=\"question-answer\">\r\n                                            <p>");
#nullable restore
#line 63 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\SelectGeneral.cshtml"
                                          Write(item.Answer4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </td>\r\n                                        <td id=\"question-final\">\r\n                                            <p>");
#nullable restore
#line 66 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\SelectGeneral.cshtml"
                                          Write(item.FinalAnswer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </td>\r\n                                        <td id=\"question-level\">\r\n");
#nullable restore
#line 69 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\SelectGeneral.cshtml"
                                             if (item.Level == 10)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <p>Easy</p> ");
#nullable restore
#line 71 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\SelectGeneral.cshtml"
                                                        }
                                                    else if (item.Level == 20)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <p>Medium</p> ");
#nullable restore
#line 74 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\SelectGeneral.cshtml"
                                                          }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <p>Hard</p>");
#nullable restore
#line 77 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\SelectGeneral.cshtml"
                                                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n                                        <td id=\"question-status\">\r\n");
#nullable restore
#line 80 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\SelectGeneral.cshtml"
                                             if (item.Status == 1)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <button");
            BeginWriteAttribute("id", " id=\"", 4508, "\"", 4521, 1);
#nullable restore
#line 82 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\SelectGeneral.cshtml"
WriteAttributeValue("", 4513, item.Id, 4513, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 4522, "\"", 4542, 1);
#nullable restore
#line 82 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\SelectGeneral.cshtml"
WriteAttributeValue("", 4530, item.Status, 4530, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 82 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\SelectGeneral.cshtml"
                                                                                           Write(item.DepartmentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("class", " class=\"", 4572, "\"", 4600, 2);
            WriteAttributeValue("", 4580, "btn-success", 4580, 11, true);
#nullable restore
#line 82 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\SelectGeneral.cshtml"
WriteAttributeValue(" ", 4591, item.Id, 4592, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Enable</button> ");
#nullable restore
#line 82 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\SelectGeneral.cshtml"
                                                                                                                                                                 }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <button");
            BeginWriteAttribute("id", " id=\"", 4785, "\"", 4798, 1);
#nullable restore
#line 85 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\SelectGeneral.cshtml"
WriteAttributeValue("", 4790, item.Id, 4790, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 4799, "\"", 4819, 1);
#nullable restore
#line 85 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\SelectGeneral.cshtml"
WriteAttributeValue("", 4807, item.Status, 4807, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 85 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\SelectGeneral.cshtml"
                                                                                           Write(item.DepartmentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("class", " class=\"", 4849, "\"", 4876, 2);
            WriteAttributeValue("", 4857, "btn-danger", 4857, 10, true);
#nullable restore
#line 85 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\SelectGeneral.cshtml"
WriteAttributeValue(" ", 4867, item.Id, 4868, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Disable</button>");
#nullable restore
#line 85 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\SelectGeneral.cshtml"
                                                                                                                                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 88 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\SelectGeneral.cshtml"
}

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c152001a11558b0a7ac7b77266b080717107946523126", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c152001a11558b0a7ac7b77266b080717107946524226", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(function () {
            $('button').on('click', function () {
                var result = $(this).attr('id');
                var val = $(this).val();
                var depart = $(this).attr(""data-id"");
                $.ajax({
                    type: ""POST"",
                    url: """);
#nullable restore
#line 111 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\SelectGeneral.cshtml"
                     Write(Url.Action("Change"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                    data: { sms: val, result: result, cate: 1, depart: depart },
                    dataType: ""json"",
                    //contentType: ""application/json; charset=utf-8"",
                    //processData: false,
                    success: function (msg) {


                        if (msg.result == 1)
                            toastr.error(""Question max is 5."");
                        if (msg.result == 2)
                            toastr.error(""Total score can not greater than 100."");
                        if (msg.result == 0)
                        {
                            //var pointString = """" + msg.points;
                            $('span#total').text(msg.points);
                            $('span#quantity').text(msg.count);
                            if (msg.baz == 1) {
                                $('button#' + msg.foo).text(""Enable"");
                                $('button#' + msg.foo).val(1);
                                $('button");
                WriteLiteral(@"#' + msg.foo).removeClass();
                                $('button#' + msg.foo).addClass(""btn-success"");
                            }
                            if (msg.baz == 0) {
                                $('button#' + msg.foo).text(""Disable"");
                                $('button#' + msg.foo).val(0);
                                $('button#' + msg.foo).removeClass();
                                $('button#' + msg.foo).addClass(""btn-danger"");
                            }
                            if (msg.count != 5 || msg.points != 100) {
                                toastr.error(""Total score must be 100 and total question must be 5 questions."");
                            }
                            if (msg.count == 5 && msg.points == 100) {
                                toastr.success(""Ok Done."");
                            }
                        }

                    },
                    error: function (req, status, error) {
                    ");
                WriteLiteral("    toastr.error(\"Total score can not greater than 100.\");\r\n                    }\r\n                });\r\n            });\r\n        });\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Aptitude.Models.Question>> Html { get; private set; }
    }
}
#pragma warning restore 1591