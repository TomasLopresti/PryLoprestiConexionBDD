CREATE DATABASE Comercio;

USE Comercio;

CREATE TABLE Productos (
    Codigo INT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Descripcion VARCHAR(255),
    Precio DECIMAL(10, 2) NOT NULL,
    Stock INT NOT NULL,
    Categoria VARCHAR(50) NOT NULL
);

INSERT INTO Productos (Codigo, Nombre, Descripcion, Precio, Stock, Categoria)
VALUES
    (1, 'Televisor LED 32"', 'Pantalla LED de 32 pulgadas', 350.00, 15, 'Electronicos'),
    (2, 'Alfajor Rasta', 'Alfajor Rasta Negro x70gr', 1.50, 200, 'Alimentos'),
    (3, 'Silla de Oficina', 'C�moda silla ergon�mica para oficina', 60.00, 30, 'Bazar/Librer�a'),
    (4, 'Smartphone Samsung Galaxy S21', 'Tel�fono m�vil con c�mara de 108MP', 600.00, 25, 'Electronicos'),
    (5, 'Carolina Herrera Very Good Girl', 'Perfume Carolina Herrera aroma Floral Frutal', 165.00, 50, 'Perfumes'),
    (6, 'Detergente Cif', 'Detergente Cif BioActive Lima x300ml', 25.00, 35, 'Limpieza');

	CREATE TABLE Contactos (
		ID INT PRIMARY KEY,
		Email VARCHAR(100) NOT NULL,
		Telefono VARCHAR(20) NOT NULL
);
INSERT INTO Contactos (ID, Email, Telefono) 
VALUES 
    (1, 'juan.perez@email.com', '+5493511234567'),
    (2, 'maria.gomez@email.com', '+5493517654321'),
    (3, 'pedro.lopez@email.com', '+5493519876543');

	CREATE TABLE usuario (
		id INT PRIMARY KEY IDENTITY(1,1),
		usuario VARCHAR(50) NOT NULL,
		contrase�a VARCHAR(50) NOT NULL
);
INSERT INTO usuario (usuario, contrase�a) VALUES
('tomas', '1234'),
('pedro', 'pass456'),
('juan', 'profe123');