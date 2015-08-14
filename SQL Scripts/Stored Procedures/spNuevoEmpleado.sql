USE [YunDB]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE spNuevoEmpleado @emp_nombre varchar(50), @emp_apellido varchar(50),
								@emp_cedula varchar(11), @dept_id int, @emp_ext nchar(10),
								@emp_flota nchar(10)

AS

SET NOCOUNT ON

-- 1 - Declare variables

-- 2 - Initialize variables

-- 3 - Execute INSERT command
INSERT INTO dbo.Empleados_mstr
           (emp_nombre,
           emp_apellido,
           emp_cedula,
           dept_id,
           emp_ext,
           emp_flota)
     VALUES
           (@emp_nombre,
			@emp_apellido,
			@emp_cedula,
			@dept_id,
			@emp_ext,
			@emp_flota)
