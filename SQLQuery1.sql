create database RentalCarDb;

CREATE TABLE [dbo].[Colors] (
    [ColorId]   INT        NOT NULL,
    [ColorName] NCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([ColorId] ASC)
);

CREATE TABLE [dbo].[Cars] (
    [CarId]       INT      NOT NULL,
    [BrandId]     INT      NOT NULL,
    [ColorId]     INT      NOT NULL,
    [ModelYear]   SMALLINT NULL,
    [DailyPrice]  DECIMAL    NOT NULL,
    [Description] TEXT     NULL,
    PRIMARY KEY CLUSTERED ([CarId] ASC)
);


CREATE TABLE [dbo].[Brands] (
    [BrandId]   INT        NOT NULL,
    [BrandName] NCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([BrandId] ASC)
);

