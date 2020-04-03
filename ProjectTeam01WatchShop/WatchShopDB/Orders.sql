CREATE TABLE [dbo].[Orders]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Quantity] INT NOT NULL DEFAULT 0, 
    [TransactionId] INT NOT NULL, 
    [SalerId] INT NOT NULL, 
    [ProductId] INT NOT NULL, 
    CONSTRAINT [FK_Orders_Employee] FOREIGN KEY ([SalerId]) REFERENCES [Employees]([Id]), 
    CONSTRAINT [FK_Orders_Products] FOREIGN KEY ([ProductId]) REFERENCES [Products]([Id]), 
    CONSTRAINT [FK_Orders_Transactions] FOREIGN KEY ([TransactionId]) REFERENCES [Transactions]([Id])
)
