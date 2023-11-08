USE  BDSISTEMA_INVENTARIO2

GO

DROP PROC CargarUsuario;
drop proc ModificarUsuario;
drop proc EliminarUsuario

CREATE PROC CargarProductos
AS
SELECT * FROM PRODUCTO;
GO

CREATE PROC ModificarProductos
	@NombreProducto nvarchar(50),
	@Marca nvarchar(50),
	@Stock int,
	@PrecioCompra decimal(10,2),
	@PrecioVenta decimal(10,2),
	@IdCategoria nvarchar (50),
	@TipoCategoria nvarchar (50),
	@IdProducto nvarchar(50)
AS
UPDATE PRODUCTO SET NombreProducto=@NombreProducto,Marca=@Marca,Stock=@Stock,PrecioCompra=@PrecioCompra,PrecioVenta=@PrecioVenta,IdCategoria=@IdCategoria,TipoCategoria=@TipoCategoria
WHERE IdProducto=@IdProducto

CREATE PROC EliminarProductos
@IdProducto nvarchar(50)
as
DELETE FROM PRODUCTO WHERE IdProducto=@IdProducto
GO

EXEC CargarProveedores;
EXEC ModificarProductos 'SUETER NEGRO','ADDIDAS',15,40000,40000,'001','ROPA','002'
EXEC EliminarProductos '003'


CREATE PROC CargarCategorias
AS
SELECT * FROM CATEGORIA;
GO

CREATE PROC ModificarCategoria
	@TipoCategoria nvarchar(50),
	@IdCategoria nvarchar(50)
AS
UPDATE CATEGORIA SET TipoCategoria=@TipoCategoria,IdCategoria=@IdCategoria
WHERE IdCategoria=@IdCategoria

CREATE PROC EliminarCategoria
@IdCategoria nvarchar(50)
as
DELETE FROM CATEGORIA WHERE IdCategoria=@IdCategoria
GO

EXEC CargarCategorias;
EXEC ModificarCategoria 'ROPA','001'
EXEC EliminarCategoria '002'

CREATE PROC CargarProveedores
AS
SELECT * FROM PROVEEDOR;
GO

CREATE PROC ModificarProveedor
	@Documento nvarchar(50),
	@RazonSocial nvarchar(50),
	@Correo nvarchar(50),
	@Telefono nvarchar(50),
	@IdProveedor nvarchar (50)
AS
UPDATE PROVEEDOR SET Documento=@Documento,RazonSocial=@RazonSocial,Correo=@Correo,Telefono=@Telefono,IdProveedor=@IdProveedor
WHERE IdProveedor=@IdProveedor

CREATE PROC EliminarProveedor
@IdProveedor nvarchar(50)
as
DELETE FROM PROVEEDOR WHERE IdProveedor=@IdProveedor
GO


EXEC ModificarCategoria 'ROPA'

CREATE PROC CargarUsuario
AS
SELECT * FROM USUARIO;
GO

CREATE PROC ModificarUsuario
@Usuario nvarchar(50),
@Contraseña nvarchar(50),
@Correo nvarchar(50),
@IdUsuario nvarchar (50)
AS
UPDATE USUARIO SET Usuario=@Usuario,Contraseña=@Contraseña,Correo=@Correo,IdUsuario=@IdUsuario
WHERE IdUsuario=@IdUsuario

CREATE PROC EliminarUsuario
@IdUsuario nvarchar(50)
as
DELETE FROM USUARIO WHERE IdUsuario=@IdUsuario
GO

EXEC CargarUsuario
EXEC ModifcarUsuario
EXEC EliminarUsuario

INSERT PROVEEDOR(IdProveedor,Documento,RazonSocial,Correo,Telefono)
VALUES('001','000001','PROVEEDOR 1','proveedor1@proveedores.pro.co','304032322');

DELETE PROVEEDOR
EXEC CargarProveedores;
select IdUsuario,Documento,Usuario,Contraseña from USUARIO where IdUsuario='001' and Documento='1066866495' and Usuario='alfredoperez' and Contraseña='alfredo7'

CREATE PROC CargarCliente
AS
SELECT * FROM CLIENTE
GO

EXEC CargarCliente

CREATE PROC ModificarCliente
@NombreCliente nvarchar(50),
@Correo nvarchar(50),
@Telefono nvarchar(50),
@IdCliente nvarchar (50)
AS
UPDATE CLIENTE SET NombreCliente=@NombreCliente,Correo=@Correo,Telefono=@Telefono,IdCliente=@IdCliente
WHERE IdCliente=@IdCliente

CREATE PROC EliminarCliente
@IdCliente nvarchar(50)
as
DELETE FROM CLIENTE WHERE IdCliente=@IdCliente
GO

DELETE PERMISO
INSERT PERMISO(IdPermiso,Permiso,IdRol,Rol)
VALUES('002','PERMISO 2','002','EMPLEADO');
SELECT IdPermiso,rol FROM PERMISO where Rol='ADMINISTRADOR'
SELECT * FROM PERMISO
CREATE PROC CargarPermiso
AS
	select p.IdRol,p.Permiso from PERMISO p
	inner join ROL r on r.IdRol = p.IdRol
	inner join USUARIO u on u.IdRol = r.IdRol
	where u.IdUsuario = '002'
GO

	select p.IdRol,p.Permiso from PERMISO p
	inner join ROL r on r.IdRol = p.IdRol
	inner join USUARIO u on u.IdRol = r.IdRol
	where u.IdUsuario = '001'

SELECT * FROM PERMISO

INSERT INTO PERMISO(IdPermiso,Permiso,IdRol,Rol) VALUES
('001','btnMenu','001','ADMINISTRADOR'),
('002','btnGestionProductos','001','ADMINISTRADOR'),
('003','btnGestionCategorias','001','ADMINISTRADOR'),
('004','btnGestionProveedores','001','ADMINISTRADOR'),
('005','btnGestionUsuarios','001','ADMINISTRADOR'),
('006','btnClientes','001','ADMINISTRADOR'),
('007','btnCompra','001','ADMINISTRADOR'),
('008','btnVenta','001','ADMINISTRADOR')

INSERT INTO PERMISO(IdPermiso,Permiso,IdRol,Rol) VALUES
('009','btnMenu','002','EMPLEADO'),
('010','btnGestionProductos','002','EMPLEADO'),
('011','btnGestionProveedores','002','EMPLEADO'),
('012','btnClientes','002','EMPLEADO'),
('013','btnCompra','002','EMPLEADO'),
('014','btnVenta','002','EMPLEADO')