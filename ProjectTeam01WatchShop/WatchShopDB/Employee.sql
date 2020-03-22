CREATE TABLE [dbo].[Employee]
(
	[EmpId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EmpName] VARCHAR(50) NULL, 
    [EmpAddress] VARCHAR(100) NULL, 
    [Password] VARCHAR(50) NOT NULL, 
    [RoleID] INT NULL, 
    [PhoneNo] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(50) NULL, 
    [isActive] VARCHAR(10) NULL, 
    CONSTRAINT [FK_Employee_Role] FOREIGN KEY ([RoleID]) REFERENCES [MasterRole]([RoleID])
)
