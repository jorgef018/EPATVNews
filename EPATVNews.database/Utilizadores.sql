CREATE TABLE [dbo].[Utilizadores](
	[Id] INT Identity (1, 1) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL, 
    CONSTRAINT [PK_Utilizadores] PRIMARY KEY ([Id])
)