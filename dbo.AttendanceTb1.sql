CREATE TABLE [dbo].[AttendanceTb1] (
    [AttNum]    INT          IDENTITY (1, 1) NOT NULL,
    [AttStId]   INT          NOT NULL,
    [AttStname] VARCHAR (50) NOT NULL,
    [AttDate]   DATE         NOT NULL,
    [AttStatus] VARCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([AttNum] ASC)
);

