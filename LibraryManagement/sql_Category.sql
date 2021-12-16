﻿CREATE TABLE [dbo].[Category]
(
	[Category] INT NOT NULL PRIMARY KEY,
	[ISBN] VARCHAR(16) NOT NULL,
	CONSTRAINT [ISBN_Category_FK] FOREIGN KEY ([ISBN]) REFERENCES [Book]([ISBN])
)