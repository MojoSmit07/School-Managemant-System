CREATE TABLE [dbo].[EventsTb1] (
    [EId]       INT          IDENTITY (1, 1) NOT NULL,
    [EDesc]     VARCHAR (50) NOT NULL,
    [EDate]     DATE         NOT NULL,
    [EDuration] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([EId] ASC)
);

