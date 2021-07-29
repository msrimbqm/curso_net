create Database simulacroSQL;

use simulacroSQL;


create table comercial(
id int PRIMARY KEY,
nombre varchar (100),
apellido1 varchar(100),
apellido2 varchar(100),
ciudad varchar(100),
comision decimal);

-- puede ser decimal(20,2) es dos enteros, dos decimales

create table pedido(
id int PRIMARY KEY,
cantidad decimal,
fecha date,
id_cliente int,
Id_comercial int);

create table cliente(
id int primary key,
nombre varchar(100),
pellido1 varchar(100),
apellido2 varchar(100),
ciudad varchar(100),
categoria int);

-- ahora relaciones
alter table pedido
add constraint FK_cliente
foreign key (id_cliente)
references cliente(id);


alter table pedido
add constraint FK_comercial
foreign key (id_comercial)
references comercial(id);



-- o los dos en en mismo alter, y tambie si equiero add constraint pk PRIMARY KEY SI NO LO PUSE


