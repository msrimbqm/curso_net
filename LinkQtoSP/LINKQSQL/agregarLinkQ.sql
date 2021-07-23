create procedure insertarcliente
@Nombre varchar(50),
@Apellido1 varchar(50),
@Apellido2 varchar(50),
@telefono varchar(50)
AS
Insert Into Clientes(Nombre, Apellido1, Apellido2, Telefono) 
Values (@Nombre,@Apellido1,@Apellido2,@Telefono)
go

exec insertarcliente 'marcos','sastre','rodriguez','639300213';
exec insertarcliente 'Mabel','Madute','Buecos','655171819'