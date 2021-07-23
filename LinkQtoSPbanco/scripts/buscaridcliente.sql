create procedure SPBuscarporId
@id varchar(5)
as
select * from Cliente
where IdCliente   like '%'+@id+'%';

exec SPBuscarporId '3';


-----------------------------------------------------------------


create procedure SPBuscarporNombre
@nombre varchar(30)
as
select * from Cliente
where  Cliente.Nombres like '%'+@nombre+'%';

exec SPBuscarporNombre 'Ma';

--////////////////////////////////////////////////////////////////////////
create procedure SPBuscarporApellido

@apellido varchar(30)
as
select * from Cliente
where  Cliente.Apellidos like '%'+@apellido+'%';

exec SPBuscarporApellido 'Sas';







exec spbuscarporid '3'