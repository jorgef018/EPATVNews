CREATE TABLE [dbo].[Feeds](
	[ID] [int] NOT NULL,
	[IdUtilizador] [int] NOT NULL,
	[Titulo] [nvarchar](50) NOT NULL,
	[Descricao] [nvarchar](2500) NULL,
	[Tipo] [int] NOT NULL,
	[Imagem] [nvarchar](50) NULL,
	[Video] [nvarchar](50) NULL,
	[DataInicio] [datetime] NOT NULL,
	[DataFim] [datetime] NOT NULL

    CONSTRAINT [FK_Feeds_Utilizadores] FOREIGN KEY ([IdUtilizador]) REFERENCES [Utilizadores]([id])
) ON [PRIMARY]