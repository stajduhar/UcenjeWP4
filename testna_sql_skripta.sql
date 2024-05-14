create database testna_baza_vjezbanje_git;

use testna_baza_vjezbanje_git;

create table tablica_1(
sifra int not null primary key identity(1,1),
ime varchar(100) not null,
);


create table grupe(
sifra int not null primary key identity(1,1),
ime varchar(20) not null,
prezime varchar(20) not null,
);



