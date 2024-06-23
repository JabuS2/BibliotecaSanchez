-- Criação do banco de dados (opcional se já existir)
CREATE DATABASE biblioteca;

-- Conexão ao banco de dados
\c biblioteca;

-- Tabela Autor
CREATE TABLE Autor (
    AutorId SERIAL PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    DataNascimento DATE NOT NULL
);

-- Tabela Livro
CREATE TABLE Livro (
    LivroId SERIAL PRIMARY KEY,
    Titulo VARCHAR(200) NOT NULL,
    AnoPublicacao INTEGER NOT NULL
);

-- Tabela AutorLivro (tabela associativa)
CREATE TABLE AutorLivro (
    AutorId INTEGER REFERENCES Autor(AutorId),
    LivroId INTEGER REFERENCES Livro(LivroId),
    PRIMARY KEY (AutorId, LivroId)
);

