-- script ejercicio linq 2 banco, cuentas, apuntes

-- creo base de datos-----------------------------------------------------------------
Create DataBase BancoBD
GO
use BancoBD

-- creo tablas sin relaciones-----------------------------------------------------
Create TABLE Cliente(
IdCliente varchar(5) PRIMARY KEY,
Apellidos varchar(30),
Nombres varchar(30),
);

Create TABLE Cuenta(
IdCuenta varchar(5) PRIMARY KEY,
IdCliente varchar(5),
Saldo float,
Divisa varchar(20)
);

Create TABLE Movimiento(
IdMovimiento varchar(5) PRIMARY KEY,
Idcuenta varchar(5),
Tipo varchar(20),
Monto float,
Fecha date
);


--ahora relaciones
ALTER table Cuenta
ADD CONSTRAINT FK_Cliente
FOREIGN KEY (IdCliente)
REFERENCES Cliente(IDCliente);


ALTER table Movimiento
ADD CONSTRAINT FK_Cuenta
FOREIGN KEY (IdCuenta)
REFERENCES Cuenta(IDCuenta);

--ahora inserta datos en la tabla------------------------------------------------


insert into cliente values ('1','Sastre', 'Mariano');
insert into cliente values ('2','Rodriguez','Marcos');
insert into cliente values ('3','Andin','Manolo');
insert into cliente values ('4','PEREZ','Mary');

insert into cuenta values('1','1',555,'Euros');
insert into cuenta values('2','1',777,'Euros');
insert into cuenta values('3','2',999,'Euros');

insert into Movimiento values ('1','1','Adeudo',22,'20211215');
insert into Movimiento values ('2','2','Adeudo',99,'20210215');
insert into Movimiento values('3','3','Abono',123,'20210903');
insert into Movimiento values('4','3','Abono',44,'20210803');


-- Consultas------------------------------------------------------------------

--1 cuentas de los clientes cuyo apellido empiece por S
select *
from cuenta inner join cliente
on cuenta.IdCliente=cliente.IdCliente
where cliente.Apellidos like 'S%';

--2 tdos movimientos  de cuentas en divisa euro del cliente de apellidos Sastre
select *
from cliente inner join cuenta 
on cuenta.IdCliente=Cliente.IdCliente
inner join movimiento
on movimiento.Idcuenta=cuenta.IdCuenta
where cliente.Apellidos='Sastre' and Divisa='Euros'

--3 Movimentos del cliente Sastre en euros , ordenados por numero de cuenta

select *
from cliente inner join cuenta 
on cuenta.IdCliente=Cliente.IdCliente
inner join movimiento
on movimiento.Idcuenta=cuenta.IdCuenta
where cliente.Apellidos='Sastre' and Divisa='Euros'
order by Cuenta.Idcuenta;


-- 4 Consultar movimientos de Sastre y los de Rodriguez


select *
from cliente inner join cuenta 
on cuenta.IdCliente=Cliente.IdCliente
inner join movimiento
on movimiento.Idcuenta=cuenta.IdCuenta
where cliente.Apellidos='Sastre' or cliente.Apellidos='Rodriguez'
order by Cuenta.Idcuenta;



























-- Procedimientos









