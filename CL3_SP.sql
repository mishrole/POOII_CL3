-- Listar Marcas
CREATE PROCEDURE SP_MARCAS_LISTAR
AS
	SELECT IdMarca, Nombre
	FROM dbo.Marca
GO

-- Listado General de Veh�culos
CREATE PROCEDURE SP_VEHICULOS_LISTAR
AS
	SELECT
	V.IdVehiculo,
	V.Placa,
	V.A�o,
	V.Modelo,
	V.IdMarca,
	M.Nombre
	FROM dbo.Vehiculo AS V INNER JOIN dbo.Marca AS M
	ON V.IdMarca = M.IdMarca
GO

-- Registro de nuevo Veh�culo

CREATE PROCEDURE SP_VEHICULOS_REGISTRAR
@Placa varchar(20),
@A�o int,
@Modelo varchar(50),
@IdMarca int
AS
	INSERT INTO dbo.Vehiculo(Placa, A�o, Modelo, IdMarca)
	VALUES(@Placa, @A�o, @Modelo, @IdMarca)
GO

-- Actualizaci�n de registro de Veh�culo

CREATE PROCEDURE SP_VEHICULOS_ACTUALIZAR
@Placa varchar(20),
@A�o int,
@Modelo varchar(50),
@IdMarca int,
@IdVehiculo int
AS
	UPDATE dbo.Vehiculo
	SET Placa = @Placa, A�o = @A�o, Modelo = @Modelo, IdMarca = @IdMarca
	WHERE IdVehiculo = @IdVehiculo
GO

-- Detalle de Veh�culo

CREATE PROCEDURE SP_VEHICULOS_OBTENER
@IdVehiculo int
AS
	SELECT
	IdVehiculo,
	Placa,
	A�o,
	Modelo,
	IdMarca
	FROM dbo.Vehiculo
	WHERE IdVehiculo = @IdVehiculo
GO

-- Eliminaci�n de registro de Veh�culo

CREATE PROCEDURE SP_VEHICULOS_ELIMINAR
@IdVehiculo int
AS
	DELETE FROM dbo.Vehiculo WHERE IdVehiculo = @IdVehiculo
GO