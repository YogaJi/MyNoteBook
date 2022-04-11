CREATE TABLE [dbo].[Journal] (
    [JournalId]       INT            IDENTITY (1, 1) NOT NULL,
    [Title]           NVARCHAR (MAX) NULL,
    [Date]            DATETIME2 (7)  NOT NULL,
    [Weather]         INT            NULL,
    [Mood]            INT            NULL,
    [Content]         NVARCHAR (MAX) NULL,
    [BackgroundColor] NVARCHAR (MAX) NULL,
    [Notebook]        INT            NULL,
    CONSTRAINT [PK_Journal] PRIMARY KEY CLUSTERED ([JournalId] ASC),
    CONSTRAINT [FK_Journal_Mood_Mood] FOREIGN KEY ([Mood]) REFERENCES [dbo].[Mood] ([MoodId]),
    CONSTRAINT [FK_Journal_Weather_Weather] FOREIGN KEY ([Weather]) REFERENCES [dbo].[Weather] ([WeatherId]),
    CONSTRAINT [FK_Journal_Notebook_Notebook] FOREIGN KEY ([Notebook]) REFERENCES [dbo].[Notebook] ([NotebookId])
);


GO
CREATE NONCLUSTERED INDEX [IX_Journal_Mood]
    ON [dbo].[Journal]([Mood] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Journal_Weather]
    ON [dbo].[Journal]([Weather] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Journal_Notebook]
    ON [dbo].[Journal]([Notebook] ASC);

