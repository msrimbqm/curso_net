create procedure SPDevolverID
@cliente varchar(30)
AS
select Idcliente
from cliente
where IdCliente=@cliente;



exec spDevolverId '1';