create database OS_3A2;
use OS_3A2;

create table usuario (
	ID int unsigned auto_increment not null primary key,
    nome varchar(80) default null,
    email varchar(80) default null,
    senha varchar(50) default null,
    telefone varchar(18) default null,
    setor int default null
);

create table setor (
	id int unsigned auto_increment not null primary key,
    descricao varchar(100) default null
);

create table tecnico (
	id int unsigned auto_increment not null primary key,
    nome varchar(80) default null,
    email varchar(80) default null,
    senha varchar(50) default null,
    especialidade int default null
);

create table especialidade (
	id int unsigned auto_increment not null primary key,
    descricao varchar(100) default null
);

create table OS(
	id int unsigned auto_increment not null primary key,
    descricao varchar(100) default null,
    status_os varchar(250) default null,
    tecnico int null default null,
    usuario int null default null
);

insert into setor values (null,'Setor1');
insert into setor values (null,'Setor2');
insert into setor values (null,'Setor3');

select * from tecnico;
select * from usuario;
select * from especialidade;
select * from setor;

select * from OS;