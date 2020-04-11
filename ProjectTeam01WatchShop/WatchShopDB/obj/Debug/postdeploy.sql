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
INSERT INTO Roles([Type]) VALUES('Seller');
INSERT INTO Roles([Type]) VALUES('Manager');

GO





insert into Employees ( Name, Address, Password, RoleId, PhoneNo, Email) values ( 'Melinde Imlach', '24072 Oriole Drive', 'test', 1, '318-152-0302', 'mimlach0@about.com');
insert into Employees ( Name, Address, Password, RoleId, PhoneNo, Email) values ( 'Paxton Sprionghall', '00827 Russell Point', 'test', 3, '590-647-2676', 'psprionghall1@cornell.edu');
insert into Employees ( Name, Address, Password, RoleId, PhoneNo, Email) values ( 'Giorgi Peto', '7 Knutson Court', 'test', 2, '969-353-1977', 'gpeto2@hc360.com');
insert into Employees ( Name, Address, Password, RoleId, PhoneNo, Email) values ( 'Angelique Congreve', '0 Bartillon Place', 'test', 2, '689-353-5621', 'acongreve3@posterous.com');
insert into Employees ( Name, Address, Password, RoleId, PhoneNo, Email) values ( 'Saleem Ebbles', '7 Clarendon Street', 'test', 2, '581-395-5490', 'sebbles4@nytimes.com');
insert into Employees ( Name, Address, Password, RoleId, PhoneNo, Email) values ( 'Allys Welling', '226 Jenna Court', 'test', 2, '793-153-4083', 'awelling5@senate.gov');
insert into Employees ( Name, Address, Password, RoleId, PhoneNo, Email) values ( 'Wilek Shotton', '8934 Melrose Center', 'test', 2, '212-259-7437', 'wshotton6@histats.com');
insert into Employees ( Name, Address, Password, RoleId, PhoneNo, Email) values ( 'Mia Crawcour', '172 Marcy Pass', 'test', 2, '669-253-1414', 'mcrawcour7@xinhuanet.com');
insert into Employees ( Name, Address, Password, RoleId, PhoneNo, Email) values ( 'Nedi Jeaffreson', '384 Ridgeview Parkway', 'test', 2, '842-154-8980', 'njeaffreson8@indiatimes.com');
insert into Employees ( Name, Address, Password, RoleId, PhoneNo, Email) values ( 'Linzy Georgeot', '28981 Maple Plaza', 'test', 2, '693-892-0937', 'lgeorgeot9@ustream.tv');
insert into Employees ( Name, Address, Password, RoleId, PhoneNo, Email) values ( 'Ronak', '28981 Maple Plaza', 'test', 2, '693-892-0937', 'rony@test.com');
insert into Employees ( Name, Address, Password, RoleId, PhoneNo, Email) values ( 'Nam', '28981 Maple Plaza', 'test', 2, '693-892-0937', 'nam@te.com');

GO


insert into Products ( Brand, [Description], Quantity, Price) values ( 'Armani Exchange', 'Nulla mollis molestie lorem', 1000, 1773);
insert into Products ( Brand, [Description], Quantity, Price) values ( 'Emporio Armani', 'Nulla mollis molestie lorem', 1000, 1913);
insert into Products ( Brand, [Description], Quantity, Price) values ( 'Fossil', 'Donec semper sapien a libero', 1000, 2902);
insert into Products ( Brand, [Description], Quantity, Price) values ( 'Kate Spade', 'Donec semper sapien a libero', 1000, 1551);
insert into Products ( Brand, [Description], Quantity, Price) values ( 'Michael Kors', 'Nunc rhoncus dui vel sem', 1000, 1369);
insert into Products ( Brand, [Description], Quantity, Price) values ( 'Chaps', 'Donec semper sapien a libero', 1000, 2408);
insert into Products ( Brand, [Description], Quantity, Price) values ( 'FastTrack', 'Nunc rhoncus dui vel sem', 1000, 2811);
insert into Products ( Brand, [Description], Quantity, Price) values ( 'Movado', 'Nunc rhoncus dui vel sem', 1000, 2349);
insert into Products ( Brand, [Description], Quantity, Price) values ( 'Rado', 'Donec semper sapien a libero', 1000, 1839);
insert into Products ( Brand, [Description], Quantity, Price) values ( 'Zodiac', 'Nunc rhoncus dui vel sem', 1000, 1970);
insert into Products ( Brand, [Description], Quantity, Price) values ( 'Smart Watches', 'Nulla mollis molestie lorem', 2000, 5773);
insert into Products ( Brand, [Description], Quantity, Price) values ( 'Michelle', 'Nulla mollis molestie lorem', 1000, 7000);
insert into Products ( Brand, [Description], Quantity, Price) values ( 'Swiz Watch', 'Donec semper sapien a libero', 1000, 8000);
insert into Products ( Brand, [Description], Quantity, Price) values ( 'Titan', 'Donec semper sapien a libero', 1000, 1551);
insert into Products ( Brand, [Description], Quantity, Price) values ( 'WatchStation', 'Nunc rhoncus dui vel sem', 2000, 1000);
insert into Products ( Brand, [Description], Quantity, Price) values ( 'Rapido', 'Donec semper sapien a libero', 1000, 2408);
insert into Products ( Brand, [Description], Quantity, Price) values ( 'Puma', 'Nunc rhoncus dui vel sem', 2000, 2500);
insert into Products ( Brand, [Description], Quantity, Price) values ( 'Chopard', 'Nunc rhoncus dui vel sem', 1000, 3349);
insert into Products ( Brand, [Description], Quantity, Price) values ( 'Rolex', 'Donec semper sapien a libero', 1000, 9000);
insert into Products ( Brand, [Description], Quantity, Price) values ( 'Audemars', 'Nunc rhoncus dui vel sem', 1000, 1970);

GO

INSERT INTO [dbo].[Transactions] ( [EmpCashierID], [CustomerEmail], [SubTotal], [TaxAmount], [TotalAmount]) VALUES (11, N'cust1@gmail.com', CAST(1773 AS Decimal(18, 0)), CAST(177 AS Decimal(18, 0)), CAST(1950 AS Decimal(18, 0)))
INSERT INTO [dbo].[Transactions] ( [EmpCashierID], [CustomerEmail], [SubTotal], [TaxAmount], [TotalAmount]) VALUES ( 12, N'cust2@gmail.com', CAST(13909 AS Decimal(18, 0)), CAST(1391 AS Decimal(18, 0)), CAST(15300 AS Decimal(18, 0)))
INSERT INTO [dbo].[Transactions] ( [EmpCashierID], [CustomerEmail], [SubTotal], [TaxAmount], [TotalAmount]) VALUES ( 3, N'test@gmail.com', CAST(4051 AS Decimal(18, 0)), CAST(405 AS Decimal(18, 0)), CAST(4456 AS Decimal(18, 0)))
INSERT INTO [dbo].[Transactions] ( [EmpCashierID], [CustomerEmail], [SubTotal], [TaxAmount], [TotalAmount]) VALUES ( 11, N'abc@gmail.com', CAST(21765 AS Decimal(18, 0)), CAST(2177 AS Decimal(18, 0)), CAST(23942 AS Decimal(18, 0)))
INSERT INTO [dbo].[Transactions] ( [EmpCashierID], [CustomerEmail], [SubTotal], [TaxAmount], [TotalAmount]) VALUES ( 9, N'lmn@gmail.com', CAST(5773 AS Decimal(18, 0)), CAST(577 AS Decimal(18, 0)), CAST(6350 AS Decimal(18, 0)))
INSERT INTO [dbo].[Transactions] ( [EmpCashierID], [CustomerEmail], [SubTotal], [TaxAmount], [TotalAmount]) VALUES ( 2, N'oop@gmail.com', CAST(1970 AS Decimal(18, 0)), CAST(197 AS Decimal(18, 0)), CAST(2167 AS Decimal(18, 0)))
INSERT INTO [dbo].[Transactions] ( [EmpCashierID], [CustomerEmail], [SubTotal], [TaxAmount], [TotalAmount]) VALUES ( 12, N'mnb@gmail.com', CAST(9850 AS Decimal(18, 0)), CAST(985 AS Decimal(18, 0)), CAST(10835 AS Decimal(18, 0)))
INSERT INTO [dbo].[Transactions] ( [EmpCashierID], [CustomerEmail], [SubTotal], [TaxAmount], [TotalAmount]) VALUES ( 8, N'test@gmail.com', CAST(2811 AS Decimal(18, 0)), CAST(281 AS Decimal(18, 0)), CAST(3092 AS Decimal(18, 0)))
INSERT INTO [dbo].[Transactions] ( [EmpCashierID], [CustomerEmail], [SubTotal], [TaxAmount], [TotalAmount]) VALUES ( 7, N'jhg@gmail.com', CAST(2811 AS Decimal(18, 0)), CAST(281 AS Decimal(18, 0)), CAST(3092 AS Decimal(18, 0)))
INSERT INTO [dbo].[Transactions] ( [EmpCashierID], [CustomerEmail], [SubTotal], [TaxAmount], [TotalAmount]) VALUES ( 9, N'poi@gmail.com', CAST(9000 AS Decimal(18, 0)), CAST(900 AS Decimal(18, 0)), CAST(9900 AS Decimal(18, 0)))
INSERT INTO [dbo].[Transactions] ( [EmpCashierID], [CustomerEmail], [SubTotal], [TaxAmount], [TotalAmount]) VALUES ( 7, N'ppp@gmail.com', CAST(2349 AS Decimal(18, 0)), CAST(235 AS Decimal(18, 0)), CAST(2584 AS Decimal(18, 0)))
INSERT INTO [dbo].[Transactions] ( [EmpCashierID], [CustomerEmail], [SubTotal], [TaxAmount], [TotalAmount]) VALUES ( 10, N'kkk@gmail.com', CAST(18469 AS Decimal(18, 0)), CAST(1847 AS Decimal(18, 0)), CAST(20316 AS Decimal(18, 0)))
INSERT INTO [dbo].[Transactions] ( [EmpCashierID], [CustomerEmail], [SubTotal], [TaxAmount], [TotalAmount]) VALUES ( 8, N'oo@gmail.com', CAST(1551 AS Decimal(18, 0)), CAST(155 AS Decimal(18, 0)), CAST(1706 AS Decimal(18, 0)))
INSERT INTO [dbo].[Transactions] ( [EmpCashierID], [CustomerEmail], [SubTotal], [TaxAmount], [TotalAmount]) VALUES ( 11, N'ww@gmail.com', CAST(3349 AS Decimal(18, 0)), CAST(335 AS Decimal(18, 0)), CAST(3684 AS Decimal(18, 0)))
INSERT INTO [dbo].[Transactions] ( [EmpCashierID], [CustomerEmail], [SubTotal], [TaxAmount], [TotalAmount]) VALUES ( 11, N'test@gmail.com', CAST(9000 AS Decimal(18, 0)), CAST(900 AS Decimal(18, 0)), CAST(9900 AS Decimal(18, 0)))
INSERT INTO [dbo].[Transactions] ( [EmpCashierID], [CustomerEmail], [SubTotal], [TaxAmount], [TotalAmount]) VALUES ( 1, N'kk@qq.com', CAST(2902 AS Decimal(18, 0)), CAST(290 AS Decimal(18, 0)), CAST(3192 AS Decimal(18, 0)))
INSERT INTO [dbo].[Transactions] ( [EmpCashierID], [CustomerEmail], [SubTotal], [TaxAmount], [TotalAmount]) VALUES ( 7, N'fdsa@rr.com', CAST(14000 AS Decimal(18, 0)), CAST(1400 AS Decimal(18, 0)), CAST(15400 AS Decimal(18, 0)))
INSERT INTO [dbo].[Transactions] ( [EmpCashierID], [CustomerEmail], [SubTotal], [TaxAmount], [TotalAmount]) VALUES ( 9, N'ytbhs@qyue.com', CAST(4247 AS Decimal(18, 0)), CAST(425 AS Decimal(18, 0)), CAST(4672 AS Decimal(18, 0)))
INSERT INTO [dbo].[Transactions] ( [EmpCashierID], [CustomerEmail], [SubTotal], [TaxAmount], [TotalAmount]) VALUES ( 3, N'gp@armani.com', CAST(7257 AS Decimal(18, 0)), CAST(726 AS Decimal(18, 0)), CAST(7983 AS Decimal(18, 0)))
INSERT INTO [dbo].[Transactions] ( [EmpCashierID], [CustomerEmail], [SubTotal], [TaxAmount], [TotalAmount]) VALUES ( 10, N'lg667@my.com', CAST(6259 AS Decimal(18, 0)), CAST(626 AS Decimal(18, 0)), CAST(6885 AS Decimal(18, 0)))
INSERT INTO [dbo].[Transactions] ( [EmpCashierID], [CustomerEmail], [SubTotal], [TaxAmount], [TotalAmount]) VALUES ( 2, N'psps112@xx.com', CAST(12349 AS Decimal(18, 0)), CAST(1235 AS Decimal(18, 0)), CAST(13584 AS Decimal(18, 0)))
INSERT INTO [dbo].[Transactions] ( [EmpCashierID], [CustomerEmail], [SubTotal], [TaxAmount], [TotalAmount]) VALUES ( 4, N'ac1984@tyyt.com', CAST(6204 AS Decimal(18, 0)), CAST(620 AS Decimal(18, 0)), CAST(6824 AS Decimal(18, 0)))
INSERT INTO [dbo].[Transactions] ( [EmpCashierID], [CustomerEmail], [SubTotal], [TaxAmount], [TotalAmount]) VALUES ( 7, N'wileks@ymail.ca', CAST(7487 AS Decimal(18, 0)), CAST(749 AS Decimal(18, 0)), CAST(8236 AS Decimal(18, 0)))
INSERT INTO [dbo].[Transactions] ( [EmpCashierID], [CustomerEmail], [SubTotal], [TaxAmount], [TotalAmount]) VALUES ( 1, N'pp@gmail.com', CAST(1773 AS Decimal(18, 0)), CAST(177 AS Decimal(18, 0)), CAST(1950 AS Decimal(18, 0)))
INSERT INTO [dbo].[Transactions] ( [EmpCashierID], [CustomerEmail], [SubTotal], [TaxAmount], [TotalAmount]) VALUES ( 2, N'tt@gmail.com', CAST(4849 AS Decimal(18, 0)), CAST(485 AS Decimal(18, 0)), CAST(5334 AS Decimal(18, 0)))

GO


INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 1, 1, 11, 1)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 4, 2, 12, 5)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 3, 2, 12, 7)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 1, 3, 3, 14)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 1, 3, 3, 17)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 2, 4, 11, 11)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 2, 4, 11, 18)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 1, 4, 11, 14)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 1, 4, 11, 20)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 1, 5, 9, 11)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 1, 6, 2, 20)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 5, 7, 12, 10)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 1, 8, 8, 7)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 1, 9, 7, 7)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 1, 10, 9, 19)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 1, 11, 7, 8)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 2, 12, 10, 16)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 2, 12, 10, 4)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 1, 12, 10, 19)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 1, 12, 10, 14)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 1, 13, 8, 14)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 1, 14, 11, 18)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 1, 15, 11, 19)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 1, 16, 1, 3)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 2, 17, 7, 12)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 1, 18, 9, 9)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 1, 18, 9, 16)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 1, 19, 3, 8)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 1, 19, 3, 17)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 1, 19, 3, 16)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 1, 20, 10, 10)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 1, 20, 10, 14)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 2, 20, 10, 5)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 1, 21, 2, 18)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 1, 21, 2, 19)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 4, 22, 4, 14)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 1, 23, 7, 10)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 3, 23, 7, 9)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 1, 24, 1, 1)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 1, 25, 2, 17)
INSERT INTO [dbo].[Orders] ( [Quantity], [TransactionId], [SalerId], [ProductId]) VALUES ( 1, 25, 2, 8)

GO
