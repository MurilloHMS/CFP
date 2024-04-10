
CREATE DATABASE FinanceiroKingdomDB;

USE FinanceiroKingdomDB;

CREATE TABLE Members (
    ID INT PRIMARY KEY IDENTITY(1, 1),
    Nome NVARCHAR(100) NOT NULL CONSTRAINT Nome_Length CHECK (LEN(Nome) <= 100),
    Email NVARCHAR(100) NOT NULL UNIQUE,
    Telefone NVARCHAR(MAX) NOT NULL,
    DataDeNascimento NVARCHAR(MAX) NOT NULL,
    PerguntaECristao NVARCHAR(MAX) NOT NULL,
    PerguntaFrequentaIgreja NVARCHAR(MAX) NOT NULL,
    CEP NVARCHAR(MAX) NOT NULL,
    Rua NVARCHAR(100) NOT NULL CONSTRAINT Rua_Length CHECK (LEN(Rua) <= 100),
    Numero NVARCHAR(6) NOT NULL CONSTRAINT Numero_Length CHECK (LEN(Numero) <= 6),
    Bairro NVARCHAR(100) NOT NULL CONSTRAINT Bairro_Length CHECK (LEN(Bairro) <= 100),
    Cidade NVARCHAR(100) NOT NULL CONSTRAINT Cidade_Length CHECK (LEN(Cidade) <= 100),
    UF NVARCHAR(2) NOT NULL CONSTRAINT UF_Length CHECK (LEN(UF) <= 2),
    Complemento NVARCHAR(100) NOT NULL CONSTRAINT Complemento_Length CHECK (LEN(Complemento) <= 100)
);


CREATE TABLE Financeiros (
    ID INT PRIMARY KEY IDENTITY(1, 1),
    TipoLancamento NVARCHAR(MAX) NOT NULL,
    Valor DECIMAL(18, 2) NOT NULL,
    DataVencimento DATETIME NULL,
    TipoEvento NVARCHAR(MAX) NOT NULL,
    Categoria NVARCHAR(MAX) NOT NULL,
    Descricao NVARCHAR(MAX) NULL,
    DataEntrada DATETIME NULL 
);
