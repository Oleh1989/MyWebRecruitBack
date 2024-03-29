﻿CREATE TABLE [dbo].[CV] (
    [CV_ID]   INT            NOT NULL,
    [CV_LINK] NVARCHAR (250) NOT NULL,
    [CAND_ID] INT            NOT NULL,
    CONSTRAINT [PK_CV] PRIMARY KEY CLUSTERED ([CV_ID] ASC),
    CONSTRAINT [FK_CV_Candidate] FOREIGN KEY ([CAND_ID]) REFERENCES [dbo].[Candidate] ([CANDIDATE_ID])
);

