/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
use WatchShopDB;

GO

INSERT INTO Roles([Type]) VALUES('Admin');
INSERT INTO Roles([Type]) VALUES('Saler');
INSERT INTO Roles([Type]) VALUES('Manager');

GO

INSERT INTO Products([Brand],[Description],[Quantity],[Price]) VALUES('b','adf',33,334.3);
INSERT INTO Products([Brand],[Description],[Quantity],[Price]) VALUES('c','gfdf',333,3.3);

GO
/*
INSERT INTO Employees([Name], [RoleId]) VALUES('Nam',2);

go*/
GO
