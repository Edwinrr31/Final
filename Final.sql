Create database Final

Use Final

select * from Stock

create table Stock (
Id Int Primary Key,
Nombre varchar (30) not null,
Precio varchar (30) not null, )

Alter table Stock
Add Fecha datetime not null


create table Facturacion (
Id Int Primary Key,
Cedula varchar (30) not null,
Nombre varchar (30) not null,
Telefono varchar (30) not null,
Email varchar (30) not null, )

create table Clientes (
Id Int Primary Key,
Cedula varchar (30) not null,
Nombre varchar (30) not null,
Telefono varchar (30) not null,
Email varchar (30) not null,
Categoria varchar (30) not null, )