begin transaction;
GO

CREATE TABLE [titulo] (

[id_titulo] int identity(1,1) NOT NULL,

[titulo] varchar(100) NULL,

[fecha] date NULL,

[comentario] varchar(255) NULL,

[evaluacion] varchar(255) NULL,

[ubicacion] varchar(50) NULL,

[id_tipo] int NULL,

[id_clase] int NULL,

PRIMARY KEY ([id_titulo]) 

)

GO



CREATE TABLE [idiomas] (

[id_idioma] int identity(1,1) NOT NULL,

[nombre] varchar(30) NULL,

PRIMARY KEY ([id_idioma]) 

)

GO

CREATE TABLE [categoria] (

[id_categoria] int identity(1,1) NOT NULL,

[nombre] varchar(30) NULL,

PRIMARY KEY ([id_categoria]) 

)

GO



CREATE TABLE [clase] (

[id_clase] int identity(1,1) NOT NULL,

[tipo] varchar(15) NULL,

PRIMARY KEY ([id_clase]) 

)

GO



CREATE TABLE [tipo] (

[id_tipo] int identity(1,1) NOT NULL,

[nombre] varchar(15) NULL,

PRIMARY KEY ([id_tipo]) 

)

GO



CREATE TABLE [titulo_idioma_aud] (

[id_titulo] int identity(1,1) NOT NULL,

[id_idiomas] int NULL

)

GO



CREATE TABLE [titulo_idioma_sub] (

[id_titulo] int identity(1,1) NOT NULL,

[id_idiomas] int NULL

)

GO



CREATE TABLE [titulo_categoria] (

[id_titulo] int identity(1,1) NOT NULL,

[id_categoria] int NULL

)

GO





ALTER TABLE [titulo_idioma_aud] ADD CONSTRAINT [fk_idiomas_aud] FOREIGN KEY ([id_idiomas]) REFERENCES [idiomas] ([id_idioma])

GO

ALTER TABLE [titulo_idioma_aud] ADD CONSTRAINT [fk_titulo_idioma_aud] FOREIGN KEY ([id_titulo]) REFERENCES [titulo] ([id_titulo])

GO

ALTER TABLE [titulo_idioma_sub] ADD CONSTRAINT [fk_titulo_idioma_sub] FOREIGN KEY ([id_titulo]) REFERENCES [titulo] ([id_titulo])

GO

ALTER TABLE [titulo_categoria] ADD CONSTRAINT [fk_titulo_categoria] FOREIGN KEY ([id_titulo]) REFERENCES [titulo] ([id_titulo])

GO

ALTER TABLE [titulo] ADD CONSTRAINT [fk_titulo_tipo] FOREIGN KEY ([id_tipo]) REFERENCES [tipo] ([id_tipo])

GO

ALTER TABLE [titulo] ADD CONSTRAINT [fk_titulo_clase] FOREIGN KEY ([id_clase]) REFERENCES [clase] ([id_clase])

GO

ALTER TABLE [titulo_categoria] ADD CONSTRAINT [fk_categoria_ti_categ] FOREIGN KEY ([id_categoria]) REFERENCES [categoria] ([id_categoria])

GO

ALTER TABLE [titulo_idioma_sub] ADD CONSTRAINT [fk_idiomas_sub] FOREIGN KEY ([id_idiomas]) REFERENCES [idiomas] ([id_idioma])

GO

commit transaction;

GO