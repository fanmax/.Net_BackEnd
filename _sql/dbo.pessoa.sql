CREATE TABLE [dbo].[pessoa]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [nome] NCHAR(50) NOT NULL, 
    [email] NCHAR(255) NULL
)
