CREATE TABLE [dbo].[Transactions]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EmpCashierID] INT NULL, 
    [ProductTotal] DECIMAL NOT NULL, 
    [TaxAmount] DECIMAL NOT NULL, 
    [OverallTotal] DECIMAL NOT NULL, 
    [CustomerEmail] VARCHAR(50) NULL, 
    [TotalQuantity] INT NOT NULL, 
    CONSTRAINT [FK_Transactions_Employee] FOREIGN KEY ([EmpCashierID]) REFERENCES [Employees]([Id])
)
