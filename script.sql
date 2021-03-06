CREATE DATABASE QLTHUVIEN
GO 
USE QLTHUVIEN
GO
/****** Object:  UserDefinedFunction [dbo].[ThongKeDG]    Script Date: 11/16/2018 10:14:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ThongKeDG]()
RETURNS @ret TABLE (MaDG CHAR(3),HoTen nvarchar(50), NgayLap date, TenSach nvarchar(50),NGAYMUON date,TinhTrang nvarchar(50),TraSach nvarchar(50),TongMuon int, slMuon int, slDung int, slTraMuon int )
AS
BEGIN
  DECLARE @t TABLE(Ma CHAR(3), slDang int) 
INSERT INTO @t SELECT MaDG,COUNT(*) FROM dbo.ThongKe WHERE [Tình trạng] =N'Đang mượn' GROUP BY MaDG

DECLARE @tt TABLE(Ma CHAR(3), slDung int) 
INSERT INTO @tt SELECT MaDG,COUNT(*) FROM dbo.ThongKe WHERE [Trả sách] = N'Trả đúng hạn' GROUP BY MaDG

DECLARE @ttt TABLE(Ma CHAR(3), slTraMuon int) 
INSERT INTO @ttt SELECT MaDG,COUNT(*) FROM dbo.ThongKe WHERE [Trả sách] = N'Trả muộn' GROUP BY MaDG

DECLARE @slmuon TABLE(Ma CHAR(3), slMuon int)
INSERT INTO @slmuon SELECT a.MaDG, COUNT(*) FROM dbo.DOCGIA a JOIN dbo.MUONSACH b ON a.MaDG = b.MADG LEFT JOIN dbo.CTMUONSACH c on b.MaPhieuMuon = c.MaPM GROUP BY a.MaDG 


INSERT INTO @ret SELECT b.*,(CASE WHEN m.slMuon is NULL THEN 0 ELSE m.slMuon END)AS 'Tổng mượn', 
		(CASE WHEN a.slDang is NULL THEN 0 ELSE a.slDang END)AS 'Đang Mượn', 
		(CASE WHEN c.slDung is NULL THEN 0 ELSE c.slDung END)AS 'Trả đúng hạn', 
		(CASE WHEN  d.slTraMuon is NULL THEN 0 ELSE  d.slTraMuon END)AS 'Trả Muộn'
	FROM ((dbo.ThongKe b LEFT JOIN @t a ON a.Ma =b.MaDG) LEFT JOIN @tt c ON b.MaDG =c.Ma) LEFT JOIN @ttt d ON b.MaDG = d.Ma LEFT JOIN @slmuon m ON b.MaDG = m.Ma

  RETURN;
END
GO
/****** Object:  Table [dbo].[BANGCAP]    Script Date: 11/16/2018 10:14:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BANGCAP](
	[MaBC] [char](3) NOT NULL,
	[TenBC] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BOPHAN]    Script Date: 11/16/2018 10:14:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BOPHAN](
	[MaBP] [char](3) NOT NULL,
	[TenBP] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 11/16/2018 10:14:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[MaCV] [char](3) NOT NULL,
	[TenCV] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CTMUONSACH]    Script Date: 11/16/2018 10:14:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CTMUONSACH](
	[MaPM] [int] NOT NULL,
	[SachMuon] [char](3) NOT NULL,
	[TinhTrang] [bit] NULL,
	[NgayTra] [datetime] NULL,
 CONSTRAINT [PK_CTMUONSACH] PRIMARY KEY CLUSTERED 
(
	[MaPM] ASC,
	[SachMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DOCGIA]    Script Date: 11/16/2018 10:14:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DOCGIA](
	[MaDG] [char](3) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[NgaySinh] [datetime] NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Email] [nvarchar](30) NULL,
	[LoaiDG] [char](4) NOT NULL,
	[NgayLap] [datetime] NOT NULL,
	[NVLap] [char](3) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAIDOCGIA]    Script Date: 11/16/2018 10:14:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOAIDOCGIA](
	[MaDG] [char](4) NOT NULL,
	[LoaiDG] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MUONSACH]    Script Date: 11/16/2018 10:14:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MUONSACH](
	[MaPhieuMuon] [int] IDENTITY(1,1) NOT NULL,
	[MADG] [char](3) NOT NULL,
	[NGAYMUON] [datetime] NOT NULL,
	[Han] [datetime] NULL,
 CONSTRAINT [PK__MUONSACH__C4C82222CB0D3AAF] PRIMARY KEY CLUSTERED 
(
	[MaPhieuMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 11/16/2018 10:14:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [char](3) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[NgaySinh] [datetime] NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Email] [nvarchar](30) NULL,
	[DienThoai] [nvarchar](14) NULL,
	[BangCap] [char](3) NOT NULL,
	[BoPhan] [char](3) NOT NULL,
	[ChucVu] [char](3) NOT NULL,
	[Account] [varchar](30) NOT NULL,
	[Pass] [varchar](20) NOT NULL,
 CONSTRAINT [PK__NHANVIEN__2725D70AD3E5C72C] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SACH]    Script Date: 11/16/2018 10:14:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SACH](
	[MaSach] [char](3) NOT NULL,
	[TenSach] [nvarchar](50) NOT NULL,
	[Loai] [char](2) NOT NULL,
	[TacGia] [nvarchar](30) NULL,
	[NamXB] [int] NULL,
	[NhaXB] [nvarchar](50) NULL,
	[NgayNhap] [datetime] NOT NULL,
	[TriGia] [money] NOT NULL,
	[NVTiepNhan] [char](3) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[THELOAISACH]    Script Date: 11/16/2018 10:14:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[THELOAISACH](
	[MaLoai] [char](2) NOT NULL,
	[TenTheLoai] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[THONGKEMUONSACH]    Script Date: 11/16/2018 10:14:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[THONGKEMUONSACH](
	[MaPM] [int] NOT NULL,
	[MaSach] [char](3) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPM] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[ThongKe]    Script Date: 11/16/2018 10:14:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ThongKe]
AS 
SELECT d.MaDG, d.HoTen,convert(date,d.NgayLap) AS 'NgayLap',s.TenSach, convert(date,m.NGAYMUON) AS 'NGAYMUON',(CASE WHEN TinhTrang = 1 THEN N'Đang mượn' ELSE N'Đã trả' END)AS 'Tình trạng',
		(CASE WHEN convert(date,NgayTra) > convert(date,m.Han) THEN N'Trả muộn' 
				WHEN convert(date,NgayTra) <= convert(date,m.Han) THEN N'Trả đúng hạn'
				WHEN  (ct.TinhTrang = 1 AND convert(date,m.Han) < convert(date,GETDATE())) THEN N'Đã quá hạn trả' 
				ELSE N'' END)AS 'Trả sách'
		FROM dbo.DOCGIA d FULL JOIN dbo.MUONSACH m ON d.MaDG = m.MADG LEFT JOIN dbo.CTMUONSACH ct on m.MaPhieuMuon = ct.MaPM LEFT JOIN dbo.SACH s ON  s.MaSach = ct.SachMuon
	
GO
INSERT [dbo].[BANGCAP] ([MaBC], [TenBC]) VALUES (N'BC1', N'Tú Tài')
INSERT [dbo].[BANGCAP] ([MaBC], [TenBC]) VALUES (N'BC2', N'Trung Cấp')
INSERT [dbo].[BANGCAP] ([MaBC], [TenBC]) VALUES (N'BC3', N'Cao Đẳng')
INSERT [dbo].[BANGCAP] ([MaBC], [TenBC]) VALUES (N'BC4', N'Đại Học')
INSERT [dbo].[BANGCAP] ([MaBC], [TenBC]) VALUES (N'BC5', N'Thạc Sĩ')
INSERT [dbo].[BANGCAP] ([MaBC], [TenBC]) VALUES (N'BC6', N'Tiến Sĩ')
INSERT [dbo].[BOPHAN] ([MaBP], [TenBP]) VALUES (N'BP1', N'Thủ Thư')
INSERT [dbo].[BOPHAN] ([MaBP], [TenBP]) VALUES (N'BP2', N'Thủ Kho')
INSERT [dbo].[BOPHAN] ([MaBP], [TenBP]) VALUES (N'BP3', N'Thủ Quỹ')
INSERT [dbo].[BOPHAN] ([MaBP], [TenBP]) VALUES (N'BP4', N'Ban Giám Đốc')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV1', N'Giám Đốc')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV2', N'Phó Giám Đốc')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV3', N'Trưởng Phòng')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV4', N'Phó Phòng')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV5', N'Nhân Viên')
INSERT [dbo].[CTMUONSACH] ([MaPM], [SachMuon], [TinhTrang], [NgayTra]) VALUES (11, N'001', 0, CAST(N'2018-11-08 19:10:05.610' AS DateTime))
INSERT [dbo].[CTMUONSACH] ([MaPM], [SachMuon], [TinhTrang], [NgayTra]) VALUES (11, N'002', 1, NULL)
INSERT [dbo].[CTMUONSACH] ([MaPM], [SachMuon], [TinhTrang], [NgayTra]) VALUES (12, N'003', 1, NULL)
INSERT [dbo].[CTMUONSACH] ([MaPM], [SachMuon], [TinhTrang], [NgayTra]) VALUES (13, N'005', 1, NULL)
INSERT [dbo].[CTMUONSACH] ([MaPM], [SachMuon], [TinhTrang], [NgayTra]) VALUES (14, N'006', 1, NULL)
INSERT [dbo].[DOCGIA] ([MaDG], [HoTen], [NgaySinh], [DiaChi], [Email], [LoaiDG], [NgayLap], [NVLap]) VALUES (N'D01', N'Nguyễn Thanh Minh', CAST(N'1982-01-02 00:00:00.000' AS DateTime), N'Bình Dương', N'tttt@gmail.com', N'DGL1', CAST(N'2018-07-05 00:00:00.000' AS DateTime), N'177')
INSERT [dbo].[DOCGIA] ([MaDG], [HoTen], [NgaySinh], [DiaChi], [Email], [LoaiDG], [NgayLap], [NVLap]) VALUES (N'D02', N'Mai Thanh Phươn', CAST(N'1983-12-19 00:00:00.000' AS DateTime), N'Bình Dương', N'yhv@gmail.com', N'DGL1', CAST(N'2017-07-16 00:00:00.000' AS DateTime), N'177')
INSERT [dbo].[DOCGIA] ([MaDG], [HoTen], [NgaySinh], [DiaChi], [Email], [LoaiDG], [NgayLap], [NVLap]) VALUES (N'D03', N'Đỗ Thanh', CAST(N'1997-12-06 00:00:00.000' AS DateTime), N'Đà Nẵng', N'yqp@gmail.com', N'DGL1', CAST(N'2017-06-14 00:00:00.000' AS DateTime), N'177')
INSERT [dbo].[DOCGIA] ([MaDG], [HoTen], [NgaySinh], [DiaChi], [Email], [LoaiDG], [NgayLap], [NVLap]) VALUES (N'D04', N'Phạm Quyên', CAST(N'1999-02-12 00:00:00.000' AS DateTime), N'Thuận AN', N'pqq@gmail.com', N'DGL2', CAST(N'2017-09-11 00:00:00.000' AS DateTime), N'177')
INSERT [dbo].[DOCGIA] ([MaDG], [HoTen], [NgaySinh], [DiaChi], [Email], [LoaiDG], [NgayLap], [NVLap]) VALUES (N'D05', N'Lê Kiên', CAST(N'1981-03-12 00:00:00.000' AS DateTime), N'Phú Giáo', N'lil@gmail.com', N'DGL1', CAST(N'2017-06-13 00:00:00.000' AS DateTime), N'123')
INSERT [dbo].[DOCGIA] ([MaDG], [HoTen], [NgaySinh], [DiaChi], [Email], [LoaiDG], [NgayLap], [NVLap]) VALUES (N'D06', N'Võ Đức', CAST(N'1991-05-19 00:00:00.000' AS DateTime), N'TPHCM', N'vd@gmail.com', N'DGL1', CAST(N'2017-07-11 00:00:00.000' AS DateTime), N'123')
INSERT [dbo].[DOCGIA] ([MaDG], [HoTen], [NgaySinh], [DiaChi], [Email], [LoaiDG], [NgayLap], [NVLap]) VALUES (N'D07', N'Mỹ Lệ', CAST(N'1998-12-16 00:00:00.000' AS DateTime), N'Trà Vinh', N'ml@gmail.com', N'DGL2', CAST(N'2017-09-22 00:00:00.000' AS DateTime), N'123')
INSERT [dbo].[DOCGIA] ([MaDG], [HoTen], [NgaySinh], [DiaChi], [Email], [LoaiDG], [NgayLap], [NVLap]) VALUES (N'D08', N'Lê Hưng', CAST(N'1999-11-20 00:00:00.000' AS DateTime), N'Bình Dương', N'lngh@gmail.com', N'DGl2', CAST(N'2017-06-12 00:00:00.000' AS DateTime), N'184')
INSERT [dbo].[DOCGIA] ([MaDG], [HoTen], [NgaySinh], [DiaChi], [Email], [LoaiDG], [NgayLap], [NVLap]) VALUES (N'D09', N'Vũ Hán', CAST(N'1999-02-19 00:00:00.000' AS DateTime), N'TPHCM', N'vha@gmail.com', N'DGL2', CAST(N'2017-08-19 00:00:00.000' AS DateTime), N'184')
INSERT [dbo].[DOCGIA] ([MaDG], [HoTen], [NgaySinh], [DiaChi], [Email], [LoaiDG], [NgayLap], [NVLap]) VALUES (N'D10', N'Tịnh Yên', CAST(N'1998-04-15 00:00:00.000' AS DateTime), N'Tân Uyên', N'ty@gmail.com', N'DGL2', CAST(N'2017-10-01 00:00:00.000' AS DateTime), N'184')
INSERT [dbo].[LOAIDOCGIA] ([MaDG], [LoaiDG]) VALUES (N'DGL1', N'Thanh Thiếu Niên')
INSERT [dbo].[LOAIDOCGIA] ([MaDG], [LoaiDG]) VALUES (N'DGL2', N'Thiếu Nhi')
SET IDENTITY_INSERT [dbo].[MUONSACH] ON 

INSERT [dbo].[MUONSACH] ([MaPhieuMuon], [MADG], [NGAYMUON], [Han]) VALUES (11, N'D01', CAST(N'2018-11-07 19:10:05.610' AS DateTime), CAST(N'2018-11-08 19:10:05.610' AS DateTime))
INSERT [dbo].[MUONSACH] ([MaPhieuMuon], [MADG], [NGAYMUON], [Han]) VALUES (12, N'D01', CAST(N'2018-11-07 19:39:08.380' AS DateTime), CAST(N'2018-11-11 19:39:08.380' AS DateTime))
INSERT [dbo].[MUONSACH] ([MaPhieuMuon], [MADG], [NGAYMUON], [Han]) VALUES (13, N'D02', CAST(N'2018-11-08 18:25:09.570' AS DateTime), CAST(N'2018-11-12 18:25:09.570' AS DateTime))
INSERT [dbo].[MUONSACH] ([MaPhieuMuon], [MADG], [NGAYMUON], [Han]) VALUES (14, N'D01', CAST(N'2018-11-08 18:26:02.053' AS DateTime), CAST(N'2018-11-12 18:26:02.053' AS DateTime))
SET IDENTITY_INSERT [dbo].[MUONSACH] OFF
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [Email], [DienThoai], [BangCap], [BoPhan], [ChucVu], [Account], [Pass]) VALUES (N'112', N'Lê Thị Hoa', CAST(N'1989-12-12 00:00:00.000' AS DateTime), N'Quãng Bình', N'lth@gmail.com', N'12345678987', N'BC3', N'BP3', N'CV3', N'lethihoa', N'12345')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [Email], [DienThoai], [BangCap], [BoPhan], [ChucVu], [Account], [Pass]) VALUES (N'123', N'Phan Thế Hiển', CAST(N'1986-11-01 00:00:00.000' AS DateTime), N'Nha Trang', N'pth@gmail.com', N'12345679876', N'BC1', N'BP1', N'CV5', N'phanthehien', N'12345')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [Email], [DienThoai], [BangCap], [BoPhan], [ChucVu], [Account], [Pass]) VALUES (N'133', N'Hoàng Minh', CAST(N'1989-12-11 00:00:00.000' AS DateTime), N'Buôn Ma Thuộc', N'hm@gmail.com', N'45677654321', N'BC2', N'BP2', N'CV4', N'hoangminh', N'12345')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [Email], [DienThoai], [BangCap], [BoPhan], [ChucVu], [Account], [Pass]) VALUES (N'155', N'Dương Thị Tùng', CAST(N'1977-10-10 00:00:00.000' AS DateTime), N'TPHCM', N'dtt@gmail.com', N'0983821987', N'BC6', N'BP4', N'CV2', N'duongthitung', N'12345')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [Email], [DienThoai], [BangCap], [BoPhan], [ChucVu], [Account], [Pass]) VALUES (N'159', N'Nguyễn Thanh Tâm', CAST(N'1983-03-11 00:00:00.000' AS DateTime), N'Nam ĐỊnh', N'ntt@gmail.com', N'45678998765', N'BC3', N'BP2', N'CV3', N'nguyenthanh', N'12345')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [Email], [DienThoai], [BangCap], [BoPhan], [ChucVu], [Account], [Pass]) VALUES (N'177', N'Mai Thanh Ngân', CAST(N'1982-11-04 00:00:00.000' AS DateTime), N'Bắc Giang', N'mtn@gmail.com', N'34548913774', N'BC2', N'BP1', N'CV4', N'maithanhngan', N'12345')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [Email], [DienThoai], [BangCap], [BoPhan], [ChucVu], [Account], [Pass]) VALUES (N'179', N'Nguyễn Khắc Sơn', CAST(N'1978-03-12 00:00:00.000' AS DateTime), N'Hà Nội', N'nks@gmail.com', N'0905224243', N'BC4', N'BP4', N'CV3', N'nguyenkhac', N'12345')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [Email], [DienThoai], [BangCap], [BoPhan], [ChucVu], [Account], [Pass]) VALUES (N'184', N'Lê Vĩnh Phúc', CAST(N'1985-07-03 00:00:00.000' AS DateTime), N'Tây Ninh', N'lvp@gmail.com', N'87654334567', N'BC2', N'BP1', N'CV5', N'levinhphuc', N'12345')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [Email], [DienThoai], [BangCap], [BoPhan], [ChucVu], [Account], [Pass]) VALUES (N'333', N'Nguyễn Khắc Sinh', CAST(N'1975-12-11 00:00:00.000' AS DateTime), N'Bình Dương', N'nks@gmail.com', N'45678987654', N'BC2', N'BP2', N'CV4', N'nguyenkhacsinh', N'12345')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [Loai], [TacGia], [NamXB], [NhaXB], [NgayNhap], [TriGia], [NVTiepNhan]) VALUES (N'001', N'Mẹ Ghẻ Con Ghẻ', N'L1', N'Hồ Biểu Chánh', 2011, N'NXB Văn hóa - Nghệ thuật', CAST(N'2012-05-24 00:00:00.000' AS DateTime), 52000.0000, N'133')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [Loai], [TacGia], [NamXB], [NhaXB], [NgayNhap], [TriGia], [NVTiepNhan]) VALUES (N'002', N'Gữi Những Năm Tháng Từng Bên', N'L2', N'Decworm', 2010, N'NXB Thế giới', CAST(N'2011-08-04 00:00:00.000' AS DateTime), 60000.0000, N'133')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [Loai], [TacGia], [NamXB], [NhaXB], [NgayNhap], [TriGia], [NVTiepNhan]) VALUES (N'003', N'Bức Thư Tỉnh Ủy', N'L1', N'Vân Thảo', 2013, N'NXB Trẻ', CAST(N'2015-06-08 00:00:00.000' AS DateTime), 70000.0000, N'159')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [Loai], [TacGia], [NamXB], [NhaXB], [NgayNhap], [TriGia], [NVTiepNhan]) VALUES (N'004', N'Cổ Tích Việt Nam Hay Nhất', N'L3', NULL, 2011, N'NXB Văn Học', CAST(N'2013-06-22 00:00:00.000' AS DateTime), 50000.0000, N'333')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [Loai], [TacGia], [NamXB], [NhaXB], [NgayNhap], [TriGia], [NVTiepNhan]) VALUES (N'005', N'Cách Tân Nghệ Thuật Văn Học', N'L1', N'Phùng Văn Tửu', 2014, N'NXB Văn học', CAST(N'2015-08-19 00:00:00.000' AS DateTime), 50000.0000, N'159')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [Loai], [TacGia], [NamXB], [NhaXB], [NgayNhap], [TriGia], [NVTiepNhan]) VALUES (N'006', N'Tam Sinh Tâm Thế - Thập Lý Đào Hoa', N'L2', N'Đường Thấp Công Tử', 2012, N'NXB Thế giới', CAST(N'2014-07-13 00:00:00.000' AS DateTime), 74000.0000, N'133')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [Loai], [TacGia], [NamXB], [NhaXB], [NgayNhap], [TriGia], [NVTiepNhan]) VALUES (N'007', N'Tớ Là Mèo Pusheen', N'L3', N'Claire Belton', 2009, N'NXB Trẻ', CAST(N'2013-10-12 00:00:00.000' AS DateTime), 80000.0000, N'159')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [Loai], [TacGia], [NamXB], [NhaXB], [NgayNhap], [TriGia], [NVTiepNhan]) VALUES (N'008', N'Con Yêu Bố Chừng Nào', N'L3', N'Sam McBratney', 2012, N'NXB Văn Học', CAST(N'2015-09-19 00:00:00.000' AS DateTime), 55000.0000, N'333')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [Loai], [TacGia], [NamXB], [NhaXB], [NgayNhap], [TriGia], [NVTiepNhan]) VALUES (N'009', N'Bên Nhau Trọn Đời', N'L2', N'Cố Mạn', 2010, N'NXB Văn Hóa - Nghệ Thuật', CAST(N'2014-06-17 00:00:00.000' AS DateTime), 75000.0000, N'333')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [Loai], [TacGia], [NamXB], [NhaXB], [NgayNhap], [TriGia], [NVTiepNhan]) VALUES (N'010', N'Góc Nhìn Sử Việt', N'L1', N'Hoàng Thị Thế', 2013, N'NXB Khoa Học Xã Hội', CAST(N'2015-12-18 00:00:00.000' AS DateTime), 65000.0000, N'159')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [Loai], [TacGia], [NamXB], [NhaXB], [NgayNhap], [TriGia], [NVTiepNhan]) VALUES (N'011', N'Vì Vợ Là Vợ Anh', N'L2', N'Lan Rùa', 2015, N'NXB  Phụ nữ', CAST(N'2016-09-25 00:00:00.000' AS DateTime), 45000.0000, N'133')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [Loai], [TacGia], [NamXB], [NhaXB], [NgayNhap], [TriGia], [NVTiepNhan]) VALUES (N'012', N'Chú Vịt Con Xấu Xí', N'L3', N'Hans Chirstian Andersen', 2010, N'NXB Thiếu Nhi', CAST(N'2014-05-19 00:00:00.000' AS DateTime), 40000.0000, N'159')
INSERT [dbo].[THELOAISACH] ([MaLoai], [TenTheLoai]) VALUES (N'L1', N'Văn Học')
INSERT [dbo].[THELOAISACH] ([MaLoai], [TenTheLoai]) VALUES (N'L2', N'Tiểu thuyết')
INSERT [dbo].[THELOAISACH] ([MaLoai], [TenTheLoai]) VALUES (N'L3', N'Truyện Thiếu Nhi')
ALTER TABLE [dbo].[CTMUONSACH]  WITH CHECK ADD FOREIGN KEY([SachMuon])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[CTMUONSACH]  WITH CHECK ADD  CONSTRAINT [FK__CTMUONSACH__MaPM__2D27B809] FOREIGN KEY([MaPM])
REFERENCES [dbo].[MUONSACH] ([MaPhieuMuon])
GO
ALTER TABLE [dbo].[CTMUONSACH] CHECK CONSTRAINT [FK__CTMUONSACH__MaPM__2D27B809]
GO
ALTER TABLE [dbo].[DOCGIA]  WITH CHECK ADD FOREIGN KEY([LoaiDG])
REFERENCES [dbo].[LOAIDOCGIA] ([MaDG])
GO
ALTER TABLE [dbo].[DOCGIA]  WITH CHECK ADD  CONSTRAINT [FK__DOCGIA__NVLap__1FCDBCEB] FOREIGN KEY([NVLap])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[DOCGIA] CHECK CONSTRAINT [FK__DOCGIA__NVLap__1FCDBCEB]
GO
ALTER TABLE [dbo].[MUONSACH]  WITH CHECK ADD  CONSTRAINT [FK__MUONSACH__MADG__267ABA7A] FOREIGN KEY([MADG])
REFERENCES [dbo].[DOCGIA] ([MaDG])
GO
ALTER TABLE [dbo].[MUONSACH] CHECK CONSTRAINT [FK__MUONSACH__MADG__267ABA7A]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK__NHANVIEN__BangCa__1A14E395] FOREIGN KEY([BangCap])
REFERENCES [dbo].[BANGCAP] ([MaBC])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK__NHANVIEN__BangCa__1A14E395]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK__NHANVIEN__BoPhan__1B0907CE] FOREIGN KEY([BoPhan])
REFERENCES [dbo].[BOPHAN] ([MaBP])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK__NHANVIEN__BoPhan__1B0907CE]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK__NHANVIEN__ChucVu__1BFD2C07] FOREIGN KEY([ChucVu])
REFERENCES [dbo].[CHUCVU] ([MaCV])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK__NHANVIEN__ChucVu__1BFD2C07]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD FOREIGN KEY([Loai])
REFERENCES [dbo].[THELOAISACH] ([MaLoai])
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK__SACH__NVTiepNhan__239E4DCF] FOREIGN KEY([NVTiepNhan])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK__SACH__NVTiepNhan__239E4DCF]
GO
ALTER TABLE [dbo].[THONGKEMUONSACH]  WITH CHECK ADD FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[THONGKEMUONSACH]  WITH CHECK ADD  CONSTRAINT [FK__THONGKEMUO__MaPM__29572725] FOREIGN KEY([MaPM])
REFERENCES [dbo].[MUONSACH] ([MaPhieuMuon])
GO
ALTER TABLE [dbo].[THONGKEMUONSACH] CHECK CONSTRAINT [FK__THONGKEMUO__MaPM__29572725]
GO
/****** Object:  StoredProcedure [dbo].[PhieuMuonSach]    Script Date: 11/16/2018 10:14:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PhieuMuonSach]
 @xml XML, @MaDG CHAR(3)
 AS 
	DECLARE @kqua NVARCHAR(100)
	DECLARE @SachMuonQuaHan INT = (SELECT COUNT(*) FROM dbo.MUONSACH a, dbo.CTMUONSACH b WHERE a.MaPhieuMuon = b.MaPM AND a.MADG = @MaDG AND a.Han < GETDATE() AND b.TinhTrang = 1)
	DECLARE @SoSachDgMuon INT =(SELECT COUNT(*) FROM dbo.MUONSACH a, dbo.CTMUONSACH b WHERE a.MaPhieuMuon = b.MaPM AND b.TinhTrang = 1 AND a.MADG = @MaDG)
	DECLARE @HanThe DATETIME = DATEADD(month, 6, (SELECT NgayLap FROM dbo.DOCGIA WHERE MaDG = @MaDG))
	IF(@HanThe < GETDATE() OR @SachMuonQuaHan > 0 OR @SoSachDgMuon >= 5)
		BEGIN
			SET @kqua = N'Độc giả không thể mượn!'
			SELECT @kqua
		END
	ELSE
		BEGIN
			INSERT INTO dbo.MUONSACH VALUES (@MaDG, GETDATE(), GETDATE()+4)
			DECLARE @mapn INT = (SELECT TOP 1 MaPhieuMuon FROM dbo.MUONSACH ORDER BY MaPhieuMuon DESC)
			DECLARE @table TABLE (MaSach CHAR(3))
			INSERT INTO @table SELECT MaSachs.maSach.value('.','char(3)') AS MaSach FROM @xml.nodes('Root/ID') AS MaSachs(maSach)
			INSERT INTO dbo.CTMUONSACH SELECT @mapn, MaSach, 1 FROM @table
			
			SET @kqua = N'Mượn thành công!'
			SELECT @kqua
		END

GO
/****** Object:  StoredProcedure [dbo].[SelectAllDocGia]    Script Date: 11/16/2018 10:14:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SelectAllDocGia]
as
select MaDG AS 'Mã độc giả', HoTen AS 'Họ và tên', convert(date,NgaySinh) AS 'Ngày Sinh', 
		DiaChi AS 'Địa chỉ', Email, LoaiDG AS 'Loại ĐG', convert(date,NgayLap) AS'Ngày lập', 
		NVLap AS 'NV lập'  from DOCGIA
GO
/****** Object:  StoredProcedure [dbo].[SelectAllNhanVien]    Script Date: 11/16/2018 10:14:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SelectAllNhanVien]
as
SELECT MaNV AS 'Mã Nhân Viên', HoTen AS 'Họ và tên', convert(date,NgaySinh) AS 'Ngày sinh', DiaChi AS 'Địa chỉ',
		Email, DienThoai AS 'Điện thoại', BangCap AS 'Bằng cấp', BoPhan AS 'Bộ phận', ChucVu AS 'Chức vụ', Account, Pass 
		FROM dbo.NHANVIEN
GO
/****** Object:  StoredProcedure [dbo].[SelectAllSach]    Script Date: 11/16/2018 10:14:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SelectAllSach]
AS 
SELECT MaSach AS 'Mã Sách', TenSach AS 'Tên sách', Loai AS 'Loại sách', TacGia AS 'Tác giả',
		NamXB AS 'Năm XB', NhaXB AS 'Nhà XB', convert(date,NgayNhap) AS 'Ngày nhập', TriGia AS 'Trị giá', 
		NVTiepNhan AS 'NV tiếp nhận' FROM dbo.SACH
GO
/****** Object:  StoredProcedure [dbo].[XoaSach]    Script Date: 11/16/2018 10:14:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[XoaSach]
@maSach CHAR(3)
AS
	DECLARE @kqua NVARCHAR(100)
	DECLARE @sl INT = (SELECT COUNT(*) FROM dbo.CTMUONSACH WHERE TinhTrang = 1 AND SachMuon = @maSach)
	IF(@sl > 0)
		BEGIN
			SET @kqua =N'Sách còn đang mượn!'
			SELECT @kqua
		END
	ELSE
		BEGIN
			DELETE dbo.CTMUONSACH WHERE SachMuon = @maSach
		    DELETE dbo.SACH WHERE MaSach = @maSach
			SET @kqua =N'Xóa thành công!'
			SELECT @kqua
		END
GO
