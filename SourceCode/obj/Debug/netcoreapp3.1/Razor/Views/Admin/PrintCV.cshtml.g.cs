#pragma checksum "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Admin\PrintCV.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79113bf7b40e54c9e8171951ba0881f4474df454"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_PrintCV), @"mvc.1.0.view", @"/Views/Admin/PrintCV.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79113bf7b40e54c9e8171951ba0881f4474df454", @"/Views/Admin/PrintCV.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3293b3d850df3ce24076145fdd62ef046ce5541", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_PrintCV : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Aptitude.Models.HR>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Admin\PrintCV.cshtml"
  

    ViewData["Title"] = "Print CV";
    Layout = "~/Views/Admin/_pPrintCV.cshtml";
 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    body {
        background: -webkit-linear-gradient(left, #3931af, #00c6ff);
    }

    .emp-profile {
        padding: 3%;
        margin-top: 3%;
        margin-bottom: 3%;
        border-radius: 0.5rem;
        background: #fff;
    }

    .profile-img {
        text-align: center;
    }

        .profile-img img {
            width: 70%;
            height: 100%;
        }

        .profile-img .file {
            position: relative;
            overflow: hidden;
            margin-top: -20%;
            width: 70%;
            border: none;
            border-radius: 0;
            font-size: 15px;
            background: #212529b8;
        }

            .profile-img .file input {
                position: absolute;
                opacity: 0;
                right: 0;
                top: 0;
            }

    .profile-head h5 {
        color: #333;
    }

    .profile-head h6 {
        color: #0062cc;
    }

    .profile-edit-btn {
        ");
            WriteLiteral(@"border: none;
        border-radius: 1.5rem;
        width: 70%;
        padding: 2%;
        font-weight: 600;
        color: #6c757d;
        cursor: pointer;
    }

    .proile-rating {
        font-size: 12px;
        color: #818182;
        margin-top: 5%;
    }

        .proile-rating span {
            color: #495057;
            font-size: 15px;
            font-weight: 600;
        }

    .profile-head .nav-tabs {
        margin-bottom: 5%;
    }

        .profile-head .nav-tabs .nav-link {
            font-weight: 600;
            border: none;
        }

            .profile-head .nav-tabs .nav-link.active {
                border: none;
                border-bottom: 2px solid #0062cc;
            }

    .profile-work {
        padding: 14%;
        margin-top: -15%;
    }

        .profile-work p {
            font-size: 12px;
            color: #818182;
            font-weight: 600;
            margin-top: 10%;
        }

        .profile-work a {
");
            WriteLiteral(@"            text-decoration: none;
            color: #495057;
            font-weight: 600;
            font-size: 14px;
        }

        .profile-work ul {
            list-style: none;
        }

    .profile-tab label {
        font-weight: 600;
    }

    .profile-tab p {
        font-weight: 600;
        color: #0062cc;
    }
</style>
<link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js""></script>
<script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>

<div class=""container emp-profile"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79113bf7b40e54c9e8171951ba0881f4474df4546682", async() => {
                WriteLiteral(@"
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""tab-content profile-tab"" id=""myTabContent"">
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <label>First Name</label>
                        </div>
                        <div class=""col-md-6"">
                            <p>");
#nullable restore
#line 138 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Admin\PrintCV.cshtml"
                          Write(Model.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <label>Last Name</label>
                        </div>
                        <div class=""col-md-6"">
                            <p>");
#nullable restore
#line 146 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Admin\PrintCV.cshtml"
                          Write(Model.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <label>Email</label>
                        </div>
                        <div class=""col-md-6"">
                            <p>");
#nullable restore
#line 154 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Admin\PrintCV.cshtml"
                          Write(Model.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <label>University</label>
                        </div>
                        <div class=""col-md-6"">
                            <p>");
#nullable restore
#line 162 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Admin\PrintCV.cshtml"
                          Write(Model.University);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <label>Mark</label>
                        </div>
                        <div class=""col-md-6"">
                            <p>");
#nullable restore
#line 170 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Admin\PrintCV.cshtml"
                          Write(Model.Mark);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <label>Personal Detail</label>
                        </div>
                        <div class=""col-md-6"">
                            <p>");
#nullable restore
#line 178 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Admin\PrintCV.cshtml"
                          Write(Model.PersonalDetail);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <label>Advantage</label>
                        </div>
                        <div class=""col-md-6"">
                            <p>");
#nullable restore
#line 186 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Admin\PrintCV.cshtml"
                          Write(Model.Advantage);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <label>Disadvantage</label>
                        </div>
                        <div class=""col-md-6"">
                            <p>");
#nullable restore
#line 194 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Admin\PrintCV.cshtml"
                          Write(Model.Disadvantage);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <label>Hobby</label>
                        </div>
                        <div class=""col-md-6"">
                            <p>");
#nullable restore
#line 202 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Admin\PrintCV.cshtml"
                          Write(Model.Hobby);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <label>Language</label>
                        </div>
                        <div class=""col-md-6"">
                            <p>");
#nullable restore
#line 210 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Admin\PrintCV.cshtml"
                          Write(Model.Language);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <label>Experience</label>
                        </div>
                        <div class=""col-md-6"">
                            <p>");
#nullable restore
#line 218 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Admin\PrintCV.cshtml"
                          Write(Model.Experience);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <label>Project</label>
                        </div>
                        <div class=""col-md-6"">
                            <p>");
#nullable restore
#line 226 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Admin\PrintCV.cshtml"
                          Write(Model.Project);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <label>Last Postion</label>
                        </div>
                        <div class=""col-md-6"">
                            <p>");
#nullable restore
#line 234 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Admin\PrintCV.cshtml"
                          Write(Model.LastPostion);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                        </div>
                    </div>
                    <!--row-->
                    <div class=""row"">
                        <div class=""col-lg-9""></div>
                        <div class=""col-lg-2"">
                            <button onclick=""window.print()"">Print this page</button>
                        </div>
                        <div class=""col-lg-1""></div>
                    </div><!--/.row-->
                </div>
                </div>
            </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Aptitude.Models.HR> Html { get; private set; }
    }
}
#pragma warning restore 1591
