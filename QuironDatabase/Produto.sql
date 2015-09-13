CREATE TABLE [dbo].[Produtos]
(
	[ProdutoId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] NVARCHAR(150) NULL, 
    [Descricao] NVARCHAR(500) NULL, 
    [Categoria] NVARCHAR(50) NULL, 
    [Preco] DECIMAL(16, 2) NULL
)
