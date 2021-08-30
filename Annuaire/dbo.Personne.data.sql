SET IDENTITY_INSERT [dbo].[Personne] ON
INSERT INTO [dbo].[Personne] ([Id], [first], [date], [phone], [service], [last], [age], [title], [email]) VALUES (1, N'Test', N'2020-01-01 00:00:00', N'06.20.45.89.75', N'Compta', N'Test', 0, NULL, NULL)
INSERT INTO [dbo].[Personne] ([Id], [first], [date], [phone], [service], [last], [age], [title], [email]) VALUES (2, N'Test2', N'2020-01-02 00:00:00', N'06.25.89.45.12', N'Direction', N'Test2 ', 0, NULL, NULL)
INSERT INTO [dbo].[Personne] ([Id], [first], [date], [phone], [service], [last], [age], [title], [email]) VALUES (3, N'Test3', N'2020-01-03 00:00:00', N'06.47.85.35.69', N'Info', N'Test3', 0, NULL, NULL)
INSERT INTO [dbo].[Personne] ([Id], [first], [date], [phone], [service], [last], [age], [title], [email]) VALUES (4, N'Test4', N'0202-01-04 00:00:00', N'06.32.59.84.15', N'Info', N'Test4', 0, NULL, NULL)
INSERT INTO [dbo].[Personne] ([Id], [first], [date], [phone], [service], [last], [age], [title], [email]) VALUES (6, NULL, N'0001-01-01 00:00:00', NULL, NULL, NULL, 0, NULL, NULL)
INSERT INTO [dbo].[Personne] ([Id], [first], [date], [phone], [service], [last], [age], [title], [email]) VALUES (7, NULL, N'0001-01-01 00:00:00', NULL, NULL, NULL, 0, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Personne] OFF
