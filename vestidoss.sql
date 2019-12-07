USE Rentas
CREATE TABLE vestidoss(
IDrenta bigint NOT NULL UNIQUE,
Responsable varchar(50) NOT NULL,
Fecha_prestamo varchar(50) NOT NULL,
Fecha_entrega varchar (50) NOT NULL,
Descripcion varchar (70) NOT NULL,
Monto varchar(50) NOT NULL
)