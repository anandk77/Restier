CREATE TABLE [Product](
[ProductID] [int] IDENTITY(1,1)  NOT NULL,
[Name] [nvarchar](250) NULL,
[Price] DECIMAL(18,2),
[Category] [nvarchar](250) NULL, 
[CreatedDate][Datetime] default getdate(),
[ModifiedDate][Datetime] default getdate(),  
CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([ProductID] ASC)
) ON [PRIMARY]

CREATE TABLE [CustomerReview](
	[ID] [int] IDENTITY(1,1)  NOT NULL,
	[UserID] INT NOT NULL,
	[Rating] DECIMAL(10,2) NOT NULL,
	[ReviewComments] [nvarchar](250) NULL,
	[ProductID] INT NOT NULL,
	[CreatedDate][Datetime] default getdate(),
	[ModifiedDate][Datetime] default getdate(),
	CONSTRAINT [PK_CustomerReivew] PRIMARY KEY CLUSTERED ([ID] ASC)
) ON [PRIMARY]


CREATE TABLE [Users](
[UserID] [int] IDENTITY(1,1)  NOT NULL,
[Name] [nvarchar](100) NULL,
[Place] [nvarchar](100) NULL,
[CreatedDate][Datetime] default getdate(),
[ModifiedDate][Datetime] default getdate(),  
CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UserID] ASC)
) ON [PRIMARY]


ALTER TABLE [dbo].[CustomerReview] ADD  CONSTRAINT [FK_Prd] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO

ALTER TABLE [dbo].[CustomerReview] ADD  CONSTRAINT [FK_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
