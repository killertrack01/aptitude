#pragma checksum "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Home\ListJobs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea0713c8b082b26192efcbf8d7ce0eeb0a3e3d28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListJobs), @"mvc.1.0.view", @"/Views/Home/ListJobs.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea0713c8b082b26192efcbf8d7ce0eeb0a3e3d28", @"/Views/Home/ListJobs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3293b3d850df3ce24076145fdd62ef046ce5541", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListJobs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Aptitude.Models.Department>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "JobsDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Home\ListJobs.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Home/userLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--Declare a CSS session-->\r\n");
            DefineSection("css", async() => {
                WriteLiteral(@"
    <style>
        .row.dealer {
            background: #f6f6f6;
            box-shadow: 0 2px 15px 0 rgba(0, 0, 0, 0.16), 0 2px 10px 0 rgba(0, 0, 0, 0.12);
        }

        .link-to-dealer button a {
            color: #fff;
        }

        .link-to-dealer button {
            background-color: #dc3545;
            border: none;
            transition: all ease-out 0.5s;
        }

            .link-to-dealer button:hover {
                cursor: pointer;
                transform: scale(1.1);
            }
    </style>
");
            }
            );
            WriteLiteral("<!--end /. Declare a CSS session-->\r\n<br />\r\n<!--container-->\r\n<div class=\"container\">\r\n");
#nullable restore
#line 34 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Home\ListJobs.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <!--row-->
    <div class=""row"">
        <div class=""col-md-1""></div>
        <!--col-md-8-->
        <div class=""col-md-8"">
            <!--row dealer-->
            <div class=""row dealer"">
                <!--col-md-12-->
                <div class=""col-md-12"">
                    <!--card-->
                    <div class=""card"">
                        <!--card-header-->
                        <div class=""card-header"" style=""text-align:center"">
                            <h3 style=""color:saddlebrown""><i class=""fa fa-fw fa-stack-overflow""></i>");
#nullable restore
#line 49 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Home\ListJobs.cshtml"
                                                                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        </div>
                        <!--/.card-header-->
                        <!--card-body-->
                        <div class=""card-body"">
                            <p>
                                <strong style=""color:grey""><i class=""fa fa-fw fa-arrow-circle-o-right""></i>Salary :<i class=""fa fa-fw fa-dollar""></i> ");
#nullable restore
#line 55 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Home\ListJobs.cshtml"
                                                                                                                                                 Write(item.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong><br />\r\n                                <strong style=\"color:grey\"><i class=\"fa fa-fw fa-arrow-circle-o-right\"></i>Welfare :<i class=\"fa fa-fw fa-child\"></i> ");
#nullable restore
#line 56 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Home\ListJobs.cshtml"
                                                                                                                                                 Write(Html.Raw(item.Welfare));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong><br />\r\n                                <strong style=\"color:grey\"><i class=\"fa fa-fw fa-arrow-circle-o-right\"></i>Location :<i class=\"fa fa-fw fa-flag-checkered\"></i> ");
#nullable restore
#line 57 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Home\ListJobs.cshtml"
                                                                                                                                                           Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong><br />
                            </p>
                        </div><!--/.card-body-->
                        <!--card-footer-->
                        <div class=""card-footer"" style=""text-align:center"">
                            <!--link-to-dealer-->
                            <div class=""link-to-dealer"">
                                <button type=""button"" class=""btn-lg"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea0713c8b082b26192efcbf8d7ce0eeb0a3e3d288056", async() => {
                WriteLiteral("More Description");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Home\ListJobs.cshtml"
                                                                                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</button>
                            </div> <!--/.link-to-dealer-->
                        </div><!--/.card-footer-->
                    </div><!--/.card-->
                    <br />
                </div><!--/.col-md-12-->
            </div><!--/.row dealer-->
            <div class=""col-md-1""></div>
        </div><!--/.col-md-8-->
    </div><!--/.row-->
");
#nullable restore
#line 74 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Home\ListJobs.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div><!--/.container-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Aptitude.Models.Department>> Html { get; private set; }
    }
}
#pragma warning restore 1591