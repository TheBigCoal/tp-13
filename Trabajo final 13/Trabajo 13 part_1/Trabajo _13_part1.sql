create database trabajo_13
use trabajo_13

create table Registro
(id_registro int identity(1,1),
nombre_usuario varchar (250),
contrase�a varchar(250),
constraint pk_Registro primary key (id_registro),
)

insert into Registro (nombre_usuario, contrase�a)
values ('Luis','2345'),
		('Ezequiel','3456'),
		('Polo','4567'),
		('Maxi','5678'),
		('test','test'),
		('joan','1234');
		

select * from Registro