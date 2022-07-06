CREATE TABLE [dbo].[account] (
    [id]             INT          IDENTITY (1, 1) NOT NULL,
    [total_amount]   DECIMAL (18) NULL,
    [customer_id]    INT          NULL,
    [account_number] INT          NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[operation] (
    [id]                  INT          IDENTITY (1, 1) NOT NULL,
    [amount]              DECIMAL (18) NULL,
    [operation_date_time] DATETIME     NULL,
    [account_id]          INT          NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[customer] (
    [id]         INT           IDENTITY (1, 1) NOT NULL,
    [first_name] VARCHAR (100) NULL,
    [last_name]  VARCHAR (100) NULL,
    [phone]      VARCHAR (10)  NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);
 