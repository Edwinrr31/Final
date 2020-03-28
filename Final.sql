Create database Final

use Final

create table Stock (
Id Int Primary Key,
Nombre varchar (30) not null,
Precio int not null, )


create table Facturacion (
Id Int Primary Key,
Cedula int not null,
Nombre varchar (30) not null,
Telefono int not null,
Email varchar (30) not null, )

create table Clientes (
Id Int Primary Key,
Cedula int not null,
Nombre varchar (30) not null,
Telefono int not null,
Email varchar (30) not null,
Categoria varchar (30) not null, )