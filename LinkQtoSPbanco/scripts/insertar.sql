-- Crear procedimiento almacenado  para añadir clientes

create procedure SPInsertarCliente
@idcliente varchar(5),
@apellidos varchar(30),
@nombre varchar(30)
AS
Insert into Cliente(IdCliente, Apellidos, Nombres) 
values (@idcliente, @apellidos, @nombre)

exec SPInsertarCliente '5','Gavela','Miguel';

