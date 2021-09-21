create table hasarlý(
 hasarliid int not null,
 marka varchar(100),
 model varchar(100),
 yýl varchar(100),
 hasartipi varchar(100),
 primary key(hasarliid),
)

create table arac(
 aracid int not null,
 marka varchar(100),
 model varchar(100),
 yýl varchar(100),
 plaka varchar(100),
 primary key(aracid),
)

create table kiralama(
 musteriid int not null,
 isim varchar(100),
 soyisim varchar(100),
 telefon varchar(100),
 alýnantarih varchar(100),
 teslimtarih varchar(100),
 fiyat varchar(100),
 primary key(musteriid),
)

create table kullanýcýlar(
 kullanici int not null,
 isim varchar(100),
 sifre varchar(100),
 primary key(kullanici),
)

insert into kullanýcýlar(kullanici, isim, sifre)
values(1, 'Emirhan','nurgül3497');