ALTER PROCEDURE spEliminarDepartamento @dept_id int

AS

BEGIN
DELETE FROM Departamentos_mstr WHERE dept_id = @dept_id
END