USE [master]
GO
/****** Object:  Database [DB_PMTNLX_16_1_V1]    Script Date: 01/16/2018 1:11:46 PM ******/
CREATE DATABASE [DB_PMTNLX_16_1_V1] ON  PRIMARY 
( NAME = N'DB_PMTNLX_16_1_V1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\DB_PMTNLX_16_1_V1.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DB_PMTNLX_16_1_V1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\DB_PMTNLX_16_1_V1_log.LDF' , SIZE = 768KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DB_PMTNLX_16_1_V1] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_PMTNLX_16_1_V1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_PMTNLX_16_1_V1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_PMTNLX_16_1_V1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_PMTNLX_16_1_V1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_PMTNLX_16_1_V1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_PMTNLX_16_1_V1] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_PMTNLX_16_1_V1] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DB_PMTNLX_16_1_V1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_PMTNLX_16_1_V1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_PMTNLX_16_1_V1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_PMTNLX_16_1_V1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_PMTNLX_16_1_V1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_PMTNLX_16_1_V1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_PMTNLX_16_1_V1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_PMTNLX_16_1_V1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_PMTNLX_16_1_V1] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DB_PMTNLX_16_1_V1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_PMTNLX_16_1_V1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_PMTNLX_16_1_V1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_PMTNLX_16_1_V1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_PMTNLX_16_1_V1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_PMTNLX_16_1_V1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_PMTNLX_16_1_V1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_PMTNLX_16_1_V1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DB_PMTNLX_16_1_V1] SET  MULTI_USER 
GO
ALTER DATABASE [DB_PMTNLX_16_1_V1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_PMTNLX_16_1_V1] SET DB_CHAINING OFF 
GO
USE [DB_PMTNLX_16_1_V1]
GO
/****** Object:  Table [dbo].[CAUHOI]    Script Date: 01/16/2018 1:11:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CAUHOI](
	[QMCH] [int] NOT NULL,
	[QTCH] [ntext] NOT NULL,
	[QPIC] [image] NULL,
	[QDAD] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[QMCH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CTDETHI]    Script Date: 01/16/2018 1:11:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CTDETHI](
	[MDT] [varchar](5) NOT NULL,
	[QMCH] [int] NOT NULL,
	[STT] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MDT] ASC,
	[QMCH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DAPAN]    Script Date: 01/16/2018 1:11:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DAPAN](
	[AMDA] [varchar](5) NOT NULL,
	[ATDA] [ntext] NOT NULL,
	[QMCH] [int] NOT NULL,
	[DA] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AMDA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DETHI]    Script Date: 01/16/2018 1:11:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DETHI](
	[MDT] [varchar](5) NOT NULL,
	[TDT] [nvarchar](15) NOT NULL,
	[LOAI] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KETQUA]    Script Date: 01/16/2018 1:11:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KETQUA](
	[MND] [int] NOT NULL,
	[MKT] [int] NOT NULL,
	[MDT] [varchar](5) NOT NULL,
	[NGAYTHI] [smalldatetime] NULL,
	[DIEM] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MND] ASC,
	[MKT] ASC,
	[MDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KIEMTRA]    Script Date: 01/16/2018 1:11:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KIEMTRA](
	[MKT] [int] NOT NULL,
	[MND] [int] NOT NULL,
	[MDT] [varchar](5) NOT NULL,
	[NGAYTHI] [smalldatetime] NULL,
 CONSTRAINT [PK_KIEMTRA] PRIMARY KEY CLUSTERED 
(
	[MKT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NGUOIDUNG]    Script Date: 01/16/2018 1:11:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[NGUOIDUNG](
	[MND] [int] NOT NULL,
	[HO] [nvarchar](30) NOT NULL,
	[TEN] [nvarchar](7) NOT NULL,
	[NGAYSINH] [smalldatetime] NULL,
	[GIOITINH] [nvarchar](4) NOT NULL,
	[EMAIL] [nvarchar](30) NOT NULL,
	[TDN] [nvarchar](15) NOT NULL,
	[MK] [nvarchar](15) NOT NULL,
	[PQ] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[MND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TRALOIND]    Script Date: 01/16/2018 1:11:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TRALOIND](
	[MND] [int] NOT NULL,
	[MKT] [int] NOT NULL,
	[MDT] [varchar](5) NOT NULL,
	[QMCH] [int] NOT NULL,
	[MDAND] [char](1) NULL,
	[DANHGIA] [varchar](5) NULL,
 CONSTRAINT [PK__TRALOIND__69370FF5B3B6DB05] PRIMARY KEY CLUSTERED 
(
	[MND] ASC,
	[MKT] ASC,
	[MDT] ASC,
	[QMCH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CAUHOI] ([QMCH], [QTCH], [QPIC], [QDAD]) VALUES (1, N'“Phương tiện tham gia giao thông đường bộ” gồm những loại nào?', NULL, N'A')
INSERT [dbo].[CAUHOI] ([QMCH], [QTCH], [QPIC], [QDAD]) VALUES (2, N'“Người tham gia giao thông đường bộ” gồm những đối tượng nào?', NULL, N'A')
INSERT [dbo].[CAUHOI] ([QMCH], [QTCH], [QPIC], [QDAD]) VALUES (3, N'Khái niệm “người điều khiển giao thông” được hiểu như thế nào là đúng?', NULL, N'B')
INSERT [dbo].[CAUHOI] ([QMCH], [QTCH], [QPIC], [QDAD]) VALUES (4, N'Các hành vi nào ghi ở dưới đây bị nghiêm cấm?', NULL, N'A')
INSERT [dbo].[CAUHOI] ([QMCH], [QTCH], [QPIC], [QDAD]) VALUES (5, N'Những hành vi nào ghi ở dưới đây bị nghiêm cấm?', NULL, N'A')
INSERT [dbo].[CAUHOI] ([QMCH], [QTCH], [QPIC], [QDAD]) VALUES (6, N'Người điều khiển phương tiện giao thông đường bộ mà trong cơ thể có chất ma túy có bị nghiêm cấm hay không?', NULL, N'B')
INSERT [dbo].[CAUHOI] ([QMCH], [QTCH], [QPIC], [QDAD]) VALUES (7, N'Người điều khiển xe ô tô, máy kéo, xe máy chuyên dùng trên đường mà trong máu hoặc hơi thở có nồng độ cồn vượt quá bao nhiêu thì bị cấm?', NULL, N'A')
INSERT [dbo].[CAUHOI] ([QMCH], [QTCH], [QPIC], [QDAD]) VALUES (8, N'Người điều khiển xe mô tô, xe gắn máy trên đường mà trong máu có nồng độ cồn vượt quá bao nhiêu thì bị cấm?', NULL, N'B')
INSERT [dbo].[CAUHOI] ([QMCH], [QTCH], [QPIC], [QDAD]) VALUES (9, N'Người điều khiển xe mô tô, xe gắn máy trên đường mà trong khí thở có nồng độ cồn vượt quá bao nhiêu thì bị cấm?', NULL, N'A')
INSERT [dbo].[CAUHOI] ([QMCH], [QTCH], [QPIC], [QDAD]) VALUES (10, N'Hành vi giao xe cơ giới, xe máy chuyên dùng cho người không đủ điều kiện để điều khiển xe tham gia giao thông có bị nghiêm cấm hay không?', NULL, N'B')
INSERT [dbo].[CAUHOI] ([QMCH], [QTCH], [QPIC], [QDAD]) VALUES (11, N'Khái niệm “đường bộ” được hiểu như thế nào là đúng? Đường bộ gồm:', NULL, N'C')
INSERT [dbo].[CAUHOI] ([QMCH], [QTCH], [QPIC], [QDAD]) VALUES (12, N'“Vạch kẻ đường” được hiểu như thế nào là đúng?', NULL, N'A')
INSERT [dbo].[CAUHOI] ([QMCH], [QTCH], [QPIC], [QDAD]) VALUES (13, N'Khái niệm “Làn đường” được hiểu như thế nào là đúng?', NULL, N'A')
INSERT [dbo].[CAUHOI] ([QMCH], [QTCH], [QPIC], [QDAD]) VALUES (14, N'Khái niệm “Phần đường xe chạy” được hiểu như thế nào là đúng?', NULL, N'A')
INSERT [dbo].[CAUHOI] ([QMCH], [QTCH], [QPIC], [QDAD]) VALUES (15, N'Khái niệm “Đường phố” được hiểu như thế nào là đúng?', NULL, N'B')
INSERT [dbo].[CAUHOI] ([QMCH], [QTCH], [QPIC], [QDAD]) VALUES (16, N'Khái niệm “Dải phân cách” được hiểu như thế nào là đúng?', NULL, N'A')
INSERT [dbo].[CAUHOI] ([QMCH], [QTCH], [QPIC], [QDAD]) VALUES (17, N'Dải phân cách trên đường bộ có những loại nào?', NULL, N'A')
INSERT [dbo].[CAUHOI] ([QMCH], [QTCH], [QPIC], [QDAD]) VALUES (18, N'Khái niệm “đường ưu tiên” được hiểu như thế nào là đúng?', NULL, N'B')
INSERT [dbo].[CAUHOI] ([QMCH], [QTCH], [QPIC], [QDAD]) VALUES (19, N'Phương tiện giao thông đường bộ gồm những loại nào?', NULL, N'B')
INSERT [dbo].[CAUHOI] ([QMCH], [QTCH], [QPIC], [QDAD]) VALUES (20, N'Khái niệm phương tiện giao thông cơ giới đường bộ được hiểu như thế nào là đúng?', NULL, N'A')
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'C1', 1, 18)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'C1', 2, 19)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'C1', 3, 4)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'C1', 4, 5)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'C1', 5, 6)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'C1', 6, 7)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'C1', 7, 8)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'C1', 8, 9)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'C1', 9, 20)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'C1', 10, 1)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'C1', 11, 2)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'C1', 12, 3)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'C1', 13, 10)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'C1', 14, 11)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'C1', 15, 12)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'C1', 16, 13)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'C1', 17, 14)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'C1', 18, 15)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'C1', 19, 16)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'C1', 20, 17)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'M1', 1, 1)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'M1', 2, 2)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'M1', 3, 3)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'M1', 4, 4)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'M1', 5, 5)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'M1', 6, 6)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'M1', 7, 7)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'M1', 8, 8)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'M1', 9, 9)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'M1', 10, 10)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'M1', 11, 11)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'M1', 12, 12)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'M1', 13, 13)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'M1', 14, 14)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'M1', 15, 15)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'M1', 16, 16)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'M1', 17, 17)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'M1', 18, 18)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'M1', 19, 19)
INSERT [dbo].[CTDETHI] ([MDT], [QMCH], [STT]) VALUES (N'M1', 20, 20)
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'10A', N'Không bị nghiêm cấm', 10, N'A')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'10B', N'Bị nghiêm cấm', 10, N'B')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'10C', N'Nghiêm cấm tùy từng trường hợp', 10, N'C')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'10D', N'', 10, N'D')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'11A', N'Đường, cầu đường bộ.', 11, N'A')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'11B', N'Hầm đường bộ, bến phà đường bộ.', 11, N'B')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'11C', N'Đường, cầu đường bộ, hầm đường bộ, bến phà đường bộ và các công trình phụ trợ khác.', 11, N'C')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'11D', N'', 11, N'D')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'12A', N'Vạch kẻ đường là vạch chỉ sự phân chia làn đường, vị trí hoặc hướng đi, vị trí dừng lại.', 12, N'A')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'12B', N'Vạch kẻ đường là vạch chỉ sự phân biệt vị trí dừng, đỗ trên đường.', 12, N'B')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'12C', N'Tất cả các ý nêu trên.', 12, N'C')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'12D', N'', 12, N'D')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'13A', N'Là một phần của đường được chia theo chiều ngang của đường, có bề rộng đủ cho xe an toàn.', 13, N'A')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'13B', N'Là một phần của đường xe chạy được chia theo chiều dọc của đường, có bề rộng đủ cho xe an toàn.', 13, N'B')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'13C', N'Cả hai ý trên', 13, N'C')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'13D', N'', 13, N'D')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'14A', N'Là phần của đường bộ được sử dụng cho các phương tiện giao thông qua lại', 14, N'A')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'14B', N'Là phần của đường bộ được sử dụng cho các phương tiện giao thông qua lại, dải đất dọc hai bên đường để bảo đảm an toàn giao thông.', 14, N'B')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'14C', N'Là phần của đường bộ được sử dụng cho các phương tiện giao thông qua lại, các công trình, thiết bị phụ trợ khác, dải đất dọc hai bên đường để bảo đảm an toàn giao thông.', 14, N'C')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'14D', N'', 14, N'D')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'15A', N'Đường phố là đường đô thị gồm lòng đường và hè phố', 15, N'A')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'15B', N'Đường phố là đường bộ ngoài đô thị, có lòng đường đủ rộng cho các phương tiện giao thông qua lại.', 15, N'B')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'15C', N'Cả hai ý nêu trên', 15, N'C')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'15D', N'', 15, N'D')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'16A', N'Là bộ phận của đường để phân chia mặt đường thành hai chiều xe chạy riêng biệt hoặc để phân chia phần đường của xe cơ giới và xe thô sơ', 16, N'A')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'16B', N' Là bộ phận của đường để xác định danh giới của đất dành cho đường bộ theo chiều ngang của đường.', 16, N'B')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'16C', N'Là bộ phận của đường để ngăn cách không cho các loại xe và những nơi không được phép', 16, N'C')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'16D', N'', 16, N'D')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'17A', N'Loại cố định', 17, N'A')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'17B', N' Loại di động', 17, N'B')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'17C', N'', 17, N'C')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'17D', N'', 17, N'D')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'18A', N'Đường ưu tiên là đường mà trên đó phương tiện tham gia giao thông đường bộ phải nhường đường cho các phương tiện đến từ hướng khác khi qua nơi đường giao nhau có thể được cắm biển báo hiệu đường ưu tiên', 18, N'A')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'18B', N'Đường ưu tiên là đường mà trên đó phương tiện tham gia giao thông đường bộ được các phương tiện đến từ hướng khác khi qua nơi đường giao nhau được cắm biển báo hiệu đường ưu tiên', 18, N'B')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'18C', N'Đường ưu tiên là đường chỉ dành cho một số loại phương tiện tham gia giao thông được cắm biển báo hiệu đường ưu tiên.', 18, N'C')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'18D', N'', 18, N'D')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'19A', N'Phương tiện giao thông cơ giới đường bộ, phương tiện giao thông thô sơ đường bộ.', 19, N'A')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'19B', N'Phương tiện giao thông cơ giới đường bộ, phương tiện giao thông thô sơ đường bộ, và xe máy chuyên dùng', 19, N'B')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'19C', N'Cả hai ý nêu trên', 19, N'C')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'19D', N'', 19, N'D')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'1A', N'Phương tiện giao thông cơ giới đường bộ.', 1, N'A')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'1B', N'Phương tiện giao thông thô sơ đường bộ và xe máy chuyên dùng.', 1, N'B')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'1C', N'', 1, N'C')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'1D', N'', 1, N'D')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'20A', N'Gồm xe ô tô; máy kéo; xe mô tô hai bánh; xe mô tô ba bánh; xe gắn máy; xe cơ giới dùng cho người khuyết tật và xe máy chuyên dùng.', 20, N'A')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'20B', N'Gồm xe ô tô; máy kéo; rơ moóc hoặc sơ mi rơ moóc được kéo bởi xe ô tô; máy kéo; xe mô tô hai bánh; xe mô tô ba bánh; xe gắn máy (kể cả xe máy điện) và các loại xe tương tự', 20, N'B')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'20C', N'', 20, N'C')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'20D', N'', 20, N'D')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'2A', N'Người điều khiển, người sử dụng phương tiện tham gia giao thông đường bộ.', 2, N'A')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'2B', N'Người điều khiển, dẫn dắt súc vật; người đi bộ trên đường bộ.', 2, N'B')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'2C', N'', 2, N'C')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'2D', N'', 2, N'D')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'3A', N'Là người điều khiển phương tiện tham gia giao thông.', 3, N'A')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'3B', N'Là người được giao nhiệm vụ hướng dẫn giao thông tại nơi thi công, nơi ùn tắc giao thông, ở bến phà, tại cầu đường bộ đi chung với đường sắt.', 3, N'B')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'3C', N' Là cảnh sát giao thông', 3, N'C')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'3D', N'Tất cả các ý nêu trên.', 3, N'D')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'4A', N'Phá hoại đường, cầu, hầm, bến phà đường bộ, phá hoại đèn tín hiệu, cọc tiêu, biển báo hiệu, gương cầu, dải phân cách.', 4, N'A')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'4B', N'Phá hoại hệ thống thoát nước và các công trình, thiết bị khác thuộc kết cấu hạ tầng giao thông đường bộ.', 4, N'B')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'4C', N'', 4, N'C')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'4D', N'', 4, N'D')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'5A', N'Đua xe, cổ vũ đua xe, tổ chức đưa xe trái phép', 5, N'A')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'5B', N'Lạng lách, đánh võng.', 5, N'B')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'5C', N'', 5, N'C')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'5D', N'', 5, N'D')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'6A', N'Bị nghiêm cấm.', 6, N'A')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'6B', N'Không bị nghiêm cấm', 6, N'B')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'6C', N'', 6, N'C')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'6D', N'', 6, N'D')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'7A', N'Người điều khiển xe ô tô, máy kéo, xe máy chuyên dùng trên đường mà trong máu có nồng độ cồn vượt quá 50 miligam/100 mililít máu hoặc 0,25 miligam/ 1 lít khí thở', 7, N'A')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'7B', N' Người điều khiển xe ô tô, máy kéo, xe máy chuyên dùng trên đường mà trong máu hoặc hơi thở có nồng độ cồn.', 7, N'B')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'7C', N'Người điều khiển xe ô tô, máy kéo, xe máy chuyên dùng trên đường mà trong máu có nồng độ cồn vượt quá 80 miligam/ 100 mililít máu hoặc 40 miligam/ 1 lít khí thở.', 7, N'C')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'7D', N'', 7, N'D')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'8A', N'Nồng độ cồn vượt quá 50 miligam/ 100 mililít máu.', 8, N'A')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'8B', N'Nồng độ cồn vượt quá 40 miligam/ 100 mililít máu.', 8, N'B')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'8C', N'Nồng độ cồn vượt quá 30 miligam/ 100 mililít máu.', 8, N'C')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'8D', N'', 8, N'D')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'9A', N' Nồng độ cồn vượt quá 0,25 miligam/ 1 lít khí thở.', 9, N'A')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'9B', N'Nồng độ cồn vượt quá 0,15 miligam/ 1 lít khí thở.', 9, N'B')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'9C', N'', 9, N'C')
INSERT [dbo].[DAPAN] ([AMDA], [ATDA], [QMCH], [DA]) VALUES (N'9D', N'', 9, N'D')
INSERT [dbo].[DETHI] ([MDT], [TDT], [LOAI]) VALUES (N'C1', N'Chính Thức', 1)
INSERT [dbo].[DETHI] ([MDT], [TDT], [LOAI]) VALUES (N'M1', N'Minh Họa', 0)
INSERT [dbo].[KIEMTRA] ([MKT], [MND], [MDT], [NGAYTHI]) VALUES (1, 1, N'C1', CAST(N'1900-01-01 00:00:00' AS SmallDateTime))
INSERT [dbo].[KIEMTRA] ([MKT], [MND], [MDT], [NGAYTHI]) VALUES (2, 1, N'C1', CAST(N'1997-09-09 00:00:00' AS SmallDateTime))
INSERT [dbo].[NGUOIDUNG] ([MND], [HO], [TEN], [NGAYSINH], [GIOITINH], [EMAIL], [TDN], [MK], [PQ]) VALUES (1, N'Nguyễn Văn ', N'Toàn', CAST(N'1998-12-02 00:00:00' AS SmallDateTime), N'Nam', N'nguyenvantoan@gmail.com', N'nguyenvan toan', N'1234', N'0')
INSERT [dbo].[NGUOIDUNG] ([MND], [HO], [TEN], [NGAYSINH], [GIOITINH], [EMAIL], [TDN], [MK], [PQ]) VALUES (2, N'Đinh Văn ', N'Tín', CAST(N'1997-10-01 00:00:00' AS SmallDateTime), N'Nam', N'dinhvantin@gmail.com', N'dinhvantin', N'abcd', N'0')
INSERT [dbo].[NGUOIDUNG] ([MND], [HO], [TEN], [NGAYSINH], [GIOITINH], [EMAIL], [TDN], [MK], [PQ]) VALUES (3, N'Nguyễn Văn ', N'A', CAST(N'1998-09-23 00:00:00' AS SmallDateTime), N'Nam', N'nguyenvana@gmail.com', N'nguyenvana', N'123abc', N'0')
INSERT [dbo].[NGUOIDUNG] ([MND], [HO], [TEN], [NGAYSINH], [GIOITINH], [EMAIL], [TDN], [MK], [PQ]) VALUES (4, N'Trần Văn ', N'B', CAST(N'1995-05-20 00:00:00' AS SmallDateTime), N'Nam', N'tranvanb@gmail.com', N'tranvanb', N'a1b2c3', N'0')
INSERT [dbo].[NGUOIDUNG] ([MND], [HO], [TEN], [NGAYSINH], [GIOITINH], [EMAIL], [TDN], [MK], [PQ]) VALUES (5, N'Tô Trần ', N'C', CAST(N'1999-03-18 00:00:00' AS SmallDateTime), N'Nữ ', N'totranc@gmail.com', N'totranc', N'123456', N'0')
INSERT [dbo].[NGUOIDUNG] ([MND], [HO], [TEN], [NGAYSINH], [GIOITINH], [EMAIL], [TDN], [MK], [PQ]) VALUES (6, N'Đặng Gia ', N'D', CAST(N'1993-08-26 00:00:00' AS SmallDateTime), N'Nữ ', N'danggiad@gmail.com', N'danggiad', N'123abc', N'0')
ALTER TABLE [dbo].[CTDETHI]  WITH CHECK ADD  CONSTRAINT [FK_CTDETHI_DETHI] FOREIGN KEY([MDT])
REFERENCES [dbo].[DETHI] ([MDT])
GO
ALTER TABLE [dbo].[CTDETHI] CHECK CONSTRAINT [FK_CTDETHI_DETHI]
GO
ALTER TABLE [dbo].[DAPAN]  WITH CHECK ADD  CONSTRAINT [FK_DAPAN_CAUHOI] FOREIGN KEY([QMCH])
REFERENCES [dbo].[CAUHOI] ([QMCH])
GO
ALTER TABLE [dbo].[DAPAN] CHECK CONSTRAINT [FK_DAPAN_CAUHOI]
GO
ALTER TABLE [dbo].[KETQUA]  WITH CHECK ADD  CONSTRAINT [FK_KETQUA_DETHI] FOREIGN KEY([MDT])
REFERENCES [dbo].[DETHI] ([MDT])
GO
ALTER TABLE [dbo].[KETQUA] CHECK CONSTRAINT [FK_KETQUA_DETHI]
GO
ALTER TABLE [dbo].[KETQUA]  WITH CHECK ADD  CONSTRAINT [FK_KETQUA_KIEMTRA] FOREIGN KEY([MKT])
REFERENCES [dbo].[KIEMTRA] ([MKT])
GO
ALTER TABLE [dbo].[KETQUA] CHECK CONSTRAINT [FK_KETQUA_KIEMTRA]
GO
ALTER TABLE [dbo].[KETQUA]  WITH CHECK ADD  CONSTRAINT [FK_KETQUA_NGUOIDUNG] FOREIGN KEY([MND])
REFERENCES [dbo].[NGUOIDUNG] ([MND])
GO
ALTER TABLE [dbo].[KETQUA] CHECK CONSTRAINT [FK_KETQUA_NGUOIDUNG]
GO
ALTER TABLE [dbo].[KIEMTRA]  WITH CHECK ADD  CONSTRAINT [FK_KIEMTRA_DETHI] FOREIGN KEY([MDT])
REFERENCES [dbo].[DETHI] ([MDT])
GO
ALTER TABLE [dbo].[KIEMTRA] CHECK CONSTRAINT [FK_KIEMTRA_DETHI]
GO
ALTER TABLE [dbo].[TRALOIND]  WITH CHECK ADD  CONSTRAINT [FK_TRALOIND_CAUHOI] FOREIGN KEY([QMCH])
REFERENCES [dbo].[CAUHOI] ([QMCH])
GO
ALTER TABLE [dbo].[TRALOIND] CHECK CONSTRAINT [FK_TRALOIND_CAUHOI]
GO
ALTER TABLE [dbo].[TRALOIND]  WITH CHECK ADD  CONSTRAINT [FK_TRALOIND_DETHI] FOREIGN KEY([MDT])
REFERENCES [dbo].[DETHI] ([MDT])
GO
ALTER TABLE [dbo].[TRALOIND] CHECK CONSTRAINT [FK_TRALOIND_DETHI]
GO
ALTER TABLE [dbo].[TRALOIND]  WITH CHECK ADD  CONSTRAINT [FK_TRALOIND_KIEMTRA] FOREIGN KEY([MKT])
REFERENCES [dbo].[KIEMTRA] ([MKT])
GO
ALTER TABLE [dbo].[TRALOIND] CHECK CONSTRAINT [FK_TRALOIND_KIEMTRA]
GO
ALTER TABLE [dbo].[TRALOIND]  WITH CHECK ADD  CONSTRAINT [FK_TRALOIND_NGUOIDUNG] FOREIGN KEY([MND])
REFERENCES [dbo].[NGUOIDUNG] ([MND])
GO
ALTER TABLE [dbo].[TRALOIND] CHECK CONSTRAINT [FK_TRALOIND_NGUOIDUNG]
GO
USE [master]
GO
ALTER DATABASE [DB_PMTNLX_16_1_V1] SET  READ_WRITE 
GO
