CREATE DATABASE IF NOT EXISTS dbagenda;

USE dbagenda;

CREATE TABLE IF NOT EXISTS tb_usuarios(
nome VARCHAR(50) NOT NULL,
usuario VARCHAR(50) PRIMARY KEY,
telefone VARCHAR(15) NOT NULL,
senha VARCHAR(20) NOT NULL);

SELECT nome, usuario, telefone, senha FROM tb_usuarios;

CREATE TABLE IF NOT EXISTS tb_categoria(
cod_categoria INT AUTO_INCREMENT PRIMARY KEY,
categoria VARCHAR(40) NOT NULL,
usuario VARCHAR(50)
);
 
SELECT cod_categoria, categoria, usuario FROM tb_categoria;

SELECT cod_categoria AS 'Código', categoria AS 'Categoria', usuario AS 'Usuário' FROM tb_categoria;


CREATE TABLE IF NOT EXISTS tb_contatos(
 cod_contato INT AUTO_INCREMENT PRIMARY KEY,
 contato VARCHAR(50),
 telefone VARCHAR(15),
 categoria VARCHAR(40) );
 
 SELECT cod_contato, contato, telefone, categoria FROM tb_contatos;


SELECT * FROM mysql.USER;

CREATE TABLE IF NOT EXISTS tb_log(
cod_log INT AUTO_INCREMENT PRIMARY KEY,
usuario VARCHAR(50),
data_alteraçao DATETIME,
descriçao VARCHAR(1000) );

 select * from tb_log;
 
 
DELIMITER $$

CREATE TRIGGER TrInsertCategoria
BEFORE INSERT ON tb_categoria
FOR EACH ROW
BEGIN

SET NEW.usuario = USER();

END;
$$

DELIMITER ;

DELIMITER $$

CREATE TRIGGER TrCategoriaDelete
AFTER DELETE ON tb_categoria
FOR EACH ROW
BEGIN

INSERT INTO tb_log(usuario, data_alteraçao, descriçao)
			VALUES(USER(), CURRENT_TIMESTAMP(), CONCAT("A categoria ", OLD.categoria," foi deletada"));

END;
$$

DELIMITER ;


DELIMITER $$

CREATE TRIGGER TrCategoriaCreate
AFTER INSERT ON tb_categoria
FOR EACH ROW
BEGIN

INSERT INTO tb_log(usuario, data_alteraçao, descriçao)
			VALUES(USER(), CURRENT_TIMESTAMP(), CONCAT("A categoria ", new.categoria," foi criada"));

END;
$$

DELIMITER ;


DELIMITER $$

CREATE TRIGGER TrCategoriaInsert
AFTER UPDATE ON tb_categoria
FOR EACH ROW
BEGIN

INSERT INTO tb_log(usuario, data_alteraçao, descriçao)
			VALUES(USER(), CURRENT_TIMESTAMP(), CONCAT("A categoria ", new.categoria," foi atualizada"));
            
END;
$$

DELIMITER ;


DELIMITER $$

CREATE TRIGGER TrUsuarioSenha
AFTER UPDATE ON tb_usuarios
FOR EACH ROW
BEGIN

INSERT INTO tb_log(usuario, data_alteraçao, descriçao)
			VALUES(USER(), CURRENT_TIMESTAMP(), concat("A senha", NEW.senha," foi atualizada"));

END;

DELIMITER ;


DELIMITER $$

CREATE TRIGGER TrUsuarioDelete
AFTER DELETE ON tb_usuarios
FOR EACH ROW
BEGIN

INSERT INTO tb_log(usuario, data_alteraçao, descriçao)
			VALUES(USER(), CURRENT_TIMESTAMP(), CONCAT("O usuario ", OLD.usuario," foi deletado"));

END;
$$

DELIMITER ;



DELIMITER $$

CREATE TRIGGER TrContatoCreate
AFTER INSERT ON tb_contatos
FOR EACH ROW
BEGIN

INSERT INTO tb_log(usuario, data_alteraçao, descriçao)
			VALUES(USER(), CURRENT_TIMESTAMP(), CONCAT("A contato ", new.contato," foi criado"));

END;
$$

DELIMITER ;


DELIMITER $$

CREATE TRIGGER TrContatoUpdate
AFTER UPDATE ON tb_contatos
FOR EACH ROW
BEGIN

INSERT INTO tb_log(usuario, data_alteraçao, descriçao)
			VALUES(USER(), CURRENT_TIMESTAMP(), CONCAT("A contato ", new.contato," foi atualizado"));
            
END;
$$

DELIMITER ;


DELIMITER $$

CREATE TRIGGER TrContatoDelete
AFTER DELETE ON tb_contatos
FOR EACH ROW
BEGIN

INSERT INTO tb_log(usuario, data_alteraçao, descriçao)
			VALUES(USER(), CURRENT_TIMESTAMP(), CONCAT("O contato ", OLD.contato," foi deletado"));

END;
$$

DELIMITER ;