#pragma checksum "C:\Users\Admin\Documents\GitHub\ECommerce\BStore\Views\Checkout\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86f2b05cbaf0189f44e1771ffff1e8668225fd27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_Index), @"mvc.1.0.view", @"/Views/Checkout/Index.cshtml")]
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
#line 1 "C:\Users\Admin\Documents\GitHub\ECommerce\BStore\Views\_ViewImports.cshtml"
using BStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Documents\GitHub\ECommerce\BStore\Views\_ViewImports.cshtml"
using BStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Admin\Documents\GitHub\ECommerce\BStore\Views\Checkout\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86f2b05cbaf0189f44e1771ffff1e8668225fd27", @"/Views/Checkout/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79727395343625607dcf075d3f1fe55892915d2c", @"/Views/_ViewImports.cshtml")]
    public class Views_Checkout_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Admin\Documents\GitHub\ECommerce\BStore\Views\Checkout\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Layout/User/Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""generic-banner relative"">
    <div class=""container"">
        <div class=""row height align-items-center justify-content-center"">
            <div class=""col-lg-10"">
                <div class=""generic-banner-content"">
                    <h2 class=""text-white"">THANH TOÁN</h2>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- End banner Area -->
<!-- About Generic Start -->

<div class=""main-wrapper"">
    <div class=""container checkout-area"">
");
#nullable restore
#line 23 "C:\Users\Admin\Documents\GitHub\ECommerce\BStore\Views\Checkout\Index.cshtml"
         if (ViewBag.Success != null)
        {
            if (ViewBag.Success == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-success\" role=\"alert\">\r\n                    Đơn hàng của bạn đã được gửi đi.\r\n                </div>\r\n");
#nullable restore
#line 30 "C:\Users\Admin\Documents\GitHub\ECommerce\BStore\Views\Checkout\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-danger\" role=\"alert\">\r\n                    Giỏ hàng đang trống. Bạn không thể thanh toán.\r\n                </div>\r\n");
#nullable restore
#line 36 "C:\Users\Admin\Documents\GitHub\ECommerce\BStore\Views\Checkout\Index.cshtml"
            }

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Admin\Documents\GitHub\ECommerce\BStore\Views\Checkout\Index.cshtml"
         if (Context.Session.GetString("USERNAME_SESSION") == null && ViewBag.Success == null)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-info\" role=\"alert\">\r\n                VUI LÒNG ĐĂNG NHẬP!\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86f2b05cbaf0189f44e1771ffff1e8668225fd277448", async() => {
                WriteLiteral("Đăng nhập");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 47 "C:\Users\Admin\Documents\GitHub\ECommerce\BStore\Views\Checkout\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"container\">\r\n\r\n                <div class=\"row\">\r\n                    <div class=\"col-lg-6 col-md-6 col-sm-6 col-xs-12\">\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86f2b05cbaf0189f44e1771ffff1e8668225fd279278", async() => {
                WriteLiteral("\r\n                            <input name=\"account_id\"");
                BeginWriteAttribute("value", " value=\"", 1889, "\"", 1937, 1);
#nullable restore
#line 56 "C:\Users\Admin\Documents\GitHub\ECommerce\BStore\Views\Checkout\Index.cshtml"
WriteAttributeValue("", 1897, Context.Session.GetString("ID_SESSION"), 1897, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" hidden />
                            <div class=""form-field"">
                                <label for=""fullname"" style=""text-align: left"">
                                    Họ tên
                                    <abbr title=""required"" class=""required"">*</abbr>
                                </label>
                                <input type=""text"" name=""fullname"" id=""fullname""");
                BeginWriteAttribute("value", " value=\"", 2337, "\"", 2345, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"">
                            </div>
                            <div class=""form-field"">
                                <label for=""address"" style=""text-align: left"">
                                    Địa chỉ
                                    <abbr title=""required"" class=""required"">*</abbr>
                                </label>
                                <input type=""text"" name=""address"" id=""address""");
                BeginWriteAttribute("value", " value=\"", 2791, "\"", 2799, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"">
                            </div>
                            <div class=""form-field"">
                                <label for=""email"" style=""text-align: left"">
                                    Email
                                    <abbr title=""required"" class=""required"">*</abbr>
                                </label>
                                <input type=""text"" name=""email"" id=""email""");
                BeginWriteAttribute("value", " value=\"", 3237, "\"", 3245, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"">
                            </div>
                            <div class=""form-field"">
                                <label for=""city"" style=""text-align: left"">
                                    Thành phố
                                    <abbr title=""required"" class=""required"">*</abbr>
                                </label>
                                <select name=""city"" id=""city"" class=""form-control"">
");
#nullable restore
#line 84 "C:\Users\Admin\Documents\GitHub\ECommerce\BStore\Views\Checkout\Index.cshtml"
                                     foreach (var city in ViewBag.City)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86f2b05cbaf0189f44e1771ffff1e8668225fd2712605", async() => {
#nullable restore
#line 86 "C:\Users\Admin\Documents\GitHub\ECommerce\BStore\Views\Checkout\Index.cshtml"
                                                                     Write(city.TenTinhThanh);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "C:\Users\Admin\Documents\GitHub\ECommerce\BStore\Views\Checkout\Index.cshtml"
                                           WriteLiteral(city.MaTinhThanh);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 87 "C:\Users\Admin\Documents\GitHub\ECommerce\BStore\Views\Checkout\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </select>
                            </div>
                            <div class=""form-field"">
                                <label for=""email"" style=""text-align: left"">
                                    Số điện thoại
                                    <abbr title=""required"" class=""required"">*</abbr>
                                </label>
                                <input type=""text"" name=""tel"" id=""email""");
                BeginWriteAttribute("value", " value=\"", 4413, "\"", 4421, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"">
                            </div>
                            <div class=""form-field"">
                                <label for=""note"" style=""text-align: left"">
                                    Ghi chú đặt hàng
                                </label>
                                <textarea name=""note""");
                BeginWriteAttribute("value", " value=\"", 4762, "\"", 4770, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 4771, "\"", 4776, 0);
                EndWriteAttribute();
                WriteLiteral(@" cols=""30"" rows=""5"" class=""form-control"" placeholder=""Ghi chú về đơn đặt hàng""></textarea>
                            </div>
                            <div class=""form-field cart-checkout"">
                                <h5>Đơn hàng của bạn</h5>
                                <table class=""cart-item"">
                                    <thead>
                                        <tr>
                                            <th>Sản phẩm</th>
                                            <th style=""width: 70%"">Tổng cộng</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 113 "C:\Users\Admin\Documents\GitHub\ECommerce\BStore\Views\Checkout\Index.cshtml"
                                         if (ViewBag.Cart != null)
                                        {
                                            foreach (var item in ViewBag.Cart)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <tr>\r\n                                                    <td>");
#nullable restore
#line 118 "C:\Users\Admin\Documents\GitHub\ECommerce\BStore\Views\Checkout\Index.cshtml"
                                                   Write(item.TenThucDon);

#line default
#line hidden
#nullable disable
                WriteLiteral(" x ");
#nullable restore
#line 118 "C:\Users\Admin\Documents\GitHub\ECommerce\BStore\Views\Checkout\Index.cshtml"
                                                                      Write(item.SoLuong);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                    <td>$");
#nullable restore
#line 119 "C:\Users\Admin\Documents\GitHub\ECommerce\BStore\Views\Checkout\Index.cshtml"
                                                    Write(string.Format("{0:N2}", item.GiaBan));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                </tr>\r\n");
#nullable restore
#line 121 "C:\Users\Admin\Documents\GitHub\ECommerce\BStore\Views\Checkout\Index.cshtml"
                                            }
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 123 "C:\Users\Admin\Documents\GitHub\ECommerce\BStore\Views\Checkout\Index.cshtml"
                                         if (ViewBag.Total == 0)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <tr>\r\n                                                <td colspan=\"2\" style=\"padding-left: 80px\">Chưa có sản phẩm trong giỏ</td>\r\n                                            </tr>\r\n");
#nullable restore
#line 128 "C:\Users\Admin\Documents\GitHub\ECommerce\BStore\Views\Checkout\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        <tr>\r\n                                            <td><strong>Subtotal</strong></td>\r\n                                            <td>$");
#nullable restore
#line 132 "C:\Users\Admin\Documents\GitHub\ECommerce\BStore\Views\Checkout\Index.cshtml"
                                            Write(string.Format("{0:N2}", ViewBag.Total));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                                        </tr>
                                        <tr>
                                            <td><strong>Coupon</strong></td>
                                            <td>None</td>
                                        </tr>
                                        <tr>
                                            <td><strong>Total</strong></td>
                                            <td><strong>$");
#nullable restore
#line 140 "C:\Users\Admin\Documents\GitHub\ECommerce\BStore\Views\Checkout\Index.cshtml"
                                                    Write(string.Format("{0:N2}", ViewBag.Total));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</strong></td>
                                        </tr>

                                    </tbody>
                                </table>
                            </div>
                            <div class=""form-field"">
                                <button class=""checkout-button btn btn-default"">THANH TOÁN</button>
                            </div>

                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
                    <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-12"">
                        <a href=""/Paypal/CheckoutPaypal""><button>Paypal</button></a>
                        <button>Ví điện tử</button>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 158 "C:\Users\Admin\Documents\GitHub\ECommerce\BStore\Views\Checkout\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>

<script>
    function onBtnPayPal() {
        var obj = {};
        $.each($(""#form-info"").serializeArray(), function (k, v) {
            obj[v.name] = v.value;
        });

        console.log(obj);
        
        //$.post(
        //    '/Paypal/CheckoutPaypal',
        //    {
        //        CommandAction: {
        //            CartInfo: obj
        //        }
        //    },
        //    function (result) {
        //        if (result.IsSuccess == true) {
        //            //callback(result);
        //        }
        //    }
        //);
    }
</script>
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
