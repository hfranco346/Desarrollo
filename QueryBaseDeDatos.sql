create database Pruebas
	go
use Pruebas
go

Create table [Alumno] (
	[Alumno_Id] Char(15) NOT NULL UNIQUE,
	[Alumno_PrimerNombre] Varchar(20) NOT NULL,
	[Alumno_SegundoNombre] Varchar(20) NOT NULL,
	[Alumno_PrimerApellido] Varchar(20) NULL,
	[Alumno_SegundoApellido] Varchar(20) NULL,
	[Alumno_FechaNacimiento] Datetime NOT NULL,
	[Alumno_FechaIngreso] Datetime NULL,
	[Alumno_Direccion] Text NOT NULL,
	[Alumno_TelefonoMobil] Char(9) NULL UNIQUE,
	[Alumno_Correo] Varchar(30) NULL UNIQUE,
	[Carrera_Id] Varchar(15) NOT NULL,
	[Nick] Text NULL,
	[Contrasena] Text NULL,
Constraint [pk_Alumno] Primary Key  ([Alumno_Id])
) 
go

Create table [Carrera] (
	[Carrera_Id] Varchar(15) NOT NULL UNIQUE,
	[Carrera_Nombre] Varchar(30) NULL,
	[Carrera_Descripcion] Text NULL,
Constraint [pk_Carrera] Primary Key  ([Carrera_Id])
) 
go

Create table [Clases] (
	[Clases_Id] Varchar(15) NOT NULL UNIQUE,
	[Clases_Nombre] Varchar(30) NOT NULL UNIQUE,
	[Clases_RequisitoPorcentaje] Bit NOT NULL,
	[Clases_Creditos] Integer NOT NULL,
	[Clases_Estado] Varchar(20) NULL,
	[Clases_Descripcion] Text NULL,
	[Clases_Periodo] Integer NOT NULL,
	[Clases_Requisito] Bit NULL,
	[Clases_Electiva] Bit NULL,
	[Clases_General] Bit NULL,
	[Carrera_Id] Varchar(15) NOT NULL,
Constraint [pk_Clases] Primary Key  ([Clases_Id],[Carrera_Id])
) 
go

Create table [Generales_Clases] (
	[Clases_Id] Varchar(15) NOT NULL,
	[Carrera_Id] Varchar(15) NOT NULL,
	[Carrera_Carrera_ID] Varchar(15) NULL,
Constraint [pk_Generales_Clases] Primary Key  ([Clases_Id],[Carrera_Id])
) 
go

Create table [Requisitos] (
	[Requisitos_CodigoClase] Varchar(15) NULL,
	[Requisitos_CodigoCarrera] Varchar(15) NULL,
	[Requisitos_CodigoClaseReq] Varchar(15) NULL,
	[Requisitos_CodigoCarreraReq] Varchar(15) NULL
) 
go

Create table [Notas] (
	[Alumno_Id] Char(15) NOT NULL,
	[Clases_Id] varchar(15) NOT NULL,
	[NIP] Decimal(3,2) NULL,
	[NIIP] Decimal(3,2) NULL,
	[NIIIP] Decimal(3,2) NULL,
	[Periodo] Integer NOT NULL,
	[Anio] Char(4) NOT NULL,
Constraint [pk_Notas] Primary Key  ([Alumno_Id])
) 
go

Alter table [Notas] add Constraint [FK_Alumno-Notas_AlumnoId] foreign key([Alumno_Id]) references [Alumno] ([Alumno_Id]) 
go
Alter table [Alumno] add Constraint [FK_Carrera-Alumno_CarreraId] foreign key([Carrera_Id]) references [Carrera] ([Carrera_Id]) 
go
Alter table [Clases] add Constraint [FK_Carrera-Clases_CarreraId] foreign key([Carrera_Id]) references [Carrera] ([Carrera_Id]) 
go
Alter table [Generales_Clases] add Constraint [FK_Clases-GeneralesClases_ClasesID_CarreraId] foreign key([Clases_Id],[Carrera_Id]) references [Clases] ([Clases_Id],[Carrera_Id]) 
go
Alter table [Generales_Clases] add Constraint [FK_Carrera-GeneralesClases_CarreraCarreraId] foreign key(Carrera_Carrera_ID) references [Carrera] ([Carrera_Id]) 
go
Alter table [Generales_Clases] add Constraint [FK_Carrera-GeneralesClases_CarreraCarreraId] foreign key(Carrera_Carrera_ID) references [Carrera] ([Carrera_Id]) 
go
Alter table [Requisitos] add Constraint [FK_Clases-Requisitos_RequisitosCodigoClase] foreign key(Requisitos_CodigoClase) references [Clases] ([Clases_Id]) 
go
Alter table [Requisitos] add Constraint [FK_Clases-Requisitos_RequisitosCodigoClaseReq] foreign key(Requisitos_CodigoClaseReq) references [Clases] ([Clases_Id]) 
go
Alter table [Requisitos] add Constraint [FK_Clases-Requisitos_RequisitosCodigoCarrera] foreign key(Requisitos_CodigoCarrera) references [Clases] ([Carrera_Id]) 
go
Alter table [Requisitos] add Constraint [FK_Clases-Requisitos_RequisitosCodigoCarreraReq] foreign key(Requisitos_CodigoCarreraReq) references [Clases] ([Carrera_Id]) 
go
Alter table [Notas] add Constraint [FK_Clases-Notas_ClasesId] foreign key(Clases_Id) references [Clases] ([Clases_Id]) 
go
