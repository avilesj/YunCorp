USE [YunDB]
GO
/****** Object:  Table [dbo].[Departamentos_mstr]    Script Date: 08/02/2015 20:42:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Departamentos_mstr](
	[dept_id] [int] IDENTITY(1,1) NOT NULL,
	[dept_desc] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Departamentos_mstr] PRIMARY KEY CLUSTERED 
(
	[dept_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Empleados_mstr]    Script Date: 08/02/2015 20:42:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleados_mstr](
	[emp_id] [int] IDENTITY(1,1) NOT NULL,
	[emp_nombre] [varchar](50) NULL,
	[emp_apellido] [varchar](50) NULL,
	[emp_cedula] [varchar](11) NULL,
	[dept_id] [int] NULL,
	[emp_ext] [nchar](10) NULL,
	[emp_flota] [nchar](10) NULL,
 CONSTRAINT [PK_Empleados_mstr_1] PRIMARY KEY CLUSTERED 
(
	[emp_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_Empleados_mstr_Departamentos_mstr_ID]    Script Date: 08/02/2015 20:42:18 ******/
ALTER TABLE [dbo].[Empleados_mstr]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_mstr_Departamentos_mstr_ID] FOREIGN KEY([dept_id])
REFERENCES [dbo].[Departamentos_mstr] ([dept_id])
GO
ALTER TABLE [dbo].[Empleados_mstr] CHECK CONSTRAINT [FK_Empleados_mstr_Departamentos_mstr_ID]
GO
