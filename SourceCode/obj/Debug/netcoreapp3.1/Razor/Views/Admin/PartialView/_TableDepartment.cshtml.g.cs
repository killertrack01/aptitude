#pragma checksum "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Admin\PartialView\_TableDepartment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d792d2544c4f1da92263970601d397843002c55c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_PartialView__TableDepartment), @"mvc.1.0.view", @"/Views/Admin/PartialView/_TableDepartment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d792d2544c4f1da92263970601d397843002c55c", @"/Views/Admin/PartialView/_TableDepartment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3293b3d850df3ce24076145fdd62ef046ce5541", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_PartialView__TableDepartment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Aptitude.Models.Department>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Department_Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<table class=""table"" id=""table1"">
    <thead class=""thead-dark"">
        <tr>
            <th>Name</th>
            <th>Details</th>
            <th>Requirement</th>
            <th>Location</th>
            <th>Welfare</th>
            <th>Salary</th>
            <th>Action</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 15 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Admin\PartialView\_TableDepartment.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n                <td>");
#nullable restore
#line 19 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Admin\PartialView\_TableDepartment.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <button type=\"button\" class=\"btn btn-secondary\" data-toggle=\"modal\" data-target=\"#d-");
#nullable restore
#line 21 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Admin\PartialView\_TableDepartment.cshtml"
                                                                                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        Details\r\n                    </button>\r\n                    <!-- Modal -->\r\n                    <!-- Modal -->\r\n                    <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 804, "\"", 819, 2);
            WriteAttributeValue("", 809, "d-", 809, 2, true);
#nullable restore
#line 26 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Admin\PartialView\_TableDepartment.cshtml"
WriteAttributeValue("", 811, item.Id, 811, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                        <div class=""modal-dialog"" role=""document"">
                            <div class=""modal-content"">
                                <div class=""modal-header"">
                                    <h5 class=""modal-title"">");
#nullable restore
#line 30 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Admin\PartialView\_TableDepartment.cshtml"
                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                        <span aria-hidden=""true"">&times;</span>
                                    </button>
                                </div>
                                <div class=""modal-body"">
                                    ");
#nullable restore
#line 36 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Admin\PartialView\_TableDepartment.cshtml"
                               Write(Html.Raw(item.Detail));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                                <div class=""modal-footer"">
                                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </td>
                <td>");
#nullable restore
#line 45 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Admin\PartialView\_TableDepartment.cshtml"
               Write(Html.Raw(item.Requirement));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 46 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Admin\PartialView\_TableDepartment.cshtml"
               Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 47 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Admin\PartialView\_TableDepartment.cshtml"
               Write(Html.Raw(item.Welfare));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 48 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Admin\PartialView\_TableDepartment.cshtml"
               Write(item.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d792d2544c4f1da92263970601d397843002c55c9335", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Admin\PartialView\_TableDepartment.cshtml"
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
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 54 "C:\Users\Admin\Desktop\Sem_3_T1.1907.M0_Group_1_Aptitude_Online\SourceCode\Views\Admin\PartialView\_TableDepartment.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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