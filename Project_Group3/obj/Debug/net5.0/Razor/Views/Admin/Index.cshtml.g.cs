#pragma checksum "D:\Group03_Project\Project_Group3\Views\Admin\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "02b71f02f7009004062c6a5cb975ebdd12fcdc0d4657a26ed4f7cd0cb27475ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"02b71f02f7009004062c6a5cb975ebdd12fcdc0d4657a26ed4f7cd0cb27475ae", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9414e8f56e2cc2d04e73044b10dc6e2cfbadc9fd54b07a1fac15f562fe514924", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<IEnumerable<WebLibrary.Models.Admin>, IEnumerable<WebLibrary.Models.Learner>, 
    IEnumerable<WebLibrary.Models.Instructor>, IEnumerable<WebLibrary.Models.Course>>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/fonts/boxicons.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/avatars/birdEdu.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("140"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Group03_Project\Project_Group3\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "02b71f02f7009004062c6a5cb975ebdd12fcdc0d4657a26ed4f7cd0cb27475ae5343", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "02b71f02f7009004062c6a5cb975ebdd12fcdc0d4657a26ed4f7cd0cb27475ae6481", async() => {
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
            WriteLiteral(@"
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/chart.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.9.4/Chart.js""></script>

<!-- Content wrapper -->
<div class=""content-wrapper"">
<!-- Content --> 

<div class=""container-xxl flex-grow-1 container-p-y"">
    <div class=""row"">
        <div class=""col-lg-8"" style=""height: 200px;"">
            <div class=""card bg-theme"">
                <div class=""d-flex align-items-end row"">
                    <div class=""col-sm-7"">
                        <div class=""card-body"">
                            <h5 class=""card-title text-primary"">Welcome back Admin</h5>
                            <p class=""mb-4 text-theme"">
                                These are the metrics about our website users.</p>
                        </div>
                    </div>
                    <div class=""col-sm-5 text-center text-sm-left"">
     ");
            WriteLiteral("                   <div class=\"card-body pb-0 px-0 px-md-4 mb-3\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "02b71f02f7009004062c6a5cb975ebdd12fcdc0d4657a26ed4f7cd0cb27475ae8800", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-4 col-md-4"">
            <div class=""row"">
                <div class=""col-lg-6 col-md-12 col-6 mb-4"">
                    <div class=""card bg-theme"">
                        <div class=""card-body"">
                            <div class=""align-items-start justify-content-between"">
                                <h5 class=""card-title fw-medium text-theme"">Instructor</h5></br>
                            </div>
                                <small class=""float-right text-primary fw-medium"" style=""font-size: 1.2rem;""><i class=""menu-icon tf-icons bx bx-user-voice""></i> +72.80%</small>
                            <div class=""mt-3"">
                                <!-- Nội dung của Instructor -->
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6 col");
            WriteLiteral(@"-md-12 col-6 mb-4"">
                    <div class=""card bg-theme"">
                        <div class=""card-body"">
                            <div class=""align-items-start justify-content-between"">
                                <h5 class=""card-title fw-medium text-theme"">Learner</h5></br>
                            </div>
                                <small class=""float-right text-primary fw-medium"" style=""font-size: 1.2rem;""><i class=""menu-icon tf-icons bx bx-group""></i> +72.80%</small>
                            <div class=""mt-3"">
                                <!-- Nội dung của Learner -->
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6 col-md-12 col-6 mb-4"">
                    <div class=""card bg-theme"">
                        <div class=""card-body"">
                            <div class=""align-items-start justify-content-between"">
                                <h5 class");
            WriteLiteral(@"=""card-title fw-medium text-theme"">Course</h5></br>
                            </div>
                                <small class=""float-right text-primary fw-medium"" style=""font-size: 1.2rem;""><i class=""menu-icon tf-icons bx bx-book""></i> +72.80%</small>
                            <div class=""mt-3"">
                                <!-- Nội dung của Course -->
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6 col-md-12 col-6 mb-4"">
                    <div class=""card bg-theme"">
                        <div class=""card-body"">
                            <div class=""d-flex align-items-start justify-content-between"">
                                <h5 class=""card-title fw-medium text-theme"">Profit</h5>
                                <small class=""text-primary fw-medium""><i class=""bx bx-up-arrow-alt""></i> +72.80%</small>
                            </div>
                            <div cl");
            WriteLiteral(@"ass=""mt-3"">
                                <!-- Nội dung của Profit -->
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Total Revenue -->
        <div class=""col-8 col-lg-8 order-2 order-md-3 order-lg-2 mb-4"" style=""margin-top: -7rem;"">
            <div class=""card bg-theme"">
                <div class=""row row-bordered g-0"">
                    <div class=""col-md-12"">
                        <canvas id=""userChart"" style=""width: 100%; max-width: 100%""></canvas>
                        <script>
                            const xValues = [""2024-03-01"", ""2024-03-02"", ""2024-03-03"", ""2024-03-04"", ""2024-03-05"", ""2024-03-06"", ""2024-03-07""];
                            const yValues = [55, 49, 44, 24, 15, 35, 42];
                            const barColors = [""red"", ""green"", ""blue"", ""orange"", ""brown"", ""purple"", ""pink""];

                            new Chart(""userChart"", {
        ");
            WriteLiteral(@"                        type: ""line"",
                                data: {
                                labels: xValues,
                                datasets: [{
                                    backgroundColor: barColors,
                                    data: yValues
                                }]
                                },
                                options: {
                                legend: { display: false },
                                scales: {
                                    x: {
                                    type: ""time"",
                                    time: {
                                        unit: ""day"",
                                        displayFormats: {
                                        day: ""MMM DD""
                                        }
                                    },
                                    ticks: {
                                        source: ""labels""
                   ");
            WriteLiteral(@"                 }
                                    },
                                    y: {
                                    beginAtZero: true
                                    }
                                },
                                title: {
                                    display: true,
                                    text: ""Number of Successful User Registrations""
                                }
                                }
                            });
                        </script>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-4 col-lg-4 order-2 order-md-3 order-lg-2 mb-4"" style=""margin-top: 0rem;"">
            <div class=""card bg-theme"">
                <div class=""row row-bordered g-0"">
");
            WriteLiteral(@"                        <canvas id=""myChart"" style=""width: 100%; max-width: 600px""></canvas>
                        <script>
                            const xValues = [""Category 1"", ""Category 2"", ""Category 3"", ""Category 4"", ""Category 5""];
                            const yValues = [55, 49, 44, 24, 15];
                            const barColors = [
                                ""#b91d47"",
                                ""#00aba9"",
                                ""#2b5797"",
                                ""#e8c3b9"",
                                ""#1e7145""
                            ];

                            new Chart(""myChart"", {
                                type: ""pie"",
                                data: {
                                labels: xValues,
                                datasets: [{
                                    backgroundColor: barColors,
                                    data: yValues
                                }]
                       ");
            WriteLiteral(@"         },
                                options: {
                                title: {
                                    display: true,
                                    text: ""Course Categories""
                                }
                                }
                            });
                        </script>
");
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <!-- Order Statistics -->\r\n");
            WriteLiteral("    <!--/ Order Statistics -->\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n    <!-- Expense Overview -->\r\n");
            WriteLiteral("    <!--/ Expense Overview -->\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n    <!-- Transactions -->\r\n");
            WriteLiteral("    <!--/ Transactions -->\r\n    </div>\r\n</div>\r\n<!-- / Content -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<IEnumerable<WebLibrary.Models.Admin>, IEnumerable<WebLibrary.Models.Learner>, 
    IEnumerable<WebLibrary.Models.Instructor>, IEnumerable<WebLibrary.Models.Course>>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
