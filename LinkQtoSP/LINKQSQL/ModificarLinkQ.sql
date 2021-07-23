create procedure Modificarcliente
@Nombre varchar(50),
@Apellido1 varchar(50),
@Apellido2 varchar(50),
@telefono varchar(50)
AS

update Clientes
set Nombre=@Nombre, Apellido1=@Apellido1,Apellido2=@Apellido2,Telefono=@telefono
Where Nombre=@Nombre

exec Modificarcliente 'Marcos','Suarez','Perez',123456789




