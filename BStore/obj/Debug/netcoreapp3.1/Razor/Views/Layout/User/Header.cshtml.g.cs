#pragma checksum "D:\GITHUB\__BStore\ECommerce\BStore\Views\Layout\User\Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9da345ac117f326b8fd9a443a78b45caa7965d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Layout_User_Header), @"mvc.1.0.view", @"/Views/Layout/User/Header.cshtml")]
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
#line 1 "D:\GITHUB\__BStore\ECommerce\BStore\Views\_ViewImports.cshtml"
using BStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GITHUB\__BStore\ECommerce\BStore\Views\_ViewImports.cshtml"
using BStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "D:\GITHUB\__BStore\ECommerce\BStore\Views\Layout\User\Header.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9da345ac117f326b8fd9a443a78b45caa7965d6", @"/Views/Layout/User/Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79727395343625607dcf075d3f1fe55892915d2c", @"/Views/_ViewImports.cshtml")]
    public class Views_Layout_User_Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<header class=""main-menu-area"">
    <div class=""container"">
        <div class=""row"">
            <!-- SHOPPING-CART START -->
            <div class=""col-lg-3 col-md-3 col-sm-12 col-xs-12 pull-right shopingcartarea"">
                <div class=""shopping-cart-out pull-right"">
                    <div class=""shopping-cart"">
                        <a class=""shop-link"" href=""/cart"" title=""View my shopping cart"">
                            <i class=""fa fa-shopping-cart cart-icon""></i>
                            <b>My Cart</b>
                            <span class=""ajax-cart-quantity .amount-cart"" id=""soluonggg"">2</span>
                        </a>
                        <div class=""shipping-cart-overly"">
                            <div class=""shipping-item"">
                                <span class=""cross-icon""><i class=""fa fa-times-circle""></i></span>
                                <div class=""shipping-item-image"">
                                    <a href=""#""><img src=""img/shoppi");
            WriteLiteral(@"ng-image.jpg"" alt=""shopping image"" /></a>
                                </div>
                                <div class=""shipping-item-text"">
                                    <span>2 <span class=""pro-quan-x"">x</span> <a href=""#"" class=""pro-cat"">Watch</a></span>
                                    <span class=""pro-quality""><a href=""#"">S,Black</a></span>
                                    <p>$22.95</p>
                                </div>
                            </div>
                            <div class=""shipping-total-bill"">
                                <div class=""cart-prices"">
                                    <span class=""shipping-cost"">$2.00</span>
                                    <span>Shipping</span>
                                </div>
                                <div class=""total-shipping-prices"">
                                    <span class=""shipping-total"">$24.95</span>
                                    <span>Total</span>
                          ");
            WriteLiteral(@"      </div>
                            </div>
                            <div class=""shipping-checkout-btn"">
                                <a href=""checkout.html"">Check out <i class=""fa fa-chevron-right""></i></a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- SHOPPING-CART END -->
            <!-- MAINMENU START -->
            <div class=""col-lg-9 col-md-9 col-sm-12 col-xs-12 no-padding-right menuarea"">
                <div class=""mainmenu"">
                    <nav>
                        <ul class=""list-inline mega-menu"">
                            <li class=""active"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9da345ac117f326b8fd9a443a78b45caa7965d67054", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </li>\r\n                            <li>\r\n                                <a href=\"/menu\">Products</a>\r\n                            </li>\r\n");
#nullable restore
#line 75 "D:\GITHUB\__BStore\ECommerce\BStore\Views\Layout\User\Header.cshtml"
                             if (Context.Session.GetString("USERNAME_SESSION") != null)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 4369, "\"", 4430, 2);
            WriteAttributeValue("", 4376, "/cart/history/", 4376, 14, true);
#nullable restore
#line 79 "D:\GITHUB\__BStore\ECommerce\BStore\Views\Layout\User\Header.cshtml"
WriteAttributeValue("", 4390, Context.Session.GetString("ID_SESSION"), 4390, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Lịch sử đặt hàng</a>\r\n                                </li>\r\n");
#nullable restore
#line 81 "D:\GITHUB\__BStore\ECommerce\BStore\Views\Layout\User\Header.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9da345ac117f326b8fd9a443a78b45caa7965d69739", async() => {
                WriteLiteral("Contact Us");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                            <li><a href=""about-us.html"">About Us</a></li>
                        </ul>
                    </nav>
                </div>
            </div>
            <!-- MAINMENU END -->
        </div>
        <div class=""row"">
            <!-- MOBILE MENU START -->
            <div class=""col-sm-12 mobile-menu-area"">
                <div class=""mobile-menu hidden-md hidden-lg"" id=""mob-menu"">
                    <span class=""mobile-menu-title"">MENU</span>
                    <nav>
                        <ul>
                            <li>
                                <a href=""index.html"">Home</a>
                                <ul>
                                    <li><a href=""index.html"">Home variation 1</a></li>
                                    <li><a href=""index-2.html"">Home variation 2</a></li>
                                </ul>
                            </li>
                            <li>
                                <a href=""shop-g");
            WriteLiteral(@"ird.html"">Women</a>
                                <ul>
                                    <li>
                                        <a href=""shop-gird.html"">Tops</a>
                                        <ul>
                                            <li><a href=""shop-gird.html"">T-Shirts</a></li>
                                            <li><a href=""shop-gird.html"">Blouses</a></li>
                                        </ul>
                                    </li>
                                    <li>
                                        <a href=""shop-gird.html"">Dresses</a>
                                        <ul>
                                            <li><a href=""shop-gird.html"">Casual Dresses</a></li>
                                            <li><a href=""shop-gird.html"">Summer Dresses</a></li>
                                            <li><a href=""shop-gird.html"">Evening Dresses</a></li>
                                        </ul>
                     ");
            WriteLiteral(@"               </li>

                                </ul>
                            </li>
                            <div id=""ResultTrenn"">

                            </div>
                            <li>
                                <a href=""shop-gird.html"">men</a>
                                <ul>
                                    <li>
                                        <a href=""shop-gird.html"">Tops</a>
                                        <ul>
                                            <li><a href=""shop-gird.html"">Sports</a></li>
                                            <li><a href=""shop-gird.html"">Day</a></li>
                                            <li><a href=""shop-gird.html"">Evening</a></li>
                                        </ul>
                                    </li>
                                    <li>
                                        <a href=""shop-gird.html"">Blouses</a>
                                        <ul>
           ");
            WriteLiteral(@"                                 <li><a href=""shop-gird.html"">Handbag</a></li>
                                            <li><a href=""shop-gird.html"">Headphone</a></li>
                                            <li><a href=""shop-gird.html"">Houseware</a></li>
                                        </ul>
                                    </li>
                                    <li>
                                        <a href=""shop-gird.html"">Accessories</a>
                                        <ul>
                                            <li><a href=""shop-gird.html"">Houseware</a></li>
                                            <li><a href=""shop-gird.html"">Home</a></li>
                                            <li><a href=""shop-gird.html"">Health & Beauty</a></li>
                                        </ul>
                                    </li>
                                </ul>
                            </li>
                            <li><a href=""shop-gird.htm");
            WriteLiteral(@"l"">clothing</a></li>
                            <li><a href=""shop-gird.html"">tops</a></li>
                            <li><a href=""shop-gird.html"">T-shirts</a></li>
                            <li><a href=""#"">Delivery</a></li>
                            <li><a href=""about-us.html"">About us</a></li>
                        </ul>
                    </nav>
                </div>
            </div>
            <!-- MOBILE MENU END -->
        </div>
    </div>
</header>");
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
