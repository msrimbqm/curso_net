--1 devuelve id, nombre y apellidos clines con pedido, ordenado alf y eliminar repetidos
select distinct cliente.id, nombre, pellido1, apellido2
from pedido inner join cliente
on pedido.id_cliente=cliente.id
order by nombre asc;

--2 listado pedidos por cada cliente, todos datos, de los  clientes ordenados alfab
select  distinct *
from pedido inner join cliente
on pedido.id_cliente=cliente.id
order by nombre;

--3 listado pedidos, que tenga un comercial, datos pedidos , comerciales ordenados alfabeticamente
select pedido.*,comercial.*
from pedido inner join comercial
on pedido.id_comercial=comercial.id
order by nombre ASC;


--4 listado clientes con todsos los pedidos realizados  y datos comerciales asociados a cada pedido
select pedido.*, comercial.*,cliente.*
from pedido inner join comercial
on pedido.id_comercial=comercial.id
inner join cliente
on cliente.id=pedido.id_cliente;
-- de la tabla pedido dos inner join a las otras dos relacionadas - importante


--5 clientes pedidos año 2017  y cantidad entre 300 y 1000

select  cliente.*, pedido.fecha, pedido.cantidad
from pedido inner join cliente
on pedido.id_cliente=cliente.id
where pedido.cantidad >=300 and pedido.cantidad<=1000 and fecha>='20170101' and fecha <='20171231';

--6 nombre y apellidos comeciales algun pedido de maria santana Moreno

select distinct comercial.nombre, comercial.apellido1, comercial.apellido2
from pedido inner join comercial
on pedido.id_comercial=comercial.id
inner join cliente
on cliente.id=pedido.id_cliente
where cliente.nombre='María' and cliente.pellido1='Santana' and cliente.apellido2='Moreno';



--7 clientes nombre, algun pedido comercial daniel saez vega

select distinct cliente.nombre, cliente.pellido1, cliente.apellido2
from pedido inner join comercial
on pedido.id_comercial=comercial.id
inner join cliente
on cliente.id=pedido.id_cliente
where comercial.nombre='Daniel' and comercial.apellido1='Sáez' and comercial.apellido2='Vega';


