#pragma checksum "D:\Group03_Project\Project_Group3\Views\Lesson\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b0d465e6ce587126b33ded2c67a4fb5748f7c18d974799089c08ff50d2672b9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lesson_Index), @"mvc.1.0.view", @"/Views/Lesson/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Group03_Project\Project_Group3\Views\_ViewImports.cshtml"
using Project_Group3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Group03_Project\Project_Group3\Views\_ViewImports.cshtml"
using Project_Group3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b0d465e6ce587126b33ded2c67a4fb5748f7c18d974799089c08ff50d2672b9a", @"/Views/Lesson/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9414e8f56e2cc2d04e73044b10dc6e2cfbadc9fd54b07a1fac15f562fe514924", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Lesson_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebLibrary.Models.Lesson>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/fonts/boxicons.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("table-search d-flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/lesson"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Group03_Project\Project_Group3\Views\Lesson\Index.cshtml"
  
    ViewData["Title"] = "Course Management | Lesson";
    Layout = "~/Views/Shared/_LayoutCourse.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b0d465e6ce587126b33ded2c67a4fb5748f7c18d974799089c08ff50d2672b9a6002", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b0d465e6ce587126b33ded2c67a4fb5748f7c18d974799089c08ff50d2672b9a7140", async() => {
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 10 "D:\Group03_Project\Project_Group3\Views\Lesson\Index.cshtml"
  
    var idInstructor = int.Parse(Context.Request.Cookies["ID"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card bg-theme p-0 mt-2 mb-5\">\r\n    <div class=\"container no-footer mt-4 mb-3 p-0\">\r\n        <div class=\"text-primary mb-4\">\r\n            <a class=\"mb-5\"");
            BeginWriteAttribute("href", " href=\"", 509, "\"", 572, 1);
#nullable restore
#line 17 "D:\Group03_Project\Project_Group3\Views\Lesson\Index.cshtml"
WriteAttributeValue("", 516, Url.Action("Index", "course", new {id = @idInstructor}), 516, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Course </a>/\r\n            <a class=\"mb-5\"");
            BeginWriteAttribute("href", " href=\"", 615, "\"", 690, 1);
#nullable restore
#line 18 "D:\Group03_Project\Project_Group3\Views\Lesson\Index.cshtml"
WriteAttributeValue("", 622, Url.Action("Index", "chapter", new { courseId = ViewBag.CourseId }), 622, 68, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Chapter </a>/\r\n            <a class=\"mb-5\" href=\"javascript:void(0);\">Lesson</a>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-12 col-md-6\">\r\n                <div class=\"container-fluid\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0d465e6ce587126b33ded2c67a4fb5748f7c18d974799089c08ff50d2672b9a9791", async() => {
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"chapterId\"");
                BeginWriteAttribute("value", " value=\"", 1044, "\"", 1070, 1);
#nullable restore
#line 25 "D:\Group03_Project\Project_Group3\Views\Lesson\Index.cshtml"
WriteAttributeValue("", 1052, ViewBag.ChapterId, 1052, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"courseId\"");
                BeginWriteAttribute("value", " value=\"", 1136, "\"", 1157, 1);
#nullable restore
#line 26 "D:\Group03_Project\Project_Group3\Views\Lesson\Index.cshtml"
WriteAttributeValue("", 1144, idInstructor, 1144, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1214, "\"", 1237, 1);
#nullable restore
#line 27 "D:\Group03_Project\Project_Group3\Views\Lesson\Index.cshtml"
WriteAttributeValue("", 1222, ViewBag.search, 1222, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" type=""search"" name=""search""
                            placeholder=""Search"">
                        <button class=""btn btn-primary btn-outline-primary ml-2"" type=""submit"">
                            <i class='bx bx-search-alt-2'></i>
                        </button>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-sm-12 col-md-6 float-right\">\r\n                <a class=\"btn btn-success mb-2 float-right\"");
            BeginWriteAttribute("href", " href=\"", 1705, "\"", 1829, 1);
#nullable restore
#line 36 "D:\Group03_Project\Project_Group3\Views\Lesson\Index.cshtml"
WriteAttributeValue("", 1712, Url.Action("Create", "Lesson", 
                new { chapterId = ViewBag.ChapterId, courseId = ViewBag.CourseId }), 1712, 117, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Add new Lesson</a>
            </div>
        </div>
    </div>
    <div class=""container p-0 mt-3"">
        <table class=""datatables-basic table mb-5"">
            <thead>
                <tr>
                    <th width=""10""><input type=""checkbox"" id=""all"" class=""checkbox-item""></th>
                    <th width=""200"" class=""text-theme"">Lesson Name</th>
                    <th width=""70"" class=""text-theme"">Index</th>
                    <th width=""100"" class=""text-theme"">Description</th>
                    <th width=""150"" class=""text-theme"">Percent To Passed</th>
                    <th width=""100"" class=""text-theme"">Content</th>
                    <th width=""100"" class=""text-theme"">Action</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 55 "D:\Group03_Project\Project_Group3\Views\Lesson\Index.cshtml"
                 if (Model != null)
                {
                    foreach (var lesson in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td class=\"dt-checkboxes-cell\">\r\n                                <input type=\"checkbox\">\r\n                            </td>\r\n                            <td>");
#nullable restore
#line 63 "D:\Group03_Project\Project_Group3\Views\Lesson\Index.cshtml"
                           Write(lesson.LessonName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-center\">");
#nullable restore
#line 64 "D:\Group03_Project\Project_Group3\Views\Lesson\Index.cshtml"
                                               Write(lesson.Index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 65 "D:\Group03_Project\Project_Group3\Views\Lesson\Index.cshtml"
                           Write(lesson.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-center\">");
#nullable restore
#line 66 "D:\Group03_Project\Project_Group3\Views\Lesson\Index.cshtml"
                                               Write(lesson.PercentToPassed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 67 "D:\Group03_Project\Project_Group3\Views\Lesson\Index.cshtml"
                           Write(lesson.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-theme\">\r\n                                <div class=\"action-icon d-flex text-center\">\r\n                                    <a class=\"btn btn-warning mr-2\"");
            BeginWriteAttribute("href", "\r\n                                        href=\"", 3457, "\"", 3563, 1);
#nullable restore
#line 71 "D:\Group03_Project\Project_Group3\Views\Lesson\Index.cshtml"
WriteAttributeValue("", 3505, Url.Action("Edit", "Lesson", new {id = @lesson.LessonId}), 3505, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Edit\">\r\n                                        <i class=\'bx bxs-edit\'></i>\r\n                                    </a>\r\n                                    <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", "  href=\"", 3752, "\"", 3820, 1);
#nullable restore
#line 74 "D:\Group03_Project\Project_Group3\Views\Lesson\Index.cshtml"
WriteAttributeValue("", 3760, Url.Action("Delete", "Lesson", new {id = @lesson.LessonId}), 3760, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                                        title=""Delete"">
                                        <i class='bx bxs-trash-alt'></i>
                                    </a>
                                </div>
                            </td>
                        </tr>
");
#nullable restore
#line 81 "D:\Group03_Project\Project_Group3\Views\Lesson\Index.cshtml"
                    }
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td colspan=\"11\">No lessons found.</td>\r\n                    </tr>\r\n");
#nullable restore
#line 88 "D:\Group03_Project\Project_Group3\Views\Lesson\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b0d465e6ce587126b33ded2c67a4fb5748f7c18d974799089c08ff50d2672b9a18419", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebLibrary.Models.Lesson>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
