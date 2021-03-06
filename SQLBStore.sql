/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 12/24/2019 11:04:41 AM ******/



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BannerQuangCao]    Script Date: 12/24/2019 11:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BannerQuangCao](
	[MaBanner] [int] IDENTITY(1,1) NOT NULL,
	[LinkBanner] [nvarchar](max) NULL,
	[ContentBanner] [nvarchar](max) NULL,
	[TitleBanner] [nvarchar](max) NULL,
 CONSTRAINT [PK_BannerQuangCao] PRIMARY KEY CLUSTERED 
(
	[MaBanner] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietGioHang]    Script Date: 12/24/2019 11:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietGioHang](
	[MaCtgioHang] [int] IDENTITY(1,1) NOT NULL,
	[MaGioHang] [int] NULL,
	[MaThucDon] [int] NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_ChiTietGioHang] PRIMARY KEY CLUSTERED 
(
	[MaCtgioHang] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhGia]    Script Date: 12/24/2019 11:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhGia](
	[MaDanhGia] [int] IDENTITY(1,1) NOT NULL,
	[MaTaiKhoan] [int] NULL,
	[MaThucDon] [int] NULL,
	[LoiNhanXet] [nvarchar](max) NULL,
	[NgayDanhGia] [datetime2](7) NULL,
 CONSTRAINT [PK_DanhGia] PRIMARY KEY CLUSTERED 
(
	[MaDanhGia] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DungTich]    Script Date: 12/24/2019 11:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DungTich](
	[MaDungTich] [int] IDENTITY(1,1) NOT NULL,
	[DungTichValue] [int] NOT NULL,
 CONSTRAINT [PK_DungTich] PRIMARY KEY CLUSTERED 
(
	[MaDungTich] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GioHang]    Script Date: 12/24/2019 11:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GioHang](
	[MaGioHang] [int] IDENTITY(1,1) NOT NULL,
	[MaKhachHang] [int] NULL,
	[TongCong] [float] NULL,
	[NgayDat] [datetime2](7) NULL,
	[TrangThai] [int] NULL,
	[MaTaiKhoan] [int] NULL,
 CONSTRAINT [PK_GioHang] PRIMARY KEY CLUSTERED 
(
	[MaGioHang] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/24/2019 11:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[TenKhachHang] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[SoDt] [nvarchar](max) NULL,
	[MaTaiKhoan] [int] NULL,
	[MaTinhThanh] [int] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiThucDon]    Script Date: 12/24/2019 11:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiThucDon](
	[MaLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](max) NULL,
 CONSTRAINT [PK_LoaiThucDon] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NongDo]    Script Date: 12/24/2019 11:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NongDo](
	[MaNongDo] [int] IDENTITY(1,1) NOT NULL,
	[NongDoValue] [float] NOT NULL,
 CONSTRAINT [PK_NongDo] PRIMARY KEY CLUSTERED 
(
	[MaNongDo] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 12/24/2019 11:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanQuyen](
	[MaPhanQuyen] [nvarchar](450) NOT NULL,
	[QuyenHan] [nvarchar](max) NULL,
 CONSTRAINT [PK_PhanQuyen] PRIMARY KEY CLUSTERED 
(
	[MaPhanQuyen] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 12/24/2019 11:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaTaiKhoan] [int] IDENTITY(1,1) NOT NULL,
	[TenTaiKhoan] [nvarchar](max) NULL,
	[MatKhau] [nvarchar](max) NULL,
	[MaPhanQuyen] [nvarchar](450) NULL,
	[Email] [nvarchar](max) NULL,
	[AnhDaiDien] [nvarchar](max) NULL,
	[DangHoatDong] [int] NOT NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[MaTaiKhoan] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThucDon]    Script Date: 12/24/2019 11:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThucDon](
	[MaThucDon] [int] IDENTITY(1,1) NOT NULL,
	[TenThucDon] [nvarchar](max) NULL,
	[HinhAnh] [nvarchar](max) NULL,
	[MaLoai] [int] NULL,
	[Gia] [float] NULL,
	[KhuyenMai] [int] NULL,
	[MoTa] [nvarchar](max) NULL,
	[LuotMua] [int] NULL,
	[LuotXem] [int] NULL,
	[MaTH] [int] NULL,
	[MaDungTich] [int] NULL,
	[MaNongDo] [int] NULL,
	[MoreInfo] [nvarchar](max) NULL,
 CONSTRAINT [PK_ThucDon] PRIMARY KEY CLUSTERED 
(
	[MaThucDon] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThuongHieu]    Script Date: 12/24/2019 11:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThuongHieu](
	[MaTH] [int] IDENTITY(1,1) NOT NULL,
	[TenTH] [nvarchar](max) NULL,
	[HinhAnh] [nvarchar](max) NULL,
 CONSTRAINT [PK_ThuongHieu] PRIMARY KEY CLUSTERED 
(
	[MaTH] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TinhThanh]    Script Date: 12/24/2019 11:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TinhThanh](
	[MaTinhThanh] [int] IDENTITY(1,1) NOT NULL,
	[TenTinhThanh] [nvarchar](max) NULL,
 CONSTRAINT [PK_TinhThanh] PRIMARY KEY CLUSTERED 
(
	[MaTinhThanh] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191217083511_Bstore', N'2.2.4-servicing-10062')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191217135801_addThuongHieu', N'2.2.4-servicing-10062')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191217140240_update_banner', N'2.2.4-servicing-10062')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191217140330_update_banner_again', N'2.2.4-servicing-10062')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191217141406_update_banner_2', N'2.2.4-servicing-10062')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191217164556_add_nongdo_dungtich', N'2.2.4-servicing-10062')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191217164940_update_nongdo', N'2.2.4-servicing-10062')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191218070919_update_moreinfo', N'2.2.4-servicing-10062')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191219125057_Update', N'2.2.4-servicing-10062')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191220081927_update20_12', N'2.2.4-servicing-10062')
SET IDENTITY_INSERT [dbo].[BannerQuangCao] ON 

INSERT [dbo].[BannerQuangCao] ([MaBanner], [LinkBanner], [ContentBanner], [TitleBanner]) VALUES (3, N'63712508427941531412791067_1674440532826103_4427958388327233949_n.jpg', N'ok', N'ok')
INSERT [dbo].[BannerQuangCao] ([MaBanner], [LinkBanner], [ContentBanner], [TitleBanner]) VALUES (4, N'macdinh.jpg', N'ok2', N'ok2')
SET IDENTITY_INSERT [dbo].[BannerQuangCao] OFF
SET IDENTITY_INSERT [dbo].[ChiTietGioHang] ON 

INSERT [dbo].[ChiTietGioHang] ([MaCtgioHang], [MaGioHang], [MaThucDon], [SoLuong]) VALUES (1, 1, 1011, 1)
INSERT [dbo].[ChiTietGioHang] ([MaCtgioHang], [MaGioHang], [MaThucDon], [SoLuong]) VALUES (2, 1, 1012, 1)
INSERT [dbo].[ChiTietGioHang] ([MaCtgioHang], [MaGioHang], [MaThucDon], [SoLuong]) VALUES (3, 2, 1011, 1)
INSERT [dbo].[ChiTietGioHang] ([MaCtgioHang], [MaGioHang], [MaThucDon], [SoLuong]) VALUES (4, 2, 1012, 1)
INSERT [dbo].[ChiTietGioHang] ([MaCtgioHang], [MaGioHang], [MaThucDon], [SoLuong]) VALUES (5, 2, 1014, 1)
INSERT [dbo].[ChiTietGioHang] ([MaCtgioHang], [MaGioHang], [MaThucDon], [SoLuong]) VALUES (6, 3, 1012, 1)
INSERT [dbo].[ChiTietGioHang] ([MaCtgioHang], [MaGioHang], [MaThucDon], [SoLuong]) VALUES (7, 3, 1014, 2)
SET IDENTITY_INSERT [dbo].[ChiTietGioHang] OFF
SET IDENTITY_INSERT [dbo].[DanhGia] ON 

INSERT [dbo].[DanhGia] ([MaDanhGia], [MaTaiKhoan], [MaThucDon], [LoiNhanXet], [NgayDanhGia]) VALUES (1, 2, 1, N'Trải qua nhiều giai đoạn phát triển cùng đời sống của người dân nơi đây cũng như những sự biến mất sau hai cuộc thế chiến lớn, dòng bia Hoegaarden này đã được khôi phục lại nhờ vào bàn tay của  Pierre Celis - một người giao sữa bình thường nhưng rất yêu hương vị của Hoegaarden. Kể từ đó đến nay, Hoegaarden đã vượt ra khỏi biên giới nước Bỉ và được đón chào trên toàn thế giới trong những bữa ăn gia đình, những bữa tiệc họp mặt, tiệc mừng của rất nhiều nơi.', CAST(N'2019-12-17T20:05:36.5228675' AS DateTime2))
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaTaiKhoan], [MaThucDon], [LoiNhanXet], [NgayDanhGia]) VALUES (2, 2, 1, N'Bia Uống Không Say', CAST(N'2019-10-10T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaTaiKhoan], [MaThucDon], [LoiNhanXet], [NgayDanhGia]) VALUES (3, 2, 5, N'Ngon Lắm', CAST(N'2019-12-18T15:34:21.7573104' AS DateTime2))
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaTaiKhoan], [MaThucDon], [LoiNhanXet], [NgayDanhGia]) VALUES (4, 0, 0, NULL, CAST(N'2019-12-18T15:34:43.6213972' AS DateTime2))
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaTaiKhoan], [MaThucDon], [LoiNhanXet], [NgayDanhGia]) VALUES (5, 2, 6, N'Very Good', CAST(N'2019-12-18T15:41:56.1710353' AS DateTime2))
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaTaiKhoan], [MaThucDon], [LoiNhanXet], [NgayDanhGia]) VALUES (6, 2, 4, N'Được Lắm', CAST(N'2019-12-18T15:42:15.8651486' AS DateTime2))
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaTaiKhoan], [MaThucDon], [LoiNhanXet], [NgayDanhGia]) VALUES (7, 2, 4, N'Số 1', CAST(N'2019-12-18T15:43:09.7953235' AS DateTime2))
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaTaiKhoan], [MaThucDon], [LoiNhanXet], [NgayDanhGia]) VALUES (8, 2, 4, N'Oke', CAST(N'2019-12-18T15:43:41.7621771' AS DateTime2))
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaTaiKhoan], [MaThucDon], [LoiNhanXet], [NgayDanhGia]) VALUES (9, 2, 4, N'Tuyệt', CAST(N'2019-12-18T15:44:40.9257717' AS DateTime2))
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaTaiKhoan], [MaThucDon], [LoiNhanXet], [NgayDanhGia]) VALUES (10, 2, 6, N'Number 1', CAST(N'2019-12-18T15:45:10.7511477' AS DateTime2))
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaTaiKhoan], [MaThucDon], [LoiNhanXet], [NgayDanhGia]) VALUES (11, 2, 3, N'VIP', CAST(N'2019-12-18T15:45:20.3744658' AS DateTime2))
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaTaiKhoan], [MaThucDon], [LoiNhanXet], [NgayDanhGia]) VALUES (12, 2, 1, N'Oke ne`', CAST(N'2019-12-18T20:00:25.8914865' AS DateTime2))
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaTaiKhoan], [MaThucDon], [LoiNhanXet], [NgayDanhGia]) VALUES (13, 2, 1011, N'Khas Ngon', CAST(N'2019-12-20T18:47:56.6163372' AS DateTime2))
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaTaiKhoan], [MaThucDon], [LoiNhanXet], [NgayDanhGia]) VALUES (14, 1, 1011, N'OK', CAST(N'2019-12-21T10:22:12.9285427' AS DateTime2))
SET IDENTITY_INSERT [dbo].[DanhGia] OFF
SET IDENTITY_INSERT [dbo].[DungTich] ON 

INSERT [dbo].[DungTich] ([MaDungTich], [DungTichValue]) VALUES (1, 250)
INSERT [dbo].[DungTich] ([MaDungTich], [DungTichValue]) VALUES (2, 330)
INSERT [dbo].[DungTich] ([MaDungTich], [DungTichValue]) VALUES (3, 500)
INSERT [dbo].[DungTich] ([MaDungTich], [DungTichValue]) VALUES (4, 750)
INSERT [dbo].[DungTich] ([MaDungTich], [DungTichValue]) VALUES (5, 1000)
INSERT [dbo].[DungTich] ([MaDungTich], [DungTichValue]) VALUES (6, 1300)
INSERT [dbo].[DungTich] ([MaDungTich], [DungTichValue]) VALUES (7, 1500)
INSERT [dbo].[DungTich] ([MaDungTich], [DungTichValue]) VALUES (8, 1800)
INSERT [dbo].[DungTich] ([MaDungTich], [DungTichValue]) VALUES (9, 3000)
INSERT [dbo].[DungTich] ([MaDungTich], [DungTichValue]) VALUES (10, 4000)
INSERT [dbo].[DungTich] ([MaDungTich], [DungTichValue]) VALUES (11, 5000)
SET IDENTITY_INSERT [dbo].[DungTich] OFF
SET IDENTITY_INSERT [dbo].[GioHang] ON 

INSERT [dbo].[GioHang] ([MaGioHang], [MaKhachHang], [TongCong], [NgayDat], [TrangThai], [MaTaiKhoan]) VALUES (1, 2, 288000, CAST(N'2019-12-20T14:59:34.9809298' AS DateTime2), 0, 2)
INSERT [dbo].[GioHang] ([MaGioHang], [MaKhachHang], [TongCong], [NgayDat], [TrangThai], [MaTaiKhoan]) VALUES (2, 3, 456000, CAST(N'2019-12-20T22:17:15.2656310' AS DateTime2), 0, 2)
INSERT [dbo].[GioHang] ([MaGioHang], [MaKhachHang], [TongCong], [NgayDat], [TrangThai], [MaTaiKhoan]) VALUES (3, 4, 534000, CAST(N'2019-12-21T10:19:31.4598444' AS DateTime2), 1, 2)
SET IDENTITY_INSERT [dbo].[GioHang] OFF
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SoDt], [MaTaiKhoan], [MaTinhThanh]) VALUES (1, N'a', N'a', N'a', N'a', 1, 5)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SoDt], [MaTaiKhoan], [MaTinhThanh]) VALUES (2, N'Quyết', N'demon.bmt@gmail.com', N'Quận 8', N'01252243383', 2, 2)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SoDt], [MaTaiKhoan], [MaTinhThanh]) VALUES (3, N'Quyết', N'de123123et@gmail.com', N'DakLak', N'0949209394', 2, 2)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SoDt], [MaTaiKhoan], [MaTinhThanh]) VALUES (4, N'Quyết', N'demon.bmt@gmail.com', N'DakLak', N'01252243383', 2, 20)
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
SET IDENTITY_INSERT [dbo].[LoaiThucDon] ON 

INSERT [dbo].[LoaiThucDon] ([MaLoai], [TenLoai]) VALUES (1, N'Bia Đức')
INSERT [dbo].[LoaiThucDon] ([MaLoai], [TenLoai]) VALUES (2, N'Bia Mỹ')
INSERT [dbo].[LoaiThucDon] ([MaLoai], [TenLoai]) VALUES (3, N'Bia Bỉ')
INSERT [dbo].[LoaiThucDon] ([MaLoai], [TenLoai]) VALUES (4, N'Bia Tiệp')
INSERT [dbo].[LoaiThucDon] ([MaLoai], [TenLoai]) VALUES (5, N'Bia Hà Lan')
INSERT [dbo].[LoaiThucDon] ([MaLoai], [TenLoai]) VALUES (6, N'Bia Nhật')
INSERT [dbo].[LoaiThucDon] ([MaLoai], [TenLoai]) VALUES (7, N'Bia Pháp')
INSERT [dbo].[LoaiThucDon] ([MaLoai], [TenLoai]) VALUES (8, N'Bia Nga')
INSERT [dbo].[LoaiThucDon] ([MaLoai], [TenLoai]) VALUES (9, N'Bia Lào')
INSERT [dbo].[LoaiThucDon] ([MaLoai], [TenLoai]) VALUES (10, N'Bia Mexico')
SET IDENTITY_INSERT [dbo].[LoaiThucDon] OFF
SET IDENTITY_INSERT [dbo].[NongDo] ON 

INSERT [dbo].[NongDo] ([MaNongDo], [NongDoValue]) VALUES (1, 4)
INSERT [dbo].[NongDo] ([MaNongDo], [NongDoValue]) VALUES (3, 4.2)
INSERT [dbo].[NongDo] ([MaNongDo], [NongDoValue]) VALUES (4, 4.8)
INSERT [dbo].[NongDo] ([MaNongDo], [NongDoValue]) VALUES (5, 5)
INSERT [dbo].[NongDo] ([MaNongDo], [NongDoValue]) VALUES (6, 5.3)
INSERT [dbo].[NongDo] ([MaNongDo], [NongDoValue]) VALUES (7, 5.5)
INSERT [dbo].[NongDo] ([MaNongDo], [NongDoValue]) VALUES (8, 5.6)
INSERT [dbo].[NongDo] ([MaNongDo], [NongDoValue]) VALUES (9, 6)
INSERT [dbo].[NongDo] ([MaNongDo], [NongDoValue]) VALUES (10, 6.5)
INSERT [dbo].[NongDo] ([MaNongDo], [NongDoValue]) VALUES (11, 7)
INSERT [dbo].[NongDo] ([MaNongDo], [NongDoValue]) VALUES (12, 7.4)
INSERT [dbo].[NongDo] ([MaNongDo], [NongDoValue]) VALUES (13, 8)
SET IDENTITY_INSERT [dbo].[NongDo] OFF
INSERT [dbo].[PhanQuyen] ([MaPhanQuyen], [QuyenHan]) VALUES (N'1', N'Quản Trị Viên')
INSERT [dbo].[PhanQuyen] ([MaPhanQuyen], [QuyenHan]) VALUES (N'2', N'Khách Hàng')
SET IDENTITY_INSERT [dbo].[TaiKhoan] ON 

INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [MatKhau], [MaPhanQuyen], [Email], [AnhDaiDien], [DangHoatDong]) VALUES (1, N'admin', N'1', N'1', N'admin@gmail.com', N'637124017962651713biaduc.jpg', 1)
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [MatKhau], [MaPhanQuyen], [Email], [AnhDaiDien], [DangHoatDong]) VALUES (2, N'quyet', N'1', N'2', N'quyet@gmail.com', N'ncq.jpg', 0)
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [MatKhau], [MaPhanQuyen], [Email], [AnhDaiDien], [DangHoatDong]) VALUES (1003, N'quyetnc', N'qweqwe', N'2', N'demon.bmt@gmail.com', N'bia-chimay-do-7--330ml-thumb.jpg', 0)
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [MatKhau], [MaPhanQuyen], [Email], [AnhDaiDien], [DangHoatDong]) VALUES (1004, N'quyetttđ', N'123123', N'2', N'demon.bmt@gmail.com', N'637124771715767670biaduc.jpg', 0)
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [MatKhau], [MaPhanQuyen], [Email], [AnhDaiDien], [DangHoatDong]) VALUES (1005, N'user123', N'user123', N'2', N'user@gmail.com', N'none-avatar.jpg', 0)
SET IDENTITY_INSERT [dbo].[TaiKhoan] OFF
SET IDENTITY_INSERT [dbo].[ThucDon] ON 

INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1010, N'Chimay Xanh 9 độ ', N'download.jpg', 3, 90000, 0, N'Bia Chimay Xanh là loại bia mạnh với độ cồn 9%, có hương thơm tươi mát của men bia tươi, thoảng hương hoa hồng và vị của mạch nha cháy.', NULL, 6, 1007, 1, 1, N'Chimay Xanh là chủ yếu phân biệt bởi nhân vật của mình một bia mạnh mẽ . Đây là một bia có hương thơm của nấm men tươi được kết hợp với ánh sáng , hoa hồng liên tục do đó mùi thơm đặc biệt dễ chịu. Hương vị của nó , nhận thấy khi nếm nó , chỉ làm nổi bật những cảm giác dễ chịu trong cảm nhận mùi thơm ,  Trong khi uống có vẻ nhận thấy được sự mạnh mẽ đến lạ lùng nhưng cái cảm hứng dễ chịu của mạch nha rang làm hương vị bia Chimay càng thêm thích thú đây là loại bia Trappist đầu tiên lên men trong chai , không tiệt trùng .')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1011, N'Chimay Đỏ 7 độ – 330ml', N'637124597511068109cm7d.PNG', 3, 90000, 0, N'Bia Chimay đỏ được lưu trữ:Trong chai thủy tinh Trappist , Tulip, là sản phảm bia lâu đời nhất của Chimays. Bia chimay đỏ Trappist này sở hữu một màu đồng đẹp mà làm cho nó đặc biệt hấp dẫn với bất cứ ai muốn sở hữu nó khi không đủ tự tin. ', 2, 5, 1007, 2, 3, N'Bia Chimay đỏ 7%-330ml là sản phảm bia lâu đời nhất của Chimays. Bia chimay đỏ Trappist này sở hữu một màu đồng đẹp mà làm cho nó đặc biệt hấp dẫn với bất cứ ai muốn sở hữu nó khi không đủ tự tin. Hương vị đầu tiên với một vị  kem, tiếp theo đó nó sẽ cho ra một vị trái cây nhẹ mơ mùi từ quá trình lên men.  Hương thơm cảm thấy trong miệng là một sự cân bằng xác nhận những sắc thái trái cây tiết lộ cho khứu giác mạnh mẽ nhưng lại chưa thể mạnh bằng chimay xanh. Bia Bỉ truyền thống này là tốt nhất thưởng thức ở nhiệt độ hầm (10 - 12 ° C). nhiệt độ bảo quản trong tủ lạnh 13-15 độ C')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1012, N'Chimay Đỏ 7 độ – 75cl', N'download.jpg', 3, 220000, 10, N'Bia Chimay Đỏ75cl   Xuất xứ: Bỉmang hương vị hoa quả nhẹ, đặc biệt rất thơm mùi quả mơ do quá trình lên men đặc biệt. Chimay đỏ để lại nơi đầu lưỡi người uống vị ngọt nhẹ, hơi chút đắng', 3, 2, 1007, 4, 11, N'Bia chimay đỏ mang hương vị hoa quả nhẹ, đặc biệt rất thơm mùi quả mơ do quá trình lên men đặc biệt. Chimay đỏ để lại nơi đầu lưỡi người uống vị ngọt nhẹ, hơi chút đắng. Nhệt độ lý tưởng để thưởng thức bia CHIMAY là từ 10 độ C đến 12 độ C. Tuyệt hảo khi ăn cùng với pho mát.  Lịch sử bia chimay Năm 1862 Các thầy tu trong tu viện bắt đầu sản xuất các loại bia Chimay theo truyền thống của tu viện.Giáng sinh năm 1948 ông đã tạo ra một loại bia dùng cho giáng sinh và sau này trở thành Chimay Blue .Năm 1986 họ tiếp tục tạo ra các sản phẩm mới , năm  2001 nhưng những loại bia này hiện chưa được phân phối tại việt nam.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1013, N'Duvel 9 độ – 330ml', N'download.jpg', 3, 70000, 0, N'Bia Duvel Moortgat là một trong những tập đoàn bia lớn nhất tại Bỉ bằng cách tập trung cạnh tranh vào các loại bia đặc biệt. Hiện nay sự thành công của Duvel chủ yếu dựa vào chất lượng sản phẩm.', NULL, NULL, 1008, 2, 13, N'Bia duvel là một sản phẩm bia của tập đoàn Duvel Moortgat đây được coi là một tập đoàn bia lớn nhất của đất nước bỉ. Đặc điểm của bia duvel Bia duvel có một hương thơm mùi của mùi trái cây với vị êm nhẹ pha chút men đắng đặc trưng tạo cảm nhận hài hòa và tươi mát.Bia này có nồng độ 8.5% cũng khá cao đang được nhiều đấng mày râu yêu thích  nhất mùa hè 2015. Hiện nay sự thành công của Duvel chủ yếu dựa vào chất lượng sản phẩm, thương hiệu mạnh  Kết hợp bia duvel với thức ăn Phục vụ lý tưởng ở nhiệt độ 5-6 độ. Có thể ăn kèm với phomat, đồ nước, thịt đỏ')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1014, N'Duvel 9 độ', N'637124599657149296duvel9d.PNG', 3, 210000, 20, N'Bia Duvel Moortgat  750ml là một trong những tập đoàn bia lớn nhất tại Bỉ bằng cách tập trung cạnh tranh vào các loại bia đặc biệt.', 3, 1, 1008, 4, 1, N'Bia duvel là một sản phẩm bia của tập đoàn Duvel Moortgat đây được coi là một tập đoàn bia lớn nhất của đất nước bỉ. Đặc điểm của bia duvel Bia duvel có một hương thơm mùi của mùi trái cây với vị êm nhẹ pha chút men đắng đặc trưng tạo cảm nhận hài hòa và tươi mát.Bia này có nồng độ 8.5% cũng khá cao đang được nhiều đấng mày râu yêu thích  nhất mùa hè 2015. Hiện nay sự thành công của Duvel chủ yếu dựa vào chất lượng sản phẩm, thương hiệu mạnh  Kết hợp bia duvel với thức ăn Phục vụ lý tưởng ở nhiệt độ 5-6 độ. Có thể ăn kèm với phomat, đồ nước, thịt đỏ')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1015, N'Leffe Vàng 33cl', N'637124601008840487Leffe.PNG', 3, 750000, 20, N'Bia Leffe vànglà loại bia hoa quả nguyên chất, nhẹ, có vị đậm đà, mang hương vị củagừng, cam, nhục đậu khấu, để lại vị dịu ngọt nơi đầu lưỡi.', NULL, NULL, 1009, 2, 11, N'Bia Leffe vàng là loại bia hoa quả nguyên chất, nhẹ, có vị đậm đà, mang hương vị của gừng, cam, nhục đậu khấu, để lại vị dịu ngọt nơi đầu lưỡi. Thích hợp để dùng trong các bữa ăn nhẹ, với bánh qui hoặc patê cá hồi. Dùng lạnh, hương vị đậm đà nhất khi dùng ở nhiệt độ 5 độ C')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1016, N'Leffe Nâu 33cl', N'637124601811990315lfnau.PNG', 3, 980000, 0, N'Bia Leffe nâu làloại bia hoa quả mạnh hơn bia Leffe vàng, hương vị chính là vị caramelcháy và vị ngọt nhẹ. Tuyệt hảo khi dùng với các món ăn thịnh soạn', NULL, 1, 1009, 4, 11, N'Bia Leffe nâu là loại bia hoa quả mạnh hơn bia Leffe vàng, hương vị chính là vị caramel cháy và vị ngọt nhẹ. Tuyệt hảo khi dùng với các món ăn thịnh soạn. Dùng lạnh, hương vị đậm đà nhất khi dùng ở nhiệt độ 5 độ C')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1017, N'ST.Sebastiaan Grand Cru', N'637124602294021764sbs.PNG', 3, 210000, 0, N'Bia Sứ ST.Sebastiaan Grand Cru Là loại bia lên men nổi, hương vị có sự kết hợp hài hòa giữa hương maltêm dịu với hương hoa cỏ, phảng phất mùi thơm của nấm men.', NULL, NULL, 1010, 3, 9, N'ST.Sebastiaan Grand Cru là loại bia lên men nổi, hương vị có sự kết hợp hài hòa giữa hương maltêm dịu với hương hoa cỏ, phảng phất mùi thơm của nấm men. Bia mang vị ngọt dịu của malt, đường và mật ong, khi uống thoảng vị cồn pha lẫn một chút hương thảo mộc, vị đắng dịu của hoa bia, đem đến cho người uống hậu vị sảng khoái.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1018, N'ST.Sebastiaan Dark', N'637124612957652947sdsd.PNG', 3, 210000, 0, N'Bia Chai sứ-Bia thầy tu-Bia Màu hổ pháchNồng độ cồn:9% một dòng bia cao cấp chất lượng cho những ai muốn khám phá và thưởng thức nó,Bia St.sebastiaan có một màu hổ phách đậm đà,một màu nâu quyến rũ.', NULL, NULL, 1010, 4, 8, N'Bia Sứ ST.Sebastiaan Dark là một dòng bia cao cấp chất lượng cho những ai muốn khám phá và thưởng thức nó,Bia St.sebastiaan có một màu hổ phách đậm đà,một màu nâu quyến rũ, Bia Bỉ St.Sebastiaan có hương thơm mạch nha được rang cháy ,cùng với hương thơm của các loại trái cây ,cỏ cây.  Hương thơm của Thảo mộc nhưng lại pha chút vị đắng của men Hoa Bia,tạo sự phấn khích cho người thưởng thức loại bia thứ thiệt này một cách khoan khoái và dễ chịu.Một sự cân bằng độc đáo tạo nên một loại  Vài nét về lịch sử bia  Sứ ST.Sebastiaan Dark Gia đình nhà Sterkens đã ủ loại bia men Ale tuyệt vời hàng đầu ở  làng Meer ở miền Bắc Bỉ kể từ năm 1651.Năm 1990, nhà máy bia Sterkens chủ yếu là phân phối các loại bia của mình cho hơn 500 nhà hàng và quán rượu ở Bỉ. ')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1019, N'St.Paul Double', N'637124613447323796paul.PNG', 3, 215000, 10, N'Lên men nổiChai sứ: 500mlHạn sử dụng: 3 nămBia có màu đen ánh đồng với bọt trắng mịn dày. Bia mang vị ngọt kết hợp hài hòa với vị đắng và hương thơm của malt.', NULL, NULL, 1011, 4, 9, N'Bia St.Paul Double có màu đen ánh đồng với bọt trắng mịn dày. Bia mang vị ngọt kết hợp hài hòa với vị đắng và hương thơm của malt. Hương thơm của Thảo mộc nhưng lại pha chút vị đắng của men Hoa Bia,tạo sự phấn khích cho người thưởng thức loại bia thứ thiệt này một cách khoan khoái và dễ chịu.Một sự cân bằng độc đáo tạo nên một loại')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1020, N'St. Paul Triple', N'637124614028356191pault.PNG', 3, 215000, 0, N'Loại bia: Tu việnMàu: VàngĐộ cồn:  7,6% thể tíchHoa bia:  Hop BỉLên men nổiChai sứ 50 cl, chai thuỷ tinh 75 clHạn sử dụng:  3 nămBia có màu vàng hấp dẫn và bọt trắng tuyệt đẹp, được lên men nhờ phương pháp lên men nổi, vị malt êm dịu.', NULL, NULL, 1011, 3, 11, N'Bia St. Paul Triple có màu vàng hấp dẫn và bọt trắng tuyệt đẹp, được lên men nhờ phương pháp lên men nổi, vị malt êm dịu.Hương thơm của Thảo mộc nhưng lại pha chút vị đắng của men Hoa Bia,tạo sự phấn khích cho người thưởng thức loại bia thứ thiệt này một cách khoan khoái và dễ chịu.Một sự cân bằng độc đáo tạo nên một loại Thưởng thức bia St. Paul Triple với thức ăn Thức ăn tuyệt vời cho việc dùng Bia St. Paul Triple gồm những món nướng đặc trưng từ hương thơm của than hoa nướng thơm cháy khét,các qua thịt xiên hun khói,bacon,xúc xích,…..tất cả tạo nên một bữa ăn trọn vẹn')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1021, N'Primator EXKLUZIV ', N'637124614699208822primator.PNG', 4, 100000, 0, N'EXKLUZIV 16%Vị men bia mạnh mẽ hòa cùng vị nồng nhẹ nhàng và hương vị tinh khiết cao.Chủng loại: bia vàng Light đặc biệt.Độ cồn: 7.5% thể tích.Thành phần: nước, lúa mì, mạch nha, đường, nguyên liệu Hops từ vùng Zatec, Cộng Hòa Séc.', NULL, NULL, 1012, 4, 8, N'Exkluziv đạt được nhiều giải thưởng cho sản phẩm bia, là một trong các sản phẩm của giải thưởng “World’s Best Beers” do tạp chí thương mại World Beer Awards trao tặng vào tháng 7 năm 2008 và năm 2011  Là loại bia được các chuyên gia đánh giá cao, đặc biệt là hương vị ngọt ngào kéo dài của mạch nha vùng Moravian và với nồng độ 7.5%, Exkluziv còn được biết đến như một “Doppel Bock”. Loại bia này giúp bạn bổ sung năng lượng cho những buổi picnic vào mùa lạnh, thích hợp với BBQ hoặc các món ăn nhiều gia vị khác. Có vị tốt nhất khi ướp lạnh ở 7oC – 8oC.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1022, N'Primator Double', N'637124615319312528primd.PNG', 4, 100000, 0, N'DOUBLE 24% - Vị giác được vuốt veVị bia ngọt ngào, nhẹ nhàng khác biệt tích hợp của 5 loại hương thơm mạch nha độc đáo.Với độ tinh khiết cao chiết xuất  tạo cho việc hấp thụ vào thành mạch dạ dày tốt nhất gây hưng phấn tức thời do vậy còn được gọi là viagra đen', NULL, NULL, 1012, 4, 7, N' Bia Primator Double là một loại đặc biệt của bia đen Porter, nó thách thức giác quan của những ai muốn thử một cái gì đó khác thường và thú vị. Với nồng độ cao, loại bia này được xếp vào loại bia mạnh từ năm 1990 không chỉ tại Cộng Hòa Séc mà còn tại Châu Âu. Đồng thời, với sự pha trộn độc đáo và chiết xuất tinh khiết của các thành phần bia, hỗ trợ cho sự tiêu hóa, nó được xem là một loại bia khai vị tốt nhất hiên nay.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1023, N'Zubr Gold', N'download.jpg', 4, 100000, 10, N' Bia Zubr Gold 500ml  Bia trở thành câu chuyện về tín ngưỡng và thần thoại, thời tiền sử con người với tên Enkidu mà các thánh thần muốn so sức mạnh con người với Gilamesch', NULL, NULL, 1013, 3, 6, N'Bia trở thành câu chuyện về tín ngưỡng và thần thoại, thời tiền sử con người với tên Enkidu mà các thánh thần muốn so sức mạnh con người với Gilamesch. Gilamesch gởi người đàn bà một tuần lễ đến khai hoá văn minh cho Enkidu, người Enkidu chưa biết ăn bánh mì chưa biết uống bia, chính người đàn bà nầy dạy cho biết uống bia… (xem trích dẫn phần 1 cuối bài). Có thêm câu chuyện, người phát minh ra bia là một bệnh nhân nghèo, ông ta bỏ bánh mì cứng trong ly nước cho mềm để ăn, nhưng ông để quên hai ngày sau bánh mì lên men trong ly như một món cháo đặc, ông ăn có cảm giác ngây ngất say vì hơi men sau đó thì lành bệnh.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1024, N'Zubr Premium ', N'637124616344748166zubrw.PNG', 4, 100000, 0, N'Bia trở thành câu chuyện về tín ngưỡng và thần thoại, thời tiền sử con người với tên Enkidu mà các thánh thần muốn so sức mạnh con người với Gilamesch', NULL, NULL, 1013, 3, 8, N'Bia trở thành câu chuyện về tín ngưỡng và thần thoại, thời tiền sử con người với tên Enkidu mà các thánh thần muốn so sức mạnh con người với Gilamesch. Gilamesch gởi người đàn bà một tuần lễ đến khai hoá văn minh cho Enkidu, người Enkidu chưa biết ăn bánh mì chưa biết uống bia, chính người đàn bà nầy dạy cho biết uống bia… (xem trích dẫn phần 1 cuối bài). Có thêm câu chuyện, người phát minh ra bia là một bệnh nhân nghèo, ông ta bỏ bánh mì cứng trong ly nước cho mềm để ăn, nhưng ông để quên hai ngày sau bánh mì lên men trong ly như một món cháo đặc, ông ăn có cảm giác ngây ngất say vì hơi men sau đó thì lành bệnh.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1025, N'Pilsner', N'637124617079410942pilsner.PNG', 4, 50000, 0, N'Bia Pilsner 330ml-Bia Tiệp với mục đích kết nối sự độc đáo về bề dày lịch sử và truyềnthống nghề nấu bia Cộng Hòa Séc với phong cách sống hiện đại ngày nay', NULL, NULL, 1014, 2, 4, N'Bia tiệp Pilsner 330ml chỉ được sản xuất tại một nhà máy duy nhất ởPilsen– CH Séc suốt 200 năm qua và được xuất đi hơn 160 quốc gia toànthế giới. Bia tiệp Pilsner 330ml chỉ được sản xuất tại một nhà máy duy nhất ởPilsen– CH Séc suốt 200 năm qua và được xuất đi hơn 160 quốc gia toànthế giới.  Lịch sử bia Pilsner Josef Groll - một thiên tài lập dị, với những kiến thức sâu rộng và tầmnhìn xa hơn những gì mọi người đã từng làm trong quy trình nấu bia, thayvì cho lên men trên bề mặt như hàng trăm năm trước đây, ông đã làmngược lại là “cho lên men dưới đáy thùng” cùng với loại lúa mạch Bohemiađặc chủng và Hoa bia thượng hạng vùng Žatec, tháng 10-1842 tại khu chợSt. Martin ở Pilsen, Josef Groll đã cho ra mắt dòng bia Pilsner Urquel lvàng óng với hương vị tuyệt hảo mà chưa ai được thưởng thức trước đây.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1026, N'Staropramen ', N'637124617617363044staropramen.PNG', 4, 40000, 0, N'Staropramen (Staro) là một loại bia lager ngon, được nấu tại nhà máy biaPraha bằng phương pháp sản xuất bia truyền thống của người Czech và làloại bia được xếp vị trí hàng đầu tại Praha, thủ đô của CH Czech.', NULL, NULL, 1015, 1, 1, N'Hương vị của bia Staropramen Bia Staropramen có  hương vị thơm tuyệt hảo của một loại bia có màu vàng óng ánh như mật ong. Loại bia này có đầy đủ các vị đắng, ngọt dịu, chát nhẹ, hương thơm đặc trưng của hoa houblon, hậu vị béo ngậy của malt.  Staropramen là một loại bia lager ngon, được nấu tại nhà máy bia  Praha bằng phương pháp sản xuất bia truyền thống của người Czech và là loại bia được xếp vị trí hàng đầu tại Praha, thủ đô của CH Czech.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1027, N'Staropramen lon', N'637124618511955396starl.PNG', 4, 41000, 0, N'Bia Staropramen có hương vị thơm tuyệt hảo của một loại bia có màu vàng óng ánh như mật ong. Loại bia này có đầy đủ các vị đắng, ngọt dịu, chát nhẹ, hương thơm đặc trưng của hoa houblon, hậu vị béo ngậy của malt.', NULL, NULL, 1015, 3, 6, N'Bia Staropramen có hương vị thơm tuyệt hảo của một loại bia có màu vàng óng ánh như mật ong. Loại bia này có đầy đủ các vị đắng, ngọt dịu, chát nhẹ, hương thơm đặc trưng của hoa houblon, hậu vị béo ngậy của malt.  Staropramen là một loại bia lager ngon, được nấu tại nhà máy bia  Praha bằng phương pháp sản xuất bia truyền thống của người Czech và là loại bia được xếp vị trí hàng đầu tại Praha, thủ đô của CH Czech.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1028, N'Budweiser Budvar', N'637124618942510168budweiser.PNG', 4, 640000, 0, N'Budweiser Budvar 5 lít vượt xa cả các bia nổi tiếng nhất trong danh mục đầu tư Budvar ABV5 gốc có sẵn trên dự thảo và trong hai kích cỡ chai, 330ml và 500ml cũng như trong lon 500ml.', NULL, NULL, 1016, 3, 5, N'Bia Budweiser là một trong số những tập đoàn bia lớn nhất tại Mỹ luôn chú trọng tới chiến thuật cho ra đời các loại bia đặc biệt để cạnh tranh với các dòng bia leffe ngon, bia chimay xanh cao cấp bậc nhất của Bỉ.  Vượt xa cả các bia nổi tiếng nhất trong danh mục đầu tư Budvar ABV5 gốc có sẵn trên dự thảo và trong hai kích cỡ chai, 330ml và 500ml cũng như trong lon 500ml. Ủ từ gì, nhưng chất liệu tự nhiên địa phương trong một ngày chu kỳ sản xuất bia 100 (90 đã lên men) nó được phổ biến được coi là một trong những loại bia lớn của thế giới bị loại bia.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1029, N'Budweiser Budvar lon', N'637124619577228090budl.PNG', 4, 43000, 0, N'Bia Budweiser lon 500ml là một trong số những tập đoàn bia lớn nhất tại tiệp luôn chú trọng tới chiến thuật cho ra đời các loại bia đặc biệt để cạnh tranh với các dòng bia leffe ngon, bia chimay xanh cao cấp bậc nhất của Bỉ.', NULL, NULL, 1016, 1, 1, N'Bia Budweiser  là một trong số những tập đoàn bia lớn nhất tại Tiệp luôn chú trọng tới chiến thuật cho ra đời các loại bia đặc biệt để cạnh tranh với các dòng bia leffe ngon, bia chimay xanh cao cấp bậc nhất của Bỉ.  Vượt xa cả các bia nổi tiếng nhất trong danh mục đầu tư Budvar ABV5 gốc có sẵn trên dự thảo và trong hai kích cỡ chai, 330ml và 500ml cũng như trong lon 500ml. Ủ từ gì, nhưng chất liệu tự nhiên địa phương trong một ngày chu kỳ sản xuất bia 100 (90 đã lên men) nó được phổ biến được coi là một trong những loại bia lớn của thế giới bị loại bia.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1030, N'Flensburger vàng', N'637124620066117289flen.PNG', 1, 66000, 30, N'Hãng bia FlensburgerFlensburger là một nhà máy bia nằm ở Flensburg ở Bundeslandcủa Schleswig-Holstein , Đức . Được thành lập vào ngày 06 tháng 9 năm1888 của Flensburg bởi năm công dân của Flensburg.', NULL, 1, 1017, 4, 1, N'Đặc điểm của bia Flensburger vàng   Bia nhập khẩu - Flensburger là một loại bia ngon nhẹ với phong cách thanh lịch với màu vàng nhạt và hương vị mềm mại, chất lượng tuyệt đối. Đáp ứng được các tiêu chuẩn nghiêm ngặt của Luật tinh khiết của Đức (German Purity Law)  Flensburger – là tên 1 loại bia truyền thống danh tiếng vùng Flensburger – nước Đức, với hơn 100 năm lịch sử tồn tại. Tên bia cũng là tên thành phố xinh đẹp cổ kính Flensburger nằm gần biên giới Đan Mạch')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1031, N'Erdinger Dunkel ', N'637124620584126677erdinger.PNG', 1, 100000, 30, N'Bia Erdinger DunkelErdinger Weissbier ‘đen’ là một đặc sản lúa mì bia phong phú từ Erdinger Weissbräu.Nó cho hương vị phong phú và hương vị của  Erdinger weissbier đen được tạo từ hạt min của hoa bia và mạch nha đen.', NULL, NULL, 1018, 4, 9, N'tạo từ hạt min của hoa bia và mạch nha đen.  Các đặc sản bia đen được ủ theo một công thức lâu đời. Hương vị cay của nó cũng có kết quả từ tỷ lệ tăng lên (khoảng 13%) của wort ban đầu. Tuy nhiên, ở 5,6%, nó không chứa cồn nhiều hơn Erdinger Weissbier ''với men tốt.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1032, N' Paulaner Pa Salvator ALC', N'637124621236168696paulaner.PNG', 1, 100000, 20, N'Màu của bia Đức Paulaner này là màu của caramel và hạt dẻ nâu, kết hợp với hương vị quyến rũ của sô cô la để cung cấp cho một cường độ hài lòng trong vòm họng.', NULL, NULL, 1, 4, 5, N'Hương vị Màu của bia Đức Paulaner này là màu của caramel và hạt dẻ nâu, kết hợp với hương vị quyến rũ của sô cô la để cung cấp cho một cường độ hài lòng trong vòm họng. Theo đó kết thúc bằng một lưu ý ánh sáng của hoa bia trong nền, thường bắt chước nhưng không bao giờ lặp')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1033, N'Valentins Weibbier', N'637124621882291845va.PNG', 1, 35000, 0, N'Bia có màu vàng óng, mùi thơm đặc trưng và đặc biệt là hương vị đậm đà quyến rũ ngay từ lần đầu thưởng thức.', NULL, NULL, 1020, 3, 5, N'Bia Valentins Weibbier Premium Hefeweissbier Dunkel là loại bia đẳng cấp, sang trọng và được đánh giá cao về cả chất lượng và hình thức thiết kế chai. Sản phẩm đặc biệt nổi tiếng với hương vị thơm ngon, tinh khiết khác hẳn so với các loại bia thông thường.    Màu sắc : Bia có màu vàng óng, mùi thơm đặc trưng và đặc biệt là hương vị đậm đà quyến rũ ngay từ lần đầu thưởng thức. Bia Valentins Weibbier Premium Hefeweissbier Dunkel là một trong những dòng bia có sản lượng tiêu thụ lớn nhất ở nước Đức.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1034, N'Boong Premium Leikeim', N'637124622372853856boong.PNG', 1, 350000, 30, N'Bia Boong Premium Leikeim 5L có vàng sậm xuất xứ từ Đức', NULL, NULL, 1021, 11, 1, N'Bia Boong Premium Leikeim 5L có vị rất tinh khiết, sảng khoái khi uống là thương hiệu bia Weltenburger nổi tiếng của Đức được nhiều nước trên thế giới yêu thích.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1035, N'Jopen Doubting Thomas', N'download.jpg', 5, 100000, 20, N'Bia Jopen Doubting Thomas là một loại bia riêng biệt với mạch nha giàu như hương vị chính.', NULL, NULL, 1022, 3, 5, N'Bia Jopen Doubting Thomas là một loại bia riêng biệt với mạch nha giàu như hương vị chính. Bia này được đặt theo tên của vị tông đồ Thomas, người sẽ không tin rằng Chúa Giêsu đã sống lại từ cõi chết. Rất thích hợp khi nhấp nháp bên cạnh lò sưởi với một hương vị đặc trưng')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1036, N'Jopen Koyt Gruitbier', N'637124654543969286okg.PNG', 5, 99000, 0, N'Bia Jopen Koyt Gruitbier là một sự pha trộn thời trung cổ của các loại thảo mộc, hương vị cay rất phức tạp và trơn tru.', NULL, NULL, 1022, 4, 1, N'Bia Jopen Koyt Gruitbier được ủ với gruit, một sự pha trộn thời trung cổ của các loại thảo mộc, hương vị cay rất phức tạp và trơn tru.  Đây là một bản tái tạo của một bia Haarlem và được ủ theo quy chế của nhà sản xuất bia (công thức theo quy định của Hội đồng)')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1037, N'Royal Dutch Gold', N'637124658219457057royal.PNG', 5, 45000, 0, N'Bia Royal Dutch Gold Super Strong dòng bia cao cấp xuất xứ từ Hà Lan,được rất nhiều khách hàng yêu thích hè 2016.', NULL, NULL, 1023, 3, 13, N'Bia Royal Dutch Gold Super Strong là một loại bia riêng biệt với mạch nha giàu như hương vị chính. Xuất xứ : Hà Lan Dung tích: 500ml/lon Độ cồn : 12% Quy cách : 24 lon/thùng Hạn sử dụng: 15 tháng từ ngày sản xuất')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1038, N'Royal Dutch Post Horn', N'637124658983032686royal2.PNG', 5, 41000, 0, N'Bia Royal Dutch Post Horn Extra Strong cao cấp nhập khẩu từ Hà Lan,với hương vị mạnh mẽ khó quên.', NULL, NULL, 1023, 3, 1, N'Xuất xứ: Hà Lan Dung tích : 500ml/lon Độ cồn : 8,5% Quy cách : 24 lon/thùng Hạn sử dụng: 15 tháng từ ngày sản xuất')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1039, N'Trio Extra Stout Bottle', N'download.jpg', 5, 28000, 0, N'Bia Trio Extra Stout Bottle 330ml có hương vị hấp dẫn của sô cô la pha chút ngọt ngào, cùng hương mạch nha.', NULL, NULL, 1024, 2, 1, N'Bia Trio Extra Stout Bottle 330ml có hương vị hấp dẫn của sô cô la pha chút ngọt ngào, cùng hương mạch nha . Đây là một dòng bia hà lan rất đặc biệt từ hương vị cho đến cách thưởng thức, không quá thú vị, nhưng chỉ đơn giản là tốt.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1040, N'Trio Extra Stout', N'download.jpg', 5, 25000, 0, N'Đây là một dòng bia hà lan rất đặc biệt từ hương vị cho đến cách thưởng thức, không quá thú vị, nhưng chỉ đơn giản là tốt.', NULL, NULL, 1024, 2, 1, N'Bia Trio Extra Stout Bottle 330ml có hương vị hấp dẫn của sô cô la pha chút ngọt ngào, cùng hương mạch nha . Đây là một dòng bia hà lan rất đặc biệt từ hương vị cho đến cách thưởng thức, không quá thú vị, nhưng chỉ đơn giản là tốt.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1041, N'Chateau Neubourg', N'637124663914817045chate.PNG', 5, 35000, 0, N'Bia Château Neubourg có vị đắng đặc trưng cao quý tuyệt vời, hoàn hảo cho những người sành', NULL, NULL, 1025, 2, 5, N'Bia Château Neubourg có vị đắng đặc trưng cao quý tuyệt vời, hoàn hảo cho những người sành. Và bên cạnh đó nó được đóng chai trong một chai thanh lịch xinh đẹp, mà sẽ phù hợp với một bữa ăn tối ưa thích với các thành phần: nước, mạch nha lúa mạch, hoa bia.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1042, N'Westmalle Trappist Tripel', N'637124664584131231west.PNG', 5, 41000, 0, N'Westmalle Tripel là một loại bia thuộc dòng bia Trappist, có màu vàng lên men thứ cấp trong chai, nồng độ 9,5% Vol. Loại bia này lần đầu tiên được nấu tại Bỉ, trong tu viện Westmalle 1934. Bia có màu vàng cam đầy sức sống, kết hợp hài hòa giữa nhiều loại hương vị khác nhau. Westmalle tripel có hương thơm trái cây và một mùi hương mang sắc thái tốt đẹp.', NULL, NULL, 1026, 2, 1, N'Westmalle Tripel là một loại bia thuộc dòng bia Trappist, có màu vàng lên men thứ cấp trong chai, nồng độ 9,5% Vol. Loại bia này lần đầu tiên được nấu tại Bỉ, trong tu viện Westmalle 1934. Bia có màu vàng cam đầy sức sống, kết hợp hài hòa giữa nhiều loại hương vị khác nhau. Westmalle tripel có hương thơm trái cây và một mùi hương mang sắc thái tốt đẹp.  Người uống sẽ cảm nhận được vị êm dịu như kem tan trong miệng, với một chút đắng bởi hương thươm trái cây. Một loại bia đặc biệt, tuyệt vời của sự khéo léo và sang trọng. Westmalle Tripel thực sự được gọi là "Mẹ của tất cả các loại Triupels". Từng đạt giải vàng thế giới năm 2004 và năm 2006.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1043, N'Weidmann lon', N'637124665352888866weid.PNG', 5, 32000, 0, N'Bia Weidmann lon 500ml có màu vàng nhạt với đầu trắng mỏng, cacbonat rất nh', NULL, NULL, 1026, 3, 1, N'Bia Weidmann lon 500ml có màu vàng nhạt với đầu trắng mỏng, cacbonat rất nhẹ. Với màu sáng cùng hương vị nước khoáng đặc trưng.Hà Lan được biết là quốc gia có diện tích nhỏ phía tây bắc Châu Âu. Hà Lan có rất nhiều điều nổi tiếng một đất nước với nền du lịch hấp dẫn hay các họa sỹ nổi tiếng hay ngành trồng hoa tuylip. Đất nước này bao gồm vùng đất nổi tiếng được hình thành thông qua cải tạo đất không chỉ thế bia hà lan còn nổi tiếng khắp thế giới. Công nghiệp sản xuất bia của Hà Lan có từ lâu đời do các nhà sản xuất bia sáng tạo ra những phương pháp mới để tạo ra những hương vị bia hà lan ngon tuyệt vời.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1044, N'(Combo 2 thùng)Budweiser lon', N'637124665963241668bud.PNG', 2, 840000, 30, N'Hương vị của Budweiser là sự cân bằng tuyệt đối giữa vị cay không quá nặng với vị ngọt ngào tinh tế, giòn tan.', NULL, 1, 1027, 2, 5, N'Loại: Lager  Thương hiệu: Budweiser mỹ  Xuất xứ:  Việt Nam  Nồng độ:  5.0%  Dung tích:  330ml  Quy cách: Thùng 24    Vẫn hương vị Budweiser đặc trưng nhưng với bao bì mới đầy sang trọng, phiên bản Tết thích hợp cho những cuộc vui tại nhà của bạn hoặc dùng làm quà tặng.  Budweiser là thương hiệu bia đắt giá số 1 thế giới, được sản xuất bằng loại mạch nha cùng với hoa bia thượng hạng của Hoa Kỳ và Châu Âu. Hương vị của Budweiser là sự cân bằng tuyệt đối giữa vị cay không quá nặng với vị ngọt ngào tinh tế, giòn tan. Công nghệ ủ bia bằng gỗ sồi của Budweiser đã tạo ra một hương vị bia tuyệt hảo không thể tìm thấy ở bất kì một loại bia nào khác.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1045, N' Budweiser 5% Mỹ', N'637124666689590452budchai.PNG', 2, 410000, 20, N'Budweiser là thương hiệu bia đắt giá số 1 thế giới, được sản xuất bằng loại mạch nha cùng với hoa bia thượng hạng của Hoa Kỳ và Châu Âu', NULL, NULL, 1027, 2, 1, N'oại: Lager  Thương hiệu: Budweiser mỹ  Xuất xứ:  Việt Nam  Nồng độ:  5.0%  Dung tích:  330ml  Quy cách: Thùng 24 chai    Vẫn hương vị Budweiser đặc trưng nhưng với bao bì mới đầy sang trọng, thích hợp cho những cuộc vui tại nhà của bạn hoặc dùng làm quà tặng.  Budweiser là thương hiệu bia đắt giá số 1 thế giới, được sản xuất bằng loại mạch nha cùng với hoa bia thượng hạng của Hoa Kỳ và Châu Âu. Hương vị của Budweiser là sự cân bằng tuyệt đối giữa vị cay không quá nặng với vị ngọt ngào tinh tế, giòn tan. Công nghệ ủ bia bằng gỗ sồi của Budweiser đã tạo ra một hương vị bia tuyệt hảo không thể tìm thấy ở bất kì một loại bia nào khác.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1046, N'Sapporo Premium', N'637124667189064153sap.PNG', 6, 20000, 0, N'Sapporo Premium330ml mang đến hương vị tươi mát, sảng khoái đượctinh chế theo tiêu chuẩn công nghệ tiên tiến nhất Nhật Bản,trong mộtthiết kế hài hòa tuyệt mỹ.', NULL, NULL, 1028, 2, 1, N'Đặc điểm của bia Sapporo Premium Nguyên liệu: Lúa mạch, hoa bia, và nước. Nồng độ cồn: 5%   Bia lon Sapporo Premium 330ml mang đến hương vị tươi mát, sảng khoái được tinh chế theo tiêu chuẩn công nghệ tiên tiến nhất Nhật Bản,trong một thiết kế hài hòa tuyệt mỹ. Trên nền màu vàng sang trọng, biểu tượng ngôi sao mang “Tinh thần tiên phong” của Sapporo được in nổi bật, thể hiện một đẳng cấp.     Thưởng thức Sapporo không chỉ là trải nghiệm một loại bia êm đằm độc đáo cùng với bọt bia siêu mịn lưu giữ hương vị đặc trưng mà còn tận hưởng tinh hoa của một thương hiệu bia hàng đầu Nhật Bản.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1047, N'Sapporo Premium Lon', N'637124667787855881saplon.PNG', 6, 65000, 10, N'Là một trong những thương hiệu bia hàng đầu thế giới, Sapporo không chỉnổi tiếng bởi chất lượng thượng hạng mà còn đặc biệt với thiết kế tinhtế trong từng đường nét', NULL, NULL, 1028, 3, 1, N'Đặc điểm của bia Sapporo Premium Nguyên liệu: Lúa mạch, hoa bia, và nước. Nồng độ cồn: 5%   Bia lon Sapporo Premium 330ml mang đến hương vị tươi mát, sảng khoái được tinh chế theo tiêu chuẩn công nghệ tiên tiến nhất Nhật Bản,trong một thiết kế hài hòa tuyệt mỹ. Trên nền màu vàng sang trọng, biểu tượng ngôi sao mang “Tinh thần tiên phong” của Sapporo được in nổi bật, thể hiện một đẳng cấp.     Thưởng thức Sapporo không chỉ là trải nghiệm một loại bia êm đằm độc đáo cùng với bọt bia siêu mịn lưu giữ hương vị đặc trưng mà còn tận hưởng tinh hoa của một thương hiệu bia hàng đầu Nhật Bản.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1048, N' Asahi', N'637124668228267934asa.PNG', 5, 24000, 0, N'Sản phẩm được phân phối và bán lẻ tại công ty cổ phần sức khỏe Việt Vinacom', NULL, NULL, 1029, 2, 5, N'Đặc điểm của bia Asahi  Bia Ashahi có vị êm nhẹ với chút men đắng đặc trưng tạo cảm nhận hài hòa và tươi mát - Bia Asahi đã tạo nên một tiêu chuẩn mới trong lĩnh vực bia rượu Nhật bản . Thưởng thức bia Asahi không chỉ là trải nghiệm một loại bia êm đềm và độc đáo cùng với bọt bia siêu mịn lưu giữ hương vị đặc trưng mà còn tận hưởng tinh hoa của một thương hiệu bia hàng đầu của Nhật Bản  Quá trình sản xuất bia Asahi Bia Asahi được lên men từ giống men tốt nhất là loại Karakuchi 318 giúp tạo ra một loại bia có quá trình lên men kéo dài góp phần tạo ra hương vị cô đọng đặc trưng của bia . Điều này giải thíc cho tên gọi Super Dry của bia ( Nghĩa của từ Karakuchi trong tiếng Nhật ) . Quá trình lên men được thực hiện bởi các công nhân lành nghề , mỗi công đoạn đều được theo dõi kiểm tra bằng máy móc thiết bị tiên tiến và hiện đại nhất  Bia Asahi là sản phẩm của dây chuyền công nghệ sản xuất hiện đại với những máy móc tiên tiến nhất nhằm loại bỏ hoàn toàn lượng đường có trong lúa mạch tạo ra loại bia có vị đắng đăc trưng , hương vị đậm đà tinh khiết riêng , rất thơm ngon cho bia Ashahi')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1049, N'Kirin', N'637124668753756228kirin.PNG', 6, 65000, 20, N'Dòng bia Kirin nổi tiếng nhật bản được xuất đi khắp thế giới. Với hương vị đặc trưng của xứ sở hoa anh đào mang lại cảm giác riêng.', NULL, NULL, 1030, 2, 9, N'Đặc điểm của bia Kirin Dòng bia Kirin nổi tiếng nhật bản được xuất đi khắp thế giới. Với hương vị đặc trưng của xứ sở hoa anh đào mang lại cảm giác riêng. Bia kirin được người Việt Nam yêu thích không chỉ bởi chất lượng mà ở hương thơm khác biệt.  Thị trường bia Kirin  Dòng bia Kirin được bán tại hơn 36 quốc gia và đang tiếp tục phát triển theo mong muốn của người tiêu dùng, để ngày càng nhiều người trên thế giới có cơ hội được thưởng thức loại bia này . Trong một chai bia , bạn có thể thưởng thức được nhiều hương vị: hương thơm từ hoa houblon, hương malt và hậu vị đắng.  Tác dụng của men bia Men bia  là một nguồn giàu các chất dinh dưỡng, hơn cả mong đợi,  các chất dinh dưỡng, bao gồm magie, selen, kali, phốt pho, biotin, và các vitamin B. Uống một lượng bia vừa phải sẽ giảm nguy cơ bệnh tim, đột quỵ và suy giảm nhận thức')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1050, N'Corona Extra', N'download.jpg', 10, 65000, 0, N'Bia Corona là một trong những loại bia được uống nhiều nhất thế giới. Xuất xứ từ Mexico, càng ngày bia này càng khẳng định được vị trí của mình trong lòng các khách hàng đặc biệt là những khách hàng khó tính nhất.', NULL, NULL, 1031, 1, 1, N'Bia Corona là một trong những loại bia được uống nhiều nhất thế giới. Xuất xứ từ Mexico, càng ngày bia này càng khẳng định được vị trí của mình trong lòng các khách hàng đặc biệt là những khách hàng khó tính nhất. Hiện nay bia corona extra đang có mặt ở hầu hết các quốc gia trên thế giới , đặc biệt thị trường mỹ là một thị trường tiềm năng nhất .')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1051, N'Ziguli Barnoe', N'637124671635265656zig.PNG', 8, 100000, 0, N'Quá trình lên men 21 ngày dưới nhiệt độ lạnh, tạo đủ hương vị hài hòa, đặc trưng của hoa bia, vị bia đắng nhẹ nhàng của mạch nha', NULL, NULL, 1032, 3, 1, N'Bia Ziguli Barnoe của nhà hàng huyền thoại "Zhiguli", thể hiện những truyền thống tốt nhất của thế kỷ 20. Được chế biến theo công thức độc đáo của nhà hàng, với các loại malt chọn lọc và mùi thơm tinh tế của hoa bia Žatec và nước mềm từ Mytischi đều góp phần tạo nên hương vị độc đáo của Zhiguli.  Quá trình lên men 21 ngày dưới nhiệt độ lạnh, tạo đủ hương vị hài hòa, đặc trưng của hoa bia, vị bia đắng nhẹ nhàng của mạch nha lên mầm bởi các hạt ngũ cốc., tạo cho bia Nga này hương vị đặc biệt đáng nhớ của nó, giàu và đầy')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1052, N'Ziguli Barnoe lon', N'637124672353437403ziglon.PNG', 8, 210000, 20, N'Bia Ziguli Barnoe của nhà hàng huyền thoại "Zhiguli", thể hiện những truyền thống tốt nhất của thế kỷ 20.', NULL, NULL, 1032, 5, 1, N'Bia Ziguli Barnoe của nhà hàng huyền thoại "Zhiguli", thể hiện những truyền thống tốt nhất của thế kỷ 20. Được chế biến theo công thức độc đáo của nhà hàng, với các loại malt chọn lọc và mùi thơm tinh tế của hoa bia Žatec và nước mềm từ Mytischi đều góp phần tạo nên hương vị độc đáo của Zhiguli.  Quá trình lên men 21 ngày dưới nhiệt độ lạnh, tạo đủ hương vị hài hòa, đặc trưng của hoa bia, vị bia đắng nhẹ nhàng của mạch nha lên mầm bởi các hạt ngũ cốc., tạo cho bia Nga này hương vị đặc biệt đáng nhớ của nó, giàu và đầy.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1053, N'Hamovniki Export', N'637124672829682874hamon.PNG', 8, 100000, 0, N'Dòng bia Nga Hamovniki huyền thoại của ngành sản xuất bia Nga, là nhãn hiệu bia được người Mátxcơva yêu thích trong hơn 150 năm qua', NULL, NULL, 1033, 2, 1, N'Dòng bia Nga Hamovniki huyền thoại của ngành sản xuất bia Nga, là nhãn hiệu bia được người Mátxcơva yêu thích trong hơn 150 năm qua. Một thương hiệu với chiều dài lịch sử. Năm 1909 Nhà máy bia Mátxcơva nhận được vinh dự là hãng bia chính thức cung cấp bia cho cung điện hoàng gia Nga, trên nhãn được quyền in huy hiệu Hoàng Gia.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1054, N'GẤU SÁNG-BEAR BEER', N'637124673339452138bear.PNG', 8, 35000, 0, N'Bia Gấu Xanh ( Bia Gấu Sáng ) Nồng độ 5%  -  Bia gấu xanh ( Bia gấu sáng) nồng độ cồn 5% triết xuất từ 100% lúa mạch và được chưng cất quanhiều giai đoạn và sử lý tinh lọc qua công nghệ máy móc hiện đại ', NULL, NULL, 1034, 2, 1, N'Đặc điểm của bia Gấu sáng Bia Gấu Sáng Nồng độ 5%  triết xuất từ 100% lúa mạch và được chưng cất qua nhiều giai đoạn và sử lý tinh lọc qua công nghệ máy móc hiện đại . Bia gấu sáng  nồng độ cồn 5% triết xuất từ 100% lúa mạch và được chưng cất qua nhiều giai đoạn và sử lý tinh lọc qua công nghệ máy móc hiện đại . Giữ lại đúng hương vị bia tươi đặc trưng của Nga .  Là dòng bia nhẹ hơn bia gấu mạnh bia sản xuất khi được chọn lựa kỹ càng từ mạch nha lúa mạch,hoa bia ,men bia và nước.Đêm đến 1 hương vị nhẹ nhàng,êm dịu,sảng khoái nguyên liệu chuẩn bị phải thực sự kỹ lưỡng kết hợp với công nghệ hiện đại xử lý lọc và khử trùng .Đây là loại bia có sản lượng tiêu thụ lớn ở nước Nga dòng bia chất lượng cao có nhiều hương vị độc đáo thực sự dễ dàng cảm nhận')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1055, N'GẤU MẠNH- Harboe Bear Beer', N'637124674957491090bear2.PNG', 8, 41000, 0, N'Bia Gấu mạnh là một loại bia đặc biệt có màu mạch nha đặc trưng cùng độđậm đặc lớn sẽ là lựa chọn tuyệt vời dành cho những người yêu thích dòngbia thật mạnh mẽ.', NULL, NULL, 1034, 3, 1, N'Bia gấu  mạnh được lên men tự nhiên với thời gian lâu hơn bình thường. Từ thời xa xưa, để làm ra loại bia mạnh trong những dịp đặc biệt thì phải tốn rất nhiều thời gian, có thể lên đến 6 tháng. Bia gấu mạnh sản xuất khi được lựa chọn kỹ càng từ mạch nha, hoa bia và nước tinh khiết. Để làm ra 1 loại bia ngon thì quá trình chuẩn bị phải thật sự kĩ lưỡng. Ngày nay công nghệ hiện đại có thể sản xuất ra bia trong vòng 1 vài ngày nhưng để chuẩn bị ra loại bia này thì thời gian không thể thay thế được bất cứ điều gì.  Bia Gấu mạnh là một loại bia đặc biệt có màu mạch nha đặc trưng cùng độ đậm đặc lớn sẽ là lựa chọn tuyệt vời dành cho những người yêu thích dòng bia thật mạnh mẽ. Chế độ nhiệt độ tối ưu được kiểm soát chặt chẽ vì sự ổn định của độ lạnh sẽ làm tăng thêm hương vị và chất lượng cho thức uống tuyệt vời này')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1056, N'Baltika 3', N'637124675391660515bal.PNG', 8, 35000, 0, N'Baltika bia cổ điển lần đầu tiên được ra mắt vào năm 1992 và đã được truyền thống bia phổ biến nhất trong số người tiêu dùng Nga kể từ khi các 90 giữa do chất lượng không thay đổi cao.', NULL, NULL, 1035, 3, 1, N'Baltika bia cổ điển lần đầu tiên được ra mắt vào năm 1992 và đã được truyền thống bia phổ biến nhất trong số người tiêu dùng Nga kể từ khi các 90 giữa do chất lượng không thay đổi cao. Năm 2004 chứng kiến ​​sự "tái sinh" của Baltika chai thủy tinh đã nhận được một hình dạng mới và nhãn, được đi kèm với các đồ hộp đầu tiên của thương hiệu. Trong tháng năm 2006 của Baltika 3 được sản xuất trong một gói phần mềm sáng tạo: 1 cao cấp lít PET-gói thực tế trông giống như chai thủy tinh nửa lít.  Trong năm 2007, Baltika  chai nhận được một chữ dập nổi. Đồng thời thương hiệu đã được sản xuất trong một nhôm một lít có thể là mới cho thị trường. Vào tháng Tư năm 2008, chai PET 1,5 lít với một thiết kế "bóng đá" được sản xuất cho  Baltika 3, đặc biệt là cho giải vô địch bóng đá Nga. Vật liệu PET-thủy tinh có chất lượng cao bảo vệ và giữ phổ biến nhất Nga bia tươi trong một thời gian dài hơn.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1057, N'Baltika 7', N'637124676061727553bal2.PNG', 8, 80000, 10, N'Baltika thương hiệu xuất khẩu 7 đã được hẹn giờ để Games thiện chí ở St Petersburg vào năm 1994. Kể từ đó № Baltika 7 đã ổn định được các lãnh đạo thị trường ở trên cùng của phân khúc cao cấp', NULL, NULL, 1, 3, 1, N'Sự ra đời của № Baltika thương hiệu xuất khẩu 7 đã được hẹn giờ để Games thiện chí ở St Petersburg vào năm 1994. Kể từ đó № Baltika 7 đã ổn định được các lãnh đạo thị trường ở trên cùng của phân khúc cao cấp. Bia Baltika № 7 được làm từ mạch nha và hoa bia chọn lọc hiếm và được phân biệt cho sự mềm mại đặc biệt và sự viên mãn. "Seven" người tiêu dùng được mở để giao tiếp, họ đánh giá cao tất cả mọi thứ mà là nhằm mục đích phát triển và biết rằng họ có khả năng đạt được thành công trong cuộc sống.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1058, N'Bochka Vàng "Mạnh"', N'637124676564372625boch.PNG', 8, 50000, 0, N'Bia Bochka Vàng màu hổ phách ấm áp pha thêm màu đỏMột nồng đồ mạnh được lên men tựnhiên với thời gian lâu hơn bình thường', NULL, NULL, 1036, 3, 3, N'Đặc điểm của bia Bochka Vàng Một nồng đồ mạnh được lên men tự nhiên với thời gian lâu hơn bình thường. Từ thời xa xưa, để làm ra loại bia mạnh trong những dịp đặc biệt thì phải tốn rất nhiều thời gian, có thể lên đến 6 tháng. Bia Bochka Vàng sản xuất khi được lựa chọn kỹ càng từ mạch nha, hoa bia và nước tinh khiết. Để làm ra 1 loại bia mạnh ngon thì quá trình chuẩn bị phải thực sự kỹ lưỡng. Ngày nay công nghệ hiện đại có thể sản xuất ra bia trong vòng 1 vài ngày nhưng để chuẩn bị ra loại bia này thì thời gian sẽ không thay thế được bất cứ điều gì.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1059, N'Bochka Vàng "Cổ điển"', N'637124677514315286boch2.PNG', 8, 41000, 0, N'Bia Bochka Vàng "Cổ điển" với Màu sắc vàng với 1 màu hổ phách ấm ápGolden Barrel "lạnh" là 1 dòng bia tuyệt vời được tạo ra cho những người thích uống bia từ chai và có sự hiểu biết cao về hương vị thực sự từ bia tươi. ', NULL, NULL, 1036, 3, 5, N'Đặc điểm của bia  Bochka  Bia Bochka với màu vàng  hổ phách ấm áp Golden Barrel "lạnh" là 1 dòng bia tuyệt vời được tạo ra cho những người thích uống bia từ chai và có sự hiểu biết cao về hương vị thực sự từ bia tươi. Tính chất đầy đủ của hương vị tuyệt vời cộng với 1 màu vàng hổ phách ấm áp, được thông qua 1 sự kết hợp hài hòa từ bột mạch nha tạo nên 1 phong cách của bia BOCHK vàng "lạnh" thắm đượm đồng thời cùng với 1 hương vị nhẹ nhàng.Золотая Бочка Классическое - BOCHKA VÀNG CỔ ĐIỂN • Nồng độ - 5%  • Mật độ (Độ đậm đặc) - 12%  • Màu sắc - Màu xanh lá cây và 1 màu hổ phách trong suốt  Bia BOCHKA vàng cổ điển được nấu chín trên một công thức truyền thống từ châu âu và được lựa chọn nguyên liệu 1 cách cẩn thận. Giống hoa bia tốt nhất cho ra 1 loại bia có hương vị cân bằng vừa phải và dễ chịu. Đây là 1 thực tế tạo nên 1 hương vị thực sự của những người sành loại bia cổ điển.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1060, N'LOROYSE Pháp 8 độ', N'637124678092817171loroy.PNG', 7, 90000, 0, N'Loroyse là loại bia được ủ từ ba loại mạch nha và các loại hoa bia chọn lọc đặc biệt, kết hợp cùng nguồn nước tuyệt vời mang lại một vị đắng tinh tế và hương vị vô cùng phong phú cho khứu giác.', NULL, NULL, 1037, 2, 13, N'Thông tin sản phẩm  Tên Sp:Bia Loroyse  Xuất xứ:Pháp  Thể tích:330ml  Nồng độ:8%  -------------------------------------- Được ủ theo phương pháp truyền thống, bia Loroyse được tạo ra từ ba quá trình lên men mang đến một hương vị mượt mà và hài hòa. Độ cồn cao kết hợp với hương vị độc đáo đến từ bí quyết của các nhà quý tộc xứ Lorraine khiến cho trở thành một trải nghiệm tuyệt vời cho những người sành bia khắp thế giới.Loroyse Miêu tả : bia lên men nổi mạnh mẽ từ Lorraine, màu vàng tươi sáng,, 8% nồng độ cồn. Mùi vị:  Vị đắng vừa, nồng độ cồn cao, hương mạch nha phức hợp caramel, bơ và hương trái cây. Bảo quản : Bảo quản ở nhiệt độ 13-15 độ C, xếp đúng vị trí và tránh ánh sáng trực tiếp. Thưởng thức : Ngon hơn khi uống ướp lạnh từ 8-12 độ C')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaTH], [MaDungTich], [MaNongDo], [MoreInfo]) VALUES (1061, N'Saint Mihal', N'637124678515128699saint.PNG', 7, 20000, 0, N'Bia Saint Mihal chai 250ml có màu hổ phách nhạt với lớp mỏng trên đầu.', NULL, NULL, 1038, 1, 1, N' –  Nồng độ: 4% – Thành phần: Nước, lúa mạch, bắp, … – Thể tích thực: 250ml – Xuất xứ: Pháp Bia Saint Mihal chai 250ml có màu hổ phách nhạt với lớp mỏng trên đầu.')
SET IDENTITY_INSERT [dbo].[ThucDon] OFF
SET IDENTITY_INSERT [dbo].[ThuongHieu] ON 

INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1, N'Chimay', N'637125093101809714staropramen.PNG')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (2, N'Duvel', N'637125092798035559primator.PNG')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1002, N'Chimay', N'637125092893855827saint.PNG')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1005, N'Chimay 2', N'637125093153807153Jopen.PNG')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1007, N'Chimay', N'637125093289450341Chimay.PNG')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1008, N'Duvel', N'637125093219491009Duvel.PNG')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1009, N'Leffe', N'637125093039134201boch2.PNG')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1010, N'ST.Sebastiaan', N'637125093398179161starl.PNG')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1011, N'St.Paul', N'637125093492642732sdsd.PNG')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1012, N'Primator', N'637125093544781104duvel9d.PNG')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1013, N'Zubr', N'637125093956911440loroy.PNG')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1014, N'Pilsner', N'637125094012590065cm7d.PNG')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1015, N'Staropramen', N'637125094067663037primd.PNG')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1016, N'Budweiser Budvar', N'637125094117344367boong.PNG')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1017, N'Flensburger Beer', N'637125094168558483boch.PNG')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1018, N'Erdinger', N'637125094232396441saplon.PNG')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1019, N'Paulaner', N'637125093824899333lfnau.PNG')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1020, N'Valentines', N'637125094362532321weid.PNG')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1021, N'Weltenburger', N'637125094422662186primd.PNG')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1022, N'Jopen', N'637125094296011067boch2.PNG')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1023, N'Royal', N'637125094605259375kirin.PNG')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1024, N'Trio Extra Stout', N'637124589943103354Trio.PNG')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1025, N'Chateau Neubourg', N'637124590253511633chate.PNG')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1026, N'Weidmann', N'637124590675866466west.PNG')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1027, N'Budweiser', N'637125094474962955sap.PNG')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1028, N'Sapporo', N'637125093628448766Chimay.PNG')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1029, N'Asahi', N'637125094531873329asa.PNG')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1030, N'Kirin', N'637125094717255747bear2.PNG')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1031, N'Corona', N'637125093882313180paulaner.PNG')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1032, N'Ziguli Barnoe', N'637125092731605752Leffe.PNG')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1033, N'Hamovniki', N'637125092617690169boong.PNG')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1034, N'Gấu', N'637125092359690525bia-gau-premium-lager-500ml.jpg')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1035, N'Baltika', N'637125092050072883bia-baltika-so-9-8-nga-lon-500ml.jpeg')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1036, N'Bochka', N'637125092984668605budl.PNG')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1037, N'Loroyse Pháp', N'637125093693740949zubrw.PNG')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [HinhAnh]) VALUES (1038, N'Saint Mihal', N'637125093763257082paul.PNG')
SET IDENTITY_INSERT [dbo].[ThuongHieu] OFF
SET IDENTITY_INSERT [dbo].[TinhThanh] ON 

INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (2, N'hà nội')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (3, N'thái bình')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (4, N'vũng tàu')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (5, N'cao bằng')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (6, N'sa đéc')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (7, N'hải phòng')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (8, N'thanh hóa')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (9, N'đồng nai')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (10, N'dak lak')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (11, N'khánh hòa')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (12, N'cà mau')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (13, N'đà nẵng')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (14, N'quảng ninh')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (15, N'huế')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (16, N'bình thuận')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (17, N'hưng yên')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (18, N'kiên giang')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (19, N'mỹ tho')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (20, N'tiền giang')
SET IDENTITY_INSERT [dbo].[TinhThanh] OFF
ALTER TABLE [dbo].[ChiTietGioHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietGioHang_GioHang_MaGioHang] FOREIGN KEY([MaGioHang])
REFERENCES [dbo].[GioHang] ([MaGioHang])
GO
ALTER TABLE [dbo].[ChiTietGioHang] CHECK CONSTRAINT [FK_ChiTietGioHang_GioHang_MaGioHang]
GO
ALTER TABLE [dbo].[ChiTietGioHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietGioHang_ThucDon_MaThucDon] FOREIGN KEY([MaThucDon])
REFERENCES [dbo].[ThucDon] ([MaThucDon])
GO
ALTER TABLE [dbo].[ChiTietGioHang] CHECK CONSTRAINT [FK_ChiTietGioHang_ThucDon_MaThucDon]
GO
ALTER TABLE [dbo].[GioHang]  WITH CHECK ADD  CONSTRAINT [FK_GioHang_KhachHang_MaKhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[GioHang] CHECK CONSTRAINT [FK_GioHang_KhachHang_MaKhachHang]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_TaiKhoan_MaTaiKhoan] FOREIGN KEY([MaTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([MaTaiKhoan])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_TaiKhoan_MaTaiKhoan]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_PhanQuyen_MaPhanQuyen] FOREIGN KEY([MaPhanQuyen])
REFERENCES [dbo].[PhanQuyen] ([MaPhanQuyen])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_PhanQuyen_MaPhanQuyen]
GO
ALTER TABLE [dbo].[ThucDon]  WITH CHECK ADD  CONSTRAINT [FK_ThucDon_DungTich_MaDungTich] FOREIGN KEY([MaDungTich])
REFERENCES [dbo].[DungTich] ([MaDungTich])
GO
ALTER TABLE [dbo].[ThucDon] CHECK CONSTRAINT [FK_ThucDon_DungTich_MaDungTich]
GO
ALTER TABLE [dbo].[ThucDon]  WITH CHECK ADD  CONSTRAINT [FK_ThucDon_LoaiThucDon_MaLoai] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiThucDon] ([MaLoai])
GO
ALTER TABLE [dbo].[ThucDon] CHECK CONSTRAINT [FK_ThucDon_LoaiThucDon_MaLoai]
GO
ALTER TABLE [dbo].[ThucDon]  WITH CHECK ADD  CONSTRAINT [FK_ThucDon_NongDo_MaNongDo] FOREIGN KEY([MaNongDo])
REFERENCES [dbo].[NongDo] ([MaNongDo])
GO
ALTER TABLE [dbo].[ThucDon] CHECK CONSTRAINT [FK_ThucDon_NongDo_MaNongDo]
GO
ALTER TABLE [dbo].[ThucDon]  WITH CHECK ADD  CONSTRAINT [FK_ThucDon_ThuongHieu_MaTH] FOREIGN KEY([MaTH])
REFERENCES [dbo].[ThuongHieu] ([MaTH])
GO
ALTER TABLE [dbo].[ThucDon] CHECK CONSTRAINT [FK_ThucDon_ThuongHieu_MaTH]
GO
