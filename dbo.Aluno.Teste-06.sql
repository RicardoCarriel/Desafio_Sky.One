USE [Desafio_Sky.One]
GO

/****** Object: Table [dbo].[Aluno] Script Date: 12/07/2023 18:00:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Aluno] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [Nome]          NCHAR (40)     NOT NULL,
    [Nota1]         DECIMAL (4, 2) NOT NULL,
    [Nota2]         DECIMAL (4, 2) NOT NULL,
    [AnoLancamento] INT            NOT NULL
);


