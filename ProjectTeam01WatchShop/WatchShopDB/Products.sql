CREATE TABLE [dbo].[Products]
(
	[ProductID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductBrand] VARCHAR(50) NOT NULL, 
    [ProductDescription] VARCHAR(50) NULL, 
    [ProductQuantity] INT NULL, 
    [ProductPrice] INT NULL, 
    [ProductImage] VARCHAR(50) NOT NULL
)
