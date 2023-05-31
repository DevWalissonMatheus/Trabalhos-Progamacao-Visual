create database pecas;
use pecas;

create table cadastrar (
id_peca int not null auto_increment,
numero_serie int not null,
nome_peca varchar(50) not null,
fabricante varchar(50) not null,
modelo varchar(50) not null,
primary key (id_peca)
)

select * from cadastrar;