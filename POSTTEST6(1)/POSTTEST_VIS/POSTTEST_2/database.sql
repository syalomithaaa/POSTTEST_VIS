
CREATE TABLE Pasien (
    idPasien INT PRIMARY KEY,
    namaPasien VARCHAR(50),
    alamat VARCHAR(100)
);

CREATE TABLE Antrian (
    idAntrian INT PRIMARY KEY IDENTITY(1,1),
    idPasien INT,
    tanggal DATE,
    keluhan VARCHAR(100),
    FOREIGN KEY (idPasien) REFERENCES Pasien(idPasien)
);
