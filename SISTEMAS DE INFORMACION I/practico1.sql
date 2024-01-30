use SistemasDeInformacion
CREATE TABLE EgresoDetalle (
    IdEgreso INT,
    IdInsumo INT,
    Cantidad INT,
    PrecioUnitario DECIMAL,
    Subtotal DECIMAL,
    IdIngresoDetalle INT,
    IdSolicitudDetalle INT,
    Observaciones VARCHAR(255),
    FechaRegistro DATE,
    EstadoRegistro VARCHAR(255)
);

CREATE TABLE Egreso (
    IdEgreso INT,
    NumeroEgreso INT,
    FechaReal DATE,
    FechaEgreso DATE,
    Observaciones VARCHAR(255),
    Total DECIMAL,
    IdGrupoArticulo INT,
    IdUnidadSolicitante INT,
    IdGestion INT,
    IdUsuarioEgreso INT,
    IdAlmacen INT,
    IdEstadoEgreso INT,
    IdSolicitud INT,
    FechaRegistro DATE,
    EstadoRegistro VARCHAR(255)
);