USE [MeditateBook]
GO
SET IDENTITY_INSERT [dbo].[T_User] ON 

GO
INSERT [dbo].[T_User] ([id], [email], [password], [firstname], [lastname], [role]) VALUES (2, N'admin@admin.com', N'AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAalT7+HUZK0W1jusMMP2Q3gAAAAACAAAAAAAQZgAAAAEAACAAAADJWyi/TRf2lsr7FtK2ZYBRru37kThitj9siiIL7GNVMwAAAAAOgAAAAAIAACAAAACskANyCa6tDCiAJuGMflHeOpI997/LS6/myfBZKh1nSSAAAACVCbCP7ThrRfC9BFX5tChk20isvX3DM+TeGPj615ICO0AAAACoflk7JXpH046ZgJIC41oWXa2UuUjUjpp25v1xmKgQk2dK7aud5yVV9Bqd03Vx1XiFhA2KFvoLUGBhGcp+rdvE', N'Admin', N'Admin', 3)
GO
INSERT [dbo].[T_User] ([id], [email], [password], [firstname], [lastname], [role]) VALUES (3, N'admin1@admin.com', N'AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAalT7+HUZK0W1jusMMP2Q3gAAAAACAAAAAAAQZgAAAAEAACAAAADJWyi/TRf2lsr7FtK2ZYBRru37kThitj9siiIL7GNVMwAAAAAOgAAAAAIAACAAAACskANyCa6tDCiAJuGMflHeOpI997/LS6/myfBZKh1nSSAAAACVCbCP7ThrRfC9BFX5tChk20isvX3DM+TeGPj615ICO0AAAACoflk7JXpH046ZgJIC41oWXa2UuUjUjpp25v1xmKgQk2dK7aud5yVV9Bqd03Vx1XiFhA2KFvoLUGBhGcp+rdvE', N'Admin', N'Admin', 2)
GO
INSERT [dbo].[T_User] ([id], [email], [password], [firstname], [lastname], [role]) VALUES (4, N'admin2@admin.com', N'AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAalT7+HUZK0W1jusMMP2Q3gAAAAACAAAAAAAQZgAAAAEAACAAAADJWyi/TRf2lsr7FtK2ZYBRru37kThitj9siiIL7GNVMwAAAAAOgAAAAAIAACAAAACskANyCa6tDCiAJuGMflHeOpI997/LS6/myfBZKh1nSSAAAACVCbCP7ThrRfC9BFX5tChk20isvX3DM+TeGPj615ICO0AAAACoflk7JXpH046ZgJIC41oWXa2UuUjUjpp25v1xmKgQk2dK7aud5yVV9Bqd03Vx1XiFhA2KFvoLUGBhGcp+rdvE', N'Admin', N'Admin', 2)
GO
INSERT [dbo].[T_User] ([id], [email], [password], [firstname], [lastname], [role]) VALUES (5, N'translator1@translate.com', N'AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAalT7+HUZK0W1jusMMP2Q3gAAAAACAAAAAAAQZgAAAAEAACAAAADJWyi/TRf2lsr7FtK2ZYBRru37kThitj9siiIL7GNVMwAAAAAOgAAAAAIAACAAAACskANyCa6tDCiAJuGMflHeOpI997/LS6/myfBZKh1nSSAAAACVCbCP7ThrRfC9BFX5tChk20isvX3DM+TeGPj615ICO0AAAACoflk7JXpH046ZgJIC41oWXa2UuUjUjpp25v1xmKgQk2dK7aud5yVV9Bqd03Vx1XiFhA2KFvoLUGBhGcp+rdvE', N'Eric', N'Judor', 1)
GO
INSERT [dbo].[T_User] ([id], [email], [password], [firstname], [lastname], [role]) VALUES (6, N'translator2@translate.com', N'AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAalT7+HUZK0W1jusMMP2Q3gAAAAACAAAAAAAQZgAAAAEAACAAAADJWyi/TRf2lsr7FtK2ZYBRru37kThitj9siiIL7GNVMwAAAAAOgAAAAAIAACAAAACskANyCa6tDCiAJuGMflHeOpI997/LS6/myfBZKh1nSSAAAACVCbCP7ThrRfC9BFX5tChk20isvX3DM+TeGPj615ICO0AAAACoflk7JXpH046ZgJIC41oWXa2UuUjUjpp25v1xmKgQk2dK7aud5yVV9Bqd03Vx1XiFhA2KFvoLUGBhGcp+rdvE', N'Ramzy', N'Rebeu', 1)
GO
INSERT [dbo].[T_User] ([id], [email], [password], [firstname], [lastname], [role]) VALUES (8, N'user1@user.com', N'AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAalT7+HUZK0W1jusMMP2Q3gAAAAACAAAAAAAQZgAAAAEAACAAAADJWyi/TRf2lsr7FtK2ZYBRru37kThitj9siiIL7GNVMwAAAAAOgAAAAAIAACAAAACskANyCa6tDCiAJuGMflHeOpI997/LS6/myfBZKh1nSSAAAACVCbCP7ThrRfC9BFX5tChk20isvX3DM+TeGPj615ICO0AAAACoflk7JXpH046ZgJIC41oWXa2UuUjUjpp25v1xmKgQk2dK7aud5yVV9Bqd03Vx1XiFhA2KFvoLUGBhGcp+rdvE', N'Alexandre', N'Alves', 0)
GO
INSERT [dbo].[T_User] ([id], [email], [password], [firstname], [lastname], [role]) VALUES (9, N'user2@user.com', N'AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAalT7+HUZK0W1jusMMP2Q3gAAAAACAAAAAAAQZgAAAAEAACAAAADJWyi/TRf2lsr7FtK2ZYBRru37kThitj9siiIL7GNVMwAAAAAOgAAAAAIAACAAAACskANyCa6tDCiAJuGMflHeOpI997/LS6/myfBZKh1nSSAAAACVCbCP7ThrRfC9BFX5tChk20isvX3DM+TeGPj615ICO0AAAACoflk7JXpH046ZgJIC41oWXa2UuUjUjpp25v1xmKgQk2dK7aud5yVV9Bqd03Vx1XiFhA2KFvoLUGBhGcp+rdvE', N'Alexandre', N'Touzet', 0)
GO
INSERT [dbo].[T_User] ([id], [email], [password], [firstname], [lastname], [role]) VALUES (10, N'test@test.com', N'AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAalT7+HUZK0W1jusMMP2Q3gAAAAACAAAAAAAQZgAAAAEAACAAAADJWyi/TRf2lsr7FtK2ZYBRru37kThitj9siiIL7GNVMwAAAAAOgAAAAAIAACAAAACskANyCa6tDCiAJuGMflHeOpI997/LS6/myfBZKh1nSSAAAACVCbCP7ThrRfC9BFX5tChk20isvX3DM+TeGPj615ICO0AAAACoflk7JXpH046ZgJIC41oWXa2UuUjUjpp25v1xmKgQk2dK7aud5yVV9Bqd03Vx1XiFhA2KFvoLUGBhGcp+rdvE', N'Thib', N'Virsolvy', 2)
GO
SET IDENTITY_INSERT [dbo].[T_User] OFF
GO
SET IDENTITY_INSERT [dbo].[T_Article] ON 

GO
INSERT [dbo].[T_Article] ([id], [title], [content], [id_creator], [created_date], [validated]) VALUES (1, N'Article n�1', N'<p>Bonjour,</p>

<p>&nbsp;</p>

<p>ceci est le <strong>premier</strong> article !</p>
', 3, CAST(N'2017-07-04' AS Date), 0)
GO
INSERT [dbo].[T_Article] ([id], [title], [content], [id_creator], [created_date], [validated]) VALUES (2, N'Article 2', N'<p>Yo,</p>

<p>&nbsp;</p>

<p>second <em>article</em> ?</p>
', 2, CAST(N'2017-07-04' AS Date), 0)
GO
SET IDENTITY_INSERT [dbo].[T_Article] OFF
GO
SET IDENTITY_INSERT [dbo].[T_Language] ON 

GO
INSERT [dbo].[T_Language] ([id], [name], [shortname]) VALUES (1, N'English', N'en-us')
GO
SET IDENTITY_INSERT [dbo].[T_Language] OFF
GO
SET IDENTITY_INSERT [dbo].[T_Translation] ON 

GO
INSERT [dbo].[T_Translation] ([id], [content], [id_language], [id_article], [id_translator], [validated]) VALUES (1, N'<p>Hello,</p>

<p>&nbsp;</p>

<p>this is the&nbsp;<strong>first</strong>&nbsp;article !</p>
', 1, 1, 2, 1)
GO
INSERT [dbo].[T_Translation] ([id], [content], [id_language], [id_article], [id_translator], [validated]) VALUES (2, N'<p>Hello,</p>

<p>&nbsp;</p>

<p>second&nbsp;<em>article</em>&nbsp;?</p>
', 1, 2, 2, 1)
GO
SET IDENTITY_INSERT [dbo].[T_Translation] OFF
GO
SET IDENTITY_INSERT [dbo].[T_Message] ON 

GO
INSERT [dbo].[T_Message] ([id], [content], [id_sender], [id_receiver], [date], [isSeen]) VALUES (1, N'Bonjour l''admin !', 9, 2, CAST(N'2017-01-01' AS Date), 1)
GO
INSERT [dbo].[T_Message] ([id], [content], [id_sender], [id_receiver], [date], [isSeen]) VALUES (2, N'Salut � toi l''ami :)', 2, 9, CAST(N'2017-02-02' AS Date), 1)
GO
INSERT [dbo].[T_Message] ([id], [content], [id_sender], [id_receiver], [date], [isSeen]) VALUES (3, N'wow !', 9, 2, CAST(N'2017-07-04' AS Date), 0)
GO
INSERT [dbo].[T_Message] ([id], [content], [id_sender], [id_receiver], [date], [isSeen]) VALUES (4, N'bjr', 8, 5, CAST(N'2017-07-04' AS Date), 1)
GO
INSERT [dbo].[T_Message] ([id], [content], [id_sender], [id_receiver], [date], [isSeen]) VALUES (5, N'ah enchant� !', 5, 8, CAST(N'2017-07-04' AS Date), 1)
GO
INSERT [dbo].[T_Message] ([id], [content], [id_sender], [id_receiver], [date], [isSeen]) VALUES (6, N'comment allez vous ?', 5, 8, CAST(N'2017-07-04' AS Date), 1)
GO
INSERT [dbo].[T_Message] ([id], [content], [id_sender], [id_receiver], [date], [isSeen]) VALUES (7, N'bien merci et vous ?', 8, 5, CAST(N'2017-07-04' AS Date), 1)
GO
INSERT [dbo].[T_Message] ([id], [content], [id_sender], [id_receiver], [date], [isSeen]) VALUES (8, N'salut!', 10, 3, CAST(N'2017-07-04' AS Date), 0)
GO
SET IDENTITY_INSERT [dbo].[T_Message] OFF
GO
