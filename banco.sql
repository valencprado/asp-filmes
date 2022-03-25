# Valentina Prado - 3B DS

# criando banco de dados
create database BDFilmesNoite;
# usando o banco
use BDFilmesNoite;

# criando as tabelas
create table tbGenero(
CodGen int primary key auto_increment,
Gen varchar(20)
);

create table tbDiretor(
CodDir int primary key auto_increment,
Diretor varchar(100)
);

create table tbFilmes (
CodFilme int primary key auto_increment,
Filme varchar(50),
CodDir int,
CodGen int,
foreign key (CodDir) references tbDiretor(CodDir),
foreign key (CodGen) references tbGenero(CodGen)
);


# inserindo gêneros
insert into tbGenero (CodGen, Gen) values (default, 'Terror');
insert into tbGenero (CodGen, Gen) values (default, 'Comédia');
insert into tbGenero (CodGen, Gen) values (default, 'Romance');
insert into tbGenero (CodGen, Gen) values (default, 'Infantil');

# inserindo diretores
insert into tbDiretor (CodDir, Diretor) values (default, 'Diretor 1');
insert into tbDiretor (CodDir, Diretor) values (default, 'Diretor 2');
insert into tbDiretor (CodDir, Diretor) values (default, 'Diretor 3');
insert into tbDiretor (CodDir, Diretor) values (default, 'Diretor 4');
insert into tbDiretor (CodDir, Diretor) values (default, 'Diretor 5');
insert into tbDiretor (CodDir, Diretor) values (default, 'Diretor 6');
