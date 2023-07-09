CREATE TABLE [dbo].[TBTeste] (
    [id]               INT           IDENTITY (1, 1) NOT NULL,
    [nome]             VARCHAR (MAX) NOT NULL,
    [numeroQuestoes]   INT           NOT NULL,
    [provaRecuperacao] BIT           NULL,
    [serie]            INT           NULL,
    [data]             DATETIME      NOT NULL,
    [disciplina_id]    INT           NOT NULL,
    [materia_id]       INT           NULL,
    CONSTRAINT [PK_TBTeste] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_TBTeste_TBDisciplina] FOREIGN KEY ([disciplina_id]) REFERENCES [dbo].[TBDisciplina] ([id]),
    CONSTRAINT [FK_TBTeste_TBMateria] FOREIGN KEY ([materia_id]) REFERENCES [dbo].[TBMateria] ([id])
);

