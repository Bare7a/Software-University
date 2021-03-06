USE [School]
GO
/****** Object:  User [School_User]    Script Date: 19.6.2015 г. 22:00:04 ч. ******/
CREATE USER [School_User] FOR LOGIN [School_User] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [School_User]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [School_User]
GO
/****** Object:  Table [dbo].[Classes]    Script Date: 19.6.2015 г. 22:00:04 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Classes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[MaxStudents] [int] NOT NULL,
 CONSTRAINT [PK_Classes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Students]    Script Date: 19.6.2015 г. 22:00:04 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Age] [int] NOT NULL,
	[PhoneNumber] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Classes] ON 

INSERT [dbo].[Classes] ([Id], [Name], [MaxStudents]) VALUES (1, N'Math', 20)
INSERT [dbo].[Classes] ([Id], [Name], [MaxStudents]) VALUES (6, N'Biology', 12)
INSERT [dbo].[Classes] ([Id], [Name], [MaxStudents]) VALUES (7, N'Music', 18)
INSERT [dbo].[Classes] ([Id], [Name], [MaxStudents]) VALUES (8, N'Art', 25)
SET IDENTITY_INSERT [dbo].[Classes] OFF
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([Id], [Name], [Age], [PhoneNumber]) VALUES (1, N'Bat Boiko', 54, N'0888999444')
INSERT [dbo].[Students] ([Id], [Name], [Age], [PhoneNumber]) VALUES (2, N'Justin Bieber', 9, N'0888333222')
INSERT [dbo].[Students] ([Id], [Name], [Age], [PhoneNumber]) VALUES (4, N'Ali Raza', 67, N'0888999333')
INSERT [dbo].[Students] ([Id], [Name], [Age], [PhoneNumber]) VALUES (5, N'Hanko Brat', 22, N'0888333444')
INSERT [dbo].[Students] ([Id], [Name], [Age], [PhoneNumber]) VALUES (6, N'Yuno Gasai', 15, N'0888123321')
SET IDENTITY_INSERT [dbo].[Students] OFF
