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

SELECT cod_categoria AS 'Código', categoria AS 'Categoria' FROM tb_categoria;

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

SET NEW.usuario = CURRENT_USER();

END;
$$

DELIMITER ;


DELIMITER $$

CREATE TRIGGER TrLogCategoriaDelete
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
