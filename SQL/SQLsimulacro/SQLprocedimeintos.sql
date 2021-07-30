-- repasando stored procedures (4 PROCEDIENTOS)
-- ALTAS, BAJAS,MODIFICACIONES,CONSULTAS

CREATE PROCEDURE SP_ALTACLIENTE
@id int,
@Nombre varchar(100),
@Apellido1 varchar(100),
@Apellido2 varchar(100),
@Ciudad varchar(100),
@Categoria int
AS
INSERT INTO cliente (id,Nombre,pellido1,Apellido2,Ciudad,Categoria)
VALUES (@id,@Nombre,@Apellido1,@Apellido2,@Ciudad,@Categoria);

-- linea probar procedimiento
--exec SP_ALTACLIENTE 33,'Marcos','Sastre','Rodriguez','Gijon',3;

CREATE PROCEDURE SP_BAJACLIENTE
@id int
AS
DELETE FROM cliente where id=@id;

-- exec SP_BAJACLIENTE 33;
exec SP_BAJACLIENTE 7;



CREATE PROCEDURE SP_MODIFICARCLIENTE
@id int,
@Nombre varchar(100),
@Apellido1 varchar(100),
@Apellido2 varchar(100),
@Ciudad varchar(100),
@Categoria int
AS
UPDATE cliente 
SET id=@id,Nombre=@Nombre,pellido1=@Apellido1,Apellido2=@Apellido2,Ciudad=@Ciudad,Categoria=@Categoria
where id=@id;

--execute SP_MODIFICARCLIENTE 33,'Marculin','Sastre','Rodriguez','Gijon',3;


CREATE PROCEDURE SP_CONSULTACLIENTE
@id int
AS
Select *
From cliente
Where id=@id
-- o where id like '%@id%'si fuera para cadenas texto

execute sp_consultacliente 2

 
-- para relacion y delete rule en cascada, insert and update especification esquema tabla sql rule








