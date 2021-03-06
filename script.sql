USE [karimDB]
GO
/****** Object:  Table [dbo].[Table_1]    Script Date: 7/14/2021 01:29:51 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_1](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](200) NULL,
	[work_adress] [varchar](500) NULL,
	[home_adress] [varchar](500) NULL,
	[city] [varchar](300) NULL,
	[number1] [int] NULL,
	[number2] [int] NULL,
	[title] [varchar](300) NULL,
	[job_id] [int] NULL,
	[email] [varchar](500) NULL,
	[notice] [varchar](1000) NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Table_1] ON 

INSERT [dbo].[Table_1] ([id], [name], [work_adress], [home_adress], [city], [number1], [number2], [title], [job_id], [email], [notice]) VALUES (2, N'كريم', N'القاهرة', N'الجيزة', N'الحوامدية', 15, 12, N'مبرمج', 19, N'karim@gmail.com', N'none')
INSERT [dbo].[Table_1] ([id], [name], [work_adress], [home_adress], [city], [number1], [number2], [title], [job_id], [email], [notice]) VALUES (4, N'يحيي', N'القاهرة', N'الجيزة', N'الحوامدية', 1, 2, N'مبرمج', 177, N'yahia@gmail.com', N'none')
SET IDENTITY_INSERT [dbo].[Table_1] OFF
