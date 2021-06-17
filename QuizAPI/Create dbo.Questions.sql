USE [QuizApi]
GO

/****** Object: Table [dbo].[Questions] Script Date: 2021/06/16 22:36:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Questions] (
    [QuestionID]   INT           IDENTITY (1, 1) NOT NULL,
    [QuestionType] TEXT          NOT NULL,
    [QuestionText] VARCHAR (MAX) NOT NULL,
    [AnswerID]     INT           NOT NULL,
    [CategoryID]   INT           NOT NULL
);


select * from dbo.Questions