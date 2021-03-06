﻿/*
Deployment script for WatchShopDB

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "WatchShopDB"
:setvar DefaultFilePrefix "WatchShopDB"
:setvar DefaultDataPath "C:\Users\mr.nam\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"
:setvar DefaultLogPath "C:\Users\mr.nam\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [master];


GO

IF (DB_ID(N'$(DatabaseName)') IS NOT NULL) 
BEGIN
    ALTER DATABASE [$(DatabaseName)]
    SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [$(DatabaseName)];
END

GO
PRINT N'Creating $(DatabaseName)...'
GO
CREATE DATABASE [$(DatabaseName)]
    ON 
    PRIMARY(NAME = [$(DatabaseName)], FILENAME = N'$(DefaultDataPath)$(DefaultFilePrefix)_Primary.mdf')
    LOG ON (NAME = [$(DatabaseName)_log], FILENAME = N'$(DefaultLogPath)$(DefaultFilePrefix)_Primary.ldf') COLLATE SQL_Latin1_General_CP1_CI_AS
GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CLOSE OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
USE [$(DatabaseName)];


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ANSI_NULLS ON,
                ANSI_PADDING ON,
                ANSI_WARNINGS ON,
                ARITHABORT ON,
                CONCAT_NULL_YIELDS_NULL ON,
                NUMERIC_ROUNDABORT OFF,
                QUOTED_IDENTIFIER ON,
                ANSI_NULL_DEFAULT ON,
                CURSOR_DEFAULT LOCAL,
                CURSOR_CLOSE_ON_COMMIT OFF,
                AUTO_CREATE_STATISTICS ON,
                AUTO_SHRINK OFF,
                AUTO_UPDATE_STATISTICS ON,
                RECURSIVE_TRIGGERS OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ALLOW_SNAPSHOT_ISOLATION OFF;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET READ_COMMITTED_SNAPSHOT OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_UPDATE_STATISTICS_ASYNC OFF,
                PAGE_VERIFY NONE,
                DATE_CORRELATION_OPTIMIZATION OFF,
                DISABLE_BROKER,
                PARAMETERIZATION SIMPLE,
                SUPPLEMENTAL_LOGGING OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET TRUSTWORTHY OFF,
        DB_CHAINING OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET HONOR_BROKER_PRIORITY OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
ALTER DATABASE [$(DatabaseName)]
    SET TARGET_RECOVERY_TIME = 0 SECONDS 
    WITH ROLLBACK IMMEDIATE;


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET FILESTREAM(NON_TRANSACTED_ACCESS = OFF),
                CONTAINMENT = NONE 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CREATE_STATISTICS ON(INCREMENTAL = OFF),
                MEMORY_OPTIMIZED_ELEVATE_TO_SNAPSHOT = OFF,
                DELAYED_DURABILITY = DISABLED 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE (QUERY_CAPTURE_MODE = ALL, DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_PLANS_PER_QUERY = 200, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 367), MAX_STORAGE_SIZE_MB = 100) 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE = OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
    END


GO
IF fulltextserviceproperty(N'IsFulltextInstalled') = 1
    EXECUTE sp_fulltext_database 'enable';


GO
PRINT N'Creating [dbo].[Employees]...';


GO
CREATE TABLE [dbo].[Employees] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Name]     VARCHAR (50)  NULL,
    [Address]  VARCHAR (100) NULL,
    [Password] VARCHAR (50)  NULL,
    [RoleId]   INT           NOT NULL,
    [PhoneNo]  VARCHAR (50)  NULL,
    [Email]    VARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[Orders]...';


GO
CREATE TABLE [dbo].[Orders] (
    [Id]            INT IDENTITY (1, 1) NOT NULL,
    [Quantity]      INT NOT NULL,
    [TransactionId] INT NOT NULL,
    [SalerId]       INT NOT NULL,
    [ProductId]     INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[Products]...';


GO
CREATE TABLE [dbo].[Products] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [Brand]       VARCHAR (50) NOT NULL,
    [Description] VARCHAR (50) NULL,
    [Quantity]    INT          NOT NULL,
    [Price]       DECIMAL (18) NOT NULL,
    [Image]       VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[Roles]...';


GO
CREATE TABLE [dbo].[Roles] (
    [Id]   INT          IDENTITY (1, 1) NOT NULL,
    [Type] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[Transactions]...';


GO
CREATE TABLE [dbo].[Transactions] (
    [Id]            INT          IDENTITY (1, 1) NOT NULL,
    [EmpCashierID]  INT          NULL,
    [CustomerEmail] VARCHAR (50) NULL,
    [SubTotal]      DECIMAL (18) NOT NULL,
    [TaxAmount]     DECIMAL (18) NOT NULL,
    [TotalAmount]   DECIMAL (18) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating unnamed constraint on [dbo].[Orders]...';


GO
ALTER TABLE [dbo].[Orders]
    ADD DEFAULT 0 FOR [Quantity];


GO
PRINT N'Creating unnamed constraint on [dbo].[Products]...';


GO
ALTER TABLE [dbo].[Products]
    ADD DEFAULT 0 FOR [Quantity];


GO
PRINT N'Creating unnamed constraint on [dbo].[Products]...';


GO
ALTER TABLE [dbo].[Products]
    ADD DEFAULT 0 FOR [Price];


GO
PRINT N'Creating [dbo].[FK_Employee_Role]...';


GO
ALTER TABLE [dbo].[Employees]
    ADD CONSTRAINT [FK_Employee_Role] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[Roles] ([Id]);


GO
PRINT N'Creating [dbo].[FK_Orders_Employee]...';


GO
ALTER TABLE [dbo].[Orders]
    ADD CONSTRAINT [FK_Orders_Employee] FOREIGN KEY ([SalerId]) REFERENCES [dbo].[Employees] ([Id]);


GO
PRINT N'Creating [dbo].[FK_Orders_Products]...';


GO
ALTER TABLE [dbo].[Orders]
    ADD CONSTRAINT [FK_Orders_Products] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([Id]);


GO
PRINT N'Creating [dbo].[FK_Orders_Transactions]...';


GO
ALTER TABLE [dbo].[Orders]
    ADD CONSTRAINT [FK_Orders_Transactions] FOREIGN KEY ([TransactionId]) REFERENCES [dbo].[Transactions] ([Id]);


GO
PRINT N'Creating [dbo].[FK_Transactions_Employee]...';


GO
ALTER TABLE [dbo].[Transactions]
    ADD CONSTRAINT [FK_Transactions_Employee] FOREIGN KEY ([EmpCashierID]) REFERENCES [dbo].[Employees] ([Id]);


GO
-- Refactoring step to update target server with deployed transaction logs

IF OBJECT_ID(N'dbo.__RefactorLog') IS NULL
BEGIN
    CREATE TABLE [dbo].[__RefactorLog] (OperationKey UNIQUEIDENTIFIER NOT NULL PRIMARY KEY)
    EXEC sp_addextendedproperty N'microsoft_database_tools_support', N'refactoring log', N'schema', N'dbo', N'table', N'__RefactorLog'
END
GO
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'da48e94c-aa24-4661-aed9-fd8a3b7645cd')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('da48e94c-aa24-4661-aed9-fd8a3b7645cd')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'd483d6f2-c3e8-4667-91ef-87f44890a381')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('d483d6f2-c3e8-4667-91ef-87f44890a381')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '6227e739-33f2-4ed9-b47c-777ded69ac6f')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('6227e739-33f2-4ed9-b47c-777ded69ac6f')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '97b2716e-99dd-4045-85d8-55545f200a7b')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('97b2716e-99dd-4045-85d8-55545f200a7b')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '82fb47ce-7e7f-4436-8434-507ffce38ee3')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('82fb47ce-7e7f-4436-8434-507ffce38ee3')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '01fd193e-7d83-4609-83fb-9a904924ddd3')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('01fd193e-7d83-4609-83fb-9a904924ddd3')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'e8ad81c7-67d8-4e52-80fd-6ccdd0261264')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('e8ad81c7-67d8-4e52-80fd-6ccdd0261264')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '8572862f-6362-45ae-83e0-6978437d30d2')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('8572862f-6362-45ae-83e0-6978437d30d2')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'ef70075e-d29e-41fa-a618-4761156e0136')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('ef70075e-d29e-41fa-a618-4761156e0136')

GO

GO
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

INSERT INTO [dbo].[Transactions] ( [EmpCashierID], [CustomerEmail], [SubTotal], [TaxAmount], [TotalAmount]) VALUES ( 11, N'cust1@gmail.com', CAST(1773 AS Decimal(18, 0)), CAST(177 AS Decimal(18, 0)), CAST(1950 AS Decimal(18, 0)))
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

GO
DECLARE @VarDecimalSupported AS BIT;

SELECT @VarDecimalSupported = 0;

IF ((ServerProperty(N'EngineEdition') = 3)
    AND (((@@microsoftversion / power(2, 24) = 9)
          AND (@@microsoftversion & 0xffff >= 3024))
         OR ((@@microsoftversion / power(2, 24) = 10)
             AND (@@microsoftversion & 0xffff >= 1600))))
    SELECT @VarDecimalSupported = 1;

IF (@VarDecimalSupported > 0)
    BEGIN
        EXECUTE sp_db_vardecimal_storage_format N'$(DatabaseName)', 'ON';
    END


GO
PRINT N'Update complete.';


GO
