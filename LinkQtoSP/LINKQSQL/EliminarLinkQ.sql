create procedure EliminarCliente
@Nombre varchar(50)
AS

Delete from Clientes 
Where Nombre=@Nombre


exec EliminarCliente 'Marcos';


