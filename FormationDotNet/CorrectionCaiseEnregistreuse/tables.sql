CREATE TABLE [dbo].[product]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [title] VARCHAR(100) NULL, 
    [price] DECIMAL NULL, 
    [stock] INT NULL
);

CREATE TABLE [dbo].[order]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [total] DECIMAL NULL
);
CREATE TABLE [dbo].[product_order]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [order_id] int NULL, 
    [product_id] int NULL, 
    [qty] int NULL
);
CREATE TABLE [dbo].[payment]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [total] DECIMAL NULL,
    payment_date datetime not null,
    [type] varchar(300) not null,
    order_id int not null
);

CREATE TABLE [dbo].[card_payment]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    payment_id int not null
);
CREATE TABLE [dbo].[cash_payment]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    payment_id int not null,
    change decimal 
);