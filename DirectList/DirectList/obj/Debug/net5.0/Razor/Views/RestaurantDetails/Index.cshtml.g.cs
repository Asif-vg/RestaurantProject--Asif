#pragma checksum "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\RestaurantDetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "701ef64657bcb7a12fde8901d02b75178a64b277"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RestaurantDetails_Index), @"mvc.1.0.view", @"/Views/RestaurantDetails/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"701ef64657bcb7a12fde8901d02b75178a64b277", @"/Views/RestaurantDetails/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cac4dbdf44387914202811f0197bdc701c163916", @"/Views/_ViewImports.cshtml")]
    public class Views_RestaurantDetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\CASPER\Desktop\BackEndProject\DirectList\DirectList\Views\RestaurantDetails\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Content -->\r\n<div class=\"container\">\r\n    <div class=\"content\">\r\n        <div class=\"row sticky-wrapper\">\r\n            <div class=\"col-lg-8 col-md-8\">\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 269, "\"", 277, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""detail-tile mb-4"">
                        <h3>
                            Dingloy Place <span class=""badge badge-pill badge-success text-uppercase"">Open</span>
                        </h3>
                        <p>Dingloy Place, Remington, London, EC1V 8BP, United Kingdom</p>
                        <span class=""badge badge-pill badge-info text-uppercase mr-2"">Dinner</span>
                        <span class=""badge badge-pill badge-info text-uppercase mr-2"">Hotel</span>
                        <span class=""badge badge-pill badge-info text-uppercase"">Sea Food</span>
                    </div>
                    <div class=""nav-wrapper"">
                        <ul class=""nav nav-pills nav-fill flex-column flex-md-row"" id=""tabs-icons-text"" role=""tablist"">
                            <li class=""nav-item"">
                                <a class=""nav-link mb-sm-3 mb-md-0 active show"" id=""tabs-icons-text-1-tab"" data-toggle=""tab"" href=""#tabs-icons-text-1"" role=");
            WriteLiteral(@"""tab"" aria-controls=""tabs-icons-text-1"" aria-selected=""true""><i class=""fa fa-info-circle mr-2""></i>About</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link mb-sm-3 mb-md-0"" id=""tabs-icons-text-2-tab"" data-toggle=""tab"" href=""#tabs-icons-text-2"" role=""tab"" aria-controls=""tabs-icons-text-2"" aria-selected=""false""><i class=""fa fa-map-marker mr-2""></i>Location</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link mb-sm-3 mb-md-0"" id=""tabs-icons-text-3-tab"" data-toggle=""tab"" href=""#tabs-icons-text-3"" role=""tab"" aria-controls=""tabs-icons-text-3"" aria-selected=""false""><i class=""fa fa-money mr-2""></i>Pricing</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link mb-sm-3 mb-md-0"" id=""tabs-icons-text-4-tab"" data-toggle=""tab"" href=""#tabs-icons-text-4"" role=""tab");
            WriteLiteral(@""" aria-controls=""tabs-icons-text-3"" aria-selected=""false""><i class=""fa fa-money mr-2""></i>Reviews</a>
                            </li>
                        </ul>
                    </div>
                    <div class=""card shadow"">
                        <div class=""card-body"">
                            <div class=""tab-content"" id=""myTabContent"">
                                <div class=""tab-pane fade active show"" id=""tabs-icons-text-1"" role=""tabpanel"" aria-labelledby=""tabs-icons-text-1-tab"">
                                    <p class=""description"">Lorem ipsum dolor sit amet consectetur adipisicing elit. Placeat rerum doloribus repudiandae nulla odit, omnis ex, a assumenda fugiat quasi neque necessitatibus fugit maiores quis. Quo dolor minus pariatur natus!</p>
                                    <p class=""description"">
                                        Lorem ipsum dolor sit amet consectetur adipisicing elit. Placeat rerum doloribus repudiandae nulla odit, omnis ex, a assumenda f");
            WriteLiteral(@"ugiat quasi neque necessitatibus fugit maiores quis. Quo dolor minus pariatur natus! Lorem ipsum dolor sit amet
                                        consectetur adipisicing elit. Blanditiis quis laudantium est pariatur, harum laboriosam odit delectus vitae minima dolorem ipsam repudiandae sunt non. Dolorem adipisci voluptates doloribus voluptatum nihil.
                                    </p>
                                    <h4 class=""mb-4"">
                                        Contact Info
                                    </h4>
                                    <div class=""row mb-5"">
                                        <div class=""col-lg-4"">
                                            <div class=""detail-list mb-2"">
                                                <div class=""detail-list-label mb-1"">
                                                    <i aria-hidden=""true"" class=""fa fa-phone mr-2""></i>
                                                    <small class=""text-upperca");
            WriteLiteral(@"se font-weight-bold"">Reception.</small>
                                                </div>
                                                <p class=""m-0 text-small"">+123 123 456 45</p>
                                            </div>
                                        </div>
                                        <div class=""col-lg-4"">
                                            <div class=""detail-list mb-2"">
                                                <div class=""detail-list-label mb-1"">
                                                    <i aria-hidden=""true"" class=""fa fa-phone mr-2""></i>
                                                    <small class=""text-uppercase font-weight-bold"">For Complaints.</small>
                                                </div>
                                                <p class=""m-0 text-small"">+123 123 456 45</p>
                                            </div>
                                        </div>
                          ");
            WriteLiteral(@"              <div class=""col-lg-4"">
                                            <div class=""detail-list mb-2"">
                                                <div class=""detail-list-label mb-1"">
                                                    <i aria-hidden=""true"" class=""fa fa-phone mr-2""></i><small class=""text-uppercase font-weight-bold"">Support.</small>
                                                </div>
                                                <p class=""m-0 text-small"">+123 123 456 45</p>
                                            </div>
                                        </div>
                                    </div>
                                    <h4 class=""mb-4"">Features</h4>
                                    <span class=""badge badge-pill badge-primary text-uppercase mr-2 mb-2"">Swimming pool</span>
                                    <span class=""badge badge-pill badge-primary text-uppercase mr-2 mb-2""> Free WiFi Internet Access Included</span>
               ");
            WriteLiteral(@"                     <span class=""badge badge-pill badge-primary text-uppercase mr-2 mb-2""> Free Parking</span>
                                    <span class=""badge badge-pill badge-primary text-uppercase mr-2 mb-2"">Swimmingpool Outdoor</span>
                                    <span class=""badge badge-pill badge-primary text-uppercase mr-2 mb-2"">Family Rooms</span>
                                    <span class=""badge badge-pill badge-primary text-uppercase mr-2 mb-2"">Non Smoking Rooms</span>
                                </div>
                                <div class=""tab-pane fade"" id=""tabs-icons-text-2"" role=""tabpanel"" aria-labelledby=""tabs-icons-text-2-tab"">
                                    <p class=""description"">Cosby sweater eu banh mi, qui irure terry richardson ex squid. Aliquip placeat salvia cillum iphone. Seitan aliquip quis cardigan american apparel, butcher voluptate nisi qui.</p>
                                    <div>
                                        <!-- <agm-map ");
            WriteLiteral(@"[latitude]=""lat"" [longitude]=""lng"" style=""height: 300px"">
                                        <agm-marker [latitude]=""lat"" [longitude]=""lng""></agm-marker>
                                        </agm-map> -->
                                    </div>
                                </div>
                                <div class=""tab-pane fade"" id=""tabs-icons-text-3"" role=""tabpanel"" aria-labelledby=""tabs-icons-text-3-tab"">
                                    <div class=""pricing-list-container"">
                                        <ul>
                                            <li>
                                                <h5>Classic Burger</h5>
                                                <p>Beef, salad, mayonnaise, spicey relish, cheese</p>
                                                <span>$6</span>
                                            </li>
                                            <li>
                                                <h5>Cheddar Burger</h5>");
            WriteLiteral(@"
                                                <p>Cheddar cheese, lettuce, tomato, onion, dill pickles</p>
                                                <span>$6</span>
                                            </li>
                                            <li>
                                                <h5>Veggie Burger</h5>
                                                <p>Panko crumbed and fried, grilled peppers and mushroom</p>
                                                <span>$6</span>
                                            </li>
                                            <li>
                                                <h5>Chicken Burger</h5>
                                                <p>Cheese, chicken fillet, avocado, bacon, tomatoes, basil</p>
                                                <span>$6</span>
                                            </li>
                                        </ul>
                                    </div>
       ");
            WriteLiteral(@"                         </div>
                                <div class=""tab-pane fade"" id=""tabs-icons-text-4"" role=""tabpanel"" aria-labelledby=""tabs-icons-text-4-tab"">
                                    <div class=""row mb-4 list-img-wrap"">
                                        <div class=""col-md-2 list-img"">
                                            <img class=""img-fluid rounded-circle shadow-lg"" src=""assets/images/thumb-1.jpg"" alt=""image"">
                                        </div>
                                        <div class=""col-md-10"">
                                            <h5 class=""text-primary"">Charlotte Ainsley</h5>
                                            <p>15 Minutes Ago</p>
                                            <p>
                                                Lorem Ipsum is simply dummy text of the pr make but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets ");
            WriteLiteral(@"containing Lorem Ipsum passages, and more
                                                recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.
                                            </p>
                                            <button class=""btn btn-sm btn-primary"" type=""button"">Helpful?</button>
                                        </div>
                                    </div>
                                    <div class=""row mb-4 list-img-wrap"">
                                        <div class=""col-md-2 list-img"">
                                            <img class=""img-fluid rounded-circle shadow-lg"" src=""assets/images/thumb-2.jpg"" alt=""image"">
                                        </div>
                                        <div class=""col-md-10"">
                                            <h5 class=""text-primary"">Sophia Ainsworth</h5>
                                            <p>2 Days Ago</p>
                       ");
            WriteLiteral(@"                     <p>
                                                Lorem Ipsum is simply dummy text of the pr make but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more
                                                recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.
                                            </p>
                                            <button class=""btn btn-sm btn-primary"" type=""button"">Helpful?</button>
                                        </div>
                                    </div>
                                    <div class=""row mb-4 list-img-wrap"">
                                        <div class=""col-md-2 list-img"">
                                            <img class=""img-fluid rounded-circle shadow-lg"" src=""assets/images/thumb-1.jpg"" alt=""image"">
                     ");
            WriteLiteral(@"                   </div>
                                        <div class=""col-md-10"">
                                            <h5 class=""text-primary"">Ava Acton</h5>
                                            <p>3 days Ago</p>
                                            <p>
                                                Lorem Ipsum is simply dummy text of the pr make but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more
                                                recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.
                                            </p>
                                            <button class=""btn btn-sm btn-primary"" type=""button"">Helpful?</button>
                                        </div>
                                    </div>
                                </div>
   ");
            WriteLiteral(@"                         </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""sticky"">
                    <!-- Book Now -->
                    <div class=""boxed-widget booking-widget"">
                        <div>
                            <div class=""form-group focused"">
                                <div class=""input-group"">
                                    <div class=""input-group-prepend"">
                                        <span class=""input-group-text""><i class=""ni ni-calendar-grid-58""></i></span>
                                    </div>
                                    <input class=""form-control"" placeholder=""Start date"" type=""text"" value=""06/18/2018"">
                                </div>
                            </div>
                            <div class=""form-group"">
                                <select class=""form-control form-control-a");
            WriteLiteral("lternative custom-select\" id=\"exampleFormControlSelect1\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "701ef64657bcb7a12fde8901d02b75178a64b27720314", async() => {
                WriteLiteral("Guest");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "701ef64657bcb7a12fde8901d02b75178a64b27721619", async() => {
                WriteLiteral("One");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "701ef64657bcb7a12fde8901d02b75178a64b27722812", async() => {
                WriteLiteral("Two");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "701ef64657bcb7a12fde8901d02b75178a64b27724005", async() => {
                WriteLiteral("Three");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "701ef64657bcb7a12fde8901d02b75178a64b27725200", async() => {
                WriteLiteral("Four");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </select>
                            </div>
                            <div class=""form-group"">
                                <div class=""input-group"">
                                    <input class=""form-control"" placeholder=""FullName"" type=""text"" >
                                </div>
                            </div>
                            <div class=""form-group"">
                                <div class=""input-group"">
                                    <input class=""form-control"" placeholder=""FIN"" type=""text"" >
                                </div>
                            </div>
                        </div>
                        <!-- Book Now -->
                        <a href=""#"" class=""btn btn-1 btn-primary d-block"">Book Now</a>
                    </div>
                    <!-- Book Now / End -->
                    <div class=""boxed-widget bg-secondary mt-4 text-center p-4"">
                        <h4 class=""mb-4"">Key Peo");
            WriteLiteral(@"ple</h4>
                        <div class=""mb-3"">
                            <div class=""mb-2"">
                                <img class=""img-fluid rounded-circle shadow-lg"" width=""80"" height=""80"" src=""assets/images/thumb-1.jpg"" alt=""image"">
                            </div>
                            <div");
            BeginWriteAttribute("class", " class=\"", 16358, "\"", 16366, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <h5 class=""text-primary"">Victoria Benson</h5>
                            </div>
                        </div>
                        <ul class=""listing-details-sidebar"">
                            <li><i class=""fa fa-phone""></i> (123) 123-456</li>
                            <li><i class=""fa fa-external-link""></i> http://example.com</li>
                            <li><i class=""fa fa-envelope-o""></i>victoria@victoria.com</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591