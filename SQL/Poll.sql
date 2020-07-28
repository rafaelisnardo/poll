CREATE DATABASE Poll
GO

USE Poll
GO

CREATE TABLE [dbo].[Poll](
	[poll_id] [int] IDENTITY(1,1) NOT NULL,
	[poll_description] [varchar](255) NOT NULL,
 CONSTRAINT [PK_Poll] PRIMARY KEY CLUSTERED 
(
	[poll_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[PollOption](
	[option_id] [int] IDENTITY(1,1) NOT NULL,
	[poll_id] [int] NOT NULL,
	[option_description] [varchar](255) NOT NULL
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[PollStats](
	[stat_id] [int] IDENTITY(1,1) NOT NULL,
	[poll_id] [int] NOT NULL,
	[views] [int] NOT NULL,
 CONSTRAINT [PK_PollStats] PRIMARY KEY CLUSTERED 
(
	[stat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PollStats] ADD  CONSTRAINT [DF_PollStats_views]  DEFAULT ((0)) FOR [views]
GO


CREATE TABLE [dbo].[PollVotes](
	[vote_id] [int] IDENTITY(1,1) NOT NULL,
	[poll_id] [int] NOT NULL,
	[option_id] [int] NOT NULL,
	[qty] [int] NOT NULL,
 CONSTRAINT [PK_PollVotes] PRIMARY KEY CLUSTERED 
(
	[vote_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PollVotes] ADD  CONSTRAINT [DF_PollVotes_qty]  DEFAULT ((0)) FOR [qty]
GO