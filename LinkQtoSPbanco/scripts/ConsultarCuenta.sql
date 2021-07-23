create procedure SPConsultaCuenta
@IdCuenta varchar(5)
AS
select *
from cliente inner join cuenta 
on cuenta.IdCliente=Cliente.IdCliente
inner join movimiento
on movimiento.Idcuenta=cuenta.IdCuenta
where Cuenta.IdCuenta=@IdCuenta;

exec SPConsultaCuenta '2';

