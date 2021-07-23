create procedure Buscarcliente
@Nombre varchar(50)
AS
select * from Clientes where Nombre like '%'+@Nombre+'%';


exec buscarcliente 'mabel'