create procedure SPBuscarporId
@id varchar(5)
as
select * from cliente 
where IdCliente=@id;