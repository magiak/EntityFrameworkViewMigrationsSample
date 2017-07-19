MERGE INTO [dbo].[TableSamples] AS Target 
USING (VALUES
	(1, N'Description 1'),
	(2, N'Description 2'),
	(3, N'Description 3')
) 
AS Source ([Id], [Description]) 
ON Target.[Id] = Source.[Id]
-- update matched rows 
WHEN MATCHED THEN 
	UPDATE SET [Description] = Source.[Description]

-- insert new rows 
WHEN NOT MATCHED BY TARGET THEN 
	INSERT ([Description]) VALUES ([Description]) 

-- delete rows that are in the target but not the source 
WHEN NOT MATCHED BY SOURCE THEN 
	DELETE;
print '[dbo].[TableSamples] merged'
GO