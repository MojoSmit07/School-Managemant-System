CREATE TABLE [dbo].[FeesTb1] (
    [payId]  INT          IDENTITY (1, 1) NOT NULL,
    [StId]   INT          NOT NULL,
    [StName] VARCHAR (50) NOT NULL,
    [Month]  VARCHAR (50) NOT NULL,
    [Amt]    INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([payId] ASC)
);

