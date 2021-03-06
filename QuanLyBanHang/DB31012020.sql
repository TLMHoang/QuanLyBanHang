USE [master]
GO
/****** Object:  Database [QLBH]    Script Date: 1/31/2020 7:16:12 PM ******/
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
/****** Object:  Table [dbo].[CTHD]    Script Date: 1/31/2020 7:16:12 PM ******/
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
/****** Object:  Table [dbo].[Hang]    Script Date: 1/31/2020 7:16:12 PM ******/
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
/****** Object:  Table [dbo].[HoaDon]    Script Date: 1/31/2020 7:16:12 PM ******/
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
/****** Object:  Table [dbo].[KhachHang]    Script Date: 1/31/2020 7:16:12 PM ******/
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
/****** Object:  Table [dbo].[NhanVien]    Script Date: 1/31/2020 7:16:12 PM ******/
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
/****** Object:  Table [dbo].[Ship]    Script Date: 1/31/2020 7:16:12 PM ******/
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
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 1/31/2020 7:16:12 PM ******/
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
ALTER TABLE [dbo].[HoaDon] ADD  CONSTRAINT [df_TinhTrang]  DEFAULT ((0)) FOR [TinhTrang]
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD FOREIGN KEY([IDHang])
REFERENCES [dbo].[Hang] ([ID])
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD FOREIGN KEY([IDHoaDon])
REFERENCES [dbo].[HoaDon] ([ID])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([IDKhacHang])
REFERENCES [dbo].[KhachHang] ([ID])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([IDNhanVien])
REFERENCES [dbo].[NhanVien] ([ID])
GO
ALTER TABLE [dbo].[Ship]  WITH CHECK ADD FOREIGN KEY([IDHoaDon])
REFERENCES [dbo].[HoaDon] ([ID])
GO
/****** Object:  StoredProcedure [dbo].[DangNhap]    Script Date: 1/31/2020 7:16:12 PM ******/
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
/****** Object:  StoredProcedure [dbo].[LayCTHD]    Script Date: 1/31/2020 7:16:12 PM ******/
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
/****** Object:  StoredProcedure [dbo].[LayCTHDCheck]    Script Date: 1/31/2020 7:16:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LayCTHDCheck]
@IDHoaDon INT,
@IDHang INT,
@Tang BIT
AS
BEGIN
    SELECT * FROM dbo.CTHD WHERE IDHoaDon = @IDHoaDon AND	 IDHang = @IDHang AND	Tang = @Tang
END
GO
/****** Object:  StoredProcedure [dbo].[LayCTHDID]    Script Date: 1/31/2020 7:16:12 PM ******/
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
/****** Object:  StoredProcedure [dbo].[LayHang]    Script Date: 1/31/2020 7:16:12 PM ******/
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
/****** Object:  StoredProcedure [dbo].[LayHoaDon]    Script Date: 1/31/2020 7:16:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LayHoaDon]
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM dbo.HoaDon
	END
	ELSE
	BEGIN
	    SELECT * FROM dbo.HoaDon WHERE ID = @ID
	END
END
	
GO
/****** Object:  StoredProcedure [dbo].[LayHoaDonNgay]    Script Date: 1/31/2020 7:16:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LayHoaDonNgay]
@From DATETIME,
@To DATETIME
AS	
BEGIN
	    SELECT * FROM	dbo.HoaDon WHERE Ngay >= @From AND	Ngay <= @To
END
GO
/****** Object:  StoredProcedure [dbo].[LayHoaDonNgayTT]    Script Date: 1/31/2020 7:16:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[LayHoaDonNgayTT]
@From DATETIME,
@To DATETIME,
@TinhTrang bit
AS	
BEGIN
	SELECT * FROM	dbo.HoaDon WHERE Ngay >= @From AND	Ngay <= @To AND	TinhTrang = @TinhTrang
END
GO
/****** Object:  StoredProcedure [dbo].[LayKhachHang]    Script Date: 1/31/2020 7:16:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[LayKhachHang]
AS
	SELECT * FROM dbo.KhachHang

GO
/****** Object:  StoredProcedure [dbo].[LayNhanVien]    Script Date: 1/31/2020 7:16:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[LayNhanVien]
AS
	SELECT * FROM dbo.NhanVien

GO
/****** Object:  StoredProcedure [dbo].[LayShip]    Script Date: 1/31/2020 7:16:12 PM ******/
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
/****** Object:  StoredProcedure [dbo].[LayTaiKhoan]    Script Date: 1/31/2020 7:16:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[LayTaiKhoan]
AS
SELECT * FROM dbo.TaiKhoan
GO
/****** Object:  StoredProcedure [dbo].[SuaCTHD]    Script Date: 1/31/2020 7:16:12 PM ******/
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
BEGIN
	EXEC dbo.XoaCTHD @IDHoaDon = @IDHoaDon, -- int
	                 @IDHang = @IDHang,    -- int
					 @Tang = @Tang
	EXEC dbo.ThemCTHD @IDHoaDon = @IDHoaDon, -- int
	                  @IDHang = @IDHang,   -- int
	                  @SoLuong = @SoLuong,  -- int
	                  @Tang = @Tang,  -- bit
	                  @GiaSi = @GiaSi     -- int
	
END
GO
/****** Object:  StoredProcedure [dbo].[SuaHang]    Script Date: 1/31/2020 7:16:12 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SuaHoaDon]    Script Date: 1/31/2020 7:16:12 PM ******/
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
BEGIN
	IF @IDKhachHang = -1 SET @IDKhachHang = NULL
	IF @IDNhanVien = -1 SET @IDNhanVien = NULL
    UPDATE dbo.HoaDon SET
		IDKhacHang = @IDKhachHang,         -- IDKhacHang - int
		IDNhanVien = @IDNhanVien,         -- IDNhanVien - int
		Ngay = @Ngay, -- Ngay - datetime
		TinhTrang = @TinhTrang       -- TinhTrang - bit
	WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[SuaKhachHang]    Script Date: 1/31/2020 7:16:12 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SuaNhanVien]    Script Date: 1/31/2020 7:16:12 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SuaShip]    Script Date: 1/31/2020 7:16:12 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SuaTaiKhoan]    Script Date: 1/31/2020 7:16:12 PM ******/
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
/****** Object:  StoredProcedure [dbo].[ThemCTHD]    Script Date: 1/31/2020 7:16:12 PM ******/
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
		@GiaSi -- GiaSi - int
	   )
END
GO
/****** Object:  StoredProcedure [dbo].[ThemHang]    Script Date: 1/31/2020 7:16:12 PM ******/
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
/****** Object:  StoredProcedure [dbo].[ThemHoaDon]    Script Date: 1/31/2020 7:16:12 PM ******/
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
/****** Object:  StoredProcedure [dbo].[ThemKhachHang]    Script Date: 1/31/2020 7:16:12 PM ******/
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
/****** Object:  StoredProcedure [dbo].[ThemNhanVien]    Script Date: 1/31/2020 7:16:12 PM ******/
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
/****** Object:  StoredProcedure [dbo].[ThemShip]    Script Date: 1/31/2020 7:16:12 PM ******/
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
/****** Object:  StoredProcedure [dbo].[ThemTaiKhoan]    Script Date: 1/31/2020 7:16:12 PM ******/
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
/****** Object:  StoredProcedure [dbo].[XoaCTHD]    Script Date: 1/31/2020 7:16:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[XoaCTHD]
@IDHoaDon INT,
@IDHang INT,
@Tang BIT
AS
BEGIN
	IF @IDHang = -1
	BEGIN
	    DELETE FROM dbo.CTHD WHERE IDHoaDon = @IDHoaDon
	END
	ELSE
	BEGIN
		DELETE FROM dbo.CTHD WHERE IDHoaDon = @IDHoaDon AND IDHang = @IDHang AND Tang  = @Tang
	END
    
END
GO
/****** Object:  StoredProcedure [dbo].[XoaHang]    Script Date: 1/31/2020 7:16:12 PM ******/
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
/****** Object:  StoredProcedure [dbo].[XoaHoaDon]    Script Date: 1/31/2020 7:16:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[XoaHoaDon]
@ID INT
AS
BEGIN
	EXEC dbo.XoaShip @IDHoaDon = @ID -- int
    DELETE FROM dbo.HoaDon WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [dbo].[XoaKhachHang]    Script Date: 1/31/2020 7:16:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[XoaKhachHang]
@ID INT
AS
DELETE FROM dbo.KhachHang WHERE ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[XoaNhanVien]    Script Date: 1/31/2020 7:16:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[XoaNhanVien]  
@ID INT
AS
DELETE FROM dbo.NhanVien WHERE ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[XoaShip]    Script Date: 1/31/2020 7:16:12 PM ******/
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
/****** Object:  StoredProcedure [dbo].[XoaTaiKhoan]    Script Date: 1/31/2020 7:16:12 PM ******/
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


USE QLBH
GO	

CREATE TRIGGER trg_XoaCTHD
ON dbo.CTHD
FOR DELETE
AS
BEGIN	
    UPDATE dbo.Hang SET	SoLuong = dbo.Hang.SoLuong + (SELECT SoLuong FROM Deleted WHERE IDHang = dbo.Hang.ID)
	FROM dbo.Hang
	JOIN Deleted ON	Deleted.IDHang = Hang.ID
END
GO

CREATE TRIGGER trg_ThemCTHD
ON dbo.CTHD
FOR INSERT
AS
BEGIN
    UPDATE dbo.Hang SET	SoLuong = dbo.Hang.SoLuong - (SELECT SoLuong FROM Inserted WHERE IDHang = dbo.Hang.ID)
	FROM dbo.Hang
	JOIN Inserted ON	Inserted.IDHang = Hang.ID
END
GO


INSERT dbo.TaiKhoan
(
    TKhoan,
    MatKhau,
    Loai
)
VALUES
(   'admin',  -- TKhoan - varchar(100)
    '21232F297A57A5A743894A0E4A801FC3',  -- MatKhau - varchar(200)
    1 -- Loai - bit
    )
	GO