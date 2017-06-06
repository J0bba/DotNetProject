USE [MeditateBook]
GO
/****** Object:  Table [dbo].[T_Article]    Script Date: 06/06/2017 17:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Article](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[title] [varchar](255) NOT NULL,
	[content] [text] NOT NULL,
	[id_creator] [bigint] NOT NULL,
	[created_date] [date] NOT NULL,
	[validated] [bit] NOT NULL,
 CONSTRAINT [PK_T_Article] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[T_Article_Attach]    Script Date: 06/06/2017 17:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Article_Attach](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[id_article] [bigint] NOT NULL,
	[file_path] [text] NOT NULL,
 CONSTRAINT [PK_T_Article_Attach] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[T_Article_Image]    Script Date: 06/06/2017 17:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Article_Image](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[id_article] [bigint] NOT NULL,
	[image_path] [text] NOT NULL,
 CONSTRAINT [PK_T_Article_Image] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[T_Comment]    Script Date: 06/06/2017 17:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Comment](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[content] [text] NOT NULL,
	[id_user] [bigint] NOT NULL,
	[id_article] [bigint] NOT NULL,
	[date] [date] NOT NULL,
 CONSTRAINT [PK_T_Comment] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[T_Language]    Script Date: 06/06/2017 17:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Language](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NOT NULL,
	[shortname] [varchar](50) NOT NULL,
 CONSTRAINT [PK_T_Language] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[T_Message]    Script Date: 06/06/2017 17:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Message](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[content] [text] NOT NULL,
	[id_sender] [bigint] NOT NULL,
	[id_receiver] [bigint] NOT NULL,
	[date] [date] NOT NULL,
 CONSTRAINT [PK_T_Message] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[T_Translation]    Script Date: 06/06/2017 17:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Translation](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[content] [text] NOT NULL,
	[id_language] [bigint] NOT NULL,
	[id_article] [bigint] NOT NULL,
	[id_translator] [bigint] NOT NULL,
	[validated] [bit] NOT NULL,
 CONSTRAINT [PK_T_Translation] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[T_User]    Script Date: 06/06/2017 17:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_User](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[email] [varchar](255) NOT NULL,
	[password] [varchar](255) NOT NULL,
	[firstname] [varchar](255) NULL,
	[lastname] [varchar](255) NULL,
 CONSTRAINT [PK_T_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[T_User_Like]    Script Date: 06/06/2017 17:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_User_Like](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[id_user] [bigint] NOT NULL,
	[id_article] [bigint] NOT NULL,
 CONSTRAINT [PK_T_User_Like] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[T_Article]  WITH CHECK ADD  CONSTRAINT [FK_T_Article_T_User] FOREIGN KEY([id_creator])
REFERENCES [dbo].[T_User] ([id])
GO
ALTER TABLE [dbo].[T_Article] CHECK CONSTRAINT [FK_T_Article_T_User]
GO
ALTER TABLE [dbo].[T_Article_Attach]  WITH CHECK ADD  CONSTRAINT [FK_T_Article_Attach_T_Article] FOREIGN KEY([id_article])
REFERENCES [dbo].[T_Article] ([id])
GO
ALTER TABLE [dbo].[T_Article_Attach] CHECK CONSTRAINT [FK_T_Article_Attach_T_Article]
GO
ALTER TABLE [dbo].[T_Article_Image]  WITH CHECK ADD  CONSTRAINT [FK_T_Article_Image_T_Article] FOREIGN KEY([id_article])
REFERENCES [dbo].[T_Article] ([id])
GO
ALTER TABLE [dbo].[T_Article_Image] CHECK CONSTRAINT [FK_T_Article_Image_T_Article]
GO
ALTER TABLE [dbo].[T_Comment]  WITH CHECK ADD  CONSTRAINT [FK_T_Comment_T_Article] FOREIGN KEY([id_article])
REFERENCES [dbo].[T_Article] ([id])
GO
ALTER TABLE [dbo].[T_Comment] CHECK CONSTRAINT [FK_T_Comment_T_Article]
GO
ALTER TABLE [dbo].[T_Comment]  WITH CHECK ADD  CONSTRAINT [FK_T_Comment_T_User] FOREIGN KEY([id_user])
REFERENCES [dbo].[T_User] ([id])
GO
ALTER TABLE [dbo].[T_Comment] CHECK CONSTRAINT [FK_T_Comment_T_User]
GO
ALTER TABLE [dbo].[T_Message]  WITH CHECK ADD  CONSTRAINT [FK_T_Message_T_User] FOREIGN KEY([id_sender])
REFERENCES [dbo].[T_User] ([id])
GO
ALTER TABLE [dbo].[T_Message] CHECK CONSTRAINT [FK_T_Message_T_User]
GO
ALTER TABLE [dbo].[T_Message]  WITH CHECK ADD  CONSTRAINT [FK_T_Message_T_User1] FOREIGN KEY([id_receiver])
REFERENCES [dbo].[T_User] ([id])
GO
ALTER TABLE [dbo].[T_Message] CHECK CONSTRAINT [FK_T_Message_T_User1]
GO
ALTER TABLE [dbo].[T_Translation]  WITH CHECK ADD  CONSTRAINT [FK_T_Translation_T_Article] FOREIGN KEY([id_article])
REFERENCES [dbo].[T_Article] ([id])
GO
ALTER TABLE [dbo].[T_Translation] CHECK CONSTRAINT [FK_T_Translation_T_Article]
GO
ALTER TABLE [dbo].[T_Translation]  WITH CHECK ADD  CONSTRAINT [FK_T_Translation_T_Language] FOREIGN KEY([id_language])
REFERENCES [dbo].[T_Language] ([id])
GO
ALTER TABLE [dbo].[T_Translation] CHECK CONSTRAINT [FK_T_Translation_T_Language]
GO
ALTER TABLE [dbo].[T_Translation]  WITH CHECK ADD  CONSTRAINT [FK_T_Translation_T_User] FOREIGN KEY([id_translator])
REFERENCES [dbo].[T_User] ([id])
GO
ALTER TABLE [dbo].[T_Translation] CHECK CONSTRAINT [FK_T_Translation_T_User]
GO
ALTER TABLE [dbo].[T_User_Like]  WITH CHECK ADD  CONSTRAINT [FK_T_User_Like_T_Article] FOREIGN KEY([id_article])
REFERENCES [dbo].[T_Article] ([id])
GO
ALTER TABLE [dbo].[T_User_Like] CHECK CONSTRAINT [FK_T_User_Like_T_Article]
GO
ALTER TABLE [dbo].[T_User_Like]  WITH CHECK ADD  CONSTRAINT [FK_T_User_Like_T_User] FOREIGN KEY([id_user])
REFERENCES [dbo].[T_User] ([id])
GO
ALTER TABLE [dbo].[T_User_Like] CHECK CONSTRAINT [FK_T_User_Like_T_User]
GO
