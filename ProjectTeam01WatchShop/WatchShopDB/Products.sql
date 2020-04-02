CREATE TABLE [dbo].[Products]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Brand] VARCHAR(50) NOT NULL, 
    [Description] VARCHAR(50) NULL, 
    [Quantity] INT NULL, 
    [Price] DECIMAL NULL, 
    [Image] VARCHAR(50) NULL
)
