#pragma checksum "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\Menu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67fc9871ee3e7597f2ad03a2e95fd32f4574ecfe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_Index), @"mvc.1.0.view", @"/Views/Menu/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Menu/Index.cshtml", typeof(AspNetCore.Views_Menu_Index))]
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
#line 1 "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\_ViewImports.cshtml"
using BStore;

#line default
#line hidden
#line 2 "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\_ViewImports.cshtml"
using BStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67fc9871ee3e7597f2ad03a2e95fd32f4574ecfe", @"/Views/Menu/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79727395343625607dcf075d3f1fe55892915d2c", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Default", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Name", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Price", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:225px ; height:225px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "InfomationProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\Menu\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Layout/User/Layout.cshtml";

#line default
#line hidden
            BeginContext(94, 1078, true);
            WriteLiteral(@"
<!-- MAIN-CONTENT-SECTION START -->
<section class=""main-content-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                <!-- BSTORE-BREADCRUMB START -->
                <div class=""bstore-breadcrumb"">
                    <a href=""index.html"">HOME</a>
                    <span><i class=""fa fa-caret-right""></i></span>
                    <span>Products</span>
                </div>
                <!-- BSTORE-BREADCRUMB END -->
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-3 col-md-3 col-sm-3 col-xs-12"">
                <!-- PRODUCT-LEFT-SIDEBAR START -->
                <div class=""product-left-sidebar"">
                    <h2 class=""left-title pro-g-page-title"">Catalog</h2>

                    <!-- SINGLE SIDEBAR CATEGORIES START -->
                    <div class=""product-single-sidebar"">
                        <span class=""sidebar-title"">Categorie");
            WriteLiteral("s</span>\r\n                        <ul id=\"category\">\r\n");
            EndContext();
#line 31 "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\Menu\Index.cshtml"
                              
                                foreach (var item in ViewBag.ListCate)
                                {

#line default
#line hidden
            BeginContext(1311, 357, true);
            WriteLiteral(@"                                    <li>
                                        <label class=""cheker"">
                                            <input type=""checkbox"" name=""categories"" />
                                            <span></span>
                                        </label>
                                        <a data-url=""");
            EndContext();
            BeginContext(1669, 11, false);
#line 39 "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\Menu\Index.cshtml"
                                                Write(item.MaLoai);

#line default
#line hidden
            EndContext();
            BeginContext(1680, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(1683, 12, false);
#line 39 "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\Menu\Index.cshtml"
                                                              Write(item.TenLoai);

#line default
#line hidden
            EndContext();
            BeginContext(1695, 62, true);
            WriteLiteral("<span></span></a>\r\n                                    </li>\r\n");
            EndContext();
#line 41 "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\Menu\Index.cshtml"
                                }
                            

#line default
#line hidden
            BeginContext(1823, 351, true);
            WriteLiteral(@"
                        </ul>
                    </div>
                    <!-- SINGLE SIDEBAR CATEGORIES END -->
                    <!-- SINGLE SIDEBAR AVAILABILITY START -->
                    <div class=""product-single-sidebar"">
                        <span class=""sidebar-title"">Brands</span>
                        <ul id=""brand"">
");
            EndContext();
#line 51 "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\Menu\Index.cshtml"
                              
                                foreach (var item in ViewBag.ListBrand)
                                {

#line default
#line hidden
            BeginContext(2314, 353, true);
            WriteLiteral(@"                                    <li>
                                        <label class=""cheker"">
                                            <input type=""checkbox"" name=""brands"" />
                                            <span></span>
                                        </label>
                                        <a data-url=""");
            EndContext();
            BeginContext(2668, 9, false);
#line 59 "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\Menu\Index.cshtml"
                                                Write(item.MaTH);

#line default
#line hidden
            EndContext();
            BeginContext(2677, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(2680, 10, false);
#line 59 "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\Menu\Index.cshtml"
                                                            Write(item.TenTH);

#line default
#line hidden
            EndContext();
            BeginContext(2690, 62, true);
            WriteLiteral("<span></span></a>\r\n                                    </li>\r\n");
            EndContext();
#line 61 "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\Menu\Index.cshtml"
                                }
                            

#line default
#line hidden
            BeginContext(2818, 2471, true);
            WriteLiteral(@"                        </ul>
                    </div>
                    <!-- SINGLE SIDEBAR AVAILABILITY END -->
                    <!-- SINGLE SIDEBAR CONDITION START -->
                  

                </div>
                <!-- PRODUCT-LEFT-SIDEBAR END -->

            </div>
            <div class=""col-lg-9 col-md-9 col-sm-9 col-xs-12"">
                <div class=""right-all-product"">
                    <!-- PRODUCT-CATEGORY-HEADER START -->
                    <!-- PRODUCT-CATEGORY-HEADER END -->
                    <div class=""product-category-title"">
                        <!-- PRODUCT-CATEGORY-TITLE START -->
                        <h1>
                            <span class=""cat-name"">Our Products</span>
                        
                        </h1>
                        <!-- PRODUCT-CATEGORY-TITLE END -->
                    </div>

                    <!---Search-->
                    <div class=""active-pink-3 active-pink-4 mb-4"">
                 ");
            WriteLiteral(@"       <input class=""form-control"" name=""txtSearch"" id=""txtSearch"" type=""text"" placeholder=""Bạn muốn tìm gì?"" aria-label=""Search"">
                    </div>

                    <script>
                        // AJAX call for autocomplete
                        $(document).ready(function () {
                            $("".form-control"").keyup(function () {
                                var key = $(this).val();
                                //alert(key);
                                $.ajax({
                                    type: ""POST"",
                                    url: ""/menu/Search?key="" + key,
                                    success: function (data) {
                                        $(""#result"").html(data);
                                    }
                                });
                            });
                        });

                    </script>
                    <!---End Search-->
                    <div class=""product-shoo");
            WriteLiteral(@"ting-area"">
                        <div class=""product-shooting-bar"">
                            <!-- SHOORT-BY START -->
                            <div class=""shoort-by"">
                                <label for=""productShort"">Sort by</label>
                                <div class=""short-select-option"">
                                    <select class=""sortby"">
                                        ");
            EndContext();
            BeginContext(5289, 137, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67fc9871ee3e7597f2ad03a2e95fd32f4574ecfe13644", async() => {
                BeginContext(5322, 95, true);
                WriteLiteral("\r\n                                            Default\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            EndContext();
            BeginContext(5426, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(5468, 122, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67fc9871ee3e7597f2ad03a2e95fd32f4574ecfe15468", async() => {
                BeginContext(5489, 92, true);
                WriteLiteral("\r\n                                            Name\r\n                                        ");
                EndContext();
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
            EndContext();
            BeginContext(5590, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(5632, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67fc9871ee3e7597f2ad03a2e95fd32f4574ecfe16978", async() => {
                BeginContext(5654, 93, true);
                WriteLiteral("\r\n                                            Price\r\n                                        ");
                EndContext();
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
            EndContext();
            BeginContext(5756, 2214, true);
            WriteLiteral(@"
                                    </select>
                                </div>
                            </div>
                            <script type=""text/javascript"">
                                $(document).ready(function () {
                                    $('select.sortby').change(function (e) {
                                        var value = $(this).children(""option:selected"").val();
                                        //alert(value);
                                        $.ajax({
                                            type: ""POST"",
                                            url: '/Menu/sortby?value=' + value,
                                            success: function (result) {
                                                //alert(result);
                                                $(""#result"").html(result);
                                            }
                                        });
                                        // v");
            WriteLiteral(@"ar selectedCountry = $(this).children(""option:selected"").val();
                                        //  alert(""You have selected the country - "" + selectedCountry);
                                    });
                                });
                            </script>
                            <!-- SHOORT-BY END -->
                            <!-- SHOW-PAGE START -->
              

                            <div class=""showing-next-prev"">
                                <ul class=""pagination-bar"">
                                    <li class=""disabled"">
                                        <a id=""btnGiam""><i class=""fa fa-chevron-left""></i></a>
                                    </li>
                                    <li>
                                        <a><input type=""text"" name=""trang"" id=""trang"" value=""1"" style=""width:50px;height:25px; text-align:center""></a>
                                    </li>
                                    <li>
             ");
            WriteLiteral("                           <a id=\"btnTang\"><i class=\"fa fa-chevron-right\"></i></a>\r\n                                    </li>\r\n                                </ul>\r\n");
            EndContext();
            BeginContext(8164, 2466, true);
            WriteLiteral(@"                            </div>
                      
                            <!-- SHOW-PAGE END -->
                            <!-- VIEW-SYSTEAM START -->
                           
                            <!-- VIEW-SYSTEAM END -->
                        </div>
                        <!-- PRODUCT-SHOOTING-RESULT START -->
                        
                        <!-- PRODUCT-SHOOTING-RESULT END -->
                    </div>
                </div>

                <script type=""text/javascript"">
                    $(document).ready(function () {
                        $('#btnGiam').click(function (e) {
                            var status = 0;
                            //alert(""btnGiam"");
                            var page = $('#trang').val();
                            var kq = Number(page) - 1;
                            //alert(page);
                            $.ajax({
                                type: ""POST"",
                                u");
            WriteLiteral(@"rl: 'menu/GetProductByPage?page=' + page + '&status=' + status,
                                success: function (result) {
                                    $(""#result"").html(result);
                                    $(""#trang"").val(kq);
                                }
                            });
                        });

                        $('#btnTang').click(function (e) {
                            //alert(""btnGiam"");
                            var status = 1;
                            var page = $('#trang').val();
                            var kq = Number(page) + 1;
                            //$(""#trang"").val(kq);
                            //alert(page);
                            $.ajax({
                                type: ""POST"",
                                url: 'menu/GetProductByPage?page=' + page + '&status=' + status,
                                success: function (result) {
                                    $(""#result"").html(result);
  ");
            WriteLiteral(@"                                  $(""#trang"").val(kq);
                                }
                            });
                        });
                    });
                </script>

                <!-- ALL GATEGORY-PRODUCT START -->
                <div class=""all-gategory-product"" id=""result"">
                    <div class=""row"">
                        <ul class=""gategory-product"">
");
            EndContext();
#line 219 "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\Menu\Index.cshtml"
                              
                                foreach (var item in ViewBag.ListProduct)
                                {

#line default
#line hidden
            BeginContext(10772, 399, true);
            WriteLiteral(@"                                    <!-- SINGLE ITEM START -->
                                    <li class=""gategory-product-list col-lg-3 col-md-4 col-sm-6 col-xs-12"">
                                        <div class=""single-product-item"">
                                            <div class=""product-image"">
                                                <a href=""single-product.html"">");
            EndContext();
            BeginContext(11171, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "67fc9871ee3e7597f2ad03a2e95fd32f4574ecfe24200", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 11181, "~/user/products/", 11181, 16, true);
#line 226 "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\Menu\Index.cshtml"
AddHtmlAttributeValue("", 11197, item.HinhAnh, 11197, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11269, 8, true);
            WriteLiteral("</a>\r\n\r\n");
            EndContext();
#line 228 "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\Menu\Index.cshtml"
                                                  
                                                    if (item.KhuyenMai != 0)
                                                    {

#line default
#line hidden
            BeginContext(11462, 114, true);
            WriteLiteral("                                                        <a href=\"single-product.html\" class=\"new-mark-box\">Sale - ");
            EndContext();
            BeginContext(11577, 14, false);
#line 231 "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\Menu\Index.cshtml"
                                                                                                             Write(item.KhuyenMai);

#line default
#line hidden
            EndContext();
            BeginContext(11591, 8, true);
            WriteLiteral(" %</a>\r\n");
            EndContext();
#line 232 "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\Menu\Index.cshtml"
                                                    }
                                                

#line default
#line hidden
            BeginContext(11705, 197, true);
            WriteLiteral("                                                <div class=\"overlay-content\">\r\n                                                    <ul>\r\n                                                        <li>");
            EndContext();
            BeginContext(11902, 137, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67fc9871ee3e7597f2ad03a2e95fd32f4574ecfe27455", async() => {
                BeginContext(11990, 45, true);
                WriteLiteral("<button><i class=\"fa fa-search\"></i></button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 236 "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\Menu\Index.cshtml"
                                                                                                                       WriteLiteral(item.MaThucDon);

#line default
#line hidden
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
            EndContext();
            BeginContext(12039, 143, true);
            WriteLiteral("</li>\r\n\r\n                                                        <li class=\"order-button\"><a><button type=\"button\" title=\"Quick view\" data-id=\"");
            EndContext();
            BeginContext(12183, 14, false);
#line 238 "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\Menu\Index.cshtml"
                                                                                                                                 Write(item.MaThucDon);

#line default
#line hidden
            EndContext();
            BeginContext(12197, 57, true);
            WriteLiteral("\"><i class=\"fa fa-shopping-cart\"></i></button></a></li>\r\n");
            EndContext();
            BeginContext(12480, 509, true);
            WriteLiteral(@"                                                    </ul>
                                                </div>
                                            </div>
                                            <div class=""product-info"">
                                                <div class=""customar-comments-box"">
                                                 
                                                </div>
                                                <a href=""single-product.html"">");
            EndContext();
            BeginContext(12990, 15, false);
#line 248 "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\Menu\Index.cshtml"
                                                                         Write(item.TenThucDon);

#line default
#line hidden
            EndContext();
            BeginContext(13005, 151, true);
            WriteLiteral("</a>\r\n                                                <div class=\"price-box\">\r\n                                                    <span class=\"price\">");
            EndContext();
            BeginContext(13157, 66, false);
#line 250 "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\Menu\Index.cshtml"
                                                                   Write(String.Concat(string.Format("{0:N0}", @item.GetGiaKhuyenMai), "Đ"));

#line default
#line hidden
            EndContext();
            BeginContext(13223, 11, true);
            WriteLiteral("</span>\r\n\r\n");
            EndContext();
#line 252 "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\Menu\Index.cshtml"
                                                      
                                                        if (item.KhuyenMai != 0)
                                                        {

#line default
#line hidden
            BeginContext(13431, 84, true);
            WriteLiteral("                                                            <span class=\"old-price\">");
            EndContext();
            BeginContext(13516, 54, false);
#line 255 "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\Menu\Index.cshtml"
                                                                               Write(String.Concat(string.Format("{0:N0}", @item.Gia), "Đ"));

#line default
#line hidden
            EndContext();
            BeginContext(13570, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 256 "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\Menu\Index.cshtml"
                                                        }
                                                    

#line default
#line hidden
            BeginContext(13693, 263, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                        </div>
                                    </li>
                                    <!-- SINGLE ITEM END -->
");
            EndContext();
#line 264 "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\Menu\Index.cshtml"
                                }
                            

#line default
#line hidden
            BeginContext(14022, 192, true);
            WriteLiteral("\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n                <!-- ALL GATEGORY-PRODUCT END -->\r\n                <!-- PRODUCT-SHOOTING-RESULT START -->\r\n");
            EndContext();
            BeginContext(15752, 149, true);
            WriteLiteral("                <!-- PRODUCT-SHOOTING-RESULT END -->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- MAIN-CONTENT-SECTION END -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591