#pragma checksum "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ff8ffc1bd61e8ffd031fce751ac29a39e11cb7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exam_Test), @"mvc.1.0.view", @"/Views/Exam/Test.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ff8ffc1bd61e8ffd031fce751ac29a39e11cb7a", @"/Views/Exam/Test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3293b3d850df3ce24076145fdd62ef046ce5541", @"/Views/_ViewImports.cshtml")]
    public class Views_Exam_Test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Aptitude.Models.Question>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LogOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml"
  
    ViewData["Title"] = "Test";
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
                    <h3>General Exam</h3>
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
#line 43 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml"
                         if (ViewBag.checking == 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h3>Time in <span id=\"time\">00:10</span> seconds!</h3>\r\n                            <input type=\"hidden\" class=\"checking\" value=\"open\" />\r\n");
#nullable restore
#line 47 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml"
                         if (ViewBag.checking == 2)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h3>Time in <span id=\"time\">00:00</span> minutes!</h3>\r\n                            <input type=\"hidden\" class=\"checking\" value=\"done\" />\r\n");
#nullable restore
#line 52 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml"
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
#line 66 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml"
                 using (Html.BeginForm("Test", "Exam", FormMethod.Post))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"card\">\r\n                            <div class=\"card-header\" style=\"text-align:center\">\r\n                                <h5>");
#nullable restore
#line 72 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml"
                               Write(item.QuestionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            </div>\r\n                            <div class=\"card-body\">\r\n                                <ul>\r\n                                    <li><input");
            BeginWriteAttribute("id", " id=\"", 2723, "\"", 2738, 2);
            WriteAttributeValue("", 2728, "a+", 2728, 2, true);
#nullable restore
#line 76 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml"
WriteAttributeValue("", 2730, item.Id, 2730, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"radio\"");
            BeginWriteAttribute("name", " name=\"", 2752, "\"", 2769, 2);
            WriteAttributeValue("", 2759, "a+", 2759, 2, true);
#nullable restore
#line 76 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml"
WriteAttributeValue("", 2761, item.Id, 2761, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2770, "\"", 2788, 2);
            WriteAttributeValue("", 2778, "a+", 2778, 2, true);
#nullable restore
#line 76 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml"
WriteAttributeValue("", 2780, item.Id, 2780, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 2789, "\"", 2805, 1);
#nullable restore
#line 76 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml"
WriteAttributeValue("", 2797, counter, 2797, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /><label>");
#nullable restore
#line 76 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml"
                                                                                                                                      Write(item.Answer1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></li>\r\n                                    <li><input");
            BeginWriteAttribute("id", " id=\"", 2890, "\"", 2905, 2);
            WriteAttributeValue("", 2895, "b+", 2895, 2, true);
#nullable restore
#line 77 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml"
WriteAttributeValue("", 2897, item.Id, 2897, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"radio\"");
            BeginWriteAttribute("name", " name=\"", 2919, "\"", 2936, 2);
            WriteAttributeValue("", 2926, "a+", 2926, 2, true);
#nullable restore
#line 77 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml"
WriteAttributeValue("", 2928, item.Id, 2928, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2937, "\"", 2955, 2);
            WriteAttributeValue("", 2945, "b+", 2945, 2, true);
#nullable restore
#line 77 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml"
WriteAttributeValue("", 2947, item.Id, 2947, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 2956, "\"", 2972, 1);
#nullable restore
#line 77 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml"
WriteAttributeValue("", 2964, counter, 2964, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /><label>");
#nullable restore
#line 77 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml"
                                                                                                                                      Write(item.Answer2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></li>\r\n                                    <li><input");
            BeginWriteAttribute("id", " id=\"", 3057, "\"", 3072, 2);
            WriteAttributeValue("", 3062, "c+", 3062, 2, true);
#nullable restore
#line 78 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml"
WriteAttributeValue("", 3064, item.Id, 3064, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"radio\"");
            BeginWriteAttribute("name", " name=\"", 3086, "\"", 3103, 2);
            WriteAttributeValue("", 3093, "a+", 3093, 2, true);
#nullable restore
#line 78 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml"
WriteAttributeValue("", 3095, item.Id, 3095, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 3104, "\"", 3122, 2);
            WriteAttributeValue("", 3112, "c+", 3112, 2, true);
#nullable restore
#line 78 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml"
WriteAttributeValue("", 3114, item.Id, 3114, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 3123, "\"", 3139, 1);
#nullable restore
#line 78 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml"
WriteAttributeValue("", 3131, counter, 3131, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /><label>");
#nullable restore
#line 78 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml"
                                                                                                                                      Write(item.Answer3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></li>\r\n                                    <li><input");
            BeginWriteAttribute("id", " id=\"", 3224, "\"", 3239, 2);
            WriteAttributeValue("", 3229, "d+", 3229, 2, true);
#nullable restore
#line 79 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml"
WriteAttributeValue("", 3231, item.Id, 3231, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"radio\"");
            BeginWriteAttribute("name", " name=\"", 3253, "\"", 3270, 2);
            WriteAttributeValue("", 3260, "a+", 3260, 2, true);
#nullable restore
#line 79 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml"
WriteAttributeValue("", 3262, item.Id, 3262, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 3271, "\"", 3289, 2);
            WriteAttributeValue("", 3279, "d+", 3279, 2, true);
#nullable restore
#line 79 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml"
WriteAttributeValue("", 3281, item.Id, 3281, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 3290, "\"", 3306, 1);
#nullable restore
#line 79 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml"
WriteAttributeValue("", 3298, counter, 3298, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /><label>");
#nullable restore
#line 79 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml"
                                                                                                                                      Write(item.Answer4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></li>\r\n                                    <input type=\"hidden\"");
            BeginWriteAttribute("class", " class=\"", 3401, "\"", 3421, 1);
#nullable restore
#line 80 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml"
WriteAttributeValue("", 3409, ++counter, 3409, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                </ul>\r\n                            </div>\r\n                        </div>\r\n                        <hr />\r\n");
#nullable restore
#line 85 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"text\" style=\"display:none\" class=\"answer1\" name=\"answer1\"");
            BeginWriteAttribute("value", " value=\"", 3681, "\"", 3689, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <input type=\"text\" style=\"display:none\" class=\"answer2\" name=\"answer2\"");
            BeginWriteAttribute("value", " value=\"", 3785, "\"", 3793, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <input type=\"text\" style=\"display:none\" class=\"answer3\" name=\"answer3\"");
            BeginWriteAttribute("value", " value=\"", 3889, "\"", 3897, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <input type=\"text\" style=\"display:none\" class=\"answer4\" name=\"answer4\"");
            BeginWriteAttribute("value", " value=\"", 3993, "\"", 4001, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <input type=\"text\" style=\"display:none\" class=\"answer5\" name=\"answer5\"");
            BeginWriteAttribute("value", " value=\"", 4097, "\"", 4105, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <input type=\"text\" style=\"display:none\" class=\"result\"");
            BeginWriteAttribute("value", " value=\"", 4185, "\"", 4208, 1);
#nullable restore
#line 92 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml"
WriteAttributeValue("", 4193, ViewBag.Result, 4193, 15, false);

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
#line 124 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml"
                                  Write(ViewBag.Point);

#line default
#line hidden
#nullable disable
            WriteLiteral(" points</p><br />\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ff8ffc1bd61e8ffd031fce751ac29a39e11cb7a21387", async() => {
                WriteLiteral("<input type=\"button\" class=\"abc\" id=\"submit\" value=\"Back to Home\" name=\"submit\" />");
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
#line 131 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Exam\Test.cshtml"
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