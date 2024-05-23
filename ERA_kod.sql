use master;
go
drop database if exists audio_library;
go
create database audio_library;
go

use audio_library;
create table audio_library_account(
id int not null primary key identity(1,1),
username varchar(40) not null,
first_name varchar(40) not null,
last_name varchar(40) not null,
date_of_birth datetime,
email_account varchar(40) not null,
favorite_genre int not null
);


create table genre(
id int not null primary key identity(1,1),
);


create table book(
id int not null primary key identity(1,1),
the_title_of_the_book varchar(20) not null,
author_of_the_book int not null,
book_genre int not null
);


create table author(
id int not null primary key identity(1,1),
date_of_birth datetime,
book_genre int not null,
first_name varchar(40) not null,
last_name varchar(40) not null,
nationality varchar(40) not null
);


alter table audio_library_account add foreign key (favorite_genre) references genre(id);

alter table book add foreign key (book_genre) references genre(id);

alter table author add foreign key (book_genre) references genre(id);

alter table book add foreign key (author_of_the_book) references author(id);