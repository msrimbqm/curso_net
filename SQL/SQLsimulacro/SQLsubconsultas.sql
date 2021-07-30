--1 devuelve los pedidos  de de adela salas diez sin inner join

select * from pedido
where id_cliente=(select id from cliente where nombre='Adela' and pellido1='Salas' and apellido2='Díaz');

--2 numero de pedidos comercial daniel
select count(id)
from pedido
where Id_comercial=(select id from comercial where nombre='Daniel' and apellido1='Sáez' and apellido2='Vega');

--3 datos cliente con el pedido mas caro del 2019
select * 
from cliente 
where id=(select top 1 id_cliente from pedido where year(fecha)='2019' order by cantidad desc )




--4 fecha y cantidad del pedio de menor valor realido por pepe ruiz santana

select top 1 fecha, cantidad from
pedido inner join cliente
on pedido.id_cliente=cliente.id
where nombre='pepe' and pellido1='Ruiz' and apellido2='Santana'
order by cantidad asc;



--5 datos clientes y pedidos, pedidos en 2017 con un valor mayor de o igual al valor medio de los pedidos realizados ese año

select cliente.*, pedido.*
from cliente inner join pedido
on cliente.id=pedido.id_cliente
where year(fecha)='2017' and cantidad>=(select avg(cantidad) from pedido where year(fecha)='2017');





