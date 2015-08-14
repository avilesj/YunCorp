USE [YunDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE spNuevoDepartamento @dept_desc varchar(50)

AS

SET NOCOUNT ON

INSERT INTO dbo.Departamentos_mstr
           (dept_desc)
     VALUES
           (@dept_desc)