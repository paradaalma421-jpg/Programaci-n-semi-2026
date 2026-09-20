 CREATE TABLE [dbo].[Alumnos] (
    [idAlumno ] INT        NOT NULL,
    [codigo ]   CHAR (10)  NOT NULL,
    [nombre ]   CHAR (75)  NOT NULL,
    [dirección] CHAR (150) NULL,
    [telefono ] CHAR (9)   NULL,
    [email ]    CHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([idAlumno ]
     
);    
       
