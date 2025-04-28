create table kulan�c�(
isim nvarchar(20),
soyisim nvarchar(20),
kulan�c�id int primary key not null,
kulan�c�Ad� nvarchar(50),
sifre nvarchar(50) not null
);
create table ila�(
ila�id int primary key not null,
ila�adi nvarchar(50) not null,
fiyat decimal(10,2) not null,
tarih date not null,
ila�neiseyarad��� nvarchar(max),
yanetkileri nvarchar(max),
kulan�c�id int not null
 FOREIGN KEY (kulan�c�id) REFERENCES kulan�c�(Kulan�c�id)

);


);
alter table ila�
add constraint fk_ila�_kulan�c� FOREIGN KEY(kulan�c�id) REFERENCES kulan�c�(kulan�c�id);

