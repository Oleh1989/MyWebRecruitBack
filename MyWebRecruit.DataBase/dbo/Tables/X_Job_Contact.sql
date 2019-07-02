CREATE TABLE [dbo].[X_Job_Contact] (
    [UNIQUE_ID]  INT NOT NULL,
    [JOB_ID]     INT NOT NULL,
    [CONTACT_ID] INT NOT NULL,
    CONSTRAINT [PK_X_Job_Contact] PRIMARY KEY CLUSTERED ([UNIQUE_ID] ASC),
    CONSTRAINT [FK_X_Job_Contact_Contact] FOREIGN KEY ([CONTACT_ID]) REFERENCES [dbo].[Contact] ([CONTACT_ID]),
    CONSTRAINT [FK_X_Job_Contact_Job_General] FOREIGN KEY ([JOB_ID]) REFERENCES [dbo].[Job_General] ([JOB_ID])
);

