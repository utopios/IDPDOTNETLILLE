CREATE TABLE [dbo].[contact] (
    [id]         INT           IDENTITY (1, 1) NOT NULL,
    [last_name]  VARCHAR (100) NULL,
    [first_name] VARCHAR (100) NULL,
    [phone]      VARCHAR (10)  NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE email(
    id int NOT NULL PRIMARY KEY IDENTITY(1,1),
    mail varchar(100) NOT NULL,
    contact_id int NOT NULL
);