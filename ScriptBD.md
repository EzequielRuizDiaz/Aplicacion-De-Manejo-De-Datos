USE [GFacHojilla]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](25) NOT NULL,
	[Direccion] [varchar](25) NULL,
	[Rut] [int] NULL,
	[Telefono] [varchar](25) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Entregas](
	[IdEntrega] [int] IDENTITY(1,1) NOT NULL,
	[IdVendedor] [int] NOT NULL,
	[IdHojilla] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[CantCajas] [int] NOT NULL,
	[Nombre_De_Producto] [varchar](25) NOT NULL,
	[NombreDeVendedor] [varchar](25) NOT NULL,
	[ImporteTotal] [money] NOT NULL,
 CONSTRAINT [PK_Entregas_1] PRIMARY KEY CLUSTERED 
(
	[IdEntrega] ASC,
	[IdVendedor] ASC,
	[IdHojilla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mercaderia]    Script Date: 05/05/2020 20:49:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mercaderia](
	[IdHojilla] [int] IDENTITY(1,1) NOT NULL,
	[NombreDeProducto] [varchar](25) NOT NULL,
	[PrecioVenta] [money] NOT NULL,
	[CantidadxCaja] [int] NOT NULL,
	[GananciaPorCaja] [money] NOT NULL,
 CONSTRAINT [PK_Mercaderia_1] PRIMARY KEY CLUSTERED 
(
	[IdHojilla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](25) NOT NULL,
	[Apellido] [varchar](25) NOT NULL,
	[NombreDeUsuario] [varchar](25) NOT NULL,
	[Contraseña] [varchar](20) NOT NULL,
	[TipoDeAccseso] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Usuarios_1] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Vendedor]    Script Date: 05/05/2020 20:49:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vendedor](
	[IdVendedor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](22) NOT NULL,
	[Apellido] [varchar](25) NOT NULL,
	[Direccion] [varchar](25) NOT NULL,
	[Telefono] [varchar](22) NOT NULL,
	[Cedula] [varchar](18) NOT NULL,
 CONSTRAINT [PK_Vendedor] PRIMARY KEY CLUSTERED 
(
	[IdVendedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 05/05/2020 20:49:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ventas](
	[IdEntrega] [int] NOT NULL,
	[IdHojilla] [int] NOT NULL,
	[IdVenta] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[IdVendedor] [int] NOT NULL,
	[NombreDeCliente] [varchar](25) NULL,
	[Fecha] [date] NOT NULL,
	[CantxCaja] [money] NOT NULL,
	[Importe] [money] NOT NULL,
	[Ganancia] [money] NOT NULL,
 CONSTRAINT [PK_Ventas] PRIMARY KEY CLUSTERED 
(
	[IdEntrega] ASC,
	[IdHojilla] ASC,
	[IdVenta] ASC,
	[IdCliente] ASC,
	[IdVendedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Entregas]  WITH CHECK ADD  CONSTRAINT [FK_Entregas_Mercaderia] FOREIGN KEY([IdHojilla])
REFERENCES [dbo].[Mercaderia] ([IdHojilla])
GO
ALTER TABLE [dbo].[Entregas] CHECK CONSTRAINT [FK_Entregas_Mercaderia]
GO
ALTER TABLE [dbo].[Entregas]  WITH CHECK ADD  CONSTRAINT [FK_Entregas_Vendedor] FOREIGN KEY([IdVendedor])
REFERENCES [dbo].[Vendedor] ([IdVendedor])
GO
ALTER TABLE [dbo].[Entregas] CHECK CONSTRAINT [FK_Entregas_Vendedor]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Clientes] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Clientes] ([IdCliente])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Clientes]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Vendedor] FOREIGN KEY([IdVendedor])
REFERENCES [dbo].[Vendedor] ([IdVendedor])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Vendedor]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[AgregarCliente]

@Nombres varchar(25),
@Direccion varchar(25), 
@Rut int, 
@Telefono int
As
  Begin
     Insert Into Clientes values (@Nombres,@Direccion,@Rut,@Telefono)
	 --Mensaje que se mostrará cuando se Inserte un Registro
	 Raiserror ('El nuevo Cliente ha sido agregado correctamente', 16,1) 					
  End

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[AgregarEntregaso]
    @IdVendedor int, 
    @IdHojilla int,
	@Fecha date,
	@CantCajas int,
	@Nombre_De_Producto varchar(25),
	@NombreDeVendedor varchar(25),
	@ImporteTotal money
	
As
  Begin
     Insert Into Entregas values (@IdVendedor, @IdHojilla, @Fecha, @CantCajas, @Nombre_De_Producto, @NombreDeVendedor, @ImporteTotal)
	 --Mensaje que se mostrará cuando se Inserte un Registro
	 Raiserror ('La Entrega ha sido agregada correctamente', 16,1) 					
  End

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[AgregarMerca]


@NombreDeProducto varchar(25),
@PrecioVenta money,
@CantidadxCaja int,
@GananciaPorCaja money




 As
  Begin
     Insert Into Mercaderia values (@NombreDeProducto,@PrecioVenta,@CantidadxCaja,@GananciaPorCaja)
	 --Mensaje que se mostrará cuando se Inserte un Registro
	 Raiserror ('La Mercaderia ha sido Agregada Correctamente', 16,1) 					
  End

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[AgregarUsuarioo]

@Nombre varchar(25),
	@Apellido varchar(25),
	@NombreDeUsuario varchar(25),
	@Contraseña varchar(20),
	@TipoDeAccseso varchar(20)
As
  Begin
     Insert Into Usuarios values (@Nombre,@Apellido,@NombreDeUsuario,@Contraseña,@TipoDeAccseso)
	 --Mensaje que se mostrará cuando se Inserte un Registro
	 Raiserror ('El Usuario ha sido Ingresado correctamente', 16,1) 					
  End

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[AgregarVendedor]


@Nombres varchar(22),
@Apellidos varchar(25),
@Direccion varchar(25),
@Telefono varchar(22),

@Cedula varchar(18)




 As
  Begin
     Insert Into Vendedor values (@Nombres, @Apellidos  ,@Direccion,@Telefono,@Cedula)
	 --Mensaje que se mostrará cuando se Inserte un Registro
	 Raiserror ('El nuevo Vendedor ha sido agregado correctamente', 16,1) 					
  End

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BorrarClientee]
(
	@Original_IdCliente int
)
AS
	SET NOCOUNT OFF;
DELETE FROM Clientes
WHERE        (IdCliente = @Original_IdCliente)
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BorrarEntrega]
(
	@Original_IdEntrega int
)
AS
	SET NOCOUNT OFF;
DELETE FROM Entregas
WHERE        (IdEntrega = @Original_IdEntrega)
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[BorrarMerca]
@Original_IdHojilla int
As
  Begin
     Delete From	Mercaderia Where IdHojilla = @Original_IdHojilla
	 --Mensaje que se mostrará cuando se Borre un Registro
	 Raiserror ('La Mercaderia fue borrada correctamente', 16,1) 					
  End


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[BorrarUsuarioo]
@ID int
As
  Begin
     Delete From Usuarios Where IdUsuario = @ID
	 --Mensaje que se mostrará cuando se Borre un Registro
	 Raiserror ('El Usuario se ha elimino correctamente', 16,1) 					
  End

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BorrarVende]
(
	@Original_IdVendedor int
)
AS
	SET NOCOUNT OFF;
DELETE FROM Vendedor
WHERE        (IdVendedor = @Original_IdVendedor) 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[ModificarClientee]
@IdCliente int,
@Nombres varchar(25),
@Direccion varchar(25), 
@Rut int, 
@Telefono int
As
  Begin
    Update Clientes Set Nombre = @Nombres, Direccion = @Direccion, Rut = @Rut,Telefono = @Telefono
	Where IdCliente=@IdCliente
	--Mensaje que se mostrará cuando se Actualice un Registro
	 Raiserror ('Los Datos del Cliente fueron Actualizados correctamente', 16,1)
  End

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[ModificarEntrega]
    @IdEntrega int,
	@IdVendedor int, 
    @IdHojilla int,
	@Fecha date,
	@CantCajas int,
	@Nombre_De_Producto varchar(25),
	@NombreDeVendedor varchar(25),
	@ImporteTotal money
	

As
  Begin
    Update Entregas Set IdVendedor = @IdVendedor, IdHojilla = @IdHojilla, Fecha = @Fecha, CantCajas = @CantCajas,Nombre_De_Producto=@Nombre_De_Producto,@NombreDeVendedor=@NombreDeVendedor,ImporteTotal=@ImporteTotal
	Where IdEntrega = @IdEntrega
	--Mensaje que se mostrará cuando se Actualice un Registro
	 Raiserror ('Los Datos dW LA Entrega fueron Modificados correctamente', 16,1)
  End

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[ModificarMerca]
@IdHojilla int,
@NombreDeProducto varchar(25),
@PrecioVenta money,
@CantidadxCaja int,
@GananciaPorCaja money

As
  Begin
    Update Mercaderia Set PrecioVenta = @PrecioVenta ,CantidadxCaja = @CantidadxCaja, GananciaPorCaja = @GananciaPorCaja,NombreDeProducto = @NombreDeProducto
	Where  IdHojilla = @IdHojilla
	--Mensaje que se mostrará cuando se Actualice un Registro
	 Raiserror ('La Mercaderia  fue Modificada correctamente', 16,1)
  End

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[ModificarUsuario]
@ID int,
@Nombre varchar(25),
@Apellido varchar(25),
@NombreDeUsuario varchar(25),
@Contraseña varchar(20),
@TipoDeAccseso varchar(20)

As
  Begin
    Update Usuarios Set Nombre = @Nombre, Apellido = @Apellido, NombreDeUsuario = @NombreDeUsuario, Contraseña = @Contraseña,TipoDeAccseso=@TipoDeAccseso
	Where IdUsuario=@ID 
	--Mensaje que se mostrará cuando se Actualice un Registro
	 Raiserror ('Los Datos del Usuario fueron Modificados correctamente', 16,1)
  End

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[ModificarVendedores]
@IdVendedor int ,
@Nombres varchar(22),
@Apellidos varchar(22),
@Telefono varchar(22),
@Direccion varchar(25),
@Cedula varchar(18)

As
  Begin
    Update Vendedor Set Nombre = @Nombres, Direccion = @Direccion, Apellido = @Apellidos, Cedula = @Cedula,Telefono = @Telefono
	Where IdVendedor = @IdVendedor
	--Mensaje que se mostrará cuando se Actualice un Registro
	 Raiserror ('Los Datos del Vendedor fueron Modificados correctamente', 16,1)
  End

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[ValidarUsuario]
@Usuario varchar (25),
@Password varchar(20)
As
Begin
Select * From Usuarios Where NombreDeUsuario = @Usuario And Contraseña = @Password
End

GO
