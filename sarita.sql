create database SARITA;
USE SARITA;

create table producto( 
id_prod int primary key  auto_increment,-- Identificador del producto
nom_prod varchar(40) unique not null,-- Nombre del producto 
pre_prod double not null, -- precio del producto
fecha_cad date not null,
cantidad int not null
);

create table pedido(
id_ped int primary key auto_increment,
total double not null,
fecha_pedido date not null
);

create table ingresos(
id_ing int primary key auto_increment,
fecha_consulta date not null
);

create table reporte(
id_reporte int primary key auto_increment,
fecha date not null,
prod int not null,
foreign key(prod)references producto(id_prod) on update cascade on delete cascade
);

create table cantidad_pedido(
id_cp int primary key auto_increment,
pedido_cp int  not null,-- id del pedido
producto_cp int not null,-- id del producto
cantidad int not null,
coste double not null,
foreign key(pedido_cp)references pedido(id_ped) on update cascade on delete cascade,
foreign key(producto_cp)references producto(id_prod) on update cascade on delete cascade
);

create table ingresos_pedido(
id_ip int primary key auto_increment,
saldo double,
ingresos_ip int not null,
pedido_ip int not null,
foreign key(pedido_ip)references pedido(id_ped) on update cascade on delete cascade,
foreign key(ingresos_ip)references ingresos(id_ing) on update cascade on delete cascade
);



-- Procediminetos 

-- **PRODUCTOS**
drop procedure if exists res_prod;
delimiter $$
create procedure res_prod(
in nombre varchar(40),
in precio double,
in cad date,
in cantidad int
) begin
    insert into producto(nombre,precio, cad, cantidad)values(nom_prod,pre_prod,fecha_cad,cantidad);
end $$
delimiter ;

drop procedure if exists delete_prod;
delimiter $$
create procedure delete_prod(
in nombre varchar(40))
	begin
	 delete from producto where nombre=nom_prod;
	end $$
    delimiter ;
    
drop procedure if exists mod_prod;
delimiter $$
create procedure mod_prod(
in id int,
in nombre varchar(40),
in precio double,
in cad date,
in cant int
)
begin
 update producto set pre_prod=precio, fecha_cad=cad, cantidad=cant where id_prod=id;
 end $$
delimiter ;
    
    
insert into producto(nom_prod,pre_prod,fecha_cad,cantidad) values('Tortillas',28.00,'2023-08-13',20);
    