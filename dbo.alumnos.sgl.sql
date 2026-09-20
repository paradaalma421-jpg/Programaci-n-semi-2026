CREATE TABLE [dbo].[matriculas] (
    [idMatriula ] INT       NOT NULL,
    [idAlumno]    INT       NOT NULL,
    [fecha ]      DATE      NOT NULL,
    [periodo ]    CHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([idMatriula ] ASC)
);  

