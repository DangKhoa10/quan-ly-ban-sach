
USE [QLMuaBanSach]
GO
/****** Object:  Table [dbo].[CTHD]    Script Date: 11/11/2021 1:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHD](
	[SoLuong] [int] NULL,
	[GiaBan] [money] NULL,
	[MaSach] [char](7) NOT NULL,
	[MaHD] [char](7) NOT NULL,
 CONSTRAINT [PK_CTHD] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC,
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTPhieuDat]    Script Date: 11/11/2021 1:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPhieuDat](
	[SoLuong] [int] NULL,
	[GiaBan] [money] NULL,
	[MaPhieuDat] [char](7) NOT NULL,
	[MaSach] [char](7) NOT NULL,
 CONSTRAINT [PK_CTPhieuDat] PRIMARY KEY CLUSTERED 
(
	[MaPhieuDat] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTPhieuNhap]    Script Date: 11/11/2021 1:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPhieuNhap](
	[SoLuong] [int] NULL,
	[GiaNhap] [money] NULL,
	[MaSach] [char](7) NOT NULL,
	[MaPhieuNhap] [char](7) NOT NULL,
 CONSTRAINT [PK_CTPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC,
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 11/11/2021 1:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [char](7) NOT NULL,
	[NgayLapHD] [date] NOT NULL,
	[MaNV] [char](7) NOT NULL,
	[MaKH] [char](7) NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/11/2021 1:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [char](7) NOT NULL,
	[TenKH] [ntext] NOT NULL,
	[SDT] [char](10) NOT NULL,
	[DiaChi] [ntext] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSach]    Script Date: 11/11/2021 1:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSach](
	[MaLoai] [char](7) NOT NULL,
	[TenLoai] [ntext] NOT NULL,
 CONSTRAINT [PK_LoaiSach] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 11/11/2021 1:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [char](7) NOT NULL,
	[TenNCC] [ntext] NOT NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/11/2021 1:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [char](7) NOT NULL,
	[TenNV] [ntext] NOT NULL,
	[SDT] [char](10) NOT NULL,
	[DiaChi] [ntext] NULL,
	[ChucVu] [smallint] NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaXuatBan]    Script Date: 11/11/2021 1:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaXuatBan](
	[MaNXB] [char](7) NOT NULL,
	[TenNXB] [ntext] NOT NULL,
 CONSTRAINT [PK_NhaXuatBan] PRIMARY KEY CLUSTERED 
(
	[MaNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuDatSach]    Script Date: 11/11/2021 1:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuDatSach](
	[MaPhieuDat] [char](7) NOT NULL,
	[NgayDat] [date] NOT NULL,
	[TinhTrang] [smallint] NULL,
	[MaKH] [char](7) NOT NULL,
 CONSTRAINT [PK_PhieuDatSach] PRIMARY KEY CLUSTERED 
(
	[MaPhieuDat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhapSach]    Script Date: 11/11/2021 1:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhapSach](
	[MaPhieuNhap] [char](7) NOT NULL,
	[NgayNhap] [date] NOT NULL,
	[MaNV] [char](7) NOT NULL,
	[MaNCC] [char](7) NOT NULL,
 CONSTRAINT [PK_PhieuNhapSach] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 11/11/2021 1:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[MaSach] [char](7) NOT NULL,
	[TenSach] [ntext] NOT NULL,
	[DonGiaNhap] [money] NULL,
	[DonGiaBan] [money] NULL,
	[SoLuongTon] [int] NULL,
	[SoTrang] [int] NULL,
	[MaTG] [char](7) NOT NULL,
	[MaLoai] [char](7) NOT NULL,
	[MaNXB] [char](7) NOT NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 11/11/2021 1:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TacGia](
	[MaTG] [char](7) NOT NULL,
	[TenTG] [ntext] NOT NULL,
 CONSTRAINT [PK_TacGia] PRIMARY KEY CLUSTERED 
(
	[MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 11/11/2021 1:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[Username] [nchar](20) NOT NULL,
	[Password] [text] NULL,
	[LoaiTaiKhoan] [smallint] NULL,
	[MaKH] [char](7) NULL,
	[MaNV] [char](7) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (2, 18000.0000, N'SA00001', N'HD00001')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (5, 18000.0000, N'SA00001', N'HD00022')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (2, 18000.0000, N'SA00001', N'HD00024')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 18000.0000, N'SA00001', N'HD00029')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 18000.0000, N'SA00001', N'HD00063')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (3, 18000.0000, N'SA00001', N'HD00073')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 18000.0000, N'SA00001', N'HD00078')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (2, 40000.0000, N'SA00002', N'HD00062')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (3, 40000.0000, N'SA00002', N'HD00066')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (10, 120000.0000, N'SA00003', N'HD00042')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (2, 120000.0000, N'SA00003', N'HD00064')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (2, 120000.0000, N'SA00003', N'HD00074')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (2, 120000.0000, N'SA00003', N'HD00079')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (5, 165000.0000, N'SA00004', N'HD00059')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (2, 165000.0000, N'SA00004', N'HD00060')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (2, 165000.0000, N'SA00004', N'HD00071')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 165000.0000, N'SA00004', N'HD00072')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (2, 165000.0000, N'SA00004', N'HD00077')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 165000.0000, N'SA00004', N'HD00080')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (4, 165000.0000, N'SA00004', N'HD00086')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (2, 89000.0000, N'SA00005', N'HD00020')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 89000.0000, N'SA00005', N'HD00023')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 89000.0000, N'SA00005', N'HD00062')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 89000.0000, N'SA00005', N'HD00074')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (2, 89000.0000, N'SA00005', N'HD00079')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 79000.0000, N'SA00006', N'HD00057')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (3, 18000.0000, N'SA00007', N'HD00001')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (5, 18000.0000, N'SA00007', N'HD00015')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 18000.0000, N'SA00007', N'HD00063')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 18000.0000, N'SA00007', N'HD00068')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 18000.0000, N'SA00007', N'HD00069')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 89000.0000, N'SA00008', N'HD00024')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 89000.0000, N'SA00008', N'HD00063')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 89000.0000, N'SA00008', N'HD00075')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 89000.0000, N'SA00008', N'HD00082')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (2, 89000.0000, N'SA00008', N'HD00083')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (20, 89000.0000, N'SA00008', N'HD00089')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (2, 59000.0000, N'SA00009', N'HD00060')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 59000.0000, N'SA00009', N'HD00061')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 59000.0000, N'SA00009', N'HD00067')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (2, 59000.0000, N'SA00009', N'HD00076')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (4, 219000.0000, N'SA00010', N'HD00023')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 219000.0000, N'SA00010', N'HD00024')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 219000.0000, N'SA00010', N'HD00061')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (2, 219000.0000, N'SA00010', N'HD00064')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 219000.0000, N'SA00010', N'HD00070')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 219000.0000, N'SA00010', N'HD00078')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (2, 219000.0000, N'SA00010', N'HD00090')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (2, 219000.0000, N'SA00010', N'HD00095')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (30, 129000.0000, N'SA00011', N'HD00021')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 129000.0000, N'SA00011', N'HD00029')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (5, 129000.0000, N'SA00011', N'HD00036')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (5, 129000.0000, N'SA00011', N'HD00041')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 129000.0000, N'SA00011', N'HD00075')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (3, 129000.0000, N'SA00011', N'HD00081')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (2, 129000.0000, N'SA00011', N'HD00083')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (2, 21000.0000, N'SA00012', N'HD00058')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (5, 21000.0000, N'SA00012', N'HD00065')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (2, 89000.0000, N'SA00013', N'HD00029')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 89000.0000, N'SA00013', N'HD00067')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (2, 45000.0000, N'SA00014', N'HD00030')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 45000.0000, N'SA00014', N'HD00061')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 45000.0000, N'SA00014', N'HD00063')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (2, 45000.0000, N'SA00014', N'HD00071')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 45000.0000, N'SA00014', N'HD00076')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 790000.0000, N'SA00015', N'HD00075')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (3, 790000.0000, N'SA00015', N'HD00081')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 790000.0000, N'SA00015', N'HD00082')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (2, 790000.0000, N'SA00015', N'HD00083')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 790000.0000, N'SA00015', N'HD00085')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (5, 790000.0000, N'SA00015', N'HD00089')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 790000.0000, N'SA00015', N'HD00097')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (4, 23000.0000, N'SA00016', N'HD00028')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (10, 23000.0000, N'SA00016', N'HD00043')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (10, 465000.0000, N'SA00017', N'HD00021')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (5, 465000.0000, N'SA00017', N'HD00035')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (10, 465000.0000, N'SA00017', N'HD00040')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (3, 465000.0000, N'SA00017', N'HD00063')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 465000.0000, N'SA00017', N'HD00084')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (2, 465000.0000, N'SA00017', N'HD00095')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (10, 125000.0000, N'SA00018', N'HD00012')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (10, 125000.0000, N'SA00018', N'HD00018')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (30, 125000.0000, N'SA00018', N'HD00021')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (5, 48000.0000, N'SA00019', N'HD00065')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 48000.0000, N'SA00019', N'HD00098')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (3, 125000.0000, N'SA00020', N'HD00088')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (2, 100000.0000, N'SA00021', N'HD00087')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (5, 65000.0000, N'SA00022', N'HD00087')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (2, 65000.0000, N'SA00022', N'HD00095')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 170000.0000, N'SA00023', N'HD00088')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 79000.0000, N'SA00024', N'HD00088')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (5, 79000.0000, N'SA00024', N'HD00092')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 79000.0000, N'SA00024', N'HD00097')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (2, 25000.0000, N'SA00025', N'HD00090')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (20, 40000.0000, N'SA00026', N'HD00090')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 40000.0000, N'SA00026', N'HD00094')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 40000.0000, N'SA00026', N'HD00098')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (5, 30000.0000, N'SA00027', N'HD00094')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 30000.0000, N'SA00027', N'HD00098')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (5, 79000.0000, N'SA00028', N'HD00092')
GO
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 79000.0000, N'SA00028', N'HD00097')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 102000.0000, N'SA00029', N'HD00091')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (2, 300000.0000, N'SA00030', N'HD00091')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 89000.0000, N'SA00031', N'HD00091')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 90000.0000, N'SA00032', N'HD00092')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (2, 90000.0000, N'SA00032', N'HD00095')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 150000.0000, N'SA00033', N'HD00092')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (2, 150000.0000, N'SA00033', N'HD00096')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 51000.0000, N'SA00034', N'HD00092')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (2, 51000.0000, N'SA00034', N'HD00095')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (2, 51000.0000, N'SA00034', N'HD00096')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 108000.0000, N'SA00035', N'HD00092')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 108000.0000, N'SA00036', N'HD00093')
INSERT [dbo].[CTHD] ([SoLuong], [GiaBan], [MaSach], [MaHD]) VALUES (1, 440000.0000, N'SA00037', N'HD00093')
GO
INSERT [dbo].[CTPhieuDat] ([SoLuong], [GiaBan], [MaPhieuDat], [MaSach]) VALUES (2, 18000.0000, N'PD00001', N'SA00001')
INSERT [dbo].[CTPhieuDat] ([SoLuong], [GiaBan], [MaPhieuDat], [MaSach]) VALUES (1, 89000.0000, N'PD00001', N'SA00008')
INSERT [dbo].[CTPhieuDat] ([SoLuong], [GiaBan], [MaPhieuDat], [MaSach]) VALUES (1, 219000.0000, N'PD00001', N'SA00010')
INSERT [dbo].[CTPhieuDat] ([SoLuong], [GiaBan], [MaPhieuDat], [MaSach]) VALUES (1, 18000.0000, N'PD00002', N'SA00001')
INSERT [dbo].[CTPhieuDat] ([SoLuong], [GiaBan], [MaPhieuDat], [MaSach]) VALUES (1, 129000.0000, N'PD00002', N'SA00011')
INSERT [dbo].[CTPhieuDat] ([SoLuong], [GiaBan], [MaPhieuDat], [MaSach]) VALUES (2, 89000.0000, N'PD00002', N'SA00013')
INSERT [dbo].[CTPhieuDat] ([SoLuong], [GiaBan], [MaPhieuDat], [MaSach]) VALUES (1, 89000.0000, N'PD00003', N'SA00005')
INSERT [dbo].[CTPhieuDat] ([SoLuong], [GiaBan], [MaPhieuDat], [MaSach]) VALUES (3, 40000.0000, N'PD00004', N'SA00002')
INSERT [dbo].[CTPhieuDat] ([SoLuong], [GiaBan], [MaPhieuDat], [MaSach]) VALUES (1, 79000.0000, N'PD00005', N'SA00006')
INSERT [dbo].[CTPhieuDat] ([SoLuong], [GiaBan], [MaPhieuDat], [MaSach]) VALUES (2, 165000.0000, N'PD00009', N'SA00004')
INSERT [dbo].[CTPhieuDat] ([SoLuong], [GiaBan], [MaPhieuDat], [MaSach]) VALUES (2, 59000.0000, N'PD00009', N'SA00009')
INSERT [dbo].[CTPhieuDat] ([SoLuong], [GiaBan], [MaPhieuDat], [MaSach]) VALUES (2, 40000.0000, N'PD00011', N'SA00002')
INSERT [dbo].[CTPhieuDat] ([SoLuong], [GiaBan], [MaPhieuDat], [MaSach]) VALUES (1, 89000.0000, N'PD00011', N'SA00005')
INSERT [dbo].[CTPhieuDat] ([SoLuong], [GiaBan], [MaPhieuDat], [MaSach]) VALUES (2, 18000.0000, N'PD00012', N'SA00001')
INSERT [dbo].[CTPhieuDat] ([SoLuong], [GiaBan], [MaPhieuDat], [MaSach]) VALUES (4, 40000.0000, N'PD00012', N'SA00002')
INSERT [dbo].[CTPhieuDat] ([SoLuong], [GiaBan], [MaPhieuDat], [MaSach]) VALUES (1, 18000.0000, N'PD00015', N'SA00007')
INSERT [dbo].[CTPhieuDat] ([SoLuong], [GiaBan], [MaPhieuDat], [MaSach]) VALUES (10, 40000.0000, N'PD00016', N'SA00002')
INSERT [dbo].[CTPhieuDat] ([SoLuong], [GiaBan], [MaPhieuDat], [MaSach]) VALUES (1, 89000.0000, N'PD00016', N'SA00008')
INSERT [dbo].[CTPhieuDat] ([SoLuong], [GiaBan], [MaPhieuDat], [MaSach]) VALUES (1, 790000.0000, N'PD00016', N'SA00015')
GO
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (5, 10000.0000, N'SA00001', N'PN00001')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (10, 12000.0000, N'SA00001', N'PN00006')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (20, 15000.0000, N'SA00001', N'PN00009')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (10, 30000.0000, N'SA00002', N'PN00001')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (10, 32000.0000, N'SA00002', N'PN00006')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (200, 20000.0000, N'SA00002', N'PN00016')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (2, 100000.0000, N'SA00003', N'PN00005')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (20, 105000.0000, N'SA00003', N'PN00010')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (10, 10000.0000, N'SA00003', N'PN00022')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (7, 120000.0000, N'SA00004', N'PN00005')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (20, 150000.0000, N'SA00004', N'PN00015')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (4, 69000.0000, N'SA00005', N'PN00005')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (10, 69000.0000, N'SA00005', N'PN00015')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (5, 59000.0000, N'SA00006', N'PN00003')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (50, 69000.0000, N'SA00006', N'PN00014')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (7, 10000.0000, N'SA00007', N'PN00001')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (5, 70000.0000, N'SA00008', N'PN00004')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (30, 70000.0000, N'SA00008', N'PN00013')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (12, 30000.0000, N'SA00009', N'PN00003')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (50, 49000.0000, N'SA00009', N'PN00014')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (12, 199000.0000, N'SA00010', N'PN00005')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (20, 200000.0000, N'SA00010', N'PN00017')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (45, 100000.0000, N'SA00011', N'PN00004')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (30, 120000.0000, N'SA00011', N'PN00013')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (20, 18000.0000, N'SA00012', N'PN00016')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (5, 39000.0000, N'SA00013', N'PN00003')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (30, 69000.0000, N'SA00013', N'PN00014')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (5, 30000.0000, N'SA00014', N'PN00004')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (30, 20000.0000, N'SA00014', N'PN00013')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (15, 710000.0000, N'SA00015', N'PN00004')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (20, 690000.0000, N'SA00015', N'PN00013')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (10, 400000.0000, N'SA00017', N'PN00007')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (30, 400000.0000, N'SA00017', N'PN00011')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (5, 400000.0000, N'SA00017', N'PN00012')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (30, 100000.0000, N'SA00018', N'PN00008')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (20, 100000.0000, N'SA00018', N'PN00018')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (30, 28000.0000, N'SA00019', N'PN00010')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (30, 100000.0000, N'SA00020', N'PN00017')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (30, 80000.0000, N'SA00021', N'PN00017')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (30, 55000.0000, N'SA00022', N'PN00017')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (25, 150000.0000, N'SA00023', N'PN00018')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (30, 69000.0000, N'SA00024', N'PN00018')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (15, 21000.0000, N'SA00025', N'PN00019')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (30, 35000.0000, N'SA00026', N'PN00019')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (30, 25000.0000, N'SA00027', N'PN00019')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (50, 65000.0000, N'SA00028', N'PN00022')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (30, 82000.0000, N'SA00029', N'PN00022')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (19, 270000.0000, N'SA00030', N'PN00022')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (50, 79000.0000, N'SA00031', N'PN00022')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (20, 70000.0000, N'SA00032', N'PN00021')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (50, 140000.0000, N'SA00033', N'PN00021')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (20, 41000.0000, N'SA00034', N'PN00021')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (10, 92000.0000, N'SA00035', N'PN00021')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (30, 88000.0000, N'SA00036', N'PN00020')
INSERT [dbo].[CTPhieuNhap] ([SoLuong], [GiaNhap], [MaSach], [MaPhieuNhap]) VALUES (10, 400000.0000, N'SA00037', N'PN00020')
GO
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00001', CAST(N'2021-07-30' AS Date), N'BH00001', N'KH00001')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00012', CAST(N'2021-10-30' AS Date), N'BH00002', N'KH00007')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00015', CAST(N'2021-11-01' AS Date), N'BH00001', N'KH00002')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00018', CAST(N'2021-11-02' AS Date), N'BH00002', N'KH00003')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00020', CAST(N'2021-10-05' AS Date), N'BH00001', N'KH00016')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00021', CAST(N'2021-11-03' AS Date), N'BH00001', N'KH00019')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00022', CAST(N'2021-11-03' AS Date), N'BH00001', N'KH00016')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00023', CAST(N'2021-11-04' AS Date), N'BH00001', N'KH00012')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00024', CAST(N'2021-11-04' AS Date), N'QL00001', N'KH00001')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00028', CAST(N'2021-11-06' AS Date), N'BH00001', N'KH00014')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00029', CAST(N'2021-11-06' AS Date), N'BH00001', N'KH00004')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00030', CAST(N'2021-11-06' AS Date), N'BH00001', N'KH00014')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00035', CAST(N'2021-11-07' AS Date), N'BH00001', N'KH00014')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00036', CAST(N'2021-11-07' AS Date), N'BH00001', N'KH00014')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00040', CAST(N'2021-10-07' AS Date), N'BH00001', N'KH00001')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00041', CAST(N'2021-11-08' AS Date), N'BH00001', N'KH00056')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00042', CAST(N'2021-11-07' AS Date), N'BH00001', N'KH00005')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00043', CAST(N'2021-11-09' AS Date), N'BH00001', N'KH00008')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00057', CAST(N'2021-11-08' AS Date), N'BH00001', N'KH00095')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00058', CAST(N'2021-11-07' AS Date), N'BH00001', N'KH00008')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00059', CAST(N'2021-11-07' AS Date), N'BH00001', N'KH00016')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00060', CAST(N'2021-11-08' AS Date), N'BH00001', N'KH00030')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00061', CAST(N'2021-11-10' AS Date), N'QL00001', N'KH00100')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00062', CAST(N'2021-11-10' AS Date), N'QL00001', N'KH00014')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00063', CAST(N'2021-10-11' AS Date), N'BH00002', N'KH00012')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00064', CAST(N'2021-11-10' AS Date), N'BH00002', N'KH00101')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00065', CAST(N'2021-11-10' AS Date), N'BH00002', N'KH00012')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00066', CAST(N'2021-10-19' AS Date), N'BH00002', N'KH00095')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00067', CAST(N'2021-11-10' AS Date), N'BH00002', N'KH00006')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00068', CAST(N'2021-11-10' AS Date), N'BH00002', N'KH00006')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00069', CAST(N'2021-11-10' AS Date), N'BH00002', N'KH00006')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00070', CAST(N'2021-10-31' AS Date), N'BH00002', N'KH00006')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00071', CAST(N'2021-11-10' AS Date), N'QL00002', N'KH00012')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00072', CAST(N'2021-07-10' AS Date), N'QL00002', N'KH00014')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00073', CAST(N'2021-11-10' AS Date), N'QL00002', N'KH00102')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00074', CAST(N'2021-11-10' AS Date), N'QL00002', N'KH00014')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00075', CAST(N'2021-07-10' AS Date), N'BH00003', N'KH00012')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00076', CAST(N'2021-09-10' AS Date), N'BH00003', N'KH00008')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00077', CAST(N'2021-08-10' AS Date), N'BH00003', N'KH00005')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00078', CAST(N'2021-08-11' AS Date), N'BH00003', N'KH00005')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00079', CAST(N'2021-11-10' AS Date), N'BH00003', N'KH00002')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00080', CAST(N'2021-11-10' AS Date), N'BH00003', N'KH00001')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00081', CAST(N'2021-10-10' AS Date), N'BH00003', N'KH00007')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00082', CAST(N'2021-10-10' AS Date), N'BH00003', N'KH00018')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00083', CAST(N'2021-11-10' AS Date), N'BH00003', N'KH00014')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00084', CAST(N'2021-10-11' AS Date), N'BH00003', N'KH00012')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00085', CAST(N'2021-11-10' AS Date), N'BH00003', N'KH00014')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00086', CAST(N'2021-11-10' AS Date), N'BH00003', N'KH00012')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00087', CAST(N'2021-11-11' AS Date), N'BH00002', N'KH00018')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00088', CAST(N'2021-11-05' AS Date), N'BH00002', N'KH00100')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00089', CAST(N'2021-11-11' AS Date), N'QL00001', N'KH00103')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00090', CAST(N'2021-10-21' AS Date), N'QL00001', N'KH00104')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00091', CAST(N'2021-10-11' AS Date), N'BH00003', N'KH00105')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00092', CAST(N'2021-11-05' AS Date), N'BH00003', N'KH00012')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00093', CAST(N'2021-11-07' AS Date), N'BH00003', N'KH00106')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00094', CAST(N'2021-11-09' AS Date), N'QL00001', N'KH00014')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00095', CAST(N'2021-08-20' AS Date), N'BH00002', N'KH00107')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00096', CAST(N'2021-11-11' AS Date), N'BH00002', N'KH00014')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00097', CAST(N'2021-07-11' AS Date), N'BH00003', N'KH00108')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [MaNV], [MaKH]) VALUES (N'HD00098', CAST(N'2021-08-11' AS Date), N'BH00003', N'KH00109')
GO
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH00001', N'Trần Minh Thành', N'0358964480', N'Nam Từ Liêm')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH00002', N'Trần Minh Thư', N'0365882541', N'Cần Giờ ,TPHCM')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH00003', N'Nguyễn Quốc Hiệu', N'0792522562', N'75/35/3A Thạnh Xuân , Quận 12 , TPHCM')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH00004', N'Lê Bá Quận', N'0368524452', N'Dương Quản Hàm ,Gò Vấp ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH00005', N'Võ Hùng Quân', N'0789225632', N'250, Bùi Thị Ngọn , An Nhơn Tây , Củ Chi , TPHCM')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH00006', N'Huỳnh Minh Trí', N'0985125635', N'36 , Tô Ngọc Vân , Quận 12 , TP HCM')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH00007', N'Lê Thanh Minh', N'0562878653', N'Bình Thạnh , TPHCM')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH00008', N'Huỳnh Trọng Tấn', N'0365852662', N'Bến Cát')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH00010', N'Nguyễn Thị Ngọc Trâm ', N'0369445555', N'Bình Dương')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH00011', N'Võ Thành Đạt', N'0368965455', N'Củ Chi , TPHCM')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH00012', N'Đào A Hoàng', N'0911111111', N'Bình Dương')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH00013', N'Huỳnh Minh Anh', N'0988455585', N'22 , Thạnh Lộc , Quận 12')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH00014', N'Huỳnh Thanh Nhàn', N'0988888888', N'Bình Thạnh')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH00015', N'Võ Thành An', N'0988877665', N'An Lộc')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH00016', N'Thanh Minh', N'0906461526', N'Gò Vấp')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH00017', N'Trung Hoài Nguyễn', N'0906461522', N'Đà Nẵng')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH00018', N'Kim Thanh Binh', N'0399885557', N'Bình Định')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH00019', N'Nguyễn Kim Tuyên', N'0906461526', N'Hà Nội')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH00025', N'Đăng Nhật', N'0988666333', N'CU CHI')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH00030', N'Trần Ngọc Huyền', N'0366445552', N'An nhơn tây , Củ chi')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH00056', N'Nam Anh', N'0366999888', N'HCM')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH00095', N'Đăng Ka', N'0366999887', N'Đắc Nông')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH00100', N'Nguyễn Thị Lan', N'0336522114', N'Gò Vấp')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH00101', N'Huỳnh Nhật Long', N'0369552332', N'Đà Lạt')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH00102', N'Nguyễn Thị Huệ', N'0369445221', N'Thanh Hóa')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH00103', N'Ánh Hồng', N'0355474584', N'Hà nội')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH00104', N'Trần Thị Như Ý', N'0966845784', N'Quận 11')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH00105', N'Trấn Thành', N'0347552554', N'Quận 7')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH00106', N'Nam Anh', N'0855214254', N'Lâm Đồng')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH00107', N'Thúy Vi', N'0355697841', N'Quận 1
')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH00108', N'Trần Huyền Trang', N'0365448775', N'Quận 2
')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH00109', N'Nam Trần', N'0945862458', N'Tân Phú')
GO
INSERT [dbo].[LoaiSach] ([MaLoai], [TenLoai]) VALUES (N'TL00001', N'Văn Học')
INSERT [dbo].[LoaiSach] ([MaLoai], [TenLoai]) VALUES (N'TL00002', N'Văn Hóa / Du Lịch')
INSERT [dbo].[LoaiSach] ([MaLoai], [TenLoai]) VALUES (N'TL00003', N'Tâm Linh / Tôn Giáo')
INSERT [dbo].[LoaiSach] ([MaLoai], [TenLoai]) VALUES (N'TL00004', N'Truyện Tranh')
INSERT [dbo].[LoaiSach] ([MaLoai], [TenLoai]) VALUES (N'TL00005', N'Kinh Tế / Doanh Nhân')
INSERT [dbo].[LoaiSach] ([MaLoai], [TenLoai]) VALUES (N'TL00006', N'Thiếu Nhi')
INSERT [dbo].[LoaiSach] ([MaLoai], [TenLoai]) VALUES (N'TL00007', N'Sách Giáo Khoa')
GO
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC]) VALUES (N'CC00001', N'Nhà sách Nguyễn Du')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC]) VALUES (N'CC00002', N'Công ty cổ phần sách giáo dục TP HCM')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC]) VALUES (N'CC00003', N'Nhà sách Đất Việt')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC]) VALUES (N'CC00004', N'Công ty TNHH Đăng Nguyên')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC]) VALUES (N'CC00005', N'Sách Đại Nam')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC]) VALUES (N'CC00006', N'Sách Giáo Dục')
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [DiaChi], [ChucVu]) VALUES (N'BH00001', N'Võ Đăng Khoa', N'0948105462', N'Củ Chi', 2)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [DiaChi], [ChucVu]) VALUES (N'BH00002', N'Trần Nhật', N'0588555778', N'Bình Thạnh', 2)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [DiaChi], [ChucVu]) VALUES (N'BH00003', N'Nguyễn Thị Ngân', N'0355696471', N'Bình Phước', 2)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [DiaChi], [ChucVu]) VALUES (N'QL00001', N'Trung Hoài', N'0375462489', N'Gò Vấp', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [DiaChi], [ChucVu]) VALUES (N'QL00002', N'Đình Trọng', N'0903665998', N'Bình Dương', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [DiaChi], [ChucVu]) VALUES (N'TK00001', N'Thanh Nam', N'0378521666', N'Gò Vấp', 3)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [DiaChi], [ChucVu]) VALUES (N'TK00002', N'Trần Tâm', N'0948105461', N'Gò Vấp', 3)
GO
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB]) VALUES (N'XB00001', N'NXB Kim Đồng')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB]) VALUES (N'XB00002', N'NXB Văn Hóa')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB]) VALUES (N'XB00003', N'NXB Giáo Dục')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB]) VALUES (N'XB00004', N'NXB Trẻ')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB]) VALUES (N'XB00005', N'NXB Tri Thức')
GO
INSERT [dbo].[PhieuDatSach] ([MaPhieuDat], [NgayDat], [TinhTrang], [MaKH]) VALUES (N'PD00001', CAST(N'2021-09-30' AS Date), 1, N'KH00001')
INSERT [dbo].[PhieuDatSach] ([MaPhieuDat], [NgayDat], [TinhTrang], [MaKH]) VALUES (N'PD00002', CAST(N'2021-07-25' AS Date), 1, N'KH00004')
INSERT [dbo].[PhieuDatSach] ([MaPhieuDat], [NgayDat], [TinhTrang], [MaKH]) VALUES (N'PD00003', CAST(N'2021-11-03' AS Date), 1, N'KH00001')
INSERT [dbo].[PhieuDatSach] ([MaPhieuDat], [NgayDat], [TinhTrang], [MaKH]) VALUES (N'PD00004', CAST(N'2021-11-05' AS Date), 0, N'KH00018')
INSERT [dbo].[PhieuDatSach] ([MaPhieuDat], [NgayDat], [TinhTrang], [MaKH]) VALUES (N'PD00005', CAST(N'2021-11-06' AS Date), 1, N'KH00095')
INSERT [dbo].[PhieuDatSach] ([MaPhieuDat], [NgayDat], [TinhTrang], [MaKH]) VALUES (N'PD00009', CAST(N'2021-11-07' AS Date), 1, N'KH00030')
INSERT [dbo].[PhieuDatSach] ([MaPhieuDat], [NgayDat], [TinhTrang], [MaKH]) VALUES (N'PD00011', CAST(N'2021-11-07' AS Date), 1, N'KH00014')
INSERT [dbo].[PhieuDatSach] ([MaPhieuDat], [NgayDat], [TinhTrang], [MaKH]) VALUES (N'PD00012', CAST(N'2021-11-08' AS Date), 0, N'KH00014')
INSERT [dbo].[PhieuDatSach] ([MaPhieuDat], [NgayDat], [TinhTrang], [MaKH]) VALUES (N'PD00015', CAST(N'2021-11-10' AS Date), 0, N'KH00014')
INSERT [dbo].[PhieuDatSach] ([MaPhieuDat], [NgayDat], [TinhTrang], [MaKH]) VALUES (N'PD00016', CAST(N'2021-11-11' AS Date), 0, N'KH00100')
GO
INSERT [dbo].[PhieuNhapSach] ([MaPhieuNhap], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'PN00001', CAST(N'2021-05-30' AS Date), N'QL00001', N'CC00003')
INSERT [dbo].[PhieuNhapSach] ([MaPhieuNhap], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'PN00003', CAST(N'2021-06-03' AS Date), N'QL00001', N'CC00002')
INSERT [dbo].[PhieuNhapSach] ([MaPhieuNhap], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'PN00004', CAST(N'2021-05-27' AS Date), N'QL00001', N'CC00004')
INSERT [dbo].[PhieuNhapSach] ([MaPhieuNhap], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'PN00005', CAST(N'2021-05-27' AS Date), N'QL00001', N'CC00005')
INSERT [dbo].[PhieuNhapSach] ([MaPhieuNhap], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'PN00006', CAST(N'2021-10-28' AS Date), N'QL00001', N'CC00003')
INSERT [dbo].[PhieuNhapSach] ([MaPhieuNhap], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'PN00007', CAST(N'2021-10-28' AS Date), N'QL00002', N'CC00005')
INSERT [dbo].[PhieuNhapSach] ([MaPhieuNhap], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'PN00008', CAST(N'2021-10-31' AS Date), N'QL00002', N'CC00002')
INSERT [dbo].[PhieuNhapSach] ([MaPhieuNhap], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'PN00009', CAST(N'2021-11-03' AS Date), N'QL00002', N'CC00004')
INSERT [dbo].[PhieuNhapSach] ([MaPhieuNhap], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'PN00010', CAST(N'2021-11-03' AS Date), N'QL00002', N'CC00002')
INSERT [dbo].[PhieuNhapSach] ([MaPhieuNhap], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'PN00011', CAST(N'2021-11-06' AS Date), N'QL00002', N'CC00005')
INSERT [dbo].[PhieuNhapSach] ([MaPhieuNhap], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'PN00012', CAST(N'2021-11-06' AS Date), N'QL00001', N'CC00001')
INSERT [dbo].[PhieuNhapSach] ([MaPhieuNhap], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'PN00013', CAST(N'2021-11-10' AS Date), N'QL00001', N'CC00002')
INSERT [dbo].[PhieuNhapSach] ([MaPhieuNhap], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'PN00014', CAST(N'2021-11-10' AS Date), N'QL00001', N'CC00004')
INSERT [dbo].[PhieuNhapSach] ([MaPhieuNhap], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'PN00015', CAST(N'2021-11-10' AS Date), N'QL00002', N'CC00005')
INSERT [dbo].[PhieuNhapSach] ([MaPhieuNhap], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'PN00016', CAST(N'2021-11-10' AS Date), N'QL00002', N'CC00003')
INSERT [dbo].[PhieuNhapSach] ([MaPhieuNhap], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'PN00017', CAST(N'2021-11-10' AS Date), N'QL00001', N'CC00006')
INSERT [dbo].[PhieuNhapSach] ([MaPhieuNhap], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'PN00018', CAST(N'2021-11-10' AS Date), N'QL00002', N'CC00005')
INSERT [dbo].[PhieuNhapSach] ([MaPhieuNhap], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'PN00019', CAST(N'2021-11-11' AS Date), N'QL00001', N'CC00001')
INSERT [dbo].[PhieuNhapSach] ([MaPhieuNhap], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'PN00020', CAST(N'2021-11-11' AS Date), N'QL00001', N'CC00001')
INSERT [dbo].[PhieuNhapSach] ([MaPhieuNhap], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'PN00021', CAST(N'2021-11-11' AS Date), N'QL00002', N'CC00006')
INSERT [dbo].[PhieuNhapSach] ([MaPhieuNhap], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'PN00022', CAST(N'2021-11-11' AS Date), N'QL00002', N'CC00005')
GO
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00001', N'Nobita và binh đoàn robot', 15000.0000, 18000.0000, 19, 89, N'TG00010', N'TL00004', N'XB00001')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00002', N'Sử ta - Chuyện xưa kể lại', 20000.0000, 40000.0000, 215, 20, N'TG00006', N'TL00006', N'XB00001')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00003', N'Trở về từ xứ tuyết', 10000.0000, 120000.0000, 16, 120, N'TG00007', N'TL00003', N'XB00005')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00004', N'Tôi đã làm giàu như thế nào', 150000.0000, 165000.0000, 10, 210, N'TG00014', N'TL00005', N'XB00005')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00005', N'Tự chữa lành', 69000.0000, 89000.0000, 7, 125, N'TG00013', N'TL00003', N'XB00005')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00006', N'Hàn Quốc là thế', 69000.0000, 79000.0000, 54, 70, N'TG00000', N'TL00002', N'XB00002')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00007', N'Thám tử lừng danh Conan', 10000.0000, 18000.0000, 1, 88, N'TG00009', N'TL00004', N'XB00001')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00008', N'Chí Phèo', 70000.0000, 89000.0000, 9, 79, N'TG00001', N'TL00001', N'XB00003')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00009', N'Phẩm cách Quốc Gia', 49000.0000, 59000.0000, 56, 80, N'TG00015', N'TL00002', N'XB00005')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00010', N'Đắc Nhân Tâm', 200000.0000, 219000.0000, 18, 85, N'TG00011', N'TL00005', N'XB00005')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00011', N'Gặp anh ở Paris', 120000.0000, 129000.0000, 28, 120, N'TG00012', N'TL00001', N'XB00005')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00012', N'Bài tập toán 7', 18000.0000, 21000.0000, 32, 70, N'TG00000', N'TL00007', N'XB00003')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00013', N'Tết Việt Nam xưa', 69000.0000, 89000.0000, 32, 110, N'TG00008', N'TL00002', N'XB00002')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00014', N'Đời Thừa', 20000.0000, 45000.0000, 28, 40, N'TG00001', N'TL00001', N'XB00005')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00015', N'Truyên ngắn Nam Cao', 690000.0000, 790000.0000, 21, 137, N'TG00001', N'TL00001', N'XB00004')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00016', N'Ngữ Văn 6', 15000.0000, 23000.0000, 36, 190, N'TG00000', N'TL00007', N'XB00003')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00017', N'Cho tôi xin 1 vé đi tuổi thơ', 400000.0000, 465000.0000, 14, 200, N'TG00002', N'TL00001', N'XB00005')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00018', N'How to love', 100000.0000, 125000.0000, 20, 90, N'TG00004', N'TL00002', N'XB00002')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00019', N'Ngữ văn 12', 28000.0000, 48000.0000, 24, 300, N'TG00000', N'TL00007', N'XB00003')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00020', N'Dế mèn phiêu lưu ký', 100000.0000, 125000.0000, 27, 300, N'TG00003', N'TL00006', N'XB00001')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00021', N'Quê nhà', 80000.0000, 100000.0000, 28, 180, N'TG00003', N'TL00001', N'XB00004')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00022', N'Tuổi nhỏ chí cao', 55000.0000, 65000.0000, 23, 67, N'TG00003', N'TL00001', N'XB00005')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00023', N'Sài gòn ngoảnh lại trăm năm', 150000.0000, 170000.0000, 24, 215, N'TG00005', N'TL00002', N'XB00005')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00024', N'Chú bé thất sơn', 69000.0000, 79000.0000, 23, 60, N'TG00005', N'TL00004', N'XB00003')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00025', N'Đại sô tuyền tính 10', 21000.0000, 25000.0000, 13, 90, N'TG00000', N'TL00007', N'XB00003')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00026', N'Toán cao cấp ', 35000.0000, 40000.0000, 8, 120, N'TG00000', N'TL00007', N'XB00003')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00027', N'Vật lý đại cương', 25000.0000, 30000.0000, 24, 110, N'TG00000', N'TL00007', N'XB00003')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00028', N'DragonBall', 65000.0000, 79000.0000, 44, 200, N'TG00016', N'TL00004', N'XB00001')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00029', N'Cởi trói linh hồn', 82000.0000, 102000.0000, 29, 306, N'TG00017', N'TL00003', N'XB00005')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00030', N'Muôn kiếp nhân sinh', 270000.0000, 300000.0000, 17, 247, N'TG00007', N'TL00003', N'XB00004')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00031', N'Ám ảnh từ kiếp trước', 79000.0000, 89000.0000, 49, 76, N'TG00018', N'TL00003', N'XB00002')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00032', N'Tâm lý học hành vi', 70000.0000, 90000.0000, 17, 105, N'TG00019', N'TL00005', N'XB00002')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00033', N'Đời kinh doanh', 140000.0000, 150000.0000, 47, 306, N'TG00020', N'TL00005', N'XB00005')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00034', N'Đừng bao giờ bỏ cuộc', 41000.0000, 51000.0000, 15, 98, N'TG00014', N'TL00005', N'XB00005')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00035', N'Tỷ phú bán giày (Tái bản 2018)', 92000.0000, 108000.0000, 9, 126, N'TG00021', N'TL00005', N'XB00002')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00036', N'Những câu chuyện khoa học', 88000.0000, 108000.0000, 29, 206, N'TG00022', N'TL00006', N'XB00001')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [DonGiaNhap], [DonGiaBan], [SoLuongTon], [SoTrang], [MaTG], [MaLoai], [MaNXB]) VALUES (N'SA00037', N'Bách khoa lịch sử thế giới ', 400000.0000, 440000.0000, 9, 416, N'TG00023', N'TL00006', N'XB00005')
GO
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'TG00000', N'Nhiều tác giả')
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'TG00001', N'Nam Cao')
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'TG00002', N'Nguyễn Nhật Ánh')
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'TG00003', N'Tô Hoài')
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'TG00004', N'Thích Nhất Hạnh')
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'TG00005', N'Phạm Công Luận')
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'TG00006', N'Nguyễn Huy Thắng')
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'TG00007', N'Nguyên Phong')
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'TG00008', N'Nguyễn Văn Huyên')
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'TG00009', N'Denjiro Maru')
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'TG00010', N'Fujiko Fuijo')
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'TG00011', N'Dale Carnegie')
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'TG00012', N'Nicolas Barreau')
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'TG00013', N'Jane Roberts')
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'TG00014', N'Donald J. Trump')
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'TG00015', N'Fujiwara Masahiko')
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'TG00016', N'Toriyama Akira')
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'TG00017', N'Michael A. Singer')
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'TG00018', N'Brian L. Weiss')
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'TG00019', N'Khương Nguy')
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'TG00020', N'Phúc Chí (Phiên dịch)')
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'TG00021', N'Tony Hsieh')
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'TG00022', N'Từ Giảo')
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'TG00023', N'The Usborne')
GO
INSERT [dbo].[TaiKhoan] ([Username], [Password], [LoaiTaiKhoan], [MaKH], [MaNV]) VALUES (N'BHkhoa              ', N'12345678Aa', 2, NULL, N'BH00001')
INSERT [dbo].[TaiKhoan] ([Username], [Password], [LoaiTaiKhoan], [MaKH], [MaNV]) VALUES (N'BHngan              ', N'12345678Aa', 2, NULL, N'BH00003')
INSERT [dbo].[TaiKhoan] ([Username], [Password], [LoaiTaiKhoan], [MaKH], [MaNV]) VALUES (N'BHnhat              ', N'12345678Aa', 2, NULL, N'BH00002')
INSERT [dbo].[TaiKhoan] ([Username], [Password], [LoaiTaiKhoan], [MaKH], [MaNV]) VALUES (N'huyentran           ', N'12345678Aa', 4, N'KH00030', NULL)
INSERT [dbo].[TaiKhoan] ([Username], [Password], [LoaiTaiKhoan], [MaKH], [MaNV]) VALUES (N'meseur              ', N'12345678Aa', 4, N'KH00003', NULL)
INSERT [dbo].[TaiKhoan] ([Username], [Password], [LoaiTaiKhoan], [MaKH], [MaNV]) VALUES (N'msthanh             ', N'12345678Aa', 4, N'KH00018', NULL)
INSERT [dbo].[TaiKhoan] ([Username], [Password], [LoaiTaiKhoan], [MaKH], [MaNV]) VALUES (N'QLhoai              ', N'12345678Aa', 1, NULL, N'QL00001')
INSERT [dbo].[TaiKhoan] ([Username], [Password], [LoaiTaiKhoan], [MaKH], [MaNV]) VALUES (N'QLtrong             ', N'12345678Aa', 1, NULL, N'QL00002')
INSERT [dbo].[TaiKhoan] ([Username], [Password], [LoaiTaiKhoan], [MaKH], [MaNV]) VALUES (N'SoSo                ', N'12345678Aa', 4, N'KH00025', NULL)
INSERT [dbo].[TaiKhoan] ([Username], [Password], [LoaiTaiKhoan], [MaKH], [MaNV]) VALUES (N'ThanhNhan1          ', N'12345678Aa', 4, N'KH00014', NULL)
INSERT [dbo].[TaiKhoan] ([Username], [Password], [LoaiTaiKhoan], [MaKH], [MaNV]) VALUES (N'TKnam               ', N'12345678Aa', 3, NULL, N'TK00001')
INSERT [dbo].[TaiKhoan] ([Username], [Password], [LoaiTaiKhoan], [MaKH], [MaNV]) VALUES (N'TKtam               ', N'12345678Aa', 3, NULL, N'TK00002')
INSERT [dbo].[TaiKhoan] ([Username], [Password], [LoaiTaiKhoan], [MaKH], [MaNV]) VALUES (N'tranminh            ', N'12345678Aa', 4, N'KH00001', NULL)
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_CTHD_HoaDon]
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_CTHD_Sach]
GO
ALTER TABLE [dbo].[CTPhieuDat]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuDat_PhieuDatSach] FOREIGN KEY([MaPhieuDat])
REFERENCES [dbo].[PhieuDatSach] ([MaPhieuDat])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CTPhieuDat] CHECK CONSTRAINT [FK_CTPhieuDat_PhieuDatSach]
GO
ALTER TABLE [dbo].[CTPhieuDat]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuDat_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CTPhieuDat] CHECK CONSTRAINT [FK_CTPhieuDat_Sach]
GO
ALTER TABLE [dbo].[CTPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuNhap_PhieuNhapSach] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PhieuNhapSach] ([MaPhieuNhap])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CTPhieuNhap] CHECK CONSTRAINT [FK_CTPhieuNhap_PhieuNhapSach]
GO
ALTER TABLE [dbo].[CTPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuNhap_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CTPhieuNhap] CHECK CONSTRAINT [FK_CTPhieuNhap_Sach]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[PhieuDatSach]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDatSach_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuDatSach] CHECK CONSTRAINT [FK_PhieuDatSach_KhachHang]
GO
ALTER TABLE [dbo].[PhieuNhapSach]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapSach_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuNhapSach] CHECK CONSTRAINT [FK_PhieuNhapSach_NhaCungCap]
GO
ALTER TABLE [dbo].[PhieuNhapSach]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapSach_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuNhapSach] CHECK CONSTRAINT [FK_PhieuNhapSach_NhanVien]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_LoaiSach] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiSach] ([MaLoai])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_LoaiSach]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_NhaXuatBan] FOREIGN KEY([MaNXB])
REFERENCES [dbo].[NhaXuatBan] ([MaNXB])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_NhaXuatBan]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_TacGia] FOREIGN KEY([MaTG])
REFERENCES [dbo].[TacGia] ([MaTG])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_TacGia]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_KhachHang]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_NhanVien]
GO
