CREATE TABLE [dbo].[Orders]
(
	[OrdersID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TransactionID] INT NOT NULL, 
    [EmpID] INT NOT NULL, 
    [ProductID] INT NOT NULL, 
    CONSTRAINT [FK_Orders_Employee] FOREIGN KEY ([EmpID]) REFERENCES [Employee]([EmpID]), 
    CONSTRAINT [FK_Orders_Products] FOREIGN KEY ([ProductID]) REFERENCES [Products]([ProductID]), 
    CONSTRAINT [FK_Orders_Transactions] FOREIGN KEY ([TransactionID]) REFERENCES [Transactions]([TransactionID])
)
