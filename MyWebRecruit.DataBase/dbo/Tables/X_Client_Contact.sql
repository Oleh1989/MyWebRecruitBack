﻿CREATE TABLE [dbo].[X_Client_Contact] (
    [UNIQUE_ID]  INT NOT NULL,
    [CLIENT_ID]  INT NOT NULL,
    [CONTACT_ID] INT NOT NULL,
    CONSTRAINT [PK_X_Client_Contact] PRIMARY KEY CLUSTERED ([UNIQUE_ID] ASC),
    CONSTRAINT [FK_X_Client_Contact_Client] FOREIGN KEY ([CLIENT_ID]) REFERENCES [dbo].[Client] ([CLIENT_ID]),
    CONSTRAINT [FK_X_Client_Contact_Contact] FOREIGN KEY ([CONTACT_ID]) REFERENCES [dbo].[Contact] ([CONTACT_ID])
);

