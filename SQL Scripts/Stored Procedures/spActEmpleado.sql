SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE spActEmpleado @emp_nombre varchar(50), @emp_apellido varchar(50),
								@emp_cedula varchar(11), @dept_id int, @emp_ext nchar(10),
								@emp_flota nchar(10), @emp_id int

AS

UPDATE Empleados_mstr
SET emp_nombre = @emp_nombre, emp_apellido = @emp_apellido,
	emp_cedula = @emp_cedula, dept_id = @dept_id,
	emp_ext = @emp_ext, emp_flota = @emp_flota
WHERE emp_id = @emp_id

GO
