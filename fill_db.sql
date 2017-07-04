USE [MeditateBook]
GO
SET IDENTITY_INSERT [dbo].[T_User] ON 

INSERT [dbo].[T_User] ([id], [email], [password], [firstname], [lastname], [role]) VALUES (2, N'admin@admin.com', N'AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAANLk5gLCqV0qduukP0eIUGgAAAAACAAAAAAAQZgAAAAEAACAAAAD28k++s6vkinAYfOFCSZJhAk4M38XUcsyo35lamPs/JwAAAAAOgAAAAAIAACAAAADccXl9nXUAs1mx7Zi14dsuVoTB2sD+rjP0qC8ubmSSNBAAAABPcEbiLt4oev/Gq56vkVULQAAAALSPCTyr2OsVgG2n21fMHWpArDdcGkC/+E3DTKI28DefRODf21taqvWz2aGUDCkPAoSkV88eAC/EgmHVtJ9KvOA=', N'Admin', N'Admin', 3)
INSERT [dbo].[T_User] ([id], [email], [password], [firstname], [lastname], [role]) VALUES (3, N'admin1@admin.com', N'AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAANLk5gLCqV0qduukP0eIUGgAAAAACAAAAAAAQZgAAAAEAACAAAADGLLf1pru+4SQGul2BH4mAew8/UTKYPFoMZLCt7OPCXwAAAAAOgAAAAAIAACAAAAB9bwPCW4ObfeHbJX6tRjW33izDEawNOJlgZaiZhxInHBAAAABZZ3cupTxKw5Pwv9MNh31yQAAAAHJMZ08FCGtvIjBah2zgDUfDwrIp41IhHRrEpr5c9eyyNI3pMqCPVv3fXjSN5SyJ8xIAyt70cpwu9SNznVneHCg=', N'Admin', N'Admin', 2)
INSERT [dbo].[T_User] ([id], [email], [password], [firstname], [lastname], [role]) VALUES (4, N'admin2@admin.com', N'AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAANLk5gLCqV0qduukP0eIUGgAAAAACAAAAAAAQZgAAAAEAACAAAACPMBowETFgkgi4TQLhuM9rocb60UiY34xpJld4hoIe+gAAAAAOgAAAAAIAACAAAAANkfIoVF6lSLhbv2pY0wJm1s3sjD7MwgeunuaQeFkKQhAAAADDDY/z1jElSKHB/ITwimntQAAAAAbXw77k7g0a7o21dezHZD7Kr8j5YiiJD1A0yYJoA9RUEh9RSULrLre+amzuk4wZjhxBYD07C4xYENtvjL/Jqho=', N'Admin', N'Admin', 2)
INSERT [dbo].[T_User] ([id], [email], [password], [firstname], [lastname], [role]) VALUES (5, N'translator1@translate.com', N'AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAANLk5gLCqV0qduukP0eIUGgAAAAACAAAAAAAQZgAAAAEAACAAAAAMyPgK/ehUEOPR6fsvrMfipo+t9lG89xIoTjRup9oLnwAAAAAOgAAAAAIAACAAAAD7ltJOHDDQSBZpBR+8dAY/sKR61JOiKGIq+L0wSS9aOyAAAAABsZHI3/dMFw0Iz924E8XRb/lSKYvgjYnPsp+9sstsuEAAAABI3RJ2UyEQnPNUHFrSXhOHqBWaMNtQODqHCFUck6Z4RkAs0cG4LGo+3qwzvRSfy/wzFz4l0g9LuHi829bxm949', N'Eric', N'Judor', 1)
INSERT [dbo].[T_User] ([id], [email], [password], [firstname], [lastname], [role]) VALUES (6, N'translator2@translate.com', N'AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAANLk5gLCqV0qduukP0eIUGgAAAAACAAAAAAAQZgAAAAEAACAAAABlApLB8mQGQ/XtWFta7PyLZCt4AL92vuOE76JziCvc/gAAAAAOgAAAAAIAACAAAAD5VpNX2/yehxD5WHvV5RfQxbHpk9xFoplzunrwZKYnrSAAAADV9bILOqdl+A0T7RtDSrQMpxJKSE48ATRAD2iTdD9oS0AAAAAJ+oBeGE50F01zgie/XaI6ZfglhYIAEmCpSg4VTKz6iZx0JgjGLPRPcZM6syRlS2azoM/yG3NkQsoCcYqpbKan', N'Ramzy', N'Rebeu', 1)
INSERT [dbo].[T_User] ([id], [email], [password], [firstname], [lastname], [role]) VALUES (8, N'user1@user.com', N'AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAANLk5gLCqV0qduukP0eIUGgAAAAACAAAAAAAQZgAAAAEAACAAAABvLn9dg29vcbec2sI54n73fNvLHRZt1P2fTGML+BcoTAAAAAAOgAAAAAIAACAAAAB0TBG4X4ZiPF9hB8PqFJl20ZSKAeFIf8hrO9jrg181shAAAAAMqfg2rbFjX4JjGWgZ0DMjQAAAAJE8B/QbHNnlih6KMlnM0DwohOKSNcfUy/oZxLAVluU7vRxjwtpmsjNbfvpSEImkwtSEPeOrEniLzIsdgcczYdI=', N'Alexandre', N'Alves', 0)
INSERT [dbo].[T_User] ([id], [email], [password], [firstname], [lastname], [role]) VALUES (9, N'user2@user.com', N'AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAANLk5gLCqV0qduukP0eIUGgAAAAACAAAAAAAQZgAAAAEAACAAAABICGUD5VaI9NP9tZGpWPa0IdOnIatuMs2iUZp3qwL4LwAAAAAOgAAAAAIAACAAAAAmCE7Zn8ItzVaaWNdOarY0O+cx7fyVx2FjMroE7RqfXhAAAACmm0TKWkfNMvoKXKlpwsWFQAAAABC7B/RBayCZiuEhXfUAfNDt52qd+gFmCn7JA0+J0HhFaTmbbYQ/nhy2EceoEGVu3dqlamPe3/SV69WlpUTxEq4=', N'Alexandre', N'Touzet', 0)
SET IDENTITY_INSERT [dbo].[T_User] OFF
SET IDENTITY_INSERT [dbo].[T_Article] ON 

INSERT [dbo].[T_Article] ([id], [title], [content], [id_creator], [created_date], [validated]) VALUES (1, N'Article n°1', N'<p>Bonjour,</p>

<p>&nbsp;</p>

<p>ceci est le <strong>premier</strong> article !</p>
', 3, CAST(N'2017-07-04' AS Date), 0)
INSERT [dbo].[T_Article] ([id], [title], [content], [id_creator], [created_date], [validated]) VALUES (2, N'Article 2', N'<p>Yo,</p>

<p>&nbsp;</p>

<p>second <em>article</em> ?</p>
', 2, CAST(N'2017-07-04' AS Date), 0)
INSERT [dbo].[T_Article] ([id], [title], [content], [id_creator], [created_date], [validated]) VALUES (3, N'Test d''image', N'<p>salut une image de dab</p>
', 2, CAST(N'2017-07-04' AS Date), 0)
INSERT [dbo].[T_Article] ([id], [title], [content], [id_creator], [created_date], [validated]) VALUES (4, N'Test image 2', N'<p>l&#39;image de dab &ccedil;a repart</p>
', 2, CAST(N'2017-07-04' AS Date), 0)
SET IDENTITY_INSERT [dbo].[T_Article] OFF
SET IDENTITY_INSERT [dbo].[T_Article_Image] ON 

INSERT [dbo].[T_Article_Image] ([id], [id_article], [image_path], [name]) VALUES (1, 4, N'C:\Users\Yassine\Documents\Cours\MTI\Dot Net\MeditateBook\MeditateBook\images\article\flat,800x800,075,t.u1.jpg', N'flat,800x800,075,t.u1.jpg')
SET IDENTITY_INSERT [dbo].[T_Article_Image] OFF
SET IDENTITY_INSERT [dbo].[T_Language] ON 

INSERT [dbo].[T_Language] ([id], [name], [shortname]) VALUES (1, N'English', N'en-us')
SET IDENTITY_INSERT [dbo].[T_Language] OFF
SET IDENTITY_INSERT [dbo].[T_Translation] ON 

INSERT [dbo].[T_Translation] ([id], [content], [id_language], [id_article], [id_translator], [validated]) VALUES (1, N'<p>Hello,</p>

<p>&nbsp;</p>

<p>this is the&nbsp;<strong>first</strong>&nbsp;article !</p>
', 1, 1, 2, 1)
INSERT [dbo].[T_Translation] ([id], [content], [id_language], [id_article], [id_translator], [validated]) VALUES (2, N'<p>Hello,</p>

<p>&nbsp;</p>

<p>second&nbsp;<em>article</em>&nbsp;?</p>
', 1, 2, 2, 1)
SET IDENTITY_INSERT [dbo].[T_Translation] OFF
SET IDENTITY_INSERT [dbo].[T_Message] ON 

INSERT [dbo].[T_Message] ([id], [content], [id_sender], [id_receiver], [date], [isSeen]) VALUES (1, N'Bonjour l''admin !', 9, 2, CAST(N'2017-01-01' AS Date), 1)
INSERT [dbo].[T_Message] ([id], [content], [id_sender], [id_receiver], [date], [isSeen]) VALUES (2, N'Salut à toi l''ami :)', 2, 9, CAST(N'2017-02-02' AS Date), 1)
INSERT [dbo].[T_Message] ([id], [content], [id_sender], [id_receiver], [date], [isSeen]) VALUES (3, N'wow !', 9, 2, CAST(N'2017-07-04' AS Date), 0)
INSERT [dbo].[T_Message] ([id], [content], [id_sender], [id_receiver], [date], [isSeen]) VALUES (4, N'bjr', 8, 5, CAST(N'2017-07-04' AS Date), 1)
INSERT [dbo].[T_Message] ([id], [content], [id_sender], [id_receiver], [date], [isSeen]) VALUES (5, N'ah enchanté !', 5, 8, CAST(N'2017-07-04' AS Date), 1)
INSERT [dbo].[T_Message] ([id], [content], [id_sender], [id_receiver], [date], [isSeen]) VALUES (6, N'comment allez vous ?', 5, 8, CAST(N'2017-07-04' AS Date), 1)
INSERT [dbo].[T_Message] ([id], [content], [id_sender], [id_receiver], [date], [isSeen]) VALUES (7, N'bien merci et vous ?', 8, 5, CAST(N'2017-07-04' AS Date), 1)
SET IDENTITY_INSERT [dbo].[T_Message] OFF
