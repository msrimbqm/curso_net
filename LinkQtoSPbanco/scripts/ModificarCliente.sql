-- procedimiento modificar cliente por idcliente
Create Procedure SPModificarCliente
@idCliente varchar(5),
@apellidos varchar(30),
@nombre varchar(30)
AS
Update Cliente
set idcliente=@IdCliente, apellidos=@apellidos, nombres=@nombre
Where IdCliente=@idCliente;




