CREATE TABLE [dbo].[Employees]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NULL, 
    [Address] VARCHAR(100) NULL, 
    [Password] VARCHAR(50) NOT NULL, 
    [RoleId] INT NULL, 
    [PhoneNo] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(50) NULL, 
    CONSTRAINT [FK_Employee_Role] FOREIGN KEY ([RoleId]) REFERENCES [Roles]([Id])
)
