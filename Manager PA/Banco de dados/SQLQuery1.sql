CREATE TABLE Cadastro_usuarios(
cod_user INT IDENTITY,
usuario_nome VARCHAR(60) NOT NULL,
usuario_user VARCHAR(10) NOT NULL,
usuario_senha VARCHAR(15) NOT NULL,
PRIMARY KEY(cod_user)
);