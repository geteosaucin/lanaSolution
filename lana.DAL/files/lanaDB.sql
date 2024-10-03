create database lanaDB;
use lanaDB;
create table TipoUsuario(
IdTipoUsuario int primary key identity not null,
DescricaoTipoUsuario varchar(150) not null
);

INSERT INTO TipoUsuario(DescricaoTipoUsuario) VALUES ('Administrador'),('Outros');

select * from TipoUsuario;


create table Usuario(
IdUsuario int primary key identity not null,
NomeUsuario varchar(150) not null,
SenhaUsuario char (6) not null,
DtNascUsuario date not null,
UrlImgUsuario varchar (max) not null,
TpUsuario int,
foreign key (TpUsuario) references TipoUsuario(IdTipoUsuario)
);

insert into Usuario (NomeUsuario,SenhaUsuario,DtNascUsuario,UrlImgUsuario,TpUsuario) values 
('uil','uil123','1980-02-29','~/img/uil.jpg',1),
('robsu','rob123','1986-10-20','~/img/robsu.jpg',2),
('sataneia','sat123','2000-11-25','~/img/sataneia.jpg',2),
('mia','mia123','2001-06-12','~/img/mia.jpg',1);

select * from usuario;

select nomeusuario, senhausuario, dtnascusuario,urlimgusuario,descricaotipousuario
from usuario inner join TipoUsuario
on tpusuario = idtipousuario;

select * from usuario where nomeusuario = 'uil' and senhausuario = 'uil123';


create table Categoria(
IdCategoria int primary key identity not null,
DescricaoCategoria varchar(150) not null
);

INSERT INTO Categoria (DescricaoCategoria) VALUES ('Eletronico'),('Eletrodomestico'),('Quiquilharia');

create table Produto(
IdProduto int primary key identity not null,
NomeProduto varchar(150) not null,
DescricaoProduto varchar (800) not null,
UrlImgProduto varchar (max) not null,
EstoqueProduto int not null,
EmLancamento bit not null,
PrecoProduto decimal (10,2) not null,
CategoriaId int,
foreign key (CategoriaId) references Categoria(IdCategoria)
);

INSERT INTO Produto (NomeProduto,DescricaoProduto,UrlImgProduto,EstoqueProduto,EmLancamento,PrecoProduto,CategoriaId)
VALUES ('Fone de ouvido','Blutufi 5.1 com microfone tópi gueimer com erregebê','~/img/fone.jpeg',40,1,200.00,1),
('Érfraier','Blutufi 6.0 com uaifai 10 litros','~/img/erfraier.jpeg',10,1,500.00,2),
('Relógio do zezé di camargo e lucianu','Relógio de merda com referencia a dois bostas','~/img/relogio.jpeg',1,1,120.00,3);

select * from produto;