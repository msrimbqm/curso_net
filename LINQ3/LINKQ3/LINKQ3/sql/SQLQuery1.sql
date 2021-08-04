use Hucanet;
go
create table Pacientes(
Inscripcion int primary Key,
Nombre Varchar(50),
Apellidos varchar(50),
Sexo bit,
fecha date,
Direccion varchar(50),
NumeroSS varchar(20));

insert into Pacientes values (1, 'Marcos','Sastre',1,'20200121','Av Castilla','445644444');


