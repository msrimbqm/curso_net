create procedure APbuscarcodigo
@codigo int
as
select * from alumnos
where codigo=@codigo;

exec APbuscarcodigo 1;




create procedure APbuscardni
@dni varchar(10)
as
select * from alumnos
where DNI=@dni

exec APbuscardni '10890379'

create procedure APcontardni
@dni varchar(10)
as
select count (*) from alumnos
where DNI=@dni
