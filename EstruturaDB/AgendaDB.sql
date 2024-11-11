create database dbagenda;

use dbagenda;

create table if not exists tb_usuarios(
nome varchar(100) not null,
usuario varchar(50) primary key,
telefone varchar(15) not null,
senha varchar(20) not null);

select nome, usuario, telefone, senha from tb_usuarios;

create table if not exists tb_categoria(
cod_categoria int auto_increment primary key,
categoria varchar(40) not null);
 
select cod_categoria, categoria from tb_categoria;

select cod_categoria AS 'Código', categoria AS 'Categoria' from tb_categoria;

 