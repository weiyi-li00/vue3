#pragma checksum "/Users/nimo/Desktop/vue3/Pages/tab.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4151f5e81479430f447891711d508abc363b23d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(vue3.Pages.Pages_tab), @"mvc.1.0.razor-page", @"/Pages/tab.cshtml")]
namespace vue3.Pages
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
#line 1 "/Users/nimo/Desktop/vue3/Pages/_ViewImports.cshtml"
using vue3;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4151f5e81479430f447891711d508abc363b23d", @"/Pages/tab.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7db56d529ea734b9d1f1cab84199214e4883a228", @"/Pages/_ViewImports.cshtml")]
    public class Pages_tab : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/nimo/Desktop/vue3/Pages/tab.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<html>\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4151f5e81479430f447891711d508abc363b23d3034", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <meta name=""viewport"" content=""width=device-width,initial-scale=1.0"" />
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-BmbxuPwQa2lc/FVzBcNJ7UAyJxM6wuqIj61tLrc4wSX0szH/Ev+nYRRuWlolflfl"" crossorigin=""anonymous"">
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-b5kHyXgcpbZJO/tY9Ul7kGkf1S0CWuKcCD38l8YkeH8z8QjE0GmW1gYU5S9FOnJ0"" crossorigin=""anonymous""></script>
    <link rel=""stylesheet"" href=""./css/create1.css"">
    <title>TECS-Create</title>
  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4151f5e81479430f447891711d508abc363b23d4639", async() => {
                WriteLiteral("\n    <div id=\"app\">\n        <el-container>\n          <el-header><a href=\"./create1.html\"  ><img src=\"./img/settings.png\" id=\"logo\"");
                BeginWriteAttribute("alt", " alt=\"", 860, "\"", 866, 0);
                EndWriteAttribute();
                WriteLiteral(@" style=""width: 20px;height: 20px;"">TECS-Setting2</a></el-header>
                <el-container>
                  <ul class=""nav nav-pills mb-3"" id=""pills-tab"" role=""tablist"">
                        <li class=""nav-item"" role=""presentation"">
                            <button class=""nav-link active"" id=""pills-home-tab"" data-bs-toggle=""pill"" data-bs-target=""#pills-home"" type=""button"" role=""tab"" aria-controls=""pills-home"" aria-selected=""true"">Home</button>
                        </li>
                        <li class=""nav-item"" role=""presentation"">
                            <button class=""nav-link"" id=""pills-profile-tab"" data-bs-toggle=""pill"" data-bs-target=""#pills-profile"" type=""button"" role=""tab"" aria-controls=""pills-profile"" aria-selected=""false"">Profile</button>
                        </li>
                        <li class=""nav-item"" role=""presentation"">
                            <button class=""nav-link"" id=""pills-contact-tab"" data-bs-toggle=""pill"" data-bs-target=""#pills-contact"" type=""button"" role");
                WriteLiteral(@"=""tab"" aria-controls=""pills-contact"" aria-selected=""false"">Contact</button>
                        </li>
                    </ul>
                    <div class=""tab-content"" id=""pills-tabContent"">
                        <div class=""tab-pane fade show active"" id=""pills-home"" role=""tabpanel"" aria-labelledby=""pills-home-tab"">
                            123
                        </div>
                        <div class=""tab-pane fade"" id=""pills-profile"" role=""tabpanel"" aria-labelledby=""pills-profile-tab"">
                            456
                        </div>
                        <div class=""tab-pane fade"" id=""pills-contact"" role=""tabpanel"" aria-labelledby=""pills-contact-tab"">
                            789
                        </div>
                    </div>
                 
                </el-container>
            
          
      
      
    </div>
    <!-- js -->
    <script src=""https://code.jquery.com/jquery-3.6.0.min.js"" integrity=""sha256-/xUj+3OJU5yExlq6GSYGSHk7tPXikynS7ogEvD");
                WriteLiteral(@"ej/m4="" crossorigin=""anonymous""></script>
    <script src=""https://unpkg.com/vue@next""></script>
    <script src=""https://cdn.jsdelivr.net/npm/vue3-sfc-loader/dist/vue3-sfc-loader.js""></script>    <link rel=""stylesheet"" href=""https://unpkg.com/element-plus/lib/theme-chalk/index.css"">
    <script src=""https://unpkg.com/element-plus/lib/index.full.js""></script>
    <script src=""./js/create1.js""></script>
  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
