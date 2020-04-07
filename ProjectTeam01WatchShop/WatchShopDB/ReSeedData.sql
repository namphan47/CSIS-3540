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

go 

INSERT INTO Roles([Type]) VALUES('Admin');
INSERT INTO Roles([Type]) VALUES('Saler');
INSERT INTO Roles([Type]) VALUES('Manager');

go





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

go


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




go