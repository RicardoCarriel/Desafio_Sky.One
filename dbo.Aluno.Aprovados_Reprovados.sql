USE [Desafio_Sky.One]
GO

SELECT
    Nome,
    Nota1,
    Nota2,
    AnoLancamento,
    (Nota1 + Nota2) / 2 AS MediaAnual,
    CASE
        WHEN (Nota1 + Nota2) / 2 < 6.5 THEN 'Reprovado'
        ELSE 'Aprovado'
    END AS Status
FROM Aluno;

