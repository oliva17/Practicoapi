CREATE TABLE [dbo].[trnUsuario](
	[IdUsuario] [int] NULL,
	[NombreUsuario] [nvarchar](50) NULL,
	[Clave] [nvarchar](100) NULL,
	[Salt] [nvarchar](10) NULL,
	[FechaRegistro] [datetime] NULL,
	[EstadoRegistro] [bit] NULL
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[Roles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NombreRol] [nvarchar](max) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

INSERT INTO [dbo].[trnUsuario] ([IdUsuario], [NombreUsuario], [Clave], [Salt], [FechaRegistro], [EstadoRegistro])
VALUES 
(1, 'david', '91928327A2DD15B75D99FEF04D98B0FE1F21DC51', '123', GETDATE(),  1),
(2, 'oliva', '91928327A2DD15B75D99FEF04D98B0FE1F21DC51', '123', GETDATE(), 1);


DELETE FROM [dbo].[trnUsuario]
WHERE 
    ([IdUsuario] = 1 AND [NombreUsuario] = 'david' AND [Clave] = '91928327A2DD15B75D99FEF04D98B0FE1F21DC51' AND [Salt] = '123')
    OR
    ([IdUsuario] = 2 AND [NombreUsuario] = 'oliva' AND [Clave] = '91928327A2DD15B75D99FEF04D98B0FE1F21DC51' AND [Salt] = '123');
