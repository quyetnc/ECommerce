#pragma checksum "E:\Net Core\Project Complete\BStore\BStore\Views\DashBoard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ca37771e74f0c74223880267ea1a8ed11638550"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DashBoard_Index), @"mvc.1.0.view", @"/Views/DashBoard/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DashBoard/Index.cshtml", typeof(AspNetCore.Views_DashBoard_Index))]
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
#line 1 "E:\Net Core\Project Complete\BStore\BStore\Views\_ViewImports.cshtml"
using BStore;

#line default
#line hidden
#line 2 "E:\Net Core\Project Complete\BStore\BStore\Views\_ViewImports.cshtml"
using BStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ca37771e74f0c74223880267ea1a8ed11638550", @"/Views/DashBoard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79727395343625607dcf075d3f1fe55892915d2c", @"/Views/_ViewImports.cshtml")]
    public class Views_DashBoard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\Net Core\Project Complete\BStore\BStore\Views\DashBoard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Layout/AdminOK/_Layout.cshtml";

#line default
#line hidden
            BeginContext(98, 1537, true);
            WriteLiteral(@"

<div class=""dashboard-ecommerce"">
    <div class=""container-fluid dashboard-content "">
        <!-- ============================================================== -->
        <!-- pageheader  -->
        <!-- ============================================================== -->
        <div class=""row"">
            <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12"">
                <div class=""page-header"">
                    <h2 class=""pageheader-title"">B-Store Dashboard</h2>
                    <p class=""pageheader-text"">Nulla euismod urna eros, sit amet scelerisque torton lectus vel mauris facilisis faucibus at enim quis massa lobortis rutrum.</p>
                    <div class=""page-breadcrumb"">
                        <nav aria-label=""breadcrumb"">

                        </nav>
                    </div>
                </div>
            </div>
        </div>
        <!-- ============================================================== -->
        <!-- end pageheader  -->
 ");
            WriteLiteral(@"       <!-- ============================================================== -->
        <div class=""ecommerce-widget"">

            <div class=""row"">
                <div class=""col-xl-3 col-lg-6 col-md-6 col-sm-12 col-12"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <h5 class=""text-muted"">Thu Nhập Hằng Ngày</h5>
                            <div class=""metric-value d-inline-block"">
                                <h1 class=""mb-1"">");
            EndContext();
            BeginContext(1636, 42, false);
#line 37 "E:\Net Core\Project Complete\BStore\BStore\Views\DashBoard\Index.cshtml"
                                            Write(String.Format("{0:N0}", @ViewBag.TotalDay));

#line default
#line hidden
            EndContext();
            BeginContext(1678, 47, true);
            WriteLiteral(" VNĐ</h1>\r\n                            </div>\r\n");
            EndContext();
            BeginContext(1979, 448, true);
            WriteLiteral(@"                        </div>

                    </div>
                </div>
                <div class=""col-xl-3 col-lg-6 col-md-6 col-sm-12 col-12"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <h5 class=""text-muted"">Thu Nhập Trong Tháng</h5>
                            <div class=""metric-value d-inline-block"">
                                <h1 class=""mb-1"">");
            EndContext();
            BeginContext(2428, 44, false);
#line 51 "E:\Net Core\Project Complete\BStore\BStore\Views\DashBoard\Index.cshtml"
                                            Write(String.Format("{0:N0}", @ViewBag.TotalMonth));

#line default
#line hidden
            EndContext();
            BeginContext(2472, 47, true);
            WriteLiteral(" VNĐ</h1>\r\n                            </div>\r\n");
            EndContext();
            BeginContext(2773, 445, true);
            WriteLiteral(@"                        </div>

                    </div>
                </div>
                <div class=""col-xl-3 col-lg-6 col-md-6 col-sm-12 col-12"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <h5 class=""text-muted"">Thu Nhập Hằng Năm</h5>
                            <div class=""metric-value d-inline-block"">
                                <h1 class=""mb-1"">");
            EndContext();
            BeginContext(3219, 43, false);
#line 65 "E:\Net Core\Project Complete\BStore\BStore\Views\DashBoard\Index.cshtml"
                                            Write(String.Format("{0:N0}", @ViewBag.TotalYear));

#line default
#line hidden
            EndContext();
            BeginContext(3262, 47, true);
            WriteLiteral(" VNĐ</h1>\r\n                            </div>\r\n");
            EndContext();
            BeginContext(3512, 446, true);
            WriteLiteral(@"                        </div>

                    </div>
                </div>
                <div class=""col-xl-3 col-lg-6 col-md-6 col-sm-12 col-12"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <h5 class=""text-muted"">Yêu Cầu Chưa Xử Lý</h5>
                            <div class=""metric-value d-inline-block"">
                                <h1 class=""mb-1"">");
            EndContext();
            BeginContext(3959, 13, false);
#line 79 "E:\Net Core\Project Complete\BStore\BStore\Views\DashBoard\Index.cshtml"
                                            Write(ViewBag.Count);

#line default
#line hidden
            EndContext();
            BeginContext(3972, 43, true);
            WriteLiteral("</h1>\r\n                            </div>\r\n");
            EndContext();
            BeginContext(4223, 2390, true);
            WriteLiteral(@"                        </div>

                    </div>
                </div>
            </div>
            <div class=""row"">
                <!-- ============================================================== -->
                <!-- sales  -->
             
                <!-- ============================================================== -->
                <!-- end sales  -->
                <!-- ============================================================== -->
                <!-- ============================================================== -->
                <!-- new customer  -->
                <!-- ============================================================== -->

                <!-- ============================================================== -->
                <!-- end new customer  -->
                <!-- ============================================================== -->
                <!-- ============================================================== -->
    ");
            WriteLiteral(@"            <!-- visitor  -->
                <!-- ============================================================== -->
                
                <!-- ============================================================== -->
                <!-- end visitor  -->
                <!-- ============================================================== -->
                <!-- ============================================================== -->
                <!-- total orders  -->
                <!-- ============================================================== -->
             
                <!-- ============================================================== -->
                <!-- end total orders  -->
                <!-- ============================================================== -->
            </div>


            <div class=""row"">
                <!-- ============================================================== -->
                <!-- =================================================");
            WriteLiteral(@"============= -->
                <!-- recent orders  -->
                <!-- ============================================================== -->
                <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12"">
                    <div class=""card"">
                        <h5 class=""card-header"">Thống Kê Bán Hàng Hôm Nay  ");
            EndContext();
            BeginContext(6614, 43, false);
#line 127 "E:\Net Core\Project Complete\BStore\BStore\Views\DashBoard\Index.cshtml"
                                                                      Write(DateTime.UtcNow.Date.ToString("yyyy-MM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(6657, 851, true);
            WriteLiteral(@"</h5>
                        <div class=""card-body p-0"">
                            <div class=""table-responsive"">
                                <table class=""table"">
                                    <thead class=""bg-light"">
                                        <tr class=""border-0"">
                                            <th class=""border-0"">Mã Sản Phẩm</th>
                                            <th class=""border-0"">Tên Sản Phẩm</th>
                                            <th class=""border-0"">Giá</th>
                                            <th class=""border-0"">Số Lượng Bán Được</th>
                                            <th class=""border-0"">Thành Tiền</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
            EndContext();
#line 141 "E:\Net Core\Project Complete\BStore\BStore\Views\DashBoard\Index.cshtml"
                                         foreach (var item in ViewBag.ListProduct)
                                        {
                                            //             if (db.ThucDon.Find(item.MaThucDon).KhuyenMai > 0)
                                            //{
                                            //    tmp.gia = db.ThucDon.Find(item.MaThucDon).GiaKhuyenMai;
                                            //}
                                            //else
                                            //{
                                            //    tmp.gia = db.ThucDon.Find(item.MaThucDon).Gia;
                                            //}
                                            //tmp.masp = item.MaThucDon;
                                            //tmp.soluong = item.SoLuong;
                                            //tmp.thanhtien = tmp.gia * tmp.soluong;
                                            //tmp.tensp = db.ThucDon.Find(item.MaThucDon).TenThucDon;
                                            //tmp.id = item.MaCtgioHang;
                                            //listorder.Add(tmp);


#line default
#line hidden
            BeginContext(8680, 333, true);
            WriteLiteral(@"                                            <tr role=""row"" class=""odd"">
                                                <td class=""sorting_1"">
                                                    <font style=""vertical-align: inherit;"">
                                                        <font style=""vertical-align: inherit;"">");
            EndContext();
            BeginContext(9014, 9, false);
#line 161 "E:\Net Core\Project Complete\BStore\BStore\Views\DashBoard\Index.cshtml"
                                                                                          Write(item.masp);

#line default
#line hidden
            EndContext();
            BeginContext(9023, 367, true);
            WriteLiteral(@"</font>
                                                    </font>
                                                </td>
                                                <td>
                                                    <font style=""vertical-align: inherit;"">
                                                        <font style=""vertical-align: inherit;"">");
            EndContext();
            BeginContext(9391, 10, false);
#line 166 "E:\Net Core\Project Complete\BStore\BStore\Views\DashBoard\Index.cshtml"
                                                                                          Write(item.tensp);

#line default
#line hidden
            EndContext();
            BeginContext(9401, 367, true);
            WriteLiteral(@"</font>
                                                    </font>
                                                </td>
                                                <td>
                                                    <font style=""vertical-align: inherit;"">
                                                        <font style=""vertical-align: inherit;"">");
            EndContext();
            BeginContext(9769, 34, false);
#line 171 "E:\Net Core\Project Complete\BStore\BStore\Views\DashBoard\Index.cshtml"
                                                                                          Write(String.Format("{0:N0}", @item.gia));

#line default
#line hidden
            EndContext();
            BeginContext(9803, 371, true);
            WriteLiteral(@" VNĐ</font>
                                                    </font>
                                                </td>
                                                <td>
                                                    <font style=""vertical-align: inherit;"">
                                                        <font style=""vertical-align: inherit;"">");
            EndContext();
            BeginContext(10175, 12, false);
#line 176 "E:\Net Core\Project Complete\BStore\BStore\Views\DashBoard\Index.cshtml"
                                                                                          Write(item.soluong);

#line default
#line hidden
            EndContext();
            BeginContext(10187, 367, true);
            WriteLiteral(@"</font>
                                                    </font>
                                                </td>
                                                <td>
                                                    <font style=""vertical-align: inherit;"">
                                                        <font style=""vertical-align: inherit;"">");
            EndContext();
            BeginContext(10555, 40, false);
#line 181 "E:\Net Core\Project Complete\BStore\BStore\Views\DashBoard\Index.cshtml"
                                                                                          Write(String.Format("{0:N0}", @item.thanhtien));

#line default
#line hidden
            EndContext();
            BeginContext(10595, 180, true);
            WriteLiteral(" VNĐ</font>\r\n                                                    </font>\r\n                                                </td>\r\n                                            </tr>\r\n");
            EndContext();
#line 185 "E:\Net Core\Project Complete\BStore\BStore\Views\DashBoard\Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(10818, 1960, true);
            WriteLiteral(@"                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- ============================================================== -->

                <!-- ============================================================== -->
                <!-- end recent orders  -->
                <!-- ============================================================== -->
                <!-- ============================================================== -->
                <!-- ============================================================== -->
            </div>
            <div class=""row"">
                <!-- ============================================================== -->
                <!-- ============================================================== -->
                <div class=""col-xl-3 col-lg-12 col-md-6 col-sm-12 col-12"">
                   ");
            WriteLiteral(@" <!-- ============================================================== -->
                    <!-- ============================================================== -->
                </div>
            </div>



            <!-- ============================================================== -->
            <!-- end sales traffice source  -->
            <!-- ============================================================== -->
            <!-- ============================================================== -->
            <!-- sales traffic country source  -->
            <!-- ============================================================== -->
           
            <!-- end sales traffice country source  -->
            <!-- ============================================================== -->
        </div>
        </div>
    </div>
</div>
<!-- ============================================================== -->");
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
