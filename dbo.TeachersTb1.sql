CREATE TABLE [dbo].[TeachersTb1] (
    [TId]    INT          IDENTITY (1, 1) NOT NULL,
    [Tname]  VARCHAR (50) NOT NULL,
    [TGen]   VARCHAR (50) NOT NULL,
    [TPhone] VARCHAR (50) NOT NULL,
    [TSub]   VARCHAR (50) NOT NULL,
    [TAdd]   VARCHAR (50) NOT NULL,
    [TDOB]   DATE         NOT NULL,
    PRIMARY KEY CLUSTERED ([TId] ASC)
);

