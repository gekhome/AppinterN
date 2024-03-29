USE [AppinternWorks]
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_MembersTotal'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_MembersTotal'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_MembersAll'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_MembersAll'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountUnionAll'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountUnionAll'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountTeacher'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountTeacher'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountStudent'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountStudent'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountSchool'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountSchool'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountOrganization'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountOrganization'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountLiaison'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountLiaison'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountGraduate'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountGraduate'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountEmployer'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountEmployer'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountAmbassador'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountAmbassador'
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
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qryCountMembers'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qryCountMembers'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'chartCountMembers'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'chartCountMembers'
GO
/****** Object:  StoredProcedure [dbo].[usp_record_view]    Script Date: 16/3/2021 6:45:54 πμ ******/
DROP PROCEDURE [dbo].[usp_record_view]
GO
/****** Object:  StoredProcedure [dbo].[usp_get_view_count]    Script Date: 16/3/2021 6:45:54 πμ ******/
DROP PROCEDURE [dbo].[usp_get_view_count]
GO
/****** Object:  Table [dbo].[tbl_hit_counter]    Script Date: 16/3/2021 6:45:54 πμ ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_hit_counter]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_hit_counter]
GO
/****** Object:  Table [dbo].[MemberGroups]    Script Date: 16/3/2021 6:45:54 πμ ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MemberGroups]') AND type in (N'U'))
DROP TABLE [dbo].[MemberGroups]
GO
/****** Object:  Table [dbo].[JobSectors]    Script Date: 16/3/2021 6:45:54 πμ ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[JobSectors]') AND type in (N'U'))
DROP TABLE [dbo].[JobSectors]
GO
/****** Object:  Table [dbo].[Genders]    Script Date: 16/3/2021 6:45:54 πμ ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Genders]') AND type in (N'U'))
DROP TABLE [dbo].[Genders]
GO
/****** Object:  Table [dbo].[Durations]    Script Date: 16/3/2021 6:45:54 πμ ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Durations]') AND type in (N'U'))
DROP TABLE [dbo].[Durations]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 16/3/2021 6:45:54 πμ ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Countries]') AND type in (N'U'))
DROP TABLE [dbo].[Countries]
GO
/****** Object:  Table [dbo].[Commitments]    Script Date: 16/3/2021 6:45:54 πμ ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Commitments]') AND type in (N'U'))
DROP TABLE [dbo].[Commitments]
GO
/****** Object:  View [dbo].[chartCountMembers]    Script Date: 16/3/2021 6:45:54 πμ ******/
DROP VIEW [dbo].[chartCountMembers]
GO
/****** Object:  View [dbo].[rep_MembersApprenticeships]    Script Date: 16/3/2021 6:45:54 πμ ******/
DROP VIEW [dbo].[rep_MembersApprenticeships]
GO
/****** Object:  Table [dbo].[Apprenticeships]    Script Date: 16/3/2021 6:45:54 πμ ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Apprenticeships]') AND type in (N'U'))
DROP TABLE [dbo].[Apprenticeships]
GO
/****** Object:  View [dbo].[rep_MembersArticles]    Script Date: 16/3/2021 6:45:54 πμ ******/
DROP VIEW [dbo].[rep_MembersArticles]
GO
/****** Object:  Table [dbo].[Articles]    Script Date: 16/3/2021 6:45:54 πμ ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Articles]') AND type in (N'U'))
DROP TABLE [dbo].[Articles]
GO
/****** Object:  View [dbo].[qryCountMembers]    Script Date: 16/3/2021 6:45:54 πμ ******/
DROP VIEW [dbo].[qryCountMembers]
GO
/****** Object:  View [dbo].[sql_CountUnionAll]    Script Date: 16/3/2021 6:45:54 πμ ******/
DROP VIEW [dbo].[sql_CountUnionAll]
GO
/****** Object:  View [dbo].[sql_CountOrganization]    Script Date: 16/3/2021 6:45:54 πμ ******/
DROP VIEW [dbo].[sql_CountOrganization]
GO
/****** Object:  View [dbo].[sql_CountLiaison]    Script Date: 16/3/2021 6:45:54 πμ ******/
DROP VIEW [dbo].[sql_CountLiaison]
GO
/****** Object:  View [dbo].[sql_CountGraduate]    Script Date: 16/3/2021 6:45:54 πμ ******/
DROP VIEW [dbo].[sql_CountGraduate]
GO
/****** Object:  View [dbo].[sql_CountEmployer]    Script Date: 16/3/2021 6:45:54 πμ ******/
DROP VIEW [dbo].[sql_CountEmployer]
GO
/****** Object:  View [dbo].[sql_CountAmbassador]    Script Date: 16/3/2021 6:45:54 πμ ******/
DROP VIEW [dbo].[sql_CountAmbassador]
GO
/****** Object:  View [dbo].[sql_CountTeacher]    Script Date: 16/3/2021 6:45:54 πμ ******/
DROP VIEW [dbo].[sql_CountTeacher]
GO
/****** Object:  View [dbo].[sql_CountStudent]    Script Date: 16/3/2021 6:45:54 πμ ******/
DROP VIEW [dbo].[sql_CountStudent]
GO
/****** Object:  View [dbo].[sql_CountSchool]    Script Date: 16/3/2021 6:45:54 πμ ******/
DROP VIEW [dbo].[sql_CountSchool]
GO
/****** Object:  View [dbo].[sql_MembersTotal]    Script Date: 16/3/2021 6:45:54 πμ ******/
DROP VIEW [dbo].[sql_MembersTotal]
GO
/****** Object:  View [dbo].[sql_MembersAll]    Script Date: 16/3/2021 6:45:54 πμ ******/
DROP VIEW [dbo].[sql_MembersAll]
GO
/****** Object:  View [dbo].[qryMembersUnion]    Script Date: 16/3/2021 6:45:54 πμ ******/
DROP VIEW [dbo].[qryMembersUnion]
GO
/****** Object:  Table [dbo].[Employers]    Script Date: 16/3/2021 6:45:54 πμ ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Employers]') AND type in (N'U'))
DROP TABLE [dbo].[Employers]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 16/3/2021 6:45:54 πμ ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Teachers]') AND type in (N'U'))
DROP TABLE [dbo].[Teachers]
GO
/****** Object:  Table [dbo].[Schools]    Script Date: 16/3/2021 6:45:54 πμ ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Schools]') AND type in (N'U'))
DROP TABLE [dbo].[Schools]
GO
/****** Object:  Table [dbo].[Organizations]    Script Date: 16/3/2021 6:45:54 πμ ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Organizations]') AND type in (N'U'))
DROP TABLE [dbo].[Organizations]
GO
/****** Object:  Table [dbo].[LiaisonOfficers]    Script Date: 16/3/2021 6:45:54 πμ ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LiaisonOfficers]') AND type in (N'U'))
DROP TABLE [dbo].[LiaisonOfficers]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 16/3/2021 6:45:54 πμ ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Students]') AND type in (N'U'))
DROP TABLE [dbo].[Students]
GO
/****** Object:  Table [dbo].[Graduates]    Script Date: 16/3/2021 6:45:54 πμ ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Graduates]') AND type in (N'U'))
DROP TABLE [dbo].[Graduates]
GO
/****** Object:  Table [dbo].[Ambassadors]    Script Date: 16/3/2021 6:45:54 πμ ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Ambassadors]') AND type in (N'U'))
DROP TABLE [dbo].[Ambassadors]
GO
/****** Object:  User [umbraco]    Script Date: 16/3/2021 6:45:54 πμ ******/
DROP USER [umbraco]
GO
USE [master]
GO
/****** Object:  Database [AppinternWorks]    Script Date: 16/3/2021 6:45:54 πμ ******/
DROP DATABASE [AppinternWorks]
GO
/****** Object:  Database [AppinternWorks]    Script Date: 16/3/2021 6:45:54 πμ ******/
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
/****** Object:  User [umbraco]    Script Date: 16/3/2021 6:45:55 πμ ******/
CREATE USER [umbraco] FOR LOGIN [umbraco] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [umbraco]
GO
ALTER ROLE [db_datareader] ADD MEMBER [umbraco]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [umbraco]
GO
/****** Object:  Table [dbo].[Ambassadors]    Script Date: 16/3/2021 6:45:55 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ambassadors](
	[MemberID] [int] NOT NULL,
	[TaxNumber] [nvarchar](50) NULL,
	[FullName] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[Country] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Email] [nvarchar](255) NULL,
	[Website] [nvarchar](255) NULL,
	[SocialMedia] [nvarchar](255) NULL,
	[Occupation] [nvarchar](255) NULL,
	[JobSector] [nvarchar](255) NULL,
	[Employer] [nvarchar](255) NULL,
	[LoginName] [nvarchar](50) NULL,
 CONSTRAINT [PK_BusinessAmbassadors] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Graduates]    Script Date: 16/3/2021 6:45:55 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Graduates](
	[MemberID] [int] NOT NULL,
	[TaxNumber] [nvarchar](50) NULL,
	[FullName] [nvarchar](255) NULL,
	[Birthdate] [date] NULL,
	[Gender] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Email] [nvarchar](255) NULL,
	[Country] [nvarchar](50) NULL,
	[Specialization] [nvarchar](255) NULL,
	[School] [nvarchar](255) NULL,
	[LoginName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Graduates] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 16/3/2021 6:45:55 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[MemberID] [int] NOT NULL,
	[TaxNumber] [nvarchar](50) NULL,
	[FullName] [nvarchar](255) NULL,
	[Birthdate] [date] NULL,
	[Gender] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Email] [nvarchar](255) NULL,
	[Country] [nvarchar](50) NULL,
	[Specialization] [nvarchar](255) NULL,
	[School] [nvarchar](255) NULL,
	[LoginName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LiaisonOfficers]    Script Date: 16/3/2021 6:45:55 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LiaisonOfficers](
	[MemberID] [int] NOT NULL,
	[TaxNumber] [nvarchar](50) NULL,
	[FullName] [nvarchar](255) NULL,
	[Country] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Email] [nvarchar](255) NULL,
	[OfficeAddress] [nvarchar](255) NULL,
	[Occupation] [nvarchar](255) NULL,
	[Employer] [nvarchar](255) NULL,
	[LoginName] [nvarchar](50) NULL,
 CONSTRAINT [PK_LiaisonOfficers] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Organizations]    Script Date: 16/3/2021 6:45:55 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Organizations](
	[MemberID] [int] NOT NULL,
	[TaxNumber] [nvarchar](50) NULL,
	[OrganizationName] [nvarchar](255) NULL,
	[ContactPerson] [nvarchar](255) NULL,
	[Country] [nvarchar](50) NULL,
	[Headquarters] [nvarchar](255) NULL,
	[JobSector] [nvarchar](255) NULL,
	[Phone] [nvarchar](50) NULL,
	[Email] [nvarchar](255) NULL,
	[Website] [nvarchar](255) NULL,
	[SocialMedia] [nvarchar](255) NULL,
	[LoginName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Organizations] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Schools]    Script Date: 16/3/2021 6:45:55 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schools](
	[MemberID] [int] NOT NULL,
	[TaxNumber] [nvarchar](50) NULL,
	[SchoolName] [nvarchar](255) NULL,
	[ContactPerson] [nvarchar](255) NULL,
	[Country] [nvarchar](50) NULL,
	[Address] [nvarchar](255) NULL,
	[Phone] [nvarchar](50) NULL,
	[Email] [nvarchar](255) NULL,
	[Website] [nvarchar](255) NULL,
	[SocialMedia] [nvarchar](255) NULL,
	[LoginName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Schools] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 16/3/2021 6:45:55 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[MemberID] [int] NOT NULL,
	[TaxNumber] [nvarchar](50) NULL,
	[FullName] [nvarchar](255) NULL,
	[Country] [nvarchar](50) NULL,
	[School] [nvarchar](255) NULL,
	[SchoolAddress] [nvarchar](255) NULL,
	[Phone] [nvarchar](50) NULL,
	[Email] [nvarchar](255) NULL,
	[SocialMedia] [nvarchar](255) NULL,
	[LoginName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Teachers] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employers]    Script Date: 16/3/2021 6:45:55 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employers](
	[MemberID] [int] NOT NULL,
	[TaxNumber] [nvarchar](50) NULL,
	[CompanyName] [nvarchar](255) NULL,
	[ContactPerson] [nvarchar](255) NULL,
	[Headquarters] [nvarchar](255) NULL,
	[Country] [nvarchar](50) NULL,
	[JobSector1] [nvarchar](255) NULL,
	[JobSector2] [nvarchar](255) NULL,
	[JobSector3] [nvarchar](255) NULL,
	[Phone] [nvarchar](50) NULL,
	[Email] [nvarchar](255) NULL,
	[Website] [nvarchar](255) NULL,
	[SocialMedia] [nvarchar](255) NULL,
	[LoginName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Employers] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[qryMembersUnion]    Script Date: 16/3/2021 6:45:55 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qryMembersUnion]
AS
SELECT   MemberID, FullName AS Name, TaxNumber, Email, Phone, Country, LoginName
FROM      dbo.Ambassadors
UNION
SELECT   MemberID, CompanyName AS Name, TaxNumber, Email, Phone, Country, LoginName
FROM      dbo.Employers
UNION
SELECT   MemberID, FullName AS Name, TaxNumber, Email, Phone, Country, LoginName
FROM      dbo.Graduates
UNION
SELECT   MemberID, FullName AS Name, TaxNumber, Email, Phone, Country, LoginName
FROM      dbo.LiaisonOfficers
UNION
SELECT   MemberID, OrganizationName AS Name, TaxNumber, Email, Phone, Country, LoginName
FROM      dbo.Organizations
UNION
SELECT   MemberID, SchoolName AS Name, TaxNumber, Email, Phone, Country, LoginName
FROM      dbo.Schools
UNION
SELECT   MemberID, FullName AS Name, TaxNumber, Email, Phone, Country, LoginName
FROM      dbo.Students
UNION
SELECT   MemberID, FullName AS Name, TaxNumber, Email, Phone, Country, LoginName
FROM      dbo.Teachers
GO
/****** Object:  View [dbo].[sql_MembersAll]    Script Date: 16/3/2021 6:45:55 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[sql_MembersAll]
AS
SELECT   MemberID, Name, TaxNumber, Email, Phone, Country, LoginName
FROM      dbo.qryMembersUnion
GO
/****** Object:  View [dbo].[sql_MembersTotal]    Script Date: 16/3/2021 6:45:55 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[sql_MembersTotal]
AS
SELECT   COUNT(MemberID) AS Total
FROM      dbo.sql_MembersAll
GO
/****** Object:  View [dbo].[sql_CountSchool]    Script Date: 16/3/2021 6:45:55 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[sql_CountSchool]
AS
SELECT   'School' AS MemberType, COUNT(dbo.Schools.MemberID) AS Number, dbo.sql_MembersTotal.Total, COUNT(dbo.Schools.MemberID) / CAST(dbo.sql_MembersTotal.Total AS DECIMAL(6, 2)) AS Percentage
FROM      dbo.Schools CROSS JOIN
                dbo.sql_MembersTotal
GROUP BY dbo.sql_MembersTotal.Total
GO
/****** Object:  View [dbo].[sql_CountStudent]    Script Date: 16/3/2021 6:45:55 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[sql_CountStudent]
AS
SELECT   'Student' AS MemberType, COUNT(dbo.Students.MemberID) AS Number, dbo.sql_MembersTotal.Total, COUNT(dbo.Students.MemberID) / CAST(dbo.sql_MembersTotal.Total AS DECIMAL(6, 2)) AS Percentage
FROM      dbo.Students CROSS JOIN
                dbo.sql_MembersTotal
GROUP BY dbo.sql_MembersTotal.Total
GO
/****** Object:  View [dbo].[sql_CountTeacher]    Script Date: 16/3/2021 6:45:55 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[sql_CountTeacher]
AS
SELECT   'Teacher' AS MemberType, COUNT(dbo.Teachers.MemberID) AS Number, dbo.sql_MembersTotal.Total, COUNT(dbo.Teachers.MemberID) / CAST(dbo.sql_MembersTotal.Total AS DECIMAL(6, 2)) AS Percentage
FROM      dbo.Teachers CROSS JOIN
                dbo.sql_MembersTotal
GROUP BY dbo.sql_MembersTotal.Total
GO
/****** Object:  View [dbo].[sql_CountAmbassador]    Script Date: 16/3/2021 6:45:55 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[sql_CountAmbassador]
AS
SELECT   'Ambassador' AS MemberType, COUNT(dbo.Ambassadors.MemberID) AS Number, dbo.sql_MembersTotal.Total, COUNT(dbo.Ambassadors.MemberID) / CAST(dbo.sql_MembersTotal.Total AS DECIMAL(6, 2)) AS Percentage
FROM      dbo.Ambassadors CROSS JOIN
                dbo.sql_MembersTotal
GROUP BY dbo.sql_MembersTotal.Total
GO
/****** Object:  View [dbo].[sql_CountEmployer]    Script Date: 16/3/2021 6:45:55 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[sql_CountEmployer]
AS
SELECT   'Employer' AS MemberType, COUNT(dbo.Employers.MemberID) AS Number, dbo.sql_MembersTotal.Total, COUNT(dbo.Employers.MemberID) / CAST(dbo.sql_MembersTotal.Total AS DECIMAL(6, 2)) AS Percentage
FROM      dbo.Employers CROSS JOIN
                dbo.sql_MembersTotal
GROUP BY dbo.sql_MembersTotal.Total
GO
/****** Object:  View [dbo].[sql_CountGraduate]    Script Date: 16/3/2021 6:45:55 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[sql_CountGraduate]
AS
SELECT   'Graduate' AS MemberType, COUNT(dbo.Graduates.MemberID) AS Number, dbo.sql_MembersTotal.Total, COUNT(dbo.Graduates.MemberID) / CAST(dbo.sql_MembersTotal.Total AS DECIMAL(6, 2)) AS Percentage
FROM      dbo.Graduates CROSS JOIN
                dbo.sql_MembersTotal
GROUP BY dbo.sql_MembersTotal.Total
GO
/****** Object:  View [dbo].[sql_CountLiaison]    Script Date: 16/3/2021 6:45:55 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[sql_CountLiaison]
AS
SELECT   'Liaison Officer' AS MemberType, COUNT(dbo.LiaisonOfficers.MemberID) AS Number, dbo.sql_MembersTotal.Total, COUNT(dbo.LiaisonOfficers.MemberID) / CAST(dbo.sql_MembersTotal.Total AS DECIMAL(6, 2)) AS Percentage
FROM      dbo.LiaisonOfficers CROSS JOIN
                dbo.sql_MembersTotal
GROUP BY dbo.sql_MembersTotal.Total
GO
/****** Object:  View [dbo].[sql_CountOrganization]    Script Date: 16/3/2021 6:45:55 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[sql_CountOrganization]
AS
SELECT   'Social Partner' AS MemberType, COUNT(dbo.Organizations.MemberID) AS Number, dbo.sql_MembersTotal.Total, COUNT(dbo.Organizations.MemberID) / CAST(dbo.sql_MembersTotal.Total AS DECIMAL(6, 2)) AS Percentage
FROM      dbo.Organizations CROSS JOIN
                dbo.sql_MembersTotal
GROUP BY dbo.sql_MembersTotal.Total
GO
/****** Object:  View [dbo].[sql_CountUnionAll]    Script Date: 16/3/2021 6:45:55 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[sql_CountUnionAll]
AS
SELECT   *
FROM      dbo.sql_CountAmbassador
UNION
SELECT   *
FROM      dbo.sql_CountEmployer
UNION
SELECT   *
FROM      dbo.sql_CountGraduate
UNION
SELECT   *
FROM      dbo.sql_CountLiaison
UNION
SELECT   *
FROM      dbo.sql_CountOrganization
UNION
SELECT   *
FROM      dbo.sql_CountSchool
UNION
SELECT   *
FROM      dbo.sql_CountStudent
UNION
SELECT   *
FROM      dbo.sql_CountTeacher
GO
/****** Object:  View [dbo].[qryCountMembers]    Script Date: 16/3/2021 6:45:55 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qryCountMembers]
AS
SELECT   ISNULL(ROW_NUMBER() OVER (ORDER BY MemberType), 0) AS RowNumber, MemberType, Number, Total, Percentage * 100 AS Percentage
FROM      dbo.sql_CountUnionAll
GO
/****** Object:  Table [dbo].[Articles]    Script Date: 16/3/2021 6:45:55 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articles](
	[ArticleId] [int] NOT NULL,
	[ArticleDate] [date] NULL,
	[AuthorName] [nvarchar](255) NULL,
	[Name] [nvarchar](255) NULL,
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
/****** Object:  View [dbo].[rep_MembersArticles]    Script Date: 16/3/2021 6:45:55 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[rep_MembersArticles]
AS
SELECT   dbo.Articles.ArticleId, dbo.sql_MembersAll.MemberID, dbo.sql_MembersAll.TaxNumber, dbo.sql_MembersAll.Name, dbo.sql_MembersAll.Email, dbo.sql_MembersAll.Phone, dbo.sql_MembersAll.Country, dbo.sql_MembersAll.LoginName, 
                dbo.Articles.ArticleDate, dbo.Articles.AuthorName, dbo.Articles.Title, dbo.Articles.Description
FROM      dbo.sql_MembersAll INNER JOIN
                dbo.Articles ON dbo.sql_MembersAll.MemberID = dbo.Articles.ArticleMemberID
GO
/****** Object:  Table [dbo].[Apprenticeships]    Script Date: 16/3/2021 6:45:55 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Apprenticeships](
	[ApprenticeshipID] [int] NOT NULL,
	[Name] [nvarchar](255) NULL,
	[Title] [nvarchar](255) NULL,
	[PostDate] [date] NULL,
	[Description] [nvarchar](max) NULL,
	[DurationMonths] [nvarchar](50) NULL,
	[Commitment] [nvarchar](50) NULL,
	[Compensation] [nvarchar](50) NULL,
	[JobSector] [nvarchar](255) NULL,
	[Country] [nvarchar](50) NULL,
	[Status] [nvarchar](50) NULL,
	[StartDate] [date] NULL,
	[EndDate] [date] NULL,
	[EmployerID] [int] NULL,
 CONSTRAINT [PK_Apprenticeships] PRIMARY KEY CLUSTERED 
(
	[ApprenticeshipID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[rep_MembersApprenticeships]    Script Date: 16/3/2021 6:45:55 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[rep_MembersApprenticeships]
AS
SELECT   dbo.Apprenticeships.ApprenticeshipID AS AppID, dbo.Employers.MemberID, dbo.Employers.TaxNumber, dbo.Employers.CompanyName, dbo.Employers.Phone, dbo.Employers.Email, dbo.Apprenticeships.PostDate, dbo.Apprenticeships.Title, 
                dbo.Apprenticeships.Description, dbo.Apprenticeships.DurationMonths, dbo.Apprenticeships.Commitment, dbo.Apprenticeships.Compensation, dbo.Apprenticeships.JobSector, dbo.Apprenticeships.Country
FROM      dbo.Employers INNER JOIN
                dbo.Apprenticeships ON dbo.Employers.MemberID = dbo.Apprenticeships.EmployerID
GO
/****** Object:  View [dbo].[chartCountMembers]    Script Date: 16/3/2021 6:45:55 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[chartCountMembers]
AS
SELECT   RowNumber AS RowID, MemberType, Number, Total, Percentage
FROM      dbo.qryCountMembers
GO
/****** Object:  Table [dbo].[Commitments]    Script Date: 16/3/2021 6:45:55 πμ ******/
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
/****** Object:  Table [dbo].[Countries]    Script Date: 16/3/2021 6:45:55 πμ ******/
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
/****** Object:  Table [dbo].[Durations]    Script Date: 16/3/2021 6:45:55 πμ ******/
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
/****** Object:  Table [dbo].[Genders]    Script Date: 16/3/2021 6:45:55 πμ ******/
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
/****** Object:  Table [dbo].[JobSectors]    Script Date: 16/3/2021 6:45:55 πμ ******/
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
/****** Object:  Table [dbo].[MemberGroups]    Script Date: 16/3/2021 6:45:55 πμ ******/
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
/****** Object:  Table [dbo].[tbl_hit_counter]    Script Date: 16/3/2021 6:45:55 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_hit_counter](
	[node_id] [int] NOT NULL,
	[views] [int] NOT NULL,
 CONSTRAINT [PK_tbl_hit_counter] PRIMARY KEY CLUSTERED 
(
	[node_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Ambassadors] ([MemberID], [TaxNumber], [FullName], [Address], [Country], [Phone], [Email], [Website], [SocialMedia], [Occupation], [JobSector], [Employer], [LoginName]) VALUES (1271, N'123456789', N'Pedro Afonso', N'Plateia Georgiou 21', N'Greece', N'2106878934', N'business1@example.com', N'www.oaed.gr', N'https://www.facebook.com/', N'Public Servant', N'Recruitment and Human Resouces', N'Manpower Employment Organization (OAED)', N'business1')
INSERT [dbo].[Ambassadors] ([MemberID], [TaxNumber], [FullName], [Address], [Country], [Phone], [Email], [Website], [SocialMedia], [Occupation], [JobSector], [Employer], [LoginName]) VALUES (1272, N'123456789', N'Elizabeth Brown', N'Mataderos  2312', N'Spain', N'(5) 555-3932', N'business2@example.com', N'', N'https://www.facebook.com/, https://twitter.com/home?lang=en, https://gr.linkedin.com/', N'Agricultural and Food Science Technician', N'Retail and Sales', N'Great Lakes Food Market', N'business2')
INSERT [dbo].[Ambassadors] ([MemberID], [TaxNumber], [FullName], [Address], [Country], [Phone], [Email], [Website], [SocialMedia], [Occupation], [JobSector], [Employer], [LoginName]) VALUES (1273, N'123456789', N'Sven Ottlieb', N'Hauptstr. 29', N'Germany', N'0452-076545', N'business3@example.com', N'', N'https://www.facebook.com/, https://twitter.com/home?lang=en, https://gr.linkedin.com/', N'Architectural and Engineering Manager', N'Engineering and Manufacturing', N'Electronic Arts', N'business3')
INSERT [dbo].[Ambassadors] ([MemberID], [TaxNumber], [FullName], [Address], [Country], [Phone], [Email], [Website], [SocialMedia], [Occupation], [JobSector], [Employer], [LoginName]) VALUES (1274, N'123456789', N'Janine Labrune', N'Walserweg 21', N'Netherlands', N'0241-039123', N'business4@example.com', N'', N'https://www.facebook.com/, https://twitter.com/home?lang=en, https://gr.linkedin.com/', N'General and Operations Manager', N'Marketing, Advertising and Public Relations', N'Frankenversand Gmbh', N'business4')
INSERT [dbo].[Ambassadors] ([MemberID], [TaxNumber], [FullName], [Address], [Country], [Phone], [Email], [Website], [SocialMedia], [Occupation], [JobSector], [Employer], [LoginName]) VALUES (1275, N'123456789', N'Ann Devon', N'Berkeley Gardens 12  Brewery', N'Ireland', N'0452-076545', N'business5@example.com', N'', N'https://www.facebook.com/, https://twitter.com/home?lang=en, https://gr.linkedin.com/', N'Child, Family, and School Social Worker', N'Recruitment and Human Resouces', N'Franchi S.p.A.', N'business5')
INSERT [dbo].[Ambassadors] ([MemberID], [TaxNumber], [FullName], [Address], [Country], [Phone], [Email], [Website], [SocialMedia], [Occupation], [JobSector], [Employer], [LoginName]) VALUES (1621, N'123456789', N'Jonathan Henderson', N'Address 1234', N'Ireland', N'149-555-0113', N'business6@example.com', N'www.mysite.com', N'https://www.facebook.com/, https://twitter.com/home?lang=en', N'Administrative Services Manager', N'Business, Consulting and Management', N'Employer 10', N'business6')
INSERT [dbo].[Ambassadors] ([MemberID], [TaxNumber], [FullName], [Address], [Country], [Phone], [Email], [Website], [SocialMedia], [Occupation], [JobSector], [Employer], [LoginName]) VALUES (1622, N'123456789', N'Ramon Huang', N'Address 123', N'Portugal', N'144-555-0194', N'business7@example.com', N'www.b.ambassador7.com', N'https://www.facebook.com/, https://twitter.com/home?lang=en', N'Bookkeeping, Accounting, and Auditing Clerk', N'Accountancy, Banking and Finance', N'Self-employed', N'business7')
INSERT [dbo].[Ambassadors] ([MemberID], [TaxNumber], [FullName], [Address], [Country], [Phone], [Email], [Website], [SocialMedia], [Occupation], [JobSector], [Employer], [LoginName]) VALUES (1623, N'123456789', N'Jonathan Gonzales', N'Address 890', N'Italy', N'419-555-0193', N'business8@example.com', N'', N'https://www.facebook.com/, https://twitter.com/home?lang=en', N'Executive Administrative Assistant', N'Hospitality and Events Management', N'Employer 15', N'business8')
INSERT [dbo].[Ambassadors] ([MemberID], [TaxNumber], [FullName], [Address], [Country], [Phone], [Email], [Website], [SocialMedia], [Occupation], [JobSector], [Employer], [LoginName]) VALUES (1624, N'123456789', N'Ramon Gao', N'Address 123456', N'Portugal', N'500 555-0118', N'ramon13@adventure-works.com', N'', N'https://www.facebook.com/, https://twitter.com/home?lang=en', N'Audio and Video Equipment Technician', N'Creative Arts and Design', N'Employer 9', N'business9')
INSERT [dbo].[Ambassadors] ([MemberID], [TaxNumber], [FullName], [Address], [Country], [Phone], [Email], [Website], [SocialMedia], [Occupation], [JobSector], [Employer], [LoginName]) VALUES (1625, N'123456789', N'Raquel Alonso', N'Address 667', N'Spain', N'500 555-0175', N'raquel5@adventure-works.com', N'', N'https://www.facebook.com/, https://twitter.com/home?lang=en', N'Child, Family, and School Social Worker', N'Social Care', N'Employer 12', N'business10')
GO
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [Name], [Title], [PostDate], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Status], [StartDate], [EndDate], [EmployerID]) VALUES (1496, N'Apprenticeship 01', N'DIGITAL MARKETING IN BARCELONA', CAST(N'2021-01-10' AS Date), N'Digital Marketing Apprenticeship in Barcelona', N'10 months', N'Full-Time', N'Financial compensation', N'Business, Consulting and Management', N'Spain', N'Active', CAST(N'2021-01-17' AS Date), CAST(N'2021-04-15' AS Date), 1267)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [Name], [Title], [PostDate], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Status], [StartDate], [EndDate], [EmployerID]) VALUES (1497, N'Apprenticeship 02', N'DATA ANALYSIS IN BARCELONA', CAST(N'2021-01-19' AS Date), N'Data Analyst apprenticeship in Barcelona', N'12 months', N'Part-Time', N'No financial compensation', N'Information Technology', N'Spain', N'Active', CAST(N'2021-02-01' AS Date), CAST(N'2021-03-10' AS Date), 1267)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [Name], [Title], [PostDate], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Status], [StartDate], [EndDate], [EmployerID]) VALUES (1498, N'Apprenticeship 03', N'CRYPTOCURRENCIES ANALYST IN BARCELONA', CAST(N'2021-02-09' AS Date), N'CRYPTOCURRENCIES ANALYST APPRENTICESHIP IN BARCELONA', N'9 months', N'Full-Time', N'Financial compensation', N'Business, Consulting and Management', N'Spain', N'Active', CAST(N'2021-02-01' AS Date), CAST(N'2021-03-31' AS Date), 1268)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [Name], [Title], [PostDate], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Status], [StartDate], [EndDate], [EmployerID]) VALUES (1499, N'Apprenticeship 04', N'Graphic Design Apprenticeship', CAST(N'2021-02-01' AS Date), N'Graphic Design Apprenticeship', N'8 months', N'Part-Time', N'Financial compensation', N'Creative Arts and Design', N'Malta', N'Active', CAST(N'2021-02-01' AS Date), CAST(N'2021-03-30' AS Date), 1268)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [Name], [Title], [PostDate], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Status], [StartDate], [EndDate], [EmployerID]) VALUES (1500, N'Apprenticeship 05', N'Legal Assistant Apprenticeship', CAST(N'2021-01-20' AS Date), N'Legal Assistant Apprenticeship in Italy', N'9 months', N'Part-Time', N'No financial compensation', N'Public Services and Administration', N'Italy', N'Terminated', CAST(N'2020-12-06' AS Date), CAST(N'2021-02-16' AS Date), 1266)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [Name], [Title], [PostDate], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Status], [StartDate], [EndDate], [EmployerID]) VALUES (1501, N'Apprenticeship 06', N'Accounting & Finance Apprenticeship', CAST(N'2021-01-25' AS Date), N'Accounting & Finance Apprenticeship', N'6 months', N'Full-Time', N'No financial compensation', N'Accountancy, Banking and Finance', N'Ireland', N'Active', CAST(N'2021-01-03' AS Date), CAST(N'2021-04-07' AS Date), 1269)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [Name], [Title], [PostDate], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Status], [StartDate], [EndDate], [EmployerID]) VALUES (1502, N'Apprenticeship 07', N'Social Media Manager Apprenticeship', CAST(N'2021-02-01' AS Date), N'Social Media Manager Apprenticeship', N'9 months', N'Part-Time', N'Financial compensation', N'Business, Consulting and Management', N'Greece', N'Active', CAST(N'2021-01-03' AS Date), CAST(N'2021-04-01' AS Date), 1269)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [Name], [Title], [PostDate], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Status], [StartDate], [EndDate], [EmployerID]) VALUES (1503, N'Apprenticeship 08', N'Public Relations Apprenticeship', CAST(N'2021-01-07' AS Date), N'Public Relations Apprenticeship', N'10 months', N'Full-Time', N'Financial compensation', N'Business, Consulting and Management', N'Luxemburg', N'Terminated', CAST(N'2020-12-06' AS Date), CAST(N'2021-01-29' AS Date), 1270)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [Name], [Title], [PostDate], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Status], [StartDate], [EndDate], [EmployerID]) VALUES (1504, N'Apprenticeship 09', N'IOS Developer', CAST(N'2021-01-13' AS Date), N'OS System Developer', N'6 months', N'Part-Time', N'No financial compensation', N'Information Technology', N'Italy', N'Terminated', CAST(N'2021-01-04' AS Date), CAST(N'2021-02-25' AS Date), 1268)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [Name], [Title], [PostDate], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Status], [StartDate], [EndDate], [EmployerID]) VALUES (1505, N'Apprenticeship 10', N'Business Representative (GERMAN) - Apprenticeship in Poland', CAST(N'2021-01-05' AS Date), N'Business Representative', N'9 months', N'Full-Time', N'Financial compensation', N'Business, Consulting and Management', N'Germany', N'Active', CAST(N'2021-02-07' AS Date), CAST(N'2021-03-26' AS Date), 1270)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [Name], [Title], [PostDate], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Status], [StartDate], [EndDate], [EmployerID]) VALUES (1506, N'Apprenticeship 11', N'Web Designer', CAST(N'2021-02-02' AS Date), N'Web Designer Apprenticeship', N'12 months', N'Part-Time', N'Financial compensation', N'Information Technology', N'Spain', N'Active', CAST(N'2021-02-01' AS Date), CAST(N'2021-04-20' AS Date), 1266)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [Name], [Title], [PostDate], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Status], [StartDate], [EndDate], [EmployerID]) VALUES (1507, N'Apprenticeship 12', N'MARKETING & BUSINESS DEVELOPMENT TRAINEE', CAST(N'2021-01-25' AS Date), N'MARKETING & BUSINESS DEVELOPMENT TRAINEE', N'12 months', N'Full-Time', N'Financial compensation', N'Business, Consulting and Management', N'Ireland', N'Active', CAST(N'2021-02-01' AS Date), CAST(N'2021-03-31' AS Date), 1269)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [Name], [Title], [PostDate], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Status], [StartDate], [EndDate], [EmployerID]) VALUES (1508, N'Apprenticeship 13', N'Sales Operations and Customer Success Apprenticeship', CAST(N'2021-02-18' AS Date), N'Sales Operations and Customer Success Apprenticeship', N'6 months', N'Part-Time', N'Financial compensation', N'Business, Consulting and Management', N'Spain', N'Active', CAST(N'2021-01-18' AS Date), CAST(N'2021-03-25' AS Date), 1267)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [Name], [Title], [PostDate], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Status], [StartDate], [EndDate], [EmployerID]) VALUES (1509, N'Apprenticeship 14', N'Assistant Operations Hotel Manager', CAST(N'2021-01-20' AS Date), N'Assistant Operations Hotel Manager', N'8 months', N'Part-Time', N'No financial compensation', N'Hospitality and Events Management', N'Portugal', N'Active', CAST(N'2021-02-01' AS Date), CAST(N'2021-04-29' AS Date), 1267)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [Name], [Title], [PostDate], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Status], [StartDate], [EndDate], [EmployerID]) VALUES (1510, N'Apprenticeship 15', N'Material Chemist Assistant', CAST(N'2021-01-28' AS Date), N'Material Chemist Assistant', N'10 months', N'Part-Time', N'Financial compensation', N'Engineering and Manufacturing', N'Italy', N'Active', CAST(N'2021-02-09' AS Date), CAST(N'2021-05-31' AS Date), 1269)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [Name], [Title], [PostDate], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Status], [StartDate], [EndDate], [EmployerID]) VALUES (1566, N'Apprenticeship 16', N'Test Apprenticeship', CAST(N'2021-02-24' AS Date), N'test apprenticeship created by a custom frontend', N'10 months', N'Part-Time', N'Financial compensation', N'Engineering and Manufacturing', N'Greece', N'Active', CAST(N'2021-02-24' AS Date), CAST(N'2021-04-15' AS Date), 1266)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [Name], [Title], [PostDate], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Status], [StartDate], [EndDate], [EmployerID]) VALUES (1650, N'Apprenticeship 17', N'Marketing Assistant', CAST(N'2021-03-01' AS Date), N'EFMC is today actively recruiting a Marketing Assistant based in Tallinn - Estonia.', N'9 months', N'Full-Time', N'Financial compensation', N'Marketing, Advertising and Public Relations', N'Greece', N'Active', CAST(N'2021-03-07' AS Date), CAST(N'2021-05-30' AS Date), 1614)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [Name], [Title], [PostDate], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Status], [StartDate], [EndDate], [EmployerID]) VALUES (1651, N'Apprenticeship 18', N'Erasmus Apprenticeship at the BOKU International Relations', CAST(N'2021-02-15' AS Date), N'BOKU-International Relations is BOKU''s service department for International Affairs. Its aim is to facilitate and foster international contacts for the benefit of students, faculty and friends of the university alike. As a service to the international community, it provides information about BOKU in different languages.', N'9 months', N'Full-Time', N'No financial compensation', N'Business, Consulting and Management', N'Austria', N'Active', CAST(N'2021-03-10' AS Date), CAST(N'2021-04-30' AS Date), 1614)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [Name], [Title], [PostDate], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Status], [StartDate], [EndDate], [EmployerID]) VALUES (1652, N'Apprenticeship 19', N'Illustrator (with vector drawing skills)', CAST(N'2021-02-15' AS Date), N'Illustrator (with vector drawing skills) apprenticeship', N'12 months', N'Part-Time', N'No financial compensation', N'Creative Arts and Design', N'Ireland', N'Active', CAST(N'2021-03-01' AS Date), CAST(N'2021-05-31' AS Date), 1615)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [Name], [Title], [PostDate], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Status], [StartDate], [EndDate], [EmployerID]) VALUES (1653, N'Apprenticeship 20', N'Human Resource Assistant', CAST(N'2021-02-24' AS Date), N'', N'9 months', N'Full-Time', N'Financial compensation', N'Recruitment and Human Resouces', N'Portugal', N'Active', CAST(N'2021-03-01' AS Date), CAST(N'2021-05-11' AS Date), 1615)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [Name], [Title], [PostDate], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Status], [StartDate], [EndDate], [EmployerID]) VALUES (1654, N'Apprenticeship 21', N'Bioscience Apprenticeship', CAST(N'2021-03-01' AS Date), N'Bioscience medical assistant
Processing completed patient samples, in accordance with Health and Safety regulations and General Laboratory procedures', N'9 months', N'Full-Time', N'Financial compensation', N'Medical Services and Pharmaceuticals', N'Greece', N'Active', CAST(N'2021-03-01' AS Date), CAST(N'2021-05-25' AS Date), 1614)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [Name], [Title], [PostDate], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Status], [StartDate], [EndDate], [EmployerID]) VALUES (1655, N'Apprenticeship 22', N'Junior Nutrition Specialist', CAST(N'0001-01-01' AS Date), N'Junior Nutrition Specialist
Visiting regional markets
Planning and preparation of nutritious meals
Preparing lunch and snacks for the team
Creating fitness programs to improve work-life balance', N'9 months', N'Full-Time', N'Financial compensation', N'Healthcare', N'Portugal', N'Active', CAST(N'2021-03-01' AS Date), CAST(N'2021-05-30' AS Date), 1615)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [Name], [Title], [PostDate], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Status], [StartDate], [EndDate], [EmployerID]) VALUES (1656, N'Apprenticeship 23', N'Environmental Trainee', CAST(N'2021-03-08' AS Date), N'Environmental Trainee
We welcome interns for a minimum of 3 months and up to one year, whilst a minimum internship duration of 6 months is preferable. A minimum of 20 hours per week need to be carried out during the internship.', N'10 months', N'Part-Time', N'No financial compensation', N'Environment and Agriculture', N'Belgium', N'Active', CAST(N'2021-03-07' AS Date), CAST(N'2021-06-21' AS Date), 1617)
INSERT [dbo].[Apprenticeships] ([ApprenticeshipID], [Name], [Title], [PostDate], [Description], [DurationMonths], [Commitment], [Compensation], [JobSector], [Country], [Status], [StartDate], [EndDate], [EmployerID]) VALUES (1657, N'Apprenticeship 24', N'Food Technologist', CAST(N'2021-03-01' AS Date), N'Healthy and Affordable is our food surplus project. We save food from markets, sort it, cut it, dehydrate it, pack it and sell it on various platforms.', N'11 months', N'Part-Time', N'Financial compensation', N'Environment and Agriculture', N'Spain', N'Active', CAST(N'2021-03-01' AS Date), CAST(N'2021-05-28' AS Date), 1615)
GO
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Name], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1140, CAST(N'2021-01-03' AS Date), N'Flora MATTHAES', N'Article 19', N'Commission welcomes political agreement on European Globalisation Adjustment Fund for displaced workers', N'Political agreement on European Globalisation Adjustment Fund for displaced workers', N'Greece', 1289)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Name], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1141, CAST(N'2021-01-05' AS Date), N'Flora MATTHAES', N'Article 24', N'The Pact for Skills: mobilising all partners to invest in skills', N'The Pact for Skills: mobilising all partners to invest in skills', N'Spain', 1266)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Name], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1142, CAST(N'2021-01-06' AS Date), N'Marta WIECZOREK', N'Article 16', N'Questions and answers: Launching the Pact for Skills', N'Questions and answers: Launching the Pact for Skills', N'Belgium', 1281)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Name], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1143, CAST(N'2021-01-04' AS Date), N'Marta WIECZOREK, Flora MATTHAES', N'Article 02', N'Advancing the EU social market economy: adequate minimum wages for workers across Member States', N'Advancing the EU social market economy: adequate minimum wages for workers across Member States', N'Germany', 1269)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Name], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1144, CAST(N'2021-01-07' AS Date), N'Marta WIECZOREK', N'Article 21', N'Questions and answers: Adequate minimum wages', N'Questions and answers: Adequate minimum wages', N'Italy', 1285)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Name], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1145, CAST(N'2021-01-15' AS Date), N'Enda MCNAMARA', N'Article 08', N'Employment and Social Developments in Europe review: why social fairness and solidarity are more important than ever', N'Employment and Social Developments in Europe review', N'Germany', 1284)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Name], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1146, CAST(N'2021-01-01' AS Date), N'Laura BERARD', N'Article 14', N'Integrating migrants and refugees into the labour market: Commission and social and economic partners relaunch cooperation', N'Integrating migrants and refugees into the labour market', N'Greece', 1289)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Name], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1147, CAST(N'2021-01-07' AS Date), N'Siobhán MILLBRIGHT', N'Article 06', N'Coronavirus: European Commission calls for action in protecting seasonal workers', N'Coronavirus: European Commission calls for action in protecting seasonal workers', N'Italy', 1300)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Name], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1148, CAST(N'2021-01-10' AS Date), N'Marta WIECZOREK', N'Article 20', N'Questions and Answers on Youth Employment Support: a bridge to jobs for the next generation', N'Questions and Answers on Youth Employment Support: a bridge to jobs for the next generation', N'Greece', 1282)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Name], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1149, CAST(N'2021-01-08' AS Date), N'Siobhán MILLBRIGHT', N'Article 11', N'Questions and answers: European Skills Agenda for sustainable competitiveness, social fairness and resilience', N'European Skills Agenda for sustainable competitiveness, social fairness and resilience', N'Greece', 1283)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Name], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1150, CAST(N'2021-01-10' AS Date), N'Marta WIECZOREK', N'Article 04', N'Commission launches Youth Employment Support: a bridge to jobs for the next generation', N'Commission launches Youth Employment Support: a bridge to jobs for the next generation', N'Belgium', 1289)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Name], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1151, CAST(N'2020-12-23' AS Date), N'Marta WIECZOREK', N'Article 15', N'Joint statement and main messages following the Tripartite Social Summit', N'Joint statement and main messages following the Tripartite Social Summit', N'Netherlands', 1286)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Name], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1152, CAST(N'2021-01-06' AS Date), N'Marta WIECZOREK', N'Article 13', N'Fair minimum wages: Commission launches second-stage consultation of social partners', N'Fair minimum wages: Commission launches second-stage consultation of social partners', N'Portugal', 1274)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Name], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1153, CAST(N'2020-12-20' AS Date), N'Siobhán MILLBRIGHT', N'Article 22', N'Statement by Commissioner Nicolas Schmit ahead of International Workers'' Day', N'Statement by Commissioner Nicolas Schmit ahead of International Workers'' Day', N'Belgium', 1270)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Name], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1154, CAST(N'2021-01-06' AS Date), N'Marta WIECZOREK', N'Article 05', N'Coronavirus: EU guidance for a safe return to the workplace', N'Coronavirus: EU guidance for a safe return to the workplace', N'Spain', 1285)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Name], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1155, CAST(N'2021-01-14' AS Date), N'Marta WIECZOREK', N'Article 07', N'Coronavirus: Commission presents practical guidance to ensure the free movement of critical workers', N'Coronavirus: Practical guidance to ensure the free movement of critical workers', N'Greece', 1294)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Name], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1156, CAST(N'2021-01-05' AS Date), N'Marta WIECZOREK', N'Article 01', N'A Strong Social Europe for Just Transitions', N'A Strong Social Europe for Just Transitions', N'Italy', 1272)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Name], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1157, CAST(N'2020-12-21' AS Date), N'Sara SOUMILLION', N'Article 10', N'European Labour Authority starts its work', N'European Labour Authority starts its work', N'Belgium', 1271)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Name], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1158, CAST(N'2021-01-04' AS Date), N'Christian WIGAND', N'Article 09', N'European Labour Authority starts its activities: Question and Answers', N'European Labour Authority starts its activities: Question and Answers', N'Spain', 1290)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Name], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1159, CAST(N'2021-01-06' AS Date), N'Christian SPAHR', N'Article 18', N'More efficient decision-making in social policy – Questions and Answers', N'More efficient decision-making in social policy – Questions and Answers', N'Spain', 1284)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Name], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1160, CAST(N'2021-01-06' AS Date), N'Christian WIGAND', N'Article 23', N'Statement by Commissioner Thyssen ahead of International Workers'' Day', N'Statement by Commissioner Thyssen ahead of International Workers'' Day', N'Netherlands', 1282)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Name], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1161, CAST(N'2020-12-20' AS Date), N'Christian SPAHR', N'Article 03', N'Commission launches debate on more efficient decision-making in EU social policy', N'Commission launches debate on more efficient decision-making in EU social policy', N'Greece', 1287)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Name], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1162, CAST(N'2020-12-18' AS Date), N'Sara SOUMILLION', N'Article 17', N'Main messages from the Tripartite Social Summit', N'Main messages from the Tripartite Social Summit', N'Italy', 1294)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Name], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1163, CAST(N'2021-01-05' AS Date), N'Christian WIGAND', N'Article 12', N'Fair labour mobility: Commission welcomes agreement on the European Labour Authority', N'Fair labor mobility: Commission welcomes agreement on the European Labour Authority', N'Belgium', 1286)
INSERT [dbo].[Articles] ([ArticleId], [ArticleDate], [AuthorName], [Name], [Title], [Description], [Country], [ArticleMemberID]) VALUES (1548, CAST(N'2021-02-13' AS Date), N'Georgios Kyriakakis', N'Article 25', N'Test article created programmatically', N'Example of an Article created at Frontend programmatically', N'Spain', 1266)
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
INSERT [dbo].[Employers] ([MemberID], [TaxNumber], [CompanyName], [ContactPerson], [Headquarters], [Country], [JobSector1], [JobSector2], [JobSector3], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1266, NULL, N'Bottom-Dollar Markets', N'Paul Seal', N'12 King George St., Brussels', N'Belgium', N'Accountancy, Banking and Finance', N'Business, Consulting and Management', N'', N'+30 2346 893', N'employer1@example.com', N'www.example.com', N'https://www.facebook.com/', N'employer1')
INSERT [dbo].[Employers] ([MemberID], [TaxNumber], [CompanyName], [ContactPerson], [Headquarters], [Country], [JobSector1], [JobSector2], [JobSector3], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1267, NULL, N'Cactus Comidas para llevar', N'Nick Pearson', N'Address 76878', N'Spain', N'Energy and Utilities', N'Property and Construction', N'Environment and Agriculture', N'+45 4657 899', N'employer2@example.com', N'www.employer2.com', N'https://www.facebook.com/, https://twitter.com/home?lang=en, https://gr.linkedin.com/', N'employer2')
INSERT [dbo].[Employers] ([MemberID], [TaxNumber], [CompanyName], [ContactPerson], [Headquarters], [Country], [JobSector1], [JobSector2], [JobSector3], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1268, NULL, N'Centro comercial Moctezuma', N'Adam Miller', N'Address 5857858', N'Ireland', N'Hospitality and Events Management', N'Social Care', N'', N'+33 8987 234', N'employer3@example.com', N'www.employer3.com', N'https://www.facebook.com/, https://twitter.com/home?lang=en, https://gr.linkedin.com/', N'employer3')
INSERT [dbo].[Employers] ([MemberID], [TaxNumber], [CompanyName], [ContactPerson], [Headquarters], [Country], [JobSector1], [JobSector2], [JobSector3], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1269, NULL, N'Consolidated Holdings', N'Harry Wilson', N'Address 565565', N'Netherlands', N'Transport and Logistics', N'Public Services and Administration', N'', N'+44 6734 890', N'employer4@example.com', N'www.employer4.com', N'https://www.facebook.com/, https://twitter.com/home?lang=en', N'employer4')
INSERT [dbo].[Employers] ([MemberID], [TaxNumber], [CompanyName], [ContactPerson], [Headquarters], [Country], [JobSector1], [JobSector2], [JobSector3], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1270, NULL, N'Drachenblut Delikatessen', N'Anna Moore', N'Address 1 Street, Number 12, City', N'Germany', N'Retail and Sales', N'', N'', N'+34 6754 090', N'employer5@example.com', N'www.employer5.com', N'https://www.facebook.com/, https://twitter.com/home?lang=en, https://gr.linkedin.com/', N'employer5')
INSERT [dbo].[Employers] ([MemberID], [TaxNumber], [CompanyName], [ContactPerson], [Headquarters], [Country], [JobSector1], [JobSector2], [JobSector3], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1604, NULL, N'Electronic Bike Repair & Supplies', N'Jacquelyn Serrano', N'Address 1', N'France', N'Engineering and Manufacturing', N'Retail and Sales', N'', N'500 555-0115', N'jacquelyn17@adventure-works.com', N'www.demo.site.com', N'https://www.facebook.com, https://twitter.com/home?lang=en', N'employer6')
INSERT [dbo].[Employers] ([MemberID], [TaxNumber], [CompanyName], [ContactPerson], [Headquarters], [Country], [JobSector1], [JobSector2], [JobSector3], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1605, NULL, N'Premier Sport, Inc.', N'James Flores', N'Address 1', N'Germany', N'Retail and Sales', N'', N'', N'500 555-0147', N'employer7@example.com', N'www.employer6.com', N'https://www.facebook.com', N'employer7')
INSERT [dbo].[Employers] ([MemberID], [TaxNumber], [CompanyName], [ContactPerson], [Headquarters], [Country], [JobSector1], [JobSector2], [JobSector3], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1608, NULL, N'Compete Enterprises, Inc', N'James Washington', N'Address 10', N'Italy', N'Public Services and Administration', N'Business, Consulting and Management', N'', N'500 555-0181', N'employer8@example.com', N'www.employer8.com', N'https://www.facebook.com, https://twitter.com', N'employer8')
INSERT [dbo].[Employers] ([MemberID], [TaxNumber], [CompanyName], [ContactPerson], [Headquarters], [Country], [JobSector1], [JobSector2], [JobSector3], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1609, NULL, N'Business Equipment Center', N'James Butler', N'Address 11', N'France', N'Leisure, Sport and Tourism', N'Retail and Sales', N'', N'901-555-0171', N'employer9@example.com', N'www.employer9.com', N'https://www.facebook.com/, https://twitter.com/home?lang=en', N'employer9')
INSERT [dbo].[Employers] ([MemberID], [TaxNumber], [CompanyName], [ContactPerson], [Headquarters], [Country], [JobSector1], [JobSector2], [JobSector3], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1610, NULL, N'Ready Rentals Ltd.', N'Jacquelyn Ramos', N'Address 18', N'Italy', N'Retail and Sales', N'Hospitality and Events Management', N'Social Care', N'500 555-0125', N'employer10@example.com', N'www.employer10.com', N'https://www.facebook.com/, https://twitter.com/home?lang=en', N'employer10')
INSERT [dbo].[Employers] ([MemberID], [TaxNumber], [CompanyName], [ContactPerson], [Headquarters], [Country], [JobSector1], [JobSector2], [JobSector3], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1611, NULL, N'Training Systems S.A.', N'James Gonzales', N'Address 22', N'Spain', N'Training and Education', N'Recruitment and Human Resouces', N'', N'988-555-0116', N'employer11@exxample.com', N'www.employer11.com', N'https://www.facebook.com/, https://twitter.com/home?lang=en', N'employer11')
INSERT [dbo].[Employers] ([MemberID], [TaxNumber], [CompanyName], [ContactPerson], [Headquarters], [Country], [JobSector1], [JobSector2], [JobSector3], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1612, NULL, N'Compelling Convo Ltd.', N'Jacquelyn Suarez', N'Address 23', N'Denmark', N'Business, Consulting and Management', N'Marketing, Advertising and Public Relations', N'', N'500 555-0169', N'employer12@example.com', N'www.employer12.com', N'https://www.facebook.com/, https://twitter.com/home?lang=en', N'employer12')
INSERT [dbo].[Employers] ([MemberID], [TaxNumber], [CompanyName], [ContactPerson], [Headquarters], [Country], [JobSector1], [JobSector2], [JobSector3], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1613, NULL, N'Greenwood Athletic Company', N'James Diaz', N'Address 33', N'Ireland', N'Retail and Sales', N'Environment and Agriculture', N'', N'632-555-0118', N'employer13@example.com', N'www.employer13.com', N'https://www.facebook.com/, https://twitter.com/home?lang=en', N'employer13')
INSERT [dbo].[Employers] ([MemberID], [TaxNumber], [CompanyName], [ContactPerson], [Headquarters], [Country], [JobSector1], [JobSector2], [JobSector3], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1614, NULL, N'Smooth Operators Co.', N'Raquel Moreno', N'Address 26', N'Portugal', N'Marketing, Advertising and Public Relations', N'Media and Internet', N'', N'500 555-0121', N'employer14@example.com', N'www.employer14.com', N'https://www.facebook.com/, https://twitter.com/home?lang=en', N'employer14')
INSERT [dbo].[Employers] ([MemberID], [TaxNumber], [CompanyName], [ContactPerson], [Headquarters], [Country], [JobSector1], [JobSector2], [JobSector3], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1615, NULL, N'The Loyal Follower Ltd.', N'Ramon Li', N'Address 45', N'Hungary', N'Marketing, Advertising and Public Relations', N'Public Services and Administration', N'', N'500 555-0117', N'employer15@example.com', N'www.employer15.com', N'https://www.facebook.com/, https://twitter.com/home?lang=en', N'employer15')
INSERT [dbo].[Employers] ([MemberID], [TaxNumber], [CompanyName], [ContactPerson], [Headquarters], [Country], [JobSector1], [JobSector2], [JobSector3], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1616, NULL, N'Touring Equipment Center', N'Jonathan Coleman', N'Address 123', N'France', N'Public Services and Administration', N'Hospitality and Events Management', N'', N'225-555-0129', N'employer16@example.com', N'www.employer16.com', N'https://www.facebook.com/, https://twitter.com/home?lang=en', N'employer16')
INSERT [dbo].[Employers] ([MemberID], [TaxNumber], [CompanyName], [ContactPerson], [Headquarters], [Country], [JobSector1], [JobSector2], [JobSector3], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1617, NULL, N'Northwind Traders Inc.', N'Jonathan Perry', N'Address 34', N'Portugal', N'Property and Construction', N'Environment and Agriculture', N'', N'909-555-0148', N'employer17@example.com', N'www.employer17.com', N'https://www.facebook.com/, https://twitter.com/home?lang=en', N'employer17')
INSERT [dbo].[Employers] ([MemberID], [TaxNumber], [CompanyName], [ContactPerson], [Headquarters], [Country], [JobSector1], [JobSector2], [JobSector3], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1618, NULL, N'Reliance Consulting, Inc.', N'Jonathan Powell', N'Address 56', N'Netherlands', N'Business, Consulting and Management', N'Accountancy, Banking and Finance', N'', N'909-555-0148', N'employer18@example.com', N'www.employer18.com', N'https://www.facebook.com/, https://twitter.com/home?lang=en', N'employer18')
INSERT [dbo].[Employers] ([MemberID], [TaxNumber], [CompanyName], [ContactPerson], [Headquarters], [Country], [JobSector1], [JobSector2], [JobSector3], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1619, NULL, N'Xpereos Manufacturing Inc.', N'Jonathan Long', N'Address 1234', N'Spain', N'Engineering and Manufacturing', N'Environment and Agriculture', N'', N'145-555-0164', N'employer19@example.com', N'www.employer19.com', N'https://www.facebook.com/, https://twitter.com/home?lang=en', N'employer19')
INSERT [dbo].[Employers] ([MemberID], [TaxNumber], [CompanyName], [ContactPerson], [Headquarters], [Country], [JobSector1], [JobSector2], [JobSector3], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1620, NULL, N'Imaginato Care Ltd.', N'Jonathan Perry', N'Address 789', N'Greece', N'Hospitality and Events Management', N'Social Care', N'', N'909-555-0148', N'employer20@example.com', N'www.employer20.com', N'https://www.facebook.com/, https://twitter.com/home?lang=en', N'employer20')
GO
SET IDENTITY_INSERT [dbo].[Genders] ON 

INSERT [dbo].[Genders] ([GenderID], [GenderText]) VALUES (1, N'Male')
INSERT [dbo].[Genders] ([GenderID], [GenderText]) VALUES (2, N'Female')
SET IDENTITY_INSERT [dbo].[Genders] OFF
GO
INSERT [dbo].[Graduates] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1261, N'123456789', N'Hanna Moos', CAST(N'1986-10-17' AS Date), N'Female', N'+302106878934', N'graduate1@example.com', N'Greece', N'Business Information Systems', N'Vocational Institute IEK Patras', N'graduate1')
INSERT [dbo].[Graduates] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1262, N'123456789', N'Frederique Citeaux', CAST(N'2000-10-15' AS Date), N'Prefer not to say', N'011-4988260', N'graduate2@example.com', N'Italy', N'CAD/CAM Engineering Technology', N'Torino Technical School 1', N'graduate2')
INSERT [dbo].[Graduates] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1263, N'123456789', N'Martín Sommer', CAST(N'2002-01-11' AS Date), N'Male', N'(171) 555-0297', N'graduate3@example.com', N'Ireland', N'Agricultural Machinery Technician', N'Vocational Institute of Dublin', N'graduate3')
INSERT [dbo].[Graduates] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1264, N'123456789', N'Laurence Lebihan', CAST(N'2001-07-13' AS Date), N'Female', N'0114988260', N'graduate4@example.com', N'Spain', N'Dental Assisting', N'Vocational Institute 8', N'graduate4')
INSERT [dbo].[Graduates] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1265, N'123456789', N'Elizabeth Lincoln', CAST(N'1990-05-21' AS Date), N'Female', N'(503) 555-9573', N'graduate5@example.com', N'Portugal', N'Business and marketing management', N'Vocational Institute 9', N'graduate5')
INSERT [dbo].[Graduates] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1626, N'123456789', N'Logan Patterson', CAST(N'1986-12-03' AS Date), N'Male', N'703-555-0171', N'logan13@adventure-works.com', N'Ireland', N'Business and marketing management', N'School 20', N'graduate6')
INSERT [dbo].[Graduates] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1627, N'123456789', N'Raquel Romero', CAST(N'1995-02-10' AS Date), N'Female', N'500 555-0113', N'raquel6@adventure-works.com', N'Portugal', N'Critical Care Nursing', N'School 13', N'graduate7')
INSERT [dbo].[Graduates] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1628, N'123456789', N'Ernest Huang', CAST(N'1988-04-23' AS Date), N'Male', N'500 555-0126', N'ernest5@adventure-works.com', N'Malta', N'Engineering Design and Drafting Technology', N'School 23', N'graduate8')
INSERT [dbo].[Graduates] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1629, N'123456789', N'Jonathan Russell', CAST(N'1994-06-12' AS Date), N'Male', N'500 555-0149', N'jonathan19@adventure-works.com', N'Ireland', N'Hotel and Restaurant Management', N'School 12', N'graduate9')
INSERT [dbo].[Graduates] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1630, N'123456789', N'Logan Coleman', CAST(N'1995-03-22' AS Date), N'Male', N'107-555-0161', N'logan8@adventure-works.com', N'Italy', N'Bookkeeping, Accounting and Auditing', N'School 11', N'graduate10')
INSERT [dbo].[Graduates] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1631, N'123456789', N'Logan Henderson', CAST(N'1992-10-15' AS Date), N'Male', N'154-555-0134', N'logan7@adventure-works.com', N'Cyprus', N'Construction Operations', N'School 12', N'graduate11')
INSERT [dbo].[Graduates] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1632, N'123456789', N'Ernest Zhang', CAST(N'1992-04-12' AS Date), N'Described in another way', N'429-555-0131', N'ernest0@adventure-works.com', N'Belgium', N'Hotel and Restaurant Management', N'School 23', N'graduate12')
INSERT [dbo].[Graduates] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1633, N'123456789', N'Ethan Henderson', CAST(N'1993-07-08' AS Date), N'Male', N'500 555-0176', N'ethan1@adventure-works.com', N'Ireland', N'Interactive Media Production', N'School 15', N'graduate13')
INSERT [dbo].[Graduates] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1634, N'123456789', N'Steve Wagner', CAST(N'1992-12-03' AS Date), N'Male', N'500 555-0164', N'steve5@adventure-works.com', N'Spain', N'Electrical and Electronics Repairman', N'School 20', N'graduate14')
INSERT [dbo].[Graduates] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1635, N'123456789', N'Raquel Dominguez', CAST(N'1994-08-03' AS Date), N'Female', N'500 555-0147', N'raquel9@adventure-works.com', N'Portugal', N'Fashion Designer', N'School 11', N'graduate15')
INSERT [dbo].[Graduates] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1636, N'123456789', N'Rene Phillips', CAST(N'1994-09-11' AS Date), N'Male', N'(907) 555-7584', N'graduate16@example.com', N'Ireland', N'Business Information Systems', N'School 22', N'graduate16')
INSERT [dbo].[Graduates] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1637, N'123456789', N'Marie Bertrand', CAST(N'1993-06-25' AS Date), N'Female', N'(1) 42.34.22.66', N'graduate17@example.com', N'France', N'Health care and social assistant', N'School 25', N'graduate17')
INSERT [dbo].[Graduates] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1638, N'123456789', N'Yvonne Moncada', CAST(N'1994-03-12' AS Date), N'Female', N'(1) 135-5333', N'graduate18@example.com', N'France', N'Hotel and Restaurant Management', N'School 25', N'graduate18')
INSERT [dbo].[Graduates] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1639, N'123456789', N'Bernardo Batista', CAST(N'1995-05-23' AS Date), N'Male', N'(21) 555-4252', N'graduate19@example.com', N'Spain', N'Occupational Health and Safety Practitioner', N'School 33', N'graduate19')
INSERT [dbo].[Graduates] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1640, N'123456789', N'Isabel de Castro', CAST(N'1995-06-07' AS Date), N'Female', N'(1) 356-5634', N'graduate20@example.com', N'Portugal', N'Digital Graphic Design', N'School 456', N'graduate20')
INSERT [dbo].[Graduates] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1672, N'123456789', N'Martine Rancé', CAST(N'2000-06-11' AS Date), N'Female', N'20.16.10.16', N'graduate21@example.com', N'France', N'Business Information Systems', N'School 22', N'graduate21')
INSERT [dbo].[Graduates] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1673, N'123456789', N'Maria Larsson', CAST(N'2001-09-10' AS Date), N'Female', N'0695-34 67 21', N'graduate22@example.com', N'Portugal', N'Business Information Systems', N'School 22', N'graduate22')
INSERT [dbo].[Graduates] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1674, N'123456789', N'Peter Franken', CAST(N'2002-08-12' AS Date), N'Male', N'089-0877310', N'graduate23@example.com', N'Germany', N'Auto Repair Technician', N'School 30', N'graduate23')
INSERT [dbo].[Graduates] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1675, N'123456789', N'Paolo Accorti', CAST(N'2000-04-09' AS Date), N'Male', N'011-4988260', N'graduate24@example.com', N'Italy', N'Auto Repair Technician', N'School 20', N'graduate24')
INSERT [dbo].[Graduates] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1676, N'123456789', N'Eduardo Saavedra', CAST(N'2000-11-12' AS Date), N'Male', N'(93) 203 4560', N'graduate25@example.com', N'Spain', N'Auto Repair Technician', N'School 25', N'graduate25')
INSERT [dbo].[Graduates] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1684, N'123456789', N'John Steel', CAST(N'1998-02-21' AS Date), N'Male', N'(509) 555-7969', N'graduate26@example.com', N'Ireland', N'Business Information Systems', N'School 25', N'graduate26')
INSERT [dbo].[Graduates] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1686, N'123456789', N'Felipe Izquierdo', CAST(N'1999-07-12' AS Date), N'Male', N'(8) 34-56-12', N'graduate27@example.com', N'Spain', N'Business Information Systems', N'School 26', N'graduate27')
INSERT [dbo].[Graduates] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1687, N'123456789', N'Giovanni Rovelli', CAST(N'1998-07-30' AS Date), N'Male', N'035-640230', N'graduate28@example.com', N'Italy', N'Auto Repair Technician', N'School 35', N'graduate28')
INSERT [dbo].[Graduates] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1688, N'123456789', N'Catherine Dewey', CAST(N'1999-04-23' AS Date), N'Female', N'(02) 201 24 67', N'graduate29@example.com', N'Belgium', N'Auto Repair Technician', N'School 23', N'graduate29')
INSERT [dbo].[Graduates] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1689, N'123456789', N'Alexander Feuer', CAST(N'2000-09-23' AS Date), N'Male', N'0342-023176', N'graduate30@example.com', N'Austria', N'Auto Repair Technician', N'School 35', N'graduate30')
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
INSERT [dbo].[LiaisonOfficers] ([MemberID], [TaxNumber], [FullName], [Country], [Phone], [Email], [OfficeAddress], [Occupation], [Employer], [LoginName]) VALUES (1276, N'123456789', N'Roland Mendel', N'Greece', N'+302106878934', N'liaison1@example.com', N'Plateia Georgiou 21, Athens, Attica, Greece', N'Psychology and Sociology', N'Umbraco Ltd', N'liaison1')
INSERT [dbo].[LiaisonOfficers] ([MemberID], [TaxNumber], [FullName], [Country], [Phone], [Email], [OfficeAddress], [Occupation], [Employer], [LoginName]) VALUES (1277, N'123456789', N'Aria Cruz', N'France', N'115552167', N'liaison2@example.com', N'Address 567', N'Business Continuity Planner', N'Seven Seas Imports', N'liaison2')
INSERT [dbo].[LiaisonOfficers] ([MemberID], [TaxNumber], [FullName], [Country], [Phone], [Email], [OfficeAddress], [Occupation], [Employer], [LoginName]) VALUES (1278, N'123456789', N'Diego Roel', N'Austria', N'(5) 555-2933', N'liaison3@example.com', N'Address 2354253', N'Immigration and Customs Inspector', N'Toms Spezialitäten', N'liaison3')
INSERT [dbo].[LiaisonOfficers] ([MemberID], [TaxNumber], [FullName], [Country], [Phone], [Email], [OfficeAddress], [Occupation], [Employer], [LoginName]) VALUES (1279, N'123456789', N'Martine Rancé', N'Portugal', N'86 21 32 43', N'liaison4@example.com', N'Address 989898', N'Advertising Sales Agent', N'Princesa Isabel Vinhos', N'liaison4')
INSERT [dbo].[LiaisonOfficers] ([MemberID], [TaxNumber], [FullName], [Country], [Phone], [Email], [OfficeAddress], [Occupation], [Employer], [LoginName]) VALUES (1280, N'123456789', N'Maria Larsson', N'Ireland', N'0522-556721', N'liaison5@example.com', N'Address 3465346345', N'Human Resources Assistant', N'Rattlesnake Canyon S.A.', N'liaison5')
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
INSERT [dbo].[Organizations] ([MemberID], [TaxNumber], [OrganizationName], [ContactPerson], [Country], [Headquarters], [JobSector], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1286, N'123456789', N'Association of Commercial Television in Europe (ACT)', N'Patricia Anderson', N'France', N'Address 565656', N'Hospitality and Events Management', N'+32 7896123', N'organization1@example.com', N'www.organization1.org', N'https://www.facebook.com/, https://twitter.com/home?lang=en', N'organization1')
INSERT [dbo].[Organizations] ([MemberID], [TaxNumber], [OrganizationName], [ContactPerson], [Country], [Headquarters], [JobSector], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1287, N'', N'Association of Mutual Insurers and Insurance Cooperatives in Europe (AMICE)', N'Giovanni Rovelli', N'France', N'', N'Marketing, Advertising and Public Relations', N'(02) 201 24 67', N'organization2@example.com', N'', N'', N'organization2')
INSERT [dbo].[Organizations] ([MemberID], [TaxNumber], [OrganizationName], [ContactPerson], [Country], [Headquarters], [JobSector], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1288, N'123456789', N'Council of European Municipalities and Regions (CEMR)', N'Yvonne Moncada', N'Malta', N'Address 435435435', N'Public Services and Administration', N'0221-0644327', N'organization3@example.com', N'www.organization3.org', N'', N'organization3')
INSERT [dbo].[Organizations] ([MemberID], [TaxNumber], [OrganizationName], [ContactPerson], [Country], [Headquarters], [JobSector], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1289, N'123456789', N'European Association of Employers'' Organisations in Hairdressing (Coiffure EU)', N'Dominique Perrier', N'Belgium', N'Address 213213123', N'Marketing, Advertising and Public Relations', N'0897-034214', N'organization4@example.com', N'www.organization4.org', N'https://www.facebook.com/, https://twitter.com/home?lang=en', N'organization4')
INSERT [dbo].[Organizations] ([MemberID], [TaxNumber], [OrganizationName], [ContactPerson], [Country], [Headquarters], [JobSector], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1290, N'123456789', N'European Coordination of Independent Producers (CEPI)', N'Helvetius Nagy', N'Italy', N'Address 52454', N'Recruitment and Human Resouces', N'07-98 92 35', N'organization5@example.com', N'www.organization5.org', N'https://www.facebook.com/, https://twitter.com/home?lang=en', N'organization5')
GO
INSERT [dbo].[Schools] ([MemberID], [TaxNumber], [SchoolName], [ContactPerson], [Country], [Address], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1281, N'123456789', N'Hi-Tech Training', N'Rebecca Thorn', N'Malta', N'Another street and number 2', N'223-4565456', N'school1@example.com', N'www.example.com', N'https://www.facebook.com/', N'school1')
INSERT [dbo].[Schools] ([MemberID], [TaxNumber], [SchoolName], [ContactPerson], [Country], [Address], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1282, N'123456789', N'Dublin Vocational Academy', N'Helen Bennett', N'Ireland', N'Rue Joseph-Bens 532', N'(5) 555-1340', N'school2@example.com', N'www.school2.edu', N'https://www.facebook.com/, https://twitter.com/home?lang=en', N'school2')
INSERT [dbo].[Schools] ([MemberID], [TaxNumber], [SchoolName], [ContactPerson], [Country], [Address], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1283, N'123456789', N'Product School Athens', N'Alexopoulou Dimitra', N'Greece', N'Leoforos Georgiou 11', N'210-3456 443', N'school3@example.com', N'www.school3.edu', N'https://www.facebook.com/, https://twitter.com/home?lang=en, https://gr.linkedin.com/', N'school3')
INSERT [dbo].[Schools] ([MemberID], [TaxNumber], [SchoolName], [ContactPerson], [Country], [Address], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1284, N'123456789', N'Learning Tree International', N'Carlos González', N'Portugal', N'Some street and number 5', N'(1) 135-5333', N'school4@example.com', N'www.school4.com', N'https://www.facebook.com/, https://twitter.com/home?lang=en, https://gr.linkedin.com/', N'school4')
INSERT [dbo].[Schools] ([MemberID], [TaxNumber], [SchoolName], [ContactPerson], [Country], [Address], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1285, N'123456789', N'School Courses & Career Development', N'Rene Phillips', N'Spain', N'Carrera 52 con Ave. Bolívar #65-98 Llano Largo', N'0372-035188', N'school5@example.com', N'www.school5.edu', N'https://www.facebook.com/, https://twitter.com/home?lang=en, https://gr.linkedin.com/', N'school5')
INSERT [dbo].[Schools] ([MemberID], [TaxNumber], [SchoolName], [ContactPerson], [Country], [Address], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1641, N'123456789', N'PEARSON PROFESSIONAL TESTING CENTER', N'Maurizio Moroni', N'Italy', N'Address 1234', N'0522-556721', N'school6@example.com', N'www.pearson-school.edu', N'https://www.facebook.com/, https://twitter.com/home?lang=en', N'school6')
INSERT [dbo].[Schools] ([MemberID], [TaxNumber], [SchoolName], [ContactPerson], [Country], [Address], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1642, N'123456789', N'The Culinary Center & Cookery Club', N'Alejandra Camino', N'Spain', N'Address 456', N'(91) 745 6200', N'school7@example.com', N'www.school6.edu', N'https://www.facebook.com/, https://twitter.com/home?lang=en', N'school7')
INSERT [dbo].[Schools] ([MemberID], [TaxNumber], [SchoolName], [ContactPerson], [Country], [Address], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1643, N'123456789', N'National Organization for Certification of Qualifications & Vocational Guidance', N'Jytte Petersen', N'Denmark', N'Address 9879', N'31 12 34 56', N'school8@example.com', N'www.school8.edu', N'https://www.facebook.com/, https://twitter.com/home?lang=en', N'school8')
INSERT [dbo].[Schools] ([MemberID], [TaxNumber], [SchoolName], [ContactPerson], [Country], [Address], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1644, N'123456789', N'DLUX Professional Sweden', N'Jonas Bergulfsen', N'Sweden', N'Address 1234567', N'07-98 92 35', N'school9@example.com', N'www.school9.edu', N'https://www.facebook.com/, https://twitter.com/home?lang=en', N'school9')
INSERT [dbo].[Schools] ([MemberID], [TaxNumber], [SchoolName], [ContactPerson], [Country], [Address], [Phone], [Email], [Website], [SocialMedia], [LoginName]) VALUES (1645, N'123456789', N'Institute of Hospitality and Culinary Arts', N'Anabela Domingues', N'Spain', N'Address 567', N'(11) 555-2167', N'school10@example.com', N'www.school10.edu', N'https://www.facebook.com/, https://twitter.com/home?lang=en', N'school10')
GO
INSERT [dbo].[Students] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1256, N'123456789', N'Maria Anders', CAST(N'1992-03-16' AS Date), N'Female', N'+302106878934', N'student1@example.com', N'Greece', N'Automation control', N'Vocational Institute IEK Patras', N'student1')
INSERT [dbo].[Students] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1257, N'123456789', N'Ana Trujillo', CAST(N'2001-01-11' AS Date), N'Female', N'(8) 34-56-12', N'student2@example.com', N'Italy', N'Chemical Plant Operator', N'Vocational Institute 3', N'student2')
INSERT [dbo].[Students] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1258, N'123456789', N'Antonio Moreno', CAST(N'2003-08-12' AS Date), N'Male', N'035-640230', N'student3@example.com', N'Netherlands', N'Small Business Management', N'Vocational Institute 4', N'student3')
INSERT [dbo].[Students] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1259, N'123456789', N'Thomas Hardy', CAST(N'2000-03-04' AS Date), N'Male', N'(93) 203 4560', N'student4@example.com', N'France', N'Library and Information Technology', N'Technical School for BA', N'student4')
INSERT [dbo].[Students] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1260, N'123456789', N'Christina Berglund', CAST(N'2002-01-11' AS Date), N'Female', N'0114988260', N'student5@example.com', N'Ireland', N'Hairstyling, Cosmetics and Beautification', N'Technical College 8', N'student5')
INSERT [dbo].[Students] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1296, N'123456789', N'Catherine Dewey', CAST(N'2001-03-23' AS Date), N'Female', N'0555-09876', N'student6@example.com', N'Ireland', N'Hotel and Restaurant Management', N'Technical College 8', N'student6')
INSERT [dbo].[Students] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1582, N'123456789', N'Gustavo Achong', CAST(N'2005-03-23' AS Date), N'Male', N'398-555-0132', N'student7@example.com', N'Croatia', N'Computer networking management', N'School 1', N'student7')
INSERT [dbo].[Students] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1583, N'123456789', N'Catherine Abel', CAST(N'2004-04-12' AS Date), N'Female', N'747-555-0171', N'catherine0@adventure-works.com', N'Belgium', N'Esthetician', N'School 2', N'student8')
INSERT [dbo].[Students] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1584, N'123456789', N'Kim Abercrombie', CAST(N'2000-06-12' AS Date), N'Female', N'334-555-0137', N'kim2@adventure-works.com', N'Estonia', N'Dental Assisting', N'School 3', N'student9')
INSERT [dbo].[Students] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1585, N'123456789', N'Humberto Acevedo', CAST(N'2003-08-03' AS Date), N'Male', N'599-555-0127', N'humberto0@adventure-works.com', N'Spain', N'Digital Graphic Design', N'School 4', N'student10')
INSERT [dbo].[Students] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1586, N'123456789', N'Pilar Ackerman', CAST(N'2004-11-12' AS Date), N'Male', N'500 555-0132', N'pilar1@adventure-works.com', N'Ireland', N'Health care and social assistant', N'School 5', N'student11')
INSERT [dbo].[Students] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1587, N'123456789', N'Frances Adams', CAST(N'2006-08-08' AS Date), N'Male', N'991-555-0183', N'frances0@adventure-works.com', N'Luxemburg', N'Industrial Mechanics', N'School 5', N'student12')
INSERT [dbo].[Students] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1588, N'123456789', N'Margaret Smith', CAST(N'2006-07-22' AS Date), N'Female', N'959-555-0151', N'margaret0@adventure-works.com', N'Ireland', N'Fashion Designer', N'School 6', N'student13')
INSERT [dbo].[Students] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1589, N'123456789', N'Carla Adams', CAST(N'2007-12-09' AS Date), N'Female', N'107-555-0138', N'carla0@adventure-works.com', N'Greece', N'Hairstyling, Cosmetics and Beautification', N'School 7', N'student14')
INSERT [dbo].[Students] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1590, N'123456789', N'Jay Adams', CAST(N'2001-07-13' AS Date), N'Male', N'158-555-0142', N'jay1@adventure-works.com', N'France', N'Engineering Design and Drafting Technology', N'School 8', N'student15')
INSERT [dbo].[Students] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1591, N'123456789', N'Ronald Adina', CAST(N'2001-07-13' AS Date), N'Male', N'453-555-0165', N'ronald0@adventure-works.com', N'Bulgaria', N'Business and marketing management', N'School 9', N'student16')
INSERT [dbo].[Students] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1595, N'123456789', N'Samuel Agcaoili', CAST(N'2003-08-12' AS Date), N'Male', N'554-555-0110', N'samuel0@adventure-works.com', N'Portugal', N'Hotel and Restaurant Management', N'School 11', N'student17')
INSERT [dbo].[Students] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1596, N'123456789', N'James Aguilar', CAST(N'2005-08-04' AS Date), N'Male', N'500 555-0198', N'james2@adventure-works.com', N'Sweden', N'Chemical Plant Operator', N'School 11', N'student18')
INSERT [dbo].[Students] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1597, N'123456789', N'Robert Ahlering', CAST(N'2004-02-17' AS Date), N'Male', N'678-555-0175', N'robert1@adventure-works.com', N'Finland', N'Construction Operations', N'School 20', N'student19')
INSERT [dbo].[Students] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1598, N'123456789', N'Kim Akers', CAST(N'2003-07-13' AS Date), N'Female', N'440-555-0166', N'kim3@adventure-works.com', N'Ireland', N'CAD/CAM Engineering Technology', N'School 15', N'student20')
INSERT [dbo].[Students] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1667, N'123456789', N'Elizabeth Brown', CAST(N'2003-03-03' AS Date), N'Female', N'(171) 555-2282', N'student21@example.com', N'Ireland', N'Hairstyling, Cosmetics and Beautification', N'School 34', N'student21')
INSERT [dbo].[Students] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1668, N'123456789', N'Janine Labrune', CAST(N'2005-08-12' AS Date), N'Female', N'40.67.88.88', N'student22@example.com', N'France', N'Hairstyling, Cosmetics and Beautification', N'School 34', N'student22')
INSERT [dbo].[Students] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1669, N'123456789', N'Roland Mendel', CAST(N'2004-05-21' AS Date), N'Male', N'7675-3425', N'student23@example.com', N'Austria', N'Hairstyling, Cosmetics and Beautification', N'School 34', N'student23')
INSERT [dbo].[Students] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1670, N'123456789', N'Aria Cruz', CAST(N'2004-09-06' AS Date), N'Female', N'(11) 555-9857', N'student24@example.com', N'Belgium', N'Hotel and Restaurant Management', N'School 35', N'student24')
INSERT [dbo].[Students] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1671, N'123456789', N'Diego Roel', CAST(N'2005-10-08' AS Date), N'Male', N'(91) 555 94 44', N'student25@example.com', N'Portugal', N'Hotel and Restaurant Management', N'School 35', N'student25')
INSERT [dbo].[Students] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1677, N'123456789', N'Carlos Hernández', CAST(N'2003-09-07' AS Date), N'Male', N'(5) 555-1340', N'student26@example.com', N'Spain', N'Hotel and Restaurant Management', N'School 35', N'student26')
INSERT [dbo].[Students] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1680, N'123456789', N'Yoshi Latimer', CAST(N'2003-12-09' AS Date), N'Male', N'(503) 555-6874', N'student27@example.com', N'Ireland', N'Hotel and Restaurant Management', N'School 35', N'student27')
INSERT [dbo].[Students] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1681, N'123456789', N'Patricia McKenna', CAST(N'2002-03-14' AS Date), N'Female', N'0695-34 67 21', N'student28@example.com', N'Ireland', N'Hairstyling, Cosmetics and Beautification', N'School 35', N'student28')
INSERT [dbo].[Students] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1682, N'123456789', N'Daniel Tonini', CAST(N'2004-06-16' AS Date), N'Male', N'30.59.84.10', N'student29@example.com', N'Italy', N'Hairstyling, Cosmetics and Beautification', N'School 35', N'student29')
INSERT [dbo].[Students] ([MemberID], [TaxNumber], [FullName], [Birthdate], [Gender], [Phone], [Email], [Country], [Specialization], [School], [LoginName]) VALUES (1683, N'123456789', N'Annette Roulet', CAST(N'2004-10-12' AS Date), N'Female', N'61.77.61.10', N'student30@example.com', N'France', N'Hairstyling, Cosmetics and Beautification', N'School 35', N'student30')
GO
INSERT [dbo].[tbl_hit_counter] ([node_id], [views]) VALUES (1080, 69)
GO
INSERT [dbo].[Teachers] ([MemberID], [TaxNumber], [FullName], [Country], [School], [SchoolAddress], [Phone], [Email], [SocialMedia], [LoginName]) VALUES (1291, N'123456789', N'Simon Crowther', N'Luxemburg', N'Vocational Institute IEK Creta', N'Address 12', N'+302346789323', N'teacher1@example.com', N'https://www.facebook.com/', N'teacher1')
INSERT [dbo].[Teachers] ([MemberID], [TaxNumber], [FullName], [Country], [School], [SchoolAddress], [Phone], [Email], [SocialMedia], [LoginName]) VALUES (1292, N'123456789', N'Yvonne Moncada', N'Netherlands', N'Ofsio Technical School', N'Sierras de Granada 9993', N'07-98 92 35', N'teacher2@example.com', N'https://www.facebook.com/, https://twitter.com/home?lang=en, https://gr.linkedin.com/', N'teacher2')
INSERT [dbo].[Teachers] ([MemberID], [TaxNumber], [FullName], [Country], [School], [SchoolAddress], [Phone], [Email], [SocialMedia], [LoginName]) VALUES (1293, N'123456789', N'Henriette Pfalzheim', N'Spain', N'Ofistic Technical School', N'Berkeley Gardens 12  Brewery', N'(071) 23 67 22 20', N'teacher3@example.com', N'', N'teacher3')
INSERT [dbo].[Teachers] ([MemberID], [TaxNumber], [FullName], [Country], [School], [SchoolAddress], [Phone], [Email], [SocialMedia], [LoginName]) VALUES (1294, N'123456789', N'Guillermo Fernández', N'France', N'Techgenix Technical School', N'35 King George', N'0711-020361', N'teacher4@example.com', N'', N'teacher4')
INSERT [dbo].[Teachers] ([MemberID], [TaxNumber], [FullName], [Country], [School], [SchoolAddress], [Phone], [Email], [SocialMedia], [LoginName]) VALUES (1295, N'123456789', N'Isabel de Castro', N'Portugal', N'TeachnoCart Institute', N'Berliner Platz 43', N'981-443655', N'teacher5@example.com', N'', N'teacher5')
GO
/****** Object:  StoredProcedure [dbo].[usp_get_view_count]    Script Date: 16/3/2021 6:45:55 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_get_view_count]
(
    @node_id INT
)
AS
BEGIN

    SET NOCOUNT ON;

    SELECT views
    FROM tbl_hit_counter
    WHERE node_id = @node_id  

END

GO
/****** Object:  StoredProcedure [dbo].[usp_record_view]    Script Date: 16/3/2021 6:45:55 πμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_record_view]
(
    @node_id INT
)
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS(SELECT 1 FROM tbl_hit_counter WHERE node_id = @node_id)
    BEGIN
        UPDATE tbl_hit_counter SET views = views + 1
        WHERE node_id = @node_id
    END
    ELSE
    BEGIN
        INSERT INTO tbl_hit_counter(node_id, views) VALUES (@node_id, 1)
    END
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[21] 4[17] 2[6] 3) )"
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
         Begin Table = "qryCountMembers"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 146
               Right = 212
            End
            DisplayFlags = 280
            TopColumn = 1
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
         Column = 1845
         Alias = 1815
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'chartCountMembers'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'chartCountMembers'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[22] 4[16] 2[6] 3) )"
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
         Column = 2700
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qryCountMembers'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qryCountMembers'
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
         Width = 2655
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
            TopColumn = 0
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
         Column = 3105
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
         Configuration = "(H (1[23] 4[16] 2[9] 3) )"
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
         Begin Table = "Ambassadors"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 146
               Right = 212
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "sql_MembersTotal"
            Begin Extent = 
               Top = 6
               Left = 250
               Bottom = 89
               Right = 424
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
      Begin ColumnWidths = 12
         Column = 3990
         Alias = 2205
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountAmbassador'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountAmbassador'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[23] 4[19] 2[10] 3) )"
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
               Top = 6
               Left = 38
               Bottom = 146
               Right = 233
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "sql_MembersTotal"
            Begin Extent = 
               Top = 6
               Left = 271
               Bottom = 89
               Right = 461
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
      Begin ColumnWidths = 12
         Column = 1440
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountEmployer'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountEmployer'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[24] 4[19] 2[10] 3) )"
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
         Begin Table = "Graduates"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 146
               Right = 228
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "sql_MembersTotal"
            Begin Extent = 
               Top = 6
               Left = 266
               Bottom = 89
               Right = 456
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
      Begin ColumnWidths = 12
         Column = 3735
         Alias = 2055
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountGraduate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountGraduate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[23] 4[26] 2[10] 3) )"
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
         Begin Table = "sql_MembersTotal"
            Begin Extent = 
               Top = 6
               Left = 266
               Bottom = 89
               Right = 456
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LiaisonOfficers"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 146
               Right = 228
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
      Begin ColumnWidths = 12
         Column = 3465
         Alias = 2340
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountLiaison'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountLiaison'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[21] 4[17] 2[10] 3) )"
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
         Begin Table = "Organizations"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 146
               Right = 253
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "sql_MembersTotal"
            Begin Extent = 
               Top = 6
               Left = 291
               Bottom = 89
               Right = 481
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
      Begin ColumnWidths = 12
         Column = 2910
         Alias = 2175
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountOrganization'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountOrganization'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[22] 4[19] 2[10] 3) )"
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
         Begin Table = "Schools"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 146
               Right = 228
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "sql_MembersTotal"
            Begin Extent = 
               Top = 6
               Left = 266
               Bottom = 89
               Right = 456
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
      Begin ColumnWidths = 12
         Column = 2505
         Alias = 2250
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountSchool'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountSchool'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[21] 4[19] 2[9] 3) )"
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
         Begin Table = "Students"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 146
               Right = 228
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "sql_MembersTotal"
            Begin Extent = 
               Top = 6
               Left = 266
               Bottom = 89
               Right = 456
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
      Begin ColumnWidths = 12
         Column = 2940
         Alias = 2190
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountStudent'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountStudent'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[22] 4[17] 2[10] 3) )"
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
         Begin Table = "Teachers"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 146
               Right = 230
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "sql_MembersTotal"
            Begin Extent = 
               Top = 6
               Left = 268
               Bottom = 89
               Right = 458
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
      Begin ColumnWidths = 12
         Column = 2640
         Alias = 1890
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountTeacher'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountTeacher'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[11] 4[14] 2[25] 3) )"
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
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountUnionAll'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_CountUnionAll'
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
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[23] 4[11] 2[8] 3) )"
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
               Top = 6
               Left = 38
               Bottom = 146
               Right = 212
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
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 2295
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_MembersTotal'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'sql_MembersTotal'
GO
USE [master]
GO
ALTER DATABASE [AppinternWorks] SET  READ_WRITE 
GO
