CREATE TABLE [dbo].[TableSamples] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Description] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.TableSamples] PRIMARY KEY CLUSTERED ([Id] ASC)
);

