-- Creación de la base de datos
CREATE DATABASE dbEddieShirt;

-- Selección de la base de datos
USE dbEddieShirt;
select * from usuario;
-- Creación de la entidad USUARIO
CREATE TABLE Usuario(
	IdUsuario int primary key identity,
	NombreUsuario varchar(50),
	ApellidoPaterno varchar(50),
	ApellidoMaterno varchar(50),
	NombreCompleto varchar(50),
	Correo varchar(50),
	Clave varchar(50),
	FechaRegistro  datetime default getdate()
)
-- Creación de la entidad Cliente
CREATE TABLE Cliente (
    IdCliente INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(50) NOT NULL,
	APaterno VARCHAR(50) NOT NULL,
	AMaterno VARCHAR(50) NOT NULL,
    Correo VARCHAR(50) NOT NULL,
    Telefono VARCHAR(15) NOT NULL,
	Direccion VARCHAR(150) NOT NULL,
)

-- Creación de la entidad Talla
CREATE TABLE TallaPrenda (
    IdTallaPrenda INT PRIMARY KEY IDENTITY(1,1),
    Descripcion VARCHAR(10) NOT NULL
);

-- Creación de la entidad Color
CREATE TABLE ColorPrenda (
    IdColorPrenda INT PRIMARY KEY IDENTITY(1,1),
    Descripcion VARCHAR(20) NOT NULL
);

-- Creación de la entidad TipoPrenda
CREATE TABLE TipoPrenda (
    IdTipoPrenda INT PRIMARY KEY IDENTITY(1,1),
    Descripcion VARCHAR(50) NOT NULL
);

-- Creación de la entidad Prenda
CREATE TABLE Prenda (
    IdPrenda INT PRIMARY KEY IDENTITY(1,1),
    PrecioCompra DECIMAL(10,2) NOT NULL,
	Stock int not null default 0,
    IdTallaPrenda INT NOT NULL,
    IdColorPrenda INT NOT NULL,
	IdTipoPrenda INT NOT NULL,
    CONSTRAINT FK_Prenda_TallaPrenda FOREIGN KEY (IdTallaPrenda) REFERENCES TallaPrenda(IdTallaPrenda),
	CONSTRAINT FK_Prenda_TipoPrenda FOREIGN KEY (IdTipoPrenda) REFERENCES TipoPrenda(IdTipoPrenda),
    CONSTRAINT FK_Prenda_Color FOREIGN KEY (IdColorPrenda) REFERENCES ColorPrenda(IdColorPrenda)
);

-- Crear la tabla "Venta"
CREATE TABLE Venta (
  IdVenta INT PRIMARY KEY IDENTITY,
  IdUsuario INT NOT NULL FOREIGN KEY REFERENCES Usuario(IdUsuario),
  IdCliente INT NOT NULL,
  Fecha DATE NOT NULL,
  IVA DECIMAL(10, 2),
  ISR DECIMAL(10, 2),
  Subtotal DECIMAL(10, 2),
  GastosOperacion DECIMAL(10, 2),
  Descuento DECIMAL(10, 2) DEFAULT 0,
  Total DECIMAL(10, 2),
  Ganancia DECIMAL(10, 2),
  FechaRegistro  datetime default getdate(),
  CONSTRAINT FK_Venta_IdCliente FOREIGN KEY (IdCliente) REFERENCES Cliente(IdCliente),
);

-- Crear la tabla "DetalleVenta"
CREATE TABLE DetalleVenta (
  IdDetalleVenta INT PRIMARY KEY IDENTITY,
  IdVenta INT NOT NULL FOREIGN KEY REFERENCES Venta(IdVenta),
  IdPrenda INT NOT NULL FOREIGN KEY REFERENCES Prenda(IdPrenda),
  Tinta DECIMAL(10, 2),
  Cantidad INT,
  Comision_ML_25 DECIMAL(10, 2),
  Comision_ML_15 DECIMAL(10, 2),
  Comision_TER DECIMAL(10, 2),
);

-- Creación de la entidad Compra
	CREATE TABLE Compra (
		IdCompra INT PRIMARY KEY IDENTITY(1,1),
		IdUsuario INT NOT NULL FOREIGN KEY REFERENCES Usuario(IdUsuario),
		Fecha  datetime default getdate(),
		Proveedor VARCHAR(50),
		Total INT NOT NULL,
		FechaRegistro  datetime default getdate(),
	);

	-- Creación de la entidad Compra
	CREATE TABLE DetalleCompra (
		IdDetalleCompra INT PRIMARY KEY IDENTITY(1,1),
		IdCompra INT NOT NULL FOREIGN KEY REFERENCES Compra(IdCompra),
		Fecha  datetime default getdate(),
		IdPrenda INT NOT NULL,
		Cantidad INT NOT NULL,
		PrecioCompra DECIMAL(10,2) NOT NULL,
		CONSTRAINT FK_Compra_Prenda FOREIGN KEY (IdPrenda) REFERENCES Prenda(IdPrenda)
	);

create PROC SP_REGISTRARUSUARIO(
	@NombreUsuario varchar(50),
	@ApellidoPaterno varchar (50),
	@ApellidoMaterno varchar(50),
	@NombreCompleto varchar(50),
	@Correo varchar(100),
	@Clave varchar(100),
	@IdUsuarioResultado int output,
	@Mensaje varchar(500) output
)
as
begin
	set @IdUsuarioResultado = 0
	set @Mensaje = ''
	if not exists(select*from Usuario WHERE NombreCompleto = @NombreCompleto)
	begin
		insert into Usuario(NombreUsuario,ApellidoPaterno,ApellidoMaterno,NombreCompleto,Correo,Clave) values
		(@NombreUsuario,@ApellidoPaterno,@ApellidoMaterno,@NombreCompleto,@Correo,@Clave)

		set @IdUsuarioResultado = SCOPE_IDENTITY()
	end
	else
		set @Mensaje = 'No se puede repetir el nombre completo para mas de un usuario'
end



select * from Usuario

CREATE PROC SP_EDITARUSUARIO(
	@IdUsuario int,
	@NombreUsuario varchar(50),
	@ApellidoPaterno varchar(50),
	@ApellidoMaterno varchar(50),
	@NombreCompleto varchar(50),
	@Correo varchar(100),
	@Clave varchar(100),
	@Respuesta bit output,
	@Mensaje varchar(500) output
)
as
begin
	set @Respuesta= 0
	set @Mensaje = ''

	if not exists(select*from Usuario WHERE NombreCompleto = @NombreCompleto and IdUsuario != @IdUsuario)
	begin
		update Usuario set
		NombreUsuario = @NombreUsuario,
		ApellidoPaterno = @ApellidoPaterno,
		ApellidoMaterno = @ApellidoMaterno,
		NombreCompleto = @NombreCompleto,
		Correo = @Correo,
		Clave = @Clave
		where IdUsuario = @IdUsuario

		set @Respuesta = 1
	end
	else
		set @Mensaje = 'No se puede repetir el nombre completo para mas de un usuario'
end


exec SP_REGISTRARUSUARIO 'NomUSUARIO','NomUSUARIOcompleto','qwer@gmail.com','admin'


/* ------------------------- Procedimientos para TipoPrenda ------------------- */

-- Procedimiento para guardar TipoPrenda --

CREATE PROC SP_RegistrarTipoPrenda(
 @Descripcion varchar(50),
 @Resultado int output,
 @Mensaje varchar(500) output)
 AS
 BEGIN
  set @Resultado = 0
  if NOT EXISTS (select * from TipoPrenda where Descripcion = @Descripcion)
  BEGIN
  	INSERT into TipoPrenda(Descripcion) values (@Descripcion)
  	set @Resultado = SCOPE_IDENTITY()
  END
  ELSE
  	SET @Mensaje = 'No se puede repetir la descripcion de un tipo de prenda'

END


-- Procedimiento para Modificar TipoPrenda --

CREATE PROC SP_EditarTipoPrenda(
 @IdTipoPrenda int,
 @Descripcion varchar(50),
 @Resultado bit output,
 @Mensaje varchar(500) output
 )
 AS
 BEGIN
  set @Resultado = 1
  IF NOT EXISTS (SELECT * FROM TipoPrenda where Descripcion = @Descripcion and IdTipoPrenda != @IdTipoPrenda)
  
  	UPDATE TipoPrenda SET
  	Descripcion = @Descripcion
  	where IdTipoPrenda = @IdTipoPrenda
  ELSE
  	BEGIN
  		SET @Resultado = 0
  		SET @Mensaje = 'No se puede repetir la descripcion de un tipo de prenda'
  	END

END

DECLARE @Resultado INT;
DECLARE @Mensaje VARCHAR(50);
EXEC SP_EditarTipoPrenda 
    @IdTipoPrenda = 1, 
    @Descripcion = 'Haola', 
    @Resultado = @Resultado OUTPUT,
    @Mensaje = @Mensaje OUTPUT;


UPDATE TipoPrenda SET
  	Descripcion ='Hola'
  	where IdTipoPrenda = 1 

-- Procedimiento para Eliminar TipoPrenda --

CREATE PROC SP_EliminarTipoPrenda(
 @IdTipoPrenda int,
 @Resultado bit output,
 @Mensaje varchar(500) output)
 AS
 BEGIN
  set @Resultado = 1
  IF NOT EXISTS(
    SELECT * FROM TipoPrenda T 
    INNER JOIN Prenda p on p.IdTipoPrenda = T.IdTipoPrenda
    WHERE T.IdTipoPrenda = @IdTipoPrenda)
  	BEGIN
  		DELETE TOP(1) FROM TipoPrenda WHERE IdTipoPrenda = @IdTipoPrenda
    END
    ELSE
  	BEGIN
  		SET @Resultado = 0
  		SET @Mensaje = 'El Tipo de prenda se encuentra asociada a una prenda'
  	END
END


select * from TipoPrenda

exec SP_RegistrarTipoPrenda('Playera manga larga')

INSERT INTO TipoPrenda (Descripcion) VALUES ('Camiseta');
INSERT INTO TipoPrenda (Descripcion) VALUES ('Pantalón');
INSERT INTO TipoPrenda (Descripcion) VALUES ('Vestido');

