create database dbagenda;

use dbagenda;

create table tb_usuarios(
nome varchar(100) not null,
usuario varchar(50) primary key,
telefone varchar(15) not null,
senha varchar(20) not null);

select * from tb_usuarios;