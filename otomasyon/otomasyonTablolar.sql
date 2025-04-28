create table kulanýcý(
isim nvarchar(20),
soyisim nvarchar(20),
kulanýcýid int primary key not null,
kulanýcýAdý nvarchar(50),
sifre nvarchar(50) not null
);
create table ilaç(
ilaçid int primary key not null,
ilaçadi nvarchar(50) not null,
fiyat decimal(10,2) not null,
tarih date not null,
ilaçneiseyaradýðý nvarchar(max),
yanetkileri nvarchar(max),
kulanýcýid int not null
 FOREIGN KEY (kulanýcýid) REFERENCES kulanýcý(Kulanýcýid)

);


);
alter table ilaç
add constraint fk_ilaç_kulanýcý FOREIGN KEY(kulanýcýid) REFERENCES kulanýcý(kulanýcýid);

