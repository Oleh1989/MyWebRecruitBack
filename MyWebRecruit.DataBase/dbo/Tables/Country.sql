﻿CREATE TABLE [dbo].[Country] (
    [COUNTRY_ID]   INT           NOT NULL,
    [COUNTRY_NAME] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED ([COUNTRY_ID] ASC)
);

