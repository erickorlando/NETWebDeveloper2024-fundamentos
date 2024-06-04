IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Categorias] (
    [Id] int NOT NULL IDENTITY,
    [Nombre] nvarchar(max) NOT NULL,
    [Descripcion] nvarchar(max) NULL,
    CONSTRAINT [PK_Categorias] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Clientes] (
    [Id] int NOT NULL IDENTITY,
    [Nombre] nvarchar(max) NOT NULL,
    [Apellidos] nvarchar(max) NOT NULL,
    [Email] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Clientes] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Productos] (
    [Id] int NOT NULL IDENTITY,
    [Nombre] nvarchar(max) NOT NULL,
    [Precio] real NOT NULL,
    CONSTRAINT [PK_Productos] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240528020412_PrimeraMigracion', N'8.0.5');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Productos]') AND [c].[name] = N'Nombre');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Productos] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Productos] ALTER COLUMN [Nombre] nvarchar(100) NOT NULL;
GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Clientes]') AND [c].[name] = N'Nombre');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Clientes] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [Clientes] ALTER COLUMN [Nombre] nvarchar(100) NOT NULL;
GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Clientes]') AND [c].[name] = N'Email');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Clientes] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [Clientes] ALTER COLUMN [Email] nvarchar(500) NOT NULL;
GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Clientes]') AND [c].[name] = N'Apellidos');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Clientes] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [Clientes] ALTER COLUMN [Apellidos] nvarchar(100) NOT NULL;
GO

DECLARE @var4 sysname;
SELECT @var4 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Categorias]') AND [c].[name] = N'Nombre');
IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Categorias] DROP CONSTRAINT [' + @var4 + '];');
ALTER TABLE [Categorias] ALTER COLUMN [Nombre] nvarchar(50) NOT NULL;
GO

DECLARE @var5 sysname;
SELECT @var5 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Categorias]') AND [c].[name] = N'Descripcion');
IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [Categorias] DROP CONSTRAINT [' + @var5 + '];');
ALTER TABLE [Categorias] ALTER COLUMN [Descripcion] nvarchar(100) NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240528022315_SegundaMigracion', N'8.0.5');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Productos] ADD [CategoriaId] int NOT NULL DEFAULT 0;
GO

CREATE TABLE [Ventas] (
    [Id] int NOT NULL IDENTITY,
    [NumeroFactura] nvarchar(20) NOT NULL,
    [FechaVenta] datetime2 NOT NULL,
    [ClienteId] int NOT NULL,
    [TotalVenta] real NOT NULL,
    CONSTRAINT [PK_Ventas] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Ventas_Clientes_ClienteId] FOREIGN KEY ([ClienteId]) REFERENCES [Clientes] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [VentaDetalles] (
    [Id] int NOT NULL IDENTITY,
    [VentaId] int NOT NULL,
    [ProductoId] int NOT NULL,
    [PrecioUnitario] real NOT NULL,
    [Cantidad] int NOT NULL,
    [Total] real NOT NULL,
    CONSTRAINT [PK_VentaDetalles] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_VentaDetalles_Productos_ProductoId] FOREIGN KEY ([ProductoId]) REFERENCES [Productos] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_VentaDetalles_Ventas_VentaId] FOREIGN KEY ([VentaId]) REFERENCES [Ventas] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Productos_CategoriaId] ON [Productos] ([CategoriaId]);
GO

CREATE INDEX [IX_VentaDetalles_ProductoId] ON [VentaDetalles] ([ProductoId]);
GO

CREATE INDEX [IX_VentaDetalles_VentaId] ON [VentaDetalles] ([VentaId]);
GO

CREATE INDEX [IX_Ventas_ClienteId] ON [Ventas] ([ClienteId]);
GO

ALTER TABLE [Productos] ADD CONSTRAINT [FK_Productos_Categorias_CategoriaId] FOREIGN KEY ([CategoriaId]) REFERENCES [Categorias] ([Id]) ON DELETE CASCADE;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240528023457_TerceraMigracion', N'8.0.5');
GO

COMMIT;
GO

