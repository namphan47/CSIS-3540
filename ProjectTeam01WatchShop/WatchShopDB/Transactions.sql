CREATE TABLE [dbo].[Transactions]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EmpCashierID] INT NULL,     
    [CustomerEmail] VARCHAR(50) NULL, 
    [SubTotal] DECIMAL NOT NULL, 
    [TaxAmount] DECIMAL NOT NULL, 
    [TotalAmount] DECIMAL NOT NULL, 
    CONSTRAINT [FK_Transactions_Employee] FOREIGN KEY ([EmpCashierID]) REFERENCES [Employees]([Id])
)
