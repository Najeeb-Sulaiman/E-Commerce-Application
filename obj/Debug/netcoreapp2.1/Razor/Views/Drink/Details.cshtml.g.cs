#pragma checksum "C:\Users\FINTRAK\Documents\Visual Studio 2019\DrinkAndGo\Views\Drink\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "733c481d2394eba3003810b98a816ab4e41df1dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Drink_Details), @"mvc.1.0.view", @"/Views/Drink/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Drink/Details.cshtml", typeof(AspNetCore.Views_Drink_Details))]
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
#line 1 "C:\Users\FINTRAK\Documents\Visual Studio 2019\DrinkAndGo\Views\_ViewImports.cshtml"
using DrinkAndGo;

#line default
#line hidden
#line 2 "C:\Users\FINTRAK\Documents\Visual Studio 2019\DrinkAndGo\Views\_ViewImports.cshtml"
using DrinkAndGo.Models;

#line default
#line hidden
#line 3 "C:\Users\FINTRAK\Documents\Visual Studio 2019\DrinkAndGo\Views\_ViewImports.cshtml"
using DrinkAndGo.Data.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\FINTRAK\Documents\Visual Studio 2019\DrinkAndGo\Views\_ViewImports.cshtml"
using DrinkAndGo.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"733c481d2394eba3003810b98a816ab4e41df1dc", @"/Views/Drink/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"441c0246b2ac595a7126de0825f7df75e7befe95", @"/Views/_ViewImports.cshtml")]
    public class Views_Drink_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DrinkAndGo.Data.Models.Drink>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cartButton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(37, 109, true);
            WriteLiteral("\r\n<div class=\"col-sm-12 col-lg-12 col-md-12\">\r\n    <div class=\"thumbnail\">\r\n        <img class=\"card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 146, "\"", 176, 1);
#line 5 "C:\Users\FINTRAK\Documents\Visual Studio 2019\DrinkAndGo\Views\Drink\Details.cshtml"
WriteAttributeValue("", 152, Model.ImageThumbnailUrl, 152, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(177, 112, true);
            WriteLiteral(" style=\"width:300px; height:200px\" alt=\"\" />\r\n        <div class=\"caption\">\r\n            <h3 class=\"pull-right\">");
            EndContext();
            BeginContext(290, 25, false);
#line 7 "C:\Users\FINTRAK\Documents\Visual Studio 2019\DrinkAndGo\Views\Drink\Details.cshtml"
                              Write(Model.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(315, 70, true);
            WriteLiteral("</h3>\r\n            <h1>\r\n                <strong class=\"text-primary\">");
            EndContext();
            BeginContext(386, 10, false);
#line 9 "C:\Users\FINTRAK\Documents\Visual Studio 2019\DrinkAndGo\Views\Drink\Details.cshtml"
                                        Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(396, 54, true);
            WriteLiteral("</strong>\r\n            </h1>\r\n            <p> <strong>");
            EndContext();
            BeginContext(451, 22, false);
#line 11 "C:\Users\FINTRAK\Documents\Visual Studio 2019\DrinkAndGo\Views\Drink\Details.cshtml"
                   Write(Model.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(473, 50, true);
            WriteLiteral("</strong></p>\r\n            <br />\r\n            <p>");
            EndContext();
            BeginContext(524, 21, false);
#line 13 "C:\Users\FINTRAK\Documents\Visual Studio 2019\DrinkAndGo\Views\Drink\Details.cshtml"
          Write(Model.LongDescription);

#line default
#line hidden
            EndContext();
            BeginContext(545, 115, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"addToCart text-right\">\r\n            <p class=\"button \">\r\n                ");
            EndContext();
            BeginContext(660, 194, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe43fc69215e4d55a3de85cfeca06e59", async() => {
                BeginContext(799, 51, true);
                WriteLiteral("\r\n                    Add to cart\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-drinkId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 17 "C:\Users\FINTRAK\Documents\Visual Studio 2019\DrinkAndGo\Views\Drink\Details.cshtml"
                                                                                                                               WriteLiteral(Model.DrinkId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["drinkId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-drinkId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["drinkId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(854, 54, true);
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DrinkAndGo.Data.Models.Drink> Html { get; private set; }
    }
}
#pragma warning restore 1591
