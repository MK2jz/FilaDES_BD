create database fila; 

use fila; 

drop table controle; 

create table controle( 

nfila int auto_increment primary key, 
    nome varchar(15) not null, 
    idade int, 
    sexo varchar(1) 
    ); 

insert into controle (nome, idade, sexo) values 
('Paula', 9, 'F');

desc controle; 

select * from controle; 

delete from controle where nfila = 12;

