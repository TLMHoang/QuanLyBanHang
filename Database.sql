USE [QLBH]
GO
/****** Object:  Table [dbo].[CTHD]    Script Date: 1/11/2020 12:44:28 PM ******/
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
/****** Object:  Table [dbo].[Hang]    Script Date: 1/11/2020 12:44:28 PM ******/
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
/****** Object:  Table [dbo].[HoaDon]    Script Date: 1/11/2020 12:44:28 PM ******/
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
/****** Object:  Table [dbo].[KhachHang]    Script Date: 1/11/2020 12:44:28 PM ******/
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
/****** Object:  Table [dbo].[NhanVien]    Script Date: 1/11/2020 12:44:28 PM ******/
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
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 1/11/2020 12:44:28 PM ******/
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
SET IDENTITY_INSERT [dbo].[Hang] OFF
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([ID], [Ten]) VALUES (1, N'A')
INSERT [dbo].[NhanVien] ([ID], [Ten]) VALUES (2, N'Trần Văn B')
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
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
/****** Object:  StoredProcedure [dbo].[DangNhap]    Script Date: 1/11/2020 12:44:28 PM ******/
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
/****** Object:  StoredProcedure [dbo].[LayCTHD]    Script Date: 1/11/2020 12:44:28 PM ******/
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
/****** Object:  StoredProcedure [dbo].[LayCTHDID]    Script Date: 1/11/2020 12:44:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LayCTHDID]
@IDHoaDon INT
AS
SELECT * FROM dbo.CTHD WHERE IDHoaDon = @IDHoaDon
GO
/****** Object:  StoredProcedure [dbo].[LayHang]    Script Date: 1/11/2020 12:44:28 PM ******/
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
/****** Object:  StoredProcedure [dbo].[LayHoaDon]    Script Date: 1/11/2020 12:44:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LayHoaDon]
AS
	SELECT * FROM dbo.HoaDon
GO
/****** Object:  StoredProcedure [dbo].[LayHoaDonNoF]    Script Date: 1/11/2020 12:44:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[LayHoaDonNoF]
AS
SELECT * FROM dbo.HoaDon WHERE TinhTrang = 1
GO
/****** Object:  StoredProcedure [dbo].[LayKhachHang]    Script Date: 1/11/2020 12:44:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[LayKhachHang]
AS
	SELECT * FROM dbo.KhachHang

GO
/****** Object:  StoredProcedure [dbo].[LayNhanVien]    Script Date: 1/11/2020 12:44:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[LayNhanVien]
AS
	SELECT * FROM dbo.NhanVien

GO
/****** Object:  StoredProcedure [dbo].[LayTaiKhoan]    Script Date: 1/11/2020 12:44:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[LayTaiKhoan]
AS
SELECT * FROM dbo.TaiKhoan
GO
/****** Object:  StoredProcedure [dbo].[SuaCTHD]    Script Date: 1/11/2020 12:44:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SuaCTHD]
@IDHoaDon INT,
@IDHang INT,
@SoLuong INT
AS
UPDATE dbo.CTHD SET
    SoLuong = @SoLuong  -- SoLuong - int
    WHERE IDHoaDon = @IDHoaDon AND IDHang = @IDHang
GO
/****** Object:  StoredProcedure [dbo].[SuaHang]    Script Date: 1/11/2020 12:44:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- proc sua

CREATE PROCEDURE [dbo].[SuaHang]
@ID INT,
@TenHang NVARCHAR(200),
@GiaBan INT,
@GiaSi INT,
@GiaNhap INT,
@SoLuong INT
AS
UPDATE dbo.Hang SET
	    TenHang = @TenHang, -- TenHang - nvarchar(200)
		GiaBan = @GiaBan,
		GiaSi = @GiaSi,
		GiaNhap = @GiaNhap,
	    SoLuong = @SoLuong    -- SoLuong - int
WHERE ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[SuaHoaDon]    Script Date: 1/11/2020 12:44:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SuaHoaDon]
@ID INT,
@IDKhachHang INT,
@IDNhanVien INT,
@Ngay DATETIME,
@TinhTrang BIT,
@CheckNull BIT	
AS
UPDATE dbo.HoaDon SET
    IDKhacHang = @IDKhachHang,         -- IDKhacHang - int
    IDNhanVien = @IDNhanVien,         -- IDNhanVien - int
    Ngay = @Ngay, -- Ngay - datetime
    TinhTrang = @TinhTrang      , -- TinhTrang - bit
	CheckNull = @CheckNull
WHERE ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[SuaKhachHang]    Script Date: 1/11/2020 12:44:28 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SuaNhanVien]    Script Date: 1/11/2020 12:44:28 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SuaTaiKhoan]    Script Date: 1/11/2020 12:44:28 PM ******/
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
/****** Object:  StoredProcedure [dbo].[ThemCTHD]    Script Date: 1/11/2020 12:44:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[ThemCTHD]
@IDHoaDon INT,
@IDHang INT,
@SoLuong INT,
@Tang BIT,
@GiaSi BIT
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
/****** Object:  StoredProcedure [dbo].[ThemHang]    Script Date: 1/11/2020 12:44:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



--proc Them

CREATE PROCEDURE [dbo].[ThemHang]
@ID INT,
@TenHang NVARCHAR(200),
@GiaBan INT,
@GiaSi INT,
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
			GiaSi,
			GiaNhap,
		    SoLuong
			
		)
		VALUES
		(   
			@TenHang, -- TenHang - nvarchar(200)
			@GiaBan, -- GiaBan - int
			@GiaSi, -- GiaSi - int
			@GiaNhap,  -- GiaNhap - int
			@SoLuong    -- SoLuong - int
	    )
	END
END

GO
/****** Object:  StoredProcedure [dbo].[ThemHoaDon]    Script Date: 1/11/2020 12:44:28 PM ******/
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
/****** Object:  StoredProcedure [dbo].[ThemKhachHang]    Script Date: 1/11/2020 12:44:28 PM ******/
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
/****** Object:  StoredProcedure [dbo].[ThemNhanVien]    Script Date: 1/11/2020 12:44:28 PM ******/
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
/****** Object:  StoredProcedure [dbo].[ThemTaiKhoan]    Script Date: 1/11/2020 12:44:28 PM ******/
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
/****** Object:  StoredProcedure [dbo].[XoaCTHD]    Script Date: 1/11/2020 12:44:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[XoaCTHD]
@IDHoaDon INT
AS
DELETE FROM dbo.CTHD WHERE IDHoaDon = @IDHoaDon
GO
/****** Object:  StoredProcedure [dbo].[XoaHang]    Script Date: 1/11/2020 12:44:28 PM ******/
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
/****** Object:  StoredProcedure [dbo].[XoaHoaDon]    Script Date: 1/11/2020 12:44:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[XoaHoaDon]
@ID INT
AS
BEGIN
	EXEC dbo.XoaCTHD @IDHoaDon = @ID -- int
    DELETE FROM dbo.HoaDon WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [dbo].[XoaKhachHang]    Script Date: 1/11/2020 12:44:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[XoaKhachHang]
@ID INT
AS
DELETE FROM dbo.KhachHang WHERE ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[XoaNhanVien]    Script Date: 1/11/2020 12:44:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[XoaNhanVien]  
@ID INT
AS
DELETE FROM dbo.NhanVien WHERE ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[XoaTaiKhoan]    Script Date: 1/11/2020 12:44:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[XoaTaiKhoan]
@ID INT
AS
DELETE FROM dbo.TaiKhoan WHERE ID = @ID
GO
