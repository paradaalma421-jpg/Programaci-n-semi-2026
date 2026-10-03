CREATE TABLE [dbo].[matricula] (
    [idMatricula] INT       NOT NULL,
    [idAlumno ]   INT       NOT NULL,
    [fecha]       DATE      NULL,
    [periodo ]    CHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([idMatricula] ASC)


);CREATE TABLE [dbo].[materias] (
    [idmateria ] INT        NOT NULL,
    [codigo ]    SMALLINT   NOT NULL,
    [nombre]     CHAR (100) NOT NULL,
    [uv]         SMALLINT   NOT NULL,
    PRIMARY KEY CLUSTERED ([idmateria ] ASC)


);CREATE TABLE [dbo].[Alumnos] (
    [idAlumno ] INT        NOT NULL,
    [codigo ]   CHAR (10)  NOT NULL,
    [nombre ]   CHAR (75)  NOT NULL,
    [dirección] CHAR (150) NULL,
    [telefono ] CHAR (9)   NULL,
    [email ]    CHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([idAlumno ] ASC)
);
