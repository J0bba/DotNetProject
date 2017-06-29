USE [MeditateBook]
GO
SET IDENTITY_INSERT [dbo].[T_User] ON 

GO
INSERT [dbo].[T_User] ([id], [email], [password], [firstname], [lastname]) VALUES (1, N'test@test.com', N'test', N'test', N'test')
GO
INSERT [dbo].[T_User] ([id], [email], [password], [firstname], [lastname]) VALUES (2, N'test', N'test', N'test', N'test')
GO
SET IDENTITY_INSERT [dbo].[T_User] OFF
GO
SET IDENTITY_INSERT [dbo].[T_Article] ON 

GO
INSERT [dbo].[T_Article] ([id], [title], [content], [id_creator], [created_date], [validated]) VALUES (1, N'test', N'le contenue du truc', 1, CAST(N'2016-12-11' AS Date), 0)
GO
SET IDENTITY_INSERT [dbo].[T_Article] OFF
GO
