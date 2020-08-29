create database [SceneIt]
go

use [SceneIt]
go 

create table [Users] (
	UserId int identity(1,1) Primary key,
	Name nvarchar(50) not null	 
)
go

create table [Movies](
	MovieId int identity(1,1) Primary key,
	Title nvarchar(255) not null,
	[Year] nvarchar(20) null,
	Rated nvarchar(255) null,
	Released Date null,
	Runtime nvarchar(255) null,
	Genre nvarchar(255) null,
	Director nvarchar(255) null,
	Writer nvarchar(500) null,
	Actors nvarchar(500) null,
	Plot nvarchar(1000) null,
	[Language] nvarchar(500) null,
	Country nvarchar(100) null,
	Awards nvarchar(255) null,
	Poster nvarchar(1000) null,
	Metascore nvarchar(20) null,
	ImdbRating nvarchar(20) null,
	ImdbVotes nvarchar(50) null,
	ImdbId nvarchar(50) not null,
	[Type] nvarchar(50) null,
	Dvd nvarchar(255) null,
	BoxOffice nvarchar(255) null,
	Production nvarchar(255) null,
)
go

create table UserMovies(
	UserMovieId int identity(1,1) Primary key,
	UserId int not null foreign key references Users(UserId),
	MovieId int not null foreign key references Movies(MovieId),
	Owned bit not null,
	HasSeen bit not null,
	Recommend bit null,
	RecommendNotes nvarchar(255) null
)
go


