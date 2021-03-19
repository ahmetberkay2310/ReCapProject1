CREATE TABLE [Brands] (
    [BrandId]   INT          NOT NULL IDENTITY(1,1),
    [BrandName] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([BrandId] ASC)
);
CREATE TABLE [Rentals] (
    [Id]              INT            NOT NULL IDENTITY(1,1),
    [CarId]           INT            NOT NULL,
    [CustomerId]      INT            NOT NULL,
    [RentDate]        INT            NOT NULL,
    [ReturnDate]      INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
    CREATE TABLE [Customers] (
    [Id]              INT            NOT NULL IDENTITY(1,1),
    [UserId]          INT            NOT NULL,
    [CompanyName]     VARCHAR   (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
CREATE TABLE [Users] (
    [Id]             INT             NOT NULL IDENTITY(1,1),
    [FirstName]      VARCHAR (50)    NOT NULL,
    [LastName]       VARCHAR (50)    NOT NULL,
    [Email]          VARCHAR (50)    NOT NULL,
    [UserPassword]   VARCHAR (50)    NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
    
CREATE TABLE [Colors] (
    [ColorId]   INT          NOT NULL IDENTITY(1,1),
    [ColorName] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([ColorId] ASC)
);
CREATE TABLE [Cars] (
    [Id]             INT           NOT NULL IDENTITY(1,1),
    [BrandId]        INT           NOT NULL,
    [ColorId]        INT           NOT NULL,
    [CarDescription] VARCHAR (MAX) NOT NULL,
    [ModelYear]      INT           NOT NULL,
    [DailyPrice]     MONEY         NOT NULL,
    [IsAvailable]    BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([BrandId]) REFERENCES [dbo].[Brands] ([BrandId]),
    FOREIGN KEY ([ColorId]) REFERENCES [dbo].[Colors] ([ColorId]),
    FOREIGN KEY ([Id]) REFERENCES [dbo].[Rentals] ([Id]),
    FOREIGN KEY ([Id]) REFERENCES [dbo].[Customers] ([Id]),
    FOREIGN KEY ([Id]) REFERENCES [dbo].[Users] ([Id])
       
);