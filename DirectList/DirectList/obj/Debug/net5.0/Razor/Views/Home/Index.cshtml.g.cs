#pragma checksum "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02912d2e6e62490c643d60a6bd78580d188a26f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\_ViewImports.cshtml"
using DirectList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\_ViewImports.cshtml"
using DirectList.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\_ViewImports.cshtml"
using DirectList.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02912d2e6e62490c643d60a6bd78580d188a26f5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"964494dd9b622aaffd2ab11fc0f07dc13b7fb31a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmHome>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Restaurant Name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:black;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Restaurant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: flex; justify-content: space-around;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("list-logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""position-relative"">
    <section class=""section section-lg section-hero section-shaped"">
        <div class=""shape shape-style-1 shape-primary"">
            <span class=""span-150""></span>
            <span class=""span-50""></span>
            <span class=""span-50""></span>
            <span class=""span-75""></span>
            <span class=""span-100""></span>
            <span class=""span-75""></span>
            <span class=""span-50""></span>
            <span class=""span-100""></span>
            <span class=""span-50""></span>
            <span class=""span-100""></span>
            <div class=""overlay-bg""></div>
        </div>
        <div class=""container shape-container d-flex align-items-center py-lg"">
            <div class=""main-search-inner"">
                <h2 class=""text-white display-2"">Find Nearby Attractions</h2>
                <h4 class=""text-white"">Expolore top-rated attractions, activities and more</h4>
                <!-- Search -->
                <div class=""col-m");
            WriteLiteral("d-6 grid-full-width page-search mb-3\" style=\" max-width: 100%;\">\r\n                    <div class=\"main-search-input mt-0\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02912d2e6e62490c643d60a6bd78580d188a26f510473", async() => {
                WriteLiteral("\r\n\r\n                            <div class=\"col-lg-5 col-sm-6\">\r\n                                <div class=\"form-group\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "02912d2e6e62490c643d60a6bd78580d188a26f510899", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 32 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Search.searchData);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
                            <div class=""col-lg-1 col-sm-6 text-right"">
                                <button type=""submit"" class=""btn main-search-btn btn-radius btn-lg btn-primary text-white""><span class=""btn-inner--text"">Search</span></button>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
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
                <!-- Search Section / End -->
            </div>
        </div>
        <!-- SVG separator -->
        <div class=""separator separator-bottom separator-skew zindex-100"">
            <svg x=""0"" y=""0"" viewBox=""0 0 2560 100"" preserveAspectRatio=""none"" version=""1.1"" xmlns=""http://www.w3.org/2000/svg"">
                <polygon class=""fill-white"" points=""2560 0 2560 100 0 100""></polygon>
            </svg>
        </div>
    </section>
</div>



<div class=""block-space"">
    <div class=""container"">
        <div class=""block-head text-center mb-5"">
            <h2 class=""head-line display-3"">
                Popular Restaurants
            </h2>
            <p class=""lead mt-2 head-desc"">Browse the most desirable categories</p>
        </div>
    </div>
    <!-- Categories Carousel -->
    <div class=""fullwidth-carousel-container"">
        <div class=""fullwidth-slick-carousel category-carousel"">
            <!-- Item ");
            WriteLiteral("-->\r\n");
#nullable restore
#line 70 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\Home\Index.cshtml"
             foreach (var restaurant in Model.Restaurants)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""fw-carousel-item"">
                    <div class=""category-box-container text-center"">
                        <div class=""category-box"">
                            <div class=""category-box-content"">
                                <div class=""icon-title"">
                                    <i class=""fa-2x fa fa-glass""></i>
                                </div>
                                <h3>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02912d2e6e62490c643d60a6bd78580d188a26f516566", async() => {
                WriteLiteral("\r\n                                        Restaurants\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </h3>\r\n");
            WriteLiteral("                            </div>\r\n                            <div class=\"category-box-background\"");
            BeginWriteAttribute("style", " style=\"", 3984, "\"", 4062, 4);
            WriteAttributeValue("", 3992, "background-image:", 3992, 17, true);
            WriteAttributeValue(" ", 4009, "url(\'/wwwroot/Uploads/", 4010, 23, true);
#nullable restore
#line 86 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\Home\Index.cshtml"
WriteAttributeValue("", 4032, restaurant.RestaurantImages, 4032, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4060, "\')", 4060, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 91 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\Home\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"           
        </div>
    </div>
</div>
<div class=""block-space bg-secondary"">
    <div class=""container"">
        <div class=""block-head text-center mb-5"">
            <h2 class=""head-line display-3"">
                Most Visited Restaurants
            </h2>
            <p class=""lead mt-2 head-desc"">Discover top-rated local businesses</p>
        </div>
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""simple-slick-carousel dots-nav"">


");
#nullable restore
#line 110 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\Home\Index.cshtml"
                     foreach (var restaurant in Model.Restaurants)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""carousel-item"">
                            <div class=""category-box-container text-center"">
                                <div class=""listing-item-container"">
                                    <div class=""listing-item text-center"">
                                        <div class=""mostviewed-bg""");
            BeginWriteAttribute("style", " style=\"", 5143, "\"", 5221, 4);
            WriteAttributeValue("", 5151, "background-image:", 5151, 17, true);
            WriteAttributeValue(" ", 5168, "url(\'/wwwroot/Uploads/", 5169, 23, true);
#nullable restore
#line 116 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\Home\Index.cshtml"
WriteAttributeValue("", 5191, restaurant.RestaurantImages, 5191, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5219, "\')", 5219, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <div class=\"listing-item-content\">\r\n");
            WriteLiteral("                                                <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02912d2e6e62490c643d60a6bd78580d188a26f521204", async() => {
#nullable restore
#line 126 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\Home\Index.cshtml"
                                                                                                                                 Write(restaurant.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 126 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\Home\Index.cshtml"
                                                                                                          WriteLiteral(restaurant.Id);

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
            WriteLiteral("</h3>\r\n                                                <p class=\"mb-0\"> <small>");
#nullable restore
#line 127 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\Home\Index.cshtml"
                                                                   Write(restaurant.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n                                                <span text-uppercase\">\r\n");
#nullable restore
#line 129 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\Home\Index.cshtml"
                                                     if ((restaurant.StartTime.Hour < DateTime.Now.Hour && restaurant.StartTime.Minute <= DateTime.Now.Minute) && (restaurant.EndTime.Hour > DateTime.Now.Hour && restaurant.EndTime.Minute <= DateTime.Now.Minute))
                                                    {



#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <span class=\"badge badge-pill list-banner badge-success\">Open</span>\r\n");
#nullable restore
#line 134 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\Home\Index.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <span class=\"badge badge-pill list-banner badge-danger\">Closed</span>\r\n");
#nullable restore
#line 138 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\Home\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </span>\r\n                                            </div>\r\n");
#nullable restore
#line 141 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\Home\Index.cshtml"
                                              
                                                int id = restaurant.Id;
                                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            \r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02912d2e6e62490c643d60a6bd78580d188a26f526351", async() => {
                WriteLiteral("<i class=\"fa fa-heart-o\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 145 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\Home\Index.cshtml"
                                                                                              WriteLiteral(id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7341, "round-pill", 7341, 10, true);
            AddHtmlAttributeValue(" ", 7351, "like-banner", 7352, 12, true);
            AddHtmlAttributeValue(" ", 7363, "d-block", 7364, 8, true);
            AddHtmlAttributeValue(" ", 7371, "bg-primary", 7372, 11, true);
#nullable restore
#line 145 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\Home\Index.cshtml"
AddHtmlAttributeValue(" ", 7382, Model.AddToCart!=null?Model.AddToCart.Any(a => a==id.ToString())?"myadded":"":"", 7383, 83, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 151 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\Home\Index.cshtml"
                     }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div>
<div class=""block-space bg-primary"">
    <div class=""container"">
        <div class=""block-head text-center mb-5"">
            <h2 class=""head-line text-white display-3"">
                Plan The Vacation of Your Dreams
            </h2>
            <div class=""col-12 col-md-7 mx-auto pb-3"">
                <p class=""lead mt-2 head-desc text-white"">Explore some of the best tips from around the world from our partners and friends. Discover some of the most popular listings in Sydney.</p>
            </div>
        </div>
    </div>
    <div class=""container"">
        <div class=""row row-grid mt-5"">
");
#nullable restore
#line 170 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\Home\Index.cshtml"
             foreach (var dream in Model.DreamPlans)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 text-center\">\r\n                    <div class=\"icon icon-lg icon-shape bg-gradient-white shadow rounded-circle text-primary\">\r\n                        <i");
            BeginWriteAttribute("class", " class=\"", 8684, "\"", 8703, 1);
#nullable restore
#line 174 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\Home\Index.cshtml"
WriteAttributeValue("", 8692, dream.Icon, 8692, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                    </div>\r\n                    <h5 class=\"text-white mt-3\">");
#nullable restore
#line 176 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\Home\Index.cshtml"
                                           Write(dream.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"text-white mt-3\">");
#nullable restore
#line 177 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\Home\Index.cshtml"
                                          Write(dream.SubContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n");
#nullable restore
#line 179 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\Home\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</div>

<div class=""block-space bg-secondary"">
    <div class=""block-head text-center mb-5"">
        <h2 class=""head-line display-3"">
            Recent Blog
        </h2>
        <p class=""lead mt-2 head-desc"">Hassel Free Service</p>
    </div>
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-lg-12"">
                <div class=""row row-grid"">
");
#nullable restore
#line 196 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\Home\Index.cshtml"
                     foreach (var blog in Model.Blogs)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4\">\r\n                            <div class=\"card card-lift--hover shadow border-0\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "02912d2e6e62490c643d60a6bd78580d188a26f533446", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9631, "~/Uploads/", 9631, 10, true);
#nullable restore
#line 200 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 9641, blog.Image, 9641, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"card-body py-4\">\r\n                                    <h5>");
#nullable restore
#line 202 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\Home\Index.cshtml"
                                   Write(blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    <p>");
#nullable restore
#line 203 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\Home\Index.cshtml"
                                  Write(blog.CreatedDate.ToString("dd MMMM yyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p class=\"description mb-4\">");
#nullable restore
#line 204 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\Home\Index.cshtml"
                                                           Write(Html.Raw(blog.Content.Length > 150 ? blog.Content.Substring(0, 150) + "..." : blog.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02912d2e6e62490c643d60a6bd78580d188a26f536268", async() => {
                WriteLiteral("Read More");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_14.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 205 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\Home\Index.cshtml"
                                                                                                            WriteLiteral(blog.Id);

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
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 209 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\Home\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmHome> Html { get; private set; }
    }
}
#pragma warning restore 1591
