CREATE DATABASE [QLTiemChung]
GO
USE [QLTiemChung]
GO
/****** Object:  Table [dbo].[BacSi]    Script Date: 11/26/2021 5:35:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BacSi](
	[MaBS] [int] NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[Luong] [int] NULL,
	[ChucVu] [nvarchar](max) NULL,
	[PhongBan] [nvarchar](max) NULL,
	[NgaySinh] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[SDT] [nchar](10) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[HamHoc] [nvarchar](50) NULL,
	[MaCoSo] [int] NULL,
	[MaND] [int] NULL,
 CONSTRAINT [PK_BacSi] PRIMARY KEY CLUSTERED 
(
	[MaBS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BenhNhan]    Script Date: 11/26/2021 5:35:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BenhNhan](
	[MaBN] [int] NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[SDT] [nchar](10) NULL,
	[ThanhNhan] [nvarchar](max) NULL,
 CONSTRAINT [PK_BenhNhan] PRIMARY KEY CLUSTERED 
(
	[MaBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CoSo]    Script Date: 11/26/2021 5:35:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CoSo](
	[MaCoSo] [int] NOT NULL,
	[TenCoSo] [nvarchar](250) NULL,
	[DiaChi] [nvarchar](max) NULL,
 CONSTRAINT [PK_CoSo] PRIMARY KEY CLUSTERED 
(
	[MaCoSo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTKho]    Script Date: 11/26/2021 5:35:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTKho](
	[MaKho] [int] NULL,
	[MaVX] [int] NULL,
	[SoLuong] [int] NULL,
	[LoaiVX] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTPhieuNhap]    Script Date: 11/26/2021 5:35:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPhieuNhap](
	[MaKho] [int] NULL,
	[MaPhieuNhap] [int] NULL,
	[MaVX] [int] NULL,
	[SoLo] [nvarchar](250) NULL,
	[SoLuong] [nchar](10) NULL,
	[DonGia] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTPhieuXuat]    Script Date: 11/26/2021 5:35:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPhieuXuat](
	[MaKho] [int] NULL,
	[MaPhieuXuat] [int] NULL,
	[MaVX] [int] NULL,
	[DonGia] [int] NULL,
	[SoLuong] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 11/26/2021 5:35:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [int] NOT NULL,
	[ChiPhiKham] [int] NULL,
	[ChiPhiTiem] [int] NULL,
	[Ngay] [date] NULL,
	[MaNV] [int] NULL,
	[MaPhieuTiem] [int] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kho]    Script Date: 11/26/2021 5:35:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kho](
	[MaKho] [int] NOT NULL,
	[MaCoSo] [int] NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_Kho] PRIMARY KEY CLUSTERED 
(
	[MaKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiNguoiDung]    Script Date: 11/26/2021 5:35:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiNguoiDung](
	[MaLoaiND] [int] NOT NULL,
	[TenLoaiND] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiNguoiDung] PRIMARY KEY CLUSTERED 
(
	[MaLoaiND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 11/26/2021 5:35:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[MaND] [int] NOT NULL,
	[TenND] [nvarchar](50) NULL,
	[TaiKhoan] [nchar](100) NULL,
	[MatKhau] [nchar](100) NULL,
	[MaLoaiND] [int] NULL,
 CONSTRAINT [PK_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[MaND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 11/26/2021 5:35:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [int] NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[SDT] [nchar](10) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/26/2021 5:35:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[PhongBan] [nvarchar](max) NULL,
	[ChucVu] [nvarchar](max) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[Luong] [int] NULL,
	[NgaySinh] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[MaCoSo] [int] NULL,
	[MaND] [int] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuDangKy]    Script Date: 11/26/2021 5:35:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuDangKy](
	[MaBN] [int] NULL,
	[MaNV] [int] NULL,
	[NgayDangKy] [date] NULL,
	[MaVX] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuKham]    Script Date: 11/26/2021 5:35:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuKham](
	[MaBN] [int] NULL,
	[MaBS] [int] NULL,
	[NgayKham] [date] NULL,
	[TrangThaiCoTheTiem] [nvarchar](20) NULL,
	[XacNhanDuocTiem] [nvarchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 11/26/2021 5:35:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPhieuNhap] [int] NOT NULL,
	[NgayNhap] [date] NULL,
	[TongTien] [int] NULL,
	[MaNCC] [int] NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuTiem]    Script Date: 11/26/2021 5:35:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuTiem](
	[MaPhieuTiem] [int] NOT NULL,
	[NgayTiem] [date] NULL,
	[ChiPhi] [int] NULL,
	[LieuLuong] [nvarchar](50) NULL,
	[MaVX] [int] NULL,
	[MaBN] [int] NULL,
	[MaBS] [int] NULL,
 CONSTRAINT [PK_PhieuTiem] PRIMARY KEY CLUSTERED 
(
	[MaPhieuTiem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuXuat]    Script Date: 11/26/2021 5:35:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuXuat](
	[MaPhieuXuat] [int] NOT NULL,
	[NgayXuat] [date] NULL,
	[MaCoSo] [int] NULL,
 CONSTRAINT [PK_PhieuXuat] PRIMARY KEY CLUSTERED 
(
	[MaPhieuXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vacxin]    Script Date: 11/26/2021 5:35:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vacxin](
	[MaVX] [int] NOT NULL,
	[TenVX] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[PhanLoai] [nvarchar](50) NULL,
	[DonGiaNhap] [int] NULL,
	[DonGiaBan] [int] NULL,
	[DonViTinh] [nvarchar](50) NULL,
	[MaNCC] [int] NULL,
 CONSTRAINT [PK_Vacxin] PRIMARY KEY CLUSTERED 
(
	[MaVX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BacSi]  WITH CHECK ADD  CONSTRAINT [FK_BacSi_CoSo] FOREIGN KEY([MaCoSo])
REFERENCES [dbo].[CoSo] ([MaCoSo])
GO
ALTER TABLE [dbo].[BacSi] CHECK CONSTRAINT [FK_BacSi_CoSo]
GO
ALTER TABLE [dbo].[BacSi]  WITH CHECK ADD  CONSTRAINT [FK_BacSi_NguoiDung] FOREIGN KEY([MaND])
REFERENCES [dbo].[NguoiDung] ([MaND])
GO
ALTER TABLE [dbo].[BacSi] CHECK CONSTRAINT [FK_BacSi_NguoiDung]
GO
ALTER TABLE [dbo].[CTKho]  WITH CHECK ADD  CONSTRAINT [FK_CTKho_Kho] FOREIGN KEY([MaKho])
REFERENCES [dbo].[Kho] ([MaKho])
GO
ALTER TABLE [dbo].[CTKho] CHECK CONSTRAINT [FK_CTKho_Kho]
GO
ALTER TABLE [dbo].[CTKho]  WITH CHECK ADD  CONSTRAINT [FK_CTKho_Vacxin] FOREIGN KEY([MaVX])
REFERENCES [dbo].[Vacxin] ([MaVX])
GO
ALTER TABLE [dbo].[CTKho] CHECK CONSTRAINT [FK_CTKho_Vacxin]
GO
ALTER TABLE [dbo].[CTPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuNhap_Kho] FOREIGN KEY([MaKho])
REFERENCES [dbo].[Kho] ([MaKho])
GO
ALTER TABLE [dbo].[CTPhieuNhap] CHECK CONSTRAINT [FK_CTPhieuNhap_Kho]
GO
ALTER TABLE [dbo].[CTPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuNhap_PhieuNhap] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PhieuNhap] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[CTPhieuNhap] CHECK CONSTRAINT [FK_CTPhieuNhap_PhieuNhap]
GO
ALTER TABLE [dbo].[CTPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuXuat_Kho] FOREIGN KEY([MaKho])
REFERENCES [dbo].[Kho] ([MaKho])
GO
ALTER TABLE [dbo].[CTPhieuXuat] CHECK CONSTRAINT [FK_CTPhieuXuat_Kho]
GO
ALTER TABLE [dbo].[CTPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuXuat_PhieuXuat] FOREIGN KEY([MaPhieuXuat])
REFERENCES [dbo].[PhieuXuat] ([MaPhieuXuat])
GO
ALTER TABLE [dbo].[CTPhieuXuat] CHECK CONSTRAINT [FK_CTPhieuXuat_PhieuXuat]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_PhieuTiem] FOREIGN KEY([MaPhieuTiem])
REFERENCES [dbo].[PhieuTiem] ([MaPhieuTiem])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_PhieuTiem]
GO
ALTER TABLE [dbo].[Kho]  WITH CHECK ADD  CONSTRAINT [FK_Kho_CoSo] FOREIGN KEY([MaCoSo])
REFERENCES [dbo].[CoSo] ([MaCoSo])
GO
ALTER TABLE [dbo].[Kho] CHECK CONSTRAINT [FK_Kho_CoSo]
GO
ALTER TABLE [dbo].[NguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_NguoiDung_LoaiNguoiDung] FOREIGN KEY([MaLoaiND])
REFERENCES [dbo].[LoaiNguoiDung] ([MaLoaiND])
GO
ALTER TABLE [dbo].[NguoiDung] CHECK CONSTRAINT [FK_NguoiDung_LoaiNguoiDung]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_CoSo] FOREIGN KEY([MaCoSo])
REFERENCES [dbo].[CoSo] ([MaCoSo])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_CoSo]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_NguoiDung] FOREIGN KEY([MaND])
REFERENCES [dbo].[NguoiDung] ([MaND])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_NguoiDung]
GO
ALTER TABLE [dbo].[PhieuDangKy]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDangKy_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuDangKy] CHECK CONSTRAINT [FK_PhieuDangKy_NhanVien]
GO
ALTER TABLE [dbo].[PhieuDangKy]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDangKy_Vacxin] FOREIGN KEY([MaVX])
REFERENCES [dbo].[Vacxin] ([MaVX])
GO
ALTER TABLE [dbo].[PhieuDangKy] CHECK CONSTRAINT [FK_PhieuDangKy_Vacxin]
GO
ALTER TABLE [dbo].[PhieuKham]  WITH CHECK ADD  CONSTRAINT [FK_PhieuKham_BacSi] FOREIGN KEY([MaBS])
REFERENCES [dbo].[BacSi] ([MaBS])
GO
ALTER TABLE [dbo].[PhieuKham] CHECK CONSTRAINT [FK_PhieuKham_BacSi]
GO
ALTER TABLE [dbo].[PhieuKham]  WITH CHECK ADD  CONSTRAINT [FK_PhieuKham_BenhNhan] FOREIGN KEY([MaBN])
REFERENCES [dbo].[BenhNhan] ([MaBN])
GO
ALTER TABLE [dbo].[PhieuKham] CHECK CONSTRAINT [FK_PhieuKham_BenhNhan]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhaCungCap]
GO
ALTER TABLE [dbo].[PhieuTiem]  WITH CHECK ADD  CONSTRAINT [FK_PhieuTiem_BacSi] FOREIGN KEY([MaBS])
REFERENCES [dbo].[BacSi] ([MaBS])
GO
ALTER TABLE [dbo].[PhieuTiem] CHECK CONSTRAINT [FK_PhieuTiem_BacSi]
GO
ALTER TABLE [dbo].[PhieuTiem]  WITH CHECK ADD  CONSTRAINT [FK_PhieuTiem_BenhNhan] FOREIGN KEY([MaBN])
REFERENCES [dbo].[BenhNhan] ([MaBN])
GO
ALTER TABLE [dbo].[PhieuTiem] CHECK CONSTRAINT [FK_PhieuTiem_BenhNhan]
GO
ALTER TABLE [dbo].[PhieuTiem]  WITH CHECK ADD  CONSTRAINT [FK_PhieuTiem_Vacxin] FOREIGN KEY([MaVX])
REFERENCES [dbo].[Vacxin] ([MaVX])
GO
ALTER TABLE [dbo].[PhieuTiem] CHECK CONSTRAINT [FK_PhieuTiem_Vacxin]
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuat_CoSo] FOREIGN KEY([MaCoSo])
REFERENCES [dbo].[CoSo] ([MaCoSo])
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_PhieuXuat_CoSo]
GO
ALTER TABLE [dbo].[Vacxin]  WITH CHECK ADD  CONSTRAINT [FK_Vacxin_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[Vacxin] CHECK CONSTRAINT [FK_Vacxin_NhaCungCap]
GO
