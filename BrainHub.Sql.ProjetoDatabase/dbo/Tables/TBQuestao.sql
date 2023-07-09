CREATE TABLE [dbo].[TBQuestao] (
    [id]         INT           IDENTITY (1, 1) NOT NULL,
    [enunciado]  VARCHAR (MAX) NOT NULL,
    [materia_id] INT           NOT NULL,
    [resposta]   VARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_TBQuestao] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_TBQuestao_TBMateria] FOREIGN KEY ([materia_id]) REFERENCES [dbo].[TBMateria] ([id])
);

