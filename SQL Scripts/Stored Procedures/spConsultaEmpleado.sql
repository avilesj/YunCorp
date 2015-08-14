USE [YunDB]
GO
/****** Object:  StoredProcedure [dbo].[spConsultaEmpleado]    Script Date: 08/02/2015 20:14:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spConsultaEmpleado] @emp_nombre varchar(50), @emp_apellido varchar(50),
								@emp_cedula varchar(11), @dept_id int, @emp_ext nchar(10),
								@emp_flota nchar(10)

AS

SET NOCOUNT ON

SELECT Empleados_mstr.emp_nombre,
	Empleados_mstr.emp_apellido,
	Empleados_mstr.emp_cedula,
	Empleados_mstr.emp_ext,
	Empleados_mstr.emp_flota,
	Departamentos_mstr.dept_desc FROM Empleados_mstr
	INNER JOIN Departamentos_mstr
	ON Empleados_mstr.dept_id = Departamentos_mstr.dept_id
	WHERE Empleados_mstr.emp_nombre = @emp_nombre 
	OR
	Empleados_mstr.emp_apellido = @emp_apellido
	OR
	Empleados_mstr.emp_cedula = @emp_cedula
	OR
	Empleados_mstr.emp_ext = @emp_ext
	OR
	Empleados_mstr.emp_flota = @emp_flota