create database baseusuarios;
use baseusuarios;


create table usuario(
CodUsu int auto_increment,
nombre varchar (20),
pass varchar (15),
constraint pk_usuario primary key (CodUsu)
);

CREATE TABLE Cliente (
    id_cliente INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(50),
    apellido VARCHAR(50),
    dni VARCHAR(20),
    mail VARCHAR(50),
    telefono VARCHAR(20),
    apto_fisico BOOLEAN
);

CREATE TABLE Socio (
    id_socio INT AUTO_INCREMENT PRIMARY KEY,
    id_cliente INT,
    carnet_entregado BOOLEAN,
    cuota_mensual DECIMAL(10, 2),
    estado_pago BOOLEAN,
    FOREIGN KEY (id_cliente) REFERENCES Cliente(id)
);

CREATE TABLE NoSocio (
    id_nosocio INT AUTO_INCREMENT PRIMARY KEY,
    id_cliente INT,
    pago_diario DECIMAL(10, 2),
    FOREIGN KEY (id_cliente) REFERENCES Cliente(id)
);

CREATE TABLE Actividad (
    id_actividad INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(50),
    dia VARCHAR(10),
    horario VARCHAR(10),
    monto DECIMAL(10, 2)
);

CREATE TABLE Cuota (
    id_cuota INT AUTO_INCREMENT PRIMARY KEY,
    id_socio INT,
    monto DECIMAL(10, 2),
    fecha_vencimiento DATE,
    FOREIGN KEY (id_socio) REFERENCES Socio(id_socio)
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

-- Stored Procedure para AgregarSocio
DELIMITER //

CREATE PROCEDURE AgregarSocio(
    IN p_nombre VARCHAR(50),
    IN p_apellido VARCHAR(50),
    IN p_dni VARCHAR(20),
    IN p_mail VARCHAR(50),
    IN p_telefono VARCHAR(20),
    IN p_apto_fisico BOOLEAN,
    IN p_cuota_mensual DECIMAL(10,2),
    IN p_carnet_entregado BOOLEAN, -- Agregado para el carnet
    IN p_estado_pago BOOLEAN        -- Agregado para el estado de pago
)
BEGIN
    -- Declarar la variable para almacenar el ID del cliente
    DECLARE id_cliente INT;

    -- Insertar en la tabla Cliente
    INSERT INTO Cliente (nombre, apellido, dni, mail, telefono, apto_fisico) 
    VALUES (p_nombre, p_apellido, p_dni, p_mail, p_telefono, p_apto_fisico);
    
    -- Obtener el ID del último cliente insertado
    SET id_cliente = LAST_INSERT_ID();
    
    -- Insertar en la tabla Socio
    INSERT INTO Socio (id_cliente, carnet_entregado, cuota_mensual, estado_pago) 
    VALUES (id_cliente, p_carnet_entregado, p_cuota_mensual, p_estado_pago);
END //


DELIMITER ;

