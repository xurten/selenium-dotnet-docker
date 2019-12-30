CREATE TABLE [dbo].[LogInformation] (
    [Id]         INT        IDENTITY (1, 1) NOT NULL,
    [LogDetails] NCHAR (200) NULL,
    [LogDate]    DATETIME   NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

