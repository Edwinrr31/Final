Create database Final

use Final

alter table Clientes
alter column Telefono float


create table Stock (
Id Int Primary Key,
Nombre varchar (30) not null,
Precio float not null, )


create table Facturacion (
Id Int Primary Key,
Cedula float not null,
Nombre varchar (30) not null,
Telefono float not null,
Email varchar (30) not null, )

create table Clientes (
Id Int Primary Key,
Cedula float not null,
Nombre varchar (30) not null,
Telefono float not null,
Email varchar (30) not null,
Categoria varchar (30) not null, )