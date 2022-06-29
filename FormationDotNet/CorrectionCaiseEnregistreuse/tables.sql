CREATE TABLE [dbo].[product]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [title] VARCHAR(100) NULL, 
    [price] DECIMAL NULL, 
    [stock] INT NULL
)
