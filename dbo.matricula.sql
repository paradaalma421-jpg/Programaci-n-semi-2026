CREATE TABLE [dbo].[matricula] (
    [idMatricula] INT       NOT NULL,
    [idAlumno ]   INT       NOT NULL,
    [fecha]       DATE      NULL,
    [periodo ]    CHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([idMatricula] ASC)
);



