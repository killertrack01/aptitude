#pragma checksum "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ab7734c13dff10d2d6ef1db23d6156360f21a2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exam_ComputerExam), @"mvc.1.0.view", @"/Views/Exam/ComputerExam.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ab7734c13dff10d2d6ef1db23d6156360f21a2b", @"/Views/Exam/ComputerExam.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3293b3d850df3ce24076145fdd62ef046ce5541", @"/Views/_ViewImports.cshtml")]
    public class Views_Exam_ComputerExam : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Aptitude.Models.Question>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Exam", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ResultExam", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml"
  
    ViewData["Title"] = "ComputerExam";
    Layout = "~/Views/Exam/examLayout.cshtml";
    int counter = 1;

#line default
#line hidden
#nullable disable
            DefineSection("css", async() => {
                WriteLiteral(@"
    <!-- CSS -->
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css"" integrity=""sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2"" crossorigin=""anonymous"">
    <style>
        .exam-name .single {
            max-width: 650px;
            margin: 0 auto;
            text-align: center;
            position: relative;
        }

            .exam-name .single h3 {
                font-size: 40px;
                color: saddlebrown;
                text-transform: uppercase;
            }
    </style>

");
            }
            );
            WriteLiteral(@"<hr />
<section class=""exam-name"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-sm-12"">
                <div class=""single"" style=""text-align:center"">
                    <h3>Computer Exam</h3>
                </div>
            </div>
        </div>
        <hr />
        <div class=""row"">
            <div class=""col-sm-4""></div>
            <div class=""col-sm-4"">
                <div class=""card"">
                    <div class=""card-header"" style=""text-align:center"">
");
#nullable restore
#line 43 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml"
                         if (ViewBag.checking == 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h3>Time in <span id=\"time\">00:10</span> seconds!</h3>\r\n                            <input type=\"hidden\" class=\"checking\" value=\"open\" />\r\n");
#nullable restore
#line 47 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml"
                         if (ViewBag.checking == 2)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h3>Time in <span id=\"time\">00:00</span> minutes!</h3>\r\n                            <input type=\"hidden\" class=\"checking\" value=\"done\" />\r\n");
#nullable restore
#line 52 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
            <div class=""col-sm-4""></div>
        </div>
        <hr />
    </div>
</section>
<section class=""details-exam"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-1""></div>
            <div class=""col-md-8"">
");
#nullable restore
#line 66 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml"
                 using (Html.BeginForm("ComputerExam", "Exam", FormMethod.Post))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"card\">\r\n                            <div class=\"card-header\" style=\"text-align:center\">\r\n                                <h5>");
#nullable restore
#line 72 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml"
                               Write(item.QuestionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            </div>\r\n                            <div class=\"card-body\">\r\n                                <ul>\r\n                                    <li><input");
            BeginWriteAttribute("id", " id=\"", 2740, "\"", 2755, 2);
            WriteAttributeValue("", 2745, "a+", 2745, 2, true);
#nullable restore
#line 76 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml"
WriteAttributeValue("", 2747, item.Id, 2747, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"radio\"");
            BeginWriteAttribute("name", " name=\"", 2769, "\"", 2786, 2);
            WriteAttributeValue("", 2776, "a+", 2776, 2, true);
#nullable restore
#line 76 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml"
WriteAttributeValue("", 2778, item.Id, 2778, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2787, "\"", 2805, 2);
            WriteAttributeValue("", 2795, "a+", 2795, 2, true);
#nullable restore
#line 76 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml"
WriteAttributeValue("", 2797, item.Id, 2797, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 2806, "\"", 2822, 1);
#nullable restore
#line 76 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml"
WriteAttributeValue("", 2814, counter, 2814, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /><label>");
#nullable restore
#line 76 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml"
                                                                                                                                      Write(item.Answer1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></li>\r\n                                    <li><input");
            BeginWriteAttribute("id", " id=\"", 2907, "\"", 2922, 2);
            WriteAttributeValue("", 2912, "b+", 2912, 2, true);
#nullable restore
#line 77 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml"
WriteAttributeValue("", 2914, item.Id, 2914, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"radio\"");
            BeginWriteAttribute("name", " name=\"", 2936, "\"", 2953, 2);
            WriteAttributeValue("", 2943, "a+", 2943, 2, true);
#nullable restore
#line 77 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml"
WriteAttributeValue("", 2945, item.Id, 2945, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2954, "\"", 2972, 2);
            WriteAttributeValue("", 2962, "b+", 2962, 2, true);
#nullable restore
#line 77 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml"
WriteAttributeValue("", 2964, item.Id, 2964, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 2973, "\"", 2989, 1);
#nullable restore
#line 77 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml"
WriteAttributeValue("", 2981, counter, 2981, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /><label>");
#nullable restore
#line 77 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml"
                                                                                                                                      Write(item.Answer2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></li>\r\n                                    <li><input");
            BeginWriteAttribute("id", " id=\"", 3074, "\"", 3089, 2);
            WriteAttributeValue("", 3079, "c+", 3079, 2, true);
#nullable restore
#line 78 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml"
WriteAttributeValue("", 3081, item.Id, 3081, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"radio\"");
            BeginWriteAttribute("name", " name=\"", 3103, "\"", 3120, 2);
            WriteAttributeValue("", 3110, "a+", 3110, 2, true);
#nullable restore
#line 78 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml"
WriteAttributeValue("", 3112, item.Id, 3112, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 3121, "\"", 3139, 2);
            WriteAttributeValue("", 3129, "c+", 3129, 2, true);
#nullable restore
#line 78 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml"
WriteAttributeValue("", 3131, item.Id, 3131, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 3140, "\"", 3156, 1);
#nullable restore
#line 78 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml"
WriteAttributeValue("", 3148, counter, 3148, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /><label>");
#nullable restore
#line 78 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml"
                                                                                                                                      Write(item.Answer3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></li>\r\n                                    <li><input");
            BeginWriteAttribute("id", " id=\"", 3241, "\"", 3256, 2);
            WriteAttributeValue("", 3246, "d+", 3246, 2, true);
#nullable restore
#line 79 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml"
WriteAttributeValue("", 3248, item.Id, 3248, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"radio\"");
            BeginWriteAttribute("name", " name=\"", 3270, "\"", 3287, 2);
            WriteAttributeValue("", 3277, "a+", 3277, 2, true);
#nullable restore
#line 79 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml"
WriteAttributeValue("", 3279, item.Id, 3279, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 3288, "\"", 3306, 2);
            WriteAttributeValue("", 3296, "d+", 3296, 2, true);
#nullable restore
#line 79 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml"
WriteAttributeValue("", 3298, item.Id, 3298, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 3307, "\"", 3323, 1);
#nullable restore
#line 79 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml"
WriteAttributeValue("", 3315, counter, 3315, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /><label>");
#nullable restore
#line 79 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml"
                                                                                                                                      Write(item.Answer4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></li>\r\n                                    <input type=\"hidden\"");
            BeginWriteAttribute("class", " class=\"", 3418, "\"", 3438, 1);
#nullable restore
#line 80 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml"
WriteAttributeValue("", 3426, ++counter, 3426, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                </ul>\r\n                            </div>\r\n                        </div>\r\n                        <hr />\r\n");
#nullable restore
#line 85 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"text\" style=\"display:none\" class=\"answer1\" name=\"answer1\"");
            BeginWriteAttribute("value", " value=\"", 3698, "\"", 3706, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <input type=\"text\" style=\"display:none\" class=\"answer2\" name=\"answer2\"");
            BeginWriteAttribute("value", " value=\"", 3802, "\"", 3810, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <input type=\"text\" style=\"display:none\" class=\"answer3\" name=\"answer3\"");
            BeginWriteAttribute("value", " value=\"", 3906, "\"", 3914, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <input type=\"text\" style=\"display:none\" class=\"answer4\" name=\"answer4\"");
            BeginWriteAttribute("value", " value=\"", 4010, "\"", 4018, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <input type=\"text\" style=\"display:none\" class=\"answer5\" name=\"answer5\"");
            BeginWriteAttribute("value", " value=\"", 4114, "\"", 4122, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <input type=\"text\" style=\"display:none\" class=\"result\"");
            BeginWriteAttribute("value", " value=\"", 4202, "\"", 4225, 1);
#nullable restore
#line 92 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml"
WriteAttributeValue("", 4210, ViewBag.Result, 4210, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    <div class=""row"">
                        <div class=""col-sm-10""></div>
                        <div class=""col-sm-2"">
                            <input type=""submit"" class=""btn btn-primary btn-lg btn-block"" value=""Submit"" />
                        </div>
                    </div>
");
            WriteLiteral("                    <!-- Button trigger modal -->\r\n");
            WriteLiteral(@"                    <div class=""modal fade"" tabindex=""-1"" role=""dialog"" id=""details-modal"" data-keyboard=""false"" data-backdrop=""static"">
                        <div class=""modal-dialog"">
                            <div class=""modal-content"">
                                <div class=""modal-header"" style=""margin-left: 36%;"">
                                    <h5 class=""modal-title"">Time out</h5>
                                </div>
                                <div class=""modal-body text-center"">
                                    <input type=""submit"" class=""abc"" id=""submit"" value=""submit"" name=""submit"" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- Button trigger modal -->
                    <!-- Button trigger modal -->
");
            WriteLiteral(@"                    <div class=""modal fade"" tabindex=""-1"" role=""dialog"" id=""result-modal"" data-keyboard=""false"" data-backdrop=""static"">
                        <div class=""modal-dialog"">
                            <div class=""modal-content"">
                                <div class=""modal-header"" style=""margin-left: 36%;"">
                                    <h5 class=""modal-title"">Your Result</h5>
                                </div>
                                <div class=""modal-body text-center"">
                                    <p>");
#nullable restore
#line 124 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml"
                                  Write(ViewBag.Point);

#line default
#line hidden
#nullable disable
            WriteLiteral(" points</p><br />\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ab7734c13dff10d2d6ef1db23d6156360f21a2b21704", async() => {
                WriteLiteral("<input type=\"button\" class=\"abc\" id=\"submit\" value=\"Back to Exam\" name=\"submit\" />");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <!-- Button trigger modal -->\r\n");
#nullable restore
#line 131 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\ComputerExam.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"col-md-3\"></div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script>
        $(function () {
            //$('button.details').on('click', function () {
            //    //alert(""abc"");
            //    $('#details-modal').modal('show');
            //});
            $('input.1').on('click', function () {
                $('.answer1').val("""");
                let a = $(this).val();
                $('.answer1').val(a);
            });
            $('input.2').on('click', function () {
                $('.answer2').val("""");
                let a = $(this).val();
                $('.answer2').val(a);
            });
            $('input.3').on('click', function () {
                $('.answer3').val("""");
                let a = $(this).val();
                $('.answer3').val(a);
            });
            $('input.4').on('click', function () {
                $('.answer4').val("""");
                let a = $(this).val();
                $('.answer4').val(a);
            });
            $('input.5').on('click', function () {
        ");
                WriteLiteral(@"        $('.answer5').val("""");
                let a = $(this).val();
                $('.answer5').val(a);
            });

            if ($('input.result').val() == ""done"") {
                $('#result-modal').modal('show');
            }

        })



        function startTimer(duration, display) {
            var timer = duration, minutes, seconds;
            var countdown = setInterval(function () {
                minutes = parseInt(timer / 60, 10);
                seconds = parseInt(timer % 60, 10);

                minutes = minutes < 10 ? ""0"" + minutes : minutes;
                seconds = seconds < 10 ? ""0"" + seconds : seconds;

                display.textContent = minutes + "":"" + seconds;

                if (--timer < 0) {
                    timer = duration;
                }
                if (seconds == ""00"" && minutes == ""00"") {
                    clearTimeout(countdown);
                    $(function () {
                        if ($(""input.checking"").va");
                WriteLiteral(@"l() == 'open') {
                            $('#details-modal').modal('show');
                        }

                    })
                }
            }, 1000);
        }

        window.onload = function () {
            if ($(""input.checking"").val() == 'open') {
                var timeout = 10,
                    display = document.querySelector('#time');
                startTimer(timeout, display);
            }
        };



    </script>





    <!--jQuery and JS bundle w / Popper.js -->
    <script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js"" integrity=""sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-ho+j7jyWK8fNQe+A12Hb8AhRq26LrZ/JpcUGGOn+Y7RsweNrtN/tE3MoK7ZeZDyx"" crossorigin=""anonymous""></script>

");
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
