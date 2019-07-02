CREATE TABLE [dbo].[Job_Financial] (
    [JOB_ID]       INT           NOT NULL,
    [JOB_CURRENCY] NCHAR (10)    NULL,
    [JOB_STATUS]   NVARCHAR (50) NULL,
    [START_DT]     DATE          NULL,
    [END_DT]       DATE          NULL,
    [NO_REQ]       SMALLINT      NOT NULL,
    [CATEGORY]     NVARCHAR (50) NOT NULL,
    [SALARY]       MONEY         NULL,
    [INTERSHIP_YN] TINYINT       NULL,
    [PAY_METHOD]   INT           NULL,
    CONSTRAINT [PK_Job_Financial] PRIMARY KEY CLUSTERED ([JOB_ID] ASC),
    CONSTRAINT [FK_Job_Financial_Job_General] FOREIGN KEY ([JOB_ID]) REFERENCES [dbo].[Job_General] ([JOB_ID]),
    CONSTRAINT [FK_Job_Financial_Pay_Method] FOREIGN KEY ([PAY_METHOD]) REFERENCES [dbo].[Pay_Method] ([PAY_METHOD_ID])
);

