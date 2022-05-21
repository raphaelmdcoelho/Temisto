CREATE DATABASE League

GO

USE League

GO

CREATE SCHEMA Base

GO

CREATE TABLE [Base].[Hero] (
	[Id] [int] NOT NULL,
	[Name] [varchar](max) NULL,
	[HeroName] [varchar](max) NOT NULL,
	[Age] [int] NULL,
	[Gender] [int] NULL,
	PRIMARY KEY (Id)
);

GO
