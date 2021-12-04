USE [Prueba1]
GO

/****** Object:  Table [dbo].[Cliente]    Script Date: 3/12/2021 12:17:27 p. m. ******/
DROP TABLE [dbo].[Cliente]
GO

/****** Object:  Table [dbo].[Cliente]    Script Date: 3/12/2021 12:17:27 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cliente](
	[IdPersona] [int] IDENTITY(1,1) NOT NULL,
	[NombreApellidos] [nvarchar](200) NULL,
	[TipoDocumento] [nvarchar](20) NULL,
	[FechaNacimiento] [DateTime] NULL,
	[ValorGanar] [int] NULL,
	[EstadoCivil] [nvarchar](20) NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[IdPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] 

GO


