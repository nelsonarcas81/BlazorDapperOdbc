CREATE TABLE equipe(
	[id] [varchar](12) NOT NULL,
	[descricao] [varchar](30) NOT NULL,
	[dtcadastro] [date] NULL
) ON [PRIMARY]
ALTER TABLE [dbo].[equipe] ADD PRIMARY KEY CLUSTERED 
(
	[id] ASC
)