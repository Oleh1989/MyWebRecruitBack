﻿CREATE TABLE [dbo].[Job_General] (
    [JOB_ID]        INT            NOT NULL,
    [NAME]          NVARCHAR (100) NOT NULL,
    [ADDRESS_LINE]  NVARCHAR (100) NULL,
    [ADDRESS_CITY]  NVARCHAR (100) NULL,
    [ADDRESS_INDEX] NVARCHAR (10)  NULL,
    [COUNTRY]       INT            NULL,
    CONSTRAINT [PK_Job_General] PRIMARY KEY CLUSTERED ([JOB_ID] ASC),
    CONSTRAINT [FK_Job_General_Country] FOREIGN KEY ([COUNTRY]) REFERENCES [dbo].[Country] ([COUNTRY_ID])
);

