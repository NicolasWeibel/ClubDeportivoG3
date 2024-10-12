drop database if exists baseusuarios;
create database baseusuarios;
use baseusuarios;


create table usuario(
CodUsu int auto_increment,
nombre varchar (20),
pass varchar (15),
constraint pk_usuario primary key (CodUsu)
);

insert into usuario(nombre,pass) values
('prueba','1234');


/* se cambia el delimitador de linea para poder almacenar en
el sistema gestor el código del procedimiento
Se puede utilizar cualquier caracater 
*************************************************   */

DELIMITER //

CREATE PROCEDURE IngresoLogin(IN Usu VARCHAR(20), IN Pass VARCHAR(15))
BEGIN
  SELECT nombre, pass
  FROM usuario u 
  WHERE u.nombre = Usu AND u.pass = Pass;
END //

DELIMITER ;
