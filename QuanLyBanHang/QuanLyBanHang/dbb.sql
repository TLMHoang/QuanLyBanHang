CREATE DATABASE QLBH
GO

USE QLBH
GO

CREATE TABLE TaiKhoan
(
	ID INT IDENTITY(1,1),
	TKhoan VARCHAR(100),
	MatKhau VARCHAR(200),
	Loai BIT

	PRIMARY KEY(ID,TKhoan) 
)
GO	


CREATE TABLE Hang
(
	ID INT IDENTITY(1,1),
	TenHang NVARCHAR(200),
	GiaBan INT,
	GiaNhap INT,
	SoLuong INT

	PRIMARY KEY(ID),
)
GO

CREATE TABLE KhachHang
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	TenKH NVARCHAR(200),
	SDT VARCHAR(20),
	DiaChi NVARCHAR(300)

)
GO

CREATE TABLE NhanVien
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	Ten NVARCHAR(200)
)
GO	

CREATE TABLE HoaDon
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	IDKhacHang INT,
	IDNhanVien INT,
	Ngay DATETIME,
	TongTien INT DEFAULT 0,
	TinhTrang BIT DEFAULT 0,
	CheckNull BIT DEFAULT 1

	FOREIGN KEY(IDKhacHang) REFERENCES dbo.KhachHang(ID),
	FOREIGN KEY(IDNhanVien) REFERENCES dbo.NhanVien(ID)
)
GO

CREATE TABLE CTHD
(
	IDHoaDon INT,
	IDHang INT,
	SoLuong INT,
	Tang BIT,
	GiaSi INT	

	FOREIGN KEY(IDHoaDon) REFERENCES dbo.HoaDon(ID),
	FOREIGN KEY(IDHang) REFERENCES dbo.Hang(ID)
)
GO


-- trigger

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

--Procedure Lay
CREATE PROCEDURE LayHang   
AS
BEGIN
    SELECT * FROM dbo.Hang
END
GO

CREATE PROCEDURE LayCTHD
AS
BEGIN
	SELECT * FROM dbo.CTHD
END

GO

CREATE PROCEDURE LayHoaDon
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

CREATE PROCEDURE LayKhachHang
AS
	SELECT * FROM dbo.KhachHang

GO

CREATE PROCEDURE LayNhanVien
AS
	SELECT * FROM dbo.NhanVien

GO

CREATE PROCEDURE LayTaiKhoan
AS
SELECT * FROM dbo.TaiKhoan
GO


--proc Them

CREATE PROCEDURE ThemHang
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




CREATE PROCEDURE ThemCTHD
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

CREATE PROCEDURE ThemHoaDon
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


CREATE PROCEDURE ThemKhachHang
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

CREATE PROCEDURE ThemNhanVien  
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

ALTER PROCEDURE ThemTaiKhoan
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
	--UPDATE dbo.TaiKhoan SET MatKhau = CONVERT(VARCHAR(32), HASHBYTES('MD5', @MatKhau), 2) WHERE MatKhau = @MatKhau AND TKhoan = @TKhoan
	DECLARE @I INT = (SELECT ID FROM dbo.TaiKhoan WHERE MatKhau = @MatKhau AND TKhoan = @TKhoan)

	EXEC dbo.SuaTaiKhoan @ID = @I,       -- int
	                     @MatKhau = @TKhoan, -- varchar(200)
	                     @Loai = 0   -- bit
	
END
GO


-- proc xoa

CREATE PROCEDURE XoaHang
@ID INT
AS
DELETE FROM dbo.Hang WHERE ID = @ID
GO

CREATE PROCEDURE XoaCTHD
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

CREATE PROCEDURE XoaHoaDon
@ID INT
AS
BEGIN
	EXEC dbo.XoaShip @IDHoaDon = @ID -- int
    DELETE FROM dbo.HoaDon WHERE ID = @ID
END

GO

CREATE PROCEDURE XoaKhachHang
@ID INT
AS
DELETE FROM dbo.KhachHang WHERE ID = @ID
GO

CREATE PROCEDURE XoaNhanVien  
@ID INT
AS
DELETE FROM dbo.NhanVien WHERE ID = @ID
GO

CREATE PROCEDURE XoaTaiKhoan
@ID INT
AS
DELETE FROM dbo.TaiKhoan WHERE ID = @ID
GO

-- proc sua

CREATE PROCEDURE SuaHang
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

CREATE PROCEDURE SuaCTHD
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

CREATE PROCEDURE SuaHoaDon
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

CREATE PROCEDURE SuaKhachHang
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

CREATE PROCEDURE SuaNhanVien  
@ID INT,
@Ten NVARCHAR(200)
AS
UPDATE dbo.NhanVien SET
Ten = @Ten -- Ten - nvarchar(200)
WHERE ID = @ID
GO

CREATE PROCEDURE SuaTaiKhoan
@ID INT,
@MatKhau VARCHAR(200),
@Loai BIT
AS
UPDATE dbo.TaiKhoan SET
    MatKhau = CONVERT(VARCHAR(32), HASHBYTES('MD5', @MatKhau), 2),  -- MatKhau - varchar(200)
    Loai = @Loai -- Loai - bit
WHERE ID = @ID
GO


CREATE PROCEDURE DangNhap
@TaiKhoan VARCHAR(100),
@MatKhau VARCHAR(200)
AS
SELECT * FROM dbo.TaiKhoan WHERE TKhoan = @TaiKhoan AND MatKhau = CONVERT(VARCHAR(32),HASHBYTES('MD5', @MatKhau),2)
GO

CREATE PROCEDURE LayCTHDID
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

CREATE PROCEDURE LayCTHDCheck
@IDHoaDon INT,
@IDHang INT,
@Tang BIT
AS
BEGIN
    SELECT * FROM dbo.CTHD WHERE IDHoaDon = @IDHoaDon AND	 IDHang = @IDHang AND	Tang = @Tang
END
GO

CREATE PROCEDURE LayHoaDonNgay
@From DATETIME,
@To DATETIME
AS	
BEGIN
	    SELECT * FROM	dbo.HoaDon WHERE Ngay >= @From AND	Ngay <= @To
END
GO


CREATE PROCEDURE LayHoaDonNgayTT
@From DATETIME,
@To DATETIME,
@TinhTrang bit
AS	
BEGIN
	SELECT * FROM	dbo.HoaDon WHERE Ngay >= @From AND	Ngay <= @To AND	TinhTrang = @TinhTrang
END
GO	

CREATE TABLE Ship
(
	IDHoaDon INT,
	Nhan INT,
	Tra INT

	FOREIGN KEY (IDHoaDon) REFERENCES dbo.HoaDon(ID)
)
GO

CREATE PROCEDURE LayShip
@IDHoaDon INT
AS
BEGIN
    SELECT * FROM dbo.Ship WHERE IDHoaDon = @IDHoaDon
END
GO

CREATE PROCEDURE ThemShip
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

CREATE PROCEDURE SuaShip
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

EXEC dbo.SuaShip @IDHoaDon = 119, -- int
                 @Nhan = 50000,     -- int
                 @Tra = 0       -- int


CREATE PROCEDURE XoaShip
@IDHoaDon INT
AS
BEGIN
    DELETE FROM dbo.Ship WHERE IDHoaDon = @IDHoaDon
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

INSERT dbo.TaiKhoan
(
    TKhoan,
    MatKhau,
    Loai
)
VALUES
(   'test',  -- TKhoan - varchar(100)
    '21232F297A57A5A743894A0E4A801FC3',  -- MatKhau - varchar(200)
    0 -- Loai - bit
    )

DECLARE @IDHD INT
SET @IDHD = 4
DELETE TOP(1) FROM dbo.CTHD WHERE IDHoaDon = @IDHD
DELETE TOP(1) FROM dbo.CTHD WHERE IDHoaDon = @IDHD
DELETE TOP(1) FROM dbo.CTHD WHERE IDHoaDon = @IDHD
DELETE TOP(1) FROM dbo.CTHD WHERE IDHoaDon = @IDHD
DELETE TOP(1) FROM dbo.CTHD WHERE IDHoaDon = @IDHD
DELETE TOP(1) FROM dbo.CTHD WHERE IDHoaDon = @IDHD
DELETE TOP(1) FROM dbo.CTHD WHERE IDHoaDon = @IDHD
DELETE TOP(1) FROM dbo.CTHD WHERE IDHoaDon = @IDHD
EXEC dbo.XoaHoaDon @ID = @IDHD -- int

