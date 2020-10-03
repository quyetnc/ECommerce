using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BStore.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BannerQuangCao",
                columns: table => new
                {
                    MaBanner = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkBanner = table.Column<string>(nullable: true),
                    TitleBanner = table.Column<string>(nullable: true),
                    ContentBanner = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BannerQuangCao", x => x.MaBanner);
                });

            migrationBuilder.CreateTable(
                name: "DanhGia",
                columns: table => new
                {
                    MaDanhGia = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaTaiKhoan = table.Column<int>(nullable: true),
                    MaThucDon = table.Column<int>(nullable: true),
                    LoiNhanXet = table.Column<string>(nullable: true),
                    NgayDanhGia = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhGia", x => x.MaDanhGia);
                });

            migrationBuilder.CreateTable(
                name: "DungTich",
                columns: table => new
                {
                    MaDungTich = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DungTichValue = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DungTich", x => x.MaDungTich);
                });

            migrationBuilder.CreateTable(
                name: "LoaiThucDon",
                columns: table => new
                {
                    MaLoai = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiThucDon", x => x.MaLoai);
                });

            migrationBuilder.CreateTable(
                name: "NongDo",
                columns: table => new
                {
                    MaNongDo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NongDoValue = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NongDo", x => x.MaNongDo);
                });

            migrationBuilder.CreateTable(
                name: "PhanQuyen",
                columns: table => new
                {
                    MaPhanQuyen = table.Column<string>(nullable: false),
                    QuyenHan = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhanQuyen", x => x.MaPhanQuyen);
                });

            migrationBuilder.CreateTable(
                name: "ThuongHieu",
                columns: table => new
                {
                    MaTH = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTH = table.Column<string>(nullable: true),
                    HinhAnh = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThuongHieu", x => x.MaTH);
                });

            migrationBuilder.CreateTable(
                name: "TinhThanh",
                columns: table => new
                {
                    MaTinhThanh = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTinhThanh = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinhThanh", x => x.MaTinhThanh);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    MaTaiKhoan = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTaiKhoan = table.Column<string>(nullable: true),
                    MatKhau = table.Column<string>(nullable: true),
                    MaPhanQuyen = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    AnhDaiDien = table.Column<string>(nullable: true),
                    DangHoatDong = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.MaTaiKhoan);
                    table.ForeignKey(
                        name: "FK_TaiKhoan_PhanQuyen_MaPhanQuyen",
                        column: x => x.MaPhanQuyen,
                        principalTable: "PhanQuyen",
                        principalColumn: "MaPhanQuyen",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ThucDon",
                columns: table => new
                {
                    MaThucDon = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenThucDon = table.Column<string>(nullable: true),
                    HinhAnh = table.Column<string>(nullable: true),
                    MaLoai = table.Column<int>(nullable: true),
                    MaTH = table.Column<int>(nullable: true),
                    Gia = table.Column<double>(nullable: true),
                    KhuyenMai = table.Column<int>(nullable: true),
                    MaNongDo = table.Column<int>(nullable: true),
                    MaDungTich = table.Column<int>(nullable: true),
                    MoTa = table.Column<string>(nullable: true),
                    MoreInfo = table.Column<string>(nullable: true),
                    LuotXem = table.Column<int>(nullable: true),
                    LuotMua = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThucDon", x => x.MaThucDon);
                    table.ForeignKey(
                        name: "FK_ThucDon_DungTich_MaDungTich",
                        column: x => x.MaDungTich,
                        principalTable: "DungTich",
                        principalColumn: "MaDungTich",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ThucDon_LoaiThucDon_MaLoai",
                        column: x => x.MaLoai,
                        principalTable: "LoaiThucDon",
                        principalColumn: "MaLoai",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ThucDon_NongDo_MaNongDo",
                        column: x => x.MaNongDo,
                        principalTable: "NongDo",
                        principalColumn: "MaNongDo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ThucDon_ThuongHieu_MaTH",
                        column: x => x.MaTH,
                        principalTable: "ThuongHieu",
                        principalColumn: "MaTH",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    MaKhachHang = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhachHang = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DiaChi = table.Column<string>(nullable: true),
                    SoDt = table.Column<string>(nullable: true),
                    MaTaiKhoan = table.Column<int>(nullable: true),
                    MaTinhThanh = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.MaKhachHang);
                    table.ForeignKey(
                        name: "FK_KhachHang_TaiKhoan_MaTaiKhoan",
                        column: x => x.MaTaiKhoan,
                        principalTable: "TaiKhoan",
                        principalColumn: "MaTaiKhoan",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GioHang",
                columns: table => new
                {
                    MaGioHang = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKhachHang = table.Column<int>(nullable: true),
                    TongCong = table.Column<double>(nullable: true),
                    NgayDat = table.Column<DateTime>(nullable: true),
                    TrangThai = table.Column<int>(nullable: true),
                    MaTaiKhoan = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHang", x => x.MaGioHang);
                    table.ForeignKey(
                        name: "FK_GioHang_KhachHang_MaKhachHang",
                        column: x => x.MaKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "MaKhachHang",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietGioHang",
                columns: table => new
                {
                    MaCtgioHang = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaGioHang = table.Column<int>(nullable: true),
                    MaThucDon = table.Column<int>(nullable: true),
                    SoLuong = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietGioHang", x => x.MaCtgioHang);
                    table.ForeignKey(
                        name: "FK_ChiTietGioHang_GioHang_MaGioHang",
                        column: x => x.MaGioHang,
                        principalTable: "GioHang",
                        principalColumn: "MaGioHang",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietGioHang_ThucDon_MaThucDon",
                        column: x => x.MaThucDon,
                        principalTable: "ThucDon",
                        principalColumn: "MaThucDon",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGioHang_MaGioHang",
                table: "ChiTietGioHang",
                column: "MaGioHang");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGioHang_MaThucDon",
                table: "ChiTietGioHang",
                column: "MaThucDon");

            migrationBuilder.CreateIndex(
                name: "IX_GioHang_MaKhachHang",
                table: "GioHang",
                column: "MaKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_KhachHang_MaTaiKhoan",
                table: "KhachHang",
                column: "MaTaiKhoan");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoan_MaPhanQuyen",
                table: "TaiKhoan",
                column: "MaPhanQuyen");

            migrationBuilder.CreateIndex(
                name: "IX_ThucDon_MaDungTich",
                table: "ThucDon",
                column: "MaDungTich");

            migrationBuilder.CreateIndex(
                name: "IX_ThucDon_MaLoai",
                table: "ThucDon",
                column: "MaLoai");

            migrationBuilder.CreateIndex(
                name: "IX_ThucDon_MaNongDo",
                table: "ThucDon",
                column: "MaNongDo");

            migrationBuilder.CreateIndex(
                name: "IX_ThucDon_MaTH",
                table: "ThucDon",
                column: "MaTH");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BannerQuangCao");

            migrationBuilder.DropTable(
                name: "ChiTietGioHang");

            migrationBuilder.DropTable(
                name: "DanhGia");

            migrationBuilder.DropTable(
                name: "TinhThanh");

            migrationBuilder.DropTable(
                name: "GioHang");

            migrationBuilder.DropTable(
                name: "ThucDon");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "DungTich");

            migrationBuilder.DropTable(
                name: "LoaiThucDon");

            migrationBuilder.DropTable(
                name: "NongDo");

            migrationBuilder.DropTable(
                name: "ThuongHieu");

            migrationBuilder.DropTable(
                name: "TaiKhoan");

            migrationBuilder.DropTable(
                name: "PhanQuyen");
        }
    }
}
