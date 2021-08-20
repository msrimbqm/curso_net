
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/20/2021 17:04:40
-- Generated from EDMX file: C:\Users\Tarde\Desktop\CURSONETGIT\msrimbqm\curso_net\modelFirst2\modelfirst2\modelfirst2\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ModelFirst2];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_NIVEL_RIESGOPUESTO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PUESTOSet] DROP CONSTRAINT [FK_NIVEL_RIESGOPUESTO];
GO
IF OBJECT_ID(N'[dbo].[FK_TIPO_DE_DEDUCCIONREGISTRO_TRANSACCIN_DEDUCCION]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[REGISTRO_TRANSACCIN_DEDUCCIONSet] DROP CONSTRAINT [FK_TIPO_DE_DEDUCCIONREGISTRO_TRANSACCIN_DEDUCCION];
GO
IF OBJECT_ID(N'[dbo].[FK_TIPO_DE_INGRESOREGISTRO_TRANSACCION]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[REGISTRO_TRANSACCIONSet] DROP CONSTRAINT [FK_TIPO_DE_INGRESOREGISTRO_TRANSACCION];
GO
IF OBJECT_ID(N'[dbo].[FK_EMPLEADOREGISTRO_TRANSACCIN_DEDUCCION]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[REGISTRO_TRANSACCIN_DEDUCCIONSet] DROP CONSTRAINT [FK_EMPLEADOREGISTRO_TRANSACCIN_DEDUCCION];
GO
IF OBJECT_ID(N'[dbo].[FK_PUESTOEMPLEADO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EMPLEADOSet] DROP CONSTRAINT [FK_PUESTOEMPLEADO];
GO
IF OBJECT_ID(N'[dbo].[FK_EMPLEADOREGISTRO_TRANSACCION]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[REGISTRO_TRANSACCIONSet] DROP CONSTRAINT [FK_EMPLEADOREGISTRO_TRANSACCION];
GO
IF OBJECT_ID(N'[dbo].[FK_DEPARTAMENTOEMPLEADO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EMPLEADOSet] DROP CONSTRAINT [FK_DEPARTAMENTOEMPLEADO];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[PUESTOSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PUESTOSet];
GO
IF OBJECT_ID(N'[dbo].[NIVEL_RIESGOSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NIVEL_RIESGOSet];
GO
IF OBJECT_ID(N'[dbo].[REGISTRO_TRANSACCIN_DEDUCCIONSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[REGISTRO_TRANSACCIN_DEDUCCIONSet];
GO
IF OBJECT_ID(N'[dbo].[TIPO_DE_DEDUCCIONSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TIPO_DE_DEDUCCIONSet];
GO
IF OBJECT_ID(N'[dbo].[REGISTRO_TRANSACCIONSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[REGISTRO_TRANSACCIONSet];
GO
IF OBJECT_ID(N'[dbo].[TIPO_DE_INGRESOSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TIPO_DE_INGRESOSet];
GO
IF OBJECT_ID(N'[dbo].[DEPARTAMENTOSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DEPARTAMENTOSet];
GO
IF OBJECT_ID(N'[dbo].[EMPLEADOSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EMPLEADOSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PUESTOSet'
CREATE TABLE [dbo].[PUESTOSet] (
    [Id_Puesto] int IDENTITY(1,1) NOT NULL,
    [Nombre_Puesto] nvarchar(max)  NOT NULL,
    [Id_Nivel_Riesgo] int  NOT NULL,
    [Nivel_Salario_Min] int  NOT NULL,
    [Nivel_Salario_Max] int  NOT NULL
);
GO

-- Creating table 'NIVEL_RIESGOSet'
CREATE TABLE [dbo].[NIVEL_RIESGOSet] (
    [Id_Nivel_Riesgo] int IDENTITY(1,1) NOT NULL,
    [Tipo_Riesgo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'REGISTRO_TRANSACCIN_DEDUCCIONSet'
CREATE TABLE [dbo].[REGISTRO_TRANSACCIN_DEDUCCIONSet] (
    [Id_Transaccion_Deduccion] int IDENTITY(1,1) NOT NULL,
    [Id_Empleado] int  NOT NULL,
    [Id_Tipo_Deduccion] int  NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Monto] float  NOT NULL,
    [EMPLEADO_Id_Empleado] int  NOT NULL
);
GO

-- Creating table 'TIPO_DE_DEDUCCIONSet'
CREATE TABLE [dbo].[TIPO_DE_DEDUCCIONSet] (
    [Id_Tipo_Deduccion] int IDENTITY(1,1) NOT NULL,
    [Nombre_Tipo_Deduccion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'REGISTRO_TRANSACCIONSet'
CREATE TABLE [dbo].[REGISTRO_TRANSACCIONSet] (
    [Id_Transaccion_Ingreso] int IDENTITY(1,1) NOT NULL,
    [Id_Empleado] int  NOT NULL,
    [Id_Tipo_Ingreso] int  NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Monto] float  NOT NULL
);
GO

-- Creating table 'TIPO_DE_INGRESOSet'
CREATE TABLE [dbo].[TIPO_DE_INGRESOSet] (
    [Id_Tipo_Ingreso] int IDENTITY(1,1) NOT NULL,
    [Nombre_Tipo_Deduccion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DEPARTAMENTOSet'
CREATE TABLE [dbo].[DEPARTAMENTOSet] (
    [Id_Departamento] int IDENTITY(1,1) NOT NULL,
    [Nombre_Departamento] nvarchar(max)  NOT NULL,
    [Ubicacion_Fiscal_Departa] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EMPLEADOSet'
CREATE TABLE [dbo].[EMPLEADOSet] (
    [Id_Empleado] int IDENTITY(1,1) NOT NULL,
    [Cod_Empleado] nvarchar(max)  NOT NULL,
    [Nombre_Empleado] nvarchar(max)  NOT NULL,
    [Id_Departamento] int  NOT NULL,
    [Id_Puesto] int  NOT NULL,
    [Salario_Mensual_Emplea] float  NOT NULL,
    [Cedula_Empleado] nvarchar(max)  NOT NULL,
    [Responsable_Area] nvarchar(max)  NOT NULL,
    [DEPARTAMENTO_Id_Departamento] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id_Puesto] in table 'PUESTOSet'
ALTER TABLE [dbo].[PUESTOSet]
ADD CONSTRAINT [PK_PUESTOSet]
    PRIMARY KEY CLUSTERED ([Id_Puesto] ASC);
GO

-- Creating primary key on [Id_Nivel_Riesgo] in table 'NIVEL_RIESGOSet'
ALTER TABLE [dbo].[NIVEL_RIESGOSet]
ADD CONSTRAINT [PK_NIVEL_RIESGOSet]
    PRIMARY KEY CLUSTERED ([Id_Nivel_Riesgo] ASC);
GO

-- Creating primary key on [Id_Transaccion_Deduccion] in table 'REGISTRO_TRANSACCIN_DEDUCCIONSet'
ALTER TABLE [dbo].[REGISTRO_TRANSACCIN_DEDUCCIONSet]
ADD CONSTRAINT [PK_REGISTRO_TRANSACCIN_DEDUCCIONSet]
    PRIMARY KEY CLUSTERED ([Id_Transaccion_Deduccion] ASC);
GO

-- Creating primary key on [Id_Tipo_Deduccion] in table 'TIPO_DE_DEDUCCIONSet'
ALTER TABLE [dbo].[TIPO_DE_DEDUCCIONSet]
ADD CONSTRAINT [PK_TIPO_DE_DEDUCCIONSet]
    PRIMARY KEY CLUSTERED ([Id_Tipo_Deduccion] ASC);
GO

-- Creating primary key on [Id_Transaccion_Ingreso] in table 'REGISTRO_TRANSACCIONSet'
ALTER TABLE [dbo].[REGISTRO_TRANSACCIONSet]
ADD CONSTRAINT [PK_REGISTRO_TRANSACCIONSet]
    PRIMARY KEY CLUSTERED ([Id_Transaccion_Ingreso] ASC);
GO

-- Creating primary key on [Id_Tipo_Ingreso] in table 'TIPO_DE_INGRESOSet'
ALTER TABLE [dbo].[TIPO_DE_INGRESOSet]
ADD CONSTRAINT [PK_TIPO_DE_INGRESOSet]
    PRIMARY KEY CLUSTERED ([Id_Tipo_Ingreso] ASC);
GO

-- Creating primary key on [Id_Departamento] in table 'DEPARTAMENTOSet'
ALTER TABLE [dbo].[DEPARTAMENTOSet]
ADD CONSTRAINT [PK_DEPARTAMENTOSet]
    PRIMARY KEY CLUSTERED ([Id_Departamento] ASC);
GO

-- Creating primary key on [Id_Empleado] in table 'EMPLEADOSet'
ALTER TABLE [dbo].[EMPLEADOSet]
ADD CONSTRAINT [PK_EMPLEADOSet]
    PRIMARY KEY CLUSTERED ([Id_Empleado] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Id_Nivel_Riesgo] in table 'PUESTOSet'
ALTER TABLE [dbo].[PUESTOSet]
ADD CONSTRAINT [FK_NIVEL_RIESGOPUESTO]
    FOREIGN KEY ([Id_Nivel_Riesgo])
    REFERENCES [dbo].[NIVEL_RIESGOSet]
        ([Id_Nivel_Riesgo])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NIVEL_RIESGOPUESTO'
CREATE INDEX [IX_FK_NIVEL_RIESGOPUESTO]
ON [dbo].[PUESTOSet]
    ([Id_Nivel_Riesgo]);
GO

-- Creating foreign key on [Id_Tipo_Deduccion] in table 'REGISTRO_TRANSACCIN_DEDUCCIONSet'
ALTER TABLE [dbo].[REGISTRO_TRANSACCIN_DEDUCCIONSet]
ADD CONSTRAINT [FK_TIPO_DE_DEDUCCIONREGISTRO_TRANSACCIN_DEDUCCION]
    FOREIGN KEY ([Id_Tipo_Deduccion])
    REFERENCES [dbo].[TIPO_DE_DEDUCCIONSet]
        ([Id_Tipo_Deduccion])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TIPO_DE_DEDUCCIONREGISTRO_TRANSACCIN_DEDUCCION'
CREATE INDEX [IX_FK_TIPO_DE_DEDUCCIONREGISTRO_TRANSACCIN_DEDUCCION]
ON [dbo].[REGISTRO_TRANSACCIN_DEDUCCIONSet]
    ([Id_Tipo_Deduccion]);
GO

-- Creating foreign key on [Id_Tipo_Ingreso] in table 'REGISTRO_TRANSACCIONSet'
ALTER TABLE [dbo].[REGISTRO_TRANSACCIONSet]
ADD CONSTRAINT [FK_TIPO_DE_INGRESOREGISTRO_TRANSACCION]
    FOREIGN KEY ([Id_Tipo_Ingreso])
    REFERENCES [dbo].[TIPO_DE_INGRESOSet]
        ([Id_Tipo_Ingreso])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TIPO_DE_INGRESOREGISTRO_TRANSACCION'
CREATE INDEX [IX_FK_TIPO_DE_INGRESOREGISTRO_TRANSACCION]
ON [dbo].[REGISTRO_TRANSACCIONSet]
    ([Id_Tipo_Ingreso]);
GO

-- Creating foreign key on [EMPLEADO_Id_Empleado] in table 'REGISTRO_TRANSACCIN_DEDUCCIONSet'
ALTER TABLE [dbo].[REGISTRO_TRANSACCIN_DEDUCCIONSet]
ADD CONSTRAINT [FK_EMPLEADOREGISTRO_TRANSACCIN_DEDUCCION]
    FOREIGN KEY ([EMPLEADO_Id_Empleado])
    REFERENCES [dbo].[EMPLEADOSet]
        ([Id_Empleado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EMPLEADOREGISTRO_TRANSACCIN_DEDUCCION'
CREATE INDEX [IX_FK_EMPLEADOREGISTRO_TRANSACCIN_DEDUCCION]
ON [dbo].[REGISTRO_TRANSACCIN_DEDUCCIONSet]
    ([EMPLEADO_Id_Empleado]);
GO

-- Creating foreign key on [Id_Puesto] in table 'EMPLEADOSet'
ALTER TABLE [dbo].[EMPLEADOSet]
ADD CONSTRAINT [FK_PUESTOEMPLEADO]
    FOREIGN KEY ([Id_Puesto])
    REFERENCES [dbo].[PUESTOSet]
        ([Id_Puesto])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PUESTOEMPLEADO'
CREATE INDEX [IX_FK_PUESTOEMPLEADO]
ON [dbo].[EMPLEADOSet]
    ([Id_Puesto]);
GO

-- Creating foreign key on [Id_Empleado] in table 'REGISTRO_TRANSACCIONSet'
ALTER TABLE [dbo].[REGISTRO_TRANSACCIONSet]
ADD CONSTRAINT [FK_EMPLEADOREGISTRO_TRANSACCION]
    FOREIGN KEY ([Id_Empleado])
    REFERENCES [dbo].[EMPLEADOSet]
        ([Id_Empleado])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EMPLEADOREGISTRO_TRANSACCION'
CREATE INDEX [IX_FK_EMPLEADOREGISTRO_TRANSACCION]
ON [dbo].[REGISTRO_TRANSACCIONSet]
    ([Id_Empleado]);
GO

-- Creating foreign key on [DEPARTAMENTO_Id_Departamento] in table 'EMPLEADOSet'
ALTER TABLE [dbo].[EMPLEADOSet]
ADD CONSTRAINT [FK_DEPARTAMENTOEMPLEADO]
    FOREIGN KEY ([DEPARTAMENTO_Id_Departamento])
    REFERENCES [dbo].[DEPARTAMENTOSet]
        ([Id_Departamento])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DEPARTAMENTOEMPLEADO'
CREATE INDEX [IX_FK_DEPARTAMENTOEMPLEADO]
ON [dbo].[EMPLEADOSet]
    ([DEPARTAMENTO_Id_Departamento]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------