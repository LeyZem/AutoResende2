CREATE TABLE [dbo].[Cliente] (
    [idCliente]      INT          NOT NULL,
    [Nome]           VARCHAR (50) NOT NULL,
    [CPF]            VARCHAR (50) NOT NULL,
    [RG]             VARCHAR (50) NOT NULL,
    [OrgaoExpedidor] VARCHAR (50) NOT NULL,
    [DataNascimento] DATE         NOT NULL,
    [Logradouro]     VARCHAR (50) NOT NULL,
    [Bairro]         VARCHAR (50) NOT NULL,
    [Cidade]         VARCHAR (50) NOT NULL,
    [UF]             VARCHAR (50) NOT NULL,
    [CEP]            VARCHAR (50) NOT NULL,
    [TelRes]         VARCHAR (50) NULL,
    [TelCel]         VARCHAR (50) NULL,
    [email]          VARCHAR (50) NULL,
    [Comentario] VARCHAR(50) NULL, 
    CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED ([idCliente] ASC)
);

