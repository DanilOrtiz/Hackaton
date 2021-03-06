CREATE DATABASE Hackaton


USE [Hackaton]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 21/08/2018 20:46:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categoria](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](500) NOT NULL,
	[Fecha_Crea] [datetime] NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ciudad]    Script Date: 21/08/2018 20:46:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ciudad](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](500) NOT NULL,
	[Latitud] [numeric](18, 6) NULL,
	[Longitid] [numeric](18, 6) NULL,
	[Fecha_Crea] [datetime] NOT NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_Ciudad] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Estado]    Script Date: 21/08/2018 20:46:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Estado](
	[ID] [int] NOT NULL,
	[Descripcion] [varchar](500) NOT NULL,
	[Fecha_Crea] [datetime] NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_Suceso_Estado] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Perfil]    Script Date: 21/08/2018 20:46:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Perfil](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](500) NOT NULL,
	[Fecha_Crea] [datetime] NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_Perfil] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Suceso]    Script Date: 21/08/2018 20:46:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Suceso](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Usuario_ID] [int] NULL,
	[Descripcion] [varchar](1000) NOT NULL,
	[Latitud] [numeric](18, 6) NULL,
	[Longitid] [numeric](18, 6) NULL,
	[Ciudad_ID] [int] NULL,
	[Suceso_Estado_ID] [int] NOT NULL,
	[EsAnonimo] [bit] NOT NULL,
	[Fecha_Crea] [datetime] NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_Suceso] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Suceso_Categoria]    Script Date: 21/08/2018 20:46:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suceso_Categoria](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Suceso_ID] [int] NOT NULL,
	[Categoria_ID] [int] NOT NULL,
	[Fecha_Crea] [datetime] NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_Suceso_Categoria] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Suceso_Comentario]    Script Date: 21/08/2018 20:46:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Suceso_Comentario](
	[ID] [int] NOT NULL,
	[Suceso_ID] [int] NOT NULL,
	[Comentario] [varchar](5000) NOT NULL,
	[Usuario_ID] [int] NOT NULL,
	[Fecha_Crea] [datetime] NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_Suceso_Comentario] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Suceso_Multimedia]    Script Date: 21/08/2018 20:46:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Suceso_Multimedia](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ruta] [varchar](1000) NOT NULL,
	[Nombre] [varchar](500) NOT NULL,
	[Suceso_Multimedia_Tipo_ID] [int] NOT NULL,
	[Suceso_ID] [int] NOT NULL,
	[Fecha_Crea] [datetime] NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_Suceso_Multimedia] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Suceso_Multimedia_Tipo]    Script Date: 21/08/2018 20:46:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Suceso_Multimedia_Tipo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](500) NULL,
	[Fecha_Crea] [datetime] NOT NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_Suceso_Multimedia_Tipo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Suceso_Valoracion]    Script Date: 21/08/2018 20:46:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suceso_Valoracion](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Suceso_ID] [int] NOT NULL,
	[Usuario_ID] [int] NOT NULL,
	[Fecha_Crea] [datetime] NOT NULL,
	[Suceso_Valoracion_Tipo_ID] [int] NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_Suceso_Valoracion] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Suceso_Valoracion_Tipo]    Script Date: 21/08/2018 20:46:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Suceso_Valoracion_Tipo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](500) NOT NULL,
	[Valoracion] [int] NOT NULL,
	[Fecha_Crea] [datetime] NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_Suceso_Valoracion_Tipo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 21/08/2018 20:46:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](500) NOT NULL,
	[Correo] [varchar](500) NOT NULL,
	[Clave] [varbinary](500) NOT NULL,
	[Ciudad_ID] [int] NULL,
	[Perfil_ID] [int] NULL,
	[Imagen] [varchar](500) NOT NULL,
	[Fecha_Crea] [datetime] NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Categoria] ADD  CONSTRAINT [DF__Categoria__Activ__15502E78]  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [dbo].[Ciudad] ADD  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [dbo].[Perfil] ADD  CONSTRAINT [DF__Perfil__Activo__1367E606]  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [dbo].[Suceso] ADD  CONSTRAINT [DF__Suceso__EsAnonim__173876EA]  DEFAULT ((0)) FOR [EsAnonimo]
GO
ALTER TABLE [dbo].[Suceso] ADD  CONSTRAINT [DF__Suceso__Activo__182C9B23]  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [dbo].[Suceso_Categoria] ADD  CONSTRAINT [DF__Suceso_Ca__Activ__1A14E395]  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [dbo].[Suceso_Multimedia] ADD  CONSTRAINT [DF__Suceso_Mu__Activ__1BFD2C07]  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [dbo].[Suceso_Multimedia_Tipo] ADD  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [dbo].[Suceso_Valoracion] ADD  CONSTRAINT [DF__Suceso_Va__Activ__1FCDBCEB]  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [dbo].[Suceso_Valoracion_Tipo] ADD  CONSTRAINT [DF__Suceso_Va__Activ__21B6055D]  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [DF__Usuario__Activo__0F975522]  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [dbo].[Suceso]  WITH CHECK ADD  CONSTRAINT [FK_Suceso_Suceso] FOREIGN KEY([ID])
REFERENCES [dbo].[Estado] ([ID])
GO
ALTER TABLE [dbo].[Suceso] CHECK CONSTRAINT [FK_Suceso_Suceso]
GO
ALTER TABLE [dbo].[Suceso_Categoria]  WITH CHECK ADD  CONSTRAINT [FK_Suceso_Categoria_Categoria] FOREIGN KEY([Categoria_ID])
REFERENCES [dbo].[Categoria] ([ID])
GO
ALTER TABLE [dbo].[Suceso_Categoria] CHECK CONSTRAINT [FK_Suceso_Categoria_Categoria]
GO
ALTER TABLE [dbo].[Suceso_Categoria]  WITH CHECK ADD  CONSTRAINT [FK_Suceso_Categoria_Suceso] FOREIGN KEY([Suceso_ID])
REFERENCES [dbo].[Suceso] ([ID])
GO
ALTER TABLE [dbo].[Suceso_Categoria] CHECK CONSTRAINT [FK_Suceso_Categoria_Suceso]
GO
ALTER TABLE [dbo].[Suceso_Comentario]  WITH CHECK ADD  CONSTRAINT [FK_Suceso_Comentario_Suceso] FOREIGN KEY([Suceso_ID])
REFERENCES [dbo].[Suceso] ([ID])
GO
ALTER TABLE [dbo].[Suceso_Comentario] CHECK CONSTRAINT [FK_Suceso_Comentario_Suceso]
GO
ALTER TABLE [dbo].[Suceso_Comentario]  WITH CHECK ADD  CONSTRAINT [FK_Suceso_Comentario_Suceso_Comentario] FOREIGN KEY([Usuario_ID])
REFERENCES [dbo].[Usuario] ([ID])
GO
ALTER TABLE [dbo].[Suceso_Comentario] CHECK CONSTRAINT [FK_Suceso_Comentario_Suceso_Comentario]
GO
ALTER TABLE [dbo].[Suceso_Multimedia]  WITH CHECK ADD  CONSTRAINT [FK_Suceso_Multimedia_Suceso] FOREIGN KEY([Suceso_ID])
REFERENCES [dbo].[Suceso] ([ID])
GO
ALTER TABLE [dbo].[Suceso_Multimedia] CHECK CONSTRAINT [FK_Suceso_Multimedia_Suceso]
GO
ALTER TABLE [dbo].[Suceso_Multimedia]  WITH CHECK ADD  CONSTRAINT [FK_Suceso_Multimedia_Suceso_Multimedia] FOREIGN KEY([Suceso_Multimedia_Tipo_ID])
REFERENCES [dbo].[Suceso_Multimedia_Tipo] ([ID])
GO
ALTER TABLE [dbo].[Suceso_Multimedia] CHECK CONSTRAINT [FK_Suceso_Multimedia_Suceso_Multimedia]
GO
ALTER TABLE [dbo].[Suceso_Valoracion]  WITH CHECK ADD  CONSTRAINT [FK_Suceso_Valoracion_Suceso] FOREIGN KEY([Suceso_ID])
REFERENCES [dbo].[Suceso] ([ID])
GO
ALTER TABLE [dbo].[Suceso_Valoracion] CHECK CONSTRAINT [FK_Suceso_Valoracion_Suceso]
GO
ALTER TABLE [dbo].[Suceso_Valoracion]  WITH CHECK ADD  CONSTRAINT [FK_Suceso_Valoracion_Suceso_Valoracion_Tipo] FOREIGN KEY([Suceso_Valoracion_Tipo_ID])
REFERENCES [dbo].[Suceso_Valoracion_Tipo] ([ID])
GO
ALTER TABLE [dbo].[Suceso_Valoracion] CHECK CONSTRAINT [FK_Suceso_Valoracion_Suceso_Valoracion_Tipo]
GO
ALTER TABLE [dbo].[Suceso_Valoracion]  WITH CHECK ADD  CONSTRAINT [FK_Suceso_Valoracion_Usuario] FOREIGN KEY([Usuario_ID])
REFERENCES [dbo].[Usuario] ([ID])
GO
ALTER TABLE [dbo].[Suceso_Valoracion] CHECK CONSTRAINT [FK_Suceso_Valoracion_Usuario]
GO
