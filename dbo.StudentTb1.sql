CREATE TABLE [dbo].[StudentTb1] (
    [StId]    INT          IDENTITY (1, 1) NOT NULL,
    [StName]  VARCHAR (50) NOT NULL,
    [StGen]   VARCHAR (10) NOT NULL,
    [StDOB]   DATE         NOT NULL,
    [StClass] VARCHAR (10) NOT NULL,
    [StFees]  INT          NOT NULL,
    [StAdd]   VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([StId] ASC)
);

