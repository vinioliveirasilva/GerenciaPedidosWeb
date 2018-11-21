login:ENGSOFT
senha:Engenhariasoft

alter session set "_ORACLE_SCRIPT"=true; 

/* CREATE TABLE COMMANDS */

CREATE TABLE Cliente (
	Cnpj varchar(11) NOT NULL
	,EmpEnd varchar(100)
    ,EmpNome varchar(100) NOT NULL
    ,TelCel varchar(13)
    ,TelEmp varchar(12) NOT NULL
    ,Contato varchar(50) NOT NULL
    ,Email varchar(50) NOT NULL
    ,PRIMARY KEY(Cnpj)
)

CREATE TABLE Funcionario (
	Cpf varchar(11) NOT NULL
	,Nome varchar(50) NOT NULL
	,Email varchar(50)
	,TelCel varchar(13)
	,End varchar(50)
	,PRIMARY KEY(Cpf)
)

CREATE TABLE Usuario (
	Id varchar(11) NOT NULL
	,Nome varchar(50) NOT NULL
	,Senha varchar(256) NOT NULL
	,PRIMARY KEY(Id)
)

CREATE TABLE Servico (
	Id int GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1)
	,Nome varchar(40) NOT NULL
	,PRIMARY KEY(Id)
)

CREATE TABLE Chamado (
	Id int GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1)
	,Titulo varchar(80)
	,Problema varchar(1000)
	,Status int
	,Prioridade int
	,Data_Abertura varchar(30)
	,Data_Fechamento varchar(30)
	,IdCliente varchar(11)
	,PRIMARY KEY(Id)
	FOREIGN KEY(IdCliente)
	REFERENCES Cliente(Cnpj)
 )
 
CREATE TABLE Comentario (
	Id int GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1),
	IdChamado int NOT NULL,
	Usuario varchar(11) NOT NULL,
	PRIMARY KEY(Id),
	FOREIGN KEY(IdChamado)
	REFERENCES Chamado(Id)
)

/* DUMMY DATA INSERTS */

