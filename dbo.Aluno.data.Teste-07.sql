SET IDENTITY_INSERT [dbo].[Aluno] ON
INSERT INTO [dbo].[Aluno] ([Id], [Nome], [Nota1], [Nota2], [AnoLancamento]) VALUES (1, N'João', CAST(5.00 AS Decimal(4, 2)), CAST(10.00 AS Decimal(4, 2)), 2022)
INSERT INTO [dbo].[Aluno] ([Id], [Nome], [Nota1], [Nota2], [AnoLancamento]) VALUES (2, N'João', CAST(7.00 AS Decimal(4, 2)), CAST(5.00 AS Decimal(4, 2)), 2023)
INSERT INTO [dbo].[Aluno] ([Id], [Nome], [Nota1], [Nota2], [AnoLancamento]) VALUES (3, N'Carlos', CAST(3.00 AS Decimal(4, 2)), CAST(7.00 AS Decimal(4, 2)), 2022)
INSERT INTO [dbo].[Aluno] ([Id], [Nome], [Nota1], [Nota2], [AnoLancamento]) VALUES (4, N'João', CAST(2.00 AS Decimal(4, 2)), CAST(10.00 AS Decimal(4, 2)), 2023)
INSERT INTO [dbo].[Aluno] ([Id], [Nome], [Nota1], [Nota2], [AnoLancamento]) VALUES (5, N'Vinicius', CAST(4.50 AS Decimal(4, 2)), CAST(6.00 AS Decimal(4, 2)), 2022)
INSERT INTO [dbo].[Aluno] ([Id], [Nome], [Nota1], [Nota2], [AnoLancamento]) VALUES (6, N'Vinicius', CAST(3.10 AS Decimal(4, 2)), CAST(7.70 AS Decimal(4, 2)), 2022)
SET IDENTITY_INSERT [dbo].[Aluno] OFF
