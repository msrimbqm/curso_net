1-- cantidad suman pedidos tabla
select sum (cantidad)
from pedido;

--2 cantidad media pedidos
select avg (cantidad)
from pedido;

--3 numero de comerciales distintos aparecen en pedido

select  count (id_comercial)
from pedido;

--4 numer total clientes
select  count (id)
from cliente;

--5 mayor cantidad de pedido
select max (cantidad)
from pedido;

--6 menor cantidad
select min (cantidad)
from pedido;

--7 valor maximo de categoria por cada ciudad cliente
select max(categoria), ciudad
from cliente
group by ciudad;

--8 max pedido durante mismo dia por cliente

select max (cantidad) as [cantidad maxima],fecha,cliente.id, nombre,pellido1, apellido2
from cliente inner join pedido
on pedido.id_cliente=cliente.id
group by fecha,cliente.id,nombre, pellido1,apellido2 

--9 maximo valor de los pedidos realizados durante mismo dia, para  cada uno de los clientes, teniendo en cuenta que solo queremos superen 2000

select max (cantidad) as [cantidad maxima],fecha,cliente.id, nombre,pellido1, apellido2
from cliente inner join pedido
on pedido.id_cliente=cliente.id
group by fecha,cantidad,cliente.id,nombre, pellido1,apellido2
having cantidad>2000;

--10 calcula el maximo valor de los pedidos realizados para cada una de comerciales, durante la fecaha 2016-08-17

select max(cantidad) as maximo,nombre,apellido1
from pedido inner join comercial
on pedido.id_comercial=comercial.id
where fecha='20160817'
group by comercial.id,nombre,apellido1


--11 listado id cliente nombre, apellidos, numero total pedidos de cada cliente, puede haber cliente sin pedido, si asi debe poner 0
select cliente.id, nombre, pellido1,apellido2,count(id_cliente) as [numero de pedidos]
from cliente left join pedido
on pedido.id_cliente=cliente.id
group by cliente.id,nombre, pellido1,apellido2,id_cliente;
-- left join es porque saca todos los clientes ademas de los tenga relacion y como tienen salen cero

--12 lo mismo en el 2017
select cliente.id, nombre, pellido1,apellido2,count(id_cliente) as [numero de pedidos],fecha
from cliente left join pedido
on pedido.id_cliente=cliente.id
group by cliente.id,nombre, pellido1,apellido2,id_cliente,fecha
having fecha>='20170101' and fecha <='20171231';

--13 id cliente, nombre, apellido, valor maxima cantidad por cada cliente, cero si  no tiene iffullno funciona sqlserver menor 2012

select cliente.id,nombre, pellido1, max (cantidad) as maximo
from cliente left join pedido
on cliente.id=pedido.id_cliente
group by cliente.id,nombre,pellido1

--14 pedido de maximo valor
select max (cantidad), year(fecha)
from pedido
group by year(fecha)


--15 numero total de pedidos del año
select count(id) as numeropedidos, year(fecha)
from pedido
group by year(fecha);



