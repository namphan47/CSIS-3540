CREATE TABLE [dbo].[Orders]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TransactionId] INT NOT NULL, 
    [EmpId] INT NOT NULL, 
    [ProductId] INT NOT NULL, 
    CONSTRAINT [FK_Orders_Employee] FOREIGN KEY ([EmpId]) REFERENCES [Employees]([Id]), 
    CONSTRAINT [FK_Orders_Products] FOREIGN KEY ([ProductId]) REFERENCES [Products]([Id]), 
    CONSTRAINT [FK_Orders_Transactions] FOREIGN KEY ([TransactionId]) REFERENCES [Transactions]([Id])
)
