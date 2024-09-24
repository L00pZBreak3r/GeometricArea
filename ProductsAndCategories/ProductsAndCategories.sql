SELECT a.title AS ProductName, b.title AS CategoryName
FROM dbo.Products a LEFT JOIN (dbo.Categories b INNER JOIN dbo.ProductsToCategories c ON b.id = c.CategoryId) ON a.id = c.ProductId
ORDER BY a.title;


/*
CREATE TABLE dbo.Products (
  id          int IDENTITY(1, 1),
  title       nvarchar(255) NOT NULL,
  PRIMARY KEY (id)
)
GO

CREATE UNIQUE INDEX Products_Index01
  ON dbo.Products
  (title)
GO

CREATE TABLE dbo.Categories (
  id          int IDENTITY(1, 1),
  title       nvarchar(255) NOT NULL,
  PRIMARY KEY (id)
)
GO

CREATE UNIQUE INDEX Categories_Index01
  ON dbo.Categories
  (title)
GO

CREATE TABLE dbo.ProductsToCategories (
  ProductId     int NOT NULL,
  CategoryId    int NOT NULL,
  PRIMARY KEY (ProductId, CategoryId)
)
GO

CREATE UNIQUE INDEX ProductsToCategories_Index01
  ON dbo.ProductsToCategories
  (ProductId, CategoryId)
GO
*/
