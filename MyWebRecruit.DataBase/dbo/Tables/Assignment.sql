CREATE TABLE [dbo].[Assignment] (
    [ASSIG_ID]     INT            NOT NULL,
    [START_DT]     DATE           NOT NULL,
    [END_DT]       DATE           NULL,
    [SALARY]       MONEY          NOT NULL,
    [ASSIG_TYPE]   INT            NOT NULL,
    [JOB_NAME]     NVARCHAR (50)  NOT NULL,
    [REASON_LEAVE] NVARCHAR (100) NULL,
    [CAND_ID]      INT            NOT NULL,
    [JOB_ID]       INT            NOT NULL,
    [IS_DELETED] BIT NOT NULL, 
    CONSTRAINT [PK_Assignment] PRIMARY KEY CLUSTERED ([ASSIG_ID] ASC),
    CONSTRAINT [FK_Assignment_Assig_Type] FOREIGN KEY ([ASSIG_TYPE]) REFERENCES [dbo].[Assig_Type] ([ASSIG_TYPE_ID]),
    CONSTRAINT [FK_Assignment_Candidate] FOREIGN KEY ([CAND_ID]) REFERENCES [dbo].[Candidate] ([CANDIDATE_ID]),
    CONSTRAINT [FK_Assignment_Job_General] FOREIGN KEY ([JOB_ID]) REFERENCES [dbo].[Job_General] ([JOB_ID])
);

