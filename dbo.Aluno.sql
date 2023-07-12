CREATE TABLE [dbo].[Aluno] (
    [Id]            INT            NOT NULL,
    [Nome]          NCHAR (100)    NOT NULL,
    [Nota1]         DECIMAL (4, 2) NOT NULL,
    [Nota2]         DECIMAL (4, 2) NOT NULL,
    [AnoLancamento] INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

