#pragma checksum "D:\IT Step\C#\QuotesArtGeneratorRepo\QuoteArtGenerator\QuotesArtGenerator\QuotesArtGenerator\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7cca3a000be3260b4d68386e13012df03b734b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\IT Step\C#\QuotesArtGeneratorRepo\QuoteArtGenerator\QuotesArtGenerator\QuotesArtGenerator\Views\_ViewImports.cshtml"
using QuotesArtGenerator;

#line default
#line hidden
#line 2 "D:\IT Step\C#\QuotesArtGeneratorRepo\QuoteArtGenerator\QuotesArtGenerator\QuotesArtGenerator\Views\_ViewImports.cshtml"
using QuotesArtGenerator.Models;

#line default
#line hidden
#line 2 "D:\IT Step\C#\QuotesArtGeneratorRepo\QuoteArtGenerator\QuotesArtGenerator\QuotesArtGenerator\Views\Home\Index.cshtml"
using QuotesArtGenerator.Controllers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7cca3a000be3260b4d68386e13012df03b734b0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53ced316705c0057e4da66124b72b95764ce7fd5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuotesArtGenerator.Models.Quote>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(80, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\IT Step\C#\QuotesArtGeneratorRepo\QuoteArtGenerator\QuotesArtGenerator\QuotesArtGenerator\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "QuoteGen";

#line default
#line hidden
            BeginContext(126, 16, true);
            WriteLiteral("\r\n<h1>Category: ");
            EndContext();
            BeginContext(143, 40, false);
#line 8 "D:\IT Step\C#\QuotesArtGeneratorRepo\QuoteArtGenerator\QuotesArtGenerator\QuotesArtGenerator\Views\Home\Index.cshtml"
         Write(Html.DisplayFor(model => model.CATEGORY));

#line default
#line hidden
            EndContext();
            BeginContext(183, 97, true);
            WriteLiteral("</h1>\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dd class=\"col-sm-10\">\r\n            <h4>\"");
            EndContext();
            BeginContext(281, 37, false);
#line 13 "D:\IT Step\C#\QuotesArtGeneratorRepo\QuoteArtGenerator\QuotesArtGenerator\QuotesArtGenerator\Views\Home\Index.cshtml"
            Write(Html.DisplayFor(model => model.QUOTE));

#line default
#line hidden
            EndContext();
            BeginContext(318, 69, true);
            WriteLiteral("\"</h4>\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 387, "\"", 457, 2);
            WriteAttributeValue("", 394, "/Home/GetWikiUrl?author=", 394, 24, true);
#line 16 "D:\IT Step\C#\QuotesArtGeneratorRepo\QuoteArtGenerator\QuotesArtGenerator\QuotesArtGenerator\Views\Home\Index.cshtml"
WriteAttributeValue("", 418, Html.DisplayFor(model => model.AUTHOR), 418, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(458, 25, true);
            WriteLiteral(">\r\n                <h5>- ");
            EndContext();
            BeginContext(484, 38, false);
#line 17 "D:\IT Step\C#\QuotesArtGeneratorRepo\QuoteArtGenerator\QuotesArtGenerator\QuotesArtGenerator\Views\Home\Index.cshtml"
                 Write(Html.DisplayFor(model => model.AUTHOR));

#line default
#line hidden
            EndContext();
            BeginContext(522, 78, true);
            WriteLiteral("</h5>\r\n            </a>\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<hr />\r\n<div>\r\n    ");
            EndContext();
            BeginContext(600, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7cca3a000be3260b4d68386e13012df03b734b07173", async() => {
                BeginContext(690, 8, true);
                WriteLiteral("Generate");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(702, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuotesArtGenerator.Models.Quote> Html { get; private set; }
    }
}
#pragma warning restore 1591