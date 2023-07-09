CREATE TABLE [dbo].[TBAlternativa] (
    [id]         INT           IDENTITY (1, 1) NOT NULL,
    [questao_id] INT           NOT NULL,
    [titulo]     VARCHAR (MAX) NOT NULL,
    [letra]      VARCHAR (MAX) NOT NULL,
    [correta]    BIT           NOT NULL,
    CONSTRAINT [PK_TBAlternativa] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_TBAlternativa_TBQuestao] FOREIGN KEY ([questao_id]) REFERENCES [dbo].[TBQuestao] ([id])
);

