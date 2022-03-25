# Valentina Prado - 3B DS

# criando banco de dados
create database BDFilmesNoite;
# usando o banco
use BDFilmesNoite;

# criando as tabelas
create table tb_genero(
cod_gen int primary key auto_increment,
gen varchar(20)
);

create table tb_diretor(
cod_dir int primary key auto_increment,
dir varchar(100)
);

create table tb_filmes (
cod_filme int primary key auto_increment,
filme varchar(50),
cod_dir int,
cod_gen int,
foreign key (cod_dir) references tb_diretor(cod_dir),
foreign key (cod_gen) references tb_genero(cod_gen)
);


# inserindo gêneros
insert into tb_genero (cod_gen, gen) values (default, 'Terror');
insert into tb_genero (cod_gen, gen) values (default, 'Comédia');
insert into tb_genero (cod_gen, gen) values (default, 'Romance');
insert into tb_genero (cod_gen, gen) values (default, 'Infantil');

# inserindo diretores
insert into tb_diretor (cod_dir, dir) values (default, 'Diretor 1');
insert into tb_diretor (cod_dir, dir) values (default, 'Diretor 2');
insert into tb_diretor (cod_dir, dir) values (default, 'Diretor 3');
insert into tb_diretor (cod_dir, dir) values (default, 'Diretor 4');
insert into tb_diretor (cod_dir, dir) values (default, 'Diretor 5');
insert into tb_diretor (cod_dir, dir) values (default, 'Diretor 6');

# mostrando os dados das tabelas

select * from tb_diretor;
select * from tb_genero;


