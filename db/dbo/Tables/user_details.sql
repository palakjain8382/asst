﻿CREATE TABLE [dbo].[user_details] (
    [UserID]       INT        NOT NULL,
    [FirstName]    NCHAR (50) NULL,
    [LastName]     NCHAR (50) NULL,
    [DOB]          DATE       NULL,
    [Gender]       NCHAR (50) NULL,
    [EmailAddress] NCHAR (50) NULL,
    CONSTRAINT [PK_user_details] PRIMARY KEY CLUSTERED ([UserID] ASC)
);

