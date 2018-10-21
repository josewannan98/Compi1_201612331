use UsuariosCBC;

create Table Usuarios
(
    ID_USUARIO int NOT NULL PRIMARY KEY IDENTITY(1,1),
	NOMBRE varchar(100) NOT NULL,
	APELLIDO varchar(100) NOT NULL,
	CONTRASENA varchar(50) NOT NULL,
	DPI int NOT NULL,
	CORREO varchar(50) NOT NULL
);


Create Table Chat
(
	ID_CHAT int NOT NULL PRIMARY KEY IDENTITY(1,1),
	ID_USUARIO int FOREIGN KEY references Usuarios(ID_USUARIO)
);

Create Table Mensajes
(
	ID_MENSAJE int NOT NULL PRIMARY KEY IDENTITY(1,1),
	MENSAJE varchar(100) NOT NULL,
	RECIBE int NOT NULL,
	ID_CHAT int FOREIGN KEY references Chat(ID_CHAT)
);