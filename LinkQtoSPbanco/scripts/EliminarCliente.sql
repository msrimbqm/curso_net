-- elimnar cliente
Create Procedure SPEliminarCliente
@IdCliente varchar(5)
AS
Delete from Cliente
Where cliente.IdCliente=@IdCliente;

