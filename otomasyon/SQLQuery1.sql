CREATE TABLE Randevu (
    RandevuID INT PRIMARY KEY IDENTITY(1,1),
    Kullan�c�Ad� NVARCHAR(50) NOT NULL,
    Tarih DATE NOT NULL,
    Saat TIME NOT NULL,
    B�l�m NVARCHAR(50) NOT NULL,
    Doktor NVARCHAR(50) NOT NULL,
    CONSTRAINT UQ_Randevu UNIQUE (Tarih, Saat, Doktor)
);