USE [Bank]
GO

/****** Object:  Table [dbo].[Login]    Script Date: 02-04-2019 16:52:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Login](
	[userId] [varchar](20) NOT NULL,
	[password] [varchar](20) NOT NULL,
	[role] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

CREATE TABLE [dbo].[Account](
	[accountNo] [bigint] IDENTITY(1504000000,1) NOT NULL,
	[customerId] [int] NOT NULL,
	[accountType] [varchar](10) NOT NULL,
	[DateOfOpen] [varchar](15) NOT NULL,
	[status] [varchar](10) NOT NULL,
	[dateOfEdited] [varchar](15) NULL,
	[ClosingDate] [varchar](15) NULL,
	[amount] [int] NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[accountNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Customer] FOREIGN KEY([customerId])
REFERENCES [dbo].[Customer] ([customerId])
GO

ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Customer]
GO

CREATE TABLE [dbo].[Transaction](
	[transactionId] [bigint] IDENTITY(6524000000,1) NOT NULL,
	[fromAccountNo] [bigint] NOT NULL,
	[toAccountNo] [bigint] NOT NULL,
	[transactionDate] [varchar](15) NOT NULL,
	[amount] [int] NOT NULL,
	[transactionType] [varchar](15) NOT NULL,
	[comments] [varchar](50) NULL,
 CONSTRAINT [PK_Transaction] PRIMARY KEY CLUSTERED 
(
	[transactionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Transaction]  WITH CHECK ADD  CONSTRAINT [FK_Transaction_Account] FOREIGN KEY([fromAccountNo])
REFERENCES [dbo].[Account] ([accountNo])
GO

ALTER TABLE [dbo].[Transaction] CHECK CONSTRAINT [FK_Transaction_Account]
GO

ALTER TABLE [dbo].[Transaction]  WITH CHECK ADD  CONSTRAINT [FK_Transaction_Account1] FOREIGN KEY([toAccountNo])
REFERENCES [dbo].[Account] ([accountNo])
GO

ALTER TABLE [dbo].[Transaction] CHECK CONSTRAINT [FK_Transaction_Account1]
GO