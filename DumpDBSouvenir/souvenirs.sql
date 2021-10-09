CREATE DATABASE IF NOT EXISTS souvenirsdbmm CHARSET utf8mb4;
USE souvenirsdbmm;

CREATE TABLE usuarios(
id_user INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
user_name VARCHAR(50) NOT NULL,
password VARCHAR(255) NOT NULL
);

CREATE TABLE souvenirs(
id_souvenir INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
nombre VARCHAR(50) NOT NULL,
descripcion VARCHAR(100) NOT NULL,
stock INT NOT NULL,
precio DECIMAL(7,2) UNSIGNED NOT NULL, 
fecha_de_alta DATETIME NOT NULL
);

CREATE TABLE compras(
id_compra INT UNSIGNED,
fecha_compra DATETIME NOT NULL,
producto VARCHAR(50),
cantidad INT,
PRIMARY KEY(id_compra),
FOREIGN KEY (id_compra) REFERENCES souvenirs(id_souvenir),
FOREIGN KEY (id_compra) REFERENCES usuarios(id_user)
);



