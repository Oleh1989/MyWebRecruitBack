﻿CREATE TABLE [dbo].[Client] (
    [CLIENT_ID]     INT            NOT NULL,
    [NAME]          NVARCHAR (50)  NOT NULL,
    [WEB_SITE]      NVARCHAR (200) NULL,
    [ADDRESS_LINE]  NVARCHAR (200) NULL,
    [ADDRESS_CITY]  NVARCHAR (50)  NULL,
    [ADDRESS_INDEX] NCHAR (10)     NULL,
    [COUNTRY]       INT            NULL,
    [TEL_NO]        NVARCHAR (20)  NOT NULL,
    [CREATED_BY]    INT            NOT NULL,
    CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED ([CLIENT_ID] ASC),
    CONSTRAINT [FK_Client_Country] FOREIGN KEY ([COUNTRY]) REFERENCES [dbo].[Country] ([COUNTRY_ID]),
    CONSTRAINT [FK_Client_User] FOREIGN KEY ([CREATED_BY]) REFERENCES [dbo].[User] ([USER_ID])
);
