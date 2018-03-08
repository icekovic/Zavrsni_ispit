create database ZavrsniIspit
go

use ZavrsniIspit
go

create table Pasmina
(
	IDPasmina int primary key identity not null,
	Naziv nvarchar(30) not null unique	--ista pasmina ne smije biti unešena više puta - unique constraint
)
insert into Pasmina values('Simentalska')
insert into Pasmina values('Holstein')
insert into Pasmina values('Domaca obicna')

create table Slika
(
	IDSlika int primary key identity not null,
	NazivSlike nvarchar(50) not null,
	Putanja nvarchar(200) not null
)

insert into Slika values('Milka.jpg', '/Slike/Milka.jpg')
insert into Slika values('Kata.jpg', '/Slike/Kata.jpg')
insert into Slika values('Sara.jpg', '/Slike/Sara.jpg')
insert into Slika values('Stefa.jpg', '/Slike/Stefa.jpg')
insert into Slika values('Cveta.jpg', '/Slike/Cveta.jpg')

select* from Slika

create table Krava
(
	IDKrava int primary key identity not null,
	Ime nvarchar(20) not null,
	DatumRodjenja date not null,
	DatumDolaskaNaFarmu date not null,
	JedinstveniVeterinarskiBroj nvarchar(10) not null check (JedinstveniVeterinarskiBroj like 'HR%'),
	BrojTeladi int not null,
	PasminaID int not null foreign key references Pasmina(IDPasmina),
	SlikaID int not null foreign key references Slika(IDSlika)
)

insert into Krava values('Milka', '2016-08-12', '2017-05-20', 'HR64178319', 2, 1, 1)
insert into Krava values('Kata', '2015-02-07', '2016-09-14', 'HR93718419', 1, 1, 2)
insert into Krava values('Sara', '2016-08-12', '2017-05-20', 'HR64178319', 3, 2, 3)
insert into Krava values('Stefa', '2016-03-01', '2017-10-12', 'HR41594561', 2, 2, 4)
insert into Krava values('Cveta', '2016-10-17', '2017-09-09', 'HR71830196', 3, 3, 5)

create table DnevnaProizvodnjaMlijeka
(
	IDDnevnaProizvodnjaMlijeka int primary key identity not null,
	DnevnaKolicinaMlijekaLitre int not null,
	ProsjecniPostotakMasnoce float not null,
	ProsjecniPostotakMikroorganizama float not null,
	DatumMuznje date not null,
	KravaID int not null foreign key  references Krava(IDKrava)
)

insert into DnevnaProizvodnjaMlijeka values (10, 1.23, 0.4, '2016-09-10', 1)
insert into DnevnaProizvodnjaMlijeka values (15, 1.07, 0.2, '2016-12-20',  1)
insert into DnevnaProizvodnjaMlijeka values (13, 1.10, 0.3, '2016-10-11',  5)
insert into DnevnaProizvodnjaMlijeka values (9, 0.91, 0.1, '2017-10-06',  2)
insert into DnevnaProizvodnjaMlijeka values (20, 1.17, 0.4, '2016-12-10', 2)
insert into DnevnaProizvodnjaMlijeka values (25, 1.30, 0.9, '2015-04-28',  3)
insert into DnevnaProizvodnjaMlijeka values (33, 1.04, 0.4, '2017-09-11', 3)
insert into DnevnaProizvodnjaMlijeka values (11, 1.03, 0.3, '2015-05-29', 4)
insert into DnevnaProizvodnjaMlijeka values (26, 1.40, 0.01, '2017-09-05', 4)
insert into DnevnaProizvodnjaMlijeka values (21, 1.26, 0.02, '2016-06-28', 5)

--SQL> CREATE TABLE student_info(
--	no NUMBER(3) PRIMARY KEY,
-- 	stu_code VARCHAR(10) CHECK (stu_code like 'j%'), - zapocinje sa j
-- 	name VARCHAR(30) CHECK ( name = upper(name) ), - vrijednost ima sva velika slova
--	city VARCHAR(30) CHECK (city IN ('Houston','San Antonio','Boston','Miami')) - vrijednost mora biti neka od navedenih
--	scholarship NUMBER(5) CHECK (scholarship BETWEEN 5000 AND 20000) - vrijednost mora biti u rasponu
--  Product_id varchar2(6) CHECK ( SUBSTR(Product_id,1,1) = 'P') - prvi znak mora biti P, ostali mogu biti bilo koji
--);


--procedure

go

create procedure DnevnaProsjecnaKolicinaMlijeka
	@Godina int
as
select ROUND(AVG(CAST(DnevnaKolicinaMlijekaLitre as float)), 2)	--zaokruživanje na dvije decimale
from DnevnaProizvodnjaMlijeka
where YEAR(DatumMuznje) = @Godina

go

create procedure KraveZadanaGodinaViseOdDvadesetLitaraMlijeka
	@Godina int
as
select
	Ime as 'Krava',
	DatumRodjenja as 'Datum rodjenja',
	DatumDolaskaNaFarmu as 'Datum dolaska na farmu',
	JedinstveniVeterinarskiBroj as 'Jedinstveni veterinarski broj',
	BrojTeladi as 'Broj teladi',
	ROUND(AVG(CAST(DnevnaKolicinaMlijekaLitre as float)), 2) as 'Prosjecna kolicina mlijeka'
from Krava
inner join DnevnaProizvodnjaMlijeka on IDKrava = KravaID
where YEAR(DatumMuznje) = @Godina
group by Ime, DatumRodjenja, DatumDolaskaNaFarmu, JedinstveniVeterinarskiBroj, BrojTeladi
having ROUND(AVG(CAST(DnevnaKolicinaMlijekaLitre as float)), 2) > 20

exec KraveZadanaGodinaViseOdDvadesetLitaraMlijeka 2017

select Naziv
from Pasmina inner join Krava on PasminaID = IDPasmina
where Ime = 'Milka'