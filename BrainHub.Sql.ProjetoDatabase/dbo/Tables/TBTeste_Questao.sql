CREATE TABLE [dbo].[TBTeste_Questao] (
    [teste_id]   INT NOT NULL,
    [questao_id] INT NOT NULL,
    [id]         INT IDENTITY (1, 1) NOT NULL,
    CONSTRAINT [PK_TBTeste_Questao] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_TBTeste_Questao_TBQuestao] FOREIGN KEY ([questao_id]) REFERENCES [dbo].[TBQuestao] ([id]),
    CONSTRAINT [FK_TBTeste_Questao_TBTeste] FOREIGN KEY ([teste_id]) REFERENCES [dbo].[TBTeste] ([id]) ON DELETE CASCADE
);

