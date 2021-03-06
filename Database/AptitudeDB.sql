USE [master]
GO
/****** Object:  Database [AptitudeDB]    Script Date: 24-Dec-20 11:24:30 PM ******/
CREATE DATABASE [AptitudeDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AptitudeDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\AptitudeDB.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'AptitudeDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\AptitudeDB_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [AptitudeDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AptitudeDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AptitudeDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AptitudeDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AptitudeDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AptitudeDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AptitudeDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [AptitudeDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [AptitudeDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [AptitudeDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AptitudeDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AptitudeDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AptitudeDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AptitudeDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AptitudeDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AptitudeDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AptitudeDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AptitudeDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [AptitudeDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AptitudeDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AptitudeDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AptitudeDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AptitudeDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AptitudeDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AptitudeDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AptitudeDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AptitudeDB] SET  MULTI_USER 
GO
ALTER DATABASE [AptitudeDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AptitudeDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AptitudeDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AptitudeDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [AptitudeDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 24-Dec-20 11:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 24-Dec-20 11:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 24-Dec-20 11:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 24-Dec-20 11:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 24-Dec-20 11:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 24-Dec-20 11:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 24-Dec-20 11:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 24-Dec-20 11:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CV]    Script Date: 24-Dec-20 11:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CV](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Pass] [nvarchar](max) NULL,
	[University] [nvarchar](max) NULL,
	[Mark] [int] NULL,
	[PersonalDetail] [nvarchar](max) NULL,
	[Advantage] [nvarchar](max) NULL,
	[Disadvantage] [nvarchar](max) NULL,
	[Hobby] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
	[Experience] [nvarchar](max) NULL,
	[Project] [nvarchar](max) NULL,
	[LastPostion] [nvarchar](max) NULL,
	[Status] [int] NULL,
	[ExamId] [int] NULL,
	[DepartmentId] [int] NULL,
	[DateCV] [datetime] NULL,
 CONSTRAINT [PK_CV] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Department]    Script Date: 24-Dec-20 11:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Detail] [nvarchar](max) NULL,
	[Requirement] [nvarchar](max) NULL,
	[Location] [nvarchar](max) NULL,
	[Welfare] [nvarchar](max) NULL,
	[Salary] [int] NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Exam]    Script Date: 24-Dec-20 11:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exam](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Mark] [float] NULL,
	[Result] [nvarchar](max) NULL,
	[ExamTime] [nvarchar](max) NULL,
	[Date] [datetime2](7) NULL,
	[Answer] [nvarchar](max) NULL,
 CONSTRAINT [PK_Exam] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HR]    Script Date: 24-Dec-20 11:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HR](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Pass] [nvarchar](max) NULL,
	[University] [nvarchar](max) NULL,
	[Mark] [int] NULL,
	[PersonalDetail] [nvarchar](max) NULL,
	[Advantage] [nvarchar](max) NULL,
	[Disadvantage] [nvarchar](max) NULL,
	[Hobby] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
	[Experience] [nvarchar](max) NULL,
	[Project] [nvarchar](max) NULL,
	[LastPostion] [nvarchar](max) NULL,
	[Status] [int] NULL,
	[ExamId] [int] NULL,
	[DepartmentId] [int] NULL,
 CONSTRAINT [PK_HR] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Maintance]    Script Date: 24-Dec-20 11:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Maintance](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MaintanceDetail] [nvarchar](max) NULL,
	[MaintainceDate] [nvarchar](max) NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_Maintance] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Question]    Script Date: 24-Dec-20 11:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Question](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[QuestionName] [nvarchar](max) NULL,
	[Answer1] [nvarchar](max) NULL,
	[Answer2] [nvarchar](max) NULL,
	[Answer3] [nvarchar](max) NULL,
	[Answer4] [nvarchar](max) NULL,
	[FinalAnswer] [nvarchar](max) NULL,
	[Category] [int] NULL,
	[Level] [int] NULL,
	[Status] [int] NULL,
	[DepartmentId] [int] NULL,
 CONSTRAINT [PK_Question] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'00000000000000_CreateIdentitySchema', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201202041707_AptitudeDB', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201211040654_AptitudeDB', N'3.1.8')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'1', N'Admin', N'ADMIN', NULL)
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'788b480b-9142-49d4-a829-52a45c74dc19', N'User', N'USER', N'a6090ab3-77ef-4b24-91d4-748cb920c88e')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'234f3975-fc44-430e-8ef2-07b0c69647c6', N'1')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b83e78a8-0a5d-4b8d-9151-61563dec26ee', N'788b480b-9142-49d4-a829-52a45c74dc19')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c7feb453-48b1-4094-8c68-de6158303aec', N'788b480b-9142-49d4-a829-52a45c74dc19')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'234f3975-fc44-430e-8ef2-07b0c69647c6', N'buibavuong123456@gmail.com', N'BUIBAVUONG123456@GMAIL.COM', N'buibavuong123456@gmail.com', N'BUIBAVUONG123456@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEL8D/VBP5p6CcB8PYpJuGgrZC1hRGWlN9PkONg8JdPZqbui6lvu7mfdzbvTWUJC7fg==', N'YBVE2IMJ2UCWR5OM2BYOSIW37DK4SIPF', N'61f5a907-9710-42a1-bebd-af1746b7ebf8', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'b83e78a8-0a5d-4b8d-9151-61563dec26ee', N'bavuongbui@gmail.com', N'BAVUONGBUI@GMAIL.COM', N'bavuongbui@gmail.com', N'BAVUONGBUI@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEL8D/VBP5p6CcB8PYpJuGgrZC1hRGWlN9PkONg8JdPZqbui6lvu7mfdzbvTWUJC7fg==', N'OB5AG54E7DWD64VRVQFYP3ZEKK6QDRPA', N'149e6f22-6746-4ab0-9a12-05ecf73a6d8d', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'c7feb453-48b1-4094-8c68-de6158303aec', N'bubugihu@gmail.com', N'BUBUGIHU@GMAIL.COM', N'bubugihu@gmail.com', N'BUBUGIHU@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEL8D/VBP5p6CcB8PYpJuGgrZC1hRGWlN9PkONg8JdPZqbui6lvu7mfdzbvTWUJC7fg==', N'2E3NLDJK6HP5R335NFBO2NR42XNMSKOU', N'd13e1bc1-757c-4b99-be91-3f99c59a413c', NULL, 0, 0, NULL, 1, 0)
SET IDENTITY_INSERT [dbo].[CV] ON 

INSERT [dbo].[CV] ([Id], [FirstName], [LastName], [Email], [Pass], [University], [Mark], [PersonalDetail], [Advantage], [Disadvantage], [Hobby], [Language], [Experience], [Project], [LastPostion], [Status], [ExamId], [DepartmentId], [DateCV]) VALUES (6, N'bui', N'gia', N'bubugihu@gmail.com', N'123', N'UEH', 8, N'I am Single', N'Try hard', N'old', N'travel', N'japanese', N'3 years', N'laravel', N'dev', 2, 46, 1, CAST(0x0000AC99016D23C8 AS DateTime))
INSERT [dbo].[CV] ([Id], [FirstName], [LastName], [Email], [Pass], [University], [Mark], [PersonalDetail], [Advantage], [Disadvantage], [Hobby], [Language], [Experience], [Project], [LastPostion], [Status], [ExamId], [DepartmentId], [DateCV]) VALUES (7, N'chacha', N'bubu', N'bavuongbui@gmail.com', N'123', N'UEL', 5, N'I am Married', N'Smart', N'young', N'cinema', N'French', N'1 years', N'dot net', N'dev', 1, 49, 2, CAST(0x0000AC99016D23C8 AS DateTime))
SET IDENTITY_INSERT [dbo].[CV] OFF
SET IDENTITY_INSERT [dbo].[Department] ON 

INSERT [dbo].[Department] ([Id], [Name], [Detail], [Requirement], [Location], [Welfare], [Salary]) VALUES (1, N'Dev', N'Back End', N'Man', N'VN', N'Bonus ', 1100)
INSERT [dbo].[Department] ([Id], [Name], [Detail], [Requirement], [Location], [Welfare], [Salary]) VALUES (2, N'Manager', N'IT Comtor', N'Woman', N'VN', N'Bonus ', 1500)
SET IDENTITY_INSERT [dbo].[Department] OFF
SET IDENTITY_INSERT [dbo].[Exam] ON 

INSERT [dbo].[Exam] ([Id], [Mark], [Result], [ExamTime], [Date], [Answer]) VALUES (43, 10, N'Failed', N'14:00', CAST(0x0726DF04FBC8F4410B AS DateTime2), N'b+6//t+1//d+8//d+9//a+10')
INSERT [dbo].[Exam] ([Id], [Mark], [Result], [ExamTime], [Date], [Answer]) VALUES (44, 20, N'Failed', N'14:00', CAST(0x07A371E300C9F4410B AS DateTime2), N'a+11//b+13//d+14//b+15//a+16')
INSERT [dbo].[Exam] ([Id], [Mark], [Result], [ExamTime], [Date], [Answer]) VALUES (45, 0, N'Failed', N'14:00', CAST(0x07B85C3A06C9F4410B AS DateTime2), N'c+22//d+23//b+24//b+25//d+26')
INSERT [dbo].[Exam] ([Id], [Mark], [Result], [ExamTime], [Date], [Answer]) VALUES (46, 80, N'Passed', N'14:00', CAST(0x070000000000000000 AS DateTime2), N'b+6//t+1//d+8//d+9//a+10')
INSERT [dbo].[Exam] ([Id], [Mark], [Result], [ExamTime], [Date], [Answer]) VALUES (47, 90, N'Passed', N'14:00', CAST(0x070000000000000000 AS DateTime2), N'b+6//t+1//d+8//d+9//a+10')
INSERT [dbo].[Exam] ([Id], [Mark], [Result], [ExamTime], [Date], [Answer]) VALUES (48, 80, N'Passed', N'14:00', CAST(0x070000000000000000 AS DateTime2), N'b+6//t+1//d+8//d+9//a+10')
INSERT [dbo].[Exam] ([Id], [Mark], [Result], [ExamTime], [Date], [Answer]) VALUES (49, 60, N'Passed', N'14:00', CAST(0x07074473EABEF6410B AS DateTime2), N'c+6//c+7//c+8//b+9//a+10')
INSERT [dbo].[Exam] ([Id], [Mark], [Result], [ExamTime], [Date], [Answer]) VALUES (50, 30, N'Failed', N'14:00', CAST(0x07FAE499F7BEF6410B AS DateTime2), N'a+11//b+13//c+14//d+15//c+16')
INSERT [dbo].[Exam] ([Id], [Mark], [Result], [ExamTime], [Date], [Answer]) VALUES (51, 30, N'Failed', N'14:00', CAST(0x074FE619FEBEF6410B AS DateTime2), N'c+22//c+23//c+24//c+25//c+26')
SET IDENTITY_INSERT [dbo].[Exam] OFF
SET IDENTITY_INSERT [dbo].[HR] ON 

INSERT [dbo].[HR] ([Id], [FirstName], [LastName], [Email], [Pass], [University], [Mark], [PersonalDetail], [Advantage], [Disadvantage], [Hobby], [Language], [Experience], [Project], [LastPostion], [Status], [ExamId], [DepartmentId]) VALUES (1, N'bui', N'gia', N'bubugihu@gmail.com', NULL, N'UEH', 8, N'I am Single', N'Try hard', N'old', N'travel', N'japanese', N'3 years', N'laravel', N'dev', 3, 46, 1)
SET IDENTITY_INSERT [dbo].[HR] OFF
SET IDENTITY_INSERT [dbo].[Question] ON 

INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (6, N'What is the size of a standard barrel of oil in gallons?', N'55', N'42', N'159', N' 26', N'b', 1, 10, 1, 1)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (7, N'Which country is NOT currently a member of OPEC?', N'Saudi Arabia', N'Angola', N'Nigeria', N'Brazil', N'd', 1, 10, 1, 1)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (8, N'What country was the top oil producing country in 2015?', N'Saudi Arabia', N'Russia', N'United States', N'China', N'c', 1, 20, 1, 1)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (9, N'About how many gallons of gasoline are produced from one barrel of crude oil?', N'55', N'19', N'42', N'5', N'b', 1, 40, 1, 1)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (10, N'What is the top oil-producing state in the United States as of 2016?', N'Alaska', N' North Dakota', N'Oklahoma', N'Texas', N'd', 1, 20, 1, 1)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (11, N'If a, b, c, d ∈ N and they are four consecutive terms of an AP then the ath, bth, cth, dth terms of a GP are in', N' AP', N'GP', N'HP', N' None of these', N'b', 2, 10, 0, 1)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (13, N'Let a function f(z) = 2z + 1. Then the number of real values of z for which the three unequal numbers f(z), f(2z), f(4z) are in GP is', N'1', N'2', N' 0', N'None of these.

', N'c', 2, 10, 1, 1)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (14, N'If x, y, z are in GP then x + y, 2y, y + z are in', N'AP', N'GP', N'HP', N' None of these

', N'c', 2, 10, 0, 1)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (15, N'The average of first 50 natural numbers is …………. .', N'25.30', N'25.5', N'25.00', N'12.25', N'b', 2, 20, 0, 1)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (16, N' The number of 3-digit numbers divisible by 6, is ………….. .', N' 149', N'166', N'150', N'151
', N'c', 2, 20, 1, 1)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (17, N'A clock strikes once at 1 o’clock, twice at 2 o’clock, thrice at 3 o’clock and so on. How many times will it strike in 24 hours?', N'78', N'136', N'156', N'196', N'c', 2, 20, 1, 1)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (18, N'Which of the following numbers gives 240 when added to its own square?', N'15', N'16', N' 18', N' 20', N'a', 2, 10, 0, 1)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (19, N'The simplest form of 1.5 : 2.5 is …………… .', N'6 : 10', N'15 : 25', N' 0.75 : 1.25', N'3 : 5', N'd', 2, 40, 0, 1)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (20, N'In 24,673 ; the place-value of 6 is ….. .', N'700', N'600', N'10', N'100', N'b', 2, 40, 1, 1)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (21, N'In 24,673 ; the face-value of 4 is ….. .  A. 4', N' 4', N'2', N'1000', N' 9999', N'a', 2, 10, 1, 1)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (22, N'Which one is the first search engine in internet', N'Google', N'Archie', N'Altavista', N'WAIS', N'b', 3, 10, 1, 1)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (23, N'Number of bit used by the IPv6 address', N'32 bit', N'64 bit', N'128 bit', N'256 bit', N'c', 3, 10, 1, 1)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (24, N'Which one is the first web browser invented in 1990', N'Internet Explorer', N' Mosaic', N'Mozilla', N'Nexus', N'd', 3, 10, 0, 1)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (25, N' Which of the following programming language is used to create programs like applets?', N'COBOL', N'C Language', N'Java', N'BASIC', N'c', 3, 20, 1, 1)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (26, N'First computer virus is known as', N'Rabbit', N'Creeper Virus', N'Elk Cloner', N'SCA Virus', N'b', 3, 20, 1, 1)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (27, N'Which one programming language is exclusively used for artificial intelligence', N'C', N'Java', N'J2EE', N'Prolog', N'd', 3, 20, 0, 1)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (28, N'Firewall in computer is used for', N'Security', N'Data Transmission', N'Authentication', N'Monitoring', N'a', 3, 40, 1, 1)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (29, N'A dual layer Blue-ray Disc can store data upto', N'20GB', N'35 GB', N'12 GB', N'50 GB', N'd', 3, 40, 0, 1)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (30, N'Which of the following is not an operating system', N'DOS', N'Mac', N'C', N'Linux', N'c', 3, 40, 0, 1)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (31, N'Which of the following is not a database management software', N'MySQL', N'Oracle', N'Sybase', N'COBOL', N'd', 3, 40, 0, 1)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (60, N'What is the size of a standard barrel of oil in gallons?', N'55', N'42', N'159', N' 26', N'b', 1, 10, 1, 2)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (61, N'Which country is NOT currently a member of OPEC?', N'Saudi Arabia', N'Angola', N'Nigeria', N'Brazil', N'd', 1, 10, 1, 2)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (62, N'What country was the top oil producing country in 2015?', N'Saudi Arabia', N'Russia', N'United States', N'China', N'c', 1, 20, 1, 2)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (63, N'About how many gallons of gasoline are produced from one barrel of crude oil?', N'55', N'19', N'42', N'5', N'b', 1, 40, 1, 2)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (64, N'What is the top oil-producing state in the United States as of 2016?', N'Alaska', N' North Dakota', N'Oklahoma', N'Texas', N'd', 1, 20, 1, 2)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (65, N'If a, b, c, d ∈ N and they are four consecutive terms of an AP then the ath, bth, cth, dth terms of a GP are in', N' AP', N'GP', N'HP', N' None of these', N'b', 2, 10, 0, 2)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (66, N'Let a function f(z) = 2z + 1. Then the number of real values of z for which the three unequal numbers f(z), f(2z), f(4z) are in GP is', N'1', N'2', N' 0', N'None of these.', N'a', 2, 10, 0, 2)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (67, N'c', N'2', N'10', N'1', N'1', N'b', 2, 10, 1, 2)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (68, N'If x, y, z are in GP then x + y, 2y, y + z are in', N'AP', N'GP', N'HP', N' None of these', N'c', 2, 20, 1, 2)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (69, N'c', N'2', N'10', N'0', N'1', N'd', 2, 20, 0, 2)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (70, N'The average of first 50 natural numbers is …………. .', N'25.30', N'25.5', N'25.00', N'12.25', N'b', 2, 20, 0, 2)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (71, N' The number of 3-digit numbers divisible by 6, is ………….. .', N' 149', N'166', N'150', N'151', N'a', 2, 10, 0, 2)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (72, N'c', N'2', N'20', N'1', N'1', N'b', 2, 10, 0, 2)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (73, N'A clock strikes once at 1 o’clock, twice at 2 o’clock, thrice at 3 o’clock and so on. How many times will it strike in 24 hours?', N'78', N'136', N'156', N'196', N'c', 2, 20, 1, 2)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (74, N'Which of the following numbers gives 240 when added to its own square?', N'15', N'16', N' 18', N' 20', N'a', 2, 10, 0, 2)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (75, N'The simplest form of 1.5 : 2.5 is …………… .', N'6 : 10', N'15 : 25', N' 0.75 : 1.25', N'3 : 5', N'd', 2, 40, 0, 2)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (76, N'In 24,673 ; the place-value of 6 is ….. .', N'700', N'600', N'10', N'100', N'b', 2, 40, 1, 2)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (77, N'In 24,673 ; the face-value of 4 is ….. .  A. 4', N' 4', N'2', N'1000', N' 9999', N'a', 2, 10, 1, 2)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (78, N'Which one is the first search engine in internet', N'Google', N'Archie', N'Altavista', N'WAIS', N'b', 3, 10, 1, 2)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (79, N'Number of bit used by the IPv6 address', N'32 bit', N'64 bit', N'128 bit', N'256 bit', N'c', 3, 10, 1, 2)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (80, N'Which one is the first web browser invented in 1990', N'Internet Explorer', N' Mosaic', N'Mozilla', N'Nexus', N'd', 3, 10, 0, 2)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (81, N' Which of the following programming language is used to create programs like applets?', N'COBOL', N'C Language', N'Java', N'BASIC', N'c', 3, 20, 1, 2)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (82, N'First computer virus is known as', N'Rabbit', N'Creeper Virus', N'Elk Cloner', N'SCA Virus', N'b', 3, 20, 1, 2)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (83, N'Which one programming language is exclusively used for artificial intelligence', N'C', N'Java', N'J2EE', N'Prolog', N'd', 3, 20, 0, 2)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (84, N'Firewall in computer is used for', N'Security', N'Data Transmission', N'Authentication', N'Monitoring', N'a', 3, 40, 1, 2)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (85, N'A dual layer Blue-ray Disc can store data upto', N'20GB', N'35 GB', N'12 GB', N'50 GB', N'd', 3, 40, 0, 2)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (86, N'Which of the following is not an operating system', N'DOS', N'Mac', N'C', N'Linux', N'c', 3, 40, 0, 2)
INSERT [dbo].[Question] ([Id], [QuestionName], [Answer1], [Answer2], [Answer3], [Answer4], [FinalAnswer], [Category], [Level], [Status], [DepartmentId]) VALUES (87, N'Which of the following is not a database management software', N'MySQL', N'Oracle', N'Sybase', N'COBOL', N'd', 3, 40, 0, 2)
SET IDENTITY_INSERT [dbo].[Question] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 24-Dec-20 11:24:30 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [RoleNameIndex]    Script Date: 24-Dec-20 11:24:30 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 24-Dec-20 11:24:30 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 24-Dec-20 11:24:30 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 24-Dec-20 11:24:30 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [EmailIndex]    Script Date: 24-Dec-20 11:24:30 PM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UserNameIndex]    Script Date: 24-Dec-20 11:24:30 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
USE [master]
GO
ALTER DATABASE [AptitudeDB] SET  READ_WRITE 
GO
