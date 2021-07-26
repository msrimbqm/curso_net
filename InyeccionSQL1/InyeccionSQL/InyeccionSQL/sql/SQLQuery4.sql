USE [EJERCICIOSCLASE]
GO

/****** Object:  Table [dbo].[Personas]    Script Date: 26/07/2021 18:39:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Personas](
	[ID] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Edad] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

