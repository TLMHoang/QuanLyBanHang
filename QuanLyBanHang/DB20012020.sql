USE [master]
GO
/****** Object:  Database [QLBH]    Script Date: 1/20/2020 3:25:29 PM ******/
CREATE DATABASE [QLBH]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLBH', FILENAME = N'D:\SQL2019\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLBH.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLBH_log', FILENAME = N'D:\SQL2019\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLBH_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLBH] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLBH].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLBH] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLBH] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLBH] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLBH] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLBH] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLBH] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLBH] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLBH] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLBH] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLBH] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLBH] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLBH] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLBH] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLBH] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLBH] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLBH] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLBH] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLBH] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLBH] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLBH] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLBH] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLBH] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLBH] SET RECOVERY FULL 
GO
ALTER DATABASE [QLBH] SET  MULTI_USER 
GO
ALTER DATABASE [QLBH] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLBH] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLBH] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLBH] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLBH] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLBH', N'ON'
GO
ALTER DATABASE [QLBH] SET QUERY_STORE = OFF
GO
USE [QLBH]
GO
/****** Object:  Table [dbo].[CTHD]    Script Date: 1/20/2020 3:25:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHD](
	[IDHoaDon] [int] NULL,
	[IDHang] [int] NULL,
	[SoLuong] [int] NULL,
	[Tang] [bit] NULL,
	[GiaSi] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hang]    Script Date: 1/20/2020 3:25:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hang](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenHang] [nvarchar](200) NULL,
	[GiaBan] [int] NULL,
	[GiaNhap] [int] NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 1/20/2020 3:25:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDKhacHang] [int] NULL,
	[IDNhanVien] [int] NULL,
	[Ngay] [datetime] NULL,
	[TinhTrang] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 1/20/2020 3:25:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](200) NULL,
	[SDT] [varchar](20) NULL,
	[DiaChi] [nvarchar](300) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 1/20/2020 3:25:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ship]    Script Date: 1/20/2020 3:25:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ship](
	[IDHoaDon] [int] NULL,
	[Nhan] [int] NULL,
	[Tra] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 1/20/2020 3:25:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TKhoan] [varchar](100) NOT NULL,
	[MatKhau] [varchar](200) NULL,
	[Loai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[TKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CTHD] ([IDHoaDon], [IDHang], [SoLuong], [Tang], [GiaSi]) VALUES (28, 6, 2, 0, -1)
INSERT [dbo].[CTHD] ([IDHoaDon], [IDHang], [SoLuong], [Tang], [GiaSi]) VALUES (29, 7, 10, 0, -1)
INSERT [dbo].[CTHD] ([IDHoaDon], [IDHang], [SoLuong], [Tang], [GiaSi]) VALUES (31, 1, 1, 0, -1)
INSERT [dbo].[CTHD] ([IDHoaDon], [IDHang], [SoLuong], [Tang], [GiaSi]) VALUES (32, 8, 1, 0, -1)
INSERT [dbo].[CTHD] ([IDHoaDon], [IDHang], [SoLuong], [Tang], [GiaSi]) VALUES (33, 8, 2, 0, -1)
INSERT [dbo].[CTHD] ([IDHoaDon], [IDHang], [SoLuong], [Tang], [GiaSi]) VALUES (34, 2, 3, 0, -1)
INSERT [dbo].[CTHD] ([IDHoaDon], [IDHang], [SoLuong], [Tang], [GiaSi]) VALUES (34, 2, 1, 0, -1)
INSERT [dbo].[CTHD] ([IDHoaDon], [IDHang], [SoLuong], [Tang], [GiaSi]) VALUES (35, 5, 2, 0, -1)
INSERT [dbo].[CTHD] ([IDHoaDon], [IDHang], [SoLuong], [Tang], [GiaSi]) VALUES (36, 6, 2, 0, -1)
INSERT [dbo].[CTHD] ([IDHoaDon], [IDHang], [SoLuong], [Tang], [GiaSi]) VALUES (36, 8, 1, 0, -1)
INSERT [dbo].[CTHD] ([IDHoaDon], [IDHang], [SoLuong], [Tang], [GiaSi]) VALUES (39, 7, 1, 0, -1)
INSERT [dbo].[CTHD] ([IDHoaDon], [IDHang], [SoLuong], [Tang], [GiaSi]) VALUES (41, 9, 1, 0, -1)
INSERT [dbo].[CTHD] ([IDHoaDon], [IDHang], [SoLuong], [Tang], [GiaSi]) VALUES (41, 11, 10, 0, -1)
INSERT [dbo].[CTHD] ([IDHoaDon], [IDHang], [SoLuong], [Tang], [GiaSi]) VALUES (64, 3, 5, 0, -1)
INSERT [dbo].[CTHD] ([IDHoaDon], [IDHang], [SoLuong], [Tang], [GiaSi]) VALUES (65, 7, 8, 0, -1)
INSERT [dbo].[CTHD] ([IDHoaDon], [IDHang], [SoLuong], [Tang], [GiaSi]) VALUES (68, 6, 10, 0, -1)
INSERT [dbo].[CTHD] ([IDHoaDon], [IDHang], [SoLuong], [Tang], [GiaSi]) VALUES (68, 7, 8, 0, -1)
INSERT [dbo].[CTHD] ([IDHoaDon], [IDHang], [SoLuong], [Tang], [GiaSi]) VALUES (36, 6, 2, 0, -1)
INSERT [dbo].[CTHD] ([IDHoaDon], [IDHang], [SoLuong], [Tang], [GiaSi]) VALUES (38, 11, 13, 0, -1)
INSERT [dbo].[CTHD] ([IDHoaDon], [IDHang], [SoLuong], [Tang], [GiaSi]) VALUES (39, 5, 13, 0, -1)
INSERT [dbo].[CTHD] ([IDHoaDon], [IDHang], [SoLuong], [Tang], [GiaSi]) VALUES (40, 3, 12, 0, -1)
INSERT [dbo].[CTHD] ([IDHoaDon], [IDHang], [SoLuong], [Tang], [GiaSi]) VALUES (41, 5, 2, 0, -1)
SET IDENTITY_INSERT [dbo].[Hang] ON 

INSERT [dbo].[Hang] ([ID], [TenHang], [GiaBan], [GiaNhap], [SoLuong]) VALUES (1, N'3D Tranh Hồng Lá Xanh', 80000, 70000, 42)
INSERT [dbo].[Hang] ([ID], [TenHang], [GiaBan], [GiaNhap], [SoLuong]) VALUES (2, N'3D Mica giả gạch hoa lá', 50000, 35000, 15)
INSERT [dbo].[Hang] ([ID], [TenHang], [GiaBan], [GiaNhap], [SoLuong]) VALUES (3, N'3D Mica giả gạch họa tiết', 50000, 35000, 5)
INSERT [dbo].[Hang] ([ID], [TenHang], [GiaBan], [GiaNhap], [SoLuong]) VALUES (5, N'CASIO fx570VN', 500000, 450000, 15)
INSERT [dbo].[Hang] ([ID], [TenHang], [GiaBan], [GiaNhap], [SoLuong]) VALUES (6, N'CASIO fs570ES', 450000, 400000, 20)
INSERT [dbo].[Hang] ([ID], [TenHang], [GiaBan], [GiaNhap], [SoLuong]) VALUES (7, N'CPU i9 9000K', 10000000, 8000000, 8)
INSERT [dbo].[Hang] ([ID], [TenHang], [GiaBan], [GiaNhap], [SoLuong]) VALUES (8, N'CPU 17 7700HQ', 9000000, 8000000, 2)
INSERT [dbo].[Hang] ([ID], [TenHang], [GiaBan], [GiaNhap], [SoLuong]) VALUES (9, N'CPU I5 7700HQ', 8000000, 5500000, 4)
INSERT [dbo].[Hang] ([ID], [TenHang], [GiaBan], [GiaNhap], [SoLuong]) VALUES (10, N'CPU I3 3th', 5000000, 3500000, 5)
INSERT [dbo].[Hang] ([ID], [TenHang], [GiaBan], [GiaNhap], [SoLuong]) VALUES (11, N'GTX 1050 2GB', 5000000, 3500000, 20)
SET IDENTITY_INSERT [dbo].[Hang] OFF
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (23, NULL, NULL, CAST(N'2020-01-16T16:50:21.673' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (24, NULL, NULL, CAST(N'2020-01-16T16:57:15.860' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (25, NULL, NULL, CAST(N'2020-01-16T17:30:57.270' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (26, NULL, NULL, CAST(N'2020-01-16T17:33:56.493' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (27, NULL, NULL, CAST(N'2020-01-16T22:47:50.687' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (28, NULL, NULL, CAST(N'2020-01-16T23:01:48.480' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (29, NULL, NULL, CAST(N'2020-01-16T23:05:46.453' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (30, NULL, NULL, CAST(N'2020-01-16T23:07:02.633' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (31, NULL, NULL, CAST(N'2020-01-16T23:07:49.710' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (32, NULL, NULL, CAST(N'2020-01-16T23:09:04.577' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (33, NULL, NULL, CAST(N'2020-01-16T23:10:42.157' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (34, NULL, NULL, CAST(N'2020-01-16T23:11:59.777' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (35, NULL, NULL, CAST(N'2020-01-16T23:16:09.100' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (36, NULL, NULL, CAST(N'2020-01-16T23:17:57.040' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (37, NULL, NULL, CAST(N'2020-01-16T23:19:37.320' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (38, NULL, NULL, CAST(N'2020-01-16T23:21:03.847' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (39, NULL, NULL, CAST(N'2020-01-16T23:22:43.560' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (40, NULL, NULL, CAST(N'2020-01-16T23:25:25.967' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (41, NULL, NULL, CAST(N'2020-01-16T23:26:10.017' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (42, NULL, NULL, CAST(N'2020-01-17T00:55:50.903' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (43, NULL, NULL, CAST(N'2020-01-17T00:58:42.610' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (44, NULL, NULL, CAST(N'2020-01-17T10:05:13.943' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (45, NULL, NULL, CAST(N'2020-01-17T10:06:34.233' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (46, NULL, NULL, CAST(N'2020-01-17T10:07:54.020' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (47, NULL, NULL, CAST(N'2020-01-17T10:10:51.073' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (48, NULL, NULL, CAST(N'2020-01-17T10:14:31.990' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (49, NULL, NULL, CAST(N'2020-01-17T10:17:49.827' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (50, NULL, NULL, CAST(N'2020-01-17T10:19:24.990' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (51, NULL, NULL, CAST(N'2020-01-18T11:51:31.533' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (52, NULL, NULL, CAST(N'2020-01-18T11:52:32.183' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (53, NULL, NULL, CAST(N'2020-01-18T11:56:17.343' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (54, NULL, NULL, CAST(N'2020-01-18T11:57:48.167' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (55, NULL, NULL, CAST(N'2020-01-18T12:04:15.837' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (56, NULL, NULL, CAST(N'2020-01-20T14:04:10.737' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (57, NULL, NULL, CAST(N'2020-01-20T14:18:27.520' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (58, NULL, NULL, CAST(N'2020-01-20T14:21:55.423' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (59, NULL, NULL, CAST(N'2020-01-20T14:28:23.663' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (60, NULL, NULL, CAST(N'2020-01-20T14:29:27.727' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (61, NULL, NULL, CAST(N'2020-01-20T14:32:26.230' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (62, NULL, NULL, CAST(N'2020-01-20T14:33:49.620' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (63, NULL, NULL, CAST(N'2020-01-20T14:36:18.647' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (64, NULL, NULL, CAST(N'2020-01-20T14:37:27.773' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (65, NULL, NULL, CAST(N'2020-01-20T14:39:15.370' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (66, NULL, NULL, CAST(N'2020-01-20T14:39:49.973' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (67, NULL, NULL, CAST(N'2020-01-20T14:43:46.823' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([ID], [IDKhacHang], [IDNhanVien], [Ngay], [TinhTrang]) VALUES (68, NULL, NULL, CAST(N'2020-01-20T14:45:10.937' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([ID], [Ten]) VALUES (1, N'A')
INSERT [dbo].[NhanVien] ([ID], [Ten]) VALUES (2, N'Trần Văn B')
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
INSERT [dbo].[Ship] ([IDHoaDon], [Nhan], [Tra]) VALUES (46, 0, 0)
INSERT [dbo].[Ship] ([IDHoaDon], [Nhan], [Tra]) VALUES (47, 0, 0)
INSERT [dbo].[Ship] ([IDHoaDon], [Nhan], [Tra]) VALUES (48, 0, 0)
INSERT [dbo].[Ship] ([IDHoaDon], [Nhan], [Tra]) VALUES (49, 0, 0)
INSERT [dbo].[Ship] ([IDHoaDon], [Nhan], [Tra]) VALUES (51, 0, 0)
INSERT [dbo].[Ship] ([IDHoaDon], [Nhan], [Tra]) VALUES (52, 0, 0)
INSERT [dbo].[Ship] ([IDHoaDon], [Nhan], [Tra]) VALUES (53, 0, 0)
INSERT [dbo].[Ship] ([IDHoaDon], [Nhan], [Tra]) VALUES (54, 0, 0)
INSERT [dbo].[Ship] ([IDHoaDon], [Nhan], [Tra]) VALUES (56, 0, 0)
INSERT [dbo].[Ship] ([IDHoaDon], [Nhan], [Tra]) VALUES (57, 0, 0)
INSERT [dbo].[Ship] ([IDHoaDon], [Nhan], [Tra]) VALUES (58, 0, 0)
INSERT [dbo].[Ship] ([IDHoaDon], [Nhan], [Tra]) VALUES (59, 0, 0)
INSERT [dbo].[Ship] ([IDHoaDon], [Nhan], [Tra]) VALUES (60, 0, 0)
INSERT [dbo].[Ship] ([IDHoaDon], [Nhan], [Tra]) VALUES (61, 0, 0)
INSERT [dbo].[Ship] ([IDHoaDon], [Nhan], [Tra]) VALUES (62, 0, 0)
INSERT [dbo].[Ship] ([IDHoaDon], [Nhan], [Tra]) VALUES (64, 0, 0)
INSERT [dbo].[Ship] ([IDHoaDon], [Nhan], [Tra]) VALUES (66, 0, 0)
INSERT [dbo].[Ship] ([IDHoaDon], [Nhan], [Tra]) VALUES (50, 0, 0)
INSERT [dbo].[Ship] ([IDHoaDon], [Nhan], [Tra]) VALUES (55, 0, 0)
INSERT [dbo].[Ship] ([IDHoaDon], [Nhan], [Tra]) VALUES (63, 0, 0)
INSERT [dbo].[Ship] ([IDHoaDon], [Nhan], [Tra]) VALUES (67, 0, 0)
INSERT [dbo].[Ship] ([IDHoaDon], [Nhan], [Tra]) VALUES (68, 0, 0)
INSERT [dbo].[Ship] ([IDHoaDon], [Nhan], [Tra]) VALUES (65, 0, 0)
SET IDENTITY_INSERT [dbo].[TaiKhoan] ON 

INSERT [dbo].[TaiKhoan] ([ID], [TKhoan], [MatKhau], [Loai]) VALUES (1, N'admin', N'21232F297A57A5A743894A0E4A801FC3', 1)
INSERT [dbo].[TaiKhoan] ([ID], [TKhoan], [MatKhau], [Loai]) VALUES (2, N'test', N'C4CA4238A0B923820DCC509A6F75849B', 0)
INSERT [dbo].[TaiKhoan] ([ID], [TKhoan], [MatKhau], [Loai]) VALUES (11, N'Test1', N'C4CA4238A0B923820DCC509A6F75849B', 0)
SET IDENTITY_INSERT [dbo].[TaiKhoan] OFF
ALTER TABLE [dbo].[HoaDon] ADD  CONSTRAINT [df_TinhTrang]  DEFAULT ((0)) FOR [TinhTrang]
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD FOREIGN KEY([IDHoaDon])
REFERENCES [dbo].[HoaDon] ([ID])
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD FOREIGN KEY([IDHang])
REFERENCES [dbo].[Hang] ([ID])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([IDNhanVien])
REFERENCES [dbo].[NhanVien] ([ID])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([IDKhacHang])
REFERENCES [dbo].[KhachHang] ([ID])
GO
ALTER TABLE [dbo].[Ship]  WITH CHECK ADD FOREIGN KEY([IDHoaDon])
REFERENCES [dbo].[HoaDon] ([ID])
GO
/****** Object:  StoredProcedure [dbo].[DangNhap]    Script Date: 1/20/2020 3:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DangNhap]
@TaiKhoan VARCHAR(100),
@MatKhau VARCHAR(200)
AS
SELECT * FROM dbo.TaiKhoan WHERE TKhoan = @TaiKhoan AND MatKhau = CONVERT(VARCHAR(32),HASHBYTES('MD5', @MatKhau),2)
GO
/****** Object:  StoredProcedure [dbo].[LayCTHD]    Script Date: 1/20/2020 3:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[LayCTHD]
AS
BEGIN
	SELECT * FROM dbo.CTHD
END

GO
/****** Object:  StoredProcedure [dbo].[LayCTHDID]    Script Date: 1/20/2020 3:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LayCTHDID]
@IDHoaDon INT,
@IDHang INT
AS
BEGIN
    IF @IDHang = -1 
	BEGIN
	    SELECT * FROM dbo.CTHD WHERE IDHoaDon = @IDHoaDon
	END
	ELSE
	BEGIN
	    SELECT * FROM dbo.CTHD WHERE IDHoaDon = @IDHoaDon AND	 IDHang = @IDHang
	END
END

GO
/****** Object:  StoredProcedure [dbo].[LayHang]    Script Date: 1/20/2020 3:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LayHang]   
AS
BEGIN
		SELECT * FROM dbo.Hang
END
GO
/****** Object:  StoredProcedure [dbo].[LayHoaDon]    Script Date: 1/20/2020 3:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LayHoaDon]
AS
	SELECT * FROM dbo.HoaDon
GO
/****** Object:  StoredProcedure [dbo].[LayHoaDonNoF]    Script Date: 1/20/2020 3:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LayHoaDonNoF]
@TinhTrang BIT	
AS
SELECT * FROM dbo.HoaDon WHERE TinhTrang = @TinhTrang
GO
/****** Object:  StoredProcedure [dbo].[LayKhachHang]    Script Date: 1/20/2020 3:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[LayKhachHang]
AS
	SELECT * FROM dbo.KhachHang

GO
/****** Object:  StoredProcedure [dbo].[LayNhanVien]    Script Date: 1/20/2020 3:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[LayNhanVien]
AS
	SELECT * FROM dbo.NhanVien

GO
/****** Object:  StoredProcedure [dbo].[LayShip]    Script Date: 1/20/2020 3:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LayShip]
@IDHoaDon INT
AS
BEGIN
    SELECT * FROM dbo.Ship WHERE IDHoaDon = @IDHoaDon
END
GO
/****** Object:  StoredProcedure [dbo].[LayTaiKhoan]    Script Date: 1/20/2020 3:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[LayTaiKhoan]
AS
SELECT * FROM dbo.TaiKhoan
GO
/****** Object:  StoredProcedure [dbo].[SuaCTHD]    Script Date: 1/20/2020 3:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SuaCTHD]
@IDHoaDon INT,
@IDHang INT,
@SoLuong INT,
@Tang BIT,
@GiaSi INT
AS
UPDATE dbo.CTHD SET
    SoLuong = @SoLuong,  -- SoLuong - int
	Tang = @Tang,
	GiaSi = @GiaSi
    WHERE IDHoaDon = @IDHoaDon AND IDHang = @IDHang
GO
/****** Object:  StoredProcedure [dbo].[SuaHang]    Script Date: 1/20/2020 3:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SuaHang]
@ID INT,
@TenHang NVARCHAR(200),
@GiaBan INT,
@GiaNhap INT,
@SoLuong INT
AS
UPDATE dbo.Hang SET
	    TenHang = @TenHang, -- TenHang - nvarchar(200)
		GiaBan = @GiaBan,
		GiaNhap = @GiaNhap,
	    SoLuong = @SoLuong    -- SoLuong - int
WHERE ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[SuaHoaDon]    Script Date: 1/20/2020 3:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SuaHoaDon]
@ID INT,
@IDKhachHang INT,
@IDNhanVien INT,
@Ngay DATETIME,
@TinhTrang BIT
AS
UPDATE dbo.HoaDon SET
    IDKhacHang = @IDKhachHang,         -- IDKhacHang - int
    IDNhanVien = @IDNhanVien,         -- IDNhanVien - int
    Ngay = @Ngay, -- Ngay - datetime
    TinhTrang = @TinhTrang       -- TinhTrang - bit
WHERE ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[SuaKhachHang]    Script Date: 1/20/2020 3:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SuaKhachHang]
@ID INT,
@TenKH NVARCHAR(200),
@SDT NVARCHAR(20),
@DiaChi NVARCHAR(300)
AS
UPDATE dbo.KhachHang SET
    TenKH = @TenKH, -- TenKH - nvarchar(200)
    SDT = @SDT,  -- SDT - varchar(20)
    DiaChi = @DiaChi  -- DiaChi - nvarchar(300)
WHERE ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[SuaNhanVien]    Script Date: 1/20/2020 3:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SuaNhanVien]  
@ID INT,
@Ten NVARCHAR(200)
AS
UPDATE dbo.NhanVien SET
Ten = @Ten -- Ten - nvarchar(200)
WHERE ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[SuaShip]    Script Date: 1/20/2020 3:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SuaShip]
@IDHoaDon INT,
@Nhan INT,
@Tra INT
AS
BEGIN
    UPDATE dbo.Ship SET	
	Nhan = @Nhan, 
	Tra = @Tra
	WHERE IDHoaDon = @IDHoaDon
END
GO
/****** Object:  StoredProcedure [dbo].[SuaTaiKhoan]    Script Date: 1/20/2020 3:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SuaTaiKhoan]
@ID INT,
@MatKhau VARCHAR(200),
@Loai BIT
AS
UPDATE dbo.TaiKhoan SET
    MatKhau = CONVERT(VARCHAR(32), HASHBYTES('MD5', @MatKhau), 2),  -- MatKhau - varchar(200)
    Loai = @Loai -- Loai - bit
WHERE ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[ThemCTHD]    Script Date: 1/20/2020 3:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemCTHD]
@IDHoaDon INT,
@IDHang INT,
@SoLuong INT,
@Tang BIT,
@GiaSi INT
AS
BEGIN
	INSERT	dbo.CTHD
	(
		IDHoaDon,
		IDHang,
		SoLuong,
		Tang,
		GiaSi
	)
	VALUES
	(   
		@IDHoaDon, -- IDHoaDon - int
	    @IDHang, -- IDHang - int
		@SoLuong,  -- SoLuong - int
		@Tang, -- Tang - bit
		@GiaSi -- GiaSi - bit
	   )
END
GO
/****** Object:  StoredProcedure [dbo].[ThemHang]    Script Date: 1/20/2020 3:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemHang]
@ID INT,
@TenHang NVARCHAR(200),
@GiaBan INT,
@GiaNhap INT,
@SoLuong INT
AS
BEGIN
    IF (@ID = -1)
	BEGIN
		INSERT dbo.Hang
		(
		    TenHang,
			GiaBan,
			GiaNhap,
		    SoLuong
			
		)
		VALUES
		(   
			@TenHang, -- TenHang - nvarchar(200)
			@GiaBan, -- GiaBan - int
			@GiaNhap,  -- GiaNhap - int
			@SoLuong    -- SoLuong - int
	    )
	END
END

GO
/****** Object:  StoredProcedure [dbo].[ThemHoaDon]    Script Date: 1/20/2020 3:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemHoaDon]
@ID INT,
@IDKhachHang INT,
@IDNhanVien INT,
@Ngay DATETIME
AS
BEGIN
	IF @IDKhachHang = -1 
		SET @IDKhachHang = NULL
	IF @IDNhanVien = -1
		SET @IDNhanVien = NULL
    IF @ID = -1
	BEGIN
	INSERT dbo.HoaDon
	(
	   IDKhacHang,
	    IDNhanVien,
	    Ngay
	)
	VALUES
	(   
		@IDKhachHang,         -- IDKhacHang - int
		@IDNhanVien,         -- IDNhanVien - int
		@Ngay -- Ngay - datetime
		)
	END
END

GO
/****** Object:  StoredProcedure [dbo].[ThemKhachHang]    Script Date: 1/20/2020 3:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
EXEC dbo.ThemHoaDon @ID = -1,                       -- int
                    @IDKhachHang = -1,              -- int
                    @IDNhanVien = -1,               -- int
                    @Ngay = '2020-01-07 04:22:15', -- datetime
                    @TinhTrang = 1              -- bit
*/



CREATE PROCEDURE [dbo].[ThemKhachHang]
@ID INT,
@TenKH VARCHAR(200),
@SDT VARCHAR(20),
@DiaChi NVARCHAR(300)
AS
BEGIN
    IF @ID = -1
	BEGIN	
	INSERT dbo.KhachHang
	(
		TenKH,
	    SDT,
	    DiaChi
	)
	VALUES
	(   
		@TenKH, -- TenKH - nvarchar(200)
		@SDT,  -- SDT - varchar(20)
		@DiaChi  -- DiaChi - nvarchar(300)
		)
	END	
END
GO
/****** Object:  StoredProcedure [dbo].[ThemNhanVien]    Script Date: 1/20/2020 3:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ThemNhanVien]  
@ID INT,
@Ten NVARCHAR(200)
AS
BEGIN
    IF @ID = -1
	BEGIN
	INSERT dbo.NhanVien
	(
	    Ten
	)
	VALUES
	(
		@Ten -- Ten - nvarchar(200)
		)
	END	
END

GO
/****** Object:  StoredProcedure [dbo].[ThemShip]    Script Date: 1/20/2020 3:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ThemShip]
@IDHoaDon INT,
@Nhan INT,
@Tra INT
AS
BEGIN
    INSERT dbo.Ship
    (
        IDHoaDon,
        Nhan,
        Tra
    )
    VALUES
    (   @IDHoaDon, -- IDHoaDon - int
        @Nhan, -- Nhan - int
        @Tra  -- Tra - int
        )
END
GO
/****** Object:  StoredProcedure [dbo].[ThemTaiKhoan]    Script Date: 1/20/2020 3:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemTaiKhoan]
@ID INT,
@TKhoan NVARCHAR(100),
@MatKhau NVARCHAR(200),
@Loai BIT
AS
BEGIN
    IF	@ID = -1
	BEGIN
	INSERT dbo.TaiKhoan
	(
		TKhoan,
		MatKhau,
		Loai
	)
	VALUES
	(
		@TKhoan,  -- TKhoan - varchar(100)
		@MatKhau,  -- MatKhau - varchar(200)
		@Loai -- Loai - bit
		)
	END
	DECLARE @I INT = (SELECT ID FROM dbo.TaiKhoan WHERE MatKhau = @MatKhau AND TKhoan = @TKhoan)

	EXEC dbo.SuaTaiKhoan @ID = @I,       -- int
	                     @MatKhau = @TKhoan, -- varchar(200)
	                     @Loai = 0   -- bit
	
END
GO
/****** Object:  StoredProcedure [dbo].[XoaCTHD]    Script Date: 1/20/2020 3:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[XoaCTHD]
@IDHoaDon INT
AS
DELETE FROM dbo.CTHD WHERE IDHoaDon = @IDHoaDon
GO
/****** Object:  StoredProcedure [dbo].[XoaCTHDID]    Script Date: 1/20/2020 3:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[XoaCTHDID]
@IDHoaDon INT,
@IDHang INT
AS
DELETE FROM dbo.CTHD WHERE IDHoaDon = @IDHoaDon AND IDHang = @IDHang
GO
/****** Object:  StoredProcedure [dbo].[XoaHang]    Script Date: 1/20/2020 3:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- proc xoa

CREATE PROCEDURE [dbo].[XoaHang]
@ID INT
AS
DELETE FROM dbo.Hang WHERE ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[XoaHoaDon]    Script Date: 1/20/2020 3:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[XoaHoaDon]
@ID INT
AS
BEGIN
	EXEC dbo.XoaCTHD @IDHoaDon = @ID -- int
	EXEC dbo.XoaShip @IDHoaDon = @ID -- int
    DELETE FROM dbo.HoaDon WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [dbo].[XoaKhachHang]    Script Date: 1/20/2020 3:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[XoaKhachHang]
@ID INT
AS
DELETE FROM dbo.KhachHang WHERE ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[XoaNhanVien]    Script Date: 1/20/2020 3:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[XoaNhanVien]  
@ID INT
AS
DELETE FROM dbo.NhanVien WHERE ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[XoaShip]    Script Date: 1/20/2020 3:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[XoaShip]
@IDHoaDon INT
AS
BEGIN
    DELETE FROM dbo.Ship WHERE IDHoaDon = @IDHoaDon
END
GO
/****** Object:  StoredProcedure [dbo].[XoaTaiKhoan]    Script Date: 1/20/2020 3:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[XoaTaiKhoan]
@ID INT
AS
DELETE FROM dbo.TaiKhoan WHERE ID = @ID
GO
USE [master]
GO
ALTER DATABASE [QLBH] SET  READ_WRITE 
GO
