create table Articulos(
	ArticuloId int identity (1,1) primary key,
	Descripcion varchar(30),
	Existencia int,
	Precio int
)

create table Ventas(
	VentaId int identity (1,1) primary key,
	Fecha varchar(20),
	Monto int
)

create table VentasDetalle(
	Id int identity (1,1) primary key,
	VentaId int references Ventas(VentaId),
	ArticuloId int references Articulos(ArticuloId),
	Cantidad int,
	Precio int
)