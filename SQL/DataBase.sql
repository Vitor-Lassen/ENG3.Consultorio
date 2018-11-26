CREATE DATABASE CONSULTORIO

USING CONSULTORIO

CREATE TABLE USUARIO
(
PK_USUARIO INT PRIMARY KEY,
USUARIO VARCHAR(10) NOT NULL,
SENHA VARCHAR(30) NOT NULL,
ACESSO VARCHAR(1) NOT NULL,
);

CREATE TABLE ENDERECO
(
PK_ENDERECO INT PRIMARY KEY IDENTITY(1,1),
CEP INT NOT NULL,
NUMERO INT NOT NULL,
COMPLEMENTO VARCHAR(20),
);

CREATE TABLE TELEFONE
(
PK_TELEFONE INT PRIMARY KEY,
TELEFONE VARCHAR(11),
Type smallInt
);

CREATE TABLE SECRETARIA 
(
PK_SECRETARIA INT PRIMARY KEY,
NOME VARCHAR(50) NOT NULL,
FK_LOGIN_ID INT REFERENCES LOGIN(PK_USUARIO),
FK_ENDERECO_ID INT REFERENCES ENDERECO(PK_ENDERECO),
);

CREATE TABLE SECRETARIA_TELEFONE
(
PK_TELEFONE_SECRETARIA INT PRIMARY KEY,
FK_SECRETARIA_ID INT REFERENCES SECRETARIA(PK_CPF),
FK_TELEFONE_ID INT REFERENCES TELEFONE(PK_TELEFONE),
);

CREATE TABLE CONVENIO
(
PK_CONVENIO INT PRIMARY KEY,
NOME VARCHAR(20) NOT NULL,
);

CREATE TABLE PACIENTE
(
PK_PACIENTE INT PRIMARY KEY,
NOME VARCHAR(50) NOT NULL,
FK_LOGIN_ID INT REFERENCES LOGIN(PK_USUARIO),
FK_ENDERECO_ID INT REFERENCES ENDERECO(PK_ENDERECO),
FK_CONVENIO_ID INT REFERENCES CONVENIO(PK_CONVENIO),
);

CREATE TABLE PACIENTE_TELEFONE
(
PK_TELEFONE_PACIENTE INT PRIMARY KEY,
FK_PACIENTE_ID INT REFERENCES PACIENTE(PK_PACIENTE),
FK_TELEFONE_ID INT REFERENCES TELEFONE(PK_TELEFONE),
);

CREATE TABLE MEDICO
(
PK_CRM INT PRIMARY KEY,
NOME VARCHAR(50) NOT NULL,
ESPECIALIDADE VARCHAR(20) NOT NULL,
FK_LOGIN_ID INT REFERENCES USUARIO(PK_USUARIO),
FK_ENDERECO_ID INT REFERENCES ENDERECO(PK_ENDERECO),
);

CREATE TABLE MEDICO_TELEFONE
(
PK_TELEFONE_MEDICO INT PRIMARY KEY identity(1,1),
FK_CRM INT REFERENCES MEDICO(PK_CRM),
FK_TELEFONE_ID INT REFERENCES TELEFONE(PK_TELEFONE),
);

CREATE TABLE CONSULTA
(
PK_CONSULTA INT PRIMARY KEY,
DT_HR_INICIO DATETIME NOT NULL,
DT_HR_FIM DATETIME NOT NULL,
TIPO_CONSULTA VARCHAR(30) NOT NULL,
VALOR DOUBLE(10,2) NOT NULL,
TIPO_PAGAMENTO VARCHAR(10) NOT NULL,
QUITADO BOOLEAN NOT NULL,
FK_SECRETARIA_ID INT REFERENCES SECRETARIA(PK_SECRETARIA),
FK_MEDICO_ID INT REFERENCES MEDICO(PK_MEDICO),
FK_PACIENTE_ID INT REFERENCES PACIENTE(PK_PACIENTE),
);

CREATE TABLE EXAME
(
PK_EXAME INT PRIMARY KEY,
DT_HR_INICIO DATETIME NOT NULL,
TIPO_EXAME VARCHAR(30) NOT NULL,
FK_CONSULTA_ID INT REFERENCES CONSULTA(PK_CONSULTA),
);

CREATE TABLE MATERIAL
(
PK_MATERIAL INT PRIMARY KEY,
NOME VARCHAR(30) NOT NULL,
);

CREATE TABLE CONSULTA_MATERIAL
(
PK_CONSULTA_MATERIAL INT PRIMARY KEY, 
FK_CONSULTA_ID INT REFERENCES CONSULTA(PK_CONSULTA),
FK_MATERIAL_ID INT REFERENCES MATERIAL(PK_MATERIAL),
);

CREATE TABLE EXAME_MATERIAL
(
PK_EXAME_MATERIAL INT PRIMARY KEY,
FK_EXAME_ID INT REFERENCES CONSULTA(PK_CONSULTA),
FK_MATERIAL_ID INT REFERENCES MATERIAL(PK_MATERIAL),
);