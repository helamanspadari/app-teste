CREATE DATABASE testeDB

USE testeDB

CREATE TABLE Proprietario (
	Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR(MAX),
	Documento VARCHAR(MAX),
	Email VARCHAR(MAX),
	CEP VARCHAR(MAX),
	Endereco VARCHAR(MAX),
	Status BIT
)

CREATE TABLE Marca (
	Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR(MAX),
	Status BIT
)

CREATE TABLE Veiculo (
	Id int not null primary key identity(1,1),
	Renavam  VARCHAR(MAX),
    Modelo VARCHAR(MAX),
    AnoFabricacao INT,
    AnoModelo INT,
    Quilometragem FLOAT,
    Valor DECIMAL(18,2),
    Status INT,
    MarcaId INT NOT NULL,
	ProprietarioId INT NOT NULL

	CONSTRAINT FK_Marca_Veiculo
		FOREIGN KEY(MarcaId) REFERENCES Marca(Id),
	CONSTRAINT FK_Proprietario_Veiculo
		FOREIGN KEY(ProprietarioId) REFERENCES Proprietario(Id)
)
