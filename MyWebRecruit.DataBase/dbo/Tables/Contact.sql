﻿CREATE TABLE [dbo].[Contact] (
    [CONTACT_ID] INT            NOT NULL,
    [FIRST_NAME] NVARCHAR (50)  NOT NULL,
    [LAST_NAME]  NVARCHAR (50)  NOT NULL,
    [TEL_NO]     NVARCHAR (20)  NOT NULL,
    [EMAIL]      NVARCHAR (255) NOT NULL,
    [DISTURB_YN] TINYINT        NULL,
    [DEPARTMENT] NVARCHAR (100) NULL,
    [JOB_TITLE]  NVARCHAR (100) NULL,
    CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED ([CONTACT_ID] ASC)
);

