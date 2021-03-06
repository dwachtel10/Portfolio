USE [master]
GO
/****** Object:  Database [BarBlog]    Script Date: 12/7/2016 8:53:37 PM ******/
CREATE DATABASE [BarBlog]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BarBlog', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQL2014\MSSQL\DATA\BarBlog.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BarBlog_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQL2014\MSSQL\DATA\BarBlog_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BarBlog] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BarBlog].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BarBlog] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BarBlog] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BarBlog] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BarBlog] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BarBlog] SET ARITHABORT OFF 
GO
ALTER DATABASE [BarBlog] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BarBlog] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BarBlog] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BarBlog] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BarBlog] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BarBlog] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BarBlog] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BarBlog] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BarBlog] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BarBlog] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BarBlog] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BarBlog] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BarBlog] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BarBlog] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BarBlog] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BarBlog] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BarBlog] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BarBlog] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BarBlog] SET  MULTI_USER 
GO
ALTER DATABASE [BarBlog] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BarBlog] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BarBlog] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BarBlog] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [BarBlog] SET DELAYED_DURABILITY = DISABLED 
GO
USE [BarBlog]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](128) NOT NULL,
	[RoleId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](128) NOT NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEndDateUtc] [datetime] NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[UserName] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Categories]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] NOT NULL,
	[CategoryName] [varchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Post]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Post](
	[PostID] [int] NOT NULL,
	[UserID] [int] NULL,
	[CategoryID] [int] NOT NULL,
	[PostTitle] [varchar](max) NOT NULL,
	[PostSubtitle] [varchar](max) NULL,
	[PostBody] [varchar](max) NOT NULL,
	[PostStatus] [int] NOT NULL,
	[PostDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PostID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PostTags]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostTags](
	[PostTagID] [int] IDENTITY(1,1) NOT NULL,
	[PostID] [int] NOT NULL,
	[TagID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PostTagID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StaticPages]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StaticPages](
	[PageID] [int] NOT NULL,
	[PageTitle] [varchar](max) NOT NULL,
	[PageBody] [varchar](max) NOT NULL,
	[PageDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tags]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tags](
	[TagID] [int] NOT NULL,
	[TagName] [varchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TagID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [int] NOT NULL,
	[UserName] [varchar](30) NOT NULL,
	[UserPassword] [varchar](30) NOT NULL,
	[UserPermissions] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'201612061944371_InitialCreate', N'BarBlog.Web.Models.ApplicationDbContext', 0x1F8B0800000000000400DD5CDB6EE336107D2FD07F10F4D416A9954B77B10DEC2EB24ED206CD0DEB6CDBB7052DD18EB012A595A83441D12FEB433FA9BFD0A144DD78D1C5566C67B1C02222876786C321391C0EFDDF3FFF8EDF3EFA9EF180A3D80DC8C43C18ED9B062676E0B864393113BAF8FE8DF9F6A7AFBF1A9F39FEA3F15B4E77C4E8A0258927E63DA5E1B165C5F63DF6513CF25D3B0AE260414776E05BC809ACC3FDFD1FAD83030B0384095886317E9F10EAFA38FD80CF69406C1CD20479578183BD989743CD2C4535AE918FE310D97862BE43D13B2F588E7EC7F351466D1A279E8B409219F616A681080928A220E7F18718CF681490E52C8402E4DD3D8518E816C88B3197FFB824EFDA95FD43D615AB6C9843D9494C03BF27E0C111D78D25365F49C366A13BD0DE1968993EB15EA71A9C98170E4E8BDE071E284064783CF522463C31AF0A162771788DE9286F38CA20CF2380FB33883E8DAA887B46E7767B852D1D8EF6D9BF3D639A783489F084E08446C8DB336E93B9E7DABFE2A7BBE0132693A383F9E2E8CDABD7C8397AFD033E7A55ED29F415E86A0550741B05218E4036BC28FA6F1A56BD9D25362C9A55DA645A015B8269611A57E8F1129325BD870973F8C634CEDD47ECE425DCB83E1017661134A251029FD789E7A1B9878B7AAB9127FBBF81EBE1ABD78370BD460FEE321D7A813F4C9C08E6D57BECA5B5F1BD1B66D3AB36DE1F39D97914F8ECBB6E5F59EDC759904436EB4CA025B943D112D3BA7463AB34DE4E26CDA08637EB1C75F74D9B492A9BB792947568959990B3D8F46CC8E57D5EBE9D2DEE240C61F052D3621A69323879B31A09ADF78C0A4D693A075D4D874097BEE495F0CC47AE37C052D8810B78210B37F271D1CB7701181E22BD65BE45710C2B81F30B8AEF1B44873F07107D86ED2402039D51E487CFCEEDF63E20F83AF1E7CCEE37C76BB0A1B9FB333847360DA233C25AAD8D7719D89F82849E11E71451FC81DA3920FBBC73FDEE0083887362DB388ECFC198B1330DC0C9CE012F083D3AEC0DC716A86DBB22530FB9BEDA171196D28F3969E98FA829249F4443A6F24B9A44BD0C962EE9266A4EAA1735A368159593F515958175939453EA054D095AE5CCA806F3F4D2111ADED54B6177DFD75B6FF3D6AD051535CE6085C43F63822358C69C5B44298E4839025DD68D6D380BE9F031A6CFBE37A59C7E435E3234AB956643BA080C3F1B52D8DD9F0DA99850FCE03ACC2BE97000CA8901BE13BDFA6CD53EE704C9363D1D6ADDDC34F3CDAC01BAE97212C781EDA6B34011FAE2818BBAFCE0C319ED518CAC376224043A0686EEB22D0F4AA06FA6685437E4147B9862E3C4CE42835314DBC891D5081D727A0896EFA80AC1CA88485DB8EF249E60E938628D103B04C530535D42E569E112DB0D91D7AA25A165C72D8CF5BDE021D69CE21013C6B055135D98AB03204C80828F30286D1A1A5B158B6B36448DD7AA1BF33617B61C77292EB1119B6CF19D3576C9FDB76731CC668D6DC0389B55D245006D306F1B06CACF2A5D0D403CB8EC9A810A27268D8172976A23065AD7D8160CB4AE921767A0D911B5EBF80BE7D55D33CFFA4179F3DB7AA3BAB6609B357DEC986966BE27B4A1D00247B2799ECE59257EA48AC319C8C9CF67317775451361E0334CEB219BD2DF55FAA156338868444D80A5A1B580F26B4009489A503D84CB63798DD2712FA2076C1E776B84E56BBF005BB10119BB7A1D5A21D45F9A8AC6D9E9F451F4ACB006C9C83B1D162A380A831017AF7AC73B284517979515D3C517EEE30D573AC607A341412D9EAB4649796706D7526E9AED5A5239647D5CB2B5B424B84F1A2DE59D195C4BDC46DB95A4700A7AB8056BA9A8BE850F34D9F24847B1DB1475632BCB92E205634B934E35BE4261E8926525BD8A9718B32CB76AFAFDAC7FD2919F615876ACC83D2AA42D38D120424B2CD4026B90F4DC8D627A8A289A2316E7993ABE44A6DC5B35CB7FCEB2BA7DCA8398EF033935FB3B6BA1B8BCAFEDB5B233C231CEA1873EF368D230BA62FCD5CD0D96EE863C142922F7D3C04B7CA277B0F4ADB3FBBB6AFBAC4446185B82FC920325694B7273EBAAEF3430F2A41868900AFF65F581D243E8D49D7B9F5585EB3C523D4A1EA0AAA2E882565B1B389D23D36BB0441FB1FF58B5223CCFBCE2892955005ED413A392DB208155EABAA3D6D34FAA98F59AEE88428E491552A8EA21653593A42664B562253C8D46D514DD39C8B9235574B9B63BB2228BA40AADA85E015B21B358D71D5591685205565477C72EB34EC4457487772EEDC965E5AD2B3BDCAEB77769309E67451C66EBABDCE157812AC53DB1F82DBD04C6CB77D29AB427BC95AD298B69AC674D1A0CFDCA53BBFDAE2F3C8D57F67ACCDA95766D716FBAD2D7E3F5B3D967B50CE980279214DC8B839E70A01BF3C355FB231AE9B495919846AE46D8D89F628AFD112318CD3E7B53CFC56C19CF09AE10711738A6591A8779B87F7028BCC3D99D3731561C3B9EE270AA7B18531FB30D6464910714D9F72892F323D6783752824AA1E70BE2E0C789F957DAEA388D62B0BFD2E23DE322FE40DCCF0954DC450936FE96F33D87C9A36F3E64EDE8AB87EE5ABDF8E363D674CFB88960C61C1BFB822E5719E1FA5B885ED2644DD79066E517122F7742D59E1F28518509B1FA6B83B94B077969904BF98D8F1EBFED2B9AF235C15A888A170343E10DA242DD8B8055B0B4AF011CF8A4E96B807E9D55BF0E584534EDCB0097F40713DF05745F86F2965BDC6A1467A24D2C49A99E5BF3AAD74AB2DCF6DE24A55FAF35D1E514EB1E706BA451AF60192F2C0379B0DD5191603C18F6364DFBD9B38A772591B84CF1D86EFEF02653861BAE85BEA84CE11DC86D53E4EA6C3F1F78D3B6A68BE3EE785265BFACDF1D33369EC1B5FDDCDE4D1B9B2ECCBBE3C6D62B8377C76C6D5BFBE7962DADF316BAF57C5C39B548731FA38A05B7E5DB66817338E1CF033082CCA3CC9E49AA13BC9A92535B1896247AA6FACC3291B1347124BE124533DB7E7DE51B7E6367394D335B4D3E66136FBEFE37F2E634CDBC35598EDBC81456E619AAB2B75BD6B1A624A89794195CEB494B227A9BCFDA78B9FE92128107514A6DF668EE885F4EDEEF202A1972EAF4C8F395AF7B61EFACFCB222ECDFB1BB2C21D8EF2C126CD776CD82E6822C827CF31624CA498408CD15A6C8812DF524A2EE02D914AA598C397DE79DC6EDD84DC71C3B17E426A16142A1CBD89F7BB5801773029AF8A7C9CC7599C73761FA9325437401C474596CFE86BC4B5CCF29E43E57C4843410CCBBE0115D3696944576974F05D275403A0271F5154ED11DF6430FC0E21B32430F7815D9C0FC2EF112D94F65045007D23E1075B58F4F5DB48C901F738CB23D7C820D3BFEE34FFF036E0A292560540000, N'6.1.3-40302')
INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1', N'Admin')
INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2', N'Manager')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'48ad0b42-0836-4232-9e07-3cbbd0d240fc', N'1')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b6035535-58a9-4d7f-b546-58b32f1fa77e', N'2')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd7be8d17-d27f-42af-b3ad-c24433eedf87', N'1')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'48ad0b42-0836-4232-9e07-3cbbd0d240fc', N'danielpolefko@gmail.com', 0, N'AGIYd22vWihvAURDiwTbRkwjxxM5EmYkGYQ4a5VUjiQdAf+a1K+3kGaW+f9rsGM1Aw==', N'e4f827d9-1c8e-47f6-9fb1-29f1001f3804', NULL, 0, 0, NULL, 1, 0, N'danielpolefko@gmail.com')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b6035535-58a9-4d7f-b546-58b32f1fa77e', N'manager@manager.com', 0, N'ALql9YdGf1SRGmgXzN1LLFtDylw41zP6SOuNJmnXVMPZQtYEFl3fvs9pRu541iFghg==', N'a154001a-5039-428c-b591-6881cc5f2d4d', NULL, 0, 0, NULL, 1, 0, N'manager@manager.com')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd7be8d17-d27f-42af-b3ad-c24433eedf87', N'admin@admin.com', 0, N'AGFojsvkjzGjrqN4VHOmYVMbZViQUK/Udl747PXABpWvWpzhyJZS/NWB9QwEpVyEwA==', N'37b42b4d-fd78-4287-abef-02be48b4e048', NULL, 0, 0, NULL, 1, 0, N'admin@admin.com')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (1, N'Personal')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (2, N'Review')
INSERT [dbo].[Post] ([PostID], [UserID], [CategoryID], [PostTitle], [PostSubtitle], [PostBody], [PostStatus], [PostDate]) VALUES (1, NULL, 2, N'Review: The Zephyr Pub', NULL, N'<p><img src="https://pbs.twimg.com/profile_images/2147805831/zappertwit.jpg" alt="" width="500" height="500" /></p>
<p>&nbsp;</p>
<p>The Zephyr is a dive in the best sense of the word: the lighting is dim, the floor is sticky, every wooden surface has initials or expletives carved into it. &nbsp;But look beyond its aged, seedy appearance and you''ll find out why this bar has been a fixture of downtown Kent since&nbsp;before there&nbsp;<em>was</em> a downtown Kent. &nbsp;</p>
<p><img src="http://bloximages.newyork1.vip.townnews.com/kentwired.com/content/tncms/assets/v3/editorial/6/51/6518ee28-dd84-11e4-9c4a-8352411d6c16/5524734f79955.image.jpg?resize=665%2C427" alt="" width="350" height="275" /></p>
<p>With three floors, two bars, and a massive courtyard out back that backs right up to&nbsp;<em>Taco Tontos (</em>which makes for excellent synergy between alcohol and what is excellent drunk food), Zephyr stands out from an architectural perspective if nothing else.</p>
<p><img src="https://s3-media2.fl.yelpcdn.com/bphoto/nIYZ1M8-TLNgiyTZgdYHGA/ls.jpg" alt="A view of Zephyr''s courtyard and three-level patio." width="250" height="250" /></p>
<p><span style="font-family: ''Open Sans'', Arial, sans-serif; text-align: justify;">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras quis ante a leo pellentesque condimentum et a velit. Sed eget commodo risus. Aliquam et viverra nibh. Quisque interdum suscipit dolor commodo accumsan. Mauris urna dui, condimentum et suscipit viverra, consectetur id leo. Morbi ut egestas odio, ut ullamcorper orci. Nullam eu ligula eleifend, sollicitudin tortor quis, euismod ante. Integer at quam non massa suscipit venenatis. Phasellus rutrum blandit neque, ac hendrerit erat malesuada et. Donec laoreet vehicula sollicitudin. Donec facilisis a lacus quis viverra. Fusce imperdiet, nibh sit amet imperdiet efficitur, orci nunc dapibus ante, in rhoncus nisl justo quis nisi.</span></p>', 2, CAST(N'2016-12-07 00:00:00.000' AS DateTime))
INSERT [dbo].[Post] ([PostID], [UserID], [CategoryID], [PostTitle], [PostSubtitle], [PostBody], [PostStatus], [PostDate]) VALUES (2, NULL, 1, N'Broadening Horizons', NULL, N'<p>Just a heads up, readers: our staff may be moving before long, so there may be delays in posts. &nbsp;But on the plus side, we''ll be able to cover new and exciting bars!</p>
<p>Stay thirsty!</p>', 2, CAST(N'2016-12-07 00:00:00.000' AS DateTime))
INSERT [dbo].[Post] ([PostID], [UserID], [CategoryID], [PostTitle], [PostSubtitle], [PostBody], [PostStatus], [PostDate]) VALUES (3, NULL, 1, N'Anyone know any good bars in North Canton?', NULL, N'<p>Email us at regbarrev@swc.com! &nbsp;</p>', 2, CAST(N'2016-12-07 00:00:00.000' AS DateTime))
INSERT [dbo].[Post] ([PostID], [UserID], [CategoryID], [PostTitle], [PostSubtitle], [PostBody], [PostStatus], [PostDate]) VALUES (4, NULL, 1, N'Review: Fakey McFictional''s Pub', NULL, N'<p><img src="http://i3.mirror.co.uk/incoming/article6073866.ece/ALTERNATES/s615b/Four-hands-holing-pints-of-beer.jpg" alt="" width="615" height="410" /></p>
<p style="margin: 0px 0px 10px; padding: 0px; line-height: normal; color: #666666; font-family: Verdana, Geneva, sans-serif; font-size: 10px;">Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.</p>
<p style="margin: 0px 0px 10px; padding: 0px; line-height: normal; color: #666666; font-family: Verdana, Geneva, sans-serif; font-size: 10px;">Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur?</p>
<p style="margin: 0px 0px 10px; padding: 0px; line-height: normal; color: #666666; font-family: Verdana, Geneva, sans-serif; font-size: 10px;">Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur? At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio. Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime placeat facere</p>', 2, CAST(N'2016-12-07 00:00:00.000' AS DateTime))
INSERT [dbo].[Post] ([PostID], [UserID], [CategoryID], [PostTitle], [PostSubtitle], [PostBody], [PostStatus], [PostDate]) VALUES (5, NULL, 2, N'Review: 157 Lounge', NULL, N'<p><img src="http://onthegrid3.imgix.net/Kent-OTG-157Lounge-4.jpg?auto=format,redeye&amp;dpr=2&amp;w=571" alt="" width="600" height="400" /></p>
<p>The 157 Lounge is a relatively recent addition to the Kent scene (at least in comparison to local landmarks like the Zephyr, Ray''s Place, and Venice Cafe), and it shows. &nbsp;Almost uniquely among the downtown offerings, 157 offers a much more nightclub-feeling atmosphere as opposed to the ubiquitous college bar feel. &nbsp;The aesthetic of this place is as upscale urban as it gets--the stark simplicity of the color scheme, the angular minimalism of structure, and the in-house sushi bar almost make you forget that you''re in sleepy little Kent, Ohio. &nbsp;</p>
<p><img src="http://onthegrid2.imgix.net/Kent-OTG-157Lounge-1.jpg?auto=format,redeye&amp;dpr=2&amp;w=571" alt="" width="700" height="466" /></p>
<p>Li Europan lingues es membres del sam familie. Lor separat&nbsp;existentie es un myth. Por scientie, musica, sport etc, litot Europa usa li sam vocabular. Li lingues differe solmen in li grammatica, li pronunciation e li plu commun vocabules. Omnicos directe al desirabilite de un nov lingua franca: On refusa continuar payar custosi traductores.</p>
<p>At solmen va esser necessi far uniform grammatica, pronunciation e plu sommun paroles. Ma quande lingues coalesce, li grammatica del resultant lingue es plu simplic e regulari quam ti del coalescent lingues. Li nov lingua franca va esser plu simplic e regulari quam li existent Europan lingues.</p>
<p>It va esser tam simplic quam Occidental in fact, it va esser Occidental. A un Angleso it va semblar un simplificat Angles, quam un skeptic Cambridge amico dit me que Occidental es. Li Europan lingues es membres del sam familie. Lor separat existentie es un myth. Por scientie, musica, sport etc, litot Europa usa li sam vocabular. Li lingues differe solmen in li grammatica, li pronunciation e li plu commun vocabules. Omnicos directe al desirabilite de un nov lingua franca: On refusa continuar payar custosi traductores. At solmen va esser necessi far uniform grammatica, pronunciation e plu sommun paroles.</p>
<p>&nbsp;</p>', 2, CAST(N'2016-12-07 00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[PostTags] ON 

INSERT [dbo].[PostTags] ([PostTagID], [PostID], [TagID]) VALUES (1, 1, 1)
INSERT [dbo].[PostTags] ([PostTagID], [PostID], [TagID]) VALUES (2, 2, 2)
INSERT [dbo].[PostTags] ([PostTagID], [PostID], [TagID]) VALUES (3, 3, 3)
INSERT [dbo].[PostTags] ([PostTagID], [PostID], [TagID]) VALUES (4, 3, 4)
INSERT [dbo].[PostTags] ([PostTagID], [PostID], [TagID]) VALUES (7, 4, 1)
INSERT [dbo].[PostTags] ([PostTagID], [PostID], [TagID]) VALUES (8, 4, 5)
INSERT [dbo].[PostTags] ([PostTagID], [PostID], [TagID]) VALUES (9, 5, 6)
INSERT [dbo].[PostTags] ([PostTagID], [PostID], [TagID]) VALUES (10, 5, 1)
SET IDENTITY_INSERT [dbo].[PostTags] OFF
INSERT [dbo].[StaticPages] ([PageID], [PageTitle], [PageBody], [PageDate]) VALUES (1, N'Who We Are', N'<h2>So What Is This?</h2>
<p>&nbsp;</p>
<p>We are three software developers who are passionate not only about computers, but also nightlife. &nbsp;We started this project as a resource for those who may want to embrace the bar/nightclub scene but are apprehensive about going into the unknown unprepared. &nbsp;</p>
<p>The objective of this site is to provide information on local bars, lounges, and nightclubs from the perspective of a non-barfly layman. &nbsp;This way, we hope to provide aspiring clubgoers with an informed-and-understandable-but-casual viewpoint on their local scene. &nbsp;There are few things more uncomfortable than trying to enjoy yourself in a place that doesn''t fit your liking, so let us help you avoid that!</p>', CAST(N'2016-12-07 17:36:54.037' AS DateTime))
INSERT [dbo].[StaticPages] ([PageID], [PageTitle], [PageBody], [PageDate]) VALUES (2, N'Local Bars', N'<h2>Kent Bars</h2>
<p>Home to Kent State University, Kent, Ohio has grown from a sleepy college town to a bustling mini-metropolis of nightlife in the past decade. &nbsp;Here are the addresses of some of the more prominent establishments you''ll find near the home of the Golden Flashes.</p>
<p>157 Lounge</p>
<p><img src="https://s3-media4.fl.yelpcdn.com/bphoto/ypTYKp3NS2eTJsP1arR2IQ/180s.jpg" alt="" width="180" height="180" /></p>
<p>157 S. Water St.</p>
<p>(330) 678-1577</p>
<p><a href="http://www.157lounge.com" target="_blank" rel="noopener noreferrer">www.157lounge.com</a></p>
<p>&nbsp;</p>
<p>Bar 145</p>
<p><img src="http://www.bar145kent.com/images/gallery/gallery1.jpg" alt="" width="150" height="150" /></p>
<p>211 Erie St.</p>
<p>(330) 673-7822</p>
<p><a href="http://www.bar145kent.com" target="_blank" rel="noopener noreferrer">www.bar145kent.com</a></p>
<p>&nbsp;</p>', CAST(N'2016-12-07 00:00:00.000' AS DateTime))
INSERT [dbo].[StaticPages] ([PageID], [PageTitle], [PageBody], [PageDate]) VALUES (3, N'Links', N'<h2>Helpful Links</h2>
<p>Here are some links to some interesting information for bar-goers and alcohol afficianados alike!</p>
<p>&nbsp;</p>
<p><a href="http://www.drinksmixer.com/" target="_blank" rel="noopener noreferrer">http://www.drinksmixer.com/</a></p>
<p>If you have no idea what you like, you can search this site for something that sounds good. &nbsp;You might want to have it bookmarked on your phone--the bartender might not have heard of it!</p>
<p>&nbsp;</p>
<p><a href="http://www.houzz.com/photos/home-bar" target="_blank" rel="noopener noreferrer">http://www.houzz.com/photos/home-bar</a></p>
<p>If you''re more of a staying-in kind of person, here''s some amazing photos of home bar setups to inspire you.</p>
<p>&nbsp;</p>
<p><a href="http://www.drinksmixer.com/guide/" target="_blank" rel="noopener noreferrer">http://www.drinksmixer.com/guide/</a></p>
<p>Drinksmixer also offers hints for the amateur bartender!</p>
<p>&nbsp;</p>
<p><a href="https://www.kegworks.com/" target="_blank" rel="noopener noreferrer">https://www.kegworks.com/</a></p>
<p>Whether you need some glassware, are stocking up on ingredients, or want tips about bartending, this site has it all!</p>', CAST(N'2016-12-07 17:53:53.617' AS DateTime))
INSERT [dbo].[Tags] ([TagID], [TagName]) VALUES (1, N'review')
INSERT [dbo].[Tags] ([TagID], [TagName]) VALUES (2, N'personal')
INSERT [dbo].[Tags] ([TagID], [TagName]) VALUES (3, N'request')
INSERT [dbo].[Tags] ([TagID], [TagName]) VALUES (4, N'email')
INSERT [dbo].[Tags] ([TagID], [TagName]) VALUES (5, N'irish pub')
INSERT [dbo].[Tags] ([TagID], [TagName]) VALUES (6, N'nightclub')
INSERT [dbo].[User] ([UserID], [UserName], [UserPassword], [UserPermissions]) VALUES (1, N'Dan', N'password', N'full')
SET ANSI_PADDING ON

GO
/****** Object:  Index [RoleNameIndex]    Script Date: 12/7/2016 8:53:37 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UserId]    Script Date: 12/7/2016 8:53:37 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UserId]    Script Date: 12/7/2016 8:53:37 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_RoleId]    Script Date: 12/7/2016 8:53:37 PM ******/
CREATE NONCLUSTERED INDEX [IX_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UserId]    Script Date: 12/7/2016 8:53:37 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserRoles]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UserNameIndex]    Script Date: 12/7/2016 8:53:37 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]
GO
/****** Object:  StoredProcedure [dbo].[AddBlogPost]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[AddBlogPost]
(
	@PostID int,
	@UserID int,
	@CategoryID int,
	@PostTitle varchar(max),
	@PostSubTitle varchar(max),
	@PostBody varchar(max),
	@PostStatus int,
	@PostDate datetime
	
) AS

INSERT INTO Post (PostID, UserID, CategoryID, PostTitle, PostSubtitle, PostBody, PostStatus, PostDate)
Values (@PostID, @UserID, @CategoryID, @PostTitle, @PostSubtitle, @PostBody, @PostStatus, @PostDate)




GO
/****** Object:  StoredProcedure [dbo].[AddCategory]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Categories

CREATE PROCEDURE [dbo].[AddCategory]
(
@CategoryID int,
@CategoryName varchar(max) 
) AS

INSERT INTO Categories(CategoryID, CategoryName)
Values (@CategoryID, @CategoryName)




GO
/****** Object:  StoredProcedure [dbo].[AddPostTag]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--PostTags

CREATE PROCEDURE [dbo].[AddPostTag]
(
	@TagID int,
	@PostID int
) AS

INSERT INTO PostTags(TagID, PostID)
Values (@TagID, @PostID)




GO
/****** Object:  StoredProcedure [dbo].[AddStaticPage]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[AddStaticPage]
(
	@PageID int,
--	@UserID int,
--	@PageStatus varchar(max),
	@PageTitle varchar(max),
	@PageBody varchar(max),
	@PageDate datetime
	
) AS

INSERT INTO StaticPages (PageID, PageTitle, PageBody, PageDate)
Values (@PageID, @PageTitle, @PageBody, @PageDate)




GO
/****** Object:  StoredProcedure [dbo].[AddTag]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Tags

CREATE PROCEDURE [dbo].[AddTag]
(
	@TagID int,
	@TagName varchar(max)
) AS

INSERT INTO Tags (TagID, TagName)
Values (@TagID, @TagName)




GO
/****** Object:  StoredProcedure [dbo].[GetAllBlogPosts]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAllBlogPosts] as

Select *
From Post




GO
/****** Object:  StoredProcedure [dbo].[GetAllCategories]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[GetAllCategories] AS

Select *
From Categories




GO
/****** Object:  StoredProcedure [dbo].[GetAllStaticPages]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAllStaticPages] as

Select *
From StaticPages




GO
/****** Object:  StoredProcedure [dbo].[GetAllTags]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[GetAllTags] AS

Select *
From Tags




GO
/****** Object:  StoredProcedure [dbo].[GetBlogPost]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetBlogPost]
(
	@PostID int
) as

Select *
From Post
Where PostID = @PostID




GO
/****** Object:  StoredProcedure [dbo].[GetCategory]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[GetCategory]
(
	@CategoryID int
)AS

Select *
From Categories
Where CategoryID = @CategoryID




GO
/****** Object:  StoredProcedure [dbo].[GetStaticPage]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Static Pages

CREATE PROCEDURE [dbo].[GetStaticPage]
(
	@PageID int
) as

Select *
From StaticPages
Where PageID = @PageID




GO
/****** Object:  StoredProcedure [dbo].[GetTag]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[GetTag]
(
	@TagID int
)AS

Select *
From Tags
Where TagID = @TagID




GO
/****** Object:  StoredProcedure [dbo].[GetTagsByPostID]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetTagsByPostID]
(
	@PostID int
)AS
SELECT PostTags.TagID, Tags.TagName
FROM PostTags INNER JOIN Tags
ON PostTags.TagID = Tags.TagID
WHERE PostTags.PostID = @PostID




GO
/****** Object:  StoredProcedure [dbo].[RemoveBlogPost]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[RemoveBlogPost]
(
	@PostID int
) AS

Delete
From Post
Where PostID = @PostID




GO
/****** Object:  StoredProcedure [dbo].[RemoveCategory]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[RemoveCategory]
(
	@CategoryID int
) AS

Delete
From Categories
Where CategoryID = @CategoryID




GO
/****** Object:  StoredProcedure [dbo].[RemovePostTags]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[RemovePostTags]
(
	@PostID int
)AS
Delete
From PostTags
Where PostID = @PostID




GO
/****** Object:  StoredProcedure [dbo].[RemovePostTagsByTagID]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RemovePostTagsByTagID]
(
	@TagID int
)AS
DELETE
FROM PostTags
WHERE TagID = @TagID


GO
/****** Object:  StoredProcedure [dbo].[RemoveStaticPages]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[RemoveStaticPages]
(
	@PageID int
) AS

Delete
From StaticPages
Where PageID = @PageID




GO
/****** Object:  StoredProcedure [dbo].[RemoveTag]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[RemoveTag]
(
	@TagID int
) AS

Delete
From Tags
Where TagID = @TagID




GO
/****** Object:  StoredProcedure [dbo].[UpdateBlogPost]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[UpdateBlogPost]
(
	@PostID int,
	@UserID int,
	@CategoryID int,
	@PostTitle varchar(max),
	@PostSubTitle varchar(max),
	@PostBody varchar(max),
	@PostStatus int,
	@PostDate datetime
) AS

UPDATE Post
Set UserID = @UserID,
CategoryID = @CategoryID,
PostTitle = @PostTitle,
PostSubtitle = @PostSubtitle,
PostBody = @PostBody,
PostStatus = @PostStatus,
PostDate = @PostDate

Where PostID = @PostID




GO
/****** Object:  StoredProcedure [dbo].[UpdateCategory]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[UpdateCategory]
(
	@CategoryID int,
	@CategoryName varchar(max)
) AS

UPDATE Categories
Set CategoryName = @CategoryName

Where CategoryID = @CategoryID




GO
/****** Object:  StoredProcedure [dbo].[UpdateStaticPage]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[UpdateStaticPage]
(
	@PageID int,
--	@UserID int,
	@PageTitle varchar (max),
--	@PageStatus varchar(max),
	@PageBody varchar(max),
	@Pagedate datetime
) AS

UPDATE StaticPages
Set 
PageTitle = @PageTitle,
PageBody =	@PageBody,
PageDate = @PageDate

Where PageID = @PageID




GO
/****** Object:  StoredProcedure [dbo].[UpdateTag]    Script Date: 12/7/2016 8:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[UpdateTag]
(
	@TagID int,
	@TagName varchar(max)
) AS

UPDATE Tags
Set TagName = @TagName

Where TagID = @TagID




GO
USE [master]
GO
ALTER DATABASE [BarBlog] SET  READ_WRITE 
GO
