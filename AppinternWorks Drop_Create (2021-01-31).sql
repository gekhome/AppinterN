USE [AppinternWorks]
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_MembersAll'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_MembersAll'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'rep_MembersArticles'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'rep_MembersArticles'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'rep_MembersApprenticeships'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'rep_MembersApprenticeships'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qryMembersUnion'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qryMembersUnion'
GO
/****** Object:  Table [dbo].[MemberGroups]    Script Date: 31/1/2021 10:23:12 πμ ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MemberGroups]') AND type in (N'U'))
DROP TABLE [dbo].[MemberGroups]
GO
/****** Object:  Table [dbo].[JobSectors]    Script Date: 31/1/2021 10:23:12 πμ ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[JobSectors]') AND type in (N'U'))
DROP TABLE [dbo].[JobSectors]
GO
/****** Object:  Table [dbo].[Genders]    Script Date: 31/1/2021 10:23:12 πμ ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Genders]') AND type in (N'U'))
DROP TABLE [dbo].[Genders]
GO
/****** Object:  Table [dbo].[Durations]    Script Date: 31/1/2021 10:23:12 πμ ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Durations]') AND type in (N'U'))
DROP TABLE [dbo].[Durations]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 31/1/2021 10:23:12 πμ ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Countries]') AND type in (N'U'))
DROP TABLE [dbo].[Countries]
GO
/****** Object:  Table [dbo].[Commitments]    Script Date: 31/1/2021 10:23:12 πμ ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Commitments]') AND type in (N'U'))
DROP TABLE [dbo].[Commitments]
GO
/****** Object:  View [dbo].[rep_MembersApprenticeships]    Script Date: 31/1/2021 10:23:12 πμ ******/
DROP VIEW [dbo].[rep_MembersApprenticeships]
GO
/****** Object:  Table [dbo].[Apprenticeships]    Script Date: 31/1/2021 10:23:12 πμ ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Apprenticeships]') AND type in (N'U'))
DROP TABLE [dbo].[Apprenticeships]
GO
/****** Object:  View [dbo].[rep_MembersArticles]    Script Date: 31/1/2021 10:23:12 πμ ******/
DROP VIEW [dbo].[rep_MembersArticles]
GO
/****** Object:  Table [dbo].[Articles]    Script Date: 31/1/2021 10:23:12 πμ ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Articles]') AND type in (N'U'))
DROP TABLE [dbo].[Articles]
GO
/****** Object:  View [dbo].[sql_MembersAll]    Script Date: 31/1/2021 10:23:12 πμ ******/
DROP VIEW [dbo].[sql_MembersAll]
GO
/****** Object:  View [dbo].[qryMembersUnion]    Script Date: 31/1/2021 10:23:12 πμ ******/
DROP VIEW [dbo].[qryMembersUnion]
GO
/****** Object:  Table [dbo].[Employers]    Script Date: 31/1/2021 10:23:12 πμ ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Employers]') AND type in (N'U'))
DROP TABLE [dbo].[Employers]
GO
/****** Object:  Table [dbo].[LiaisonOfficers]    Script Date: 31/1/2021 10:23:12 πμ ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LiaisonOfficers]') AND type in (N'U'))
DROP TABLE [dbo].[LiaisonOfficers]
GO
/****** Object:  Table [dbo].[Ambassadors]    Script Date: 31/1/2021 10:23:12 πμ ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Ambassadors]') AND type in (N'U'))
DROP TABLE [dbo].[Ambassadors]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 31/1/2021 10:23:12 πμ ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Teachers]') AND type in (N'U'))
DROP TABLE [dbo].[Teachers]
GO
/****** Object:  Table [dbo].[Graduates]    Script Date: 31/1/2021 10:23:12 πμ ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Graduates]') AND type in (N'U'))
DROP TABLE [dbo].[Graduates]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 31/1/2021 10:23:12 πμ ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Students]') AND type in (N'U'))
DROP TABLE [dbo].[Students]
GO
/****** Object:  Table [dbo].[Schools]    Script Date: 31/1/2021 10:23:12 πμ ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Schools]') AND type in (N'U'))
DROP TABLE [dbo].[Schools]
GO
/****** Object:  Table [dbo].[Organizations]    Script Date: 31/1/2021 10:23:12 πμ ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Organizations]') AND type in (N'U'))
DROP TABLE [dbo].[Organizations]
GO
/****** Object:  User [umbraco]    Script Date: 31/1/2021 10:23:12 πμ ******/
DROP USER [umbraco]
GO
USE [master]
GO
/****** Object:  Database [AppinternWorks]    Script Date: 31/1/2021 10:23:12 πμ ******/
DROP DATABASE [AppinternWorks]
GO
/****** Object:  Database [AppinternWorks]    Script Date: 31/1/2021 10:23:12 πμ ******/
CREATE DATABASE [AppinternWorks]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AppinternWorksDB', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL14.SQL_SERVER\MSSQL\DATA\AppinternWorksDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AppinternWorksDB_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL14.SQL_SERVER\MSSQL\DATA\AppinternWorksDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [AppinternWorks] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AppinternWorks].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AppinternWorks] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AppinternWorks] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AppinternWorks] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AppinternWorks] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AppinternWorks] SET ARITHABORT OFF 
GO
ALTER DATABASE [AppinternWorks] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [AppinternWorks] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AppinternWorks] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AppinternWorks] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AppinternWorks] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AppinternWorks] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AppinternWorks] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AppinternWorks] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AppinternWorks] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AppinternWorks] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AppinternWorks] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AppinternWorks] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AppinternWorks] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AppinternWorks] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AppinternWorks] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AppinternWorks] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AppinternWorks] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AppinternWorks] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AppinternWorks] SET  MULTI_USER 
GO
ALTER DATABASE [AppinternWorks] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AppinternWorks] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AppinternWorks] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AppinternWorks] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AppinternWorks] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AppinternWorks] SET QUERY_STORE = OFF
GO
USE [AppinternWorks]
GO
/****** Object:  User [umbraco]    Script Date: 31/1/2021 10:23:12 πμ ******/
CREATE USER [umbraco] FOR LOGIN [umbraco] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [umbraco]
GO
ALTER ROLE [db_datareader] ADD MEMBER [umbraco]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [umbraco]
GO
/****** Object:  Table [dbo].[Organizations]    Script Date: 31/1/2021 10:23:12 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Organizations](
	[MemberID] [int] NOT NULL,
	[OrganizationName] [nvarchar](255) NULL,
	[ContactPerson] [nvarchar](255) NULL,
	[Phone] [nvarchar](50) NULL,
	[Fax] [nvarchar](50) NULL,
	[Email] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[City] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[Zip] [nvarchar](20) NULL,
	[Country] [nvarchar](50) NULL,
	[JobSector] [nvarchar](255) NULL,
	[LoginName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Organizations] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Schools]    Script Date: 31/1/2021 10:23:12 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schools](
	[MemberID] [int] NOT NULL,
	[SchoolName] [nvarchar](255) NULL,
	[ContactPerson] [nvarchar](255) NULL,
	[Phone] [nvarchar](50) NULL,
	[Fax] [nvarchar](50) NULL,
	[Email] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[City] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[Zip] [nvarchar](20) NULL,
	[Country] [nvarchar](50) NULL,
	[LoginName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Schools] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 31/1/2021 10:23:12 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[MemberID] [int] NOT NULL,
	[FullName] [nvarchar](255) NULL,
	[Gender] [nvarchar](50) NULL,
	[Birthdate] [date] NULL,
	[Phone] [nvarchar](50) NULL,
	[Email] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[City] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[Zip] [nvarchar](20) NULL,
	[Country] [nvarchar](50) NULL,
	[School] [nvarchar](255) NULL,
	[JobSector] [nvarchar](255) NULL,
	[Specialty] [nvarchar](255) NULL,
	[LoginName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Graduates]    Script Date: 31/1/2021 10:23:12 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Graduates](
	[MemberID] [int] NOT NULL,
	[FullName] [nvarchar](255) NULL,
	[Gender] [nvarchar](50) NULL,
	[Birthdate] [date] NULL,
	[Phone] [nvarchar](50) NULL,
	[Email] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[City] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[Zip] [nvarchar](20) NULL,
	[Country] [nvarchar](50) NULL,
	[School] [nvarchar](255) NULL,
	[JobSector] [nvarchar](255) NULL,
	[Specialty] [nvarchar](255) NULL,
	[LoginName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Graduates] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 31/1/2021 10:23:12 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[MemberID] [int] NOT NULL,
	[FullName] [nvarchar](255) NULL,
	[Gender] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Fax] [nvarchar](50) NULL,
	[Email] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[City] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[Zip] [nvarchar](20) NULL,
	[Country] [nvarchar](50) NULL,
	[School] [nvarchar](255) NULL,
	[JobSector] [nvarchar](255) NULL,
	[TeachingYears] [nvarchar](50) NULL,
	[LoginName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Teachers] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ambassadors]    Script Date: 31/1/2021 10:23:12 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ambassadors](
	[MemberID] [int] NOT NULL,
	[FullName] [nvarchar](255) NULL,
	[Gender] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Fax] [nvarchar](50) NULL,
	[Email] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[City] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[Zip] [nvarchar](20) NULL,
	[Country] [nvarchar](50) NULL,
	[JobSector] [nvarchar](255) NULL,
	[Employer] [nvarchar](255) NULL,
	[WorkingYears] [nvarchar](50) NULL,
	[LoginName] [nvarchar](50) NULL,
 CONSTRAINT [PK_BusinessAmbassadors] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LiaisonOfficers]    Script Date: 31/1/2021 10:23:12 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LiaisonOfficers](
	[MemberID] [int] NOT NULL,
	[FullName] [nvarchar](255) NULL,
	[Gender] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Fax] [nvarchar](50) NULL,
	[Email] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[City] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[Zip] [nvarchar](20) NULL,
	[Country] [nvarchar](50) NULL,
	[JobSector] [nvarchar](255) NULL,
	[Employer] [nvarchar](255) NULL,
	[WorkingYears] [nvarchar](50) NULL,
	[LoginName] [nvarchar](50) NULL,
 CONSTRAINT [PK_LiaisonOfficers] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employers]    Script Date: 31/1/2021 10:23:12 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employers](
	[MemberID] [int] NOT NULL,
	[TradeName] [nvarchar](255) NULL,
	[ContactPerson] [nvarchar](255) NULL,
	[Phone] [nvarchar](50) NULL,
	[Fax] [nvarchar](50) NULL,
	[Email] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[City] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[Zip] [nvarchar](20) NULL,
	[Country] [nvarchar](50) NULL,
	[JobSector] [nvarchar](255) NULL,
	[LoginName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Employers] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[qryMembersUnion]    Script Date: 31/1/2021 10:23:12 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qryMembersUnion]
AS
SELECT   MemberID, FullName AS Name, Email, Address + N', ' + ISNULL(City, N'') + N', ' + ISNULL(Zip, '') AS FullAddress, Country, LoginName
FROM      dbo.Ambassadors
UNION
SELECT   MemberID, TradeName AS Name, Email, Address + N', ' + ISNULL(City, N'') + N', ' + ISNULL(Zip, '') AS FullAddress, Country, LoginName
FROM      dbo.Employers
UNION
SELECT   MemberID, FullName AS Name, Email, Address + N', ' + ISNULL(City, N'') + N', ' + ISNULL(Zip, '') AS FullAddress, Country, LoginName
FROM      dbo.Graduates
UNION
SELECT   MemberID, FullName AS Name, Email, Address + N', ' + ISNULL(City, N'') + N', ' + ISNULL(Zip, '') AS FullAddress, Country, LoginName
FROM      dbo.LiaisonOfficers
UNION
SELECT   MemberID, OrganizationName AS Name, Email, Address + N', ' + ISNULL(City, N'') + N', ' + ISNULL(Zip, '') AS FullAddress, Country, LoginName
FROM      dbo.Organizations
UNION
SELECT   MemberID, SchoolName AS Name, Email, Address + N', ' + ISNULL(City, N'') + N', ' + ISNULL(Zip, '') AS FullAddress, Country, LoginName
FROM      dbo.Schools
UNION
SELECT   MemberID, FullName AS Name, Email, Address + N', ' + ISNULL(City, N'') + N', ' + ISNULL(Zip, '') AS FullAddress, Country, LoginName
FROM      dbo.Students
UNION
SELECT   MemberID, FullName AS Name, Email, Address + N', ' + ISNULL(City, N'') + N', ' + ISNULL(Zip, '') AS FullAddress, Country, LoginName
FROM      dbo.Teachers
GO
/****** Object:  View [dbo].[sql_MembersAll]    Script Date: 31/1/2021 10:23:12 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[sql_MembersAll]
AS
SELECT   MemberID, Name, Email, FullAddress, Country, LoginName
FROM      dbo.qryMembersUnion
GO
/****** Object:  Table [dbo].[Articles]    Script Date: 31/1/2021 10:23:12 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articles](
	[ArticleId] [int] NOT NULL,
	[ArticleDate] [date] NULL,
	[AuthorName] [nvarchar](255) NULL,
	[Title] [nvarchar](255) NULL,
	[Description] [nvarchar](max) NULL,
	[Country] [nvarchar](50) NULL,
	[ArticleMemberID] [int] NULL,
 CONSTRAINT [PK_Articles] PRIMARY KEY CLUSTERED 
(
	[ArticleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[rep_MembersArticles]    Script Date: 31/1/2021 10:23:12 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[rep_MembersArticles]
AS
SELECT   dbo.sql_MembersAll.MemberID, dbo.sql_MembersAll.Name, dbo.sql_MembersAll.Email, dbo.sql_MembersAll.FullAddress, dbo.sql_MembersAll.Country, dbo.sql_MembersAll.LoginName, dbo.Articles.ArticleDate, dbo.Articles.AuthorName, 
                dbo.Articles.Title, dbo.Articles.Description
FROM      dbo.sql_MembersAll INNER JOIN
                dbo.Articles ON dbo.sql_MembersAll.MemberID = dbo.Articles.ArticleMemberID
GO
/****** Object:  Table [dbo].[Apprenticeships]    Script Date: 31/1/2021 10:23:12 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Apprenticeships](
	[ApprenticeshipID] [int] NOT NULL,
	[PostDate] [date] NULL,
	[Title] [nvarchar](255) NULL,
	[Description] [nvarchar](max) NULL,
	[DurationMonths] [nvarchar](50) NULL,
	[Commitment] [nvarchar](50) NULL,
	[Compensation] [nvarchar](50) NULL,
	[JobSector] [nvarchar](255) NULL,
	[Country] [nvarchar](50) NULL,
	[Requirements] [nvarchar](max) NULL,
	[EmployerID] [int] NULL,
 CONSTRAINT [PK_Apprenticeships] PRIMARY KEY CLUSTERED 
(
	[ApprenticeshipID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[rep_MembersApprenticeships]    Script Date: 31/1/2021 10:23:12 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[rep_MembersApprenticeships]
AS
SELECT   dbo.Apprenticeships.ApprenticeshipID AS AppID, dbo.Employers.MemberID, dbo.Employers.TradeName, dbo.Employers.Phone, dbo.Employers.Email, dbo.Apprenticeships.PostDate, dbo.Apprenticeships.Title, dbo.Apprenticeships.Description, 
                dbo.Apprenticeships.DurationMonths, dbo.Apprenticeships.Commitment, dbo.Apprenticeships.Compensation, dbo.Apprenticeships.JobSector, dbo.Apprenticeships.Country
FROM      dbo.Employers INNER JOIN
                dbo.Apprenticeships ON dbo.Employers.MemberID = dbo.Apprenticeships.EmployerID
GO
/****** Object:  Table [dbo].[Commitments]    Script Date: 31/1/2021 10:23:12 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Commitments](
	[CommitmentID] [int] IDENTITY(1,1) NOT NULL,
	[CommitmentText] [nvarchar](50) NULL,
 CONSTRAINT [PK_Commitments] PRIMARY KEY CLUSTERED 
(
	[CommitmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 31/1/2021 10:23:12 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[CountryID] [int] IDENTITY(1,1) NOT NULL,
	[CountryName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Durations]    Script Date: 31/1/2021 10:23:12 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Durations](
	[DurationID] [int] IDENTITY(1,1) NOT NULL,
	[DurationMonths] [nvarchar](20) NULL,
 CONSTRAINT [PK_Durations] PRIMARY KEY CLUSTERED 
(
	[DurationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genders]    Script Date: 31/1/2021 10:23:12 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genders](
	[GenderID] [int] IDENTITY(1,1) NOT NULL,
	[GenderText] [nvarchar](20) NULL,
 CONSTRAINT [PK_Genders] PRIMARY KEY CLUSTERED 
(
	[GenderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JobSectors]    Script Date: 31/1/2021 10:23:12 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JobSectors](
	[JobSectorID] [int] IDENTITY(1,1) NOT NULL,
	[JobSectorText] [nvarchar](255) NULL,
 CONSTRAINT [PK_JobSectors] PRIMARY KEY CLUSTERED 
(
	[JobSectorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MemberGroups]    Script Date: 31/1/2021 10:23:12 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MemberGroups](
	[MemberGroupID] [int] IDENTITY(1,1) NOT NULL,
	[MemberGroupText] [nvarchar](50) NULL,
 CONSTRAINT [PK_MemberTypes] PRIMARY KEY CLUSTERED 
(
	[MemberGroupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Ambassadors] ([MemberID], [FullName], [Gender], [Phone], [Fax], [Email], [Address], [City], [State], [Zip], [Country], [JobSector], [Employer], [WorkingYears], [LoginName]) VALUES (1271, N'Pedro Afonso', N'Male', N'2106878934', N'', N'business1@example.com', N'Plateia Georgiou 21', N'Athens', N'Attiki', N'11234', N'Greece', N'Recruitment and Human Resouces', N'Manpower Employment Organization (OAED)', N'24', N'business1')
INSERT [dbo].[Ambassadors] ([MemberID], [FullName], [Gender], [Phone], [Fax], [Email], [Address], [City], [State], [Zip], [Country], [JobSector], [Employer], [WorkingYears], [LoginName]) VALUES (1272, N'Elizabeth Brown', N'Female', N'(5) 555-3932', N'', N'business2@example.com', N'Mataderos  2312', N'Madrid', N'', N'05023', N'Spain', N'Retail and Sales', N'Great Lakes Food Market', N'12', N'business2')
INSERT [dbo].[Ambassadors] ([MemberID], [FullName], [Gender], [Phone], [Fax], [Email], [Address], [City], [State], [Zip], [Country], [JobSector], [Employer], [WorkingYears], [LoginName]) VALUES (1273, N'Sven Ottlieb', N'Male', N'0452-076545', N'', N'business3@example.com', N'Hauptstr. 29', N'Hamburg', N'', N'52066', N'Germany', N'Media and Internet', N'Electronic Arts', N'6', N'business3')
INSERT [dbo].[Ambassadors] ([MemberID], [FullName], [Gender], [Phone], [Fax], [Email], [Address], [City], [State], [Zip], [Country], [JobSector], [Employer], [WorkingYears], [LoginName]) VALUES (1274, N'Janine Labrune', N'Female', N'0241-039123', N'', N'business4@example.com', N'Walserweg 21', N'Roterdam', N'', N'44000', N'Netherlands', N'Marketing, Advertising and Public Relations', N'Frankenversand Gmbh', N'11', N'business4')
INSERT [dbo].[Ambassadors] ([MemberID], [FullName], [Gender], [Phone], [Fax], [Email], [Address], [City], [State], [Zip], [Country], [JobSector], [Employer], [WorkingYears], [LoginName]) VALUES (1275, N'Ann Devon', N'Female', N'0452-076545', N'', N'business5@example.com', N'Berkeley Gardens 12  Brewery', N'Dublin', N'', N'T2F 8M4', N'Ireland', N'Recruitment and Human Resouces', N'Franchi S.p.A.', N'14', N'business5')
GO
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [PostDate], [Title], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Requirements], [EmployerID]) VALUES (1437, CAST(N'2021-01-04' AS Date), N'Apprenticeship at International Relations Office', N'General informationThe International Relations office at the University of Economics - Varna, Bulgaria, is looking for an intern for the coming semester 2021.
UE - VARNA International Relations Office is providing opportunities for students and undergraduates to gain real work experience in the international environment. We are looking for interns at the International Office at UE -VARNA. The internship involves translating, office administrative work, connecting relations with other universities, informing students and other people about Erasmus+ programs. The trainee is expected to have B1 level of English, any other language is an advantage. The interns will also have the chance to get experience in designing and implementing EU projects such as Youth Projects and new term Erasmus+ KA2 Strategic Partner.', N'6 months', N'Full-Time', N'Financial compensation', N'Training and Education, Recruitment and Human Resources', N'Bulgaria', NULL, 1267)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [PostDate], [Title], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Requirements], [EmployerID]) VALUES (1438, CAST(N'2021-01-13' AS Date), N'Graphic Designer - Visual Communication', N'General informationDuration: 6 monthsCommitment: Full-timeDescription: 
OFoundation
We are a Social Enterprise that creates Successful Brands on online marketplaces.
We focus on retail brands that are active in online marketplaces like Amazon. If you join us, you will have a great opportunity to work with all our brands and on multiple projects.
We want passionate and self-driven individuals with a real strive for improving themselves – who will enjoy a dynamic and creative environment where they can try new things and be themselves.
Join us now to expand your skills, learn new ones, and to work in a real-world environment with a global outreach.', N'6 months', N'Full-Time', N'Financial compensation', N'Creative Arts and Design, Media and Internet, Business, Consulting and Management', N'Portugal', NULL, 1268)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [PostDate], [Title], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Requirements], [EmployerID]) VALUES (1439, CAST(N'2021-01-20' AS Date), N'Mechanical Engineering Technician', N'General informationOFoundation
We are a Social Enterprise that creates Successful Brands on online marketplaces.
We focus on retail brands that are active in online marketplaces like Amazon. If you join us, you will have a great opportunity to work with all our brands and on multiple projects.
We want passionate and self-driven individuals with a real strive for improving themselves – who will enjoy a dynamic and creative environment where they can try new things and be themselves.
Join us now to expand your skills, learn new ones, and to work in a real-world environment with a global outreach.', N'12 months', N'Part-Time', N'No financial compensation', N'Engineering and Manufacturing, Energy and Utilities', N'Greece', NULL, 1269)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [PostDate], [Title], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Requirements], [EmployerID]) VALUES (1440, CAST(N'2020-12-07' AS Date), N'Moodle Designer /Developer', N'About us: 
AGIFODENT is a non profit organization that was born in Granada at the end of 2002 in order to inform and educate all users and institutions in matters of European educational programs. Over nearly a decade of travel, our organization has defined its objectives in terms of social and educational needs, being its main aim to organise and manage as intermediary organisation several traineeships under the programme Erasmus+ KA1, for European students. Agifodent is member of CECE Granada, a regional network for private and semi public education centres at all levels (early childhood education, primary, secondary and VET education). Therefore, the traineeship will be developed in one of these member centres and always under the supervision and guidance of Agifodent, and according to the CV and preferences of the trainee.', N'6 months', N'Part-Time', N'Financial compensation', N'Engineering and Manufacturing, Information Technology, Media and Internet', N'Greece', NULL, 1270)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [PostDate], [Title], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Requirements], [EmployerID]) VALUES (1441, CAST(N'2020-12-16' AS Date), N'GRAPHIC and WEB DESIGN', N'Description:
Searching for your next internship opportunity? Willing to address a new Graphic design challenge and contribute to the online growth of the positive impact solution around the world? Look no further, we are hiring!
MYWATER is seeking a candidate for a part-time GRAPHIC and WEB DESIGNER  - Remote Internship due to Covid 19 situation.
MYWATER is a smart water startup with a strong environmental and social vocation: we are on a mission to accelerate world transition to sustainable and safe water consumption. Some people call it the water fountain; we call it MYWATER.
MYWATER is a digital and contactless water refill station, sustainable alternative to the bottled water problem, implementing a circular economy and EU Green deal by addressing SDG6, SDG11, SDG12 and SDG13.', N'8 months', N'Full-Time', N'No financial compensation', N'Creative Arts and Design, Information Technology, Media and Internet', N'Italy', NULL, 1268)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [PostDate], [Title], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Requirements], [EmployerID]) VALUES (1442, CAST(N'2021-01-06' AS Date), N'Sport Events and Activities Coordinator', N'
Málaga Adventures is a tourism company located in Málaga that offers tours in the city and all around Andalusia.
From this year, it’s part of COEO, a company whose main aim is to provide the best experiences in Málaga, whether you are a tourist, an international living in Málaga or a local. 
For this reason, we are looking for interns that can help us provide the best activities, in order to create unforgettable moments and make friends in the city. 
Some of the activities provided are: beach volley, hiking, running, bike, salsa, conversation classes and yoga. 
We look for a dynamic and sporty Event and Activities Coordinator Intern that likes to stay among people and like to help organize and manage different activities. ', N'12 months', N'Part-Time', N'Financial compensation', N'Social Care, Leisure, Sport and Tourism, Healthcare', N'Italy', NULL, 1266)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [PostDate], [Title], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Requirements], [EmployerID]) VALUES (1443, CAST(N'2021-01-05' AS Date), N'Customer Service & HR Specialist', N'Description: 
OFoundation
We are a Social Enterprise that creates Successful Brands on online marketplaces.
We focus on retail brands that are active in online marketplaces like Amazon. If you join us, you will have a great opportunity to work with all our brands and on multiple projects.
We want passionate and self-driven individuals with a real strive for improving themselves – who will enjoy a dynamic and creative environment where they can try new things and be themselves.
Join us now to expand your skills, learn new ones, and to work in a real-world environment with a global outreach.', N'6 months', N'Full-Time', N'Financial compensation', N'Business, Consulting and Management, Recruitment and Human Resources, Social Care', N'Italy', NULL, 1269)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [PostDate], [Title], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Requirements], [EmployerID]) VALUES (1444, CAST(N'2021-01-14' AS Date), N'Legal Specialist', N'
OFoundation
We are a Social Enterprise that creates Successful Brands on online marketplaces.
We focus on retail brands that are active in online marketplaces like Amazon. If you join us, you will have a great opportunity to work with all our brands and on multiple projects.
We want passionate and self-driven individuals with a real strive for improving themselves – who will enjoy a dynamic and creative environment where they can try new things and be themselves.
Join us now to expand your skills, learn new ones, and to work in a real-world environment with a global outreach.', N'10 months', N'Full-Time', N'Financial compensation', N'Business, Consulting and Management, Marketing, Advertising and Public Relations, Public Services and Administration', N'Italy', NULL, 1268)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [PostDate], [Title], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Requirements], [EmployerID]) VALUES (1445, CAST(N'2021-01-17' AS Date), N'Human Resources apprentice in Barcelona or Madrid', N'Description: 
Currently for our client we are looking for new candidates to join the Human Resources department:', N'9 months', N'Full-Time', N'Financial compensation', N'Recruitment and Human Resources, Business, Consulting and Management, Charity and Voluntary Work', N'Spain', NULL, 1266)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [PostDate], [Title], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Requirements], [EmployerID]) VALUES (1446, CAST(N'2021-01-03' AS Date), N'Marketing apprentice in Barcelona', N'Description: 
Our collaborator is a leading creative agency with a training center placed in Barcelona . Company provides also business solutions in the field of graphic designing, event planning, recruitment and financial analysis. Currently they are looking for an interns to join their team in their office in Barcelona and aid the digital marketing team.', N'9 months', N'Part-Time', N'Financial compensation', N'Business, Consulting and Management, Creative Arts and Design, Marketing, Advertising and Public Relations', N'Spain', NULL, 1267)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [PostDate], [Title], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Requirements], [EmployerID]) VALUES (1447, CAST(N'2020-12-10' AS Date), N'CRYPTOCURRENCIES ANALYST IN BARCELONA', N'Description: 
VF Investment is a brand-new Financial Service provider and Investment Advisory company in Barcelona, Spain. We believe that giving resourceful information of strategy and innovation by our passionate young workers will lead to your success.
We have experienced traders and investment professionals that provide services for different segments such as Stocks, Commodity, Forex & Cryptocurrencies.
We are looking for candidates interested in cryptocurrency analysis that would like to participate in our internship program.
Due to COVID19 pandemic, we offer this internship in a smart work mode or at the office.', N'8 months', N'Full-Time', N'Financial compensation', N'Business, Consulting and Management, Information Technology', N'Spain', NULL, 1268)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [PostDate], [Title], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Requirements], [EmployerID]) VALUES (1448, CAST(N'2020-12-15' AS Date), N'Human Resources apprentice in Barcelona, Madrid', N'', N'10 months', N'Part-Time', N'No financial compensation', N'Recruitment and Human Resources, Business, Consulting and Management, Charity and Voluntary Work', N'Spain', NULL, 1268)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [PostDate], [Title], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Requirements], [EmployerID]) VALUES (1449, CAST(N'2021-01-03' AS Date), N'Marketing apprentice in Madrid', N'Description: 
Our collaborator is a leading creative agency with a training center placed in Barcelona . Company provides also business solutions in the field of graphic designing, event planning, recruitment and financial analysis. Currently they are looking for an interns to join their team in their office in Barcelona and aid the digital marketing team.', N'8 months', N'Full-Time', N'Financial compensation', N'Business, Consulting and Management, Creative Arts and Design, Information Technology', N'Spain', NULL, 1267)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [PostDate], [Title], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Requirements], [EmployerID]) VALUES (1451, CAST(N'2020-12-06' AS Date), N'Programmer', N'Description: 
Art & Science Node based in Berlin is looking for a highly talented Artist, Programmer or Developer to join us in the construction of non-commercial augmented reality platform (AR Application and interactive website) for an immersive, digital experience of artworks and future AR artistic projects. The accepted candidate will be working together with the interdisciplinary, science and art team of ASN.', N'10 months', N'Full-Time', N'Financial compensation', N'Engineering and Manufacturing, Information Technology, Media and Internet', N'Germany', NULL, 1269)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [PostDate], [Title], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Requirements], [EmployerID]) VALUES (1452, CAST(N'2021-01-11' AS Date), N'Clients Intel and Alliances Development Specialist', N'Description: 
EFMC is now offering internship opportunities for the Spring-Summer 2021 period.
Tasks: Competitive analysis / Marketing / Social Media Management / Sales / Client interactions
Field:  EU Funds program management/ Financial management / Academic research / Startup acceleration', N'12 months', N'Part-Time', N'Financial compensation', N'Business, Consulting and Management, Information Technology, Media and Internet', N'Netherlands', NULL, 1266)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [PostDate], [Title], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Requirements], [EmployerID]) VALUES (1453, CAST(N'2020-12-06' AS Date), N'Social Media Apprentice - Nightlife team - Paris', N'Description: 
EIAP is searching for a motivated, smart and dedicated person who loves communication and
international environment and is willing to work in an international organization whose aim is to
promote Erasmus+ and help international students doing their exchange in Paris.
Seeking adventure and experiance in Paris ? We are looking for outgoing, positive, and levelhead indiviuals to join our Nightlife/team in paris.
As Part of our operational team, you will support and assisit international students during them exchange to help them to make the most of thier time in Paris. 
As a communication intern you work on a dynamic team and assist the Nightlife team to work with the most prestigious & luxury clubs in Paris', N'9 months', N'Full-Time', N'Financial compensation', N'Business, Consulting and Management, Creative Arts and Design', N'Greece', NULL, 1268)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [PostDate], [Title], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Requirements], [EmployerID]) VALUES (1454, CAST(N'2021-01-07' AS Date), N'BUSINESS ADMINISTRATION TRAINEE', N'Description: 
BUSINESS ADMINISTRATION TRAINEE - Dutch, French or German speakers wanted! (Start: February/March 2021)
Location: Bratislava, Slovakia
Start: February / March 2021
Duration: 5 months minimum 
Working language: English
Company profile: 
We are preparing several internship positions in the field of Business administration in Bratislava based branches of the top international companies including Big Four accounting firms and Global Business centers.
Position description: 
Trainees will be mainly part of a OTC (Order to Cash) departments, which responsibility covers all processes related to receiving, processing and fulfilling customer`s requests for goods or services. Order to Cash department is continuously working on improvements and process enhancements to fulfill our customer`s requirements in highest quality to ensure customer satisfaction. ', N'9 months', N'Part-Time', N'Financial compensation', N'Business, Consulting and Management, Marketing, Advertising and Public Relations', N'Spain', NULL, 1267)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [PostDate], [Title], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Requirements], [EmployerID]) VALUES (1455, CAST(N'2020-11-24' AS Date), N'Social Media & Copywriter Apprentice', N'Description: 
Are you a creative individual who is passionate about writing and social media and looking for valuable, hands-on professional experience? Are you motivated to achieve high-impact growth with an interest in developing your copywriting and social media management skills?
As the Social Media & Copywriter Intern, you will write original copy and content across different formats (web, video, social media, advertising) to drive growth and play a key role in scaling THNK''s programs. The most successful Social Media & Copywriter Intern will be a quick learner with creative ideas and the ability to adapt in a fast-paced, collaborative environment.
THNK School of Creative Leadership offers interactive and experiential programs to develop creative leaders capable of delivering innovative solutions to the world''s greatest challenges. Since 2012, we''ve equipped over 6,000 participants globally with the vision, mindset, and skills to unlock their full creative leadership potential and increase their impact.', N'10 months', N'Part-Time', N'Financial compensation', N'Information Technology, Media and Internet', N'Greece', NULL, 1266)
GO
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1140, CAST(N'2021-01-03' AS Date), N'Flora MATTHAES', N'Commission welcomes political agreement on European Globalisation Adjustment Fund for displaced workers', N'The Commission welcomes the political agreement reached between the European Parliament and EU Member States in the Council on the European Globalisation Adjustment Fund for displaced workers (EGF). Pending its final approval, this agreement will allow the Fund to continue supporting workers and self-employed persons whose activity has been lost.', N'Greece', 1289)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1141, CAST(N'2021-01-05' AS Date), N'Flora MATTHAES', N'The Pact for Skills: mobilising all partners to invest in skills', N'The Pact for Skills promotes joint action to maximise the impact of investing in improving existing skills (upskilling) and training in new skills (reskilling). It calls on industry, employers, social partners, chambers of commerce, public authorities, education and training providers and employment agencies to work together and make a clear commitment to invest in training for all working age people across the Union.', N'Spain', 1266)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1142, CAST(N'2021-01-06' AS Date), N'Marta WIECZOREK', N'Questions and answers: Launching the Pact for Skills', N'The Pact for Skills is a new engagement and governance model for a joint skills endeavour. The Pact aims to mobilise and incentivise all relevant stakeholders to take concrete commitments to upskill and reskill people of working age, and, when relevant, pool efforts via partnerships. All stakeholders joining the Pact should sign up to the Charter and can benefit from EU support through networking, knowledge and guidance and resources hubs.', N'Belgium', 1281)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1143, CAST(N'2021-01-04' AS Date), N'Marta WIECZOREK, Flora MATTHAES', N'Advancing the EU social market economy: adequate minimum wages for workers across Member States', N'The current crisis has particularly hit sectors with a higher share of low-wage workers such as cleaning, retail, health and long-term care and residential care. Ensuring a decent living for workers and reducing in-work poverty is not only important during the crisis but also essential for a sustainable and inclusive economic recovery.', N'Germany', 1269)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1144, CAST(N'2021-01-07' AS Date), N'Marta WIECZOREK', N'Questions and answers: Adequate minimum wages', N'Ensuring that EU workers earn adequate wages is essential for improving their living and working conditions and for building fair and resilient economies and societies. Yet, in recent decades, low wages have not kept up with other wages, and in-work poverty has increased.', N'Italy', 1285)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1145, CAST(N'2021-01-15' AS Date), N'Enda MCNAMARA', N'Employment and Social Developments in Europe review: why social fairness and solidarity are more important than ever', N'The review notes that the COVID-19 pandemic is having profound health, economic, employment and social effects, threatening much of the progress that the EU had achieved previously. All Member States are experiencing a greater economic shock than in 2008-2009. Economic output has contracted sharply and unemployment is on the rise. The most vulnerable persons, including Europe''s youth, are hit particularly hard.', N'Germany', 1284)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1146, CAST(N'2021-01-01' AS Date), N'Laura BERARD', N'Integrating migrants and refugees into the labour market: Commission and social and economic partners relaunch cooperation', N'Today, the Commission, trade unions, chambers of commerce and employers'' organisations are renewing their cooperation to enhance the integration of migrants and refugees into the labour market. In a joint statement released today, they highlight areas for future focus, and express interest in cooperating further in the area of labour migration under the European Partnership on Integration launched in 2017.', N'Greece', 1289)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1147, CAST(N'2021-01-07' AS Date), N'Siobhán MILLBRIGHT', N'Coronavirus: European Commission calls for action in protecting seasonal workers', N'The European Commission presents Guidelines to ensure the protection of seasonal workers in the EU in the context of the coronavirus pandemic. It provides guidance to national authorities, labour inspectorates, and social partners to guarantee the rights, health and safety of seasonal workers, and to ensure that seasonal workers are aware of their rights.', N'Italy', 1300)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1148, CAST(N'2021-01-10' AS Date), N'Marta WIECZOREK', N'Questions and Answers on Youth Employment Support: a bridge to jobs for the next generation', N'The European Commission has already provided significant support to Member States to tackle the pandemic and to keep people in their jobs notably through EU funding and the SURE scheme. The Commission is now putting forward targeted initiatives to help young people to give them all possible opportunities to develop their full potential to shape the future of our continent. It is now for the Member States to prioritise these investments.', N'Greece', 1282)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1149, CAST(N'2021-01-08' AS Date), N'Siobhán MILLBRIGHT', N'Questions and answers: European Skills Agenda for sustainable competitiveness, social fairness and resilience', N'Skills are key for sustainable competitiveness, resilience and ensuring social fairness for all. Businesses need workers with the skills required to master the green and digital transitions, and people need to be able to get the right education and training to thrive in life. Skills are an answer to the need for companies to remain competitive while ensuring social fairness for all.', N'Greece', 1283)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1150, CAST(N'2021-01-10' AS Date), N'Marta WIECZOREK', N'Commission launches Youth Employment Support: a bridge to jobs for the next generation', N'The coronavirus pandemic has emphasised the often difficult start many young people face in the labour market. We need to act fast. Now is the time to direct our attention towards the next generation.', N'Belgium', 1289)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1151, CAST(N'2020-12-23' AS Date), N'Marta WIECZOREK', N'Joint statement and main messages following the Tripartite Social Summit', N'The topic of the Tripartite Social Summit was "Contribution of the Social Partners to relaunching Growth and Employment in the Aftermath of COVID-19". The discussions were structured around the following:', N'Netherlands', 1286)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1152, CAST(N'2021-01-06' AS Date), N'Marta WIECZOREK', N'Fair minimum wages: Commission launches second-stage consultation of social partners', N'The EU has been particularly hit by the coronavirus pandemic, with negative effects on Member States'' economies, businesses, and the income of workers and their families. Ensuring that all workers in the EU earn a decent living is essential for the recovery as well as for building fair and resilient economies, and minimum wages have an important role to play.Minimum wages are relevant both in countries relying solely on collectively agreed wage floors and in those with a statutory minimum wage.', N'Portugal', 1274)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1153, CAST(N'2020-12-20' AS Date), N'Siobhán MILLBRIGHT', N'Statement by Commissioner Nicolas Schmit ahead of International Workers'' Day', N'We pay tribute to the thousands of frontline workers across the Union such as health professionals, emergency responders, care workers, factory operatives, supermarket cashiers, cleaners and refuse collectors for their selfless dedication to the protection and well-being of others during the Coronavirus pandemic.', N'Belgium', 1270)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1154, CAST(N'2021-01-06' AS Date), N'Marta WIECZOREK', N'Coronavirus: EU guidance for a safe return to the workplace', N'How to ensure the health and safety of workers when they come back to the workplace? This important question is on the minds of many employers as EU countries plan or execute a progressive return to work after coronavirus. In response, the European Agency for Safety and Health at Work (EU-OSHA) has issued today guidance on coming back to work.', N'Spain', 1285)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1155, CAST(N'2021-01-14' AS Date), N'Marta WIECZOREK', N'Coronavirus: Commission presents practical guidance to ensure the free movement of critical workers', N'Today, the Commission has issued new practical advice to ensure that mobile workers within the EU, in particular those in critical occupations to fight the coronavirus pandemic, can reach their workplace.', N'Greece', 1294)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1156, CAST(N'2021-01-05' AS Date), N'Marta WIECZOREK', N'A Strong Social Europe for Just Transitions', N'The European Pillar of Social Rights sets out 20 key principles and rights essential for fair and well-functioning labour markets and welfare systems in the 21st century. The Pillar is a reference framework to drive reforms at national level. It serves as a guide for the renewed process of convergence towards better working and living conditions in Europe.', N'Italy', 1272)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1157, CAST(N'2020-12-21' AS Date), N'Sara SOUMILLION', N'European Labour Authority starts its work', N'The European Labour Authority starts its activities with an inaugural ceremony and the first meeting of its Management Board. The launch takes place two years after European Commission President Jean-Claude Juncker announced the idea for such an Authority in his 2017 State of the Union address before the European Parliament.', N'Belgium', 1271)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1158, CAST(N'2021-01-04' AS Date), N'Christian WIGAND', N'European Labour Authority starts its activities: Question and Answers', N'The European Labour Authority is the new EU agency that will contribute to fostering fairness and mutual trust in the Internal Market by ensuring that EU labour rules are enforced in a fair, simple and effective way. To this end, the Authority will support Member States in matters relating to cross-border labour mobility, including rules on the free movement of workers, the posting of workers and the coordination of social security systems.', N'Spain', 1290)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1159, CAST(N'2021-01-06' AS Date), N'Christian SPAHR', N'More efficient decision-making in social policy – Questions and Answers', N'In times of rapid, sometimes fundamental change, it is more important than ever that the EU, alongside the Member States, is able to formulate swiftly policy responses. In his State of the Union address of September 2018, President Juncker announced that it is the right time to take stock of the framework for EU decision‑making set out in the Treaties for different key policy areas, to make sure that the EU can use all the tools at its disposal and maximise its added value.', N'Spain', 1284)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1160, CAST(N'2021-01-06' AS Date), N'Christian WIGAND', N'Statement by Commissioner Thyssen ahead of International Workers'' Day', N'The European Pillar of Social Rights continuously reminds us that we have to work together to build the Social Europe we want: EU institutions, Member States and social partners - each one of us within our own competences and with our own tools. Next week, Europe''s leaders will meet in Sibiu to discuss the future of Europe. I am convinced that Social Europe will remain a top priority in the future so that everybody can build further on what we have achieved so far for the benefit of all.”', N'Netherlands', 1282)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1161, CAST(N'2020-12-20' AS Date), N'Christian SPAHR', N'Commission launches debate on more efficient decision-making in EU social policy', N'Most social policy areas, where the EU has powers to act, are already subject to qualified majority voting. This has allowed putting in place a comprehensive social "acquis" over the years, with significant further steps under this Commission. A very limited number of areas, however, still requires unanimity among EU Member States and special legislative procedures, in which the European Parliament does not have an equal role as the Council as co-decision maker.', N'Greece', 1287)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1162, CAST(N'2020-12-18' AS Date), N'Sara SOUMILLION', N'Main messages from the Tripartite Social Summit', N'Joint statement by President of the European Commission Jean-Claude Juncker, Prime Minister of Romania Viorica Dăncilă, General-Secretary of the European Trade Union Confederation Luca Visentini and President of BusinessEurope Pierre Gattaz.', N'Italy', 1294)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1163, CAST(N'2021-01-05' AS Date), N'Christian WIGAND', N'Fair labour mobility: Commission welcomes agreement on the European Labour Authority', N'This new EU authority will support fair labour mobility within the EU, allowing citizens and businesses to seize the opportunities offered by the single market while supporting cooperation between national authorities, including in preventing and tackling social fraud and abuse.', N'Belgium', 1286)
GO
SET IDENTITY_INSERT [dbo].[Commitments] ON 

INSERT [dbo].[Commitments] ([CommitmentID], [CommitmentText]) VALUES (1, N'Full-Time')
INSERT [dbo].[Commitments] ([CommitmentID], [CommitmentText]) VALUES (2, N'Part-Time')
SET IDENTITY_INSERT [dbo].[Commitments] OFF
GO
SET IDENTITY_INSERT [dbo].[Countries] ON 

INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (1, N'Austria')
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (2, N'Belgium')
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (3, N'Bulgaria')
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (4, N'Croatia')
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (5, N'Cyprus')
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (6, N'Czechia')
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (7, N'Denmark')
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (8, N'Estonia')
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (9, N'Finland')
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (10, N'France')
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (11, N'Germany')
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (12, N'Greece')
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (13, N'Hungary')
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (14, N'Ireland')
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (15, N'Italy')
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (16, N'Latvia')
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (17, N'Lithouania')
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (18, N'Luxemburg')
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (19, N'Malta')
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (20, N'Netherlands')
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (21, N'Poland')
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (22, N'Portugal')
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (23, N'Romania')
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (24, N'Slovakia')
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (25, N'Slovenia')
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (26, N'Spain')
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (27, N'Sweden')
SET IDENTITY_INSERT [dbo].[Countries] OFF
GO
SET IDENTITY_INSERT [dbo].[Durations] ON 

INSERT [dbo].[Durations] ([DurationID], [DurationMonths]) VALUES (1, N'1 month')
INSERT [dbo].[Durations] ([DurationID], [DurationMonths]) VALUES (2, N'2 months')
INSERT [dbo].[Durations] ([DurationID], [DurationMonths]) VALUES (3, N'3 months')
INSERT [dbo].[Durations] ([DurationID], [DurationMonths]) VALUES (4, N'4 months')
INSERT [dbo].[Durations] ([DurationID], [DurationMonths]) VALUES (5, N'5 months')
INSERT [dbo].[Durations] ([DurationID], [DurationMonths]) VALUES (6, N'6 months')
INSERT [dbo].[Durations] ([DurationID], [DurationMonths]) VALUES (7, N'7 months')
INSERT [dbo].[Durations] ([DurationID], [DurationMonths]) VALUES (8, N'8 months')
INSERT [dbo].[Durations] ([DurationID], [DurationMonths]) VALUES (9, N'9 months')
INSERT [dbo].[Durations] ([DurationID], [DurationMonths]) VALUES (10, N'10 months')
INSERT [dbo].[Durations] ([DurationID], [DurationMonths]) VALUES (11, N'11 months')
INSERT [dbo].[Durations] ([DurationID], [DurationMonths]) VALUES (12, N'12 months')
SET IDENTITY_INSERT [dbo].[Durations] OFF
GO
INSERT [dbo].[Employers] ([MemberID], [TradeName], [ContactPerson], [Phone], [Fax], [Email], [Address], [City], [State], [Zip], [Country], [JobSector], [LoginName]) VALUES (1266, N'Bottom-Dollar Markets', N'Paul Seal', N'+30 2346 893', NULL, N'employer1@example.com', N'St. Peter''s Square 67', N'Some City', NULL, NULL, N'Belgium', N'Engineering and Manufacturing', N'employer1')
INSERT [dbo].[Employers] ([MemberID], [TradeName], [ContactPerson], [Phone], [Fax], [Email], [Address], [City], [State], [Zip], [Country], [JobSector], [LoginName]) VALUES (1267, N'Cactus Comidas para llevar', N'Nick Pearson', N'+45 4657 899', NULL, N'employer2@example.com', N'Argyle Avenue 22, Some District', N'Barcelona', NULL, NULL, N'Spain', N'Media and Internet', N'employer2')
INSERT [dbo].[Employers] ([MemberID], [TradeName], [ContactPerson], [Phone], [Fax], [Email], [Address], [City], [State], [Zip], [Country], [JobSector], [LoginName]) VALUES (1268, N'Centro comercial Moctezuma', N'Adam Miller', N'+33 8987 234', NULL, N'employer3@example.com', N'Street Name 1, number 56', N'Some city 2', NULL, NULL, N'Ireland', N'Leisure, Sport and Tourism', N'employer3')
INSERT [dbo].[Employers] ([MemberID], [TradeName], [ContactPerson], [Phone], [Fax], [Email], [Address], [City], [State], [Zip], [Country], [JobSector], [LoginName]) VALUES (1269, N'Consolidated Holdings', N'Harry Wilson', N'+44 6734 890', NULL, N'employer4@example.com', N'Street Name 2, Number 2', N'Some city 2', NULL, NULL, N'Netherlands', N'Creative Arts and Design', N'employer4')
INSERT [dbo].[Employers] ([MemberID], [TradeName], [ContactPerson], [Phone], [Fax], [Email], [Address], [City], [State], [Zip], [Country], [JobSector], [LoginName]) VALUES (1270, N'Drachenblut Delikatessen', N'Anna Moore', N'+34 6754 090', NULL, N'employer5@example.com', N'Street Name 3, Number 3', N'Some city 3', NULL, NULL, N'Germany', N'Environment and Agriculture', N'employer5')
GO
SET IDENTITY_INSERT [dbo].[Genders] ON 

INSERT [dbo].[Genders] ([GenderID], [GenderText]) VALUES (1, N'Male')
INSERT [dbo].[Genders] ([GenderID], [GenderText]) VALUES (2, N'Female')
SET IDENTITY_INSERT [dbo].[Genders] OFF
GO
INSERT [dbo].[Graduates] ([MemberID], [FullName], [Gender], [Birthdate], [Phone], [Email], [Address], [City], [State], [Zip], [Country], [School], [JobSector], [Specialty], [LoginName]) VALUES (1261, N'Hanna Moos', N'Female', CAST(N'1986-10-12' AS Date), N'+302106878934', N'graduate1@example.com', N'Plateia Georgiou 21', N'Athens', N'Attiki', N'11234', N'Greece', N'Vocational Institute IEK Patras', N'Engineering and Manufacturing', N'Automation Technician', N'graduate1')
INSERT [dbo].[Graduates] ([MemberID], [FullName], [Gender], [Birthdate], [Phone], [Email], [Address], [City], [State], [Zip], [Country], [School], [JobSector], [Specialty], [LoginName]) VALUES (1262, N'Frederique Citeaux', N'Prefer not to say', CAST(N'2000-10-15' AS Date), N'011-4988260', N'graduate2@example.com', N'Via Monte Bianco 34', N'Torino', N'', N'10100', N'Italy', N'Torino Technical School 1', N'Hospitality and Events Management', N'Marketing Assistant', N'graduate2')
INSERT [dbo].[Graduates] ([MemberID], [FullName], [Gender], [Birthdate], [Phone], [Email], [Address], [City], [State], [Zip], [Country], [School], [JobSector], [Specialty], [LoginName]) VALUES (1263, N'Martín Sommer', N'Male', CAST(N'2002-01-11' AS Date), N'(171) 555-0297', N'graduate3@example.com', N'35 King George St.', N'Dublin', N'', N'WX3 6FW', N'Ireland', N'Vocational Institute of Dublin', N'Medical Services and Pharmaceuticals', N'Certified nursing assistants', N'graduate3')
INSERT [dbo].[Graduates] ([MemberID], [FullName], [Gender], [Birthdate], [Phone], [Email], [Address], [City], [State], [Zip], [Country], [School], [JobSector], [Specialty], [LoginName]) VALUES (1264, N'Laurence Lebihan', N'Female', CAST(N'2001-07-13' AS Date), N'0114988260', N'graduate4@example.com', N'Via Monte Bianco 34', N'Madrid', N'', N'94117', N'Spain', N'Vocational Institute 8', N'Engineering and Manufacturing', N'Plumbing Technician', N'graduate4')
INSERT [dbo].[Graduates] ([MemberID], [FullName], [Gender], [Birthdate], [Phone], [Email], [Address], [City], [State], [Zip], [Country], [School], [JobSector], [Specialty], [LoginName]) VALUES (1265, N'Elizabeth Lincoln', N'Female', CAST(N'0001-01-01' AS Date), N'(503) 555-9573', N'graduate5@example.com', N'43 rue St. Laurent', N'City 3', N'', N'23289', N'Portugal', N'Vocational Institute 9', N'Healthcare', N'Exercise Physiologists', N'graduate5')
GO
SET IDENTITY_INSERT [dbo].[JobSectors] ON 

INSERT [dbo].[JobSectors] ([JobSectorID], [JobSectorText]) VALUES (1, N'Accountancy, Banking and Finance')
INSERT [dbo].[JobSectors] ([JobSectorID], [JobSectorText]) VALUES (2, N'Business, Consulting and Management')
INSERT [dbo].[JobSectors] ([JobSectorID], [JobSectorText]) VALUES (3, N'Charity and Voluntary Work')
INSERT [dbo].[JobSectors] ([JobSectorID], [JobSectorText]) VALUES (4, N'Creative Arts and Design')
INSERT [dbo].[JobSectors] ([JobSectorID], [JobSectorText]) VALUES (5, N'Energy and Utilities')
INSERT [dbo].[JobSectors] ([JobSectorID], [JobSectorText]) VALUES (6, N'Engineering and Manufacturing')
INSERT [dbo].[JobSectors] ([JobSectorID], [JobSectorText]) VALUES (7, N'Environment and Agriculture')
INSERT [dbo].[JobSectors] ([JobSectorID], [JobSectorText]) VALUES (8, N'Healthcare')
INSERT [dbo].[JobSectors] ([JobSectorID], [JobSectorText]) VALUES (9, N'Hospitality and Events Management')
INSERT [dbo].[JobSectors] ([JobSectorID], [JobSectorText]) VALUES (10, N'Information Technology')
INSERT [dbo].[JobSectors] ([JobSectorID], [JobSectorText]) VALUES (11, N'Law Enforcement and Security')
INSERT [dbo].[JobSectors] ([JobSectorID], [JobSectorText]) VALUES (12, N'Leisure, Sport and Tourism')
INSERT [dbo].[JobSectors] ([JobSectorID], [JobSectorText]) VALUES (13, N'Marketing, Advertising and Public Relations')
INSERT [dbo].[JobSectors] ([JobSectorID], [JobSectorText]) VALUES (14, N'Media and Internet')
INSERT [dbo].[JobSectors] ([JobSectorID], [JobSectorText]) VALUES (15, N'Property and Construction')
INSERT [dbo].[JobSectors] ([JobSectorID], [JobSectorText]) VALUES (16, N'Public Services and Administration')
INSERT [dbo].[JobSectors] ([JobSectorID], [JobSectorText]) VALUES (17, N'Recruitment and Human Resouces')
INSERT [dbo].[JobSectors] ([JobSectorID], [JobSectorText]) VALUES (18, N'Retail and Sales')
INSERT [dbo].[JobSectors] ([JobSectorID], [JobSectorText]) VALUES (19, N'Medical Services and Pharmaceuticals')
INSERT [dbo].[JobSectors] ([JobSectorID], [JobSectorText]) VALUES (20, N'Social Care')
INSERT [dbo].[JobSectors] ([JobSectorID], [JobSectorText]) VALUES (21, N'Training and Education')
INSERT [dbo].[JobSectors] ([JobSectorID], [JobSectorText]) VALUES (22, N'Transport and Logistics')
SET IDENTITY_INSERT [dbo].[JobSectors] OFF
GO
INSERT [dbo].[LiaisonOfficers] ([MemberID], [FullName], [Gender], [Phone], [Fax], [Email], [Address], [City], [State], [Zip], [Country], [JobSector], [Employer], [WorkingYears], [LoginName]) VALUES (1276, N'Roland Mendel', N'Male', N'+302346789323', N'211-4545732', N'liaison1@example.com', N'St. Peter''s Square 67', N'Some City 1', N'Region b', N'45623', N'Denmark', N'Information Technology', N'Umbraco Ltd', N'11', N'liaison1')
INSERT [dbo].[LiaisonOfficers] ([MemberID], [FullName], [Gender], [Phone], [Fax], [Email], [Address], [City], [State], [Zip], [Country], [JobSector], [Employer], [WorkingYears], [LoginName]) VALUES (1277, N'Aria Cruz', N'Female', N'0114988260', N'', N'liaison2@example.com', N'Via Monte Bianco 34', N'Torino', N'Region 6', N'10100', N'Italy', N'Environment and Agriculture', N'Seven Seas Imports', N'13', N'liaison2')
INSERT [dbo].[LiaisonOfficers] ([MemberID], [FullName], [Gender], [Phone], [Fax], [Email], [Address], [City], [State], [Zip], [Country], [JobSector], [Employer], [WorkingYears], [LoginName]) VALUES (1278, N'Diego Roel', N'Male', N'(5) 555-2933', N'', N'liaison3@example.com', N'90 Wadhurst Rd.', N'Vienna', N'Region 1', N'97201', N'Austria', N'Leisure, Sport and Tourism', N'Toms Spezialitäten', N'22', N'liaison3')
INSERT [dbo].[LiaisonOfficers] ([MemberID], [FullName], [Gender], [Phone], [Fax], [Email], [Address], [City], [State], [Zip], [Country], [JobSector], [Employer], [WorkingYears], [LoginName]) VALUES (1279, N'Martine Rancé', N'Female', N'86 21 32 43', N'', N'liaison4@example.com', N'Estrada da saúde n. 58', N'City 2', N'Region G', N'45213', N'Portugal', N'Hospitality and Events Management', N'Princesa Isabel Vinhos', N'15', N'liaison4')
INSERT [dbo].[LiaisonOfficers] ([MemberID], [FullName], [Gender], [Phone], [Fax], [Email], [Address], [City], [State], [Zip], [Country], [JobSector], [Employer], [WorkingYears], [LoginName]) VALUES (1280, N'Maria Larsson', N'Described in another way', N'0522-556721', N'0522-556721', N'liaison5@example.com', N'2817 Milton Dr.', N'City 5', N'Region A', N'65453', N'Ireland', N'Social Care', N'Rattlesnake Canyon S.A.', N'9', N'liaison5')
GO
SET IDENTITY_INSERT [dbo].[MemberGroups] ON 

INSERT [dbo].[MemberGroups] ([MemberGroupID], [MemberGroupText]) VALUES (1, N'VET Student')
INSERT [dbo].[MemberGroups] ([MemberGroupID], [MemberGroupText]) VALUES (2, N'VET Graduate')
INSERT [dbo].[MemberGroups] ([MemberGroupID], [MemberGroupText]) VALUES (3, N'VET Provider')
INSERT [dbo].[MemberGroups] ([MemberGroupID], [MemberGroupText]) VALUES (4, N'VET Teacher-Trainer')
INSERT [dbo].[MemberGroups] ([MemberGroupID], [MemberGroupText]) VALUES (5, N'Liaison Officer')
INSERT [dbo].[MemberGroups] ([MemberGroupID], [MemberGroupText]) VALUES (6, N'Business Ambassador')
INSERT [dbo].[MemberGroups] ([MemberGroupID], [MemberGroupText]) VALUES (7, N'Employer')
INSERT [dbo].[MemberGroups] ([MemberGroupID], [MemberGroupText]) VALUES (8, N'Social Partner')
SET IDENTITY_INSERT [dbo].[MemberGroups] OFF
GO
INSERT [dbo].[Organizations] ([MemberID], [OrganizationName], [ContactPerson], [Phone], [Fax], [Email], [Address], [City], [State], [Zip], [Country], [JobSector], [LoginName]) VALUES (1286, N'Association of Commercial Television in Europe (ACT)', N'Patricia Anderson', N'+32 7896123', N'+32 5435345', N'organization1@example.com', N'Another street and number', N'Paris', N'Paris', N'45623', N'France', N'Hospitality and Events Management', N'organization1')
INSERT [dbo].[Organizations] ([MemberID], [OrganizationName], [ContactPerson], [Phone], [Fax], [Email], [Address], [City], [State], [Zip], [Country], [JobSector], [LoginName]) VALUES (1287, N'Association of Mutual Insurers and Insurance Cooperatives in Europe (AMICE)', N'Giovanni Rovelli', N'(02) 201 24 67', N'', N'organization2@example.com', N'12 Orchestra Terrace', N'City 1', N'State 1', N'34598', N'France', N'Marketing, Advertising and Public Relations', N'organization2')
INSERT [dbo].[Organizations] ([MemberID], [OrganizationName], [ContactPerson], [Phone], [Fax], [Email], [Address], [City], [State], [Zip], [Country], [JobSector], [LoginName]) VALUES (1288, N'Council of European Municipalities and Regions (CEMR)', N'Yvonne Moncada', N'0221-0644327', N'0221-0644312', N'organization3@example.com', N'89 Chiaroscuro Rd.', N'City 2', N'State 2', N'545 89', N'Malta', N'Public Services and Administration', N'organization3')
INSERT [dbo].[Organizations] ([MemberID], [OrganizationName], [ContactPerson], [Phone], [Fax], [Email], [Address], [City], [State], [Zip], [Country], [JobSector], [LoginName]) VALUES (1289, N'European Association of Employers'' Organisations in Hairdressing (Coiffure EU)', N'Dominique Perrier', N'0897-034214', N'0897-034214', N'organization4@example.com', N'Grenzacherweg 237', N'City 5', N'Region 5', N'89645', N'Belgium', N'Marketing, Advertising and Public Relations', N'organization4')
INSERT [dbo].[Organizations] ([MemberID], [OrganizationName], [ContactPerson], [Phone], [Fax], [Email], [Address], [City], [State], [Zip], [Country], [JobSector], [LoginName]) VALUES (1290, N'European Coordination of Independent Producers (CEPI)', N'Helvetius Nagy', N'07-98 92 35', N'07-98 92 45', N'organization5@example.com', N'Strada Provinciale 124', N'City 6', N'Region 6', N'67123', N'Italy', N'Recruitment and Human Resouces', N'organization5')
GO
INSERT [dbo].[Schools] ([MemberID], [SchoolName], [ContactPerson], [Phone], [Fax], [Email], [Address], [City], [State], [Zip], [Country], [LoginName]) VALUES (1281, N'Hi-Tech Training', N'Rebecca Thorn', N'223- 4565456', N'223-45678 674', N'school1@example.com', N'Another street and number 2', N'Some city 3', N'Region B', N'78967', N'Malta', N'school1')
INSERT [dbo].[Schools] ([MemberID], [SchoolName], [ContactPerson], [Phone], [Fax], [Email], [Address], [City], [State], [Zip], [Country], [LoginName]) VALUES (1282, N'Dublin Vocational Academy', N'Helen Bennett', N'(5) 555-1340', N'', N'school2@example.com', N'Rue Joseph-Bens 532', N'City 2', N'Region 2', N'AB-1456', N'Ireland', N'school2')
INSERT [dbo].[Schools] ([MemberID], [SchoolName], [ContactPerson], [Phone], [Fax], [Email], [Address], [City], [State], [Zip], [Country], [LoginName]) VALUES (1283, N'Product School Athens', N'Alexopoulou Dimitra', N'210-3456 443', N'', N'school3@example.com', N'Leoforos Georgiou 11', N'Athens', N'Attica', N'11234', N'Greece', N'school3')
INSERT [dbo].[Schools] ([MemberID], [SchoolName], [ContactPerson], [Phone], [Fax], [Email], [Address], [City], [State], [Zip], [Country], [LoginName]) VALUES (1284, N'Learning Tree International', N'Carlos González', N'(1) 135-5333', N'', N'school4@example.com', N'Some street and number 5', N'City 8', N'', N'56789', N'Portugal', N'school4')
INSERT [dbo].[Schools] ([MemberID], [SchoolName], [ContactPerson], [Phone], [Fax], [Email], [Address], [City], [State], [Zip], [Country], [LoginName]) VALUES (1285, N'School Courses & Career Development', N'Rene Phillips', N'0372-035188', N'0372-035156', N'school5@example.com', N'Carrera 52 con Ave. Bolívar #65-98 Llano Largo', N'Valencia', N'', N'05487-020', N'Spain', N'school5')
GO
INSERT [dbo].[Students] ([MemberID], [FullName], [Gender], [Birthdate], [Phone], [Email], [Address], [City], [State], [Zip], [Country], [School], [JobSector], [Specialty], [LoginName]) VALUES (1256, N'Maria Anders', N'Female', CAST(N'1983-05-09' AS Date), N'+302106878934', N'student1@example.com', N'Plateia Georgiou 21', N'Athens', N'Attiki', N'11234', N'Greece', N'Vocational Institute IEK Patras', N'Transport and Logistics', N'Logistics Administrator', N'student1')
INSERT [dbo].[Students] ([MemberID], [FullName], [Gender], [Birthdate], [Phone], [Email], [Address], [City], [State], [Zip], [Country], [School], [JobSector], [Specialty], [LoginName]) VALUES (1257, N'Ana Trujillo', N'Female', CAST(N'2001-01-11' AS Date), N'(8) 34-56-12', N'student2@example.com', N'89 Chiaroscuro Rd.', N'Some city 2', N'', N'97219', N'Italy', N'Vocational Institute 3', N'Retail and Sales', N'Accounting Manager', N'student2')
INSERT [dbo].[Students] ([MemberID], [FullName], [Gender], [Birthdate], [Phone], [Email], [Address], [City], [State], [Zip], [Country], [School], [JobSector], [Specialty], [LoginName]) VALUES (1258, N'Antonio Moreno', N'Male', CAST(N'2003-08-12' AS Date), N'035-640230', N'student3@example.com', N'Ave. 5 de Mayo Porlamar', N'City 5', N'', N'14776', N'Netherlands', N'Vocational Institute 4', N'Information Technology', N'Web Designer', N'student3')
INSERT [dbo].[Students] ([MemberID], [FullName], [Gender], [Birthdate], [Phone], [Email], [Address], [City], [State], [Zip], [Country], [School], [JobSector], [Specialty], [LoginName]) VALUES (1259, N'Thomas Hardy', N'Male', CAST(N'2000-03-04' AS Date), N'(93) 203 4560', N'student4@example.com', N'City Center Plaza 516 Main St.', N'Versailles', N'', N'78000', N'France', N'Technical School for BA', N'Business, Consulting and Management', N'Sales Representative', N'student4')
INSERT [dbo].[Students] ([MemberID], [FullName], [Gender], [Birthdate], [Phone], [Email], [Address], [City], [State], [Zip], [Country], [School], [JobSector], [Specialty], [LoginName]) VALUES (1260, N'Christina Berglund', N'Female', CAST(N'2002-01-11' AS Date), N'0114988260', N'student5@example.com', N'Via Monte Bianco 34', N'City 5', N'', N'45678', N'Ireland', N'Technical College 8', N'Environment and Agriculture', N'Agricultural Inspectors', N'student5')
INSERT [dbo].[Students] ([MemberID], [FullName], [Gender], [Birthdate], [Phone], [Email], [Address], [City], [State], [Zip], [Country], [School], [JobSector], [Specialty], [LoginName]) VALUES (1296, N'Catherine Dewey', N'Female', CAST(N'2001-03-23' AS Date), N'0555-09876', N'student6@example.com', N'Ave. 5 de Mayo Porlamar', N'City 8', N'', N'23489', N'Ireland', N'Technical College 8', N'Environment and Agriculture', N'Agricultural Inspectors', N'student6')
GO
INSERT [dbo].[Teachers] ([MemberID], [FullName], [Gender], [Phone], [Fax], [Email], [Address], [City], [State], [Zip], [Country], [School], [JobSector], [TeachingYears], [LoginName]) VALUES (1291, N'Simon Crowther', N'Male', N'+302346789323', NULL, N'teacher1@example.com', N'St. Peter''s Square 67', N'Some City', N'Region A', N'45623', N'Luxemburg', N'Vocational Institute IEK Creta', N'Creative Arts and Design', N'12', N'teacher1')
INSERT [dbo].[Teachers] ([MemberID], [FullName], [Gender], [Phone], [Fax], [Email], [Address], [City], [State], [Zip], [Country], [School], [JobSector], [TeachingYears], [LoginName]) VALUES (1292, N'Yvonne Moncada', N'Female', N'07-98 92 35', NULL, N'teacher2@example.com', N'Erling Skakkes gate 78', N'City 8', N'Region 8', N'zip 8', N'Netherlands', N'Ofsio Technical School', N'Recruitment and Human Resouces', N'5', N'teacher2')
INSERT [dbo].[Teachers] ([MemberID], [FullName], [Gender], [Phone], [Fax], [Email], [Address], [City], [State], [Zip], [Country], [School], [JobSector], [TeachingYears], [LoginName]) VALUES (1293, N'Henriette Pfalzheim', N'Female', N'(071) 23 67 22 20', NULL, N'teacher3@example.com', N'(071) 23 67 22 34', N'City 5', N'Region 5', N'zip 5', N'Spain', N'Ofistic Technical School', N'Leisure, Sport and Tourism', N'12', N'teacher3')
INSERT [dbo].[Teachers] ([MemberID], [FullName], [Gender], [Phone], [Fax], [Email], [Address], [City], [State], [Zip], [Country], [School], [JobSector], [TeachingYears], [LoginName]) VALUES (1294, N'Guillermo Fernández', N'Male', N'0711-020361', NULL, N'teacher4@example.com', N'2, rue du Commerce', N'Lyon', N'Region 3', N'69004', N'France', N'Techgenix Technical School', N'Public Services and Administration', N'13', N'teacher4')
INSERT [dbo].[Teachers] ([MemberID], [FullName], [Gender], [Phone], [Fax], [Email], [Address], [City], [State], [Zip], [Country], [School], [JobSector], [TeachingYears], [LoginName]) VALUES (1295, N'Isabel de Castro', N'Female', N'981-443655', NULL, N'teacher5@example.com', N'Jardim das rosas n. 32', N'Lisbon', N'Region 7', N'4353453', N'Portugal', N'TeachnoCart Institute', N'Information Technology', N'11', N'teacher5')
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[26] 4[21] 2[21] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[7] 2[46] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 4245
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 5625
         Alias = 3150
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qryMembersUnion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qryMembersUnion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[21] 4[22] 2[9] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Employers"
            Begin Extent = 
               Top = 5
               Left = 2
               Bottom = 145
               Right = 176
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "Apprenticeships"
            Begin Extent = 
               Top = 7
               Left = 288
               Bottom = 147
               Right = 476
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 14
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 3075
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'rep_MembersApprenticeships'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'rep_MembersApprenticeships'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[23] 4[22] 2[9] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "sql_MembersAll"
            Begin Extent = 
               Top = 4
               Left = 7
               Bottom = 160
               Right = 238
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Articles"
            Begin Extent = 
               Top = 0
               Left = 311
               Bottom = 159
               Right = 551
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 2085
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1890
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'rep_MembersArticles'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'rep_MembersArticles'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[21] 4[20] 2[6] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "qryMembersUnion"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 146
               Right = 235
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 2190
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_MembersAll'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_MembersAll'
GO
USE [master]
GO
ALTER DATABASE [AppinternWorks] SET  READ_WRITE 
GO
