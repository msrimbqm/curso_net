-- consultas sobre una tabla
--1 todos pedidos ordenados por fecha y los mas recientes primero
select *
from pedido
order by fecha DESC;

--2 devuelve todos los datos de los pedidos de mayor valorlor 2 mayores
select top (2)  *
from pedido
order by cantidad desc;

--3 lista id clientes, que tenga algun pedo no repetidos
select distinct id_cliente
from pedido;

--4 pedidos del 2017 cantidad mayor de 500
select * 
from pedido
where cantidad>500 and fecha>='20170101' and fecha <= '20171231';
--o year(fecha)='2017'
-- o where fecha between '20170101' and '20171231'



--5 nombre y eplldios comerciales con comision entre 0.05 y 0.11
select nombre, apellido1, apellido2,comision
from comercial
where comision >=0.05 and comision<=0.11;
-- comision between 0.05 and 0.11

--6 comision mayor en tabla comercial
select top 1 comision
from comercial
order by comision desc;

--7 id, nombre y apellido  clientes cuyo apellido no es null, ordenado alfabeeticamnte por apellidos, nombre
select id, nombre, pellido1
from cliente
where apellido2 is not null
order by pellido1, apellido2, nombre asc;

--8 devuelve un listado nombres clientes que empiezan por A y terminan por N, y los que empiezen por P, ordenado alfabeticamnte
select nombre
from cliente
where nombre like 'A%n' or nombre like 'P%'
order by nombre asc;

--9 listando nombre comerciales que no empiezen por A ordenado
select nombre
from cliente
where nombre not like 'A%' 
order by nombre asc;

--10 devuelve listado con los nombres comercailes que termimen por el o O, quitar repetidos
select distinct nombre 
from comercial
where nombre like '%O';












