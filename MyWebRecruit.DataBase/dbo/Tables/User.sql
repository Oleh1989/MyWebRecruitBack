﻿CREATE TABLE [dbo].[User] (
    [USER_ID]     INT            NOT NULL,
    [USER_NAME]   NVARCHAR (16)  NOT NULL,
    [USER_EMAIL]  NVARCHAR (255) NOT NULL,
    [PASSWORD]    NVARCHAR (50)  NOT NULL,
    [CREATE_TIME] DATETIME       NOT NULL,
    [ADMIN_YN]    TINYINT        NOT NULL,
    [IS_DELETED] BIT NOT NULL, 
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([USER_ID] ASC)
);

