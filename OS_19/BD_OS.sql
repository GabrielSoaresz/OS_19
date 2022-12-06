create database OS_19;
use OS_19;

create table usuario(
id int unsigned auto_increment not null primary key,
nome varchar(80) default null,
email varchar(80) default null,
telefone varchar(18) default null,
senha varchar(50) default null,
setor int default null
)engine=innodb;

create table setor(
id int unsigned auto_increment not null primary key,
descricao varchar(100) default null
)engine=innodb;

create table tecnico(
id int unsigned auto_increment not null primary key,
nome varchar(80) default null,
email varchar(80) default null,
senha varchar(50) default null,
especialidade int default null
)engine=innodb;


create table especialidade(
id int unsigned auto_increment not null primary key,
descricao varchar(100) default null
)engine=innodb;

insert into setor values(null,'PROFESSOR');
insert into setor values(null,'ADMIN');
insert into setor values(null,'DIRETOR');
select * from usuario;

insert into especialidade values(null,'INFORMÁTICA');
insert into especialidade values(null,'ELÉTRICA');
insert into especialidade values(null,'REDES');

create table os(
id int unsigned auto_increment not null primary key,
descricao varchar(250) default null,
status_os varchar(50) default null,
tecnico_id int default null,
usuario_id int default null
)engine=innodb;