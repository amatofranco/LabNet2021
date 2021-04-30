/* Franco Amato - Ejercicio SQL */

USE PracticaSQL
	GO

/* Consignas:
1- Recuperar lista de empleados */

SELECT EMP.LAST_NAME AS 'APELLIDO',
    EMP.FIRST_NAME AS 'NOMBRE'
	FROM TEST.EMPLOYEES AS EMP


/* 2- Recuperar id, apellido, fecha de contratación de los empleados.*/

SELECT EMP.ID AS 'ID',
	EMP.LAST_NAME AS 'APELLIDO',
	CAST (EMP.HIRE_DATE AS DATE) AS 'FECHA CONTRATACION' 
	FROM TEST.EMPLOYEES AS EMP

/* 3- Recuperar id, apellido, fecha de contratación, salario de los empleados. */

SELECT EMP.ID AS 'ID', 
	EMP.LAST_NAME AS 'APELLIDO',
	CAST (EMP.HIRE_DATE AS DATE) AS 'FECHA CONTRATACION',
	ISNULL(EMP.SALARY, 0) AS 'SALARIO'
	FROM TEST.EMPLOYEES AS EMP

/* 4- Recuperar id, apellido, fecha de contratación, salario anual de los empleados. */

SELECT EMP.ID AS 'ID',
	EMP.LAST_NAME AS 'APELLIDO',
	CAST (EMP.HIRE_DATE AS DATE) AS 'FECHA CONTRATACION',
	ISNULL(EMP.SALARY * 12, 0) AS 'SALARIO'
	FROM TEST.EMPLOYEES AS EMP

/* 5- Recuperar id, apellido y nombre, fecha de contratación, salario anual de los empleados. */

SELECT EMP.ID AS 'ID',
	   EMP.LAST_NAME + ' ' +
	   EMP.FIRST_NAME AS 'APELLIDO,NOMBRE',
	   CAST (EMP.HIRE_DATE AS DATE) AS 'FECHA CONTRATACION',
	   ISNULL(EMP.SALARY * 12, 0) AS 'SALARIO'
	   FROM TEST.EMPLOYEES AS EMP

/* 6- Recuperar lista de departamentos que tienen empleados:
6.a- Recuperar lista de departamentos de los empleados */

SELECT EMP.LAST_NAME AS 'APELLIDO',
    EMP.FIRST_NAME AS 'NOMBRE',
	DEP.DEPARTMENT_NAME AS 'DEPARTAMENTO'
	FROM TEST.EMPLOYEES AS EMP
	JOIN TEST.DEPARTMENTS AS DEP
	ON EMP.DEPARTMENT_ID = DEP.ID

/* 6.b- Recuperar lista no repetida de departamentos de los empleados */

SELECT DISTINCT DEP.ID AS 'ID',
	DEP.DEPARTMENT_NAME AS 'DEPARTAMENTO'
	FROM TEST.DEPARTMENTS AS DEP
	JOIN TEST.EMPLOYEES AS EMP
	ON DEP.ID = EMP.DEPARTMENT_ID


/* 7- Recuperar lista de empleados cuyo departamento sea 10.*/


SELECT EMP.LAST_NAME AS 'APELLIDO',
    EMP.FIRST_NAME AS 'NOMBRE',
	EMP.DEPARTMENT_ID AS 'ID DEPARTAMENTO'
	FROM TEST.EMPLOYEES AS EMP
	WHERE EMP.DEPARTMENT_ID = 10


/* 8- Recuperar lista de empleados cuyo salario sea menor a 2000. */

SELECT EMP.LAST_NAME AS 'APELLIDO',
    EMP.FIRST_NAME AS 'NOMBRE',
	EMP.SALARY AS 'SALARIO'
	FROM TEST.EMPLOYEES AS EMP
	WHERE EMP.SALARY < 2000

/* 9- Recuperar lista de empleados cuyo salario sea entre 1800 y 3000*/

SELECT EMP.LAST_NAME AS 'APELLIDO',
    EMP.FIRST_NAME AS 'NOMBRE',
	EMP.SALARY AS 'SALARIO'
	FROM TEST.EMPLOYEES AS EMP
	WHERE EMP.SALARY BETWEEN 1800 AND 3000

/* 10- Recuperar lista de empleados cuyo departamento sea 10 o 30 o 31.*/

SELECT EMP.LAST_NAME AS 'APELLIDO',
    EMP.FIRST_NAME AS 'NOMBRE',
	EMP.DEPARTMENT_ID AS 'ID DEPARTAMENTO'
	FROM TEST.EMPLOYEES AS EMP
	WHERE EMP.DEPARTMENT_ID IN (10, 30, 31)

/* 11- Recuperar lista de empleados cuyo apellido empiece con F.*/

SELECT EMP.LAST_NAME AS 'APELLIDO',
    EMP.FIRST_NAME AS 'NOMBRE'
	FROM TEST.EMPLOYEES AS EMP
	WHERE EMP.LAST_NAME LIKE 'F%'

/*
12- Recuperar lista de empleados cuyo job_id:
12.a- no haya sido definido
*/

SELECT EMP.LAST_NAME AS 'APELLIDO',
    EMP.FIRST_NAME AS 'NOMBRE',
	ISNULL (EMP.JOB_ID , 'Sin Id') AS 'JOB ID'
	FROM TEST.EMPLOYEES AS EMP
	WHERE EMP.JOB_ID IS NULL

/* 12.b- haya sido definido. */

SELECT EMP.LAST_NAME AS 'APELLIDO',
    EMP.FIRST_NAME AS 'NOMBRE',
	EMP.JOB_ID AS 'JOB ID'
	FROM TEST.EMPLOYEES AS EMP
	WHERE EMP.JOB_ID IS NOT NULL

/* 13- Recuperar lista de empleados cuyo job_id sea distinto de ‘AD_CTB’ */

SELECT EMP.LAST_NAME AS 'APELLIDO',
    EMP.FIRST_NAME AS 'NOMBRE',
	ISNULL (EMP.JOB_ID , 'Sin Id') AS 'JOB ID'
	FROM TEST.EMPLOYEES AS EMP
	WHERE EMP.JOB_ID <> 'AD_CTB' 
	OR EMP.JOB_ID IS NULL


/*14- Recuperar lista de empleados cuyo job_id sea distinto de ‘AD_CTB’ y cuyo salario sea mayor a 1900.*/

SELECT EMP.LAST_NAME AS 'APELLIDO',
    EMP.FIRST_NAME AS 'NOMBRE',
	ISNULL (EMP.JOB_ID , 'Sin Id') AS 'JOB ID',
	EMP.SALARY AS ' SALARIO'
	FROM TEST.EMPLOYEES AS EMP
	WHERE (EMP.JOB_ID <> 'AD_CTB') 
	AND EMP.SALARY > 1900

/*
15- Recuperar lista de empleados cuyo job_id sea distinto de ‘AD_CTB’ o cuyo salario sea mayor a 1900.*/

SELECT EMP.LAST_NAME AS 'APELLIDO',
    EMP.FIRST_NAME AS 'NOMBRE',
	ISNULL (EMP.JOB_ID , 'Sin Id') AS 'JOB ID',
	ISNULL (EMP.SALARY,0) AS ' SALARIO'
	FROM TEST.EMPLOYEES AS EMP
	WHERE (EMP.JOB_ID <> 'AD_CTB')
	OR EMP.SALARY > 1900

/* 16- Recuperar lista de empleados cuyo job_id sea ‘AD_CTB’ o ‘FQ_GRT’ (sin usar IN) y cuyo salario sea mayor a 1900.*/

SELECT EMP.LAST_NAME AS 'APELLIDO',
    EMP.FIRST_NAME AS 'NOMBRE',
	ISNULL (EMP.JOB_ID , 'Sin Id') AS 'JOB ID',
	ISNULL (EMP.SALARY,0) AS ' SALARIO'
	FROM TEST.EMPLOYEES AS EMP
    WHERE (EMP.JOB_ID = 'AD_CTB' OR EMP.JOB_ID = 'FQ_GRT') AND EMP.SALARY > 1900


/* 17- Recuperar empleados ordenados por fecha de ingreso (desde más viejo a más nuevo).*/

SELECT EMP.LAST_NAME AS 'APELLIDO',
    EMP.FIRST_NAME AS 'NOMBRE',
	CAST (EMP.HIRE_DATE AS DATE) AS 'FECHA CONTRATACION'
	FROM TEST.EMPLOYEES AS EMP
	ORDER BY HIRE_DATE ASC

/* 18- Recuperar empleados ordenados por fecha de ingreso (desde más nuevo a más viejo).*/

SELECT EMP.LAST_NAME AS 'APELLIDO',
    EMP.FIRST_NAME AS 'NOMBRE',
	CAST (EMP.HIRE_DATE AS DATE) AS 'FECHA CONTRATACION'
	FROM TEST.EMPLOYEES AS EMP
	ORDER BY HIRE_DATE DESC

/* 19- Recuperar empleados ordenados por fecha de ingreso descendente y apellido ascendente.*/

SELECT EMP.LAST_NAME AS 'APELLIDO',
    EMP.FIRST_NAME AS 'NOMBRE',
	CAST (EMP.HIRE_DATE AS DATE) AS 'FECHA CONTRATACION'
	FROM TEST.EMPLOYEES AS EMP
	ORDER BY HIRE_DATE DESC, LAST_NAME ASC

/* 20- Recuperar apellido y salario anual de empleados ordenados por salario anual. */

SELECT EMP.LAST_NAME AS 'APELLIDO',
	   ISNULL(EMP.SALARY * 12, 0) AS 'SALARIO ANUAL'
	   FROM TEST.EMPLOYEES AS EMP
	   ORDER BY [SALARIO ANUAL]

/* 21- Recuperar lista de empleados con la descripción del departamento al que cada uno pertenece.
Tip: evitar producto cartesiano. */

SELECT EMP.LAST_NAME AS 'APELLIDO',
    EMP.FIRST_NAME AS 'NOMBRE',
	ISNULL (DEP.DEPARTMENT_DESCRIPTION,'Sin descripcion') AS ' DESCRIPCION DEPARTAMENTO'
	FROM TEST.EMPLOYEES AS EMP, TEST.DEPARTMENTS DEP
	WHERE EMP.DEPARTMENT_ID = DEP.ID

/* 22- Seleccionar apellido de empleado y nombre de departamento */

SELECT EMP.LAST_NAME AS 'APELLIDO',
	DEP.DEPARTMENT_NAME AS ' NOMBRE DEPARTAMENTO'
	FROM TEST.EMPLOYEES AS EMP, TEST.DEPARTMENTS DEP
	WHERE EMP.DEPARTMENT_ID = DEP.ID


/* 23- Agregar id de empleado y id de departamento
Tip: desambiguar campos usando alias de tablas.*/

SELECT EMP.ID AS 'ID EMPLEADO',
    EMP.LAST_NAME AS 'APELLIDO',
	DEP.ID AS 'ID DEPARTAMENTO',
    DEP.DEPARTMENT_NAME AS 'DEPARTAMENTO'
	FROM TEST.EMPLOYEES AS EMP, TEST.DEPARTMENTS AS DEP
	WHERE EMP.DEPARTMENT_ID = DEP.ID

/*24- Recuperar lista de empleados con descipción de departamentos y ciudades.*/


SELECT EMP.LAST_NAME AS 'APELLIDO',
    EMP.FIRST_NAME AS 'NOMBRE',
	DEP.DEPARTMENT_NAME AS 'DEPARTAMENTO',
	ISNULL (DEP.DEPARTMENT_DESCRIPTION,'Sin descripcion') AS 'DESCRIPCION',
	LOC.CITY AS 'CIUDAD'
	FROM TEST.EMPLOYEES AS EMP, TEST.DEPARTMENTS AS DEP, TEST.LOCATIONS AS LOC
	WHERE EMP.DEPARTMENT_ID = DEP.ID 
	AND DEP.LOCATION_ID = LOC.ID


/* Uso de cláusula JOIN
25- Recuperar lista de empleados con la descripción del departamento al que cada uno pertenece.*/


SELECT EMP.LAST_NAME AS 'APELLIDO',
    EMP.FIRST_NAME AS 'NOMBRE',
	ISNULL (DEP.DEPARTMENT_DESCRIPTION,'Sin descripcion') AS ' DESCRIPCION DEPARTAMENTO'
	FROM TEST.EMPLOYEES AS EMP
	JOIN TEST.DEPARTMENTS AS DEP
	ON EMP.DEPARTMENT_ID = DEP.ID

/* 26- Recuperar lista de empleados con la descripción del departamento, tengan o no departamento asignado.*/

SELECT EMP.LAST_NAME AS 'APELLIDO',
    EMP.FIRST_NAME AS 'NOMBRE',
	ISNULL (DEP.DEPARTMENT_DESCRIPTION,'Sin descripcion') AS ' DESCRIPCION DEPARTAMENTO'
	FROM TEST.EMPLOYEES AS EMP
	LEFT JOIN TEST.DEPARTMENTS AS DEP
	ON EMP.DEPARTMENT_ID = DEP.ID

/*
27- Recuperar lista de departamentos con empleados de cada departamento, tengan o no empleados asociados.*/

SELECT DEP.DEPARTMENT_NAME AS 'DEPARTAMENTO',
    ISNULL (
    EMP.LAST_NAME + ' '
	+ EMP.FIRST_NAME, 'SIN EMPLEADOS') AS 'EMPLEADOS'
	FROM TEST.DEPARTMENTS AS DEP
	LEFT JOIN TEST.EMPLOYEES AS EMP
	ON DEP.ID = EMP.DEPARTMENT_ID

/* Selfjoin -  28- Recuperar lista de subordinados por cada manager */

SELECT  EMP1.LAST_NAME + ' '
	+ EMP1.FIRST_NAME AS 'Empleado',
	EMP2.LAST_NAME + ' '
	+ EMP2.FIRST_NAME AS 'Manager'
	FROM TEST.EMPLOYEES EMP1
	JOIN TEST.EMPLOYEES EMP2
	ON EMP1.MANAGER_ID = EMP2.ID

/* 29- Recuperar máximo salario de los empleados. */


SELECT EMP.SALARY AS 'Salario Maximo',
	SELECT EMP.LAST_NAME AS 'APELLIDO',
    EMP.FIRST_NAME AS 'NOMBRE',
	FROM TEST.EMPLOYEES EMP
	WHERE EMP.SALARY = 
						    (SELECT MAX (EMP.SALARY) 
							FROM TEST.EMPLOYEES EMP)
    GROUP BY EMP.LAST_NAME, EMP.FIRST_NAME, EMP.SALARY


/* 30- Recuperar máximo, mínimo, promedio, y suma total de salarios de los empleados.*/

SELECT MAX(EMP.SALARY) AS 'Salario Maximo', 
	MIN(EMP.SALARY) AS 'Salario Minimo', 
	AVG (EMP.SALARY) AS 'Promedio de Salario', 
	SUM (EMP.SALARY) AS 'Suma de Salarios'
	FROM TEST.EMPLOYEES EMP

/* 31- Recuperar máximo, mínimo, promedio, y suma total de fecha de contratación de los empleados.*/

SELECT MAX(CAST (EMP.HIRE_DATE AS DATE)) AS 'Maximo Fecha contratacion', 
	MIN(CAST (EMP.HIRE_DATE AS DATE)) AS ' Minimo Fecha contratacion', 
	CAST (AVG (CAST (EMP.HIRE_DATE AS INT)) AS DATETIME) AS 'Promedio Fecha contratacion', 
	CAST (SUM (CAST (EMP.HIRE_DATE AS INT)) AS DATETIME) AS 'Suma Fecha contratacion'
	FROM TEST.EMPLOYEES EMP


/* 32- Obtener la cantidad de empleados.*/

SELECT COUNT(EMP.ID) 
	AS 'Cantidad de Empleados'
	FROM TEST.EMPLOYEES EMP

/* 33- Obtener la cantidad de empleados cuyo departamento sea 10. */

SELECT COUNT(EMP.ID) 
	AS 'Cantidad de Empleados Departamento 10'
	FROM TEST.EMPLOYEES EMP
	WHERE EMP.DEPARTMENT_ID = 10

/* 34- Obtener la cantidad de empleados de cada departamento.*/

SELECT DEP.DEPARTMENT_NAME AS 'Departamento',
	COUNT(EMP.DEPARTMENT_ID) 
	AS 'Cantidad de Empleados'
	FROM TEST.DEPARTMENTS DEP
	LEFT JOIN TEST.EMPLOYEES EMP
	ON EMP.DEPARTMENT_ID = DEP.ID
	GROUP BY DEP.DEPARTMENT_NAME


/* 35- Obtener la cantidad de empleados por cada departamento y job. */


SELECT DEP.DEPARTMENT_NAME AS 'Departamento',
    ISNULL (JOB.JOB_NAME,'Sin datos') AS 'Trabajo',
	COUNT(EMP.JOB_ID) AS 'Cantidad de Empleados'
	FROM TEST.DEPARTMENTS DEP
	LEFT JOIN TEST.EMPLOYEES EMP
	ON EMP.DEPARTMENT_ID = DEP.ID
	LEFT JOIN TEST.JOBS JOB
	ON EMP.JOB_ID = JOB.ID
	GROUP BY DEPARTMENT_NAME, JOB_NAME
	ORDER BY DEPARTMENT_NAME


/* 36- Recuperar los departamentos y el salario promedio de cada departamento.*/

SELECT DEP.DEPARTMENT_NAME AS 'Departamento',
	ISNULL (AVG (EMP.SALARY),0) AS 'Salario Promedio'
	FROM TEST.DEPARTMENTS DEP
	LEFT JOIN TEST.EMPLOYEES EMP
	ON  DEP.ID = EMP.DEPARTMENT_ID
	GROUP BY DEPARTMENT_NAME

/* 37- Recuperar los departamentos y el salario promedio si es menor a 1200.*/

SELECT DEP.DEPARTMENT_NAME AS 'Departamento',
	ISNULL (AVG (EMP.SALARY),0) AS 'Salario Promedio'
	FROM TEST.DEPARTMENTS DEP
	LEFT JOIN TEST.EMPLOYEES EMP
	ON  DEP.ID = EMP.DEPARTMENT_ID
	GROUP BY DEPARTMENT_NAME
	HAVING AVG (EMP.SALARY)<1200

/* 38- Crear un nuevo departamento
38.a- Caso 1: Crear insert de todos los campos en orden. */

INSERT INTO TEST.DEPARTMENTS 
	VALUES (60,'Sistemas',1,'Desarrollo de aplicaciones')

/*
38.b- Caso 2: Crear insert de todos los campos en orden usando valores nulos.*/


INSERT INTO TEST.DEPARTMENTS 
	VALUES (61,'Transporte',2,NULL)


/* 38.c- Crear insert usando solamente los campos obligatorios.
Tip: Especificar lista de campos obligatorios.*/

INSERT INTO TEST.DEPARTMENTS
		(ID,
		DEPARTMENT_NAME,
		LOCATION_ID)
		VALUES (62,'Comunicacion',3)


/* 39- Crear un nuevo empleado basado en los datos de Gustavo Boulette:
- cambiando su nombre
- aumentando su sueldo en $200.
- blanqueando su manager */

INSERT INTO TEST.EMPLOYEES
			(ID, 
			FIRST_NAME, 
			LAST_NAME, 
			SALARY, 
			DEPARTMENT_ID,
			JOB_ID,
			HIRE_DATE,
			MANAGER_ID)

			SELECT  19 AS ID,
			'Roberto' AS FIRST_NAME,
			EMP.LAST_NAME,
			EMP.SALARY + 200,
			EMP.DEPARTMENT_ID,
			EMP.JOB_ID,
			EMP.HIRE_DATE,
			NULL AS MANAGER_ID

			FROM TEST.EMPLOYEES EMP
			WHERE EMP.FIRST_NAME = 'Gustavo'
			AND EMP.LAST_NAME = 'Boulette'


/* 40- Actualizar salario del empleado 10 a $1100. */

UPDATE TEST.EMPLOYEES 
	SET SALARY = 1100
	WHERE ID = 10

/* 41- Duplicar salario del empleado 11.*/


UPDATE TEST.EMPLOYEES 
	SET SALARY = SALARY * 2
	WHERE ID = 11

/* 42- Aumentar salario en un 10% a todos los empleados del departamento 40. */

UPDATE TEST.EMPLOYEES 
	SET SALARY = SALARY * 1.10
	WHERE DEPARTMENT_ID = 40

/* 43- Eliminar departamentos cuyo id sea mayor a 50.
Tip: hacer un select antes y después para verificar usando la misma condición que para el
delete.*/


SELECT ID, DEPARTMENT_NAME FROM TEST.DEPARTMENTS
	WHERE ID > 50

DELETE FROM TEST.DEPARTMENTS
	WHERE ID > 50


/*
44- Eliminar departamento 40. Tip: notar resultado de las restricciones de integridad.*/


SELECT ID, DEPARTMENT_NAME FROM TEST.DEPARTMENTS
	WHERE ID = 40

DELETE FROM TEST.DEPARTMENTS
	WHERE ID = 40;


/*  RESULTADO: No puede eliminarse el Departamento, al estar su ID referenciado
	en la tabla empleados, siendo el Departamento del Empleado (EMP_DEP) una FK.
	En base a esto, una opción seria eliminar la FK, teniendo en cuenta que traería
	problemas de referencias, realizando:

	ALTER TABLE TEST.EMPLOYEES
	DROP CONSTRAINT EMP_DEP
*/


/* 45 -  Crear la función fn_AntiguedadEmpleado; que retorne la antiguedad en años de cada
empleado donde el parametro de ingreso es el id del empleado */

	GO
CREATE FUNCTION TEST.fn_AntiguedadEmpleado (@id int)  
	RETURNS INT
	AS
	BEGIN 
	DECLARE @antiguedad INT
	SELECT @antiguedad = DATEDIFF (year, EMP.HIRE_DATE, GETDATE())
	FROM TEST.EMPLOYEES EMP
	WHERE EMP.ID = @id
    RETURN @antiguedad
	END
	GO

/* 46 - Crear el Procedimiento almacenado GetNombreAntiguedad; que retorne el primer
nombre y el apellido separados por una coma y en la segunda columna la antiguedad en año. Usar
la función creada en el punto anterior.
Ordenar por antiguedad descendiente (mas antiguo primero)*/

CREATE PROCEDURE GetNombreAntiguedad
	AS
SELECT EMP.FIRST_NAME + ',' +
	EMP.LAST_NAME ' NombreYApellido', 
	TEST.fn_AntiguedadEmpleado(EMP.ID) AS 'Antiguedad'
	FROM TEST.EMPLOYEES EMP
	GROUP BY LAST_NAME,FIRST_NAME, ID
	ORDER BY ANTIGUEDAD ASC
	GO

EXECUTE GetNombreAntiguedad
	GO

