
ALTER DATABASE [YazilimSinama] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [YazilimSinama] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [YazilimSinama] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [YazilimSinama] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [YazilimSinama] SET ARITHABORT OFF 
GO
ALTER DATABASE [YazilimSinama] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [YazilimSinama] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [YazilimSinama] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [YazilimSinama] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [YazilimSinama] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [YazilimSinama] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [YazilimSinama] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [YazilimSinama] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [YazilimSinama] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [YazilimSinama] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [YazilimSinama] SET  DISABLE_BROKER 
GO
ALTER DATABASE [YazilimSinama] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [YazilimSinama] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [YazilimSinama] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [YazilimSinama] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [YazilimSinama] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [YazilimSinama] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [YazilimSinama] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [YazilimSinama] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [YazilimSinama] SET  MULTI_USER 
GO
ALTER DATABASE [YazilimSinama] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [YazilimSinama] SET DB_CHAINING OFF 
GO
ALTER DATABASE [YazilimSinama] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [YazilimSinama] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [YazilimSinama]
GO
/****** Object:  StoredProcedure [dbo].[sp_DemirbasDuzenle]    Script Date: 12/25/2017 7:29:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DemirbasDuzenle]
(
@demirbasNo int,
@fakutleId int,
@bolumId int,
@kategoriId int,
@demirbasAdedi int,
@demirbasAciklama text
)
AS
DECLARE @demirbasKod nvarchar(50)
Update Demirbaslar Set DemirbasAdedi=@demirbasAdedi,DemirbasAciklama=@demirbasAciklama WHERE DemirbasNo=@demirbasNo


DECLARE @demirbasId int
SET @demirbasKod = (SELECT [dbo].[fnc_DemirbasKodOlustur](@fakutleId,@bolumId,@kategoriId,@demirbasNo))
UPDATE Demirbaslar SET DemirbasKodu = @demirbasKod WHERE DemirbasNo = @demirbasNo
GO
/****** Object:  StoredProcedure [dbo].[sp_DemirbasEkle]    Script Date: 12/25/2017 7:29:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DemirbasEkle]
(
@fakutleId int,
@bolumId int,
@kategoriId int,
@urunId int,
@demirbasAdedi int,
@demirbasAciklama text
)
AS
DECLARE @demirbasKod nvarchar(50)
DECLARE @urunAdi nvarchar(250)

SET @urunAdi=(SELECT u.UrunAdi FROM urunler u where UrunId=@urunId)

INSERT INTO Demirbaslar(DemirbasAdi,DemirbasAdedi,DemirbasAciklama,UrunId) VALUES(@urunAdi,@demirbasAdedi,@demirbasAciklama,@urunId)


DECLARE @demirbasId int
SET @demirbasId = (SELECT TOP(1) DemirbasNo FROM Demirbaslar ORDER BY DemirbasNo DESC)
SET @demirbasKod = (SELECT [dbo].[fnc_DemirbasKodOlustur](@fakutleId,@bolumId,@kategoriId,@demirbasId))
UPDATE Demirbaslar SET DemirbasKodu = @demirbasKod WHERE DemirbasNo = @demirbasId
GO
/****** Object:  StoredProcedure [dbo].[sp_kisi_Demirbaslar]    Script Date: 12/25/2017 7:29:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_kisi_Demirbaslar](@kisiId int)
as

Select do.DemirbasOdaId,d.DemirbasKodu,d.DemirbasAdi,do.Adet FROM Zimmetler z inner join Odalar o on z.OdaId = o.OdaId inner join Demirbas_Oda do on z.ZimmetId=do.ZimmetId inner join Kisiler k   on k.KisiId=z.KisiId inner join Demirbaslar d on do.DemirbasId=d.DemirbasNo where k.KisiId=k.KisiId
GO
/****** Object:  StoredProcedure [dbo].[sp_kisi_Demirbaslar1]    Script Date: 12/25/2017 7:29:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_kisi_Demirbaslar1](@kisiId int)
as

Select do.DemirbasOdaId,d.DemirbasKodu,d.DemirbasAdi,do.Adet FROM Zimmetler z inner join Odalar o on z.OdaId = o.OdaId inner join Demirbas_Oda do on z.ZimmetId=do.ZimmetId inner join Kisiler k   on k.KisiId=z.KisiId inner join Demirbaslar d on do.DemirbasId=d.DemirbasNo where k.KisiId=@KisiId
GO
/****** Object:  StoredProcedure [dbo].[sp_Odadaki_Demirbaslar01]    Script Date: 12/25/2017 7:29:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_Odadaki_Demirbaslar01](@OdaId int)
as

Select do.DemirbasOdaId,d.DemirbasKodu,d.DemirbasAdi,do.Adet FROM Zimmetler z inner join Odalar o on z.OdaId = o.OdaId inner join Demirbas_Oda do on z.ZimmetId=do.ZimmetId inner join Kisiler k   on k.KisiId=z.KisiId inner join Demirbaslar d on do.DemirbasId=d.DemirbasNo where z.OdaId=@OdaId
GO
/****** Object:  StoredProcedure [dbo].[sp_Odadaki_Demirbaslar02]    Script Date: 12/25/2017 7:29:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_Odadaki_Demirbaslar02](@OdaId int)
as

Select do.DemirbasOdaId,d.DemirbasKodu,d.DemirbasAdi,do.Adet FROM Zimmetler z inner join Odalar o on z.OdaId = o.OdaId inner join Demirbas_Oda do on z.ZimmetId=do.ZimmetId inner join Kisiler k   on k.KisiId=z.KisiId inner join Demirbaslar d on do.DemirbasId=d.DemirbasNo where z.OdaId=@OdaId
GO
/****** Object:  StoredProcedure [dbo].[sp_OdaEkle]    Script Date: 12/25/2017 7:29:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_OdaEkle](@OdaAdi nvarchar(50),@BolumId int)
as
Insert into Odalar Values(@OdaAdi)
DECLARE @OdaId int 
SET @OdaId=(Select Top(1) odaId From Odalar order by OdaId Desc)
Insert into OdaFakulteBolum(OdaId,BolumId) Values(@OdaId,@BolumId)
GO
/****** Object:  StoredProcedure [dbo].[sp_OdaGuncelle]    Script Date: 12/25/2017 7:29:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_OdaGuncelle](@OdaId int, @OdaAdi nvarchar(50),@BolumId int,@KisiId int)
as
Update Odalar set OdaAdi=@OdaAdi where OdaId=@OdaId
Update OdaFakulteBolum set BolumId=@BolumId where OdaId=@OdaId
Update Zimmetler Set KisiId=@KisiId where OdaId=@OdaId
GO
/****** Object:  StoredProcedure [dbo].[sp_OdayaDemirbasEkle]    Script Date: 12/25/2017 7:29:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_OdayaDemirbasEkle](@DemirbasId int,@OdaId int,@Adet int)
as
Declare @ZimmetId int 
Set @ZimmetId = (Select top(1) ZimmetId from Zimmetler where OdaId=@OdaId)
Insert into Demirbas_Oda(DemirbasId,Adet,ZimmetId) Values(@DemirbasId,@Adet,@ZimmetId)
Declare @DemirbasOdaId int
SET @DemirbasOdaId = (SELECT TOP(1) DemirbasOdaId From Demirbas_Oda Order by DemirbasOdaId desc )
GO
/****** Object:  StoredProcedure [dbo].[sp_UrunEkle]    Script Date: 12/25/2017 7:29:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_UrunEkle](@KategoriId int,@UrunAdi nvarchar(50),@UrunBirimFiyati money,@Stok int,@SatinAlinmaTarihi datetime)
As
INSERT INTO [dbo].[Urunler]
           ([KategoriId]
           ,[UrunAdi]
           ,[UrunBirimFiyati],
		   [SatinAlinmaTarihi]
           )
     VALUES
           (@KategoriId
           ,@UrunAdi
           ,@UrunBirimFiyati,
		   @SatinAlinmaTarihi
           )
DECLARE @UrunId int
SET @UrunId=(Select TOP(1) UrunId from Urunler order by UrunId desc)
INSERT INTO Urun_Stok (Stok,UrunId) values(@Stok,@UrunId)
GO
/****** Object:  StoredProcedure [dbo].[sp_UrunGuncelle]    Script Date: 12/25/2017 7:29:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_UrunGuncelle](@UrunId int, @KategoriId int,@UrunAdi nvarchar(50),@UrunBirimFiyati money,@Stok int,@SatinAlinmaTarihi datetime)
As
Update [dbo].[Urunler]
           Set [KategoriId]=@KategoriId,[UrunAdi] =@UrunAdi,[UrunBirimFiyati]=@UrunBirimFiyati,[SatinAlinmaTarihi]=@SatinAlinmaTarihi WHERE UrunId=@UrunId
           
     
Update Urun_Stok SET Stok=@Stok where UrunId=@UrunId
GO
/****** Object:  UserDefinedFunction [dbo].[fnc_DemirbasKodOlustur]    Script Date: 12/25/2017 7:29:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Function [dbo].[fnc_DemirbasKodOlustur](@fakulteId int,@bolumId int,@kategoriId int,@demirbasId int)
RETURNS nvarchar(50)
AS
BEGIN

	DECLARE @demirbasKod nvarchar(50)

	SET @demirbasKod= (SELECT CAST(@fakulteId as nvarchar)+'.'+CAST(@bolumId as nvarchar)+'.'+CAST(@kategoriId as nvarchar)+'.'+CAST(@demirbasId as nvarchar))
	Return @demirbasKod

END

GO
/****** Object:  Table [dbo].[Bolumler]    Script Date: 12/25/2017 7:29:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bolumler](
	[BolumId] [int] IDENTITY(1,1) NOT NULL,
	[FakulteId] [int] NOT NULL,
	[BolumAdi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Bolumler] PRIMARY KEY CLUSTERED 
(
	[BolumId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Demirbas_Oda]    Script Date: 12/25/2017 7:29:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Demirbas_Oda](
	[DemirbasOdaId] [int] IDENTITY(1,1) NOT NULL,
	[DemirbasId] [int] NOT NULL,
	[ZimmetId] [int] NOT NULL,
	[Adet] [int] NULL,
 CONSTRAINT [PK_Demirbas_Oda] PRIMARY KEY CLUSTERED 
(
	[DemirbasOdaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Demirbaslar]    Script Date: 12/25/2017 7:29:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Demirbaslar](
	[DemirbasNo] [int] IDENTITY(1,1) NOT NULL,
	[UrunId] [int] NULL,
	[DemirbasKodu] [nvarchar](50) NULL,
	[DemirbasAdi] [nvarchar](50) NULL,
	[DemirbasAdedi] [int] NULL,
	[DemirbasAciklama] [nvarchar](50) NULL,
 CONSTRAINT [PK_Demirbaslar] PRIMARY KEY CLUSTERED 
(
	[DemirbasNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Fakulteler]    Script Date: 12/25/2017 7:29:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fakulteler](
	[FakulteId] [int] IDENTITY(1,1) NOT NULL,
	[FakulteAdi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Fakulteler] PRIMARY KEY CLUSTERED 
(
	[FakulteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kategoriler]    Script Date: 12/25/2017 7:29:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kategoriler](
	[KategoriId] [int] IDENTITY(1,1) NOT NULL,
	[KategoriAdi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Kategoriler] PRIMARY KEY CLUSTERED 
(
	[KategoriId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kisiler]    Script Date: 12/25/2017 7:29:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kisiler](
	[KisiId] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](50) NOT NULL,
	[Soyad] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Kisiler] PRIMARY KEY CLUSTERED 
(
	[KisiId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kullanici_Role]    Script Date: 12/25/2017 7:29:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici_Role](
	[KullaniciRoleId] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciId] [int] NOT NULL,
	[RoleId] [int] NOT NULL,
 CONSTRAINT [PK_Kullanici_Role_1] PRIMARY KEY CLUSTERED 
(
	[KullaniciRoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kullanicilar]    Script Date: 12/25/2017 7:29:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanicilar](
	[KullaniciId] [int] NOT NULL,
	[KullaniciAdi] [nvarchar](50) NOT NULL,
	[Sifre] [nvarchar](50) NOT NULL,
	[SonGirisTarihi] [smalldatetime] NULL,
	[Silindi] [bit] NULL,
 CONSTRAINT [PK_Kullanicilar] PRIMARY KEY CLUSTERED 
(
	[KullaniciId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OdaFakulteBolum]    Script Date: 12/25/2017 7:29:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OdaFakulteBolum](
	[OdaFakulteBolumId] [int] IDENTITY(1,1) NOT NULL,
	[OdaId] [int] NOT NULL,
	[BolumId] [int] NOT NULL,
 CONSTRAINT [PK_OdaFakulteBolum] PRIMARY KEY CLUSTERED 
(
	[OdaFakulteBolumId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Odalar]    Script Date: 12/25/2017 7:29:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Odalar](
	[OdaId] [int] IDENTITY(1,1) NOT NULL,
	[OdaAdi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Odalar] PRIMARY KEY CLUSTERED 
(
	[OdaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Roller]    Script Date: 12/25/2017 7:29:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roller](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RolAdi] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Roller] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Urun_Stok]    Script Date: 12/25/2017 7:29:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urun_Stok](
	[StokId] [int] IDENTITY(1,1) NOT NULL,
	[UrunId] [int] NOT NULL,
	[Stok] [int] NOT NULL,
 CONSTRAINT [PK_Urun_Stok] PRIMARY KEY CLUSTERED 
(
	[StokId] ASC,
	[UrunId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Urunler]    Script Date: 12/25/2017 7:29:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urunler](
	[UrunId] [int] IDENTITY(1,1) NOT NULL,
	[KategoriId] [int] NOT NULL,
	[UrunAdi] [nvarchar](50) NOT NULL,
	[UrunBirimFiyati] [money] NOT NULL,
	[SatinAlinmaTarihi] [smalldatetime] NULL,
	[Silindi] [bit] NULL,
 CONSTRAINT [PK_Urunler] PRIMARY KEY CLUSTERED 
(
	[UrunId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Zimmetler]    Script Date: 12/25/2017 7:29:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zimmetler](
	[ZimmetId] [int] IDENTITY(1,1) NOT NULL,
	[KisiId] [int] NULL,
	[OdaId] [int] NULL,
 CONSTRAINT [PK_Zimmetler] PRIMARY KEY CLUSTERED 
(
	[ZimmetId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[KisiOda]    Script Date: 12/25/2017 7:29:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[KisiOda]
as
Select k.KisiId,k.Ad,k.Soyad,do.OdaId,o.OdaAdi from Kisiler k inner join Zimmetler z on k.KisiId=z.KisiId inner join Demirbas_Oda do on z.DemirbasOdaId=do.DemirbasOdaId inner join Odalar o on o.OdaId=do.OdaId group by do.OdaId,k.KisiId,k.Ad,k.Soyad,o.OdaAdi
GO
SET IDENTITY_INSERT [dbo].[Bolumler] ON 

INSERT [dbo].[Bolumler] ([BolumId], [FakulteId], [BolumAdi]) VALUES (1, 1, N'Yazýlým Mühendisliði')
INSERT [dbo].[Bolumler] ([BolumId], [FakulteId], [BolumAdi]) VALUES (2, 1, N'Mekatronik Mühendisliði')
INSERT [dbo].[Bolumler] ([BolumId], [FakulteId], [BolumAdi]) VALUES (3, 2, N'Bilgisayar Mühendisliði')
INSERT [dbo].[Bolumler] ([BolumId], [FakulteId], [BolumAdi]) VALUES (4, 2, N'Endüstri Mühendisliði')
INSERT [dbo].[Bolumler] ([BolumId], [FakulteId], [BolumAdi]) VALUES (5, 3, N'Týp ')
SET IDENTITY_INSERT [dbo].[Bolumler] OFF
SET IDENTITY_INSERT [dbo].[Demirbas_Oda] ON 

INSERT [dbo].[Demirbas_Oda] ([DemirbasOdaId], [DemirbasId], [ZimmetId], [Adet]) VALUES (1, 1, 1, 50)
INSERT [dbo].[Demirbas_Oda] ([DemirbasOdaId], [DemirbasId], [ZimmetId], [Adet]) VALUES (2, 2, 1, 5)
SET IDENTITY_INSERT [dbo].[Demirbas_Oda] OFF
SET IDENTITY_INSERT [dbo].[Demirbaslar] ON 

INSERT [dbo].[Demirbaslar] ([DemirbasNo], [UrunId], [DemirbasKodu], [DemirbasAdi], [DemirbasAdedi], [DemirbasAciklama]) VALUES (1, 1, N'1.1.1.1', N'Bilgisayar', 50, N'Bilgisayar')
INSERT [dbo].[Demirbaslar] ([DemirbasNo], [UrunId], [DemirbasKodu], [DemirbasAdi], [DemirbasAdedi], [DemirbasAciklama]) VALUES (2, 2, N'1.1.4.2', N'Ofis TÝpi Sandalye', 0, N'asdasdasd')
INSERT [dbo].[Demirbaslar] ([DemirbasNo], [UrunId], [DemirbasKodu], [DemirbasAdi], [DemirbasAdedi], [DemirbasAciklama]) VALUES (3, 3, N'1.1.1.3', N'Projeksiyon', 1, N'Demirbas projection')
INSERT [dbo].[Demirbaslar] ([DemirbasNo], [UrunId], [DemirbasKodu], [DemirbasAdi], [DemirbasAdedi], [DemirbasAciklama]) VALUES (4, 4, N'1.1.1.4', N'Fare', 20, N'')
INSERT [dbo].[Demirbaslar] ([DemirbasNo], [UrunId], [DemirbasKodu], [DemirbasAdi], [DemirbasAdedi], [DemirbasAciklama]) VALUES (5, 4, N'1.1.1.5', N'Fare', 20, N'')
SET IDENTITY_INSERT [dbo].[Demirbaslar] OFF
SET IDENTITY_INSERT [dbo].[Fakulteler] ON 

INSERT [dbo].[Fakulteler] ([FakulteId], [FakulteAdi]) VALUES (1, N'Teknoloji Fakültesi')
INSERT [dbo].[Fakulteler] ([FakulteId], [FakulteAdi]) VALUES (2, N'Mühendislik Fakültesi')
INSERT [dbo].[Fakulteler] ([FakulteId], [FakulteAdi]) VALUES (3, N'Týp Fakültesi')
SET IDENTITY_INSERT [dbo].[Fakulteler] OFF
SET IDENTITY_INSERT [dbo].[Kategoriler] ON 

INSERT [dbo].[Kategoriler] ([KategoriId], [KategoriAdi]) VALUES (1, N'Elektronik Aletlet')
INSERT [dbo].[Kategoriler] ([KategoriId], [KategoriAdi]) VALUES (2, N'Temizlik Malzemeleri')
INSERT [dbo].[Kategoriler] ([KategoriId], [KategoriAdi]) VALUES (3, N'Kýrtasiye Ürünleri')
INSERT [dbo].[Kategoriler] ([KategoriId], [KategoriAdi]) VALUES (4, N'Mobilya Ürünleri')
SET IDENTITY_INSERT [dbo].[Kategoriler] OFF
SET IDENTITY_INSERT [dbo].[Kisiler] ON 

INSERT [dbo].[Kisiler] ([KisiId], [Ad], [Soyad]) VALUES (1, N'Fatih', N'ÖZKIR')
INSERT [dbo].[Kisiler] ([KisiId], [Ad], [Soyad]) VALUES (2, N'Emre', N'ÖZ')
SET IDENTITY_INSERT [dbo].[Kisiler] OFF
SET IDENTITY_INSERT [dbo].[Kullanici_Role] ON 

INSERT [dbo].[Kullanici_Role] ([KullaniciRoleId], [KullaniciId], [RoleId]) VALUES (3, 1, 1)
INSERT [dbo].[Kullanici_Role] ([KullaniciRoleId], [KullaniciId], [RoleId]) VALUES (4, 2, 2)
SET IDENTITY_INSERT [dbo].[Kullanici_Role] OFF
INSERT [dbo].[Kullanicilar] ([KullaniciId], [KullaniciAdi], [Sifre], [SonGirisTarihi], [Silindi]) VALUES (1, N'fatihozkir', N'81dc9bdb52d04dc20036dbd8313ed055', CAST(0xA854045B AS SmallDateTime), 0)
INSERT [dbo].[Kullanicilar] ([KullaniciId], [KullaniciAdi], [Sifre], [SonGirisTarihi], [Silindi]) VALUES (2, N'emreoz', N'827ccb0eea8a706c4c34a16891f84e7b', CAST(0xA8540457 AS SmallDateTime), 0)
SET IDENTITY_INSERT [dbo].[OdaFakulteBolum] ON 

INSERT [dbo].[OdaFakulteBolum] ([OdaFakulteBolumId], [OdaId], [BolumId]) VALUES (1, 1, 1)
SET IDENTITY_INSERT [dbo].[OdaFakulteBolum] OFF
SET IDENTITY_INSERT [dbo].[Odalar] ON 

INSERT [dbo].[Odalar] ([OdaId], [OdaAdi]) VALUES (1, N'YZMLAB4')
SET IDENTITY_INSERT [dbo].[Odalar] OFF
SET IDENTITY_INSERT [dbo].[Roller] ON 

INSERT [dbo].[Roller] ([RoleId], [RolAdi]) VALUES (1, N'Admin')
INSERT [dbo].[Roller] ([RoleId], [RolAdi]) VALUES (2, N'Standart')
SET IDENTITY_INSERT [dbo].[Roller] OFF
SET IDENTITY_INSERT [dbo].[Urun_Stok] ON 

INSERT [dbo].[Urun_Stok] ([StokId], [UrunId], [Stok]) VALUES (1, 1, 0)
INSERT [dbo].[Urun_Stok] ([StokId], [UrunId], [Stok]) VALUES (2, 2, 0)
INSERT [dbo].[Urun_Stok] ([StokId], [UrunId], [Stok]) VALUES (3, 3, 159)
INSERT [dbo].[Urun_Stok] ([StokId], [UrunId], [Stok]) VALUES (4, 4, 60)
SET IDENTITY_INSERT [dbo].[Urun_Stok] OFF
SET IDENTITY_INSERT [dbo].[Urunler] ON 

INSERT [dbo].[Urunler] ([UrunId], [KategoriId], [UrunAdi], [UrunBirimFiyati], [SatinAlinmaTarihi], [Silindi]) VALUES (1, 1, N'Bilgisayar', 24.0000, CAST(0xA84E0000 AS SmallDateTime), 0)
INSERT [dbo].[Urunler] ([UrunId], [KategoriId], [UrunAdi], [UrunBirimFiyati], [SatinAlinmaTarihi], [Silindi]) VALUES (2, 4, N'Ofis TÝpi Sandalye', 12.0000, CAST(0xA84E0000 AS SmallDateTime), 0)
INSERT [dbo].[Urunler] ([UrunId], [KategoriId], [UrunAdi], [UrunBirimFiyati], [SatinAlinmaTarihi], [Silindi]) VALUES (3, 1, N'Projeksiyon', 250.0000, CAST(0xA8540000 AS SmallDateTime), 0)
INSERT [dbo].[Urunler] ([UrunId], [KategoriId], [UrunAdi], [UrunBirimFiyati], [SatinAlinmaTarihi], [Silindi]) VALUES (4, 1, N'Fare', 5.0000, CAST(0xA8540000 AS SmallDateTime), 0)
SET IDENTITY_INSERT [dbo].[Urunler] OFF
SET IDENTITY_INSERT [dbo].[Zimmetler] ON 

INSERT [dbo].[Zimmetler] ([ZimmetId], [KisiId], [OdaId]) VALUES (1, 1, 1)
SET IDENTITY_INSERT [dbo].[Zimmetler] OFF
ALTER TABLE [dbo].[Kullanicilar] ADD  CONSTRAINT [DF_Kullanicilar_SonGirisTarihi]  DEFAULT (getdate()) FOR [SonGirisTarihi]
GO
ALTER TABLE [dbo].[Kullanicilar] ADD  CONSTRAINT [DF_Kullanicilar_Silindi]  DEFAULT ((0)) FOR [Silindi]
GO
ALTER TABLE [dbo].[Urunler] ADD  CONSTRAINT [DF_Urunler_Silindi]  DEFAULT ((0)) FOR [Silindi]
GO
ALTER TABLE [dbo].[Bolumler]  WITH NOCHECK ADD  CONSTRAINT [FK_Bolumler_Fakulteler] FOREIGN KEY([FakulteId])
REFERENCES [dbo].[Fakulteler] ([FakulteId])
GO
ALTER TABLE [dbo].[Bolumler] CHECK CONSTRAINT [FK_Bolumler_Fakulteler]
GO
ALTER TABLE [dbo].[Demirbas_Oda]  WITH NOCHECK ADD  CONSTRAINT [FK_Demirbas_Oda_Demirbaslar] FOREIGN KEY([DemirbasId])
REFERENCES [dbo].[Demirbaslar] ([DemirbasNo])
GO
ALTER TABLE [dbo].[Demirbas_Oda] CHECK CONSTRAINT [FK_Demirbas_Oda_Demirbaslar]
GO
ALTER TABLE [dbo].[Demirbas_Oda]  WITH NOCHECK ADD  CONSTRAINT [FK_Demirbas_Oda_Zimmetler] FOREIGN KEY([ZimmetId])
REFERENCES [dbo].[Zimmetler] ([ZimmetId])
GO
ALTER TABLE [dbo].[Demirbas_Oda] CHECK CONSTRAINT [FK_Demirbas_Oda_Zimmetler]
GO
ALTER TABLE [dbo].[Demirbaslar]  WITH NOCHECK ADD  CONSTRAINT [FK_Demirbaslar_Urunler] FOREIGN KEY([UrunId])
REFERENCES [dbo].[Urunler] ([UrunId])
GO
ALTER TABLE [dbo].[Demirbaslar] CHECK CONSTRAINT [FK_Demirbaslar_Urunler]
GO
ALTER TABLE [dbo].[Kullanici_Role]  WITH NOCHECK ADD  CONSTRAINT [FK_Kullanici_Role_Kullanicilar] FOREIGN KEY([KullaniciId])
REFERENCES [dbo].[Kullanicilar] ([KullaniciId])
GO
ALTER TABLE [dbo].[Kullanici_Role] CHECK CONSTRAINT [FK_Kullanici_Role_Kullanicilar]
GO
ALTER TABLE [dbo].[Kullanici_Role]  WITH NOCHECK ADD  CONSTRAINT [FK_Kullanici_Role_Roller] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roller] ([RoleId])
GO
ALTER TABLE [dbo].[Kullanici_Role] CHECK CONSTRAINT [FK_Kullanici_Role_Roller]
GO
ALTER TABLE [dbo].[Kullanicilar]  WITH NOCHECK ADD  CONSTRAINT [FK_Kullanicilar_Kisiler] FOREIGN KEY([KullaniciId])
REFERENCES [dbo].[Kisiler] ([KisiId])
GO
ALTER TABLE [dbo].[Kullanicilar] CHECK CONSTRAINT [FK_Kullanicilar_Kisiler]
GO
ALTER TABLE [dbo].[OdaFakulteBolum]  WITH NOCHECK ADD  CONSTRAINT [FK_OdaFakulteBolum_Bolumler] FOREIGN KEY([BolumId])
REFERENCES [dbo].[Bolumler] ([BolumId])
GO
ALTER TABLE [dbo].[OdaFakulteBolum] CHECK CONSTRAINT [FK_OdaFakulteBolum_Bolumler]
GO
ALTER TABLE [dbo].[OdaFakulteBolum]  WITH NOCHECK ADD  CONSTRAINT [FK_OdaFakulteBolum_Odalar] FOREIGN KEY([OdaId])
REFERENCES [dbo].[Odalar] ([OdaId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OdaFakulteBolum] CHECK CONSTRAINT [FK_OdaFakulteBolum_Odalar]
GO
ALTER TABLE [dbo].[Urun_Stok]  WITH NOCHECK ADD  CONSTRAINT [FK_Urun_Stok_Urunler] FOREIGN KEY([UrunId])
REFERENCES [dbo].[Urunler] ([UrunId])
GO
ALTER TABLE [dbo].[Urun_Stok] CHECK CONSTRAINT [FK_Urun_Stok_Urunler]
GO
ALTER TABLE [dbo].[Urunler]  WITH NOCHECK ADD  CONSTRAINT [FK_Urunler_Kategoriler] FOREIGN KEY([KategoriId])
REFERENCES [dbo].[Kategoriler] ([KategoriId])
GO
ALTER TABLE [dbo].[Urunler] CHECK CONSTRAINT [FK_Urunler_Kategoriler]
GO
ALTER TABLE [dbo].[Zimmetler]  WITH NOCHECK ADD  CONSTRAINT [FK_Zimmetler_Kisiler] FOREIGN KEY([KisiId])
REFERENCES [dbo].[Kisiler] ([KisiId])
GO
ALTER TABLE [dbo].[Zimmetler] CHECK CONSTRAINT [FK_Zimmetler_Kisiler]
GO
ALTER TABLE [dbo].[Zimmetler]  WITH NOCHECK ADD  CONSTRAINT [FK_Zimmetler_Odalar] FOREIGN KEY([OdaId])
REFERENCES [dbo].[Odalar] ([OdaId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Zimmetler] CHECK CONSTRAINT [FK_Zimmetler_Odalar]
GO
USE [master]
GO
ALTER DATABASE [YazilimSinama] SET  READ_WRITE 
GO
