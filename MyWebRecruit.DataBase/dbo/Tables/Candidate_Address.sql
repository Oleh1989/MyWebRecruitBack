CREATE TABLE [dbo].[Candidate_Address] (
    [CANDIDATE_ID]  INT            NOT NULL,
    [ADDRESS_LINE]  NVARCHAR (100) NULL,
    [ADDRESS_CITY]  NVARCHAR (20)  NULL,
    [ADDRESS_INDEX] NCHAR (10)     NULL,
    [COUNTRY_ID]    INT            NULL,
    CONSTRAINT [PK_Candidate_Address] PRIMARY KEY CLUSTERED ([CANDIDATE_ID] ASC),
    CONSTRAINT [FK_Candidate_Address_Country] FOREIGN KEY ([COUNTRY_ID]) REFERENCES [dbo].[Country] ([COUNTRY_ID])
);

