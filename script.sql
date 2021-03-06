USE [quanlyphongtro]
GO
/****** Object:  Table [dbo].[danhSachDichVu]    Script Date: 10-Apr-21 10:40:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[danhSachDichVu](
	[tenDichVu] [nvarchar](100) NOT NULL,
	[donViTinh] [nvarchar](100) NOT NULL,
	[donGia] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[tenDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hoaDonDichVu]    Script Date: 10-Apr-21 10:40:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoaDonDichVu](
	[maHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[maPhong] [nvarchar](100) NOT NULL,
	[tenDichVu] [nvarchar](100) NOT NULL,
	[soLuong] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hoaDonTong]    Script Date: 10-Apr-21 10:40:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoaDonTong](
	[maHoaDonTong] [int] IDENTITY(1,1) NOT NULL,
	[maPhong] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maHoaDonTong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[phong]    Script Date: 10-Apr-21 10:40:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phong](
	[maPhong] [nvarchar](10) NOT NULL,
	[trangThai] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[taikhoan]    Script Date: 10-Apr-21 10:40:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[taikhoan](
	[tenDangNhap] [nvarchar](100) NOT NULL,
	[tenHienThi] [nvarchar](100) NOT NULL,
	[matKhau] [nvarchar](100) NOT NULL,
	[quyenHan] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[tenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[hoaDonDichVu]  WITH CHECK ADD FOREIGN KEY([tenDichVu])
REFERENCES [dbo].[danhSachDichVu] ([tenDichVu])
GO
ALTER TABLE [dbo].[hoaDonTong]  WITH CHECK ADD FOREIGN KEY([maPhong])
REFERENCES [dbo].[phong] ([maPhong])
GO
/****** Object:  StoredProcedure [dbo].[dangNhap]    Script Date: 10-Apr-21 10:40:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[dangNhap]
@ptenDangNhap nvarchar(100), @pmatKhau nvarchar(100)
as
begin
	select quyenHan from taiKhoan where tenDangNhap = @ptenDangNhap and matKhau = @pmatKhau
end;
GO
