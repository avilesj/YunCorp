USE [YunDB]
GO
/****** Object:  StoredProcedure [dbo].[spEliminarEmpleado]    Script Date: 08/02/2015 21:47:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spEliminarEmpleado] @emp_id int

AS

BEGIN
DELETE FROM Empleados_mstr WHERE emp_id = @emp_id
END