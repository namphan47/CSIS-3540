CREATE TABLE [dbo].[Products]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Brand] VARCHAR(50) NOT NULL, 
    [Description] VARCHAR(50) NULL, 
    [Quantity] INT NOT NULL DEFAULT 0, 
    [Price] DECIMAL NOT NULL DEFAULT 0, 
    [Image] VARCHAR(50) NULL
)
